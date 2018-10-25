
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
	/// DataGridRowクラスの、標準ではバインドできないプロパティを表します。
	/// </summary>
	public enum DataGridRowUnbindableCanReadProperty
	{
		AlternationIndex,
		IsEditing,
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
	/// DataGridRowクラスのバインドできないプロパティから、値を指定されたソースに反映するためのアクションです。
	/// </summary>
	public class DataGridRowSetStateToSourceAction : TriggerAction<DataGridRow>
	{
		public DataGridRowSetStateToSourceAction()
		{
		}

		/// <summary>
		/// 値を設定したいプロパティを取得または設定します。
		/// </summary>
		public DataGridRowUnbindableCanReadProperty Property
        {
            get { return (DataGridRowUnbindableCanReadProperty)GetValue(PropertyProperty); }
            set { SetValue(PropertyProperty, value); }
        }

        public static readonly DependencyProperty PropertyProperty =
            DependencyProperty.Register("Property", typeof(DataGridRowUnbindableCanReadProperty), typeof(DataGridRowSetStateToSourceAction), new PropertyMetadata());

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
            DependencyProperty.Register("Source", typeof(object), typeof(DataGridRowSetStateToSourceAction), new FrameworkPropertyMetadata(null,FrameworkPropertyMetadataOptions.BindsTwoWayByDefault));

        protected override void Invoke(object parameter)
        {
            switch (Property)
            {
                case DataGridRowUnbindableCanReadProperty.AlternationIndex:
					if((System.Int32)Source != AssociatedObject.AlternationIndex)
					{
						Source = AssociatedObject.AlternationIndex;
					}
                    break;
                case DataGridRowUnbindableCanReadProperty.IsEditing:
					if((System.Boolean)Source != AssociatedObject.IsEditing)
					{
						Source = AssociatedObject.IsEditing;
					}
                    break;
                case DataGridRowUnbindableCanReadProperty.ActualWidth:
					if((System.Double)Source != AssociatedObject.ActualWidth)
					{
						Source = AssociatedObject.ActualWidth;
					}
                    break;
                case DataGridRowUnbindableCanReadProperty.ActualHeight:
					if((System.Double)Source != AssociatedObject.ActualHeight)
					{
						Source = AssociatedObject.ActualHeight;
					}
                    break;
                case DataGridRowUnbindableCanReadProperty.IsInitialized:
					if((System.Boolean)Source != AssociatedObject.IsInitialized)
					{
						Source = AssociatedObject.IsInitialized;
					}
                    break;
                case DataGridRowUnbindableCanReadProperty.IsLoaded:
					if((System.Boolean)Source != AssociatedObject.IsLoaded)
					{
						Source = AssociatedObject.IsLoaded;
					}
                    break;
                case DataGridRowUnbindableCanReadProperty.HasAnimatedProperties:
					if((System.Boolean)Source != AssociatedObject.HasAnimatedProperties)
					{
						Source = AssociatedObject.HasAnimatedProperties;
					}
                    break;
                case DataGridRowUnbindableCanReadProperty.IsMeasureValid:
					if((System.Boolean)Source != AssociatedObject.IsMeasureValid)
					{
						Source = AssociatedObject.IsMeasureValid;
					}
                    break;
                case DataGridRowUnbindableCanReadProperty.IsArrangeValid:
					if((System.Boolean)Source != AssociatedObject.IsArrangeValid)
					{
						Source = AssociatedObject.IsArrangeValid;
					}
                    break;
                case DataGridRowUnbindableCanReadProperty.IsMouseDirectlyOver:
					if((System.Boolean)Source != AssociatedObject.IsMouseDirectlyOver)
					{
						Source = AssociatedObject.IsMouseDirectlyOver;
					}
                    break;
                case DataGridRowUnbindableCanReadProperty.IsMouseOver:
					if((System.Boolean)Source != AssociatedObject.IsMouseOver)
					{
						Source = AssociatedObject.IsMouseOver;
					}
                    break;
                case DataGridRowUnbindableCanReadProperty.IsStylusOver:
					if((System.Boolean)Source != AssociatedObject.IsStylusOver)
					{
						Source = AssociatedObject.IsStylusOver;
					}
                    break;
                case DataGridRowUnbindableCanReadProperty.IsKeyboardFocusWithin:
					if((System.Boolean)Source != AssociatedObject.IsKeyboardFocusWithin)
					{
						Source = AssociatedObject.IsKeyboardFocusWithin;
					}
                    break;
                case DataGridRowUnbindableCanReadProperty.IsMouseCaptured:
					if((System.Boolean)Source != AssociatedObject.IsMouseCaptured)
					{
						Source = AssociatedObject.IsMouseCaptured;
					}
                    break;
                case DataGridRowUnbindableCanReadProperty.IsMouseCaptureWithin:
					if((System.Boolean)Source != AssociatedObject.IsMouseCaptureWithin)
					{
						Source = AssociatedObject.IsMouseCaptureWithin;
					}
                    break;
                case DataGridRowUnbindableCanReadProperty.IsStylusDirectlyOver:
					if((System.Boolean)Source != AssociatedObject.IsStylusDirectlyOver)
					{
						Source = AssociatedObject.IsStylusDirectlyOver;
					}
                    break;
                case DataGridRowUnbindableCanReadProperty.IsStylusCaptured:
					if((System.Boolean)Source != AssociatedObject.IsStylusCaptured)
					{
						Source = AssociatedObject.IsStylusCaptured;
					}
                    break;
                case DataGridRowUnbindableCanReadProperty.IsStylusCaptureWithin:
					if((System.Boolean)Source != AssociatedObject.IsStylusCaptureWithin)
					{
						Source = AssociatedObject.IsStylusCaptureWithin;
					}
                    break;
                case DataGridRowUnbindableCanReadProperty.IsKeyboardFocused:
					if((System.Boolean)Source != AssociatedObject.IsKeyboardFocused)
					{
						Source = AssociatedObject.IsKeyboardFocused;
					}
                    break;
                case DataGridRowUnbindableCanReadProperty.IsInputMethodEnabled:
					if((System.Boolean)Source != AssociatedObject.IsInputMethodEnabled)
					{
						Source = AssociatedObject.IsInputMethodEnabled;
					}
                    break;
                case DataGridRowUnbindableCanReadProperty.IsFocused:
					if((System.Boolean)Source != AssociatedObject.IsFocused)
					{
						Source = AssociatedObject.IsFocused;
					}
                    break;
                case DataGridRowUnbindableCanReadProperty.IsVisible:
					if((System.Boolean)Source != AssociatedObject.IsVisible)
					{
						Source = AssociatedObject.IsVisible;
					}
                    break;
                case DataGridRowUnbindableCanReadProperty.AreAnyTouchesOver:
					if((System.Boolean)Source != AssociatedObject.AreAnyTouchesOver)
					{
						Source = AssociatedObject.AreAnyTouchesOver;
					}
                    break;
                case DataGridRowUnbindableCanReadProperty.AreAnyTouchesDirectlyOver:
					if((System.Boolean)Source != AssociatedObject.AreAnyTouchesDirectlyOver)
					{
						Source = AssociatedObject.AreAnyTouchesDirectlyOver;
					}
                    break;
                case DataGridRowUnbindableCanReadProperty.AreAnyTouchesCapturedWithin:
					if((System.Boolean)Source != AssociatedObject.AreAnyTouchesCapturedWithin)
					{
						Source = AssociatedObject.AreAnyTouchesCapturedWithin;
					}
                    break;
                case DataGridRowUnbindableCanReadProperty.AreAnyTouchesCaptured:
					if((System.Boolean)Source != AssociatedObject.AreAnyTouchesCaptured)
					{
						Source = AssociatedObject.AreAnyTouchesCaptured;
					}
                    break;
                case DataGridRowUnbindableCanReadProperty.IsSealed:
					if((System.Boolean)Source != AssociatedObject.IsSealed)
					{
						Source = AssociatedObject.IsSealed;
					}
                    break;
            }
        }
	}
}
