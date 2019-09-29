using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace Livet.StatefulModel
{
    public sealed class SynchronizationContextCollection<T> : NotifyChangedCollection<T>,ISynchronizableNotifyChangedCollection<T>
    {
        public SynchronizationContextCollection(SynchronizationContext context) : this(Enumerable.Empty<T>(), context) { }

        public SynchronizationContextCollection(IEnumerable<T> collection, SynchronizationContext context) : base(collection)
        {
            if (collection == null) throw new ArgumentNullException(nameof(collection));
            if (context == null) throw new ArgumentNullException(nameof(context));
            Synchronizer = new Synchronizer<T>(this);
            Context = context;
        }

        protected override void InsertItem(int index, T newItem) => DoActionWithLockOnContext(() => base.InsertItem(index, newItem));
        protected override void RemoveItem(int index) => DoActionWithLockOnContext(() => base.RemoveItem(index));
        protected override void ReplaceItem(int index, T newItem) => DoActionWithLockOnContext(() => base.ReplaceItem(index, newItem));
        protected override void MoveItem(int oldIndex, int newIndex) => DoActionWithLockOnContext(() => base.MoveItem(oldIndex,newIndex));
        protected override void ClearItems() => DoActionWithLockOnContext(base.ClearItems);

        public void Move(int oldIndex, int newIndex) => MoveItem(oldIndex, newIndex);

        public SynchronizationContext Context { get; }

        private void DoActionWithLockOnContext(Action action)
        {
            lock (Synchronizer.LockObject)
            {
                Context.Post(_ => action(), null);
            }
        }

        public Synchronizer<T> Synchronizer { get; }

        public void Dispose() => Synchronizer.Dispose();
    }

    public static class SynchronizationContextCollectionExtensions
    {
        public static SynchronizationContextCollection<T> ToSyncedSynchronizationContextCollection<T>(
            this ISynchronizableNotifyChangedCollection<T> source,
            SynchronizationContext context) => ToSyncedSynchronizationContextCollection(source, _ => _, context);

        public static SynchronizationContextCollection<TResult> ToSyncedSynchronizationContextCollection<TSource, TResult>(
            this ISynchronizableNotifyChangedCollection<TSource> source, 
            Func<TSource, TResult> converter,
            SynchronizationContext context)
        {
            lock (source.Synchronizer.LockObject)
            {
                var result = new SynchronizationContextCollection<TResult>(source.Select(converter),context);

                var collectionChangedListener = SynchronizableNotifyChangedCollectionHelper.CreateSynchronizableCollectionChangedEventListener(source, result,
                    converter);
                result.Synchronizer.EventListeners.Add(collectionChangedListener);
                return result;
            }
        }
    }
}
