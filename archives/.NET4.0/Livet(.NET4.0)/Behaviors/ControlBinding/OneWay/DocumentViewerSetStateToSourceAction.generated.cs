
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
	/// DocumentViewerクラスの、標準ではバインドできないプロパティを表します。
	/// </summary>
	public enum DocumentViewerUnbindableCanReadProperty
	{
		ExtentWidth,
		ExtentHeight,
		ViewportWidth,
		ViewportHeight,
		CanMoveUp,
		CanMoveDown,
		CanMoveLeft,
		CanMoveRight,
		CanIncreaseZoom,
		CanDecreaseZoom,
		PageCount,
		MasterPageNumber,
		CanGoToPreviousPage,
		CanGoToNextPage,
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
	/// DocumentViewerクラスのバインドできないプロパティから、値を指定されたソースに反映するためのアクションです。
	/// </summary>
	public class DocumentViewerSetStateToSourceAction : TriggerAction<DocumentViewer>
	{
		public DocumentViewerSetStateToSourceAction()
		{
		}

		/// <summary>
		/// 値を設定したいプロパティを取得または設定します。
		/// </summary>
		public DocumentViewerUnbindableCanReadProperty Property
        {
            get { return (DocumentViewerUnbindableCanReadProperty)GetValue(PropertyProperty); }
            set { SetValue(PropertyProperty, value); }
        }

        public static readonly DependencyProperty PropertyProperty =
            DependencyProperty.Register("Property", typeof(DocumentViewerUnbindableCanReadProperty), typeof(DocumentViewerSetStateToSourceAction), new PropertyMetadata());

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
            DependencyProperty.Register("Source", typeof(object), typeof(DocumentViewerSetStateToSourceAction), new FrameworkPropertyMetadata(null,FrameworkPropertyMetadataOptions.BindsTwoWayByDefault));

        protected override void Invoke(object parameter)
        {
            switch (Property)
            {
                case DocumentViewerUnbindableCanReadProperty.ExtentWidth:
					if((System.Double)Source != AssociatedObject.ExtentWidth)
					{
						Source = AssociatedObject.ExtentWidth;
					}
                    break;
                case DocumentViewerUnbindableCanReadProperty.ExtentHeight:
					if((System.Double)Source != AssociatedObject.ExtentHeight)
					{
						Source = AssociatedObject.ExtentHeight;
					}
                    break;
                case DocumentViewerUnbindableCanReadProperty.ViewportWidth:
					if((System.Double)Source != AssociatedObject.ViewportWidth)
					{
						Source = AssociatedObject.ViewportWidth;
					}
                    break;
                case DocumentViewerUnbindableCanReadProperty.ViewportHeight:
					if((System.Double)Source != AssociatedObject.ViewportHeight)
					{
						Source = AssociatedObject.ViewportHeight;
					}
                    break;
                case DocumentViewerUnbindableCanReadProperty.CanMoveUp:
					if((System.Boolean)Source != AssociatedObject.CanMoveUp)
					{
						Source = AssociatedObject.CanMoveUp;
					}
                    break;
                case DocumentViewerUnbindableCanReadProperty.CanMoveDown:
					if((System.Boolean)Source != AssociatedObject.CanMoveDown)
					{
						Source = AssociatedObject.CanMoveDown;
					}
                    break;
                case DocumentViewerUnbindableCanReadProperty.CanMoveLeft:
					if((System.Boolean)Source != AssociatedObject.CanMoveLeft)
					{
						Source = AssociatedObject.CanMoveLeft;
					}
                    break;
                case DocumentViewerUnbindableCanReadProperty.CanMoveRight:
					if((System.Boolean)Source != AssociatedObject.CanMoveRight)
					{
						Source = AssociatedObject.CanMoveRight;
					}
                    break;
                case DocumentViewerUnbindableCanReadProperty.CanIncreaseZoom:
					if((System.Boolean)Source != AssociatedObject.CanIncreaseZoom)
					{
						Source = AssociatedObject.CanIncreaseZoom;
					}
                    break;
                case DocumentViewerUnbindableCanReadProperty.CanDecreaseZoom:
					if((System.Boolean)Source != AssociatedObject.CanDecreaseZoom)
					{
						Source = AssociatedObject.CanDecreaseZoom;
					}
                    break;
                case DocumentViewerUnbindableCanReadProperty.PageCount:
					if((System.Int32)Source != AssociatedObject.PageCount)
					{
						Source = AssociatedObject.PageCount;
					}
                    break;
                case DocumentViewerUnbindableCanReadProperty.MasterPageNumber:
					if((System.Int32)Source != AssociatedObject.MasterPageNumber)
					{
						Source = AssociatedObject.MasterPageNumber;
					}
                    break;
                case DocumentViewerUnbindableCanReadProperty.CanGoToPreviousPage:
					if((System.Boolean)Source != AssociatedObject.CanGoToPreviousPage)
					{
						Source = AssociatedObject.CanGoToPreviousPage;
					}
                    break;
                case DocumentViewerUnbindableCanReadProperty.CanGoToNextPage:
					if((System.Boolean)Source != AssociatedObject.CanGoToNextPage)
					{
						Source = AssociatedObject.CanGoToNextPage;
					}
                    break;
                case DocumentViewerUnbindableCanReadProperty.ActualWidth:
					if((System.Double)Source != AssociatedObject.ActualWidth)
					{
						Source = AssociatedObject.ActualWidth;
					}
                    break;
                case DocumentViewerUnbindableCanReadProperty.ActualHeight:
					if((System.Double)Source != AssociatedObject.ActualHeight)
					{
						Source = AssociatedObject.ActualHeight;
					}
                    break;
                case DocumentViewerUnbindableCanReadProperty.IsInitialized:
					if((System.Boolean)Source != AssociatedObject.IsInitialized)
					{
						Source = AssociatedObject.IsInitialized;
					}
                    break;
                case DocumentViewerUnbindableCanReadProperty.IsLoaded:
					if((System.Boolean)Source != AssociatedObject.IsLoaded)
					{
						Source = AssociatedObject.IsLoaded;
					}
                    break;
                case DocumentViewerUnbindableCanReadProperty.HasAnimatedProperties:
					if((System.Boolean)Source != AssociatedObject.HasAnimatedProperties)
					{
						Source = AssociatedObject.HasAnimatedProperties;
					}
                    break;
                case DocumentViewerUnbindableCanReadProperty.IsMeasureValid:
					if((System.Boolean)Source != AssociatedObject.IsMeasureValid)
					{
						Source = AssociatedObject.IsMeasureValid;
					}
                    break;
                case DocumentViewerUnbindableCanReadProperty.IsArrangeValid:
					if((System.Boolean)Source != AssociatedObject.IsArrangeValid)
					{
						Source = AssociatedObject.IsArrangeValid;
					}
                    break;
                case DocumentViewerUnbindableCanReadProperty.IsMouseDirectlyOver:
					if((System.Boolean)Source != AssociatedObject.IsMouseDirectlyOver)
					{
						Source = AssociatedObject.IsMouseDirectlyOver;
					}
                    break;
                case DocumentViewerUnbindableCanReadProperty.IsMouseOver:
					if((System.Boolean)Source != AssociatedObject.IsMouseOver)
					{
						Source = AssociatedObject.IsMouseOver;
					}
                    break;
                case DocumentViewerUnbindableCanReadProperty.IsStylusOver:
					if((System.Boolean)Source != AssociatedObject.IsStylusOver)
					{
						Source = AssociatedObject.IsStylusOver;
					}
                    break;
                case DocumentViewerUnbindableCanReadProperty.IsKeyboardFocusWithin:
					if((System.Boolean)Source != AssociatedObject.IsKeyboardFocusWithin)
					{
						Source = AssociatedObject.IsKeyboardFocusWithin;
					}
                    break;
                case DocumentViewerUnbindableCanReadProperty.IsMouseCaptured:
					if((System.Boolean)Source != AssociatedObject.IsMouseCaptured)
					{
						Source = AssociatedObject.IsMouseCaptured;
					}
                    break;
                case DocumentViewerUnbindableCanReadProperty.IsMouseCaptureWithin:
					if((System.Boolean)Source != AssociatedObject.IsMouseCaptureWithin)
					{
						Source = AssociatedObject.IsMouseCaptureWithin;
					}
                    break;
                case DocumentViewerUnbindableCanReadProperty.IsStylusDirectlyOver:
					if((System.Boolean)Source != AssociatedObject.IsStylusDirectlyOver)
					{
						Source = AssociatedObject.IsStylusDirectlyOver;
					}
                    break;
                case DocumentViewerUnbindableCanReadProperty.IsStylusCaptured:
					if((System.Boolean)Source != AssociatedObject.IsStylusCaptured)
					{
						Source = AssociatedObject.IsStylusCaptured;
					}
                    break;
                case DocumentViewerUnbindableCanReadProperty.IsStylusCaptureWithin:
					if((System.Boolean)Source != AssociatedObject.IsStylusCaptureWithin)
					{
						Source = AssociatedObject.IsStylusCaptureWithin;
					}
                    break;
                case DocumentViewerUnbindableCanReadProperty.IsKeyboardFocused:
					if((System.Boolean)Source != AssociatedObject.IsKeyboardFocused)
					{
						Source = AssociatedObject.IsKeyboardFocused;
					}
                    break;
                case DocumentViewerUnbindableCanReadProperty.IsInputMethodEnabled:
					if((System.Boolean)Source != AssociatedObject.IsInputMethodEnabled)
					{
						Source = AssociatedObject.IsInputMethodEnabled;
					}
                    break;
                case DocumentViewerUnbindableCanReadProperty.IsFocused:
					if((System.Boolean)Source != AssociatedObject.IsFocused)
					{
						Source = AssociatedObject.IsFocused;
					}
                    break;
                case DocumentViewerUnbindableCanReadProperty.IsVisible:
					if((System.Boolean)Source != AssociatedObject.IsVisible)
					{
						Source = AssociatedObject.IsVisible;
					}
                    break;
                case DocumentViewerUnbindableCanReadProperty.AreAnyTouchesOver:
					if((System.Boolean)Source != AssociatedObject.AreAnyTouchesOver)
					{
						Source = AssociatedObject.AreAnyTouchesOver;
					}
                    break;
                case DocumentViewerUnbindableCanReadProperty.AreAnyTouchesDirectlyOver:
					if((System.Boolean)Source != AssociatedObject.AreAnyTouchesDirectlyOver)
					{
						Source = AssociatedObject.AreAnyTouchesDirectlyOver;
					}
                    break;
                case DocumentViewerUnbindableCanReadProperty.AreAnyTouchesCapturedWithin:
					if((System.Boolean)Source != AssociatedObject.AreAnyTouchesCapturedWithin)
					{
						Source = AssociatedObject.AreAnyTouchesCapturedWithin;
					}
                    break;
                case DocumentViewerUnbindableCanReadProperty.AreAnyTouchesCaptured:
					if((System.Boolean)Source != AssociatedObject.AreAnyTouchesCaptured)
					{
						Source = AssociatedObject.AreAnyTouchesCaptured;
					}
                    break;
                case DocumentViewerUnbindableCanReadProperty.IsSealed:
					if((System.Boolean)Source != AssociatedObject.IsSealed)
					{
						Source = AssociatedObject.IsSealed;
					}
                    break;
            }
        }
	}
}
