
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
	/// ToolBarPanelクラスの、標準ではバインドできないプロパティを表します。
	/// </summary>
	public enum ToolBarPanelUnbindableCanReadProperty
	{
		CanHorizontallyScroll,
		CanVerticallyScroll,
		ExtentWidth,
		ExtentHeight,
		ViewportWidth,
		ViewportHeight,
		HorizontalOffset,
		VerticalOffset,
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
	/// ToolBarPanelクラスのバインドできないプロパティから、値を指定されたソースに反映するためのアクションです。
	/// </summary>
	public class ToolBarPanelSetStateToSourceAction : TriggerAction<ToolBarPanel>
	{
		public ToolBarPanelSetStateToSourceAction()
		{
		}

		/// <summary>
		/// 値を設定したいプロパティを取得または設定します。
		/// </summary>
		public ToolBarPanelUnbindableCanReadProperty Property
        {
            get { return (ToolBarPanelUnbindableCanReadProperty)GetValue(PropertyProperty); }
            set { SetValue(PropertyProperty, value); }
        }

        public static readonly DependencyProperty PropertyProperty =
            DependencyProperty.Register("Property", typeof(ToolBarPanelUnbindableCanReadProperty), typeof(ToolBarPanelSetStateToSourceAction), new PropertyMetadata());

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
            DependencyProperty.Register("Source", typeof(object), typeof(ToolBarPanelSetStateToSourceAction), new FrameworkPropertyMetadata(null,FrameworkPropertyMetadataOptions.BindsTwoWayByDefault));

        protected override void Invoke(object parameter)
        {
            switch (Property)
            {
                case ToolBarPanelUnbindableCanReadProperty.CanHorizontallyScroll:
					if((System.Boolean)Source != AssociatedObject.CanHorizontallyScroll)
					{
						Source = AssociatedObject.CanHorizontallyScroll;
					}
                    break;
                case ToolBarPanelUnbindableCanReadProperty.CanVerticallyScroll:
					if((System.Boolean)Source != AssociatedObject.CanVerticallyScroll)
					{
						Source = AssociatedObject.CanVerticallyScroll;
					}
                    break;
                case ToolBarPanelUnbindableCanReadProperty.ExtentWidth:
					if((System.Double)Source != AssociatedObject.ExtentWidth)
					{
						Source = AssociatedObject.ExtentWidth;
					}
                    break;
                case ToolBarPanelUnbindableCanReadProperty.ExtentHeight:
					if((System.Double)Source != AssociatedObject.ExtentHeight)
					{
						Source = AssociatedObject.ExtentHeight;
					}
                    break;
                case ToolBarPanelUnbindableCanReadProperty.ViewportWidth:
					if((System.Double)Source != AssociatedObject.ViewportWidth)
					{
						Source = AssociatedObject.ViewportWidth;
					}
                    break;
                case ToolBarPanelUnbindableCanReadProperty.ViewportHeight:
					if((System.Double)Source != AssociatedObject.ViewportHeight)
					{
						Source = AssociatedObject.ViewportHeight;
					}
                    break;
                case ToolBarPanelUnbindableCanReadProperty.HorizontalOffset:
					if((System.Double)Source != AssociatedObject.HorizontalOffset)
					{
						Source = AssociatedObject.HorizontalOffset;
					}
                    break;
                case ToolBarPanelUnbindableCanReadProperty.VerticalOffset:
					if((System.Double)Source != AssociatedObject.VerticalOffset)
					{
						Source = AssociatedObject.VerticalOffset;
					}
                    break;
                case ToolBarPanelUnbindableCanReadProperty.ActualWidth:
					if((System.Double)Source != AssociatedObject.ActualWidth)
					{
						Source = AssociatedObject.ActualWidth;
					}
                    break;
                case ToolBarPanelUnbindableCanReadProperty.ActualHeight:
					if((System.Double)Source != AssociatedObject.ActualHeight)
					{
						Source = AssociatedObject.ActualHeight;
					}
                    break;
                case ToolBarPanelUnbindableCanReadProperty.IsInitialized:
					if((System.Boolean)Source != AssociatedObject.IsInitialized)
					{
						Source = AssociatedObject.IsInitialized;
					}
                    break;
                case ToolBarPanelUnbindableCanReadProperty.IsLoaded:
					if((System.Boolean)Source != AssociatedObject.IsLoaded)
					{
						Source = AssociatedObject.IsLoaded;
					}
                    break;
                case ToolBarPanelUnbindableCanReadProperty.HasAnimatedProperties:
					if((System.Boolean)Source != AssociatedObject.HasAnimatedProperties)
					{
						Source = AssociatedObject.HasAnimatedProperties;
					}
                    break;
                case ToolBarPanelUnbindableCanReadProperty.IsMeasureValid:
					if((System.Boolean)Source != AssociatedObject.IsMeasureValid)
					{
						Source = AssociatedObject.IsMeasureValid;
					}
                    break;
                case ToolBarPanelUnbindableCanReadProperty.IsArrangeValid:
					if((System.Boolean)Source != AssociatedObject.IsArrangeValid)
					{
						Source = AssociatedObject.IsArrangeValid;
					}
                    break;
                case ToolBarPanelUnbindableCanReadProperty.IsMouseDirectlyOver:
					if((System.Boolean)Source != AssociatedObject.IsMouseDirectlyOver)
					{
						Source = AssociatedObject.IsMouseDirectlyOver;
					}
                    break;
                case ToolBarPanelUnbindableCanReadProperty.IsMouseOver:
					if((System.Boolean)Source != AssociatedObject.IsMouseOver)
					{
						Source = AssociatedObject.IsMouseOver;
					}
                    break;
                case ToolBarPanelUnbindableCanReadProperty.IsStylusOver:
					if((System.Boolean)Source != AssociatedObject.IsStylusOver)
					{
						Source = AssociatedObject.IsStylusOver;
					}
                    break;
                case ToolBarPanelUnbindableCanReadProperty.IsKeyboardFocusWithin:
					if((System.Boolean)Source != AssociatedObject.IsKeyboardFocusWithin)
					{
						Source = AssociatedObject.IsKeyboardFocusWithin;
					}
                    break;
                case ToolBarPanelUnbindableCanReadProperty.IsMouseCaptured:
					if((System.Boolean)Source != AssociatedObject.IsMouseCaptured)
					{
						Source = AssociatedObject.IsMouseCaptured;
					}
                    break;
                case ToolBarPanelUnbindableCanReadProperty.IsMouseCaptureWithin:
					if((System.Boolean)Source != AssociatedObject.IsMouseCaptureWithin)
					{
						Source = AssociatedObject.IsMouseCaptureWithin;
					}
                    break;
                case ToolBarPanelUnbindableCanReadProperty.IsStylusDirectlyOver:
					if((System.Boolean)Source != AssociatedObject.IsStylusDirectlyOver)
					{
						Source = AssociatedObject.IsStylusDirectlyOver;
					}
                    break;
                case ToolBarPanelUnbindableCanReadProperty.IsStylusCaptured:
					if((System.Boolean)Source != AssociatedObject.IsStylusCaptured)
					{
						Source = AssociatedObject.IsStylusCaptured;
					}
                    break;
                case ToolBarPanelUnbindableCanReadProperty.IsStylusCaptureWithin:
					if((System.Boolean)Source != AssociatedObject.IsStylusCaptureWithin)
					{
						Source = AssociatedObject.IsStylusCaptureWithin;
					}
                    break;
                case ToolBarPanelUnbindableCanReadProperty.IsKeyboardFocused:
					if((System.Boolean)Source != AssociatedObject.IsKeyboardFocused)
					{
						Source = AssociatedObject.IsKeyboardFocused;
					}
                    break;
                case ToolBarPanelUnbindableCanReadProperty.IsInputMethodEnabled:
					if((System.Boolean)Source != AssociatedObject.IsInputMethodEnabled)
					{
						Source = AssociatedObject.IsInputMethodEnabled;
					}
                    break;
                case ToolBarPanelUnbindableCanReadProperty.IsFocused:
					if((System.Boolean)Source != AssociatedObject.IsFocused)
					{
						Source = AssociatedObject.IsFocused;
					}
                    break;
                case ToolBarPanelUnbindableCanReadProperty.IsVisible:
					if((System.Boolean)Source != AssociatedObject.IsVisible)
					{
						Source = AssociatedObject.IsVisible;
					}
                    break;
                case ToolBarPanelUnbindableCanReadProperty.AreAnyTouchesOver:
					if((System.Boolean)Source != AssociatedObject.AreAnyTouchesOver)
					{
						Source = AssociatedObject.AreAnyTouchesOver;
					}
                    break;
                case ToolBarPanelUnbindableCanReadProperty.AreAnyTouchesDirectlyOver:
					if((System.Boolean)Source != AssociatedObject.AreAnyTouchesDirectlyOver)
					{
						Source = AssociatedObject.AreAnyTouchesDirectlyOver;
					}
                    break;
                case ToolBarPanelUnbindableCanReadProperty.AreAnyTouchesCapturedWithin:
					if((System.Boolean)Source != AssociatedObject.AreAnyTouchesCapturedWithin)
					{
						Source = AssociatedObject.AreAnyTouchesCapturedWithin;
					}
                    break;
                case ToolBarPanelUnbindableCanReadProperty.AreAnyTouchesCaptured:
					if((System.Boolean)Source != AssociatedObject.AreAnyTouchesCaptured)
					{
						Source = AssociatedObject.AreAnyTouchesCaptured;
					}
                    break;
                case ToolBarPanelUnbindableCanReadProperty.IsSealed:
					if((System.Boolean)Source != AssociatedObject.IsSealed)
					{
						Source = AssociatedObject.IsSealed;
					}
                    break;
            }
        }
	}
}
