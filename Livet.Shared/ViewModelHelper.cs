using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Collections.ObjectModel;
using System.Windows.Threading;
using Livet.EventListeners;

namespace Livet
{
    /// <summary>
    /// ViewModelのヘルパークラスです。
    /// </summary>
    public static class ViewModelHelper
    {
        /// <summary>
        /// 変更通知コレクションに連動する読み取り専用の変更通知コレクションを生成します。
        /// </summary>
        /// <typeparam name="TModel">ソース変更通知コレクションのアイテム型</typeparam>
        /// <typeparam name="TViewModel">生成する連動コレクションのアイテム型</typeparam>
        /// <param name="source">ソース変更通知コレクション</param>
        /// <param name="converter">TModel型のインスタンスをTViewModel型のインスタンスに変換するFunc</param>
        /// <param name="dispatcher">生成する連動コレクションが変更通知を行うDispatcher</param>
        /// <returns>生成された連動コレクション</returns>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Reliability", "CA2000:DisposeObjectsBeforeLosingScope")]
        public static ReadOnlyDispatcherCollection<TViewModel> CreateReadOnlyDispatcherCollection<TModel, TViewModel>(IList<TModel> source, Func<TModel, TViewModel> converter, Dispatcher dispatcher)
        {
            if (source == null) throw new ArgumentNullException("source");

            var sourceAsNotifyCollection = source as INotifyCollectionChanged;
            if (sourceAsNotifyCollection == null) throw new ArgumentException("sourceがINotifyCollectionChangedを実装していません");

            var initCollection = new ObservableCollection<TViewModel>();

            foreach (var model in source)
            {
                initCollection.Add(converter(model));
            }

            var target = new DispatcherCollection<TViewModel>(initCollection, dispatcher);
            var result = new ReadOnlyDispatcherCollection<TViewModel>(target);

            var collectionChangedListener = new CollectionChangedEventListener(sourceAsNotifyCollection);

            result.EventListeners.Add(collectionChangedListener);

            collectionChangedListener.RegisterHandler((sender, e) =>
                {
                    switch (e.Action)
                    {
                        case NotifyCollectionChangedAction.Add:
                            var vm = converter((TModel) e.NewItems[0]);
                            InvokeOnDispatcher(() => target.Insert(e.NewStartingIndex, vm),dispatcher);
                            break;
                        case NotifyCollectionChangedAction.Move:
                            InvokeOnDispatcher(() => target.Move(e.OldStartingIndex, e.NewStartingIndex), dispatcher);
                            break;
                        case NotifyCollectionChangedAction.Remove:
                            if (typeof (IDisposable).IsAssignableFrom(typeof (TViewModel)))
                            {
                                ((IDisposable) target[e.OldStartingIndex]).Dispose();
                            }
                            InvokeOnDispatcher(() => target.RemoveAt(e.OldStartingIndex), dispatcher);
                            break;
                        case NotifyCollectionChangedAction.Replace:
                            if (typeof(IDisposable).IsAssignableFrom(typeof(TViewModel)))
                            {
                                ((IDisposable)target[e.NewStartingIndex]).Dispose();
                            }
                            var replaceVm = converter((TModel) e.NewItems[0]);
                            InvokeOnDispatcher(() => target[e.NewStartingIndex] = replaceVm, dispatcher);
                            break;
                        case NotifyCollectionChangedAction.Reset:
                            if (typeof(IDisposable).IsAssignableFrom(typeof(TViewModel)))
                            {
                                foreach (IDisposable item in target)
                                {
                                    item.Dispose();
                                }
                            }
                            InvokeOnDispatcher(target.Clear, dispatcher);
                            break;
                        default:
                            throw new ArgumentException();
                    }
                });

            return result;
        }

        private static void InvokeOnDispatcher(Action action,Dispatcher dispatcher)
        {
            dispatcher.Invoke(action);
        }
    }
}
