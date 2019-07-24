using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Linq;
using System.Threading;
using System.Windows.Threading;
using Livet.Annotations;

namespace Livet
{
    /// <summary>
    ///     コレクション変更通知を指定されたDispatcher経由で行うコレクションです。
    /// </summary>
    /// <typeparam name="T">コレクションアイテムの型</typeparam>
    public class DispatcherCollection<T> : IList<T>, ICollection, INotifyCollectionChanged, INotifyPropertyChanged,
        IReadOnlyList<T>
    {
        [NotNull] private readonly IList<T> _sourceAsIList;
        [NotNull] private Dispatcher _dispatcher;

        /// <summary>
        ///     コンストラクタ
        /// </summary>
        /// <param name="dispatcher">UIDispatcher(通常はDispatcherHelper.UIDispatcher)</param>
        public DispatcherCollection([NotNull] Dispatcher dispatcher) :
            this(new ObservableCollection<T>(), dispatcher) { }

        /// <summary>
        ///     コンストラクタ
        /// </summary>
        /// <param name="collection">元となるコレクション(IList(Of(T)とINotifyPropertyChangedも実装している必要があります)</param>
        /// <param name="dispatcher">UIDispatcher(通常はDispatcherHelper.UIDispatcher)</param>
        public DispatcherCollection([NotNull] INotifyCollectionChanged collection, [CanBeNull] Dispatcher dispatcher)
        {
            if (collection == null) throw new ArgumentNullException(nameof(collection));
            if (!(collection is IList<T>)) throw new ArgumentException("collectionはIList<T>を実装している必要があります");
            if (!(collection is INotifyPropertyChanged))
                throw new ArgumentException("collectionはINotifyPropertyChangedを実装している必要があります");

            _sourceAsIList = (IList<T>) collection;

            _dispatcher = dispatcher ?? throw new ArgumentNullException(nameof(dispatcher));
            CollectionChangedDispatcherPriority = DispatcherPriority.Normal;

            ((INotifyPropertyChanged) collection).PropertyChanged += (sender, e) =>
            {
                if (e == null) throw new ArgumentNullException(nameof(e));
                if (!Dispatcher.CheckAccess())
                {
                    Dispatcher.Invoke(CollectionChangedDispatcherPriority,
                        (Action) (() => OnPropertyChanged(e.PropertyName)));
                }
                else
                    OnPropertyChanged(e.PropertyName);
            };

            collection.CollectionChanged += (sender, e) =>
            {
                if (!Dispatcher.CheckAccess())
                    Dispatcher.Invoke(CollectionChangedDispatcherPriority, (Action) (() => OnCollectionChanged(e)));
                else
                    OnCollectionChanged(e);
            };
        }

        /// <summary>
        ///     このコレクションに関連付けられたDispatcherを取得、または設定します。
        /// </summary>
        [NotNull]
        public Dispatcher Dispatcher
        {
            get { return _dispatcher; }
            set { _dispatcher = value ?? throw new ArgumentNullException(nameof(value)); }
        }

        /// <summary>
        ///     コレクション変更通知時のDispatcherPriorityを指定、または取得します。
        /// </summary>
        public DispatcherPriority CollectionChangedDispatcherPriority { get; set; }

        /// <summary>
        ///     全体を互換性のある1次元の配列にコピーします。コピー操作は、コピー先の配列の指定したインデックスから始まります。
        /// </summary>
        /// <param name="array">コピー先の配列</param>
        /// <param name="index">コピー先の配列のどこからコピー操作をするかのインデックス</param>
        public void CopyTo(Array array, int index)
        {
            CopyTo(array.Cast<T>().ToArray(), index);
        }

        /// <summary>
        ///     このコレクションがスレッドセーフであるかどうかを取得します。
        /// </summary>
        public bool IsSynchronized
        {
            get { return _sourceAsIList is ObservableSynchronizedCollection<T>; }
        }

        /// <summary>
        ///     このコレクションへのスレッドセーフなアクセスに使用できる同期オブジェクトを返します。
        /// </summary>
        public object SyncRoot { get; } = new object();

        /// <summary>
        ///     指定したオブジェクトを検索し、最初に見つかった位置の 0 から始まるインデックスを返します。
        /// </summary>
        /// <param name="item">検索するオブジェクト</param>
        /// <returns>最初に見つかった位置のインデックス</returns>
        public int IndexOf(T item)
        {
            return _sourceAsIList.IndexOf(item);
        }

        /// <summary>
        ///     指定したインデックスの位置に要素を挿入します。
        /// </summary>
        /// <param name="index">指定するインデックス</param>
        /// <param name="item">挿入するオブジェクト</param>
        public void Insert(int index, T item)
        {
            _sourceAsIList.Insert(index, item);
        }

        /// <summary>
        ///     指定したインデックスにある要素を削除します。
        /// </summary>
        /// <param name="index">指定するインデックス</param>
        public void RemoveAt(int index)
        {
            _sourceAsIList.RemoveAt(index);
        }

        public T this[int index]
        {
            get { return _sourceAsIList[index]; }
            set { _sourceAsIList[index] = value; }
        }

        /// <summary>
        ///     末尾にオブジェクトを追加します。
        /// </summary>
        /// <param name="item">追加するオブジェクト</param>
        public void Add(T item)
        {
            _sourceAsIList.Add(item);
        }

        /// <summary>
        ///     すべての要素を削除します。
        /// </summary>
        public void Clear()
        {
            _sourceAsIList.Clear();
        }

        /// <summary>
        ///     ある要素がこのコレクションに含まれているかどうかを判断します。
        /// </summary>
        /// <param name="item">コレクションに含まれているか判断したい要素</param>
        /// <returns>このコレクションに含まれているかどうか</returns>
        public bool Contains(T item)
        {
            return _sourceAsIList.Contains(item);
        }

        /// <summary>
        ///     全体を互換性のある1次元の配列にコピーします。コピー操作は、コピー先の配列の指定したインデックスから始まります。
        /// </summary>
        /// <param name="array">コピー先の配列</param>
        /// <param name="arrayIndex">コピー先の配列のどこからコピー操作をするかのインデックス</param>
        public void CopyTo(T[] array, int arrayIndex)
        {
            _sourceAsIList.CopyTo(array, arrayIndex);
        }

        /// <summary>
        ///     実際に格納されている要素の数を取得します。
        /// </summary>
        public int Count
        {
            get { return _sourceAsIList.Count; }
        }

        /// <summary>
        ///     このコレクションが読み取り専用かどうかを取得します。
        /// </summary>
        public bool IsReadOnly
        {
            get { return _sourceAsIList.IsReadOnly; }
        }

        /// <summary>
        ///     最初に見つかった特定のオブジェクトを削除します。
        /// </summary>
        /// <param name="item">削除したいオブジェクト</param>
        /// <returns>削除できたかどうか</returns>
        public bool Remove(T item)
        {
            return _sourceAsIList.Remove(item);
        }

        /// <summary>
        ///     反復処理するための列挙子を返します。
        /// </summary>
        /// <returns>列挙子</returns>
        public IEnumerator<T> GetEnumerator()
        {
            return _sourceAsIList.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return _sourceAsIList.GetEnumerator();
        }

        /// <summary>
        ///     プロパティが変更された際に発生するイベントです。
        /// </summary>
        [field: NonSerialized]
        public event NotifyCollectionChangedEventHandler CollectionChanged;

        /// <summary>
        ///     コレクションが変更された際に発生するイベントです。
        /// </summary>
        [field: NonSerialized]
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        ///     指定されたインデックスの要素を指定されたインデックスに移動します。
        /// </summary>
        /// <param name="oldIndex">移動したい要素のインデックス</param>
        /// <param name="newIndex">移動先のインデックス</param>
        public void Move(int oldIndex, int newIndex)
        {
            if (_sourceAsIList is ObservableCollection<T> sourceAsObservableCollection)
                sourceAsObservableCollection.Move(oldIndex, newIndex);
            else
            {
                var sourceAsConcurrentObservableCollection = _sourceAsIList as ObservableSynchronizedCollection<T>;

                sourceAsConcurrentObservableCollection?.Move(oldIndex, newIndex);
            }
        }

        protected void OnCollectionChanged(NotifyCollectionChangedEventArgs args)
        {
            var threadSafeHandler = Interlocked.CompareExchange(ref CollectionChanged, null, null);

            threadSafeHandler?.Invoke(this, args);
        }

        protected void OnPropertyChanged([CanBeNull] string propertyName)
        {
            var threadSafeHandler = Interlocked.CompareExchange(ref PropertyChanged, null, null);
            threadSafeHandler?.Invoke(this, EventArgsFactory.GetPropertyChangedEventArgs(propertyName));
        }
    }
}