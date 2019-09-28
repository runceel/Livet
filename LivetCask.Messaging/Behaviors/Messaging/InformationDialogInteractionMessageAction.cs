using System.Windows;
using Livet.Messaging;

namespace Livet.Behaviors.Messaging
{
    /// <summary>
    ///     情報ダイアログを表示するアクションです。InformationMessageに対応します。
    /// </summary>
    public class InformationDialogInteractionMessageAction : InteractionMessageAction<FrameworkElement>
    {
        protected override void InvokeAction(InteractionMessage message)
        {
            if (message is InformationMessage informationMessage)
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