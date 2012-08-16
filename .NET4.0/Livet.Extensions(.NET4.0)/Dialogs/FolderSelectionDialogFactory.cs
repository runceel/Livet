using System;
using System.Globalization;
using Livet.Messaging.IO;
using Livet.Properties;
using Microsoft.WindowsAPICodePack.Dialogs;

namespace Livet.Dialogs
{
	/// <summary>
	///		The factory to abstract concrete implementation of <see cref="FolderSelectionDialog"/>.
	/// </summary>
	internal sealed class FolderSelectionDialogFactory
	{
		/// <summary>
		///		Gets a value indicating whether this platform can use Win32 Common Item Dialog.
		/// </summary>
		/// <value>
		/// 	<c>true</c> if this platform can use Win32 Common Item Dialog; otherwise, <c>false</c>.
		/// </value>
		public static bool CanUseCommonItemDialog
		{
			get { return CommonFileDialog.IsPlatformSupported; }
		}

		/// <summary>
		///		Creates the appropriate <see cref="FolderSelectionDialog"/> for running platform.
		/// </summary>
		/// <param name="preference">Folder selection dialog impementation preference.</param>
		/// <returns>
		///		The appropriate <see cref="FolderSelectionDialog"/> for running platform.
		/// </returns>
		/// <remarks>
		///		The return value is determined with running platform and <paramref name="preference"/>.
		/// </remarks>
		public static FolderSelectionDialog CreateDialog( FolderSelectionDialogPreference preference )
		{
			switch ( preference )
			{
				case FolderSelectionDialogPreference.None:
				{
					if ( CanUseCommonItemDialog )
					{
						return new CommonOpenFileFolderSelectionDialog();
					}
					else
					{
						return new FolderBrowserFolderSelectionDialog();
					}
				}
				case FolderSelectionDialogPreference.FolderBrowser:
				{
					return new FolderBrowserFolderSelectionDialog();
				}
				case FolderSelectionDialogPreference.CommonItemDialog:
				{
					if ( !CanUseCommonItemDialog )
					{
						throw new PlatformNotSupportedException( Resources.FolderSelectionDialogFactory_CommonItemDialogIsSupportedFromWindowsNT6 );
					}

					return new CommonOpenFileFolderSelectionDialog();
				}
				default:
				{
					throw new ArgumentException(
						String.Format( CultureInfo.CurrentCulture, Resources.UnsupportedEnumValue, typeof( FolderSelectionDialogPreference ), preference, ( int )preference ),
						"preference"
					);
				}
			}
		}
	}
}
