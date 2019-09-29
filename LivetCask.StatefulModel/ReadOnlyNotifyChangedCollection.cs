using Livet.EventListeners.WeakEvents;
using System;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Reflection;

namespace Livet.StatefulModel
{
    public sealed class ReadOnlyNotifyChangedCollection<T> : ReadOnlyCollection<T>, INotifyCollectionChanged, INotifyPropertyChanged, IDisposable
    {
        private readonly bool _isDisposableType;

        public ReadOnlyNotifyChangedCollection(ISynchronizableNotifyChangedCollection<T> collection)
            : base(collection)
        {
            if (collection == null) throw new ArgumentNullException(nameof(collection));

            EventListeners = new LivetCompositeDisposable();

            _isDisposableType = typeof(IDisposable).GetTypeInfo().IsAssignableFrom(typeof(T).GetTypeInfo());

            lock (collection.Synchronizer.LockObject)
            {
                SourceCollection = collection;

                EventListeners.Add(new PropertyChangedWeakEventListener(SourceCollection, (sender, e) => OnPropertyChanged(e)));
                EventListeners.Add(new CollectionChangedWeakEventListener(SourceCollection, (sender, e) => OnCollectionChanged(e)));
            }
        }

        public ISynchronizableNotifyChangedCollection<T> SourceCollection { get;}

        public LivetCompositeDisposable EventListeners { get;}

        public event NotifyCollectionChangedEventHandler CollectionChanged;

        public event PropertyChangedEventHandler PropertyChanged;

        private void OnCollectionChanged(NotifyCollectionChangedEventArgs args) => CollectionChanged?.Invoke(this, args);

        private void OnPropertyChanged(PropertyChangedEventArgs args) => PropertyChanged?.Invoke(this, args);

        public void Dispose()
        {
            if (EventListeners.Count != 0)
            {
                EventListeners.Dispose();

                if (_isDisposableType)
                {
                    foreach (var unknown in this)
                    {
                        var i = (IDisposable)unknown;
                        i.Dispose();
                    }
                }
            }
        }
    }

    public static class ReadOnlyNotifyChangedCollectionExtensions
    {
        public static ReadOnlyNotifyChangedCollection<T> ToSyncedReadOnlyNotifyChangedCollection<T>(
            this ISynchronizableNotifyChangedCollection<T> source) => new ReadOnlyNotifyChangedCollection<T>(source);
    }
}
