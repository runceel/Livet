using System;
using System.Linq;
using System.Collections.Concurrent;
using System.Reflection;
using System.Threading.Tasks;
using System.Linq.Expressions;

namespace Livet.Behaviors
{
    /// <summary>
    /// ビヘイビア・トリガー・アクションでのメソッド直接バインディングを可能にするためのクラスです。<br/>
    /// 引数の無いメソッドを実行します。メソッドの実行は最大限キャッシュされます。
    /// </summary>
    public class MethodBinder
    {
        private static ConcurrentDictionary<Type, ConcurrentDictionary<string, Action<object>>> _methodCacheDictionary = new ConcurrentDictionary<Type, ConcurrentDictionary<string, Action<object>>>();

        private string _methodName;

        private Type _targetObjectType;

        private MethodInfo _methodInfo;
        private Action<object> _method;

        public void Invoke(object targetObject, string methodName)
        {
            if (targetObject == null) throw new ArgumentNullException("targetObject");
            if (methodName == null) throw new ArgumentNullException("methodName");

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
            {
                throw new ArgumentException(string.Format(
                "{0} 型に 引数を持たないメソッド {1} が見つかりません。",
                _targetObjectType.Name,
                methodName));
            }

            _methodInfo.Invoke(targetObject, new object[] { });


            var taskArgument = new Tuple<Type, MethodInfo>(_targetObjectType, _methodInfo);

            Task.Factory.StartNew(arg =>
                {
                    var taskArg = (Tuple<Type, MethodInfo>)arg;

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

                    var dic = _methodCacheDictionary.GetOrAdd(taskArg.Item1, _ => new ConcurrentDictionary<string, Action<object>>());
                    dic.TryAdd(taskArg.Item2.Name, method);
                },taskArgument);
        }

        private bool TryGetCacheFromMethodCacheDictionary(out Action<object> m)
        {
            m = null;
            var foundAction = false;
            ConcurrentDictionary<string, Action<object>> actionDictionary;
            if (_methodCacheDictionary.TryGetValue(_targetObjectType, out actionDictionary))
            {
                foundAction = actionDictionary.TryGetValue(_methodName, out m);
            }

            return foundAction;
        }
    }
}
