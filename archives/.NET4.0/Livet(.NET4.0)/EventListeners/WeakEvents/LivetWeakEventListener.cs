using System;

namespace Livet.EventListeners.WeakEvents
{
    /// <summary>
    /// 汎用WeakEventリスナオブジェクトです。
    /// </summary>
    /// <typeparam name="THandler">対象のイベントのイベントハンドラ型</typeparam>
    /// <typeparam name="TEventArgs">対象のイベントのイベント引数型</typeparam>
    public class LivetWeakEventListener<THandler, TEventArgs> : IDisposable where TEventArgs : EventArgs
    {
        private bool _disposed;

        private EventHandler<TEventArgs> _handler;
        private THandler _resultHandler;
        private Action<THandler> _remove;
        private bool _initialized;

        private static void ReceiveEvent(WeakReference<LivetWeakEventListener<THandler, TEventArgs>> listenerWeakReference, object sender, TEventArgs args)
        {
            LivetWeakEventListener<THandler, TEventArgs> listenerResult;

            if (listenerWeakReference.TryGetTarget(out listenerResult))
            {
                var handler = listenerResult._handler;

                if (handler != null)
                {
                    handler(sender, args);
                }
            }
        }

        private static THandler GetStaticHandler(WeakReference<LivetWeakEventListener<THandler, TEventArgs>> listenerWeakReference, Func<EventHandler<TEventArgs>, THandler> conversion)
        {
            return conversion((sender, e) => ReceiveEvent(listenerWeakReference, sender, e));
        }

        protected LivetWeakEventListener()
        {

        }

        protected void Initialize(Func<EventHandler<TEventArgs>, THandler> conversion, Action<THandler> add, Action<THandler> remove, EventHandler<TEventArgs> handler)
        {
            if (_initialized) return;

            if (conversion == null) throw new ArgumentNullException("conversion");
            if (add == null) throw new ArgumentNullException("add");
            if (remove == null) throw new ArgumentNullException("remove");
            if (handler == null) throw new ArgumentNullException("handler");

            _handler = handler;
            _remove = remove;

            _resultHandler = GetStaticHandler(new WeakReference<LivetWeakEventListener<THandler, TEventArgs>>(this), conversion);

            add(_resultHandler);
        }


        /// <summary>
        /// コンストラクタ
        /// </summary>
        /// <param name="conversion">ジェネリックイベントハンドラ型をTHandler方に変換するFunc</param>
        /// <param name="add">h => obj.Event += > h の様な形でイベントの購読を登録するためのAction。hはTHandler型です。</param>
        /// <param name="remove">h => obj.Event += > h の様な形でイベントの購読を登録するためのAction。hはTHandler型です。</param>
        /// <param name="handler">イベントを受信した際に行いたいアクション</param>
        public LivetWeakEventListener(Func<EventHandler<TEventArgs>, THandler> conversion, Action<THandler> add, Action<THandler> remove, EventHandler<TEventArgs> handler)
        {
            Initialize(conversion,add,remove,handler);
            _initialized = true;
        }

        protected void ThrowExceptionIfDisposed()
        {
            if (_disposed)
            {
                throw new ObjectDisposedException("LivetWeakEventListener");
            }
        }

        /// <summary>
        /// イベントソースとの接続を解除します。
        /// </summary>
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (_disposed) return;

            if (disposing)
            {
                _remove(_resultHandler);
                _handler = null;
                _resultHandler = default(THandler);
                _remove = null;
            }
            _disposed = true;
        }
    }
}
