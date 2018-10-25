using System.Windows;

namespace Livet.Behaviors
{
    /// <summary>
    /// 初期値に対応したDataTriggerです。
    /// </summary>
    public class LivetDataTrigger : Microsoft.Expression.Interactivity.Core.DataTrigger
    {
        protected override void OnAttached()
        {
            base.OnAttached();

            base.EvaluateBindingChange(
                new DependencyPropertyChangedEventArgs(
                    ValueProperty,
                    null,
                    Value));
        }
    }
}
