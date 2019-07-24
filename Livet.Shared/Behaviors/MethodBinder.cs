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

                if (TryGetCacheFromMethodCacheDictionary(out _method) && _method != null)
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

            if (TryGetCacheFromMethodCacheDictionary(out _method) && _method != null)
            {
                _method(targetObject);
                return;
            }

            _methodInfo = _targetObjectType?
                .GetMethods()
                .FirstOrDefault(method => method.Name == methodName
                                          && method.GetParameters().Length == 0
                                          && method.ReturnType == typeof(void));

            if (_methodInfo == null)
            {
                var message = $"{_targetObjectType?.Name} 型に 引数を持たないメソッド {methodName} が見つかりません。";
                throw new ArgumentException(message);
            }

            _methodInfo.Invoke(targetObject, new object[] { });

            var taskArgument = new Tuple<Type, MethodInfo>(_targetObjectType, _methodInfo);

            Task.Factory.StartNew(arg =>
            {
                if (arg == null) throw new ArgumentNullException(nameof(arg));

                var taskArg = (Tuple<Type, MethodInfo>) arg;
                var paraTarget = Expression.Parameter(typeof(object), "target");

                var method = Expression.Lambda<Action<object>>
                (
                    Expression.Call
                    (
                        Expression.Convert(paraTarget, taskArg.Item1 ?? throw new ArgumentException()),
                        taskArg.Item2 ?? throw new ArgumentException()
                    ),
                    paraTarget
                ).Compile();

                var dic = MethodCacheDictionary.GetOrAdd(taskArg.Item1,
                              _ => new ConcurrentDictionary<string, Action<object>>())
                          ?? throw new InvalidOperationException();
                dic.TryAdd(taskArg.Item2.Name, method);
            }, taskArgument);
        }

        private bool TryGetCacheFromMethodCacheDictionary(out Action<object> m)
        {
            if (_targetObjectType == null) throw new InvalidOperationException($"{nameof(_targetObjectType)} is null.");
            if (_methodName == null) throw new InvalidOperationException($"{nameof(_methodName)} is null.");

            m = null;
            var foundAction = false;
            if (MethodCacheDictionary.TryGetValue(_targetObjectType, out var actionDictionary))
                foundAction = actionDictionary.TryGetValue(_methodName, out m);

            return foundAction;
        }
    }
}