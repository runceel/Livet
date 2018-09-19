
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
	/// MediaElementクラスの、標準ではバインドできないプロパティで書き込み可能なものを表します。
	/// </summary>
	public enum MediaElementUnbindableCanWriteProperty
	{
		Position,
		SpeedRatio
	}

	/// <summary>
	/// MediaElementクラスのバインディングできないプロパティに、指定されたソースから値を設定するためのビヘイビアです。
	/// </summary>
	public class MediaElementSetStateToControlBehavior : Behavior<MediaElement>
	{
		public MediaElementSetStateToControlBehavior()
		{
		}

		/// <summary>
		/// 値を設定したいプロパティを取得または設定します。
		/// </summary>
		public MediaElementUnbindableCanWriteProperty Property
        {
            get { return (MediaElementUnbindableCanWriteProperty)GetValue(PropertyProperty); }
            set { SetValue(PropertyProperty, value); }
        }

        public static readonly DependencyProperty PropertyProperty =
            DependencyProperty.Register("Property", typeof(MediaElementUnbindableCanWriteProperty), typeof(MediaElementSetStateToControlBehavior), new PropertyMetadata());

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
            DependencyProperty.Register("Source", typeof(object), typeof(MediaElementSetStateToControlBehavior), new FrameworkPropertyMetadata(null,new PropertyChangedCallback(SourceChanged)));

        private static void SourceChanged(DependencyObject sender,DependencyPropertyChangedEventArgs e)
        {
			var thisObject = (MediaElementSetStateToControlBehavior)sender;
			
			if(thisObject.AssociatedObject == null)
			{
				return;
			}

            switch (thisObject.Property)
            {
                case MediaElementUnbindableCanWriteProperty.Position:
					if(e.NewValue == null)
					{
						return;
					}
					if(e.OldValue != null)
					{
						if((System.TimeSpan)e.OldValue == (System.TimeSpan)e.NewValue)
						{
							return;
						}
					}
					thisObject.AssociatedObject.Position = (System.TimeSpan)thisObject.Source;
                    break;
                case MediaElementUnbindableCanWriteProperty.SpeedRatio:
					if(e.NewValue == null)
					{
						return;
					}
					if(e.OldValue != null)
					{
						if((System.Double)e.OldValue == (System.Double)e.NewValue)
						{
							return;
						}
					}
					thisObject.AssociatedObject.SpeedRatio = (System.Double)thisObject.Source;
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