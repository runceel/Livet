using Livet.Collections;
using System;
using System.Collections;
using System.Collections.Generic;

namespace Livet
{
    public class MultipleDisposable : IDisposable, ICollection<IDisposable>
    {
        private readonly List<IDisposable> _targetLists;
        private bool _disposed;
        private readonly object _lockObject = new object();

        public MultipleDisposable()
        {
            _targetLists = new List<IDisposable>();
        }

        public MultipleDisposable(IEnumerable<IDisposable> sourceDisposableList)
        {
            if (sourceDisposableList == null) throw new ArgumentNullException(nameof(sourceDisposableList));

            _targetLists = new List<IDisposable>(sourceDisposableList);
        }

        public IEnumerator<IDisposable> GetEnumerator()
        {
            ThrowExceptionIfDisposed();
            lock (_lockObject)
            {
                return ((IEnumerable<IDisposable>)_targetLists.ToArray()).GetEnumerator();
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            ThrowExceptionIfDisposed();
            lock (_lockObject)
            {
                return ((IEnumerable<IDisposable>)_targetLists.ToArray()).GetEnumerator();
            }
        }

        public void Add(IDisposable item)
        {
            ThrowExceptionIfDisposed();
            lock (_lockObject)
            {
                _targetLists.Add(item);
            }
        }

        public void Add(Action releaseAction)
        {
            ThrowExceptionIfDisposed();
            var disposable = new AnonymousDisposable(releaseAction);
            lock (_lockObject)
            {
                _targetLists.Add(disposable);
            }
        }

        public void AddFirst(IDisposable item)
        {
            ThrowExceptionIfDisposed();
            lock (_lockObject)
            {
                _targetLists.Insert(0, item);
            }
        }

        public void AddFirst(Action releaseAction)
        {
            ThrowExceptionIfDisposed();
            var disposable = new AnonymousDisposable(releaseAction);
            lock (_lockObject)
            {
                _targetLists.Insert(0, disposable);
            }
        }

        public void Clear()
        {
            ThrowExceptionIfDisposed();
            lock (_lockObject)
            {
                _targetLists.Clear();
            }
        }

        public bool Contains(IDisposable item)
        {
            ThrowExceptionIfDisposed();
            lock (_lockObject)
            {
                return _targetLists.Contains(item);
            }
        }

        public void CopyTo(IDisposable[] array, int arrayIndex)
        {
            ThrowExceptionIfDisposed();
            lock (_lockObject)
            {
                _targetLists.CopyTo(array, arrayIndex);
            }
        }

        public int Count
        {
            get
            {
                ThrowExceptionIfDisposed();
                lock (_lockObject)
                {
                    return _targetLists.Count;
                }
            }
        }

        public bool IsReadOnly
        {
            get
            {
                ThrowExceptionIfDisposed();
                return false;
            }

        }

        public bool Remove(IDisposable item)
        {
            ThrowExceptionIfDisposed();

            lock (_lockObject)
            {
                return _targetLists.Remove(item);
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
                lock (_lockObject)
                {
                    foreach(var item in _targetLists)
                    {
                        item.Dispose();
                    }
                }
            }
            _disposed = true;
        }

        protected void ThrowExceptionIfDisposed()
        {
            if (_disposed)
            {
                throw new ObjectDisposedException("CompositeDisposable");
            }
        }
    }
}
