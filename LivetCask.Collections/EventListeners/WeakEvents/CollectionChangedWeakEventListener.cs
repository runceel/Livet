using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;

namespace Livet.Collections.EventListeners.WeakEvents
{
    public sealed class CollectionChangedWeakEventListener : WeakEventListener<NotifyCollectionChangedEventHandler, NotifyCollectionChangedEventArgs>, IEnumerable<KeyValuePair<NotifyCollectionChangedAction, List<NotifyCollectionChangedEventHandler>>>
    {
        private readonly AnonymousCollectionChangedEventHandlerBag _bag;

        public CollectionChangedWeakEventListener(INotifyCollectionChanged source)
        {
            _bag = new AnonymousCollectionChangedEventHandlerBag(source);
            Initialize(
                h => new NotifyCollectionChangedEventHandler(h),
                h => source.CollectionChanged += h,
                h => source.CollectionChanged -= h,
                (sender, e) => _bag.ExecuteHandler(e));
        }

        public CollectionChangedWeakEventListener(INotifyCollectionChanged source, NotifyCollectionChangedEventHandler handler)
        {
            _bag = new AnonymousCollectionChangedEventHandlerBag(source, handler);
            Initialize(
                h => new NotifyCollectionChangedEventHandler(h),
                h => source.CollectionChanged += h,
                h => source.CollectionChanged -= h,
                (sender, e) => _bag.ExecuteHandler(e));
        }

        public void RegisterHandler(NotifyCollectionChangedEventHandler handler)
        {
            ThrowExceptionIfDisposed();
            _bag.RegisterHandler(handler);
        }

        public void RegisterHandler(NotifyCollectionChangedAction action, NotifyCollectionChangedEventHandler handler)
        {
            ThrowExceptionIfDisposed();
            _bag.RegisterHandler(action, handler);
        }

        IEnumerator<KeyValuePair<NotifyCollectionChangedAction, List<NotifyCollectionChangedEventHandler>>> IEnumerable<KeyValuePair<NotifyCollectionChangedAction, List<NotifyCollectionChangedEventHandler>>>.GetEnumerator()
        {
            return
                ((
                 IEnumerable
                     <KeyValuePair<NotifyCollectionChangedAction, List<NotifyCollectionChangedEventHandler>>>)
                 _bag).GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return ((
                 IEnumerable
                     <KeyValuePair<NotifyCollectionChangedAction, List<NotifyCollectionChangedEventHandler>>>)
                 _bag).GetEnumerator();
        }

        public void Add(NotifyCollectionChangedEventHandler handler)
        {
            ThrowExceptionIfDisposed();
            _bag.Add(handler);
        }

        public void Add(NotifyCollectionChangedAction action, NotifyCollectionChangedEventHandler handler)
        {
            ThrowExceptionIfDisposed();
            _bag.Add(action, handler);
        }

        public void Add(NotifyCollectionChangedAction action, params NotifyCollectionChangedEventHandler[] handlers)
        {
            ThrowExceptionIfDisposed();
            _bag.Add(action, handlers);
        }
    }
}
