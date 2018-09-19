
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
	/// WebBrowserクラスの、標準ではバインドできないプロパティで書き込み可能なものを表します。
	/// </summary>
	public enum WebBrowserUnbindableCanWriteProperty
	{
		Source,
		ObjectForScripting
	}

	/// <summary>
	/// WebBrowserクラスのバインディングできないプロパティに、指定されたソースから値を設定するためのビヘイビアです。
	/// </summary>
	public class WebBrowserSetStateToControlBehavior : Behavior<WebBrowser>
	{
		public WebBrowserSetStateToControlBehavior()
		{
		}

		/// <summary>
		/// 値を設定したいプロパティを取得または設定します。
		/// </summary>
		public WebBrowserUnbindableCanWriteProperty Property
        {
            get { return (WebBrowserUnbindableCanWriteProperty)GetValue(PropertyProperty); }
            set { SetValue(PropertyProperty, value); }
        }

        public static readonly DependencyProperty PropertyProperty =
            DependencyProperty.Register("Property", typeof(WebBrowserUnbindableCanWriteProperty), typeof(WebBrowserSetStateToControlBehavior), new PropertyMetadata());

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
            DependencyProperty.Register("Source", typeof(object), typeof(WebBrowserSetStateToControlBehavior), new FrameworkPropertyMetadata(null,new PropertyChangedCallback(SourceChanged)));

        private static void SourceChanged(DependencyObject sender,DependencyPropertyChangedEventArgs e)
        {
			var thisObject = (WebBrowserSetStateToControlBehavior)sender;
			
			if(thisObject.AssociatedObject == null)
			{
				return;
			}

            switch (thisObject.Property)
            {
                case WebBrowserUnbindableCanWriteProperty.Source:
					if(e.NewValue == null)
					{
						return;
					}
					if(e.OldValue != null)
					{
						if((System.Uri)e.OldValue == (System.Uri)e.NewValue)
						{
							return;
						}
					}
					thisObject.AssociatedObject.Source = (System.Uri)thisObject.Source;
                    break;
                case WebBrowserUnbindableCanWriteProperty.ObjectForScripting:
					if(e.NewValue == null)
					{
						return;
					}
					if(e.OldValue != null)
					{
						if((System.Object)e.OldValue == (System.Object)e.NewValue)
						{
							return;
						}
					}
					thisObject.AssociatedObject.ObjectForScripting = (System.Object)thisObject.Source;
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