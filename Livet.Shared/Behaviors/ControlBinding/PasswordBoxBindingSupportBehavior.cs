using System.Windows;
using System.Windows.Controls;
using System.Windows.Interactivity;

namespace Livet.Behaviors.ControlBinding
{
    /// <summary>
    ///     PasswordBoxのPasswordをバインド可能にするためのビヘイビアです。
    /// </summary>
    public class PasswordBoxBindingSupportBehavior : Behavior<PasswordBox>
    {
        // Using a DependencyProperty as the backing store for Password.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty PasswordProperty =
            DependencyProperty.Register("Password", typeof(string), typeof(PasswordBoxBindingSupportBehavior),
                new FrameworkPropertyMetadata(string.Empty, FrameworkPropertyMetadataOptions.BindsTwoWayByDefault,
                    SourcePasswordChanged));

        /// <summary>
        ///     パスワードを取得、または設定します。
        /// </summary>
        public string Password
        {
            get { return (string) GetValue(PasswordProperty); }
            set { SetValue(PasswordProperty, value); }
        }

        private static void SourcePasswordChanged(DependencyObject sender, DependencyPropertyChangedEventArgs e)
        {
            if (sender is PasswordBoxBindingSupportBehavior thisObject)
            {
                if (thisObject.AssociatedObject == null) return;

                if (thisObject.AssociatedObject.Password != (string) e.NewValue)
                    thisObject.AssociatedObject.Password = (string) e.NewValue;
            }
        }

        private void ControlPasswordChanged(object sender, RoutedEventArgs e)
        {
            var passwordBox = (PasswordBox) sender;

            if (Password != passwordBox.Password) Password = passwordBox.Password;
        }

        protected override void OnAttached()
        {
            base.OnAttached();

            SourcePasswordChanged(this, new DependencyPropertyChangedEventArgs(PasswordProperty, null, Password));

            AssociatedObject.PasswordChanged += ControlPasswordChanged;
        }
    }
}