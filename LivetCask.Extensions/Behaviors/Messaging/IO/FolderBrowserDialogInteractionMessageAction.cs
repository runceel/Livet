using System;
using System.Linq;
using System.Windows;
using Livet.Dialogs;
using Livet.Messaging;
using Livet.Messaging.IO;

namespace Livet.Behaviors.Messaging.IO
{
    /// <summary>
    ///     Show folder browser dialog.
    ///     <see cref="InteractionMessageAction{T}" /> for <see cref="FolderSelectionMessage" />.
    ///     This object must be hosted by <see cref="FrameworkElement" />.
    /// </summary>
    public class FolderBrowserDialogInteractionMessageAction : InteractionMessageAction<FrameworkElement>
    {
        /// <summary>
        ///     Invokes the action related to this class.
        /// </summary>
        /// <param name="m"><see cref="FolderSelectionMessage" /> specified to <see cref="InteractionMessenger" /> in the client.</param>
        protected override void InvokeAction(InteractionMessage m)
        {
            // ReSharper disable once InvertIf
            if (m is FolderSelectionMessage folderSelectionMessage)
            {
                var hostWindow = Window.GetWindow(AssociatedObject ?? throw new InvalidOperationException());
                if (hostWindow == null) return;

                using (var dialog = FolderSelectionDialogFactory.CreateDialog(folderSelectionMessage.DialogPreference))
                {
                    if (dialog == null) throw new InvalidOperationException();

                    dialog.Title = folderSelectionMessage.Title;
                    dialog.Description = folderSelectionMessage.Description;
                    dialog.SelectedPath = folderSelectionMessage.SelectedPath;
                    dialog.Multiselect = folderSelectionMessage.Multiselect;

                    if (dialog.ShowDialog(hostWindow).GetValueOrDefault())
                    {
                        folderSelectionMessage.Response = dialog.SelectedPaths;
                    }
                    else
                    {
                        folderSelectionMessage.Response = null;
                    }
                }
            }
        }
    }
}