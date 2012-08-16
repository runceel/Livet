using System;
using System.IO;
using System.Linq;
using System.Windows;
using System.Windows.Interop;

namespace Livet.Dialogs
{
	/// <summary>
	///		<see cref="FolderSelectionDialog"/> implementation using WinForm's <see cref="T:System.Windows.Forms.FolderBrowserDialog"/>.
	/// </summary>
	internal sealed class FolderBrowserFolderSelectionDialog : FolderSelectionDialog
	{
		private readonly System.Windows.Forms.FolderBrowserDialog _folderBrowserDialog;

		/// <summary>
		/// Gets or sets the descriptive text to instruct the operation.
		/// </summary>
		/// <value>
		/// The descriptive text to instruct the operation.
		/// </value>
		public sealed override string Description
		{
			get { return this._folderBrowserDialog.Description; }
			set { this._folderBrowserDialog.Description = value; }
		}

		/// <summary>
		/// Gets or sets the selected path.
		/// </summary>
		/// <value>
		/// The selected path. This will be default path when the dialog is opened.
		/// </value>
		public sealed override string SelectedPath
		{
			get { return this._folderBrowserDialog.SelectedPath; }
			set
			{
				// FolderBrowserDialog.SelectedPath must ends with Path.DirectorySeparatorChar.
				if ( value != null && value.LastOrDefault() != Path.DirectorySeparatorChar )
				{
					this._folderBrowserDialog.SelectedPath = value + Path.DirectorySeparatorChar;
				}
				else
				{
					this._folderBrowserDialog.SelectedPath = value;
				}
			}
		}

		/// <summary>
		///		This property is not supported.
		/// </summary>
		/// <value>Always <see cref="F:String.Empty"/>.</value>
		public sealed override string Title
		{
			get { return String.Empty; }
			set { }
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="FolderBrowserFolderSelectionDialog"/> class.
		/// </summary>
		public FolderBrowserFolderSelectionDialog()
		{
			this._folderBrowserDialog =
				new System.Windows.Forms.FolderBrowserDialog()
				{
					ShowNewFolderButton = true,
					RootFolder = Environment.SpecialFolder.MyComputer,
				};
		}

		/// <summary>
		/// Releases unmanaged and - optionally - managed resources
		/// </summary>
		/// <param name="disposing"><c>true</c> to release both managed and unmanaged resources; <c>false</c> to release only unmanaged resources.</param>
		protected sealed override void Dispose( bool disposing )
		{
			if ( disposing )
			{
				this._folderBrowserDialog.Dispose();
			}

			base.Dispose( disposing );
		}

		/// <summary>
		/// Shows the dialog with specified <see cref="Window"/> as host window.
		/// </summary>
		/// <param name="hostWindow">The host window which will host this dialog. This value will not be <c>null</c>.</param>
		/// <returns>
		/// The result of the dialog.
		/// </returns>
		protected sealed override bool? ShowDialogCore( Window hostWindow )
		{
			switch ( this._folderBrowserDialog.ShowDialog( new WindowsFormsWin32Window( new WindowInteropHelper( hostWindow ).EnsureHandle() ) ) )
			{
				case System.Windows.Forms.DialogResult.OK:
				case System.Windows.Forms.DialogResult.Yes:
				{
					return true;
				}
				default:
				{
					return null;
				}
			}
		}

		/// <summary>
		///		A simple <see cref="IWin32Window"/> implementation wraps HWND.
		/// </summary>
		private sealed class WindowsFormsWin32Window : System.Windows.Forms.IWin32Window
		{
			private readonly IntPtr _handle;

			/// <summary>
			///		Gets the handle to the window represented by the implementer.
			/// </summary>
			/// <returns>
			///		A handle to the window represented by the implementer.
			///	</returns>
			public IntPtr Handle
			{
				get { return this._handle; }
			}

			/// <summary>
			/// Initializes a new instance of the <see cref="WindowsFormsWin32Window"/> class.
			/// </summary>
			/// <param name="hwnd">The HWND.</param>
			public WindowsFormsWin32Window( IntPtr hwnd )
			{
				this._handle = hwnd;
			}
		}
	}
}
