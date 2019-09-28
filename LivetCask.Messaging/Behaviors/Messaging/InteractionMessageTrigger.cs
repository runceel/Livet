using System;
using System.Windows;
using Microsoft.Xaml.Behaviors;
using Livet.Annotations;
using Livet.EventListeners.WeakEvents;
using Livet.Messaging;

namespace Livet.Behaviors.Messaging
{
    /// <summary>
    ///     ViewModelからの相互作用メッセージを受信し、アクションを実行します。
    /// </summary>
    public class InteractionMessageTrigger : TriggerBase<FrameworkElement>, IDisposable
    {
        // Using a DependencyProperty as the backing store for Messenger.  This enables animation, styling, binding, etc...
        [NotNull] public static readonly DependencyProperty MessengerProperty =
            DependencyProperty.Register("Messenger", typeof(InteractionMessenger), typeof(InteractionMessageTrigger),
                new PropertyMetadata(MessengerChanged));

        // Using a DependencyProperty as the backing store for FireActionsOnlyWhileAttachedObjectLoading.  This enables animation, styling, binding, etc...
        [NotNull] public static readonly DependencyProperty InvokeActionsOnlyWhileAttatchedObjectLoadedProperty =
            DependencyProperty.Register("InvokeActionsOnlyWhileAttatchedObjectLoaded", typeof(bool),
                typeof(InteractionMessageTrigger), new PropertyMetadata(false));

        // Using a DependencyProperty as the backing store for IsEnable.  This enables animation, styling, binding, etc...
        [NotNull] public static readonly DependencyProperty IsEnableProperty =
            DependencyProperty.Register("IsEnable", typeof(bool), typeof(InteractionMessageTrigger),
                new PropertyMetadata(true));

        private bool _disposed;

        [CanBeNull] private LivetWeakEventListener<EventHandler<InteractionMessageRaisedEventArgs>,
            InteractionMessageRaisedEventArgs> _listener;

        private bool _loaded = true;

        /// <summary>
        ///     ViewModelのMessengerを指定、または取得します。
        /// </summary>
        public InteractionMessenger Messenger
        {
            get { return (InteractionMessenger) GetValue(MessengerProperty); }
            set { SetValue(MessengerProperty, value); }
        }

        /// <summary>
        ///     アタッチされたオブジェクトがロードされている期間(Loaded~Unloaded)だけActionを実行するかどうかを指定、または取得します。デフォルトはfalseです。
        /// </summary>
        public bool InvokeActionsOnlyWhileAttatchedObjectLoaded
        {
            get { return (bool) (GetValue(InvokeActionsOnlyWhileAttatchedObjectLoadedProperty) ?? default(bool)); }
            set { SetValue(InvokeActionsOnlyWhileAttatchedObjectLoadedProperty, value); }
        }

        /// <summary>
        ///     このトリガーが有効かどうかを指定、または取得します。デフォルトはtrueです。
        /// </summary>
        public bool IsEnable
        {
            get { return (bool) (GetValue(IsEnableProperty) ?? default(bool)); }
            set { SetValue(IsEnableProperty, value); }
        }

        /// <summary>
        ///     このトリガーが反応する相互作用メッセージのメッセージキーを指定、または取得します。<br />
        ///     このプロパティが指定されていない場合、このトリガーは全ての相互作用メッセージに反応します。
        /// </summary>
        public string MessageKey { get; set; }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        private static void MessengerChanged([NotNull] DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (d == null) throw new ArgumentNullException(nameof(d));
            var thisReference = (InteractionMessageTrigger) d;

            if (e.OldValue == e.NewValue) return;

            if (e.OldValue != null) thisReference._listener?.Dispose();

            if (e.NewValue == null) return;
            var newMessenger = (InteractionMessenger) e.NewValue;

            thisReference._listener =
                new LivetWeakEventListener<EventHandler<InteractionMessageRaisedEventArgs>,
                    InteractionMessageRaisedEventArgs>(
                    h => h,
                    h => newMessenger.Raised += h,
                    h => newMessenger.Raised -= h,
                    thisReference.MessageReceived);
        }

        private void MessageReceived(object sender, [NotNull] InteractionMessageRaisedEventArgs e)
        {
            if (e == null) throw new ArgumentNullException(nameof(e));

            var message = e.Message;

            var cloneMessage = (InteractionMessage) message.Clone();

            cloneMessage.Freeze();

            var checkResult = false;

            void CheckAction()
            {
                if (!IsEnable) return;
                if (InvokeActionsOnlyWhileAttatchedObjectLoaded && !_loaded) return;
                if (!(string.IsNullOrEmpty(MessageKey) || MessageKey == cloneMessage.MessageKey)) return;

                checkResult = true;
            }

            DoActionOnDispatcher(CheckAction);

            if (!checkResult) return;

            DoActionOnDispatcher(() => InvokeActions(cloneMessage));

            var responsiveMessage = message as ResponsiveInteractionMessage;

            object response;
            if (responsiveMessage != null &&
                (response = ((ResponsiveInteractionMessage) cloneMessage).Response) != null)
                responsiveMessage.Response = response;
        }

        private void DoActionOnDispatcher([NotNull] Action action)
        {
            if (action == null) throw new ArgumentNullException(nameof(action));
            if (Dispatcher == null) throw new InvalidOperationException("Dispatcher is null.");

            if (Dispatcher.CheckAccess())
                action();
            else
                Dispatcher.Invoke(action);
        }

        protected override void OnAttached()
        {
            base.OnAttached();

            if (AssociatedObject == null) return;

            AssociatedObject.Loaded += AssociatedObjectLoaded;
            AssociatedObject.Unloaded += AssociatedObjectUnloaded;
        }

        private void AssociatedObjectLoaded(object sender, RoutedEventArgs e)
        {
            _loaded = true;
        }

        private void AssociatedObjectUnloaded(object sender, RoutedEventArgs e)
        {
            _loaded = false;
        }

        protected override void OnDetaching()
        {
            if (Messenger != null) _listener?.Dispose();

            if (AssociatedObject != null)
            {
                AssociatedObject.Loaded -= AssociatedObjectLoaded;
                AssociatedObject.Unloaded -= AssociatedObjectUnloaded;
            }

            base.OnDetaching();
        }

        // ReSharper disable once UnusedParameter.Global
        protected virtual void Dispose(bool disposing)
        {
            if (_disposed) return;

            _listener?.Dispose();
            _disposed = true;
        }
    }
}