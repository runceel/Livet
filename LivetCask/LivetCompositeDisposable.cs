using System;
using System.Collections;
using System.Collections.Generic;
using Livet.Annotations;

namespace Livet
{
    /// <summary>
    ///     複数のIDisposableオブジェクトをまとめて操作するための機能を提供します。
    /// </summary>
    public class LivetCompositeDisposable : IDisposable, ICollection<IDisposable>
    {
        [NotNull] private readonly object _lockObject = new object();
        [NotNull] private readonly List<IDisposable> _targetLists;
        private bool _disposed;

        /// <summary>
        ///     コンストラクタ
        /// </summary>
        public LivetCompositeDisposable()
        {
            _targetLists = new List<IDisposable>();
        }

        /// <summary>
        ///     コンストラクタ
        /// </summary>
        /// <param name="sourceDisposableList">ソースとなるIDisposableコレクション</param>
        public LivetCompositeDisposable([NotNull] IEnumerable<IDisposable> sourceDisposableList)
        {
            if (sourceDisposableList == null) throw new ArgumentNullException(nameof(sourceDisposableList));

            _targetLists = new List<IDisposable>(sourceDisposableList);
        }

        /// <summary>
        ///     IDisposableコレクションの列挙子を取得します。
        /// </summary>
        /// <returns>IDisposableコレクションの列挙子</returns>
        public IEnumerator<IDisposable> GetEnumerator()
        {
            ThrowExceptionIfDisposed();
            lock (_lockObject) { return ((IEnumerable<IDisposable>) _targetLists.ToArray()).GetEnumerator(); }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            ThrowExceptionIfDisposed();
            lock (_lockObject) { return ((IEnumerable<IDisposable>) _targetLists.ToArray()).GetEnumerator(); }
        }

        /// <summary>
        ///     末尾にオブジェクトを追加します。
        /// </summary>
        /// <param name="item">追加するオブジェクト</param>
        public void Add(IDisposable item)
        {
            if (item == null) throw new ArgumentNullException(nameof(item));

            ThrowExceptionIfDisposed();
            lock (_lockObject) { _targetLists.Add(item); }
        }

        /// <summary>
        ///     すべての要素を削除します。
        /// </summary>
        public void Clear()
        {
            ThrowExceptionIfDisposed();
            lock (_lockObject) { _targetLists.Clear(); }
        }

        /// <summary>
        ///     ある要素がこのコレクションに含まれているかどうかを判断します。
        /// </summary>
        /// <param name="item">コレクションに含まれているか判断したい要素</param>
        /// <returns>このコレクションに含まれているかどうか</returns>
        public bool Contains(IDisposable item)
        {
            if (item == null) throw new ArgumentNullException(nameof(item));

            ThrowExceptionIfDisposed();
            lock (_lockObject) { return _targetLists.Contains(item); }
        }

        /// <summary>
        ///     全体を互換性のある1次元の配列にコピーします。コピー操作は、コピー先の配列の指定したインデックスから始まります。
        /// </summary>
        /// <param name="array">コピー先の配列</param>
        /// <param name="arrayIndex">コピー先の配列のどこからコピー操作をするかのインデックス</param>
        public void CopyTo(IDisposable[] array, int arrayIndex)
        {
            ThrowExceptionIfDisposed();
            lock (_lockObject) { _targetLists.CopyTo(array, arrayIndex); }
        }

        /// <summary>
        ///     実際に格納されている要素の数を取得します。
        /// </summary>
        public int Count
        {
            get
            {
                ThrowExceptionIfDisposed();
                lock (_lockObject) { return _targetLists.Count; }
            }
        }

        /// <summary>
        ///     このコレクションが読み取り専用かどうかを取得します。(常にfalseを返します)
        /// </summary>
        public bool IsReadOnly
        {
            get
            {
                ThrowExceptionIfDisposed();
                return false;
            }
        }

        /// <summary>
        ///     最初に見つかった特定のオブジェクトを削除します。
        /// </summary>
        /// <param name="item">削除したいオブジェクト</param>
        /// <returns>削除できたかどうか</returns>
        public bool Remove(IDisposable item)
        {
            if (item == null) throw new ArgumentNullException(nameof(item));

            ThrowExceptionIfDisposed();

            lock (_lockObject) { return _targetLists.Remove(item); }
        }

        /// <summary>
        ///     このコレクションに含まれるすべての要素をDisposeします。
        /// </summary>
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        /// <summary>
        ///     IDisposableの代わりに、リソースを解放するActionを末尾に追加します。
        /// </summary>
        /// <param name="releaseAction">リソースを解放するためのAction</param>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Reliability", "CA2000:DisposeObjectsBeforeLosingScope")]
        public void Add([NotNull] Action releaseAction)
        {
            if (releaseAction == null) throw new ArgumentNullException(nameof(releaseAction));

            ThrowExceptionIfDisposed();
            var disposable = new AnonymousDisposable(releaseAction);
            lock (_lockObject) { _targetLists.Add(disposable); }
        }

        /// <summary>
        ///     先頭にオブジェクトを追加します。
        /// </summary>
        /// <param name="item">追加するオブジェクト</param>
        public void AddFirst(IDisposable item)
        {
            if (item == null) throw new ArgumentNullException(nameof(item));

            ThrowExceptionIfDisposed();
            lock (_lockObject) { _targetLists.Insert(0, item); }
        }

        /// <summary>
        ///     IDisposableの代わりに、リソースを解放するActionを先頭に追加します。
        /// </summary>
        /// <param name="releaseAction">リソースを解放するためのAction</param>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Reliability", "CA2000:DisposeObjectsBeforeLosingScope")]
        public void AddFirst([NotNull] Action releaseAction)
        {
            if (releaseAction == null) throw new ArgumentNullException(nameof(releaseAction));

            ThrowExceptionIfDisposed();
            var disposable = new AnonymousDisposable(releaseAction);
            lock (_lockObject) { _targetLists.Insert(0, disposable); }
        }

        protected virtual void Dispose(bool disposing)
        {
            if (_disposed) return;

            if (disposing)
                lock (_lockObject) { _targetLists.ForEach(item => item?.Dispose()); }

            _disposed = true;
        }

        protected void ThrowExceptionIfDisposed()
        {
            if (_disposed) throw new ObjectDisposedException("CompositeDisposable");
        }
    }
}