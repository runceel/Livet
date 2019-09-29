using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace Livet.StatefulModel
{
    public sealed class FilteredObservableCollection<T> : NotifyChangedCollection<T>, ISynchronizableNotifyChangedCollection<T>
    { 
        public FilteredObservableCollection(Func<T,bool> filter) : this(Enumerable.Empty<T>(), filter) { }

        public FilteredObservableCollection(IEnumerable<T> collection, Func<T, bool> filter) : base(collection)
        {
            if (collection == null) throw new ArgumentNullException(nameof(collection));
            if (filter == null) throw new ArgumentNullException(nameof(filter));
            Synchronizer = new Synchronizer<T>(this);
            Filter = filter;
        }

        public Func<T,bool> Filter { get; set; }
        public Synchronizer<T> Synchronizer { get; }

        public void Move(int oldIndex, int newIndex)
        {
            base.MoveItem(oldIndex,newIndex);
        }

        protected override void InsertItem(int index, T newItem)
        {
            if(!Filter(newItem)) return;
            base.InsertItem(index, newItem);
        }

        protected override void ReplaceItem(int index, T newItem)
        {
            if (!Filter(newItem)) return;
            base.ReplaceItem(index, newItem);
        }

        public void Dispose() => Synchronizer.Dispose();
    }

    public static class FilteredObservableCollectionExtensions
    {
        public static FilteredObservableCollection<T> ToSyncedFilteredObservableCollection<T>(
            this ISynchronizableNotifyChangedCollection<T> source, Func<T, bool> filter) => ToSyncedFilteredObservableCollection(source, _ => _,filter);

        public static FilteredObservableCollection<TResult> ToSyncedFilteredObservableCollection<TSource, TResult>(
            this ISynchronizableNotifyChangedCollection<TSource> source,
            Func<TSource, TResult> converter,
            Func<TResult,bool> filter )
        {
            var isDisposableType = typeof(IDisposable).GetTypeInfo().IsAssignableFrom(typeof(TResult).GetTypeInfo());

            lock (source.Synchronizer.LockObject)
            {
                var result = new FilteredObservableCollection<TResult>(filter);
                foreach (var item in source)
                {
                    result.Add(converter(item));
                }

                var collectionChangedListener =
                    SynchronizableNotifyChangedCollectionHelper.CreateSynchronizableCollectionChangedEventListener(
                        source, result,
                        converter,
                        addAction: e =>
                        {
                            var vm = converter((TSource) e.NewItems[0]);
                            if(!filter(vm)) return;
                            result.Insert(e.NewStartingIndex, vm);
                        },
                        replaceAction: e =>
                        {
                            if (isDisposableType)
                            {
                                ((IDisposable)result[e.NewStartingIndex]).Dispose();
                            }
                            var replaceVm = converter((TSource)e.NewItems[0]);
                            if (!filter(replaceVm)) return;
                            result[e.NewStartingIndex] = replaceVm;
                        });
                result.Synchronizer.EventListeners.Add(collectionChangedListener);
                return result;
            }
        }
    }
}
