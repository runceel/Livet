using System;
using System.Windows;

namespace Livet.Dialogs
{
	/// <summary>
	///		Hides implementation of the folder selection dialog which depends on platform version.
	/// </summary>
	internal abstract class FolderSelectionDialog : IDisposable
	{
		/// <summary>
		///		Gets or sets the selected path.
		/// </summary>
		/// <value>
		///		The selected path. This will be default path when the dialog is opened.
		/// </value>
		public abstract string SelectedPath { get; set; }

		/// <summary>
		///		Gets or sets the descriptive text to instruct the operation.
		/// </summary>
		/// <value>
		///		The descriptive text to instruct the operation.
		///		Some dialog cannot support this value.
		/// </value>
		public abstract string Description { get; set; }


		/// <summary>
		///		Gets or sets the title of the dialog.
		/// </summary>
		/// <value>
		///		The title of the dialog.
		///		Some dialog cannot support this value.
		///		The <c>null</c> or empty indicates using default title.
		/// </value>
		public abstract string Title { get; set; }

		/// <summary>
		///		Initializes a new instance of the <see cref="FolderSelectionDialog"/> class.
		/// </summary>
		protected FolderSelectionDialog() { }

		/// <summary>
		///		Performs application-defined tasks associated with freeing, releasing, or resetting unmanaged resources.
		/// </summary>
		public void Dispose()
		{
			this.Dispose( true );
			GC.SuppressFinalize( this );
		}

		/// <summary>
		///		Releases unmanaged and - optionally - managed resources
		/// </summary>
		/// <param name="disposing">
		///		<c>true</c> to release both managed and unmanaged resources; <c>false</c> to release only unmanaged resources.
		/// </param>
		protected virtual void Dispose( bool disposing )
		{
		}

		/// <summary>
		///		Shows the dialog with specified <see cref="Window"/> as host window.
		/// </summary>
		/// <param name="hostWindow">The host window which will host this dialog.</param>
		/// <returns>The result of the dialog.</returns>
		/// <exception cref="ArgumentNullException">
		///		<paramref name="hostWindow"/> is <c>null</c>.
		/// </exception>
		public bool? ShowDialog( Window hostWindow )
		{
			if ( hostWindow == null )
			{
				throw new ArgumentNullException( "hostWindow" );
			}

			return this.ShowDialogCore( hostWindow );
		}

		/// <summary>
		///		Shows the dialog with specified <see cref="Window"/> as host window.
		/// </summary>
		/// <param name="hostWindow">The host window which will host this dialog. This value will not be <c>null</c>.</param>
		/// <returns>The result of the dialog.</returns>
		protected abstract bool? ShowDialogCore( Window hostWindow );
	}
}
