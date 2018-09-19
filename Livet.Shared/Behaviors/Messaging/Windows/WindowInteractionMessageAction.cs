using System.Windows;
using Livet.Messaging.Windows;
using Livet.Messaging;

namespace Livet.Behaviors.Messaging.Windows
{
    /// <summary>
    /// Windowの最小化・最大化・閉じるを行うアクションです。WindowActionMessageに対応します。
    /// </summary>
    public class WindowInteractionMessageAction : InteractionMessageAction<FrameworkElement>
    {
        protected override void InvokeAction(InteractionMessage message)
        {
            var windowMessage = message as WindowActionMessage;

            if (windowMessage != null)
            {
                var window = Window.GetWindow(AssociatedObject);

                if (window != null)
                {
                    switch (windowMessage.Action)
                    {
                        case WindowAction.Close:
                            window.Close();
                            break;
                        case WindowAction.Maximize:
                            window.WindowState = WindowState.Maximized;
                            break;
                        case WindowAction.Minimize:
                            window.WindowState = WindowState.Minimized;
                            break;
                        case WindowAction.Normal:
                            window.WindowState = WindowState.Normal;
                            break;
                        case WindowAction.Active:
                            window.Activate();
                            break;
                    }
                }
            }
        }
    }
}
