using System;
using System.Windows;
using System.Windows.Input;
using System.Windows.Markup;
using Livet.Annotations;
using Livet.Messaging;

namespace Livet.Behaviors.Messaging
{
    /// <summary>
    ///     Viewから直接相互作用メッセージを定義する際に使用します。
    /// </summary>
    [ContentProperty("Message")]
    public class DirectInteractionMessage : Freezable
    {
        // Using a DependencyProperty as the backing store for Message.  This enables animation, styling, binding, etc...
        [NotNull] public static readonly DependencyProperty MessageProperty =
            DependencyProperty.Register("Message", typeof(InteractionMessage), typeof(DirectInteractionMessage),
                new UIPropertyMetadata(null));

        // Using a DependencyProperty as the backing store for CallbackCommand.  This enables animation, styling, binding, etc...
        [NotNull] public static readonly DependencyProperty CallbackCommandProperty =
            DependencyProperty.Register("CallbackCommand", typeof(ICommand), typeof(DirectInteractionMessage),
                new UIPropertyMetadata(null));

        // Using a DependencyProperty as the backing store for CallbackMethodTarget.  This enables animation, styling, binding, etc...
        [NotNull] public static readonly DependencyProperty CallbackMethodTargetProperty =
            DependencyProperty.Register("CallbackMethodTarget", typeof(object), typeof(DirectInteractionMessage),
                new UIPropertyMetadata(null));

        // Using a DependencyProperty as the backing store for MethodName.  This enables animation, styling, binding, etc...
        [NotNull] public static readonly DependencyProperty CallbackMethodNameProperty =
            DependencyProperty.Register("CallbackMethodName", typeof(string), typeof(DirectInteractionMessage),
                new UIPropertyMetadata(null));

        [NotNull] private readonly MethodBinderWithArgument _callbackMethod = new MethodBinderWithArgument();

        /// <summary>
        ///     相互作用メッセージ(各種InteractionMessage)を指定、または取得します。
        /// </summary>
        public InteractionMessage Message
        {
            get { return (InteractionMessage) GetValue(MessageProperty); }
            set { SetValue(MessageProperty, value); }
        }

        /// <summary>
        ///     アクション実行後に実行するコマンドを指定、または取得します<br />
        ///     このプロパティが設定されていた場合、アクションの実行後アクションの実行に使用した相互作用メッセージをパラメータとしてコマンドを呼び出します。
        /// </summary>
        public ICommand CallbackCommand
        {
            get { return (ICommand) GetValue(CallbackCommandProperty); }
            set { SetValue(CallbackCommandProperty, value); }
        }

        /// <summary>
        ///     アクション実行後に実行するメソッドを持つオブジェクトを指定、または取得します<br />
        ///     このプロパティとCallbackMethodNameが設定されていた場合、アクションの実行後アクションの実行に使用した相互作用メッセージをパラメータとしてメソッドを呼び出します。
        /// </summary>
        public object CallbackMethodTarget
        {
            get { return GetValue(CallbackMethodTargetProperty); }
            set { SetValue(CallbackMethodTargetProperty, value); }
        }

        /// <summary>
        ///     アクション実行後に実行するメソッドの名前を指定、または取得します<br />
        ///     このプロパティとCallbackMethodTargetが設定されていた場合、アクションの実行後アクションの実行に使用した相互作用メッセージをパラメータとしてメソッドを呼び出します。
        /// </summary>
        public string CallbackMethodName
        {
            get { return (string) GetValue(CallbackMethodNameProperty); }
            set { SetValue(CallbackMethodNameProperty, value); }
        }

        internal void InvokeCallbacks([NotNull] InteractionMessage message)
        {
            if (message == null) throw new ArgumentNullException(nameof(message));

            if (CallbackCommand != null)
            {
                if (CallbackCommand.CanExecute(message))
                    CallbackCommand.Execute(message);
            }

            if (CallbackMethodTarget != null && CallbackMethodName != null)
                _callbackMethod.Invoke(CallbackMethodTarget, CallbackMethodName, message);
        }

        protected override Freezable CreateInstanceCore()
        {
            return new DirectInteractionMessage();
        }
    }
}