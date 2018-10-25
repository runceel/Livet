using System.Windows.Interactivity;
using System.Windows.Controls;
using System.Windows;

namespace Livet.Behaviors.ControlBinding
{
    /// <summary>
    /// TextBoxの選択文字列に関わるプロパティをバインド可能にするためのビヘイビアです。
    /// </summary>
    public class TextBoxBindingSupportBehavior : Behavior<TextBox>
    {

        /// <summary>
        /// 選択された文字列を取得、または設定します。
        /// </summary>
        public string SelectedText
        {
            get { return (string)GetValue(SelectedTextProperty); }
            set { SetValue(SelectedTextProperty, value); }
        }

        // Using a DependencyProperty as the backing store for SelectedText.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty SelectedTextProperty =
            DependencyProperty.Register("SelectedText", typeof(string), typeof(TextBoxBindingSupportBehavior), new FrameworkPropertyMetadata(string.Empty, FrameworkPropertyMetadataOptions.BindsTwoWayByDefault, SourceSelectedTextChanged));


        /// <summary>
        /// 選択された文字列の長さを取得、または設定します。
        /// </summary>
        public int SelectionLength
        {
            get { return (int)GetValue(SelectionLengthProperty); }
            set { SetValue(SelectionLengthProperty, value); }
        }       

        // Using a DependencyProperty as the backing store for SelectionLengh.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty SelectionLengthProperty =
            DependencyProperty.Register("SelectionLength", typeof(int), typeof(TextBoxBindingSupportBehavior), new FrameworkPropertyMetadata(0, FrameworkPropertyMetadataOptions.BindsTwoWayByDefault, SourceSelectionLengthChanged));


        /// <summary>
        /// 選択された文字列の先頭のインデックスを取得、または設定します。
        /// </summary>
        public int SelectionStart
        {
            get { return (int)GetValue(SelectionStartProperty); }
            set { SetValue(SelectionStartProperty, value); }
        }

        // Using a DependencyProperty as the backing store for SelectionStart.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty SelectionStartProperty =
            DependencyProperty.Register("SelectionStart", typeof(int), typeof(TextBoxBindingSupportBehavior), new FrameworkPropertyMetadata(0, FrameworkPropertyMetadataOptions.BindsTwoWayByDefault, SourceSelectionStartChanged));

        


        private static void SourceSelectedTextChanged(DependencyObject sender, DependencyPropertyChangedEventArgs e)
        {
            var thisObject = (TextBoxBindingSupportBehavior)sender;

            if (thisObject.AssociatedObject == null) return;

            if (thisObject.AssociatedObject.SelectedText != (string)e.NewValue)
            {
                if(((string)e.NewValue) != null)
                {
                    thisObject.AssociatedObject.SelectedText = (string)e.NewValue;
                }
            }
        }

        private static void SourceSelectionLengthChanged(DependencyObject sender, DependencyPropertyChangedEventArgs e)
        {
            var thisObject = (TextBoxBindingSupportBehavior)sender;

            if (thisObject.AssociatedObject == null) return;

            if (thisObject.AssociatedObject.SelectionLength != (int)e.NewValue)
            {
                thisObject.AssociatedObject.SelectionLength = (int)e.NewValue;
            }
        }

        private static void SourceSelectionStartChanged(DependencyObject sender, DependencyPropertyChangedEventArgs e)
        {
            var thisObject = (TextBoxBindingSupportBehavior)sender;

            if (thisObject.AssociatedObject == null) return;

            if (thisObject.AssociatedObject.SelectionStart != (int)e.NewValue)
            {
                thisObject.AssociatedObject.SelectionStart = (int)e.NewValue;
            }
        }

        private void ControlSelectedTextChanged(object sender, RoutedEventArgs e)
        {
            var textBox = (TextBox)sender;

            if (SelectedText != textBox.SelectedText)
            {
                SelectedText = textBox.SelectedText;
            }

            if (SelectionStart != textBox.SelectionStart)
            {
                SelectionStart = textBox.SelectionStart;
            }

            if (SelectionLength != textBox.SelectionLength)
            {
                SelectionLength = textBox.SelectionLength;
            }
        }


        protected override void OnAttached()
        {
            base.OnAttached();

            SourceSelectedTextChanged(this, new DependencyPropertyChangedEventArgs(SelectedTextProperty, null, SelectedText));
            SourceSelectionStartChanged(this, new DependencyPropertyChangedEventArgs(SelectionStartProperty, null, SelectionStart));
            SourceSelectionLengthChanged(this, new DependencyPropertyChangedEventArgs(SelectionLengthProperty, null, SelectionLength));

            AssociatedObject.SelectionChanged += ControlSelectedTextChanged;
        }
    }
}
