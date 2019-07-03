using System;
using System.Collections.Concurrent;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Threading.Tasks;
using Livet.Annotations;

namespace Livet.Behaviors
{
    /// <summary>
    ///     ビヘイビア・トリガー・アクションでのメソッド直接バインディングを可能にするためのクラスです。<br />
    ///     引数の無いメソッドを実行します。メソッドの実行は最大限キャッシュされます。
    /// </summary>
    public class MethodBinder
    {
        [NotNull] private static readonly ConcurrentDictionary<Type, ConcurrentDictionary<string, Action<object>>>
            MethodCacheDictionary = new ConcurrentDictionary<Type, ConcurrentDictionary<string, Action<object>>>();

        private Action<object> _method;
        private MethodInfo _methodInfo;
        private string _methodName;
        private Type _targetObjectType;

        public void Invoke([NotNull] object targetObject, [NotNull] string methodName)
        {
            if (targetObject == null) throw new ArgumentNullException(nameof(targetObject));
            if (methodName == null) throw new ArgumentNullException(nameof(methodName));

            var newTargetObjectType = targetObject.GetType();

            if (_targetObjectType == newTargetObjectType && _methodName == methodName)
            {
                if (_method != null)
                {
                    _method(targetObject);
                    return;
                }

                if (TryGetCacheFromMethodCacheDictionary(out _method))
                {
                    _method(targetObject);
                    return;
                }

                if (_methodInfo != null)
                {
                    _methodInfo.Invoke(targetObject, new object[] { });
                    return;
                }
            }

            _targetObjectType = newTargetObjectType;
            _methodName = methodName;

            if (TryGetCacheFromMethodCacheDictionary(out _method))
            {
                _method(targetObject);
                return;
            }

            _methodInfo = _targetObjectType.GetMethods()
                .FirstOrDefault(method =>
                {
                    if (method.Name != methodName) return false;

                    var parameters = method.GetParameters();

                    if (parameters.Length != 0) return false;

                    return method.ReturnType == typeof(void);
                });

            if (_methodInfo == null)
                throw new ArgumentException(string.Format(
                    "{0} 型に 引数を持たないメソッド {1} が見つかりません。",
                    _targetObjectType.Name,
                    methodName));

            _methodInfo.Invoke(targetObject, new object[] { });


            var taskArgument = new Tuple<Type, MethodInfo>(_targetObjectType, _methodInfo);

            Task.Factory.StartNew(arg =>
            {
                var taskArg = (Tuple<Type, MethodInfo>) arg;

                var paraTarget = Expression.Parameter(typeof(object), "target");

                var method = Expression.Lambda<Action<object>>
                (
                    Expression.Call
                    (
                        Expression.Convert(paraTarget, taskArg.Item1),
                        taskArg.Item2
                    ),
                    paraTarget
                ).Compile();

                var dic = MethodCacheDictionary.GetOrAdd(taskArg.Item1,
                    _ => new ConcurrentDictionary<string, Action<object>>());
                dic.TryAdd(taskArg.Item2.Name, method);
            }, taskArgument);
        }

        private bool TryGetCacheFromMethodCacheDictionary(out Action<object> m)
        {
            m = null;
            var foundAction = false;
            ConcurrentDictionary<string, Action<object>> actionDictionary;
            if (MethodCacheDictionary.TryGetValue(_targetObjectType, out actionDictionary))
                foundAction = actionDictionary.TryGetValue(_methodName, out m);

            return foundAction;
        }
    }
}