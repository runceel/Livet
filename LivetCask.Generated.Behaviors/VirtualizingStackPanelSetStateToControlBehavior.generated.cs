﻿
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
using Microsoft.Xaml.Behaviors;
using System.Windows.Controls.Primitives;
using System.Windows.Interop;
using System.ComponentModel;

namespace Livet.Behaviors.ControlBinding.OneWay
{
	/// <summary>
	/// VirtualizingStackPanelクラスの、標準ではバインドできないプロパティで書き込み可能なものを表します。
	/// </summary>
	public enum VirtualizingStackPanelUnbindableCanWriteProperty
	{
		CanHorizontallyScroll,
		CanVerticallyScroll
	}

	/// <summary>
	/// VirtualizingStackPanelクラスのバインディングできないプロパティに、指定されたソースから値を設定するためのビヘイビアです。
	/// </summary>
	public class VirtualizingStackPanelSetStateToControlBehavior : Behavior<VirtualizingStackPanel>
	{
		public VirtualizingStackPanelSetStateToControlBehavior()
		{
		}

		/// <summary>
		/// 値を設定したいプロパティを取得または設定します。
		/// </summary>
		public VirtualizingStackPanelUnbindableCanWriteProperty Property
        {
            get { return (VirtualizingStackPanelUnbindableCanWriteProperty)GetValue(PropertyProperty); }
            set { SetValue(PropertyProperty, value); }
        }

        public static readonly DependencyProperty PropertyProperty =
            DependencyProperty.Register("Property", typeof(VirtualizingStackPanelUnbindableCanWriteProperty), typeof(VirtualizingStackPanelSetStateToControlBehavior), new PropertyMetadata());

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
            DependencyProperty.Register("Source", typeof(object), typeof(VirtualizingStackPanelSetStateToControlBehavior), new PropertyMetadata(null,new PropertyChangedCallback(SourceChanged)));

        private static void SourceChanged(DependencyObject sender,DependencyPropertyChangedEventArgs e)
        {
			var thisObject = (VirtualizingStackPanelSetStateToControlBehavior)sender;
			
			if(thisObject.AssociatedObject == null)
			{
				return;
			}

            switch (thisObject.Property)
            {
                case VirtualizingStackPanelUnbindableCanWriteProperty.CanHorizontallyScroll:
					if(e.NewValue == null)
					{
						return;
					}
					if(e.OldValue != null)
					{
						if((System.Boolean)e.OldValue == (System.Boolean)e.NewValue)
						{
							return;
						}
					}
					thisObject.AssociatedObject.CanHorizontallyScroll = (System.Boolean)thisObject.Source;
                    break;
                case VirtualizingStackPanelUnbindableCanWriteProperty.CanVerticallyScroll:
					if(e.NewValue == null)
					{
						return;
					}
					if(e.OldValue != null)
					{
						if((System.Boolean)e.OldValue == (System.Boolean)e.NewValue)
						{
							return;
						}
					}
					thisObject.AssociatedObject.CanVerticallyScroll = (System.Boolean)thisObject.Source;
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