using System;
using System.Threading;
using System.Threading.Tasks;
using Livet.Annotations;

namespace Livet.Messaging
{
    /// <summary>
    ///     ViewModelで使用するMessengerクラスです。
    /// </summary>
    public class InteractionMessenger
    {
        /// <summary>
        ///     指定された相互作用メッセージを同期的に送信します。
        /// </summary>
        /// <param name="message">相互作用メッセージ</param>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1030:UseEventsWhereAppropriate")]
        public void Raise([NotNull] InteractionMessage message)
        {
            if (message == null) throw new ArgumentNullException(nameof(message));

            var threadSafeHandler = Interlocked.CompareExchange(ref Raised, null, null);
            if (threadSafeHandler == null) return;

            if (!message.IsFrozen) message.Freeze();

            threadSafeHandler(this, new InteractionMessageRaisedEventArgs(message));
        }

        /// <summary>
        ///     指定された、戻り値情報のある相互作用メッセージを同期的に送信します。
        /// </summary>
        /// <typeparam name="T">戻り値情報のある相互作用メッセージの型</typeparam>
        /// <param name="message">戻り値情報のある相互作用メッセージ</param>
        /// <returns>アクション実行後に、戻り情報を含んだ相互作用メッセージ</returns>
        public T GetResponse<T>([NotNull] T message) where T : ResponsiveInteractionMessage
        {
            if (message == null) throw new ArgumentNullException(nameof(message));

            var threadSafeHandler = Interlocked.CompareExchange(ref Raised, null, null);
            if (threadSafeHandler == null) return null;

            if (!message.IsFrozen) message.Freeze();

            threadSafeHandler(this, new InteractionMessageRaisedEventArgs(message));
            return message;
        }

        /// <summary>
        ///     相互作用メッセージが送信された時に発生するイベントです。
        /// </summary>
        public event EventHandler<InteractionMessageRaisedEventArgs> Raised;

        /// <summary>
        ///     指定された相互作用メッセージを非同期で送信します。
        /// </summary>
        /// <param name="message">相互作用メッセージ</param>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1030:UseEventsWhereAppropriate")]
        public async Task RaiseAsync([NotNull] InteractionMessage message)
        {
            if (message == null) throw new ArgumentNullException(nameof(message));

            if (!message.IsFrozen) message.Freeze();

            await Task.Factory.StartNew(() => Raise(message));
        }

        /// <summary>
        ///     指定された、戻り値情報のある相互作用メッセージを非同期で送信します。
        /// </summary>
        /// <typeparam name="T">戻り値情報のある相互作用メッセージの型</typeparam>
        /// <param name="message">戻り値情報のある相互作用メッセージ</param>
        public async Task<T> GetResponseAsync<T>([NotNull] T message) where T : ResponsiveInteractionMessage
        {
            if (message == null) throw new ArgumentNullException(nameof(message));

            if (!message.IsFrozen) message.Freeze();

            return await Task<T>.Factory.StartNew(() => GetResponse(message));
        }

        /// <summary>
        ///     指定された、戻り値情報のある相互作用メッセージを非同期で送信します。
        /// </summary>
        /// <typeparam name="T">戻り値情報のある相互作用メッセージの型</typeparam>
        /// <param name="message">戻り値情報のある相互作用メッセージ</param>
        /// <param name="callback">コールバック</param>
        [Obsolete("callbackを取らないオーバーロードの使用を検討してください。")]
        public async Task<T> GetResponseAsync<T>([NotNull] T message, [CanBeNull] Action<T> callback)
            where T : ResponsiveInteractionMessage
        {
            if (message == null) throw new ArgumentNullException(nameof(message));

            if (!message.IsFrozen) message.Freeze();

            var msg = await Task<T>.Factory.StartNew(() => GetResponse(message));
            callback?.Invoke(msg);
            return msg;
        }
    }

    /// <summary>
    ///     相互作用メッセージ送信時イベント用のイベント引数です。
    /// </summary>
    public class InteractionMessageRaisedEventArgs : EventArgs
    {
        [NotNull] private InteractionMessage _message;

        /// <summary>
        ///     コンストラクタ
        /// </summary>
        /// <param name="message">InteractionMessage</param>
        public InteractionMessageRaisedEventArgs([NotNull] InteractionMessage message)
        {
            _message = message ?? throw new ArgumentNullException(nameof(message));
        }

        /// <summary>
        ///     送信されたメッセージ
        /// </summary>
        [NotNull]
        public InteractionMessage Message
        {
            get { return _message; }
            set { _message = value ?? throw new ArgumentNullException(nameof(value)); }
        }
    }
}