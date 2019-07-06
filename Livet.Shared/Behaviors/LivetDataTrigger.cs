using System.Windows;
using DataTrigger = Microsoft.Expression.Interactivity.Core.DataTrigger;

namespace Livet.Behaviors
{
    /// <summary>
    ///     初期値に対応したDataTriggerです。
    /// </summary>
    public class LivetDataTrigger : DataTrigger
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