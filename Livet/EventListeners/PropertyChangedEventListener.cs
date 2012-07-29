using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Collections.Concurrent;
using System.Linq.Expressions;

namespace Livet.EventListeners
{
    /// <summary>
    /// INotifyPropertyChanged.PropertyChangedを受信するためのイベントリスナです。
    /// </summary>
    public sealed class PropertyChangedEventListener : EventListener<PropertyChangedEventHandler>,IEnumerable<KeyValuePair<string,ConcurrentBag<PropertyChangedEventHandler>>>
    {
        private ConcurrentDictionary<string, ConcurrentBag<PropertyChangedEventHandler>> _handlerDictionary = new ConcurrentDictionary<string, ConcurrentBag<PropertyChangedEventHandler>>();
        private WeakReference<INotifyPropertyChanged> _source;

        /// <summary>
        /// コンストラクタ
        /// </summary>
        /// <param name="source">INotifyPropertyChangedオブジェクト</param>
        public PropertyChangedEventListener(INotifyPropertyChanged source)
        {
            if (source == null) throw new ArgumentNullException("source");

            _source = new WeakReference<INotifyPropertyChanged>(source);

            Initialize(h => source.PropertyChanged += h, h => source.PropertyChanged -= h, (sender, e) => ExecuteHandler(e));
        }

        /// <summary>
        /// コンストラクタ。リスナのインスタンスの作成と同時にハンドラを一つ登録します。
        /// </summary>
        /// <param name="source">INotifyPropertyChangedオブジェクト</param>
        /// <param name="handler">PropertyChangedイベントハンドラ</param>
        public PropertyChangedEventListener(INotifyPropertyChanged source, PropertyChangedEventHandler handler)
            :this(source)
        {
            if (handler == null) throw new ArgumentNullException("handler");
            RegisterHandler(handler);
        }

        /// <summary>
        /// このリスナインスタンスに新たなハンドラを追加します。
        /// </summary>
        /// <param name="handler">PropertyChangedイベントハンドラ</param>
        public void RegisterHandler(PropertyChangedEventHandler handler)
        {
            ThrowExceptionIfDisposed();
            _handlerDictionary.GetOrAdd(string.Empty, _ => new ConcurrentBag<PropertyChangedEventHandler>()).Add(handler);
        }

        /// <summary>
        /// このリスナインスタンスにプロパティ名でフィルタリング済のハンドラを追加します。
        /// </summary>
        /// <param name="propertyName">ハンドラを登録したいPropertyChagedEventArgs.PropertyNameの名前</param>
        /// <param name="handler">propertyNameで指定されたプロパティ用のPropertyChangedイベントハンドラ</param>
        public void RegisterHandler(string propertyName, PropertyChangedEventHandler handler)
        {
            ThrowExceptionIfDisposed();
            _handlerDictionary.GetOrAdd(propertyName, _ => new ConcurrentBag<PropertyChangedEventHandler>()).Add(handler);
        }

        /// <summary>
        /// このリスナインスタンスにプロパティ名でフィルタリング済のハンドラを追加します。
        /// </summary>
        /// <param name="propertyExpression">() => プロパティ形式のラムダ式</param>
        /// <param name="handler">propertyExpressionで指定されたプロパティ用のPropertyChangedイベントハンドラ</param>
        public void RegisterHandler<T>(Expression<Func<T>> propertyExpression, PropertyChangedEventHandler handler)
        {
            ThrowExceptionIfDisposed();

            if (propertyExpression == null) throw new ArgumentNullException("propertyExpression");

            if (!(propertyExpression.Body is MemberExpression)) throw new NotSupportedException("このメソッドでは ()=>プロパティ の形式のラムダ式以外許可されません");

            var memberExpression = (MemberExpression)propertyExpression.Body;

            RegisterHandler(memberExpression.Member.Name, handler);
        }

        private void ExecuteHandler(PropertyChangedEventArgs e)
        {
            INotifyPropertyChanged sourceResult;
            var result = _source.TryGetTarget(out sourceResult);

            if (!result) return;

            if (e.PropertyName != null && _handlerDictionary.ContainsKey(e.PropertyName))
            {
                foreach (var handler in _handlerDictionary[e.PropertyName])
                {
                    handler(sourceResult, e);
                }
            }

            if (_handlerDictionary.ContainsKey(string.Empty))
            {
                foreach (var handler in _handlerDictionary[string.Empty])
                {
                    handler(sourceResult, e);
                }
            }
        }

        IEnumerator<KeyValuePair<string, ConcurrentBag<PropertyChangedEventHandler>>> IEnumerable<KeyValuePair<string, ConcurrentBag<PropertyChangedEventHandler>>>.GetEnumerator()
        {
            ThrowExceptionIfDisposed();
            return _handlerDictionary.GetEnumerator();
        }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            ThrowExceptionIfDisposed();
            return _handlerDictionary.GetEnumerator();
        }

        public void Add(PropertyChangedEventHandler handler)
        {
            ThrowExceptionIfDisposed();
            RegisterHandler(handler);
        }

        public void Add(string propertyName, PropertyChangedEventHandler handler)
        {
            ThrowExceptionIfDisposed();
            RegisterHandler(propertyName, handler);
        }


        public void Add(string propertyName, params PropertyChangedEventHandler[] handlers)
        {
            ThrowExceptionIfDisposed();
            foreach (var handler in handlers)
            {
                RegisterHandler(propertyName, handler);
            }
        }

        public void Add<T>(Expression<Func<T>> propertyExpression, PropertyChangedEventHandler handler)
        {
            ThrowExceptionIfDisposed();

            if (propertyExpression == null) throw new ArgumentNullException("propertyExpression");

            if (!(propertyExpression.Body is MemberExpression)) throw new NotSupportedException("このメソッドでは ()=>プロパティ の形式のラムダ式以外許可されません");

            var memberExpression = (MemberExpression)propertyExpression.Body;

            Add(memberExpression.Member.Name, handler);
        }


        public void Add<T>(Expression<Func<T>> propertyExpression, params PropertyChangedEventHandler[] handlers)
        {
            ThrowExceptionIfDisposed();

            if (propertyExpression == null) throw new ArgumentNullException("propertyExpression");

            if (!(propertyExpression.Body is MemberExpression)) throw new NotSupportedException("このメソッドでは ()=>プロパティ の形式のラムダ式以外許可されません");

            var memberExpression = (MemberExpression)propertyExpression.Body;

            Add(memberExpression.Member.Name, handlers);
        }
    }

}
