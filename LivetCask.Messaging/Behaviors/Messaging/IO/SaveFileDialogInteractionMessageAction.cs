using System.Windows;
using Livet.Messaging;
using Livet.Messaging.IO;
using Microsoft.Win32;

namespace Livet.Behaviors.Messaging.IO
{
    /// <summary>
    ///     「ファイルを保存する」ダイアログを表示するアクションです。<see cref="SavingFileSelectionMessage" />に対応します。
    /// </summary>
    public class SaveFileDialogInteractionMessageAction : InteractionMessageAction<DependencyObject>
    {
        protected override void InvokeAction(InteractionMessage message)
        {
            // ReSharper disable once InvertIf
            if (message is SavingFileSelectionMessage saveFileMessage)
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

                var showDialog = dialog.ShowDialog() ?? false;
                saveFileMessage.Response = showDialog ? dialog.FileNames : null;
            }
        }
    }
}