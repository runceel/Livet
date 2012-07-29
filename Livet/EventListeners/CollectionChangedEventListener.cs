using System;
using System.Linq;
using System.Collections.Specialized;
using System.Collections.Concurrent;

namespace Livet.EventListeners
{
    /// <summary>
    /// INotifyCollectionChanged.NotifyCollectionChangedを受信するためのイベントリスナです。
    /// </summary>
    public class CollectionChangedEventListener : EventListener<NotifyCollectionChangedEventHandler>
    {
        private ConcurrentDictionary<NotifyCollectionChangedAction, ConcurrentBag<NotifyCollectionChangedEventHandler>> _handlerDictionary = new ConcurrentDictionary<NotifyCollectionChangedAction, ConcurrentBag<NotifyCollectionChangedEventHandler>>();
        private WeakReference<INotifyCollectionChanged> _source;

        private ConcurrentBag<NotifyCollectionChangedEventHandler> _allHandlerList = new ConcurrentBag<NotifyCollectionChangedEventHandler>();

        /// <summary>
        /// コンストラクタ
        /// </summary>
        /// <param name="source">INotifyCollectionChangedオブジェクト</param>
        public CollectionChangedEventListener(INotifyCollectionChanged source)
        {
            if (source == null) throw new ArgumentNullException("source");
            _source = new WeakReference<INotifyCollectionChanged>(source);
            Initialize(h => source.CollectionChanged += h, h => source.CollectionChanged -= h, (sender, e) => ExecuteHandler(e));
        }

        /// <summary>
        /// コンストラクタ。リスナのインスタンスの作成と同時にハンドラを一つ登録します。
        /// </summary>
        /// <param name="source">INotifyCollectionChangedオブジェクト</param>
        /// <param name="handler">NotifyCollectionChangedイベントハンドラ</param>
        public CollectionChangedEventListener(INotifyCollectionChanged source, NotifyCollectionChangedEventHandler handler)
            :this(source)
        {
            if (handler == null) throw new ArgumentNullException("handler");
            RegisterHandler(handler);
        }

        /// <summary>
        /// このリスナインスタンスに新たなハンドラを追加します。
        /// </summary>
        /// <param name="handler">NotifyCollectionChangedイベントハンドラ</param>
        public void RegisterHandler(NotifyCollectionChangedEventHandler handler)
        {
            ThrowExceptionIfDisposed();
            _allHandlerList.Add(handler);
        }

        /// <summary>
        /// このリスナインスタンスにプロパティ名でフィルタリング済のハンドラを追加します。
        /// </summary>
        /// <param name="action">ハンドラを登録したいNotifyCollectionChangedAction</param>
        /// <param name="handler">actionで指定されたNotifyCollectionChangedActionに対応したNotifyCollectionChangedイベントハンドラ</param>
        public void RegisterHandler(NotifyCollectionChangedAction action, NotifyCollectionChangedEventHandler handler)
        {
            ThrowExceptionIfDisposed();
            _handlerDictionary.GetOrAdd(action, _ => new ConcurrentBag<NotifyCollectionChangedEventHandler>()).Add(handler);
        }

        private void ExecuteHandler(NotifyCollectionChangedEventArgs e)
        {
            INotifyCollectionChanged sourceResult;
            var result = _source.TryGetTarget(out sourceResult);

            if (!result) return;

            if (_handlerDictionary.ContainsKey(e.Action))
            {
                foreach (var handler in _handlerDictionary[e.Action])
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
    }
}
