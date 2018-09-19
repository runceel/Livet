
//このコードはT4 Templateによって自動生成されています。

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;
using System.Windows;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Interactivity;
using System.Windows.Controls.Primitives;
using System.Windows.Interop;
using System.ComponentModel;

namespace Livet.Behaviors.ControlBinding.OneWay
{
	/// <summary>
	/// DatePickerTextBoxクラスの、標準ではバインドできないプロパティで書き込み可能なものを表します。
	/// </summary>
	public enum DatePickerTextBoxUnbindableCanWriteProperty
	{
		SelectedText,
		SelectionLength,
		SelectionStart,
		CaretIndex
	}

	/// <summary>
	/// DatePickerTextBoxクラスのバインディングできないプロパティに、指定されたソースから値を設定するためのビヘイビアです。
	/// </summary>
	public class DatePickerTextBoxSetStateToControlBehavior : Behavior<DatePickerTextBox>
	{
		public DatePickerTextBoxSetStateToControlBehavior()
		{
		}

		/// <summary>
		/// 値を設定したいプロパティを取得または設定します。
		/// </summary>
		public DatePickerTextBoxUnbindableCanWriteProperty Property
        {
            get { return (DatePickerTextBoxUnbindableCanWriteProperty)GetValue(PropertyProperty); }
            set { SetValue(PropertyProperty, value); }
        }

        public static readonly DependencyProperty PropertyProperty =
            DependencyProperty.Register("Property", typeof(DatePickerTextBoxUnbindableCanWriteProperty), typeof(DatePickerTextBoxSetStateToControlBehavior), new PropertyMetadata());

		/// <summary>
		/// Propertyプロパティで指定されたプロパティに値を設定するソースを取得または設定します。
		/// </summary>
		[Bindable(BindableSupport.Default,BindingDirection.OneWay)]
		public object Source
        {
            get { return (object)GetValue(SourceProperty); }
            set { SetValue(SourceProperty, value); }
        }

        public static readonly DependencyProperty SourceProperty =
            DependencyProperty.Register("Source", typeof(object), typeof(DatePickerTextBoxSetStateToControlBehavior), new FrameworkPropertyMetadata(null,new PropertyChangedCallback(SourceChanged)));

        private static void SourceChanged(DependencyObject sender,DependencyPropertyChangedEventArgs e)
        {
			var thisObject = (DatePickerTextBoxSetStateToControlBehavior)sender;
			
			if(thisObject.AssociatedObject == null)
			{
				return;
			}

            switch (thisObject.Property)
            {
                case DatePickerTextBoxUnbindableCanWriteProperty.SelectedText:
					if(e.NewValue == null)
					{
						return;
					}
					if(e.OldValue != null)
					{
						if((System.String)e.OldValue == (System.String)e.NewValue)
						{
							return;
						}
					}
					thisObject.AssociatedObject.SelectedText = (System.String)thisObject.Source;
                    break;
                case DatePickerTextBoxUnbindableCanWriteProperty.SelectionLength:
					if(e.NewValue == null)
					{
						return;
					}
					if(e.OldValue != null)
					{
						if((System.Int32)e.OldValue == (System.Int32)e.NewValue)
						{
							return;
						}
					}
					thisObject.AssociatedObject.SelectionLength = (System.Int32)thisObject.Source;
                    break;
                case DatePickerTextBoxUnbindableCanWriteProperty.SelectionStart:
					if(e.NewValue == null)
					{
						return;
					}
					if(e.OldValue != null)
					{
						if((System.Int32)e.OldValue == (System.Int32)e.NewValue)
						{
							return;
						}
					}
					thisObject.AssociatedObject.SelectionStart = (System.Int32)thisObject.Source;
                    break;
                case DatePickerTextBoxUnbindableCanWriteProperty.CaretIndex:
					if(e.NewValue == null)
					{
						return;
					}
					if(e.OldValue != null)
					{
						if((System.Int32)e.OldValue == (System.Int32)e.NewValue)
						{
							return;
						}
					}
					thisObject.AssociatedObject.CaretIndex = (System.Int32)thisObject.Source;
                    break;

            }
        }

		protected override void OnAttached()
        {
            base.OnAttached();

            //Attatch時の評価
            SourceChanged(this, new DependencyPropertyChangedEventArgs(SourceProperty, null, Source));
        }
	}
}