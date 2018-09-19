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
using System.Windows.Controls.Primitives;
using System.ComponentModel;
using System.Windows.Interop;
using System.Windows.Data;
using System.Windows.Markup;
using System.Windows.Documents.Serialization;
using System.Windows.Input;
using System.Windows.Media.Animation;
using System.Windows.Media;
using System.Windows.Media.TextFormatting;
using System.Windows.Annotations;
using System.Windows.Ink;
using System.Windows.Automation.Peers;
using System.Windows.Markup.Localizer;
using System.Windows.Media.Imaging;
using System.IO.Packaging;
using System.Security.RightsManagement;
using System.Windows.Threading;
using System.Windows.Media.Effects;
using System.Windows.Shell;
using System.Security.Permissions;
using System.Windows.Annotations.Storage;
using System.Diagnostics;

namespace Livet.Converters
{
	/// <summary>
    /// InkCanvasSelectionHitResult列挙体とbool値の相互変換を行うIValueConverterです。
    /// </summary>
    public class InkCanvasSelectionHitResultAndBooleanConverter : IValueConverter
    {
        //VM→View
        public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            if (!(value is bool)) throw new ArgumentException();

            if ((bool)value)
            {
                if (_isConvertWhenTrueSet)
                {
                    return ConvertWhenTrue;
                }
            }
            else
            {
                if (_isConvertWhenFalseSet)
                {
                    return ConvertWhenFalse;
                }
            }

            return DependencyProperty.UnsetValue;
        }

        private bool _isConvertWhenTrueSet;
        private InkCanvasSelectionHitResult _convertWhenTrue;
		/// <summary>
        /// ソース値がTrueの際にどのInkCanvasSelectionHitResult列挙体メンバーに変換するかを指定、または取得します。
        /// </summary>
        public InkCanvasSelectionHitResult ConvertWhenTrue
        {
            get
            {
                return _convertWhenTrue;
            }
            set
            {
                _convertWhenTrue = value;
                _isConvertWhenTrueSet = true;
            }
        }

        private bool _isConvertWhenFalseSet;
        private InkCanvasSelectionHitResult _convertWhenFalse;
		/// <summary>
        /// ソース値がFalseの際にどのInkCanvasSelectionHitResult列挙体メンバーに変換するかを指定、または取得します。
        /// </summary>
        public InkCanvasSelectionHitResult ConvertWhenFalse
        {
            get
            {
                return _convertWhenFalse;
            }
            set
            {
                _convertWhenFalse = value;
                _isConvertWhenFalseSet = true;
            }
        }

        //View→VM
        public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            if (!(value is InkCanvasSelectionHitResult)) throw new ArgumentException();

            var enumValue = (InkCanvasSelectionHitResult)value;

			switch(enumValue.ToString())
			{
				case "None":
					if (_isConvertBackWhenNoneSet)
					{
						return ConvertBackWhenNone;
					}
					break;
				case "TopLeft":
					if (_isConvertBackWhenTopLeftSet)
					{
						return ConvertBackWhenTopLeft;
					}
					break;
				case "Top":
					if (_isConvertBackWhenTopSet)
					{
						return ConvertBackWhenTop;
					}
					break;
				case "TopRight":
					if (_isConvertBackWhenTopRightSet)
					{
						return ConvertBackWhenTopRight;
					}
					break;
				case "Right":
					if (_isConvertBackWhenRightSet)
					{
						return ConvertBackWhenRight;
					}
					break;
				case "BottomRight":
					if (_isConvertBackWhenBottomRightSet)
					{
						return ConvertBackWhenBottomRight;
					}
					break;
				case "Bottom":
					if (_isConvertBackWhenBottomSet)
					{
						return ConvertBackWhenBottom;
					}
					break;
				case "BottomLeft":
					if (_isConvertBackWhenBottomLeftSet)
					{
						return ConvertBackWhenBottomLeft;
					}
					break;
				case "Left":
					if (_isConvertBackWhenLeftSet)
					{
						return ConvertBackWhenLeft;
					}
					break;
				case "Selection":
					if (_isConvertBackWhenSelectionSet)
					{
						return ConvertBackWhenSelection;
					}
					break;
				default:
					throw new ArgumentException();
			}

            if (_isConvertBackDefaultBooleanValueSet)
            {
                return ConvertBackDefaultBooleanValue;
            }

