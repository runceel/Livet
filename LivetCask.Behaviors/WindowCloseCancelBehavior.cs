using System;
using System.Windows;
using System.Windows.Input;
using Microsoft.Xaml.Behaviors;
using Livet.Annotations;

namespace Livet.Behaviors
{
    /// <summary>
    ///     WindowのClose処理をキャンセルし、キャンセルした事をCallback通知可能なビヘイビアです。
    /// </summary>
    public class WindowCloseCancelBehavior : Behavior<Window>
    {
        // Using a DependencyProperty as the backing store for CanClose.  This enables animation, styling, binding, etc...
        [NotNull] public static readonly DependencyProperty CanCloseProperty =
            DependencyProperty.Register("CanClose", typeof(bool), typeof(WindowCloseCancelBehavior),
                new PropertyMetadata(true));

        // Using a DependencyProperty as the backing store for CloseCanceledCallbackCommand.  This enables animation, styling, binding, etc...
        [NotNull] public static readonly DependencyProperty CloseCanceledCallbackCommandProperty =
            DependencyProperty.Register("CloseCanceledCallbackCommand", typeof(ICommand),
                typeof(WindowCloseCancelBehavior), new PropertyMetadata(null));

        // Using a DependencyProperty as the backing store for CloseCanceledCallbackMethodTarget.  This enables animation, styling, binding, etc...
        [NotNull] public static readonly DependencyProperty CloseCanceledCallbackMethodTargetProperty =
            DependencyProperty.Register("CloseCanceledCallbackMethodTarget", typeof(object),
                typeof(WindowCloseCancelBehavior), new PropertyMetadata(null));

        // Using a DependencyProperty as the backing store for CloseCanceledCallbackMethodName.  This enables animation, styling, binding, etc...
        [NotNull] public static readonly DependencyProperty CloseCanceledCallbackMethodNameProperty =
            DependencyProperty.Register("CloseCanceledCallbackMethodName", typeof(string),
                typeof(WindowCloseCancelBehavior), new PropertyMetadata(null));

        [NotNull] private readonly MethodBinder _callbackMethod = new MethodBinder();

        /// <summary>
        ///     このWindowを閉じることが可能かどうかを取得、または設定します。このプロパティがfalseを示す場合、WindowClose処理はキャンセルされます。デフォルト値はtrueです。
        /// </summary>
        public bool CanClose
        {
            get { return (bool) (GetValue(CanCloseProperty) ?? default(bool)); }
            set { SetValue(CanCloseProperty, value); }
        }

        /// <summary>
        ///     Windowを閉じる処理がこのビヘイビアによってキャンセルされた場合に実行するコマンドを取得、または設定します。
        /// </summary>
        public ICommand CloseCanceledCallbackCommand
        {
            get { return (ICommand) GetValue(CloseCanceledCallbackCommandProperty); }
            set { SetValue(CloseCanceledCallbackCommandProperty, value); }
        }

        /// <summary>
        ///     Windowを閉じる処理がこのビヘイビアによってキャンセルされた場合に実行するメソッドを持つオブジェクトを取得、または設定します。
        /// </summary>
        public object CloseCanceledCallbackMethodTarget
        {
            get { return GetValue(CloseCanceledCallbackMethodTargetProperty); }
            set { SetValue(CloseCanceledCallbackMethodTargetProperty, value); }
        }

        /// <summary>
        ///     Windowを閉じる処理がこのビヘイビアによってキャンセルされた場合に実行するメソッドの名前を取得、または設定します。
        /// </summary>
        public string CloseCanceledCallbackMethodName
        {
            get { return (string) GetValue(CloseCanceledCallbackMethodNameProperty); }
            set { SetValue(CloseCanceledCallbackMethodNameProperty, value); }
        }

        protected override void OnAttached()
        {
            var associatedObject = AssociatedObject;
            if (associatedObject == null) throw new InvalidOperationException();

            base.OnAttached();
            associatedObject.Closing += (sender, e) =>
            {
                if (e == null) throw new ArgumentNullException(nameof(e));

                if (CanClose) return;
                if (CloseCanceledCallbackCommand != null && CloseCanceledCallbackCommand.CanExecute(null))
                    CloseCanceledCallbackCommand.Execute(null);

                if (CloseCanceledCallbackMethodTarget != null && CloseCanceledCallbackMethodName != null)
                    _callbackMethod.Invoke(CloseCanceledCallbackMethodTarget, CloseCanceledCallbackMethodName);

                e.Cancel = true;
            };
        }
    }
}