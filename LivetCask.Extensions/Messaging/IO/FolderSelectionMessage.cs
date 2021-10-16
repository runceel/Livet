using System.Windows;
using Livet.Annotations;

namespace Livet.Messaging.IO
{
    /// <summary>
    ///     <see cref="ResponsiveInteractionMessage{T}" /> for folder selection with folder browser dialog.
    /// </summary>
    /// <remarks>
    ///     You should set both of <see cref="Title" /> and <see cref="Description" />
    ///     when you set each of them,
    ///     because some platform only supports one of them.
    /// </remarks>
    public sealed class FolderSelectionMessage : ResponsiveInteractionMessage<string[]>
    {
        /// <summary>
        ///     Defines <see cref="Description" /> dependency property.
        /// </summary>
        /// <value>
        ///     <see cref="DependencyProperty" />.
        /// </value>
        [NotNull]
        public static readonly DependencyProperty DescriptionProperty =
            DependencyProperty.Register("Description", typeof(string), typeof(FolderSelectionMessage),
                new UIPropertyMetadata(null));

        /// <summary>
        ///     Defines <see cref="Title" /> dependency property.
        /// </summary>
        /// <value>
        ///     <see cref="DependencyProperty" />.
        /// </value>
        [NotNull]
        public static readonly DependencyProperty TitleProperty =
            DependencyProperty.Register("Title", typeof(string), typeof(FolderSelectionMessage),
                new UIPropertyMetadata(string.Empty));

        /// <summary>
        ///     Defines <see cref="SelectedPath" /> dependency property.
        /// </summary>
        /// <value>
        ///     <see cref="DependencyProperty" />.
        /// </value>
        [NotNull]
        public static readonly DependencyProperty SelectedPathProperty =
            DependencyProperty.Register("SelectedPath", typeof(string), typeof(FolderSelectionMessage),
                new UIPropertyMetadata(string.Empty));

        /// <summary>
        ///     Defines <see cref="SelectedPath" /> dependency property.
        /// </summary>
        /// <value>
        ///     <see cref="DependencyProperty" />.
        /// </value>
        [NotNull]
        public static readonly DependencyProperty DialogPreferenceProperty =
            DependencyProperty.Register("DialogPreference", typeof(FolderSelectionDialogPreference),
                typeof(FileSelectionMessage), new UIPropertyMetadata(FolderSelectionDialogPreference.None));
        /// <summary>
        ///     Defines <see cref="Multiselect" /> dependency property.
        /// </summary>
        /// <value>
        ///     <see cref="DependencyProperty" />.
        /// </value>
        [NotNull]
        public static readonly DependencyProperty MultiselectProperty =
            DependencyProperty.Register("Multiselect", typeof(bool),
                typeof(FileSelectionMessage), new UIPropertyMetadata(false));



        /// <summary>
        ///     Initializes a new instance of the <see cref="FolderSelectionMessage" /> class
        ///     without message key.
        /// </summary>
        public FolderSelectionMessage() { }

        /// <summary>
        ///     Initializes a new instance of the <see cref="FolderSelectionMessage" /> class
        ///     with message key.
        /// </summary>
        /// <param name="messageKey">The message key to identify the message instance.</param>
        public FolderSelectionMessage(string messageKey)
            : base(messageKey) { }

        /// <summary>
        ///     Gets or sets the description for folder selection dialog.
        /// </summary>
        /// <value>
        ///     The description for folder browser dialog.
        /// </value>
        public string Description
        {
            get { return GetValue(DescriptionProperty) as string; }
            set { SetValue(DescriptionProperty, value); }
        }

        /// <summary>
        ///     Gets or sets the selected path on the folder browser dialog.
        /// </summary>
        /// <value>
        ///     The title for folder selection dialog.
        ///     If this value is <c>null</c> or empty, then the default title is used.
        /// </value>
        public string Title
        {
            get { return GetValue(TitleProperty) as string; }
            set { SetValue(TitleProperty, value); }
        }

        /// <summary>
        ///     Gets or sets whether the multi selection is enabled on the folder browser dialog.
        /// </summary>
        public bool Multiselect
        {
            get { return (bool)GetValue(MultiselectProperty); }
            set { SetValue(MultiselectProperty, value); }
        }

        /// <summary>
        ///     Gets or sets the selected path on the folder selection dialog.
        /// </summary>
        /// <value>
        ///     The selected path on the folder selection dialog.
        ///     This value is also used to initial selected folder in the dialog.
        /// </value>
        public string SelectedPath
        {
            get { return GetValue(SelectedPathProperty) as string; }
            set { SetValue(SelectedPathProperty, value); }
        }

        /// <summary>
        ///     Gets or sets the dialog preference.
        /// </summary>
        /// <value>
        ///     The dialog preference. Default is <see cref="FolderSelectionDialogPreference.None" />.
        /// </value>
        public FolderSelectionDialogPreference DialogPreference
        {
            get
            {
                var value = GetValue(DialogPreferenceProperty);
                return value?.GetType() == typeof(FolderSelectionDialogPreference)
                    ? (FolderSelectionDialogPreference)value
                    : default;
            }
            set { SetValue(DialogPreferenceProperty, value); }
        }

        /// <summary>
        ///     Creates the new instance of this class.
        /// </summary>
        /// <returns>The new <see cref="FolderSelectionMessage" /> which has identical properties to this instance.</returns>
        protected override Freezable CreateInstanceCore()
        {
            return new FolderSelectionMessage(MessageKey);
        }
    }
}