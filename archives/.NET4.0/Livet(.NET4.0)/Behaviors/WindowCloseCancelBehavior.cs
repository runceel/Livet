using System.Windows.Interactivity;
using System.Windows;
using System.Windows.Input;

namespace Livet.Behaviors
{
    /// <summary>
    /// WindowのClose処理をキャンセルし、キャンセルした事をCallback通知可能なビヘイビアです。
    /// </summary>
    public class WindowCloseCancelBehavior : Behavior<Window>
    {
        MethodBinder _callbackMethod = new MethodBinder();

        /// <summary>
        /// このWindowを閉じることが可能かどうかを取得、または設定します。このプロパティがfalseを示す場合、WindowClose処理はキャンセルされます。デフォルト値はtrueです。
        /// </summary>
        public bool CanClose
        {
            get { return (bool)GetValue(CanCloseProperty); }
            set { SetValue(CanCloseProperty, value); }
        }

        // Using a DependencyProperty as the backing store for CanClose.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty CanCloseProperty =
            DependencyProperty.Register("CanClose", typeof(bool), typeof(WindowCloseCancelBehavior), new PropertyMetadata(true));

        /// <summary>
        /// Windowを閉じる処理がこのビヘイビアによってキャンセルされた場合に実行するコマンドを取得、または設定します。
        /// </summary>
        public ICommand CloseCanceledCallbackCommand
        {
            get { return (ICommand)GetValue(CloseCanceledCallbackCommandProperty); }
            set { SetValue(CloseCanceledCallbackCommandProperty, value); }
        }

        // Using a DependencyProperty as the backing store for CloseCanceledCallbackCommand.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty CloseCanceledCallbackCommandProperty =
            DependencyProperty.Register("CloseCanceledCallbackCommand", typeof(ICommand), typeof(WindowCloseCancelBehavior), new PropertyMetadata(null));

        /// <summary>
        /// Windowを閉じる処理がこのビヘイビアによってキャンセルされた場合に実行するメソッドを持つオブジェクトを取得、または設定します。
        /// </summary>
        public object CloseCanceledCallbackMethodTarget
        {
            get { return GetValue(CloseCanceledCallbackMethodTargetProperty); }
            set { SetValue(CloseCanceledCallbackMethodTargetProperty, value); }
        }

        // Using a DependencyProperty as the backing store for CloseCanceledCallbackMethodTarget.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty CloseCanceledCallbackMethodTargetProperty =
            DependencyProperty.Register("CloseCanceledCallbackMethodTarget", typeof(object), typeof(WindowCloseCancelBehavior), new PropertyMetadata(null));

        /// <summary>
        /// Windowを閉じる処理がこのビヘイビアによってキャンセルされた場合に実行するメソッドの名前を取得、または設定します。
        /// </summary>
        public string CloseCanceledCallbackMethodName
        {
            get { return (string)GetValue(CloseCanceledCallbackMethodNameProperty); }
            set { SetValue(CloseCanceledCallbackMethodNameProperty, value); }
        }

        // Using a DependencyProperty as the backing store for CloseCanceledCallbackMethodName.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty CloseCanceledCallbackMethodNameProperty =
            DependencyProperty.Register("CloseCanceledCallbackMethodName", typeof(string), typeof(WindowCloseCancelBehavior), new PropertyMetadata(null));

        protected override void OnAttached()
        {
            base.OnAttached();
            AssociatedObject.Closing += (sender, e) =>
                {
                    if (!CanClose)
                    {
                        if (CloseCanceledCallbackCommand != null && CloseCanceledCallbackCommand.CanExecute(null))
                        {
                            CloseCanceledCallbackCommand.Execute(null);
                        }


                        if (CloseCanceledCallbackMethodTarget != null && CloseCanceledCallbackMethodName != null)
                        {
                            _callbackMethod.Invoke(CloseCanceledCallbackMethodTarget, CloseCanceledCallbackMethodName);
                        }

                        e.Cancel = true;
                    }
                };
        }
    }
}
