
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
	/// CalendarDayButtonクラスの、標準ではバインドできないプロパティを表します。
	/// </summary>
	public enum CalendarDayButtonUnbindableCanReadProperty
	{
		IsToday,
		IsSelected,
		IsInactive,
		IsBlackedOut,
		IsHighlighted,
		IsDefaulted,
		IsPressed,
		HasContent,
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
	/// CalendarDayButtonクラスのバインドできないプロパティから、値を指定されたソースに反映するためのアクションです。
	/// </summary>
	public class CalendarDayButtonSetStateToSourceAction : TriggerAction<CalendarDayButton>
	{
		public CalendarDayButtonSetStateToSourceAction()
		{
		}

		/// <summary>
		/// 値を設定したいプロパティを取得または設定します。
		/// </summary>
		public CalendarDayButtonUnbindableCanReadProperty Property
        {
            get { return (CalendarDayButtonUnbindableCanReadProperty)GetValue(PropertyProperty); }
            set { SetValue(PropertyProperty, value); }
        }

        public static readonly DependencyProperty PropertyProperty =
            DependencyProperty.Register("Property", typeof(CalendarDayButtonUnbindableCanReadProperty), typeof(CalendarDayButtonSetStateToSourceAction), new PropertyMetadata());

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
            DependencyProperty.Register("Source", typeof(object), typeof(CalendarDayButtonSetStateToSourceAction), new FrameworkPropertyMetadata(null,FrameworkPropertyMetadataOptions.BindsTwoWayByDefault));

        protected override void Invoke(object parameter)
        {
            switch (Property)
            {
                case CalendarDayButtonUnbindableCanReadProperty.IsToday:
					if((System.Boolean)Source != AssociatedObject.IsToday)
					{
						Source = AssociatedObject.IsToday;
					}
                    break;
                case CalendarDayButtonUnbindableCanReadProperty.IsSelected:
					if((System.Boolean)Source != AssociatedObject.IsSelected)
					{
						Source = AssociatedObject.IsSelected;
					}
                    break;
                case CalendarDayButtonUnbindableCanReadProperty.IsInactive:
					if((System.Boolean)Source != AssociatedObject.IsInactive)
					{
						Source = AssociatedObject.IsInactive;
					}
                    break;
                case CalendarDayButtonUnbindableCanReadProperty.IsBlackedOut:
					if((System.Boolean)Source != AssociatedObject.IsBlackedOut)
					{
						Source = AssociatedObject.IsBlackedOut;
					}
                    break;
                case CalendarDayButtonUnbindableCanReadProperty.IsHighlighted:
					if((System.Boolean)Source != AssociatedObject.IsHighlighted)
					{
						Source = AssociatedObject.IsHighlighted;
					}
                    break;
                case CalendarDayButtonUnbindableCanReadProperty.IsDefaulted:
					if((System.Boolean)Source != AssociatedObject.IsDefaulted)
					{
						Source = AssociatedObject.IsDefaulted;
					}
                    break;
                case CalendarDayButtonUnbindableCanReadProperty.IsPressed:
					if((System.Boolean)Source != AssociatedObject.IsPressed)
					{
						Source = AssociatedObject.IsPressed;
					}
                    break;
                case CalendarDayButtonUnbindableCanReadProperty.HasContent:
					if((System.Boolean)Source != AssociatedObject.HasContent)
					{
						Source = AssociatedObject.HasContent;
					}
                    break;
                case CalendarDayButtonUnbindableCanReadProperty.ActualWidth:
					if((System.Double)Source != AssociatedObject.ActualWidth)
					{
						Source = AssociatedObject.ActualWidth;
					}
                    break;
                case CalendarDayButtonUnbindableCanReadProperty.ActualHeight:
					if((System.Double)Source != AssociatedObject.ActualHeight)
					{
						Source = AssociatedObject.ActualHeight;
					}
                    break;
                case CalendarDayButtonUnbindableCanReadProperty.IsInitialized:
					if((System.Boolean)Source != AssociatedObject.IsInitialized)
					{
						Source = AssociatedObject.IsInitialized;
					}
                    break;
                case CalendarDayButtonUnbindableCanReadProperty.IsLoaded:
					if((System.Boolean)Source != AssociatedObject.IsLoaded)
					{
						Source = AssociatedObject.IsLoaded;
					}
                    break;
                case CalendarDayButtonUnbindableCanReadProperty.HasAnimatedProperties:
					if((System.Boolean)Source != AssociatedObject.HasAnimatedProperties)
					{
						Source = AssociatedObject.HasAnimatedProperties;
					}
                    break;
                case CalendarDayButtonUnbindableCanReadProperty.IsMeasureValid:
					if((System.Boolean)Source != AssociatedObject.IsMeasureValid)
					{
						Source = AssociatedObject.IsMeasureValid;
					}
                    break;
                case CalendarDayButtonUnbindableCanReadProperty.IsArrangeValid:
					if((System.Boolean)Source != AssociatedObject.IsArrangeValid)
					{
						Source = AssociatedObject.IsArrangeValid;
					}
                    break;
                case CalendarDayButtonUnbindableCanReadProperty.IsMouseDirectlyOver:
					if((System.Boolean)Source != AssociatedObject.IsMouseDirectlyOver)
					{
						Source = AssociatedObject.IsMouseDirectlyOver;
					}
                    break;
                case CalendarDayButtonUnbindableCanReadProperty.IsMouseOver:
					if((System.Boolean)Source != AssociatedObject.IsMouseOver)
					{
						Source = AssociatedObject.IsMouseOver;
					}
                    break;
                case CalendarDayButtonUnbindableCanReadProperty.IsStylusOver:
					if((System.Boolean)Source != AssociatedObject.IsStylusOver)
					{
						Source = AssociatedObject.IsStylusOver;
					}
                    break;
                case CalendarDayButtonUnbindableCanReadProperty.IsKeyboardFocusWithin:
					if((System.Boolean)Source != AssociatedObject.IsKeyboardFocusWithin)
					{
						Source = AssociatedObject.IsKeyboardFocusWithin;
					}
                    break;
                case CalendarDayButtonUnbindableCanReadProperty.IsMouseCaptured:
					if((System.Boolean)Source != AssociatedObject.IsMouseCaptured)
					{
						Source = AssociatedObject.IsMouseCaptured;
					}
                    break;
                case CalendarDayButtonUnbindableCanReadProperty.IsMouseCaptureWithin:
					if((System.Boolean)Source != AssociatedObject.IsMouseCaptureWithin)
					{
						Source = AssociatedObject.IsMouseCaptureWithin;
					}
                    break;
                case CalendarDayButtonUnbindableCanReadProperty.IsStylusDirectlyOver:
					if((System.Boolean)Source != AssociatedObject.IsStylusDirectlyOver)
					{
						Source = AssociatedObject.IsStylusDirectlyOver;
					}
                    break;
                case CalendarDayButtonUnbindableCanReadProperty.IsStylusCaptured:
					if((System.Boolean)Source != AssociatedObject.IsStylusCaptured)
					{
						Source = AssociatedObject.IsStylusCaptured;
					}
                    break;
                case CalendarDayButtonUnbindableCanReadProperty.IsStylusCaptureWithin:
					if((System.Boolean)Source != AssociatedObject.IsStylusCaptureWithin)
					{
						Source = AssociatedObject.IsStylusCaptureWithin;
					}
                    break;
                case CalendarDayButtonUnbindableCanReadProperty.IsKeyboardFocused:
					if((System.Boolean)Source != AssociatedObject.IsKeyboardFocused)
					{
						Source = AssociatedObject.IsKeyboardFocused;
					}
                    break;
                case CalendarDayButtonUnbindableCanReadProperty.IsInputMethodEnabled:
					if((System.Boolean)Source != AssociatedObject.IsInputMethodEnabled)
					{
						Source = AssociatedObject.IsInputMethodEnabled;
					}
                    break;
                case CalendarDayButtonUnbindableCanReadProperty.IsFocused:
					if((System.Boolean)Source != AssociatedObject.IsFocused)
					{
						Source = AssociatedObject.IsFocused;
					}
                    break;
                case CalendarDayButtonUnbindableCanReadProperty.IsVisible:
					if((System.Boolean)Source != AssociatedObject.IsVisible)
					{
						Source = AssociatedObject.IsVisible;
					}
                    break;
                case CalendarDayButtonUnbindableCanReadProperty.AreAnyTouchesOver:
					if((System.Boolean)Source != AssociatedObject.AreAnyTouchesOver)
					{
						Source = AssociatedObject.AreAnyTouchesOver;
					}
                    break;
                case CalendarDayButtonUnbindableCanReadProperty.AreAnyTouchesDirectlyOver:
					if((System.Boolean)Source != AssociatedObject.AreAnyTouchesDirectlyOver)
					{
						Source = AssociatedObject.AreAnyTouchesDirectlyOver;
					}
                    break;
                case CalendarDayButtonUnbindableCanReadProperty.AreAnyTouchesCapturedWithin:
					if((System.Boolean)Source != AssociatedObject.AreAnyTouchesCapturedWithin)
					{
						Source = AssociatedObject.AreAnyTouchesCapturedWithin;
					}
                    break;
                case CalendarDayButtonUnbindableCanReadProperty.AreAnyTouchesCaptured:
					if((System.Boolean)Source != AssociatedObject.AreAnyTouchesCaptured)
					{
						Source = AssociatedObject.AreAnyTouchesCaptured;
					}
                    break;
                case CalendarDayButtonUnbindableCanReadProperty.IsSealed:
					if((System.Boolean)Source != AssociatedObject.IsSealed)
					{
						Source = AssociatedObject.IsSealed;
					}
                    break;
            }
        }
	}
}
