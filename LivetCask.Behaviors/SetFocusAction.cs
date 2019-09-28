using System.Windows;
using Microsoft.Xaml.Behaviors;

namespace Livet.Behaviors
{
    /// <summary>
    ///     アタッチしているコントロールにフォーカスを試みます。
    /// </summary>
    public class SetFocusAction : TriggerAction<FrameworkElement>
    {
        protected override void Invoke(object parameter)
        {
            AssociatedObject?.Focus();
        }
    }
}