using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using Livet.Annotations;
using Livet.EventListeners.Internals;

namespace Livet.EventListeners
{
    /// <summary>
    ///     INotifyCollectionChanged.NotifyCollectionChangedを受信するためのイベントリスナです。
    /// </summary>
    public sealed class CollectionChangedEventListener : EventListener<NotifyCollectionChangedEventHandler>,
        IEnumerable<KeyValuePair<NotifyCollectionChangedAction, List<NotifyCollectionChangedEventHandler>>>

    {
        [NotNull] private readonly AnonymousCollectionChangedEventHandlerBag _bag;

        /// <summary>
        ///     コンストラクタ
        /// </summary>
        /// <param name="source">INotifyCollectionChangedオブジェクト</param>
        public CollectionChangedEventListener([NotNull] INotifyCollectionChanged source)
        {
            if (source == null) throw new ArgumentNullException(nameof(source));

            _bag = new AnonymousCollectionChangedEventHandlerBag(source);
            Initialize(
                h => source.CollectionChanged += h,
                h => source.CollectionChanged -= h,
                (sender, e) =>
                {
                    if (e != null) _bag.ExecuteHandler(e);
                });
        }

        /// <summary>
        ///     コンストラクタ。リスナのインスタンスの作成と同時にハンドラを一つ登録します。
        /// </summary>
        /// <param name="source">INotifyCollectionChangedオブジェクト</param>
        /// <param name="handler">NotifyCollectionChangedイベントハンドラ</param>
        public CollectionChangedEventListener([NotNull] INotifyCollectionChanged source,
            [NotNull] NotifyCollectionChangedEventHandler handler)
        {
            if (source == null) throw new ArgumentNullException(nameof(source));
            if (handler == null) throw new ArgumentNullException(nameof(handler));

            _bag = new AnonymousCollectionChangedEventHandlerBag(source, handler);
            Initialize(
                h => source.CollectionChanged += h,
                h => source.CollectionChanged -= h,
                (sender, e) =>
                {
                    if (e != null) _bag.ExecuteHandler(e);
                });
        }

        IEnumerator<KeyValuePair<NotifyCollectionChangedAction, List<NotifyCollectionChangedEventHandler>>>
            IEnumerable<KeyValuePair<NotifyCollectionChangedAction, List<NotifyCollectionChangedEventHandler>>>.
            GetEnumerator()
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

        /// <summary>
        ///     このリスナインスタンスに新たなハンドラを追加します。
        /// </summary>
        /// <param name="handler">NotifyCollectionChangedイベントハンドラ</param>
        public void RegisterHandler(NotifyCollectionChangedEventHandler handler)
        {
            ThrowExceptionIfDisposed();
            _bag.RegisterHandler(handler);
        }

        /// <summary>
        ///     このリスナインスタンスにプロパティ名でフィルタリング済のハンドラを追加します。
        /// </summary>
        /// <param name="action">ハンドラを登録したいNotifyCollectionChangedAction</param>
        /// <param name="handler">actionで指定されたNotifyCollectionChangedActionに対応したNotifyCollectionChangedイベントハンドラ</param>
        public void RegisterHandler(NotifyCollectionChangedAction action, NotifyCollectionChangedEventHandler handler)
        {
            ThrowExceptionIfDisposed();
            _bag.RegisterHandler(action, handler);
        }

        public void Add(NotifyCollectionChangedEventHandler handler)
        {
            _bag.Add(handler);
        }

        public void Add(NotifyCollectionChangedAction action, NotifyCollectionChangedEventHandler handler)
        {
            _bag.Add(action, handler);
        }

        public void Add(NotifyCollectionChangedAction action,
            [NotNull] params NotifyCollectionChangedEventHandler[] handlers)
        {
            if (handlers == null) throw new ArgumentNullException(nameof(handlers));

            _bag.Add(action, handlers);
        }
    }
}