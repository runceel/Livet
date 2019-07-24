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
    ///     引数が一つだけ存在するメソッドを実行します。メソッドの実行は最大限キャッシュされます。
    /// </summary>
    public class MethodBinderWithArgument
    {
        [NotNull]
        private static readonly ConcurrentDictionary<Type, ConcurrentDictionary<string, Action<object, object>>>
            MethodCacheDictionary =
                new ConcurrentDictionary<Type, ConcurrentDictionary<string, Action<object, object>>>();

        private Type _argumentType;
        private Action<object, object> _method;
        private MethodInfo _methodInfo;
        private string _methodName;
        private Type _targetObjectType;

        public void Invoke([NotNull] object targetObject, [NotNull] string methodName, [CanBeNull] object argument)
        {
            if (targetObject == null) throw new ArgumentNullException(nameof(targetObject));
            if (methodName == null) throw new ArgumentNullException(nameof(methodName));

            var newTargetObjectType = targetObject.GetType();
            var newArgumentType = argument?.GetType();

            if (_targetObjectType == newTargetObjectType &&
                _methodName == methodName &&
                _argumentType == newArgumentType)
            {
                if (_method != null)
                {
                    _method(targetObject, argument);
                    return;
                }

                if (TryGetCacheFromMethodCacheDictionary(out _method))
                {
                    _method?.Invoke(targetObject, argument);
                    return;
                }

                if (_methodInfo != null)
                {
                    _methodInfo.Invoke(targetObject, new[] {argument});
                    return;
                }
            }

            _targetObjectType = newTargetObjectType;
            _argumentType = newArgumentType;
            _methodName = methodName;

            if (TryGetCacheFromMethodCacheDictionary(out _method))
            {
                _method?.Invoke(targetObject, argument);
                return;
            }

            _methodInfo = _targetObjectType?.GetMethods()
                .FirstOrDefault(method =>
                {
                    if (method.Name != methodName) return false;

                    var parameters = method.GetParameters();

                    if (parameters.Length != 1) return false;

                    var parameterType = parameters[0]?.ParameterType ?? throw new ArgumentException();
                    if (parameterType.IsInterface)
                    {
                        if (_argumentType != null
                            && !_argumentType.GetInterfaces().Contains(parameterType)) return false;
                    }
                    else
                    {
                        if (_argumentType != null && !_argumentType.IsSubclassOf(parameterType)
                                                  && _argumentType != parameterType) return false;
                    }

                    return method.ReturnType == typeof(void);
                });

            if (_methodInfo == null)
            {
                throw new ArgumentException(
                    $"{_targetObjectType?.Name} 型に {_argumentType?.Name} 型の引数を一つだけ持つメソッド {methodName} が見つかりません。");
            }

            _methodInfo.Invoke(targetObject, new[] {argument});

            var taskArgument = new Tuple<Type, MethodInfo, Type>(_targetObjectType, _methodInfo,
                _methodInfo.GetParameters()[0].ParameterType);

            Task.Factory.StartNew(arg =>
            {
                if (arg == null) throw new ArgumentNullException(nameof(arg));

                var taskArg = (Tuple<Type, MethodInfo, Type>) arg;

                var paraTarget = Expression.Parameter(typeof(object), "target");
                var paraMessage = Expression.Parameter(typeof(object), "argument");

                var method = Expression.Lambda<Action<object, object>>
                (
                    Expression.Call
                    (
                        Expression.Convert(paraTarget, taskArg.Item1 ?? throw new ArgumentException()),
                        taskArg.Item2 ?? throw new ArgumentException(),
                        Expression.Convert(paraMessage, taskArg.Item3 ?? throw new ArgumentException())
                    ),
                    paraTarget,
                    paraMessage
                ).Compile();

                var dic = MethodCacheDictionary.GetOrAdd(taskArg.Item1,
                              _ => new ConcurrentDictionary<string, Action<object, object>>())
                          ?? throw new InvalidOperationException();
                dic.TryAdd(taskArg.Item2.Name, method);
            }, taskArgument);
        }

        private bool TryGetCacheFromMethodCacheDictionary(out Action<object, object> m)
        {
            if (_targetObjectType == null) throw new InvalidOperationException();
            if (_methodName == null) throw new InvalidOperationException();

            m = null;
            var foundAction = false;
            if (MethodCacheDictionary.TryGetValue(_targetObjectType, out var actionDictionary))
                foundAction = actionDictionary.TryGetValue(_methodName, out m);
            return foundAction;
        }
    }
}