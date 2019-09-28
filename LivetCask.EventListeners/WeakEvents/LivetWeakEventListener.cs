using System;
using Livet.Annotations;

namespace Livet.EventListeners.WeakEvents
{
    /// <summary>
    ///     汎用WeakEventリスナオブジェクトです。
    /// </summary>
    /// <typeparam name="THandler">対象のイベントのイベントハンドラ型</typeparam>
    /// <typeparam name="TEventArgs">対象のイベントのイベント引数型</typeparam>
    public class LivetWeakEventListener<THandler, TEventArgs> : IDisposable where TEventArgs : EventArgs
    {
        private readonly bool _initialized;
        private bool _disposed;

        [CanBeNull] private EventHandler<TEventArgs> _handler;
        [CanBeNull] private Action<THandler> _remove;
        [CanBeNull] private THandler _resultHandler;

        protected LivetWeakEventListener() { }

        /// <summary>
        ///     コンストラクタ
        /// </summary>
        /// <param name="conversion">ジェネリックイベントハンドラ型をTHandler方に変換するFunc</param>
        /// <param name="add">h => obj.Event += > h の様な形でイベントの購読を登録するためのAction。hはTHandler型です。</param>
        /// <param name="remove">h => obj.Event += > h の様な形でイベントの購読を登録するためのAction。hはTHandler型です。</param>
        /// <param name="handler">イベントを受信した際に行いたいアクション</param>
        public LivetWeakEventListener([NotNull] Func<EventHandler<TEventArgs>, THandler> conversion,
            [NotNull] Action<THandler> add,
            [NotNull] Action<THandler> remove, [NotNull] EventHandler<TEventArgs> handler)
        {
            if (conversion == null) throw new ArgumentNullException(nameof(conversion));
            if (add == null) throw new ArgumentNullException(nameof(add));
            if (remove == null) throw new ArgumentNullException(nameof(remove));
            if (handler == null) throw new ArgumentNullException(nameof(handler));

            Initialize(conversion, add, remove, handler);
            _initialized = true;
        }

        /// <summary>
        ///     イベントソースとの接続を解除します。
        /// </summary>
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        private static void ReceiveEvent(
            [NotNull] WeakReference<LivetWeakEventListener<THandler, TEventArgs>> listenerWeakReference, object sender,
            TEventArgs args)
        {
            if (listenerWeakReference == null) throw new ArgumentNullException(nameof(listenerWeakReference));

            if (listenerWeakReference.TryGetTarget(out var listenerResult))
                listenerResult?._handler?.Invoke(sender, args);
        }

        private static THandler GetStaticHandler(
            [NotNull] WeakReference<LivetWeakEventListener<THandler, TEventArgs>> listenerWeakReference,
            [NotNull] Func<EventHandler<TEventArgs>, THandler> conversion)
        {
            if (listenerWeakReference == null) throw new ArgumentNullException(nameof(listenerWeakReference));
            if (conversion == null) throw new ArgumentNullException(nameof(conversion));

            return conversion((sender, e) => ReceiveEvent(listenerWeakReference, sender, e));
        }

        protected void Initialize([NotNull] Func<EventHandler<TEventArgs>, THandler> conversion,
            [NotNull] Action<THandler> add,
            [NotNull] Action<THandler> remove, [NotNull] EventHandler<TEventArgs> handler)
        {
            if (_initialized) return;

            if (conversion == null) throw new ArgumentNullException(nameof(conversion));
            if (add == null) throw new ArgumentNullException(nameof(add));

            _handler = handler ?? throw new ArgumentNullException(nameof(handler));
            _remove = remove ?? throw new ArgumentNullException(nameof(remove));

            _resultHandler = GetStaticHandler(new WeakReference<LivetWeakEventListener<THandler, TEventArgs>>(this),
                conversion);

            add(_resultHandler);
        }

        protected void ThrowExceptionIfDisposed()
        {
            if (_disposed) throw new ObjectDisposedException("LivetWeakEventListener");
        }

        protected virtual void Dispose(bool disposing)
        {
            if (_disposed) return;

            if (disposing)
            {
                _remove?.Invoke(_resultHandler);
                _handler = null;
                _resultHandler = default;
                _remove = null;
            }

            _disposed = true;
        }
    }
}