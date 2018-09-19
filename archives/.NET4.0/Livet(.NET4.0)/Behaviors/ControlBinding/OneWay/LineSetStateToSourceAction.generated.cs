
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
using System.ComponentModel;
using System.Windows.Interop;

namespace Livet.Behaviors.ControlBinding.OneWay
{
	/// <summary>
	/// Lineクラスの、標準ではバインドできないプロパティを表します。
	/// </summary>
	public enum LineUnbindableCanReadProperty
	{
		ActualWidth,
		ActualHeight,
		IsInitialized,
		IsLoaded,
		HasAnimatedProperties,
		IsMeasureValid,
		IsArrangeValid,
		IsMouseDirectlyOver,
		IsMouseOver,
		IsStylusOver,
		IsKeyboardFocusWithin,
		IsMouseCaptured,
		IsMouseCaptureWithin,
		IsStylusDirectlyOver,
		IsStylusCaptured,
		IsStylusCaptureWithin,
		IsKeyboardFocused,
		IsInputMethodEnabled,
		IsFocused,
		IsVisible,
		AreAnyTouchesOver,
		AreAnyTouchesDirectlyOver,
		AreAnyTouchesCapturedWithin,
		AreAnyTouchesCaptured,
		IsSealed
	}

	/// <summary>
	/// Lineクラスのバインドできないプロパティから、値を指定されたソースに反映するためのアクションです。
	/// </summary>
	public class LineSetStateToSourceAction : TriggerAction<Line>
	{
		public LineSetStateToSourceAction()
		{
		}

		/// <summary>
		/// 値を設定したいプロパティを取得または設定します。
		/// </summary>
		public LineUnbindableCanReadProperty Property
        {
            get { return (LineUnbindableCanReadProperty)GetValue(PropertyProperty); }
            set { SetValue(PropertyProperty, value); }
        }

        public static readonly DependencyProperty PropertyProperty =
            DependencyProperty.Register("Property", typeof(LineUnbindableCanReadProperty), typeof(LineSetStateToSourceAction), new PropertyMetadata());

		/// <summary>
		/// Propertyプロパティで指定されたプロパティから値が設定されるソースを取得または設定します。
		/// </summary>
		[Bindable(BindableSupport.Default,BindingDirection.TwoWay)]
		public object Source
        {
            get { return (object)GetValue(SourceProperty); }
            set { SetValue(SourceProperty, value); }
        }

        public static readonly DependencyProperty SourceProperty =
            DependencyProperty.Register("Source", typeof(object), typeof(LineSetStateToSourceAction), new FrameworkPropertyMetadata(null,FrameworkPropertyMetadataOptions.BindsTwoWayByDefault));

