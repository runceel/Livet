using Livet.Messaging;
using System.Windows;

namespace Livet.Behaviors.Messaging
{
    /// <summary>
    /// 情報ダイアログを表示するアクションです。InformationMessageに対応します。
    /// </summary>
    public class InformationDialogInteractionMessageAction : InteractionMessageAction<FrameworkElement>
    {
        protected override void InvokeAction(InteractionMessage message)
        {
            var informationMessage = message as InformationMessage;

            if (informationMessage != null)
            {
                MessageBox.Show(
                    informationMessage.Text,
                    informationMessage.Caption,
                    MessageBoxButton.OK,
                    informationMessage.Image
                    );
            }

        }
    }
}
