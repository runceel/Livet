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
    /// PlacementMode列挙体とbool値の相互変換を行うIValueConverterです。
    /// </summary>
    public class PlacementModeAndBooleanConverter : IValueConverter
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
        private PlacementMode _convertWhenTrue;
		/// <summary>
        /// ソース値がTrueの際にどのPlacementMode列挙体メンバーに変換するかを指定、または取得します。
        /// </summary>
        public PlacementMode ConvertWhenTrue
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
        private PlacementMode _convertWhenFalse;
		/// <summary>
        /// ソース値がFalseの際にどのPlacementMode列挙体メンバーに変換するかを指定、または取得します。
        /// </summary>
        public PlacementMode ConvertWhenFalse
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
            if (!(value is PlacementMode)) throw new ArgumentException();

            var enumValue = (PlacementMode)value;

			switch(enumValue.ToString())
			{
				case "Absolute":
					if (_isConvertBackWhenAbsoluteSet)
					{
						return ConvertBackWhenAbsolute;
					}
					break;
				case "Relative":
					if (_isConvertBackWhenRelativeSet)
					{
						return ConvertBackWhenRelative;
					}
					break;
				case "Bottom":
					if (_isConvertBackWhenBottomSet)
					{
						return ConvertBackWhenBottom;
					}
					break;
				case "Center":
					if (_isConvertBackWhenCenterSet)
					{
						return ConvertBackWhenCenter;
					}
					break;
				case "Right":
					if (_isConvertBackWhenRightSet)
					{
						return ConvertBackWhenRight;
					}
					break;
				case "AbsolutePoint":
					if (_isConvertBackWhenAbsolutePointSet)
					{
						return ConvertBackWhenAbsolutePoint;
					}
					break;
				case "RelativePoint":
					if (_isConvertBackWhenRelativePointSet)
					{
						return ConvertBackWhenRelativePoint;
					}
					break;
				case "Mouse":
					if (_isConvertBackWhenMouseSet)
					{
						return ConvertBackWhenMouse;
					}
					break;
				case "MousePoint":
					if (_isConvertBackWhenMousePointSet)
					{
						return ConvertBackWhenMousePoint;
					}
					break;
				case "Left":
					if (_isConvertBackWhenLeftSet)
					{
						return ConvertBackWhenLeft;
					}
					break;
				case "Top":
					if (_isConvertBackWhenTopSet)
					{
						return ConvertBackWhenTop;
					}
					break;
				case "Custom":
					if (_isConvertBackWhenCustomSet)
					{
						return ConvertBackWhenCustom;
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
        /// PlacementModeの値をbool値に変換する際のデフォルト値を指定、または取得します。
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

        private bool _isConvertBackWhenAbsoluteSet;
        private bool _convertBackWhenAbsolute;
		/// <summary>
        /// PlacementModeの値がAbsoluteの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenAbsolute
        {
            get
            {
                return _convertBackWhenAbsolute;
            }
            set
            {
                _convertBackWhenAbsolute = value;
                _isConvertBackWhenAbsoluteSet = true;
            }
        }
        private bool _isConvertBackWhenRelativeSet;
        private bool _convertBackWhenRelative;
		/// <summary>
        /// PlacementModeの値がRelativeの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenRelative
        {
            get
            {
                return _convertBackWhenRelative;
            }
            set
            {
                _convertBackWhenRelative = value;
                _isConvertBackWhenRelativeSet = true;
            }
        }
        private bool _isConvertBackWhenBottomSet;
        private bool _convertBackWhenBottom;
		/// <summary>
        /// PlacementModeの値がBottomの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
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
        private bool _isConvertBackWhenCenterSet;
        private bool _convertBackWhenCenter;
		/// <summary>
        /// PlacementModeの値がCenterの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenCenter
        {
            get
            {
                return _convertBackWhenCenter;
            }
            set
            {
                _convertBackWhenCenter = value;
                _isConvertBackWhenCenterSet = true;
            }
        }
        private bool _isConvertBackWhenRightSet;
        private bool _convertBackWhenRight;
		/// <summary>
        /// PlacementModeの値がRightの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
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
        private bool _isConvertBackWhenAbsolutePointSet;
        private bool _convertBackWhenAbsolutePoint;
		/// <summary>
        /// PlacementModeの値がAbsolutePointの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenAbsolutePoint
        {
            get
            {
                return _convertBackWhenAbsolutePoint;
            }
            set
            {
                _convertBackWhenAbsolutePoint = value;
                _isConvertBackWhenAbsolutePointSet = true;
            }
        }
        private bool _isConvertBackWhenRelativePointSet;
        private bool _convertBackWhenRelativePoint;
		/// <summary>
        /// PlacementModeの値がRelativePointの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenRelativePoint
        {
            get
            {
                return _convertBackWhenRelativePoint;
            }
            set
            {
                _convertBackWhenRelativePoint = value;
                _isConvertBackWhenRelativePointSet = true;
            }
        }
        private bool _isConvertBackWhenMouseSet;
        private bool _convertBackWhenMouse;
		/// <summary>
        /// PlacementModeの値がMouseの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenMouse
        {
            get
            {
                return _convertBackWhenMouse;
            }
            set
            {
                _convertBackWhenMouse = value;
                _isConvertBackWhenMouseSet = true;
            }
        }
        private bool _isConvertBackWhenMousePointSet;
        private bool _convertBackWhenMousePoint;
		/// <summary>
        /// PlacementModeの値がMousePointの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenMousePoint
        {
            get
            {
                return _convertBackWhenMousePoint;
            }
            set
            {
                _convertBackWhenMousePoint = value;
                _isConvertBackWhenMousePointSet = true;
            }
        }
        private bool _isConvertBackWhenLeftSet;
        private bool _convertBackWhenLeft;
		/// <summary>
        /// PlacementModeの値がLeftの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
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
        private bool _isConvertBackWhenTopSet;
        private bool _convertBackWhenTop;
		/// <summary>
        /// PlacementModeの値がTopの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
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
        private bool _isConvertBackWhenCustomSet;
        private bool _convertBackWhenCustom;
		/// <summary>
        /// PlacementModeの値がCustomの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenCustom
        {
            get
            {
                return _convertBackWhenCustom;
            }
            set
            {
                _convertBackWhenCustom = value;
                _isConvertBackWhenCustomSet = true;
            }
        }
    }
}