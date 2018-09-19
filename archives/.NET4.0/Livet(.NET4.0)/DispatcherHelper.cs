using System;
using System.Windows.Threading;
using System.ComponentModel;
using System.Windows;

namespace Livet
{
    /// <summary>
    /// UIDispatcherへのアクセスを簡易化します。
    /// </summary>
    public static class DispatcherHelper
    {
        private static Dispatcher _uiDispatcher;

        /// <summary>s
        /// UIDispatcherを指定、または取得します。通常このプロパティはApp_StartUpで指定されます。
        /// </summary>
        public static Dispatcher UIDispatcher
        {
            get
            {
                if ((bool)(DesignerProperties.IsInDesignModeProperty.GetMetadata(typeof(DependencyObject)).DefaultValue))
                {
                    _uiDispatcher = Dispatcher.CurrentDispatcher;
                }
                return _uiDispatcher;
            }
            set
            {
                _uiDispatcher = value;
            }
        }

        /// <summary>
        /// UIDispatcherで指定されたアクションを実行します。
        /// </summary>
        /// <param name="action">アクション</param>
        /// <exception cref="InvalidOperationException">UIDispatcherインスタンスがApp.StartUpなどで確保されていません。</exception>
#if NET45
        [Obsolete]
#endif
        public static void BeginInvoke(Action action)
        {
            if (UIDispatcher == null)
            {
                throw new InvalidOperationException("UIDispatcherインスタンスが確保されていません。App.StartUpで確保してください。");
            }

            UIDispatcher.BeginInvoke(action, null);
        }

        /// <summary>
        /// UIDispatcherで指定されたアクションを実行します。
        /// </summary>
        /// <param name="action">アクション</param>
        /// <param name="priority">DispatcherPriority</param>
        /// <exception cref="InvalidOperationException">UIDispatcherインスタンスがApp.StartUpなどで確保されていません。</exception>
#if NET45
        [Obsolete]
#endif
        public static void BeginInvoke(Action action, DispatcherPriority priority)
        {
            if (UIDispatcher == null)
            {
                throw new InvalidOperationException("UIDispatcherインスタンスが確保されていません。App.StartUpで確保してください。");
            }

            UIDispatcher.BeginInvoke(action, priority, null);
        }
    }
}
