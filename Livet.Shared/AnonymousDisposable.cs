using System;

namespace Livet
{
    /// <summary>
    /// 指定されたリソース解放用のActionをIDsposableとして扱います。
    /// </summary>
    public class AnonymousDisposable : IDisposable
    {
        private Action _releaseAction;
        private bool _disposed;

        /// <summary>
        /// コンストラクタ
        /// </summary>
        /// <param name="releaseAction">リソースを解放するためのアクション</param>
        public AnonymousDisposable(Action releaseAction)
        {
            _releaseAction = releaseAction;
        }

        /// <summary>
        /// コンストラクタで指定されたアクションを呼び出します。
        /// </summary>
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (_disposed) return;

            if (disposing)
            {
                _releaseAction();
            }
            _disposed = true;
        }
    }
}
