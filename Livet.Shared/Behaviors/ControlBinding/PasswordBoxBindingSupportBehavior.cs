using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Interactivity;
using Livet.Annotations;

namespace Livet.Behaviors.ControlBinding
{
    /// <summary>
    ///     PasswordBoxのPasswordをバインド可能にするためのビヘイビアです。
    /// </summary>
    public class PasswordBoxBindingSupportBehavior : Behavior<PasswordBox>
    {
        // Using a DependencyProperty as the backing store for Password.  This enables animation, styling, binding, etc...
        [NotNull] public static readonly DependencyProperty PasswordProperty =
            DependencyProperty.Register("Password", typeof(string), typeof(PasswordBoxBindingSupportBehavior),
                new FrameworkPropertyMetadata(
                    string.Empty,
                    FrameworkPropertyMetadataOptions.BindsTwoWayByDefault,
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
                    thisObject.AssociatedObject.Password = (string) e.NewValue ?? string.Empty;
            }
        }

        private void ControlPasswordChanged(object sender, RoutedEventArgs e)
        {
            var pb = sender as PasswordBox
                     ?? throw new ArgumentException($"{nameof(sender)} is not a {nameof(PasswordBox)}.");

            if (Password != pb.Password) Password = pb.Password;
        }

        protected override void OnAttached()
        {
            base.OnAttached();

            SourcePasswordChanged(this, new DependencyPropertyChangedEventArgs(PasswordProperty, null, Password));

            if (AssociatedObject != null) AssociatedObject.PasswordChanged += ControlPasswordChanged;
        }
    }
}