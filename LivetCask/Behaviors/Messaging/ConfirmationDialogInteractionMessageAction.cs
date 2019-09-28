using System.Windows;
using Livet.Messaging;

namespace Livet.Behaviors.Messaging
{
    /// <summary>
    ///     確認ダイアログを表示するアクションです。<see cref="ConfirmationMessage" />に対応します。
    /// </summary>
    public class ConfirmationDialogInteractionMessageAction : InteractionMessageAction<FrameworkElement>
    {
        protected override void InvokeAction(InteractionMessage message)
        {
            // ReSharper disable once InvertIf
            if (message is ConfirmationMessage confirmMessage)
            {
                var result = MessageBox.Show(
                    confirmMessage.Text,
                    confirmMessage.Caption,
                    confirmMessage.Button,
                    confirmMessage.Image,
                    confirmMessage.DefaultResult
                );

                // ReSharper disable once SwitchStatementMissingSomeCases
                switch (result)
                {
                    case MessageBoxResult.Yes:
                    case MessageBoxResult.OK:
                        confirmMessage.Response = true;
                        break;
                    case MessageBoxResult.Cancel:
                        confirmMessage.Response = null;
                        break;
                    default:
                        confirmMessage.Response = false;
                        break;
                }
            }
        }
    }
}