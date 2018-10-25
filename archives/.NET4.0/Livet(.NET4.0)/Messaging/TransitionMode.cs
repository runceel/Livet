namespace Livet.Messaging
{
    public enum TransitionMode
    {
        /// <summary>
        /// 新しくWindowを開きます。
        /// </summary>
        Normal,
        /// <summary>
        /// 新しいWindowをモーダルダイアログとして開きます。
        /// </summary>
        Modal,
        /// <summary>
        /// すでに同じ型のWindowが開かれている場合はそのWindowをアクティブにします。<br/>
        /// 同じ型のWindowが開かれていなかった場合、新しくWindowを開きます。
        /// </summary>
        NewOrActive,
        /// <summary>
        /// 指定されていません。Windowは表示されません。
        /// </summary>
        UnKnown
    }
}
