using System;
using System.Windows;
using Microsoft.Xaml.Behaviors;

namespace Livet.Behaviors
{
    /// <summary>
    ///     アタッチしたオブジェクトのDataContextがIDisposableである場合、Disposeします。
    /// </summary>
    public class DataContextDisposeAction : TriggerAction<FrameworkElement>
    {
        protected override void Invoke(object parameter)
        {
            var disposable = AssociatedObject?.DataContext as IDisposable;
            disposable?.Dispose();
        }
    }
}