        protected override void Invoke(object parameter)
        {
            switch (Property)
            {
                case LineUnbindableCanReadProperty.ActualWidth:
					if((System.Double)Source != AssociatedObject.ActualWidth)
					{
						Source = AssociatedObject.ActualWidth;
					}
                    break;
                case LineUnbindableCanReadProperty.ActualHeight:
					if((System.Double)Source != AssociatedObject.ActualHeight)
					{
						Source = AssociatedObject.ActualHeight;
					}
                    break;
                case LineUnbindableCanReadProperty.IsInitialized:
					if((System.Boolean)Source != AssociatedObject.IsInitialized)
					{
						Source = AssociatedObject.IsInitialized;
					}
                    break;
                case LineUnbindableCanReadProperty.IsLoaded:
					if((System.Boolean)Source != AssociatedObject.IsLoaded)
					{
						Source = AssociatedObject.IsLoaded;
					}
                    break;
                case LineUnbindableCanReadProperty.HasAnimatedProperties:
					if((System.Boolean)Source != AssociatedObject.HasAnimatedProperties)
					{
						Source = AssociatedObject.HasAnimatedProperties;
					}
                    break;
                case LineUnbindableCanReadProperty.IsMeasureValid:
					if((System.Boolean)Source != AssociatedObject.IsMeasureValid)
					{
						Source = AssociatedObject.IsMeasureValid;
					}
                    break;
                case LineUnbindableCanReadProperty.IsArrangeValid:
					if((System.Boolean)Source != AssociatedObject.IsArrangeValid)
					{
						Source = AssociatedObject.IsArrangeValid;
					}
                    break;
                case LineUnbindableCanReadProperty.IsMouseDirectlyOver:
					if((System.Boolean)Source != AssociatedObject.IsMouseDirectlyOver)
					{
						Source = AssociatedObject.IsMouseDirectlyOver;
					}
                    break;
                case LineUnbindableCanReadProperty.IsMouseOver:
					if((System.Boolean)Source != AssociatedObject.IsMouseOver)
					{
						Source = AssociatedObject.IsMouseOver;
					}
                    break;
                case LineUnbindableCanReadProperty.IsStylusOver:
					if((System.Boolean)Source != AssociatedObject.IsStylusOver)
					{
						Source = AssociatedObject.IsStylusOver;
					}
                    break;
                case LineUnbindableCanReadProperty.IsKeyboardFocusWithin:
					if((System.Boolean)Source != AssociatedObject.IsKeyboardFocusWithin)
					{
						Source = AssociatedObject.IsKeyboardFocusWithin;
					}
                    break;
                case LineUnbindableCanReadProperty.IsMouseCaptured:
					if((System.Boolean)Source != AssociatedObject.IsMouseCaptured)
					{
						Source = AssociatedObject.IsMouseCaptured;
					}
                    break;
                case LineUnbindableCanReadProperty.IsMouseCaptureWithin:
					if((System.Boolean)Source != AssociatedObject.IsMouseCaptureWithin)
					{
						Source = AssociatedObject.IsMouseCaptureWithin;
					}
                    break;
                case LineUnbindableCanReadProperty.IsStylusDirectlyOver:
					if((System.Boolean)Source != AssociatedObject.IsStylusDirectlyOver)
					{
						Source = AssociatedObject.IsStylusDirectlyOver;
					}
                    break;
                case LineUnbindableCanReadProperty.IsStylusCaptured:
					if((System.Boolean)Source != AssociatedObject.IsStylusCaptured)
					{
						Source = AssociatedObject.IsStylusCaptured;
					}
                    break;
                case LineUnbindableCanReadProperty.IsStylusCaptureWithin:
					if((System.Boolean)Source != AssociatedObject.IsStylusCaptureWithin)
					{
						Source = AssociatedObject.IsStylusCaptureWithin;
					}
                    break;
                case LineUnbindableCanReadProperty.IsKeyboardFocused:
					if((System.Boolean)Source != AssociatedObject.IsKeyboardFocused)
					{
						Source = AssociatedObject.IsKeyboardFocused;
					}
                    break;
                case LineUnbindableCanReadProperty.IsInputMethodEnabled:
					if((System.Boolean)Source != AssociatedObject.IsInputMethodEnabled)
					{
						Source = AssociatedObject.IsInputMethodEnabled;
					}
                    break;
                case LineUnbindableCanReadProperty.IsFocused:
					if((System.Boolean)Source != AssociatedObject.IsFocused)
					{
						Source = AssociatedObject.IsFocused;
					}
                    break;
                case LineUnbindableCanReadProperty.IsVisible:
					if((System.Boolean)Source != AssociatedObject.IsVisible)
					{
						Source = AssociatedObject.IsVisible;
					}
                    break;
                case LineUnbindableCanReadProperty.AreAnyTouchesOver:
					if((System.Boolean)Source != AssociatedObject.AreAnyTouchesOver)
					{
						Source = AssociatedObject.AreAnyTouchesOver;
					}
                    break;
                case LineUnbindableCanReadProperty.AreAnyTouchesDirectlyOver:
					if((System.Boolean)Source != AssociatedObject.AreAnyTouchesDirectlyOver)
					{
						Source = AssociatedObject.AreAnyTouchesDirectlyOver;
					}
                    break;
                case LineUnbindableCanReadProperty.AreAnyTouchesCapturedWithin:
					if((System.Boolean)Source != AssociatedObject.AreAnyTouchesCapturedWithin)
					{
						Source = AssociatedObject.AreAnyTouchesCapturedWithin;
					}
                    break;
                case LineUnbindableCanReadProperty.AreAnyTouchesCaptured:
					if((System.Boolean)Source != AssociatedObject.AreAnyTouchesCaptured)
					{
						Source = AssociatedObject.AreAnyTouchesCaptured;
					}
                    break;
                case LineUnbindableCanReadProperty.IsSealed:
					if((System.Boolean)Source != AssociatedObject.IsSealed)
					{
						Source = AssociatedObject.IsSealed;
					}
                    break;
            }
        }
	}
}
