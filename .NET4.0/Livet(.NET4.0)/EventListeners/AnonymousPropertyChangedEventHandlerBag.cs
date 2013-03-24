using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace Livet.EventListeners
{
    internal class AnonymousPropertyChangedEventHandlerBag: IEnumerable<KeyValuePair<string,ConcurrentBag<PropertyChangedEventHandler>>>, IDisposable
    {
        private ConcurrentDictionary<string, ConcurrentBag<PropertyChangedEventHandler>> _handlerDictionary = new ConcurrentDictionary<string, ConcurrentBag<PropertyChangedEventHandler>>();
        private WeakReference<INotifyPropertyChanged> _source;

        internal AnonymousPropertyChangedEventHandlerBag(INotifyPropertyChanged source)
        {
            if (source == null) throw new ArgumentNullException("source");

            _source = new WeakReference<INotifyPropertyChanged>(source);
        }

        internal AnonymousPropertyChangedEventHandlerBag(INotifyPropertyChanged source, PropertyChangedEventHandler handler)
            : this(source)
        {
            if (handler == null) throw new ArgumentNullException("handler");
            RegisterHandler(handler);
        }

        internal void RegisterHandler(PropertyChangedEventHandler handler)
        {
            _handlerDictionary.GetOrAdd(string.Empty, _ => new ConcurrentBag<PropertyChangedEventHandler>()).Add(handler);
        }

        internal void RegisterHandler(string propertyName, PropertyChangedEventHandler handler)
        {
            _handlerDictionary.GetOrAdd(propertyName, _ => new ConcurrentBag<PropertyChangedEventHandler>()).Add(handler);
        }

        internal void RegisterHandler<T>(Expression<Func<T>> propertyExpression, PropertyChangedEventHandler handler)
        {
            if (propertyExpression == null) throw new ArgumentNullException("propertyExpression");

            if (!(propertyExpression.Body is MemberExpression)) throw new NotSupportedException("このメソッドでは ()=>プロパティ の形式のラムダ式以外許可されません");

            var memberExpression = (MemberExpression)propertyExpression.Body;

            RegisterHandler(memberExpression.Member.Name, handler);
        }

        internal void ExecuteHandler(PropertyChangedEventArgs e)
        {
            INotifyPropertyChanged sourceResult;
            var result = _source.TryGetTarget(out sourceResult);

            if (!result) return;

            if (e.PropertyName != null)
            {
                ConcurrentBag<PropertyChangedEventHandler> list;
                _handlerDictionary.TryGetValue(e.PropertyName, out list);

                if (list != null)
                {
                    foreach (var handler in list)
                    {
                        handler(sourceResult, e);
                    }
                }
            }

            ConcurrentBag<PropertyChangedEventHandler> allList;
            _handlerDictionary.TryGetValue(string.Empty, out allList);
            if (allList != null)
            {
                foreach (var handler in allList)
                {
                    handler(sourceResult, e);
                }
            }
        }

        IEnumerator<KeyValuePair<string, ConcurrentBag<PropertyChangedEventHandler>>> IEnumerable<KeyValuePair<string, ConcurrentBag<PropertyChangedEventHandler>>>.GetEnumerator()
        {
            return _handlerDictionary.GetEnumerator();
        }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return _handlerDictionary.GetEnumerator();
        }

        internal void Add(PropertyChangedEventHandler handler)
        {
            RegisterHandler(handler);
        }

        internal void Add(string propertyName, PropertyChangedEventHandler handler)
        {
            RegisterHandler(propertyName, handler);
        }


        internal void Add(string propertyName, params PropertyChangedEventHandler[] handlers)
        {
            foreach (var handler in handlers)
            {
                RegisterHandler(propertyName, handler);
            }
        }

        internal void Add<T>(Expression<Func<T>> propertyExpression, PropertyChangedEventHandler handler)
        {
            if (propertyExpression == null) throw new ArgumentNullException("propertyExpression");

            if (!(propertyExpression.Body is MemberExpression)) throw new NotSupportedException("このメソッドでは ()=>プロパティ の形式のラムダ式以外許可されません");

            var memberExpression = (MemberExpression)propertyExpression.Body;

            Add(memberExpression.Member.Name, handler);
        }


        internal void Add<T>(Expression<Func<T>> propertyExpression, params PropertyChangedEventHandler[] handlers)
        {
            if (propertyExpression == null) throw new ArgumentNullException("propertyExpression");

            if (!(propertyExpression.Body is MemberExpression)) throw new NotSupportedException("このメソッドでは ()=>プロパティ の形式のラムダ式以外許可されません");

            var memberExpression = (MemberExpression)propertyExpression.Body;

            Add(memberExpression.Member.Name, handlers);
        }

        public void Dispose()
        {
            PropertyChangedEventHandler dummy;
            foreach (var bag in _handlerDictionary.Values)
            {
                while (!bag.IsEmpty)
                {
                    bag.TryTake(out dummy);
                }
            }
            _handlerDictionary.Clear();
        }
    }
}
