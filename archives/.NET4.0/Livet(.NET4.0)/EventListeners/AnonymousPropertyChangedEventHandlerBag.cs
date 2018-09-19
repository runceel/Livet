using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace Livet.EventListeners
{
    internal class AnonymousPropertyChangedEventHandlerBag: IEnumerable<KeyValuePair<string,List<PropertyChangedEventHandler>>>
    {
        private Dictionary<string, List<PropertyChangedEventHandler>> _handlerDictionary = new Dictionary<string, List<PropertyChangedEventHandler>>();
        private WeakReference<INotifyPropertyChanged> _source;

        private object _handlerDictionaryLockObject = new object();
        private Dictionary<List<PropertyChangedEventHandler>,object> _lockObjectDictionary = new Dictionary<List<PropertyChangedEventHandler>, object>();

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
            RegisterHandler(string.Empty, handler);
        }

        internal void RegisterHandler(string propertyName, PropertyChangedEventHandler handler)
        {
            lock (_handlerDictionaryLockObject)
            {
                List<PropertyChangedEventHandler> bag;
                if (!_handlerDictionary.TryGetValue(propertyName, out bag))
                {
                    bag = new List<PropertyChangedEventHandler>();
                    _lockObjectDictionary.Add(bag,new object());
                    _handlerDictionary[propertyName] = bag;
                }
                bag.Add(handler);
            }
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
                List<PropertyChangedEventHandler> list;
                lock (_handlerDictionaryLockObject)
                {
                    _handlerDictionary.TryGetValue(e.PropertyName, out list);
                }

                if (list != null)
                {
                    lock (_lockObjectDictionary[list])
                    {
                        foreach (var handler in list)
                        {
                            handler(sourceResult, e);
                        }
                    }
                }
            }

            List<PropertyChangedEventHandler> allList;
            lock (_handlerDictionaryLockObject)
            {
                _handlerDictionary.TryGetValue(string.Empty, out allList);
                if (allList != null)
                {
                    lock (_lockObjectDictionary[allList])
                    {
                        foreach (var handler in allList)
                        {
                            handler(sourceResult, e);
                        }
                    }
                }
            }
        }

        IEnumerator<KeyValuePair<string, List<PropertyChangedEventHandler>>> IEnumerable<KeyValuePair<string, List<PropertyChangedEventHandler>>>.GetEnumerator()
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
    }
}
