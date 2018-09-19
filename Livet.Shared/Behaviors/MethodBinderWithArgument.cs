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
    /// 引数が一つだけ存在するメソッドを実行します。メソッドの実行は最大限キャッシュされます。
    /// </summary>
    public class MethodBinderWithArgument
    {
        private static ConcurrentDictionary<Type, ConcurrentDictionary<string, Action<object,object>>> _methodCacheDictionary = new ConcurrentDictionary<Type, ConcurrentDictionary<string, Action<object,object>>>();

        private string _methodName;

        private Type _targetObjectType;
        private Type _argumentType;

        private MethodInfo _methodInfo;
        private Action<object,object> _method;

        public void Invoke(object targetObject, string methodName,object argument)
        {
            if (targetObject == null) throw new ArgumentNullException("targetObject");
            if (methodName == null) throw new ArgumentNullException("methodName");

            var newTargetObjectType = targetObject.GetType();
            var newArgumentType = argument.GetType();

            if (_targetObjectType == newTargetObjectType && 
                _methodName == methodName &&
                _argumentType == newArgumentType)
            {
                if (_method != null)
                {
                    _method(targetObject,argument);
                    return;
                }

                if (TryGetCacheFromMethodCacheDictionary(out _method))
                {
                    _method(targetObject, argument);
                    return;
                }

                if (_methodInfo != null)
                {
                    _methodInfo.Invoke(targetObject, new[] { argument });
                    return;
                }
            }

            _targetObjectType = newTargetObjectType;
            _argumentType = newArgumentType;
            _methodName = methodName;

            if (TryGetCacheFromMethodCacheDictionary(out _method))
            {
                _method(targetObject, argument);
                return;
            }

            _methodInfo = _targetObjectType.GetMethods()
                .FirstOrDefault(method =>
                {
                    if (method.Name != methodName) return false;

                    var parameters = method.GetParameters();

                    if (parameters.Length != 1) return false;

                    if (parameters[0].ParameterType.IsInterface)
                    {
                        if (!newArgumentType.GetInterfaces().Contains(parameters[0].ParameterType)) return false;
                    }
                    else
                    {
                        if ((!_argumentType.IsSubclassOf(parameters[0].ParameterType)) && (_argumentType != parameters[0].ParameterType)) return false;
                    }

                    return method.ReturnType == typeof(void);
                });

            if (_methodInfo == null)
            {
                throw new ArgumentException(string.Format(
                    "{0} 型に {1} 型の引数を一つだけ持つメソッド {2} が見つかりません。",
                    _targetObjectType.Name,
                    _argumentType.Name,
                    methodName));
            }

            _methodInfo.Invoke(targetObject, new[] {argument });

            var taskArgument = new Tuple<Type, MethodInfo, Type>(_targetObjectType, _methodInfo, _methodInfo.GetParameters()[0].ParameterType);

            Task.Factory.StartNew(arg =>
            {
                var taskArg = (Tuple<Type, MethodInfo, Type>)arg;

                var paraTarget = Expression.Parameter(typeof(object), "target");
                var paraMessage = Expression.Parameter(typeof(object), "argument");

                var method = Expression.Lambda<Action<object, object>>
                        (
                            Expression.Call
                                (
                                    Expression.Convert(paraTarget, taskArg.Item1),
                                    taskArg.Item2,
                                    Expression.Convert(paraMessage, taskArg.Item3)
                                ),
                                paraTarget,
                                paraMessage
                        ).Compile();

                var dic = _methodCacheDictionary.GetOrAdd(taskArg.Item1, _ => new ConcurrentDictionary<string, Action<object, object>>());
                dic.TryAdd(taskArg.Item2.Name, method);
            }, taskArgument);
        }

        private bool TryGetCacheFromMethodCacheDictionary(out Action<object,object> m)
        {
            m = null;
            var foundAction = false;
            ConcurrentDictionary<string, Action<object, object>> actionDictionary;
            if (_methodCacheDictionary.TryGetValue(_targetObjectType, out actionDictionary))
            {
                foundAction = actionDictionary.TryGetValue(_methodName, out m);
            }
            return foundAction;
        }
    }
}
