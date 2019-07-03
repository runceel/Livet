using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq.Expressions;
using Livet.Annotations;

namespace Livet.EventListeners
{
    internal class
        AnonymousPropertyChangedEventHandlerBag : IEnumerable<KeyValuePair<string, List<PropertyChangedEventHandler>>>
    {
        [NotNull] private readonly Dictionary<string, List<PropertyChangedEventHandler>> _handlerDictionary =
            new Dictionary<string, List<PropertyChangedEventHandler>>();

        [NotNull] private readonly object _handlerDictionaryLockObject = new object();

        [NotNull] private readonly Dictionary<List<PropertyChangedEventHandler>, object> _lockObjectDictionary =
            new Dictionary<List<PropertyChangedEventHandler>, object>();

        [NotNull] private readonly WeakReference<INotifyPropertyChanged> _source;

        internal AnonymousPropertyChangedEventHandlerBag(INotifyPropertyChanged source)
        {
            if (source == null) throw new ArgumentNullException(nameof(source));

            _source = new WeakReference<INotifyPropertyChanged>(source);
        }

        internal AnonymousPropertyChangedEventHandlerBag(INotifyPropertyChanged source,
            PropertyChangedEventHandler handler)
            : this(source)
        {
            if (handler == null) throw new ArgumentNullException(nameof(handler));
            RegisterHandler(handler);
        }

        IEnumerator<KeyValuePair<string, List<PropertyChangedEventHandler>>>
            IEnumerable<KeyValuePair<string, List<PropertyChangedEventHandler>>>.GetEnumerator()
        {
            return _handlerDictionary.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return _handlerDictionary.GetEnumerator();
        }

        internal void RegisterHandler(PropertyChangedEventHandler handler)
        {
            RegisterHandler(string.Empty, handler);
        }

        internal void RegisterHandler([NotNull] string propertyName, PropertyChangedEventHandler handler)
        {
            if (propertyName == null) throw new ArgumentNullException(nameof(propertyName));

            lock (_handlerDictionaryLockObject)
            {
                List<PropertyChangedEventHandler> bag;
                if (!_handlerDictionary.TryGetValue(propertyName, out bag))
                {
                    bag = new List<PropertyChangedEventHandler>();
                    _lockObjectDictionary.Add(bag, new object());
                    _handlerDictionary[propertyName] = bag;
                }

                bag.Add(handler);
            }
        }

        internal void RegisterHandler<T>([NotNull] Expression<Func<T>> propertyExpression, PropertyChangedEventHandler handler)
        {
            if (propertyExpression == null) throw new ArgumentNullException(nameof(propertyExpression));
            if (!(propertyExpression.Body is MemberExpression))
                throw new NotSupportedException("このメソッドでは ()=>プロパティ の形式のラムダ式以外許可されません");

            var memberExpression = (MemberExpression) propertyExpression.Body;

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
                    lock (_lockObjectDictionary[list])
                    {
                        foreach (var handler in list) handler(sourceResult, e);
                    }
            }

            lock (_handlerDictionaryLockObject)
            {
                _handlerDictionary.TryGetValue(string.Empty, out var allList);
                if (allList != null)
                    lock (_lockObjectDictionary[allList])
                    {
                        foreach (var handler in allList) handler(sourceResult, e);
                    }
            }
        }

        internal void Add(PropertyChangedEventHandler handler)
        {
            RegisterHandler(handler);
        }

        internal void Add([NotNull] string propertyName, [NotNull] PropertyChangedEventHandler handler)
        {
            if (propertyName == null) throw new ArgumentNullException(nameof(propertyName));
            
            RegisterHandler(propertyName, handler);
        }


        internal void Add([NotNull] string propertyName, [NotNull] params PropertyChangedEventHandler[] handlers)
        {
            if (propertyName == null) throw new ArgumentNullException(nameof(propertyName));
            if (handlers == null) throw new ArgumentNullException(nameof(handlers));

            foreach (var handler in handlers) RegisterHandler(propertyName, handler);
        }

        internal void Add<T>([NotNull] Expression<Func<T>> propertyExpression, [NotNull] PropertyChangedEventHandler handler)
        {
            if (propertyExpression == null) throw new ArgumentNullException(nameof(propertyExpression));
            if (handler == null) throw new ArgumentNullException(nameof(handler));
            if (!(propertyExpression.Body is MemberExpression))
                throw new NotSupportedException("このメソッドでは ()=>プロパティ の形式のラムダ式以外許可されません");

            var memberExpression = (MemberExpression) propertyExpression.Body;

            Add(memberExpression.Member.Name, handler);
        }


        internal void Add<T>(Expression<Func<T>> propertyExpression, [NotNull] params PropertyChangedEventHandler[] handlers)
        {
            if (propertyExpression == null) throw new ArgumentNullException(nameof(propertyExpression));
            if (handlers == null) throw new ArgumentNullException(nameof(handlers));
            if (!(propertyExpression.Body is MemberExpression))
                throw new NotSupportedException("このメソッドでは ()=>プロパティ の形式のラムダ式以外許可されません");

            var memberExpression = (MemberExpression) propertyExpression.Body;

            Add(memberExpression.Member.Name, handlers);
        }
    }
}