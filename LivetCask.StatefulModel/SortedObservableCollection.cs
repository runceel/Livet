using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace Livet.StatefulModel
{
    public sealed class SortedObservableCollection<TSource, TKey> : NotifyChangedCollection<TSource>,ISynchronizableNotifyChangedCollection<TSource>
    {
        private readonly Func<TSource, TKey> _keySelector;
        private readonly IComparer<TKey> _comparer;

        public SortedObservableCollection(Func<TSource, TKey> keySelector, bool isDescending = false)
            : this(Enumerable.Empty<TSource>(), keySelector, null, isDescending) { }

        public SortedObservableCollection(Func<TSource, TKey> keySelector, IComparer<TKey> comparer,bool isDescending = false)
            : this(Enumerable.Empty<TSource>(), keySelector, comparer, isDescending) { }

        public SortedObservableCollection(IEnumerable<TSource> collection, Func<TSource, TKey> keySelector, bool isDescending = false)
            : this(collection, keySelector, null, isDescending) { }

        public SortedObservableCollection(IEnumerable<TSource> collection, Func<TSource, TKey> keySelector, IComparer<TKey> comparer, bool isDescending = false)
        {
            if (collection == null) throw new ArgumentNullException(nameof(collection));
            if (keySelector == null) throw new ArgumentNullException(nameof(keySelector));

            _keySelector = keySelector;

            if(comparer == null)
            {
                _comparer = new AnonymousComparer<TKey>((x,y) =>
                    {
                        var comparableSource = x as IComparable;
                        var comparableTarget = y as IComparable;

                        if (comparableSource != null)
                        {
                            return comparableSource.CompareTo(comparableTarget);
                        }

                        return 0;
                    });
            }
            var sourceComparer = _comparer;
            _comparer = isDescending ? new AnonymousComparer<TKey>((x, y) => sourceComparer.Compare(x, y) * -1) : _comparer;

            Synchronizer = new Synchronizer<TSource>(this);

            foreach (var item in collection)
            {
                Add(item);
            }
        }

        protected override void InsertItem(int index, TSource item)
        {
            lock (Synchronizer.LockObject)
            {
                base.InsertItem(FindNewIndex(item), item);
            }
        }
        protected override void MoveItem(int oldIndex, int newIndex)
        {
            throw new NotSupportedException("Move is not supported.");
        }

        protected override void RemoveItem(int index)
        {
            lock (Synchronizer.LockObject)
            {
                base.RemoveItem(index);
            }
        }

        protected override void ReplaceItem(int index, TSource newItem)
        {
            RemoveItem(index);
            InsertItem(FindNewIndex(newItem), newItem);
        }

        protected override void ClearItems()
        {
            lock (Synchronizer.LockObject)
            {
                base.ClearItems();
            }
        }

        public void Move(int oldIndex, int newIndex)
        {
            MoveItem(oldIndex,newIndex);
        }

        public Synchronizer<TSource> Synchronizer { get; }

        public void Dispose() => Synchronizer.Dispose();

        private int FindNewIndex(TSource target)
        {
            if (Count == 0) return 0;

            if (Compare(target, this[0]) < 0)
            {
                return 0;
            }

            if (Compare(target, this[Count - 1]) > 0)
            {
                return Count;
            }

            var range = new IndexRange(0, Count - 1);
            return FindNextRangeCore(range, target).StartIndex;
        }

        private IndexRange FindNextRangeCore(IndexRange currentRange, TSource target)
        {
            if (currentRange.IsOne) return currentRange;

            if (currentRange.Count == 2 && Compare(target, this[currentRange.StartIndex]) > 0 && Compare(target, this[currentRange.EndIndex]) < 0)
            {
                return new IndexRange(currentRange.StartIndex + 1, currentRange.StartIndex + 1);
            }

            if (Compare(target, this[currentRange.CenterIndex]) == 0)
            {
                int i = currentRange.CenterIndex;
                while (i < Count && Compare(target, this[i]) == 0)
                {
                    i++;
                }

                return new IndexRange(i, i);
            }

            if (Compare(target, this[currentRange.CenterIndex]) < 0)
            {
                return FindNextRangeCore(new IndexRange(currentRange.StartIndex, currentRange.CenterIndex), target);
            }
            else
            {
                return FindNextRangeCore(new IndexRange(currentRange.CenterIndex + 1, currentRange.EndIndex), target);
            }
        }

        private int Compare(TSource source, TSource target)
        {
            return _comparer.Compare(_keySelector(source), _keySelector(target));
        }

        private class IndexRange
        {
            public IndexRange(int startIndex, int endIndex)
            {
                StartIndex = startIndex;
                EndIndex = endIndex;
            }

            public int StartIndex { get; }
            public int EndIndex { get;}
            public int CenterIndex => (StartIndex + EndIndex) / 2;
            public bool IsOne => StartIndex == EndIndex;
            public int Count => EndIndex - StartIndex + 1;
        }
    }

    public static class SortedObservableCollectionExtensions
    {
        public static SortedObservableCollection<TSource, TKey> ToSyncedSortedObservableCollection<TSource, TKey>(
            this ISynchronizableNotifyChangedCollection<TSource> source, 
            Func<TSource, TKey> keySelector, 
            IComparer<TKey> comparer = null, 
            bool isDescending = false)
        {
            var isDisposableType = typeof(IDisposable).GetTypeInfo().IsAssignableFrom(typeof(TSource).GetTypeInfo());

            lock (source.Synchronizer.LockObject)
            {
                var result = new SortedObservableCollection<TSource, TKey>(keySelector, comparer, isDescending);

                foreach (var item in source)
                {
                    result.Add(item);
                }

                var collectionChangedListener = SynchronizableNotifyChangedCollectionHelper.CreateSynchronizableCollectionChangedEventListener(source, result,
                    _ => _,
                    removeAction: e =>
                    {
                        var removeSourceItem = (TSource)e.OldItems[0];
                        result.RemoveAt(result.IndexOf(removeSourceItem));
                        if (isDisposableType)
                        {
                            ((IDisposable)removeSourceItem).Dispose();
                        }
                    },
                    moveAction: e => { },
                    replaceAction: e =>
                    {
                        var removeSourceItem = (TSource)e.OldItems[0];
                        result.RemoveAt(result.IndexOf(removeSourceItem));
                        result.Add((TSource)e.NewItems[0]);
                        if (isDisposableType)
                        {
                            ((IDisposable)removeSourceItem).Dispose();
                        }
                    }
                    );
                result.Synchronizer.EventListeners.Add(collectionChangedListener);
                return result;
            }
        }
    }
}
