using System;
using Livet.Annotations;

namespace Livet.EventListeners
{
    /// <summary>
    ///     汎用イベントリスナオブジェクトです。
    /// </summary>
    /// <typeparam name="THandler">イベントハンドラーの型</typeparam>
    public class EventListener<THandler> : IDisposable where THandler : class
    {
        private readonly bool _initialized;

        // ReSharper disable once NotAccessedField.Local
        [CanBeNull] private Action<THandler> _add;
        private bool _disposed;
        [CanBeNull] private THandler _handler;
        [CanBeNull] private Action<THandler> _remove;

        /// <summary>
        ///     コンストラクタ
        /// </summary>
        /// <param name="add">h => obj.Event += > h の様な形でイベントの購読を登録するためのAction。hはTHandler型です。</param>
        /// <param name="remove">h => obj.Event -= > h の様な形でイベントの購読を解除するためのAction。hはTHandler型です。</param>
        /// <param name="handler">イベントを受信した際に行いたいアクション</param>
        public EventListener([NotNull] Action<THandler> add, [NotNull] Action<THandler> remove,
            [NotNull] THandler handler)
        {
            if (add == null) throw new ArgumentNullException(nameof(add));
            if (remove == null) throw new ArgumentNullException(nameof(remove));
            if (handler == null) throw new ArgumentNullException(nameof(handler));

            Initialize(add, remove, handler);
            _initialized = true;
        }

        protected EventListener() { }

        /// <summary>
        ///     イベントハンドラの登録を解除します。
        /// </summary>
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected void Initialize([NotNull] Action<THandler> add, [NotNull] Action<THandler> remove,
            [NotNull] THandler handler)
        {
            if (_initialized) return;

            _add = add ?? throw new ArgumentNullException(nameof(add));
            _handler = handler ?? throw new ArgumentNullException(nameof(handler));
            _remove = remove ?? throw new ArgumentNullException(nameof(remove));
            add(handler);
        }

        protected void ThrowExceptionIfDisposed()
        {
            if (_disposed) throw new ObjectDisposedException("EventListener");
        }

        protected virtual void Dispose(bool disposing)
        {
            if (_disposed) return;

            if (disposing)
            {
                _remove?.Invoke(_handler);
                _add = null;
                _remove = null;
                _handler = null;
            }

            _disposed = true;
        }
    }
}