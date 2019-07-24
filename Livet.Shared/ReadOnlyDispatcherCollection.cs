using System;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Linq;
using System.Threading;
using System.Windows.Threading;
using Livet.Annotations;
using Livet.EventListeners;

namespace Livet
{
    /// <summary>
    ///     DispatcherCollectionの読み取り専用ラッパーです。<br />
    ///     ReadOnlyObservableCollectionなどと異なり、ソースコレクションの変更によってコレクションが変更された場合、<br />
    ///     変更通知を行います。
    /// </summary>
    /// <typeparam name="T">コレクションアイテムの型</typeparam>
    public class ReadOnlyDispatcherCollection<T> : ReadOnlyCollection<T>, INotifyCollectionChanged,
        INotifyPropertyChanged, IDisposable
    {
        [NotNull] private readonly DispatcherCollection<T> _list;
        [NotNull] private readonly LivetCompositeDisposable _listeners = new LivetCompositeDisposable();
        private bool _disposed;

        public ReadOnlyDispatcherCollection([NotNull] DispatcherCollection<T> collection) : base(collection)
        {
            _list = collection ?? throw new ArgumentNullException(nameof(collection));

            _listeners.Add(new PropertyChangedEventListener(
                _list,
                (sender, e) =>
                {
                    if (e != null) OnPropertyChanged(e);
                }));

            _listeners.Add(new CollectionChangedEventListener(
                _list,
                (sender, e) =>
                {
                    if (e != null) OnCollectionChanged(e);
                }));
        }

        /// <summary>
        ///     このコレクションが変更通知を行うDispatcherを取得します。
        /// </summary>
        [NotNull]
        public Dispatcher Dispatcher
        {
            get
            {
                ThrowExceptionIfDisposed();
                return _list.Dispatcher;
            }
        }

        /// <summary>
        ///     この読み取り専用コレクションのソースDispatcherCollectionを取得します。
        /// </summary>
        [NotNull]
        public DispatcherCollection<T> SourceCollection
        {
            get
            {
                ThrowExceptionIfDisposed();
                return _list;
            }
        }

        /// <summary>
        ///     この読み取り専用コレクションが保持するイベントリスナのコレクションを取得します。
        /// </summary>
        [NotNull]
        public LivetCompositeDisposable EventListeners
        {
            get
            {
                ThrowExceptionIfDisposed();
                return _listeners;
            }
        }

        /// <summary>
        ///     ソースコレクションとの連動を解除します。
        /// </summary>
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        /// <summary>
        ///     コレクションが変更された時に発生します。
        /// </summary>
        public event NotifyCollectionChangedEventHandler CollectionChanged;

        /// <summary>
        ///     プロパティが変更された時に発生します。
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnCollectionChanged([NotNull] NotifyCollectionChangedEventArgs args)
        {
            if (args == null) throw new ArgumentNullException(nameof(args));

            ThrowExceptionIfDisposed();
            var threadSafeHandler = Interlocked.CompareExchange(ref CollectionChanged, null, null);

            threadSafeHandler?.Invoke(this, args);
        }

        [NotifyPropertyChangedInvocator]
        protected void OnPropertyChanged([NotNull] PropertyChangedEventArgs args)
        {
            if (args == null) throw new ArgumentNullException(nameof(args));

            ThrowExceptionIfDisposed();
            var threadSafeHandler = Interlocked.CompareExchange(ref PropertyChanged, null, null);

            threadSafeHandler?.Invoke(this, args);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (_disposed) return;

            if (disposing)
            {
                _listeners.Dispose();

                if (typeof(IDisposable).IsAssignableFrom(typeof(T)))
                {
                    foreach (var i in _list.OfType<IDisposable>())
                        i.Dispose();
                }
            }

            _disposed = true;
        }

        protected void ThrowExceptionIfDisposed()
        {
            if (_disposed) throw new ObjectDisposedException("ReadOnlyDispatcherCollection");
        }
    }
}