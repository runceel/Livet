using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Reflection;
using Livet.EventListeners.WeakEvents;

namespace Livet.StatefulModel
{
    public interface ISynchronizableNotifyChangedCollection : INotifyCollectionChanged, INotifyPropertyChanged,
        IDisposable
    {
        
    }

    public interface ISynchronizableNotifyChangedCollection<T> : ISynchronizableNotifyChangedCollection,IList<T>
    {
        Synchronizer<T> Synchronizer { get; }
        void Move(int oldIndex, int newIndex);
    }

    public static class SynchronizableNotifyChangedCollectionHelper
    {
        public static CollectionChangedWeakEventListener CreateSynchronizableCollectionChangedEventListener
            <TSource, TResult>(
            ISynchronizableNotifyChangedCollection<TSource> source,
            ISynchronizableNotifyChangedCollection<TResult> target,
            Func<TSource,TResult> converter,
            Action<NotifyCollectionChangedEventArgs> addAction = null,
            Action<NotifyCollectionChangedEventArgs> moveAction = null,
            Action<NotifyCollectionChangedEventArgs> removeAction = null,
            Action<NotifyCollectionChangedEventArgs> replaceAction = null,
            Action<NotifyCollectionChangedEventArgs> resetAction = null)
        {
            var isDisposableType = typeof(IDisposable).GetTypeInfo().IsAssignableFrom(typeof(TResult).GetTypeInfo());

            var collectionChangedListener = new CollectionChangedWeakEventListener(source);
            collectionChangedListener.RegisterHandler((sender, e) =>
            {
                switch (e.Action)
                {
                    case NotifyCollectionChangedAction.Add:
                        if (addAction != null)
                        {
                            addAction(e);
                            break;
                        }
                        var vm = converter((TSource) e.NewItems[0]);
                        target.Insert(e.NewStartingIndex, vm);
                        break;
                    case NotifyCollectionChangedAction.Move:
                        if (moveAction != null)
                        {
                            moveAction(e);
                            break;
                        }
                        target.Move(e.OldStartingIndex, e.NewStartingIndex);
                        break;
                    case NotifyCollectionChangedAction.Remove:
                        if (removeAction != null)
                        {
                            removeAction(e);
                            break;
                        }
                        if (isDisposableType)
                        {
                            ((IDisposable) target[e.OldStartingIndex]).Dispose();
                        }
                        target.RemoveAt(e.OldStartingIndex);
                        break;
                    case NotifyCollectionChangedAction.Replace:
                        if (replaceAction != null)
                        {
                            replaceAction(e);
                            break;
                        }
                        if (isDisposableType)
                        {
                            ((IDisposable) target[e.NewStartingIndex]).Dispose();
                        }
                        var replaceVm = converter((TSource) e.NewItems[0]);
                        target[e.NewStartingIndex] = replaceVm;
                        break;
                    case NotifyCollectionChangedAction.Reset:
                        if (resetAction != null)
                        {
                            resetAction(e);
                            break;
                        }
                        if (isDisposableType)
                        {
                            foreach (var result in target)
                            {
                                var item = (IDisposable) result;
                                item.Dispose();
                            }
                        }
                        target.Clear();
                        break;
                    default:
                        throw new ArgumentException();
                }
            });
            return collectionChangedListener;
        }
    }
}
