using Livet.Messaging;
using System.Windows;

namespace Livet.Behaviors.Messaging
{
    /// <summary>
    /// 確認ダイアログを表示するアクションです。<see cref="ConfirmationMessage"/>に対応します。
    /// </summary>
    public class ConfirmationDialogInteractionMessageAction : InteractionMessageAction<FrameworkElement>
    {
        protected override void InvokeAction(InteractionMessage message)
        {
            if (message is ConfirmationMessage confirmMessage)
            {
                var result = MessageBox.Show(
                    confirmMessage.Text,
                    confirmMessage.Caption,
                    confirmMessage.Button,
                    confirmMessage.Image,
                    confirmMessage.DefaultResult
                    );

                if (result == MessageBoxResult.Yes || result == MessageBoxResult.OK)
                {
                    confirmMessage.Response = true;
                }
                else if (result == MessageBoxResult.Cancel)
                {
                    confirmMessage.Response = null;
                }
                else
                {
                    confirmMessage.Response = false;
                }
            }

        }
    }
}
