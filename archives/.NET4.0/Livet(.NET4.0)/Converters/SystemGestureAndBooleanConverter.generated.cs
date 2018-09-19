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
    /// SystemGesture列挙体とbool値の相互変換を行うIValueConverterです。
    /// </summary>
    public class SystemGestureAndBooleanConverter : IValueConverter
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
        private SystemGesture _convertWhenTrue;
		/// <summary>
        /// ソース値がTrueの際にどのSystemGesture列挙体メンバーに変換するかを指定、または取得します。
        /// </summary>
        public SystemGesture ConvertWhenTrue
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
        private SystemGesture _convertWhenFalse;
		/// <summary>
        /// ソース値がFalseの際にどのSystemGesture列挙体メンバーに変換するかを指定、または取得します。
        /// </summary>
        public SystemGesture ConvertWhenFalse
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
            if (!(value is SystemGesture)) throw new ArgumentException();

            var enumValue = (SystemGesture)value;

			switch(enumValue.ToString())
			{
				case "None":
					if (_isConvertBackWhenNoneSet)
					{
						return ConvertBackWhenNone;
					}
					break;
				case "Tap":
					if (_isConvertBackWhenTapSet)
					{
						return ConvertBackWhenTap;
					}
					break;
				case "RightTap":
					if (_isConvertBackWhenRightTapSet)
					{
						return ConvertBackWhenRightTap;
					}
					break;
				case "Drag":
					if (_isConvertBackWhenDragSet)
					{
						return ConvertBackWhenDrag;
					}
					break;
				case "RightDrag":
					if (_isConvertBackWhenRightDragSet)
					{
						return ConvertBackWhenRightDrag;
					}
					break;
				case "HoldEnter":
					if (_isConvertBackWhenHoldEnterSet)
					{
						return ConvertBackWhenHoldEnter;
					}
					break;
				case "HoldLeave":
					if (_isConvertBackWhenHoldLeaveSet)
					{
						return ConvertBackWhenHoldLeave;
					}
					break;
				case "HoverEnter":
					if (_isConvertBackWhenHoverEnterSet)
					{
						return ConvertBackWhenHoverEnter;
					}
					break;
				case "HoverLeave":
					if (_isConvertBackWhenHoverLeaveSet)
					{
						return ConvertBackWhenHoverLeave;
					}
					break;
				case "Flick":
					if (_isConvertBackWhenFlickSet)
					{
						return ConvertBackWhenFlick;
					}
					break;
				case "TwoFingerTap":
					if (_isConvertBackWhenTwoFingerTapSet)
					{
						return ConvertBackWhenTwoFingerTap;
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
        /// SystemGestureの値をbool値に変換する際のデフォルト値を指定、または取得します。
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
        /// SystemGestureの値がNoneの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
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
        private bool _isConvertBackWhenTapSet;
        private bool _convertBackWhenTap;
		/// <summary>
        /// SystemGestureの値がTapの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenTap
        {
            get
            {
                return _convertBackWhenTap;
            }
            set
            {
                _convertBackWhenTap = value;
                _isConvertBackWhenTapSet = true;
            }
        }
        private bool _isConvertBackWhenRightTapSet;
        private bool _convertBackWhenRightTap;
		/// <summary>
        /// SystemGestureの値がRightTapの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenRightTap
        {
            get
            {
                return _convertBackWhenRightTap;
            }
            set
            {
                _convertBackWhenRightTap = value;
                _isConvertBackWhenRightTapSet = true;
            }
        }
        private bool _isConvertBackWhenDragSet;
        private bool _convertBackWhenDrag;
		/// <summary>
        /// SystemGestureの値がDragの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenDrag
        {
            get
            {
                return _convertBackWhenDrag;
            }
            set
            {
                _convertBackWhenDrag = value;
                _isConvertBackWhenDragSet = true;
            }
        }
        private bool _isConvertBackWhenRightDragSet;
        private bool _convertBackWhenRightDrag;
		/// <summary>
        /// SystemGestureの値がRightDragの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenRightDrag
        {
            get
            {
                return _convertBackWhenRightDrag;
            }
            set
            {
                _convertBackWhenRightDrag = value;
                _isConvertBackWhenRightDragSet = true;
            }
        }
        private bool _isConvertBackWhenHoldEnterSet;
        private bool _convertBackWhenHoldEnter;
		/// <summary>
        /// SystemGestureの値がHoldEnterの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenHoldEnter
        {
            get
            {
                return _convertBackWhenHoldEnter;
            }
            set
            {
                _convertBackWhenHoldEnter = value;
                _isConvertBackWhenHoldEnterSet = true;
            }
        }
        private bool _isConvertBackWhenHoldLeaveSet;
        private bool _convertBackWhenHoldLeave;
		/// <summary>
        /// SystemGestureの値がHoldLeaveの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenHoldLeave
        {
            get
            {
                return _convertBackWhenHoldLeave;
            }
            set
            {
                _convertBackWhenHoldLeave = value;
                _isConvertBackWhenHoldLeaveSet = true;
            }
        }
        private bool _isConvertBackWhenHoverEnterSet;
        private bool _convertBackWhenHoverEnter;
		/// <summary>
        /// SystemGestureの値がHoverEnterの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenHoverEnter
        {
            get
            {
                return _convertBackWhenHoverEnter;
            }
            set
            {
                _convertBackWhenHoverEnter = value;
                _isConvertBackWhenHoverEnterSet = true;
            }
        }
        private bool _isConvertBackWhenHoverLeaveSet;
        private bool _convertBackWhenHoverLeave;
		/// <summary>
        /// SystemGestureの値がHoverLeaveの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenHoverLeave
        {
            get
            {
                return _convertBackWhenHoverLeave;
            }
            set
            {
                _convertBackWhenHoverLeave = value;
                _isConvertBackWhenHoverLeaveSet = true;
            }
        }
        private bool _isConvertBackWhenFlickSet;
        private bool _convertBackWhenFlick;
		/// <summary>
        /// SystemGestureの値がFlickの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenFlick
        {
            get
            {
                return _convertBackWhenFlick;
            }
            set
            {
                _convertBackWhenFlick = value;
                _isConvertBackWhenFlickSet = true;
            }
        }
        private bool _isConvertBackWhenTwoFingerTapSet;
        private bool _convertBackWhenTwoFingerTap;
		/// <summary>
        /// SystemGestureの値がTwoFingerTapの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenTwoFingerTap
        {
            get
            {
                return _convertBackWhenTwoFingerTap;
            }
            set
            {
                _convertBackWhenTwoFingerTap = value;
                _isConvertBackWhenTwoFingerTapSet = true;
            }
        }
    }
}