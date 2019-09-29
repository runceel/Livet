using System;
using System.Collections.Generic;
using System.Reflection;

namespace Livet.StatefulModel
{
    public class Synchronizer<T> : IDisposable
    {
        protected bool Disposed;

        private readonly bool _isDisposableType;

        public Synchronizer(IList<T> currentCollection)
        {
            CurrentCollection = currentCollection;
            _isDisposableType = typeof(IDisposable).GetTypeInfo().IsAssignableFrom(typeof(T).GetTypeInfo());
        }

        public IList<T> CurrentCollection { get; }

        public LivetCompositeDisposable EventListeners { get; } = new LivetCompositeDisposable();

        public object LockObject { get; } = new object();

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (Disposed) return;

            if (disposing)
            {
                if (EventListeners.Count != 0)
                {
                    EventListeners.Dispose();
                    if (_isDisposableType)
                    {
                        foreach (var unknown in CurrentCollection)
                        {
                            var i = (IDisposable) unknown;
                            i.Dispose();
                        }
                    }
                    CurrentCollection.Clear();
                }
            }
            Disposed = true;
        }

    }
}
