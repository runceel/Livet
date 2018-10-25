using Livet.Messaging.IO;
using Microsoft.Win32;
using System.Windows;

using Livet.Messaging;

namespace Livet.Behaviors.Messaging.IO
{
    /// <summary>
    /// 「ファイルを保存する」ダイアログを表示するアクションです。<see cref="SavingFileSelectionMessage"/>に対応します。
    /// </summary>
    public class SaveFileDialogInteractionMessageAction : InteractionMessageAction<DependencyObject>
    {
        protected override void InvokeAction(InteractionMessage message)
        {
            var saveFileMessage = message as SavingFileSelectionMessage;

            if (saveFileMessage != null)
            {
                var dialog = new SaveFileDialog
                                            {
                                                FileName = saveFileMessage.FileName,
                                                InitialDirectory = saveFileMessage.InitialDirectory,
                                                AddExtension = saveFileMessage.AddExtension,
                                                CreatePrompt = saveFileMessage.CreatePrompt,
                                                Filter = saveFileMessage.Filter,
                                                OverwritePrompt = saveFileMessage.OverwritePrompt,
                                                Title = saveFileMessage.Title
                                            };

                saveFileMessage.Response = dialog.ShowDialog().Value ? dialog.FileNames : null;
            }
        }
    }
}
