using System;
using System.Windows.Interactivity;
using System.Windows;

namespace Livet.Behaviors
{
    /// <summary>
    /// アタッチしたオブジェクトのDataContextがIDisposableである場合、Disposeします。
    /// </summary>
    public class DataContextDisposeAction : TriggerAction<FrameworkElement>
    {
        protected override void Invoke(object parameter)
        {
            var disposable = AssociatedObject.DataContext as IDisposable;

            if (disposable != null)
            {
                disposable.Dispose();
            }
        }
    }
}
