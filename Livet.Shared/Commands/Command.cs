using System;
using System.Collections.Generic;
using System.Linq;
using Livet.Annotations;

namespace Livet.Commands
{
    public abstract class Command
    {
        [NotNull] private readonly List<WeakReference<EventHandler>> _canExecuteChangedHandlers =
            new List<WeakReference<EventHandler>>();

        /// <summary>
        ///     コマンドが実行可能かどうかが変化した時に発生します。
        /// </summary>
        public event EventHandler CanExecuteChanged
        {
            add { _canExecuteChangedHandlers.Add(new WeakReference<EventHandler>(value)); }
            remove
            {
                foreach (var weakReference in _canExecuteChangedHandlers
                    .Where(r =>
                    {
                        if (r.TryGetTarget(out var result) && result == value) return true;
                        return false;
                    }).ToArray())
                    _canExecuteChangedHandlers.Remove(weakReference);
            }
        }

        /// <summary>
        ///     コマンドが実行可能かどうかが変化した時に呼び出されます。
        /// </summary>
        protected void OnCanExecuteChanged()
        {
            var uiDispatcher = DispatcherHelper.UIDispatcher
                               ?? throw new InvalidOperationException("DispatcherHelper.UIDispatcher is null.");

            foreach (var handlerWeakReference in _canExecuteChangedHandlers.ToArray())
                if (handlerWeakReference.TryGetTarget(out var result))
                    uiDispatcher.InvokeAsync(() => result(this, EventArgs.Empty));
                else
                    _canExecuteChangedHandlers.Remove(handlerWeakReference);
        }
    }
}