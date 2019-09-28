using System.ComponentModel;
using System.Windows;
using Microsoft.Xaml.Behaviors;
using System.Windows.Markup;
using Livet.Annotations;
using Livet.Messaging;

namespace Livet.Behaviors.Messaging
{
    /// <summary>
    ///     ViewModelからの相互作用メッセージに対応するアクションの基底抽象クラスです<br />
    ///     独自のアクションを定義する場合はこのクラスを継承してください。
    /// </summary>
    /// <typeparam name="T">このアクションがアタッチ可能な型を示します。</typeparam>
    [ContentProperty("DirectInteractionMessage")]
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1000:DoNotDeclareStaticMembersOnGenericTypes")]
    public abstract class InteractionMessageAction<T> : TriggerAction<T> where T : DependencyObject
    {
        // Using a DependencyProperty as the backing store for DirectInteractionMessage.  This enables animation, styling, binding, etc...
        [NotNull] public static readonly DependencyProperty DirectInteractionMessageProperty =
            DependencyProperty.Register("DirectInteractionMessage", typeof(DirectInteractionMessage),
                typeof(InteractionMessageAction<T>), new PropertyMetadata());

        // Using a DependencyProperty as the backing store for InvokeActionOnlyWhenWindowIsActive.  This enables animation, styling, binding, etc...
        [NotNull] public static readonly DependencyProperty InvokeActionOnlyWhenWindowIsActiveProperty =
            DependencyProperty.Register("InvokeActionOnlyWhenWindowIsActive", typeof(bool),
                typeof(InteractionMessageAction<T>), new PropertyMetadata(true));

        /// <summary>
        ///     Viewで直接相互作用メッセージを定義する場合に使用する、DirectInteractionMessageを指定、または取得します。
        /// </summary>
        public DirectInteractionMessage DirectInteractionMessage
        {
            get { return (DirectInteractionMessage) GetValue(DirectInteractionMessageProperty); }
            set { SetValue(DirectInteractionMessageProperty, value); }
        }

        /// <summary>
        ///     Windowがアクティブな時のみアクションを実行するかどうかを指定、または取得します。初期値はtrueです。
        /// </summary>
        public bool InvokeActionOnlyWhenWindowIsActive
        {
            get { return (bool) (GetValue(InvokeActionOnlyWhenWindowIsActiveProperty) ?? default(bool)); }
            set { SetValue(InvokeActionOnlyWhenWindowIsActiveProperty, value); }
        }

        protected sealed override void Invoke(object parameter)
        {
            var metadata = DesignerProperties.IsInDesignModeProperty?.GetMetadata(typeof(DependencyObject));
            if ((bool) (metadata?.DefaultValue ?? false)) return;

            var message = parameter as InteractionMessage;

            if (DirectInteractionMessage != null) message = DirectInteractionMessage.Message;

            if (AssociatedObject == null) return;

            var window = Window.GetWindow(AssociatedObject);
            if (window == null) return;
            if (!window.IsActive && InvokeActionOnlyWhenWindowIsActive) return;
            if (message == null) return;

            InvokeAction(message);
            DirectInteractionMessage?.InvokeCallbacks(message);
        }

        protected abstract void InvokeAction(InteractionMessage message);
    }
}