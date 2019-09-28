using System;

namespace Livet.Collections.EventListeners.WeakEvents
{
    public class WeakEventListener<THandler, TEventArgs> : IDisposable where TEventArgs : EventArgs
    {
        private bool _disposed;

        private EventHandler<TEventArgs> _handler;
        private THandler _resultHandler;
        private Action<THandler> _remove;
        private readonly bool _initialized;

        private static void ReceiveEvent(WeakReference<WeakEventListener<THandler, TEventArgs>> listenerWeakReference, object sender, TEventArgs args)
        {
            WeakEventListener<THandler, TEventArgs> listenerResult;

            if (listenerWeakReference.TryGetTarget(out listenerResult))
            {
                listenerResult._handler?.Invoke(sender,args);
            }
        }

        private static THandler GetStaticHandler(WeakReference<WeakEventListener<THandler, TEventArgs>> listenerWeakReference, Func<EventHandler<TEventArgs>, THandler> conversion)
        {
            return conversion((sender, e) => ReceiveEvent(listenerWeakReference, sender, e));
        }

        protected WeakEventListener()
        {

        }

        protected void Initialize(Func<EventHandler<TEventArgs>, THandler> conversion, Action<THandler> add, Action<THandler> remove, EventHandler<TEventArgs> handler)
        {
            if (_initialized) return;

            if (conversion == null) throw new ArgumentNullException(nameof(conversion));
            if (add == null) throw new ArgumentNullException(nameof(add));
            if (remove == null) throw new ArgumentNullException(nameof(remove));
            if (handler == null) throw new ArgumentNullException(nameof(handler));

            _handler = handler;
            _remove = remove;

            _resultHandler = GetStaticHandler(new WeakReference<WeakEventListener<THandler, TEventArgs>>(this), conversion);

            add(_resultHandler);
        }

        public WeakEventListener(Func<EventHandler<TEventArgs>, THandler> conversion, Action<THandler> add, Action<THandler> remove, EventHandler<TEventArgs> handler)
        {
            Initialize(conversion, add, remove, handler);
            _initialized = true;
        }

        protected void ThrowExceptionIfDisposed()
        {
            if (_disposed)
            {
                throw new ObjectDisposedException("LivetWeakEventListener");
            }
        }

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
