using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading;
using Livet.Annotations;

namespace Livet
{
    /// <summary>
    ///     スレッドセーフな変更通知コレクションです。
    /// </summary>
    /// <typeparam name="T">コレクションアイテムの型</typeparam>
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1001:TypesThatOwnDisposableFieldsShouldBeDisposable")]
    [Serializable]
    public class ObservableSynchronizedCollection<T> : IList<T>, ICollection, INotifyCollectionChanged,
        INotifyPropertyChanged, IReadOnlyList<T>
    {
        private const string ItemsString = "Item[]";
        [NotNull] private readonly IList<T> _list;

        [NonSerialized] [NotNull] private readonly ReaderWriterLockSlim _lock = new ReaderWriterLockSlim();

        /// <summary>
        ///     デフォルトコンストラクタ
        /// </summary>
        public ObservableSynchronizedCollection()
        {
            _list = new List<T>();
        }

        /// <summary>
        ///     コンストラクタ
        /// </summary>
        /// <param name="source">初期値となるソース</param>
        public ObservableSynchronizedCollection([NotNull] IEnumerable<T> source)
        {
            if (source == null) throw new ArgumentNullException(nameof(source));
            _list = new List<T>(source);
        }

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
        ///     このコレクションがスレッドセーフであるかどうかを取得します。(常にtrueを返します)
        /// </summary>
        public bool IsSynchronized
        {
            get { return true; }
        }

        /// <summary>
        ///     このコレクションへのスレッドセーフなアクセスに使用できる同期オブジェクトを返します。
        /// </summary>
        [field: NonSerialized]
        public object SyncRoot { get; } = new object();

        /// <summary>
        ///     指定したオブジェクトを検索し、最初に見つかった位置の 0 から始まるインデックスを返します。
        /// </summary>
        /// <param name="item">検索するオブジェクト</param>
        /// <returns>最初に見つかった位置のインデックス</returns>
        public int IndexOf(T item)
        {
            return ReadWithLockAction(() => _list.IndexOf(item));
        }

        /// <summary>
        ///     指定したインデックスの位置に要素を挿入します。
        /// </summary>
        /// <param name="index">指定するインデックス</param>
        /// <param name="item">挿入するオブジェクト</param>
        public void Insert(int index, T item)
        {
            ReadAndWriteWithLockAction(() => _list.Insert(index, item),
                () =>
                {
                    OnPropertyChanged(nameof(Count));
                    OnPropertyChanged(ItemsString);
                    OnCollectionChanged(
                        new NotifyCollectionChangedEventArgs(NotifyCollectionChangedAction.Add, item, index));
                });
        }

        /// <summary>
        ///     指定したインデックスにある要素を削除します。
        /// </summary>
        /// <param name="index">指定するインデックス</param>
        public void RemoveAt(int index)
        {
            ReadAndWriteWithLockAction(() => _list[index],
                removeItem => _list.RemoveAt(index),
                removeItem =>
                {
                    OnPropertyChanged(nameof(Count));
                    OnPropertyChanged(ItemsString);
                    OnCollectionChanged(new NotifyCollectionChangedEventArgs(NotifyCollectionChangedAction.Remove,
                        removeItem, index));
                });
        }

        public T this[int index]
        {
            get { return ReadWithLockAction(() => _list[index]); }
            set
            {
                ReadAndWriteWithLockAction(() => _list[index],
                    oldItem => { _list[index] = value; },
                    oldItem =>
                    {
                        OnPropertyChanged(ItemsString);
                        OnCollectionChanged(new NotifyCollectionChangedEventArgs(NotifyCollectionChangedAction.Replace,
                            _list[index], oldItem, index));
                    });
            }
        }

        /// <summary>
        ///     末尾にオブジェクトを追加します。
        /// </summary>
        /// <param name="item">追加するオブジェクト</param>
        public void Add(T item)
        {
            ReadAndWriteWithLockAction(() => _list.Add(item),
                () =>
                {
                    OnPropertyChanged(nameof(Count));
                    OnPropertyChanged(ItemsString);
                    OnCollectionChanged(new NotifyCollectionChangedEventArgs(NotifyCollectionChangedAction.Add, item,
                        _list.Count - 1));
                });
        }

        /// <summary>
        ///     すべての要素を削除します。
        /// </summary>
        public void Clear()
        {
            ReadAndWriteWithLockAction(() => _list.Count,
                count =>
                {
                    if (count == 0) return;

                    _list.Clear();
                },
                count =>
                {
                    if (count == 0) return;

                    OnPropertyChanged(nameof(Count));
                    OnPropertyChanged(ItemsString);
                    OnCollectionChanged(new NotifyCollectionChangedEventArgs(NotifyCollectionChangedAction.Reset));
                });
        }

        /// <summary>
        ///     ある要素がこのコレクションに含まれているかどうかを判断します。
        /// </summary>
        /// <param name="item">コレクションに含まれているか判断したい要素</param>
        /// <returns>このコレクションに含まれているかどうか</returns>
        public bool Contains(T item)
        {
            return ReadWithLockAction(() => _list.Contains(item));
        }

        /// <summary>
        ///     全体を互換性のある1次元の配列にコピーします。コピー操作は、コピー先の配列の指定したインデックスから始まります。
        /// </summary>
        /// <param name="array">コピー先の配列</param>
        /// <param name="arrayIndex">コピー先の配列のどこからコピー操作をするかのインデックス</param>
        public void CopyTo(T[] array, int arrayIndex)
        {
            ReadWithLockAction(() => _list.CopyTo(array, arrayIndex));
        }

        /// <summary>
        ///     実際に格納されている要素の数を取得します。
        /// </summary>
        public int Count
        {
            get { return ReadWithLockAction(() => _list.Count); }
        }

        /// <summary>
        ///     このコレクションが読み取り専用かどうかを取得します。
        /// </summary>
        public bool IsReadOnly
        {
            get { return _list.IsReadOnly; }
        }

        /// <summary>
        ///     最初に見つかった特定のオブジェクトを削除します。
        /// </summary>
        /// <param name="item">削除したいオブジェクト</param>
        /// <returns>削除できたかどうか</returns>
        public bool Remove(T item)
        {
            var result = false;

            ReadAndWriteWithLockAction(() => _list.IndexOf(item),
                index => { result = _list.Remove(item); },
                index =>
                {
                    if (!result) return;

                    OnPropertyChanged(nameof(Count));
                    OnPropertyChanged(ItemsString);
                    OnCollectionChanged(new NotifyCollectionChangedEventArgs(NotifyCollectionChangedAction.Remove,
                        item, index));
                });

            return result;
        }

        /// <summary>
        ///     反復処理するためのスナップショットの列挙子を返します。
        /// </summary>
        /// <returns>列挙子</returns>
        public IEnumerator<T> GetEnumerator()
        {
            return ReadWithLockAction(() => ((IEnumerable<T>) _list.ToArray()).GetEnumerator())
                   ?? Enumerable.Empty<T>().GetEnumerator();
        }

        /// <summary>
        ///     反復処理するためのスナップショットの列挙子を返します。
        /// </summary>
        /// <returns>列挙子</returns>
        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        /// <summary>
        ///     コレクションが変更された際に発生するイベントです。
        /// </summary>
        [field: NonSerialized]
        public event NotifyCollectionChangedEventHandler CollectionChanged;

        /// <summary>
        ///     プロパティが変更された際に発生するイベントです。
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
            ReadAndWriteWithLockAction(() => _list[oldIndex],
                item =>
                {
                    _list.RemoveAt(oldIndex);
                    _list.Insert(newIndex, item);
                },
                item =>
                {
                    OnPropertyChanged(ItemsString);
                    OnCollectionChanged(new NotifyCollectionChangedEventArgs(NotifyCollectionChangedAction.Move, item,
                        newIndex, oldIndex));
                });
        }

