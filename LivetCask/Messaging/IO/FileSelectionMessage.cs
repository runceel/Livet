using System.Windows;
using Livet.Annotations;

namespace Livet.Messaging.IO
{
    /// <summary>
    ///     ファイルを開く・ファイルを保存するアクション用の共通相互作用メッセージ基底抽象クラスです。<br />
    ///     ファイルを開くアクションをViewに行わせたい場合は、<see cref="FileSelectionMessage" />を使用してください。<br />
    ///     ファイルを保存するアクションをViewに行わせたい場合は、<see cref="SavingFileSelectionMessage" />を使用してください。
    /// </summary>
    public abstract class FileSelectionMessage : ResponsiveInteractionMessage<string[]>
    {
        // Using a DependencyProperty as the backing store for Title.  This enables animation, styling, binding, etc...
        [NotNull] public static readonly DependencyProperty TitleProperty =
            DependencyProperty.Register("Title", typeof(string), typeof(FileSelectionMessage),
                new PropertyMetadata(null));

        // Using a DependencyProperty as the backing store for Filter.  This enables animation, styling, binding, etc...
        [NotNull] public static readonly DependencyProperty FilterProperty =
            DependencyProperty.Register("Filter", typeof(string), typeof(FileSelectionMessage),
                new PropertyMetadata(null));

        // Using a DependencyProperty as the backing store for AddExtension.  This enables animation, styling, binding, etc...
        [NotNull] public static readonly DependencyProperty AddExtensionProperty =
            DependencyProperty.Register("AddExtension", typeof(bool), typeof(FileSelectionMessage),
                new PropertyMetadata(true));

        // Using a DependencyProperty as the backing store for InitialDirectory.  This enables animation, styling, binding, etc...
        [NotNull] public static readonly DependencyProperty InitialDirectoryProperty =
            DependencyProperty.Register("InitialDirectory", typeof(string), typeof(FileSelectionMessage),
                new PropertyMetadata(null));

        // Using a DependencyProperty as the backing store for FileName.  This enables animation, styling, binding, etc...
        [NotNull] public static readonly DependencyProperty FileNameProperty =
            DependencyProperty.Register("FileName", typeof(string), typeof(FileSelectionMessage),
                new PropertyMetadata(null));

        protected FileSelectionMessage() { }

        protected FileSelectionMessage(string messageKey)
            : base(messageKey) { }

        /// <summary>
        ///     ダイアログタイトルを指定、または取得します。
        /// </summary>
        [NotNull]
        public string Title
        {
            get { return (string) GetValue(TitleProperty) ?? string.Empty; }
            set { SetValue(TitleProperty, value); }
        }

        /// <summary>
        ///     ファイルの拡張子Filterを指定、または取得します。
        /// </summary>
        [NotNull]
        public string Filter
        {
            get { return (string) GetValue(FilterProperty) ?? string.Empty; }
            set { SetValue(FilterProperty, value); }
        }

        /// <summary>
        ///     拡張子を指定しなかった場合、自動で拡張子を追加するかどうかを指定、または取得します。デフォルトはtrueです。
        /// </summary>
        public bool AddExtension
        {
            get { return (bool) (GetValue(AddExtensionProperty) ?? default(bool)); }
            set { SetValue(AddExtensionProperty, value); }
        }

        /// <summary>
        ///     ダイアログに表示される初期ディレクトリを指定、または取得します。
        /// </summary>
        [NotNull]
        public string InitialDirectory
        {
            get { return (string) GetValue(InitialDirectoryProperty) ?? string.Empty; }
            set { SetValue(InitialDirectoryProperty, value); }
        }

        /// <summary>
        ///     ファイルダイアログで指定されたファイルのパスを含む文字列を指定、または取得します。
        /// </summary>
        [NotNull]
        public string FileName
        {
            get { return (string) GetValue(FileNameProperty) ?? string.Empty; }
            set { SetValue(FileNameProperty, value); }
        }

        /// <summary>
        ///     派生クラスでは必ずオーバーライドしてください。Freezableオブジェクトとして必要な実装です。<br />
        ///     通常このメソッドは、自身の新しいインスタンスを返すように実装します。
        /// </summary>
        /// <returns>自身の新しいインスタンス</returns>
        protected abstract override Freezable CreateInstanceCore();
    }
}