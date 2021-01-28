using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows;
using System.Windows.Forms;
using System.Windows.Interop;
using Livet.Annotations;
using IWin32Window = System.Windows.Forms.IWin32Window;

namespace Livet.Dialogs
{
    /// <summary>
    ///     <see cref="FolderSelectionDialog" /> implementation using WinForm's
    ///     <see cref="T:System.Windows.Forms.FolderBrowserDialog" />.
    /// </summary>
    internal sealed class FolderBrowserFolderSelectionDialog : FolderSelectionDialog
    {
        [NotNull] private readonly FolderBrowserDialog _folderBrowserDialog;

        /// <summary>
        ///     Initializes a new instance of the <see cref="FolderBrowserFolderSelectionDialog" /> class.
        /// </summary>
        public FolderBrowserFolderSelectionDialog()
        {
            _folderBrowserDialog =
                new FolderBrowserDialog
                {
                    ShowNewFolderButton = true,
                    RootFolder = Environment.SpecialFolder.MyComputer
                };
        }

        /// <summary>
        ///     Gets or sets the descriptive text to instruct the operation.
        /// </summary>
        /// <value>
        ///     The descriptive text to instruct the operation.
        /// </value>
        public override string Description
        {
            get { return _folderBrowserDialog.Description; }
            set { _folderBrowserDialog.Description = value; }
        }

        /// <summary>
        ///     Gets or sets the selected path.
        /// </summary>
        /// <value>
        ///     The selected path. This will be default path when the dialog is opened.
        /// </value>
        public override string SelectedPath
        {
            get { return _folderBrowserDialog.SelectedPath; }
            set
            {
                // FolderBrowserDialog.SelectedPath must ends with Path.DirectorySeparatorChar.
                if (value != null && value.LastOrDefault() != Path.DirectorySeparatorChar)
                    _folderBrowserDialog.SelectedPath = value + Path.DirectorySeparatorChar;
                else
                    _folderBrowserDialog.SelectedPath = value;
            }
        }

        /// <summary>
        ///     This property is not supported.
        /// </summary>
        /// <value>Always <see cref="F:String.Empty" />.</value>
        public override string Title
        {
            get { return string.Empty; }
            set { }
        }


        /// <summary>
        ///     This property is not supported.
        /// </summary>
        /// <value>Always false.</value>
        public override bool Multiselect
        {
            get { return false; }
            set { }
        }

        /// <summary>
        ///     Gets or sets the selected paths.
        /// </summary>
        /// <value>Always return SelectedPath.</value>
        public override string[] SelectedPaths
        {
            get { return new[] { SelectedPath }; }
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
            if (disposing) _folderBrowserDialog.Dispose();

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
            switch (_folderBrowserDialog.ShowDialog(
                new WindowsFormsWin32Window(new WindowInteropHelper(hostWindow).EnsureHandle())))
            {
                case DialogResult.OK:
                case DialogResult.Yes:
                    return true;
                default:
                    return null;
            }
        }

        /// <summary>
        ///     A simple <see cref="System.Windows.Interop.IWin32Window" /> implementation wraps HWND.
        /// </summary>
        private sealed class WindowsFormsWin32Window : IWin32Window
        {
            /// <summary>
            ///     Initializes a new instance of the <see cref="WindowsFormsWin32Window" /> class.
            /// </summary>
            /// <param name="hwnd">The HWND.</param>
            public WindowsFormsWin32Window(IntPtr hwnd)
            {
                Handle = hwnd;
            }

            /// <summary>
            ///     Gets the handle to the window represented by the implementer.
            /// </summary>
            /// <returns>
            ///     A handle to the window represented by the implementer.
            /// </returns>
            public IntPtr Handle { get; }
        }
    }
}