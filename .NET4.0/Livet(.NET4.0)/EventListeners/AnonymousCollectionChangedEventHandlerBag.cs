using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace Livet.EventListeners
{
    internal class AnonymousCollectionChangedEventHandlerBag : IEnumerable<KeyValuePair<NotifyCollectionChangedAction, ConcurrentBag<NotifyCollectionChangedEventHandler>>>
    {
        private ConcurrentDictionary<NotifyCollectionChangedAction, ConcurrentBag<NotifyCollectionChangedEventHandler>> _handlerDictionary = new ConcurrentDictionary<NotifyCollectionChangedAction, ConcurrentBag<NotifyCollectionChangedEventHandler>>();
        private WeakReference<INotifyCollectionChanged> _source;

        private ConcurrentBag<NotifyCollectionChangedEventHandler> _allHandlerList = new ConcurrentBag<NotifyCollectionChangedEventHandler>();

        internal AnonymousCollectionChangedEventHandlerBag(INotifyCollectionChanged source)
        {
            if (source == null) throw new ArgumentNullException("source");
            _source = new WeakReference<INotifyCollectionChanged>(source);
        }

        internal AnonymousCollectionChangedEventHandlerBag(INotifyCollectionChanged source,NotifyCollectionChangedEventHandler handler) : this(source)
        {
            if (handler == null) throw new ArgumentNullException("handler");
            RegisterHandler(handler);
        }

        internal void RegisterHandler(NotifyCollectionChangedEventHandler handler)
        {
            _allHandlerList.Add(handler);
        }

        internal void RegisterHandler(NotifyCollectionChangedAction action, NotifyCollectionChangedEventHandler handler)
        {
            _handlerDictionary.GetOrAdd(action, _ => new ConcurrentBag<NotifyCollectionChangedEventHandler>()).Add(handler);
        }

        internal void ExecuteHandler(NotifyCollectionChangedEventArgs e)
        {
            INotifyCollectionChanged sourceResult;
            var result = _source.TryGetTarget(out sourceResult);

            if (!result) return;

            ConcurrentBag<NotifyCollectionChangedEventHandler> list;
            _handlerDictionary.TryGetValue(e.Action, out list);
            if (list != null)
            {
                foreach (var handler in list)
                {
                    handler(sourceResult, e);
                }
            }

            if (_allHandlerList.Any())
            {
                foreach (var handler in _allHandlerList)
                {
                    handler(sourceResult, e);
                }
            }
        }

        IEnumerator<KeyValuePair<NotifyCollectionChangedAction, ConcurrentBag<NotifyCollectionChangedEventHandler>>> IEnumerable<KeyValuePair<NotifyCollectionChangedAction, ConcurrentBag<NotifyCollectionChangedEventHandler>>>.GetEnumerator()
        {
            return _handlerDictionary.GetEnumerator();
        }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return _handlerDictionary.GetEnumerator();
        }

        internal void Add(NotifyCollectionChangedEventHandler handler)
        {
            RegisterHandler(handler);
        }

        internal void Add(NotifyCollectionChangedAction action, NotifyCollectionChangedEventHandler handler)
        {
            RegisterHandler(action, handler);
        }


        internal void Add(NotifyCollectionChangedAction action, params NotifyCollectionChangedEventHandler[] handlers)
        {
            foreach (var handler in handlers)
            {
                RegisterHandler(action, handler);
            }
        }
    }
}
