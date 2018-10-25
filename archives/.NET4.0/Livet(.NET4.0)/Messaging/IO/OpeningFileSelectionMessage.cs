using System.Windows;

namespace Livet.Messaging.IO
{
    /// <summary>
    /// ファイルを開く アクション用の相互作用メッセージです。
    /// </summary>
    public class OpeningFileSelectionMessage : FileSelectionMessage
    {
        public OpeningFileSelectionMessage()
        {
        }

        /// <summary>
        /// メッセージキーを指定して新しい相互作用メッセージのインスタンスを生成します。
        /// </summary>
        /// <param name="messageKey">メッセージキー</param>
        public OpeningFileSelectionMessage(string messageKey)
            : base(messageKey)
        {
        }

        /// <summary>
        /// 派生クラスでは必ずオーバーライドしてください。Freezableオブジェクトとして必要な実装です。<br/>
        /// 通常このメソッドは、自身の新しいインスタンスを返すように実装します。
        /// </summary>
        /// <returns>自身の新しいインスタンス</returns>
        protected override Freezable CreateInstanceCore()
        {
            return new OpeningFileSelectionMessage(MessageKey);
        }

        /// <summary>
        /// 複数ファイルを選択可能かを取得、または設定します。
        /// </summary>
        public bool MultiSelect
        {
            get { return (bool)GetValue(MultiSelectProperty); }
            set { SetValue(MultiSelectProperty, value); }
        }

        // Using a DependencyProperty as the backing store for MultiSelect.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty MultiSelectProperty =
            DependencyProperty.Register("MultiSelect", typeof(bool), typeof(OpeningFileSelectionMessage), new PropertyMetadata(false));    
    }
}