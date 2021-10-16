using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows;
using Livet.Annotations;
using Microsoft.WindowsAPICodePack.Dialogs;

namespace Livet.Dialogs
{
    /// <summary>
    ///     <see cref="FolderSelectionDialog" /> implementation based on Win32 Common Item Dialog.
    /// </summary>
    internal sealed class CommonOpenFileFolderSelectionDialog : FolderSelectionDialog
    {
        [NotNull] private readonly CommonOpenFileDialog _commonOpenFileDialog;
        [CanBeNull] private readonly string _defaultTitle;

        /// <summary>
        ///     Initializes a new instance of the <see cref="CommonOpenFileFolderSelectionDialog" /> class.
        /// </summary>
        public CommonOpenFileFolderSelectionDialog()
        {
            _commonOpenFileDialog = new CommonOpenFileDialog { IsFolderPicker = true, Multiselect = false };
            _defaultTitle = _commonOpenFileDialog.Title;
        }

        /// <summary>
        ///     Gets or sets the title of the dialog.
        /// </summary>
        /// <value>
        ///     The title of the dialog.
        ///     Some dialog cannot support this value.
        ///     The <c>null</c> or empty indicates using default title.
        /// </value>
        public override string Title
        {
            get { return _commonOpenFileDialog.Title; }
            set { _commonOpenFileDialog.Title = string.IsNullOrEmpty(value) ? _defaultTitle : value; }
        }

        /// <summary>
        ///     This property is not supported.
        /// </summary>
        /// <value>Always <see cref="F:String.Empty" />.</value>
        public override string Description
        {
            get { return string.Empty; }
            set { }
        }

        /// <summary>
        ///  Gets or sets whether the multi selection is enabled on the folder browser dialog.
        /// </summary>
        public override bool Multiselect
        {
            get { return _commonOpenFileDialog.Multiselect; }

            set { _commonOpenFileDialog.Multiselect = value; }
        }

        /// <summary>
        ///     Gets or sets the selected path.
        /// </summary>
        /// <value>
        ///     The selected path. This will be default path when the dialog is opened.
        /// </value>
        public override string SelectedPath
        {
            get { return _commonOpenFileDialog.FileName; }
            set
            {
                DirectoryInfo asDirectory = null;
                try { asDirectory = value != null ? new DirectoryInfo(value) : null; }
                catch (ArgumentException) { }

                if (asDirectory == null)
                    _commonOpenFileDialog.DefaultFileName = value;
                else
                {
                    //// Set parent.
                    _commonOpenFileDialog.DefaultFileName = asDirectory.Name;

                    //// Set "My Computer", if drive root
                    _commonOpenFileDialog.InitialDirectory = asDirectory.Parent?.FullName
                                                             ?? "::{20D04FE0-3AEA-1069-A2D8-08002B30309D}";
                }
            }
        }

        /// <summary>
        ///     Gets or sets the selected paths.
        /// </summary>
        public override string[] SelectedPaths
        {
            get { return _commonOpenFileDialog.FileNames.ToArray(); }
        }

        /// <summary>
        ///     Releases unmanaged and - optionally - managed resources
        /// </summary>
        /// <param name="disposing">
        ///     <c>true</c> to release both managed and unmanaged resources; <c>false</c> to release only
        ///     unmanaged resources.
        /// </param>
        protected override void Dispose(bool disposing)
        {
            if (disposing) _commonOpenFileDialog.Dispose();
            base.Dispose(disposing);
        }

        /// <summary>
        ///     Shows the dialog with specified <see cref="Window" /> as host window.
        /// </summary>
        /// <param name="hostWindow">The host window which will host this dialog. This value will not be <c>null</c>.</param>
        /// <returns>
        ///     The result of the dialog.
        /// </returns>
        protected override bool? ShowDialogCore([NotNull] Window hostWindow)
        {
            if (hostWindow == null) throw new ArgumentNullException(nameof(hostWindow));

            // ReSharper disable once SwitchStatementMissingSomeCases
            switch (_commonOpenFileDialog.ShowDialog(hostWindow))
            {
                case CommonFileDialogResult.Ok:
                    return true;
                default:
                    return null;
            }
        }
    }
}