using System;
using System.Collections.Generic;
using System.Linq;

namespace Livet.Commands
{
    public abstract class Command
    {
        private List<WeakReference<EventHandler>> _canExecuteChangedHandlers = new List<WeakReference<EventHandler>>();

        /// <summary>
        /// コマンドが実行可能かどうかが変化した時に発生します。
        /// </summary>
        public event EventHandler CanExecuteChanged
        {
            add
            {
                _canExecuteChangedHandlers.Add(new WeakReference<EventHandler>(value));
            }
            remove
            {
                foreach (var weakReference in _canExecuteChangedHandlers
                    .Where(r => 
                        {
                            EventHandler result;
                            if (r.TryGetTarget(out result) && result == value)
                            {
                                return true;
                            }
                            return false;
                        }).ToList())
                {
                    _canExecuteChangedHandlers.Remove(weakReference);
                }
            }
        }

        /// <summary>
        /// コマンドが実行可能かどうかが変化した時に呼び出されます。
        /// </summary>
        protected void OnCanExecuteChanged()
        {
            foreach (var handlerWeakReference in _canExecuteChangedHandlers.ToList())
            {
                EventHandler result;

                if (handlerWeakReference.TryGetTarget(out result))
                {
#if NET4
                    DispatcherHelper.BeginInvoke(() => result(this, EventArgs.Empty));
#elif NET45
                    DispatcherHelper.UIDispatcher.InvokeAsync(() => result(this, EventArgs.Empty));
#endif
                }
                else
                {
                    _canExecuteChangedHandlers.Remove(handlerWeakReference);
                }
            }
        }
    }
}
