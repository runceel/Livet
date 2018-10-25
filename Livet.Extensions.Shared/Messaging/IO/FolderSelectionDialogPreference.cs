using System;

namespace Livet.Messaging.IO
{
	/// <summary>
	///		Specify preferred selection dialog implementation.
	/// </summary>
	/// <remarks>
	///		When you have to use specific dialog implementation
	///		regardless of underlying platform then specify this value explicitly.
	/// </remarks>
	public enum FolderSelectionDialogPreference
	{
		/// <summary>
		///		Do not specify any preference.
		///		Livet selects most appropriate options for current platform.
		/// </summary>
		None = 0,

		/// <summary>
		///		Specifies using always <see cref="T:System.Windows.Forms.FolderBrowserDialog"/>.
		/// </summary>
		FolderBrowser,

		/// <summary>
		///		Specifies using Win32 Common Item Dialog (namely, IFileOpenDialig).
		///		When the platform is prior to Windows Vista/Windows Server 2008,
		///		<see cref="PlatformNotSupportedException"/> is thrown.
		/// </summary>
		CommonItemDialog
	}
}
