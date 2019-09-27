using System;
using System.Windows;
using DataTrigger = Microsoft.Xaml.Behaviors.Core.DataTrigger;

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
                    ValueProperty ?? throw new InvalidOperationException(),
                    null,
                    Value));
        }
    }
}