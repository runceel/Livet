using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Linq.Expressions;
using Livet.Annotations;

namespace Livet.EventListeners.Internals
{
    internal class AnonymousPropertyChangedEventHandlerBag : IEnumerable<KeyValuePair<string, List<PropertyChangedEventHandler>>>
    {
        [NotNull] private readonly Dictionary<string, List<PropertyChangedEventHandler>> _handlerDictionary =
            new Dictionary<string, List<PropertyChangedEventHandler>>();

        [NotNull] private readonly object _handlerDictionaryLockObject = new object();

        [NotNull] private readonly Dictionary<List<PropertyChangedEventHandler>, object> _lockObjectDictionary =
            new Dictionary<List<PropertyChangedEventHandler>, object>();

        [NotNull] private readonly WeakReference<INotifyPropertyChanged> _source;

        public AnonymousPropertyChangedEventHandlerBag(INotifyPropertyChanged source)
        {
            if (source == null) throw new ArgumentNullException(nameof(source));

            _source = new WeakReference<INotifyPropertyChanged>(source);
        }

        public AnonymousPropertyChangedEventHandlerBag(INotifyPropertyChanged source,
            PropertyChangedEventHandler handler)
            : this(source)
        {
            if (handler == null) throw new ArgumentNullException(nameof(handler));
            RegisterHandler(handler);
        }

        IEnumerator<KeyValuePair<string, List<PropertyChangedEventHandler>>>
            IEnumerable<KeyValuePair<string, List<PropertyChangedEventHandler>>>.GetEnumerator()
        {
            // ReSharper disable once InconsistentlySynchronizedField
            return _handlerDictionary.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            // ReSharper disable once InconsistentlySynchronizedField
            return _handlerDictionary.GetEnumerator();
        }

        public void RegisterHandler([NotNull] PropertyChangedEventHandler handler)
        {
            if (handler == null) throw new ArgumentNullException(nameof(handler));

            RegisterHandler(string.Empty, handler);
        }

        public void RegisterHandler([NotNull] string propertyName, [NotNull] PropertyChangedEventHandler handler)
        {
            if (propertyName == null) throw new ArgumentNullException(nameof(propertyName));
            if (handler == null) throw new ArgumentNullException(nameof(handler));

            lock (_handlerDictionaryLockObject)
            {
                if (!_handlerDictionary.TryGetValue(propertyName, out var bag))
                {
                    bag = new List<PropertyChangedEventHandler>();
                    _lockObjectDictionary.Add(bag, new object());
                    _handlerDictionary[propertyName] = bag;
                }

                bag.Add(handler);
            }
        }

        public void RegisterHandler<T>([NotNull] Expression<Func<T>> propertyExpression,
            [NotNull] PropertyChangedEventHandler handler)
        {
            if (propertyExpression == null) throw new ArgumentNullException(nameof(propertyExpression));
            if (handler == null) throw new ArgumentNullException(nameof(handler));
            if (!(propertyExpression.Body is MemberExpression))
                throw new NotSupportedException("このメソッドでは ()=>プロパティ の形式のラムダ式以外許可されません");

            var memberExpression = (MemberExpression) propertyExpression.Body;

            RegisterHandler(memberExpression.Member.Name, handler);
        }

        public void ExecuteHandler([NotNull] PropertyChangedEventArgs e)
        {
            if (e == null) throw new ArgumentNullException(nameof(e));

            var result = _source.TryGetTarget(out var sourceResult);
            if (!result) return;

            if (e.PropertyName != null)
            {
                List<PropertyChangedEventHandler> list;
                lock (_handlerDictionaryLockObject) { _handlerDictionary.TryGetValue(e.PropertyName, out list); }

                if (list != null)
                {
                    var lockObject = _lockObjectDictionary[list];
                    if (lockObject != null)
                    {
                        lock (lockObject)
                        {
                            foreach (var handler in list) handler(sourceResult, e);
                        }
                    }
                }
            }

            lock (_handlerDictionaryLockObject)
            {
                _handlerDictionary.TryGetValue(string.Empty, out var allList);
                // ReSharper disable once InvertIf
                if (allList != null)
                {
                    var lockObject = _lockObjectDictionary[allList];
                    // ReSharper disable once InvertIf
                    if (lockObject != null)
                    {
                        lock (lockObject)
                        {
                            foreach (var handler in allList) handler(sourceResult, e);
                        }
                    }
                }
            }
        }

        public void Add([NotNull] PropertyChangedEventHandler handler)
        {
            if (handler == null) throw new ArgumentNullException(nameof(handler));

            RegisterHandler(handler);
        }

        public void Add([NotNull] string propertyName, [NotNull] PropertyChangedEventHandler handler)
        {
            if (propertyName == null) throw new ArgumentNullException(nameof(propertyName));

            RegisterHandler(propertyName, handler);
        }

        public void Add([NotNull] string propertyName, [NotNull] params PropertyChangedEventHandler[] handlers)
        {
            if (propertyName == null) throw new ArgumentNullException(nameof(propertyName));
            if (handlers == null) throw new ArgumentNullException(nameof(handlers));

            foreach (var handler in handlers.Where(h => h != null)) RegisterHandler(propertyName, handler);
        }

        public void Add<T>([NotNull] Expression<Func<T>> propertyExpression,
            [NotNull] PropertyChangedEventHandler handler)
        {
            if (propertyExpression == null) throw new ArgumentNullException(nameof(propertyExpression));
            if (handler == null) throw new ArgumentNullException(nameof(handler));
            if (!(propertyExpression.Body is MemberExpression))
                throw new NotSupportedException("このメソッドでは ()=>プロパティ の形式のラムダ式以外許可されません");

            var memberExpression = (MemberExpression) propertyExpression.Body;

            Add(memberExpression.Member.Name, handler);
        }

        public void Add<T>([NotNull] Expression<Func<T>> propertyExpression,
            [NotNull] params PropertyChangedEventHandler[] handlers)
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