        /// <summary>
        ///     CollectionChangedイベントを発生させます。
        /// </summary>
        /// <param name="args">NotifyCollectionChangedEventArgs</param>
        protected void OnCollectionChanged(NotifyCollectionChangedEventArgs args)
        {
            var threadSafeHandler = Interlocked.CompareExchange(ref CollectionChanged, null, null);

            threadSafeHandler?.Invoke(this, args);
        }

        /// <summary>
        ///     PropertyChangedイベントを発生させます。
        /// </summary>
        /// <param name="propertyName">変更されたプロパティの名前</param>
        [NotifyPropertyChangedInvocator]
        protected void OnPropertyChanged([CallerMemberName] [CanBeNull] string propertyName = "")
        {
            var threadSafeHandler = Interlocked.CompareExchange(ref PropertyChanged, null, null);
            threadSafeHandler?.Invoke(this, EventArgsFactory.GetPropertyChangedEventArgs(propertyName));
        }

        private void ReadWithLockAction([NotNull] Action readAction)
        {
            if (readAction == null) throw new ArgumentNullException(nameof(readAction));

            if (!_lock.IsReadLockHeld)
            {
                _lock.EnterReadLock();
                try { readAction(); }
                finally { _lock.ExitReadLock(); }
            }
            else
                readAction();
        }

        private TResult ReadWithLockAction<TResult>([NotNull] Func<TResult> readAction)
        {
            if (readAction == null) throw new ArgumentNullException(nameof(readAction));

            if (_lock.IsReadLockHeld) return readAction();

            _lock.EnterReadLock();

            try { return readAction(); }
            finally { _lock.ExitReadLock(); }
        }

        private void ReadAndWriteWithLockAction([NotNull] Action writeAction, [NotNull] Action readAfterWriteAction)
        {
            if (writeAction == null) throw new ArgumentNullException(nameof(writeAction));
            if (readAfterWriteAction == null) throw new ArgumentNullException(nameof(readAfterWriteAction));

            _lock.EnterUpgradeableReadLock();
            try
            {
                _lock.EnterWriteLock();
                try { writeAction(); }
                finally { _lock.ExitWriteLock(); }

                _lock.EnterReadLock();

                try { readAfterWriteAction(); }
                finally { _lock.ExitReadLock(); }
            }
            finally { _lock.ExitUpgradeableReadLock(); }
        }

        private void ReadAndWriteWithLockAction<TResult>([NotNull] Func<TResult> readBeforeWriteAction,
            [NotNull] Action<TResult> writeAction, [NotNull] Action<TResult> readAfterWriteAction)
        {
            if (readBeforeWriteAction == null) throw new ArgumentNullException(nameof(readBeforeWriteAction));
            if (writeAction == null) throw new ArgumentNullException(nameof(writeAction));
            if (readAfterWriteAction == null) throw new ArgumentNullException(nameof(readAfterWriteAction));

            _lock.EnterUpgradeableReadLock();
            try
            {
                var readActionResult = readBeforeWriteAction();

                _lock.EnterWriteLock();

                try { writeAction(readActionResult); }
                finally { _lock.ExitWriteLock(); }

                _lock.EnterReadLock();

                try { readAfterWriteAction(readActionResult); }
                finally { _lock.ExitReadLock(); }
            }
            finally { _lock.ExitUpgradeableReadLock(); }
        }
    }
}