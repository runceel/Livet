using System;

namespace Livet.Collections.EventListeners
{
    public class EventListener<THandler> : IDisposable where THandler : class
    {
        private THandler _handler;
        private Action<THandler> _add;
        private Action<THandler> _remove;
        private bool _disposed;

        private readonly bool _initialized;

        public EventListener(Action<THandler> add, Action<THandler> remove, THandler handler)
        {
            Initialize(add, remove, handler);
            _initialized = true;
        }

        protected EventListener()
        {

        }

        protected void Initialize(Action<THandler> add, Action<THandler> remove, THandler handler)
        {
            if (_initialized) return;

            if (add == null) throw new ArgumentNullException(nameof(add));
            if (remove == null) throw new ArgumentNullException(nameof(remove));
            if (handler == null) throw new ArgumentNullException(nameof(handler));

            _add = add;
            _handler = handler;
            _remove = remove;
            _add(handler);
        }

        protected void ThrowExceptionIfDisposed()
        {
            if (_disposed)
            {
                throw new ObjectDisposedException("EventListener");
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
                _remove(_handler);
                _add = null;
                _remove = null;
                _handler = null;
            }
            _disposed = true;
        }
    }
}
