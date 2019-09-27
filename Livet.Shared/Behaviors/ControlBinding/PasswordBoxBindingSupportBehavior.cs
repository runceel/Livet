using System;
using System.Diagnostics.CodeAnalysis;
using System.Windows;
using System.Windows.Controls;
using Microsoft.Xaml.Behaviors;
#if !NETCOREAPP
using Livet.Annotations;
#endif

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
            var associatedObject = (sender as PasswordBoxBindingSupportBehavior)?.AssociatedObject;
            if (associatedObject == null) return;

            var newValue = e.NewValue as string;
            if (associatedObject.Password != newValue)
                associatedObject.Password = newValue ?? string.Empty;
        }

        private void ControlPasswordChanged([NotNull] object sender, RoutedEventArgs e)
        {
            if (sender == null) throw new ArgumentNullException(nameof(sender));
            var pb = (PasswordBox) sender;

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