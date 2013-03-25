using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace Livet.EventListeners
{
    internal class AnonymousCollectionChangedEventHandlerBag : IEnumerable<KeyValuePair<NotifyCollectionChangedAction, List<NotifyCollectionChangedEventHandler>>>
    {
        //private class Enumerator : IEnumerator<KeyValuePair<NotifyCollectionChangedAction, List<NotifyCollectionChangedEventHandler>>>
        //{
        //}

        private Dictionary<NotifyCollectionChangedAction, List<NotifyCollectionChangedEventHandler>> _handlerDictionary = new Dictionary<NotifyCollectionChangedAction, List<NotifyCollectionChangedEventHandler>>();
        private WeakReference<INotifyCollectionChanged> _source;

        private List<NotifyCollectionChangedEventHandler> _allHandlerList = new List<NotifyCollectionChangedEventHandler>();

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
            lock (_allHandlerList)
            {
                _allHandlerList.Add(handler);
            }
        }

        internal void RegisterHandler(NotifyCollectionChangedAction action, NotifyCollectionChangedEventHandler handler)
        {
            lock (_handlerDictionary)
            {
                List<NotifyCollectionChangedEventHandler> bag;
                if (!_handlerDictionary.TryGetValue(action, out bag))
                {
                    bag = new List<NotifyCollectionChangedEventHandler>();
                    _handlerDictionary[action] = bag;
                }
                bag.Add(handler);
            }
        }

        internal void ExecuteHandler(NotifyCollectionChangedEventArgs e)
        {
            INotifyCollectionChanged sourceResult;
            var result = _source.TryGetTarget(out sourceResult);

            if (!result) return;

            List<NotifyCollectionChangedEventHandler> list;
            lock (_handlerDictionary)
            {
                _handlerDictionary.TryGetValue(e.Action, out list);
            }
            if (list != null)
            {
                lock (list)
                {
                    foreach (var handler in list)
                    {
                        handler(sourceResult, e);
                    }
                }
            }

            lock (_allHandlerList)
            {
                if (_allHandlerList.Any())
                {
                    foreach (var handler in _allHandlerList)
                    {
                        handler(sourceResult, e);
                    }
                }
            }
        }

        IEnumerator<KeyValuePair<NotifyCollectionChangedAction, List<NotifyCollectionChangedEventHandler>>> IEnumerable<KeyValuePair<NotifyCollectionChangedAction, List<NotifyCollectionChangedEventHandler>>>.GetEnumerator()
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

        private void DisposeConcurrentBag(ConcurrentBag<NotifyCollectionChangedEventHandler> bag)
        {
            NotifyCollectionChangedEventHandler dummy;
            while (!bag.IsEmpty)
            {
                bag.TryTake(out dummy);
            }
        }
    }
}
