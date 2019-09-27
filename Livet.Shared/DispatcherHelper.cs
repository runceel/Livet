using System;
using System.ComponentModel;
using System.Windows;
using System.Windows.Threading;
using Livet.Annotations;

namespace Livet
{
    /// <summary>
    ///     UIDispatcherへのアクセスを簡易化します。
    /// </summary>
    public static class DispatcherHelper
    {
        [CanBeNull] private static Dispatcher _uiDispatcher;

        /// <summary>
        ///     UIDispatcherを指定、または取得します。通常このプロパティはApp_StartUpで指定されます。
        /// </summary>
        [CanBeNull]
        [System.Diagnostics.CodeAnalysis.SuppressMessage("ReSharper", "InconsistentNaming")]
        public static Dispatcher UIDispatcher
        {
            get
            {
                var metadata = DesignerProperties.IsInDesignModeProperty?.GetMetadata(typeof(DependencyObject));
                if ((bool) (metadata?.DefaultValue ?? default(bool)))
                    _uiDispatcher = Dispatcher.CurrentDispatcher;
                return _uiDispatcher;
            }
            set { _uiDispatcher = value; }
        }

        /// <summary>
        ///     UIDispatcherで指定されたアクションを実行します。
        /// </summary>
        /// <param name="action">アクション</param>
        /// <exception cref="InvalidOperationException">UIDispatcherインスタンスがApp.StartUpなどで確保されていません。</exception>
        [Obsolete]
        public static void BeginInvoke([NotNull] Action action)
        {
            if (action == null) throw new ArgumentNullException(nameof(action));
            if (UIDispatcher == null)
                throw new InvalidOperationException("UIDispatcherインスタンスが確保されていません。App.StartUpで確保してください。");

            UIDispatcher.BeginInvoke(action, null);
        }

        /// <summary>
        ///     UIDispatcherで指定されたアクションを実行します。
        /// </summary>
        /// <param name="action">アクション</param>
        /// <param name="priority">DispatcherPriority</param>
        /// <exception cref="InvalidOperationException">UIDispatcherインスタンスがApp.StartUpなどで確保されていません。</exception>
        [Obsolete]
        public static void BeginInvoke([NotNull] Action action, DispatcherPriority priority)
        {
            if (action == null) throw new ArgumentNullException(nameof(action));
            if (UIDispatcher == null)
                throw new InvalidOperationException("UIDispatcherインスタンスが確保されていません。App.StartUpで確保してください。");

            UIDispatcher.BeginInvoke(action, priority, null);
        }
    }
}