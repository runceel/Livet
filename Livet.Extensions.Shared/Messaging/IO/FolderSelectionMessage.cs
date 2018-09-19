using System;
using System.Windows;
using Livet.Messaging;

namespace Livet.Messaging.IO
{
	/// <summary>
	///		<see cref="ResponsiveInteractionMessage{T}"/> for folder selection with folder browser dialog.
	/// </summary>
	/// <remarks>
	///		<para>
	///			You should set both of <see cref="Title"/> and <see cref="Description"/>
	///			when you set each of them, 
	///			because some platform only supports one of them.
	///		</para>
	///		<para>
	///			
	///		</para>
	/// </remarks>
	public sealed class FolderSelectionMessage : ResponsiveInteractionMessage<string>
	{
		/// <summary>
		///		Initializes a new instance of the <see cref="FolderSelectionMessage"/> class
		///		wihtout message key.
		/// </summary>
		public FolderSelectionMessage()
		{
		}

		/// <summary>
		///		Initializes a new instance of the <see cref="FolderSelectionMessage"/> class
		///		with message key.
		/// </summary>
		/// <param name="messageKey">The message key to identify the message instance.</param>
		public FolderSelectionMessage( string messageKey )
			: base( messageKey )
		{
		}

		/// <summary>
		///		Creates the new instance of this class.
		/// </summary>
		/// <returns>The new <see cref="FolderSelectionMessage"/> which has identical properties to this instance.</returns>
		protected sealed override Freezable CreateInstanceCore()
		{
			return new FolderSelectionMessage( this.MessageKey );
		}

		/// <summary>
		///		Defines <see cref="Description"/> depencendy property.
		/// </summary>
		/// <value>
		///		<see cref="DependencyProperty"/>.
		/// </value>
		public static readonly DependencyProperty DescriptionProperty =
			DependencyProperty.Register( "Description", typeof( string ), typeof( FolderSelectionMessage ), new UIPropertyMetadata( null ) );

		/// <summary>
		///		Gets or sets the description for folder selection dialog.
		/// </summary>
		/// <value>
		/// The description for folder browser dialog.
		/// </value>
		public string Description
		{
			get { return GetValue( DescriptionProperty ) as string; }
			set { SetValue( DescriptionProperty, value ); }
		}

		/// <summary>
		///		Defines <see cref="Title"/> depencendy property.
		/// </summary>
		/// <value>
		///		<see cref="DependencyProperty"/>.
		/// </value>
		public static readonly DependencyProperty TitleProperty =
			DependencyProperty.Register( "Title", typeof( string ), typeof( FolderSelectionMessage ), new UIPropertyMetadata( String.Empty ) );

		/// <summary>
		///		Gets or sets the selected path on the folder browser dialog.
		/// </summary>
		/// <value>
		///		The title for folder selection dialog.
		///		If this value is <c>null</c> or empty, then the default title is used.
		/// </value>
		public string Title
		{
			get { return GetValue( TitleProperty ) as string; }
			set { SetValue( TitleProperty, value ); }
		}

		/// <summary>
		///		Defines <see cref="SelectedPath"/> depencendy property.
		/// </summary>
		/// <value>
		///		<see cref="DependencyProperty"/>.
		/// </value>
		public static readonly DependencyProperty SelectedPathProperty =
			DependencyProperty.Register( "SelectedPath", typeof( string ), typeof( FolderSelectionMessage ), new UIPropertyMetadata( String.Empty ) );

		/// <summary>
		///		Gets or sets the selected path on the folder selection dialog.
		/// </summary>
		/// <value>
		///		The selected path on the folder selection dialog.
		///		This value is also used to initial selected folder in the dialog.
		/// </value>
		public string SelectedPath
		{
			get { return GetValue( SelectedPathProperty ) as string; }
			set { SetValue( SelectedPathProperty, value ); }
		}

		/// <summary>
		///		Defines <see cref="SelectedPath"/> depencendy property.
		/// </summary>
		/// <value>
		///		<see cref="DependencyProperty"/>.
		/// </value>
		public static readonly DependencyProperty DialogPreferenceProperty =
			DependencyProperty.Register( "DialogPreference", typeof( FolderSelectionDialogPreference ), typeof( FileSelectionMessage ), new UIPropertyMetadata( FolderSelectionDialogPreference.None ) );

		/// <summary>
		///		Gets or sets the dialog preference.
		/// </summary>
		/// <value>
		///		The dialog preference. Default is <see cref="FolderSelectionDialogPreference.None"/>.
		/// </value>
		public FolderSelectionDialogPreference DialogPreference
		{
			get { return ( FolderSelectionDialogPreference )GetValue( DialogPreferenceProperty ); }
			set { SetValue( DialogPreferenceProperty, value ); }
		}
	}
}