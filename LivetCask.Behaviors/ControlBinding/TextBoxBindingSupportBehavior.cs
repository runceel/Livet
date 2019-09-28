using System;
using System.Windows;
using System.Windows.Controls;
using Microsoft.Xaml.Behaviors;
using System.Diagnostics.CodeAnalysis;
#if !NETCOREAPP
using Livet.Annotations;
#endif

namespace Livet.Behaviors.ControlBinding
{
    /// <summary>
    ///     TextBoxの選択文字列に関わるプロパティをバインド可能にするためのビヘイビアです。
    /// </summary>
    public class TextBoxBindingSupportBehavior : Behavior<TextBox>
    {
        // Using a DependencyProperty as the backing store for SelectedText.  This enables animation, styling, binding, etc...
        [NotNull] public static readonly DependencyProperty SelectedTextProperty =
            DependencyProperty.Register("SelectedText", typeof(string), typeof(TextBoxBindingSupportBehavior),
                new FrameworkPropertyMetadata(string.Empty, FrameworkPropertyMetadataOptions.BindsTwoWayByDefault,
                    SourceSelectedTextChanged));

        // Using a DependencyProperty as the backing store for SelectionLength.  This enables animation, styling, binding, etc...
        [NotNull] public static readonly DependencyProperty SelectionLengthProperty =
            DependencyProperty.Register("SelectionLength", typeof(int), typeof(TextBoxBindingSupportBehavior),
                new FrameworkPropertyMetadata(0, FrameworkPropertyMetadataOptions.BindsTwoWayByDefault,
                    SourceSelectionLengthChanged));

        // Using a DependencyProperty as the backing store for SelectionStart.  This enables animation, styling, binding, etc...
        [NotNull] public static readonly DependencyProperty SelectionStartProperty =
            DependencyProperty.Register("SelectionStart", typeof(int), typeof(TextBoxBindingSupportBehavior),
                new FrameworkPropertyMetadata(0, FrameworkPropertyMetadataOptions.BindsTwoWayByDefault,
                    SourceSelectionStartChanged));

        /// <summary>
        ///     選択された文字列を取得、または設定します。
        /// </summary>
        public string SelectedText
        {
            get { return (string) GetValue(SelectedTextProperty); }
            set { SetValue(SelectedTextProperty, value); }
        }

        /// <summary>
        ///     選択された文字列の長さを取得、または設定します。
        /// </summary>
        public int SelectionLength
        {
            get { return (int) (GetValue(SelectionLengthProperty) ?? default(int)); }
            set { SetValue(SelectionLengthProperty, value); }
        }

        /// <summary>
        ///     選択された文字列の先頭のインデックスを取得、または設定します。
        /// </summary>
        public int SelectionStart
        {
            get { return (int) (GetValue(SelectionStartProperty) ?? default(int)); }
            set { SetValue(SelectionStartProperty, value); }
        }

        private static void SourceSelectedTextChanged(DependencyObject sender, DependencyPropertyChangedEventArgs e)
        {
            var thisObject = sender as TextBoxBindingSupportBehavior;
            var associatedObject = thisObject?.AssociatedObject;
            var s = e.NewValue as string;
            if (associatedObject != null && associatedObject.SelectedText != s && s != null)
                associatedObject.SelectedText = s;
        }

        private static void SourceSelectionLengthChanged(DependencyObject sender, DependencyPropertyChangedEventArgs e)
        {
            var associatedObject = (sender as TextBoxBindingSupportBehavior)?.AssociatedObject;
            if (associatedObject == null) return;

            var newValue = (int) (e.NewValue ?? default(int));
            if (associatedObject.SelectionLength != newValue)
                associatedObject.SelectionLength = newValue;
        }

        private static void SourceSelectionStartChanged(DependencyObject sender, DependencyPropertyChangedEventArgs e)
        {
            var associatedObject = (sender as TextBoxBindingSupportBehavior)?.AssociatedObject;
            if (associatedObject == null) return;

            var newValue = (int) (e.NewValue ?? default(int));
            if (associatedObject.SelectionStart != newValue)
                associatedObject.SelectionStart = newValue;
        }

        private void ControlSelectedTextChanged([NotNull] object sender, RoutedEventArgs e)
        {
            if (sender == null) throw new ArgumentNullException(nameof(sender));
            var textBox = (TextBox) sender;

            if (SelectedText != textBox.SelectedText) SelectedText = textBox.SelectedText;

            if (SelectionStart != textBox.SelectionStart) SelectionStart = textBox.SelectionStart;

            if (SelectionLength != textBox.SelectionLength) SelectionLength = textBox.SelectionLength;
        }

        protected override void OnAttached()
        {
            base.OnAttached();

            SourceSelectedTextChanged(this,
                new DependencyPropertyChangedEventArgs(SelectedTextProperty, null, SelectedText));
            SourceSelectionStartChanged(this,
                new DependencyPropertyChangedEventArgs(SelectionStartProperty, null, SelectionStart));
            SourceSelectionLengthChanged(this,
                new DependencyPropertyChangedEventArgs(SelectionLengthProperty, null, SelectionLength));

            if (AssociatedObject != null) AssociatedObject.SelectionChanged += ControlSelectedTextChanged;
        }
    }
}