            return DependencyProperty.UnsetValue;
        }

        private bool _isConvertBackDefaultBooleanValueSet;
        private bool _convertBackDefaultBooleanValue;
		/// <summary>
        /// InkCanvasSelectionHitResultの値をbool値に変換する際のデフォルト値を指定、または取得します。
        /// </summary>
        public bool ConvertBackDefaultBooleanValue
        {
            get
            {
                return _convertBackDefaultBooleanValue;
            }
            set
            {
                _convertBackDefaultBooleanValue = value;
				_isConvertBackDefaultBooleanValueSet = true;
            }
        }

        private bool _isConvertBackWhenNoneSet;
        private bool _convertBackWhenNone;
		/// <summary>
        /// InkCanvasSelectionHitResultの値がNoneの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenNone
        {
            get
            {
                return _convertBackWhenNone;
            }
            set
            {
                _convertBackWhenNone = value;
                _isConvertBackWhenNoneSet = true;
            }
        }
        private bool _isConvertBackWhenTopLeftSet;
        private bool _convertBackWhenTopLeft;
		/// <summary>
        /// InkCanvasSelectionHitResultの値がTopLeftの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenTopLeft
        {
            get
            {
                return _convertBackWhenTopLeft;
            }
            set
            {
                _convertBackWhenTopLeft = value;
                _isConvertBackWhenTopLeftSet = true;
            }
        }
        private bool _isConvertBackWhenTopSet;
        private bool _convertBackWhenTop;
		/// <summary>
        /// InkCanvasSelectionHitResultの値がTopの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenTop
        {
            get
            {
                return _convertBackWhenTop;
            }
            set
            {
                _convertBackWhenTop = value;
                _isConvertBackWhenTopSet = true;
            }
        }
        private bool _isConvertBackWhenTopRightSet;
        private bool _convertBackWhenTopRight;
		/// <summary>
        /// InkCanvasSelectionHitResultの値がTopRightの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenTopRight
        {
            get
            {
                return _convertBackWhenTopRight;
            }
            set
            {
                _convertBackWhenTopRight = value;
                _isConvertBackWhenTopRightSet = true;
            }
        }
        private bool _isConvertBackWhenRightSet;
        private bool _convertBackWhenRight;
		/// <summary>
        /// InkCanvasSelectionHitResultの値がRightの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenRight
        {
            get
            {
                return _convertBackWhenRight;
            }
            set
            {
                _convertBackWhenRight = value;
                _isConvertBackWhenRightSet = true;
            }
        }
        private bool _isConvertBackWhenBottomRightSet;
        private bool _convertBackWhenBottomRight;
		/// <summary>
        /// InkCanvasSelectionHitResultの値がBottomRightの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenBottomRight
        {
            get
            {
                return _convertBackWhenBottomRight;
            }
            set
            {
                _convertBackWhenBottomRight = value;
                _isConvertBackWhenBottomRightSet = true;
            }
        }
        private bool _isConvertBackWhenBottomSet;
        private bool _convertBackWhenBottom;
		/// <summary>
        /// InkCanvasSelectionHitResultの値がBottomの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenBottom
        {
            get
            {
                return _convertBackWhenBottom;
            }
            set
            {
                _convertBackWhenBottom = value;
                _isConvertBackWhenBottomSet = true;
            }
        }
        private bool _isConvertBackWhenBottomLeftSet;
        private bool _convertBackWhenBottomLeft;
		/// <summary>
        /// InkCanvasSelectionHitResultの値がBottomLeftの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenBottomLeft
        {
            get
            {
                return _convertBackWhenBottomLeft;
            }
            set
            {
                _convertBackWhenBottomLeft = value;
                _isConvertBackWhenBottomLeftSet = true;
            }
        }
        private bool _isConvertBackWhenLeftSet;
        private bool _convertBackWhenLeft;
		/// <summary>
        /// InkCanvasSelectionHitResultの値がLeftの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenLeft
        {
            get
            {
                return _convertBackWhenLeft;
            }
            set
            {
                _convertBackWhenLeft = value;
                _isConvertBackWhenLeftSet = true;
            }
        }
        private bool _isConvertBackWhenSelectionSet;
        private bool _convertBackWhenSelection;
		/// <summary>
        /// InkCanvasSelectionHitResultの値がSelectionの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenSelection
        {
            get
            {
                return _convertBackWhenSelection;
            }
            set
            {
                _convertBackWhenSelection = value;
                _isConvertBackWhenSelectionSet = true;
            }
        }
    }
}