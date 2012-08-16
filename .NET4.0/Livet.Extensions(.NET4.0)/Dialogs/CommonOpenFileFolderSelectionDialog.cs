using System;
using System.IO;
using System.Windows;
using Microsoft.WindowsAPICodePack.Dialogs;

namespace Livet.Dialogs
{
	/// <summary>
	///		<see cref="FolderSelectionDialog"/> implementation based on Win32 Common Item Dialog.
	/// </summary>
	internal sealed class CommonOpenFileFolderSelectionDialog : FolderSelectionDialog
	{
		private readonly string _defaultTitle;
		private readonly CommonOpenFileDialog _commonOpenFileDialog;

		/// <summary>
		///		Gets or sets the title of the dialog.
		/// </summary>
		/// <value>
		///		The title of the dialog.
		///		Some dialog cannot support this value.
		///		The <c>null</c> or empty indicates using default title.
		/// </value>
		public sealed override string Title
		{
			get { return this._commonOpenFileDialog.Title; }
			set { this._commonOpenFileDialog.Title = String.IsNullOrEmpty( value ) ? this._defaultTitle : value; }
		}

		/// <summary>
		///		This property is not supported.
		/// </summary>
		/// <value>Always <see cref="F:String.Empty"/>.</value>
		public sealed override string Description
		{
			get { return String.Empty; }
			set { }
		}

		/// <summary>
		/// Gets or sets the selected path.
		/// </summary>
		/// <value>
		/// The selected path. This will be default path when the dialog is opened.
		/// </value>
		public sealed override string SelectedPath
		{
			get { return this._commonOpenFileDialog.FileName; }
			set
			{
				DirectoryInfo asDirectory = null;
				try
				{
					asDirectory = new DirectoryInfo( value );
				}
				catch ( ArgumentException ) { }

				if ( asDirectory == null )
				{
					this._commonOpenFileDialog.DefaultFileName = value;
				}
				else
				{
					// Set parent.
					this._commonOpenFileDialog.DefaultFileName = asDirectory.Name;
					this._commonOpenFileDialog.InitialDirectory = asDirectory.Parent.FullName;
				}
			}
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="CommonOpenFileFolderSelectionDialog"/> class.
		/// </summary>
		public CommonOpenFileFolderSelectionDialog()
		{
			this._commonOpenFileDialog =
				new CommonOpenFileDialog()
				{
					IsFolderPicker = true,
					Multiselect = false,
				};
			this._defaultTitle = this._commonOpenFileDialog.Title;
		}

		/// <summary>
		/// Releases unmanaged and - optionally - managed resources
		/// </summary>
		/// <param name="disposing"><c>true</c> to release both managed and unmanaged resources; <c>false</c> to release only unmanaged resources.</param>
		protected sealed override void Dispose( bool disposing )
		{
			if ( disposing )
			{
				this._commonOpenFileDialog.Dispose();
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
			switch ( this._commonOpenFileDialog.ShowDialog( hostWindow ) )
			{
				case CommonFileDialogResult.Ok:
				{
					return true;
				}
				default:
				{
					return null;
				}
			}
		}
	}
}
