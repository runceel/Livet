using System;
using System.Collections;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace Livet.EventListeners.WeakEvents
{
    /// <summary>
    /// INotifyPropertyChanged.PropertyChangedを受信するためのWeakイベントリスナです。
    /// </summary>
    public sealed class PropertyChangedWeakEventListener : LivetWeakEventListener<PropertyChangedEventHandler,PropertyChangedEventArgs>,IEnumerable<KeyValuePair<string,List<PropertyChangedEventHandler>>>
    {
         private AnonymousPropertyChangedEventHandlerBag _bag;

        /// <summary>
        /// コンストラクタ
        /// </summary>
        /// <param name="source">INotifyPropertyChangedオブジェクト</param>
        public PropertyChangedWeakEventListener(INotifyPropertyChanged source)
        {
            _bag = new AnonymousPropertyChangedEventHandlerBag(source);
            Initialize(
                h => new PropertyChangedEventHandler(h), 
                h => source.PropertyChanged += h, 
                h => source.PropertyChanged -= h, 
                (sender, e) => _bag.ExecuteHandler(e));
        }

        /// <summary>
        /// コンストラクタ。リスナのインスタンスの作成と同時にハンドラを一つ登録します。
        /// </summary>
        /// <param name="source">INotifyPropertyChangedオブジェクト</param>
        /// <param name="handler">PropertyChangedイベントハンドラ</param>
        public PropertyChangedWeakEventListener(INotifyPropertyChanged source, PropertyChangedEventHandler handler)
        {
           _bag = new AnonymousPropertyChangedEventHandlerBag(source,handler);
           Initialize(
                h => new PropertyChangedEventHandler(h), 
                h => source.PropertyChanged += h, 
                h => source.PropertyChanged -= h, 
                (sender, e) => _bag.ExecuteHandler(e));
        }

        /// <summary>
        /// このリスナインスタンスに新たなハンドラを追加します。
        /// </summary>
        /// <param name="handler">PropertyChangedイベントハンドラ</param>
        public void RegisterHandler(PropertyChangedEventHandler handler)
        {
            ThrowExceptionIfDisposed();
            _bag.RegisterHandler(handler);
        }

        /// <summary>
        /// このリスナインスタンスにプロパティ名でフィルタリング済のハンドラを追加します。
        /// </summary>
        /// <param name="propertyName">ハンドラを登録したいPropertyChagedEventArgs.PropertyNameの名前</param>
        /// <param name="handler">propertyNameで指定されたプロパティ用のPropertyChangedイベントハンドラ</param>
        public void RegisterHandler(string propertyName, PropertyChangedEventHandler handler)
        {
            ThrowExceptionIfDisposed();
            _bag.RegisterHandler(propertyName,handler);
        }

        /// <summary>
        /// このリスナインスタンスにプロパティ名でフィルタリング済のハンドラを追加します。
        /// </summary>
        /// <param name="propertyExpression">() => プロパティ形式のラムダ式</param>
        /// <param name="handler">propertyExpressionで指定されたプロパティ用のPropertyChangedイベントハンドラ</param>
        public void RegisterHandler<T>(Expression<Func<T>> propertyExpression, PropertyChangedEventHandler handler)
        {
            ThrowExceptionIfDisposed();
            _bag.RegisterHandler(propertyExpression,handler);
        }

        IEnumerator<KeyValuePair<string, List<PropertyChangedEventHandler>>> IEnumerable<KeyValuePair<string, List<PropertyChangedEventHandler>>>.GetEnumerator()
        {
            ThrowExceptionIfDisposed();
            return
                ((IEnumerable<KeyValuePair<string, List<PropertyChangedEventHandler>>>) _bag)
                    .GetEnumerator();
        }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            ThrowExceptionIfDisposed();
            return ((IEnumerable<KeyValuePair<string, List<PropertyChangedEventHandler>>>)_bag).GetEnumerator();
        }

        public void Add(PropertyChangedEventHandler handler)
        {
            ThrowExceptionIfDisposed();
            _bag.Add(handler);
        }

        public void Add(string propertyName, PropertyChangedEventHandler handler)
        {
            ThrowExceptionIfDisposed();
            _bag.Add(propertyName,handler);
        }


        public void Add(string propertyName, params PropertyChangedEventHandler[] handlers)
        {
            ThrowExceptionIfDisposed();
            _bag.Add(propertyName,handlers);
        }

        public void Add<T>(Expression<Func<T>> propertyExpression, PropertyChangedEventHandler handler)
        {
            ThrowExceptionIfDisposed();
            _bag.Add(propertyExpression,handler);
        }


        public void Add<T>(Expression<Func<T>> propertyExpression, params PropertyChangedEventHandler[] handlers)
        {
            ThrowExceptionIfDisposed();
            _bag.Add(propertyExpression,handlers);
        }
    }
}
