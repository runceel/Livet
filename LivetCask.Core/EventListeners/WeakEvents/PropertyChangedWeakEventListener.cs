using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq.Expressions;
using Livet.Annotations;
using Livet.EventListeners.Internals;

namespace Livet.EventListeners.WeakEvents
{
    /// <summary>
    ///     INotifyPropertyChanged.PropertyChangedを受信するためのWeakイベントリスナです。
    /// </summary>
    public sealed class PropertyChangedWeakEventListener :
        LivetWeakEventListener<PropertyChangedEventHandler, PropertyChangedEventArgs>,
        IEnumerable<KeyValuePair<string, List<PropertyChangedEventHandler>>>
    {
        [NotNull] private readonly AnonymousPropertyChangedEventHandlerBag _bag;

        /// <summary>
        ///     コンストラクタ
        /// </summary>
        /// <param name="source">INotifyPropertyChangedオブジェクト</param>
        public PropertyChangedWeakEventListener([NotNull] INotifyPropertyChanged source)
        {
            if (source == null) throw new ArgumentNullException(nameof(source));

            _bag = new AnonymousPropertyChangedEventHandlerBag(source);
            Initialize(
                h => new PropertyChangedEventHandler(h ?? throw new ArgumentNullException(nameof(h))),
                h => source.PropertyChanged += h,
                h => source.PropertyChanged -= h,
                (sender, e) => _bag.ExecuteHandler(e ?? throw new ArgumentNullException(nameof(e))));
        }

        /// <summary>
        ///     コンストラクタ。リスナのインスタンスの作成と同時にハンドラを一つ登録します。
        /// </summary>
        /// <param name="source">INotifyPropertyChangedオブジェクト</param>
        /// <param name="handler">PropertyChangedイベントハンドラ</param>
        public PropertyChangedWeakEventListener([NotNull] INotifyPropertyChanged source,
            [NotNull] PropertyChangedEventHandler handler)
        {
            if (source == null) throw new ArgumentNullException(nameof(source));
            if (handler == null) throw new ArgumentNullException(nameof(handler));

            _bag = new AnonymousPropertyChangedEventHandlerBag(source, handler);
            Initialize(
                h => new PropertyChangedEventHandler(h ?? throw new ArgumentNullException(nameof(h))),
                h => source.PropertyChanged += h,
                h => source.PropertyChanged -= h,
                (sender, e) => _bag.ExecuteHandler(e ?? throw new ArgumentNullException(nameof(e))));
        }

        IEnumerator<KeyValuePair<string, List<PropertyChangedEventHandler>>>
            IEnumerable<KeyValuePair<string, List<PropertyChangedEventHandler>>>.GetEnumerator()
        {
            ThrowExceptionIfDisposed();
            return
                ((IEnumerable<KeyValuePair<string, List<PropertyChangedEventHandler>>>) _bag)
                .GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            ThrowExceptionIfDisposed();
            return ((IEnumerable<KeyValuePair<string, List<PropertyChangedEventHandler>>>) _bag).GetEnumerator();
        }

        /// <summary>
        ///     このリスナインスタンスに新たなハンドラを追加します。
        /// </summary>
        /// <param name="handler">PropertyChangedイベントハンドラ</param>
        public void RegisterHandler([NotNull] PropertyChangedEventHandler handler)
        {
            if (handler == null) throw new ArgumentNullException(nameof(handler));

            ThrowExceptionIfDisposed();
            _bag.RegisterHandler(handler);
        }

        /// <summary>
        ///     このリスナインスタンスにプロパティ名でフィルタリング済のハンドラを追加します。
        /// </summary>
        /// <param name="propertyName">ハンドラを登録したいPropertyChangedEventArgs.PropertyNameの名前</param>
        /// <param name="handler">propertyNameで指定されたプロパティ用のPropertyChangedイベントハンドラ</param>
        public void RegisterHandler([NotNull] string propertyName, [NotNull] PropertyChangedEventHandler handler)
        {
            if (propertyName == null) throw new ArgumentNullException(nameof(propertyName));
            if (handler == null) throw new ArgumentNullException(nameof(handler));

            ThrowExceptionIfDisposed();
            _bag.RegisterHandler(propertyName, handler);
        }

        /// <summary>
        ///     このリスナインスタンスにプロパティ名でフィルタリング済のハンドラを追加します。
        /// </summary>
        /// <param name="propertyExpression">() => プロパティ形式のラムダ式</param>
        /// <param name="handler">propertyExpressionで指定されたプロパティ用のPropertyChangedイベントハンドラ</param>
        public void RegisterHandler<T>([NotNull] Expression<Func<T>> propertyExpression,
            [NotNull] PropertyChangedEventHandler handler)
        {
            if (propertyExpression == null) throw new ArgumentNullException(nameof(propertyExpression));
            if (handler == null) throw new ArgumentNullException(nameof(handler));

            ThrowExceptionIfDisposed();
            _bag.RegisterHandler(propertyExpression, handler);
        }

        public void Add([NotNull] PropertyChangedEventHandler handler)
        {
            if (handler == null) throw new ArgumentNullException(nameof(handler));

            ThrowExceptionIfDisposed();
            _bag.Add(handler);
        }

        public void Add([NotNull] string propertyName, [NotNull] PropertyChangedEventHandler handler)
        {
            if (propertyName == null) throw new ArgumentNullException(nameof(propertyName));
            if (handler == null) throw new ArgumentNullException(nameof(handler));

            ThrowExceptionIfDisposed();
            _bag.Add(propertyName, handler);
        }

        public void Add([NotNull] string propertyName, [NotNull] params PropertyChangedEventHandler[] handlers)
        {
            if (propertyName == null) throw new ArgumentNullException(nameof(propertyName));
            if (handlers == null) throw new ArgumentNullException(nameof(handlers));

            ThrowExceptionIfDisposed();
            _bag.Add(propertyName, handlers);
        }

        public void Add<T>([NotNull] Expression<Func<T>> propertyExpression,
            [NotNull] PropertyChangedEventHandler handler)
        {
            if (propertyExpression == null) throw new ArgumentNullException(nameof(propertyExpression));
            if (handler == null) throw new ArgumentNullException(nameof(handler));

            ThrowExceptionIfDisposed();
            _bag.Add(propertyExpression, handler);
        }

        public void Add<T>([NotNull] Expression<Func<T>> propertyExpression,
            [NotNull] params PropertyChangedEventHandler[] handlers)
        {
            if (propertyExpression == null) throw new ArgumentNullException(nameof(propertyExpression));
            if (handlers == null) throw new ArgumentNullException(nameof(handlers));

            ThrowExceptionIfDisposed();
            _bag.Add(propertyExpression, handlers);
        }
    }
}