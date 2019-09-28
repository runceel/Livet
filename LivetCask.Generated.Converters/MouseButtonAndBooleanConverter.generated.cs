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
    /// MouseButton列挙体とbool値の相互変換を行うIValueConverterです。
    /// </summary>
    public class MouseButtonAndBooleanConverter : IValueConverter
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
        private MouseButton _convertWhenTrue;
		/// <summary>
        /// ソース値がTrueの際にどのMouseButton列挙体メンバーに変換するかを指定、または取得します。
        /// </summary>
        public MouseButton ConvertWhenTrue
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
        private MouseButton _convertWhenFalse;
		/// <summary>
        /// ソース値がFalseの際にどのMouseButton列挙体メンバーに変換するかを指定、または取得します。
        /// </summary>
        public MouseButton ConvertWhenFalse
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
            if (!(value is MouseButton)) throw new ArgumentException();

            var enumValue = (MouseButton)value;

			switch(enumValue.ToString())
			{
				case "Left":
					if (_isConvertBackWhenLeftSet)
					{
						return ConvertBackWhenLeft;
					}
					break;
				case "Middle":
					if (_isConvertBackWhenMiddleSet)
					{
						return ConvertBackWhenMiddle;
					}
					break;
				case "Right":
					if (_isConvertBackWhenRightSet)
					{
						return ConvertBackWhenRight;
					}
					break;
				case "XButton1":
					if (_isConvertBackWhenXButton1Set)
					{
						return ConvertBackWhenXButton1;
					}
					break;
				case "XButton2":
					if (_isConvertBackWhenXButton2Set)
					{
						return ConvertBackWhenXButton2;
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
        /// MouseButtonの値をbool値に変換する際のデフォルト値を指定、または取得します。
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

        private bool _isConvertBackWhenLeftSet;
        private bool _convertBackWhenLeft;
		/// <summary>
        /// MouseButtonの値がLeftの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
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
        private bool _isConvertBackWhenMiddleSet;
        private bool _convertBackWhenMiddle;
		/// <summary>
        /// MouseButtonの値がMiddleの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenMiddle
        {
            get
            {
                return _convertBackWhenMiddle;
            }
            set
            {
                _convertBackWhenMiddle = value;
                _isConvertBackWhenMiddleSet = true;
            }
        }
        private bool _isConvertBackWhenRightSet;
        private bool _convertBackWhenRight;
		/// <summary>
        /// MouseButtonの値がRightの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
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
        private bool _isConvertBackWhenXButton1Set;
        private bool _convertBackWhenXButton1;
		/// <summary>
        /// MouseButtonの値がXButton1の際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenXButton1
        {
            get
            {
                return _convertBackWhenXButton1;
            }
            set
            {
                _convertBackWhenXButton1 = value;
                _isConvertBackWhenXButton1Set = true;
            }
        }
        private bool _isConvertBackWhenXButton2Set;
        private bool _convertBackWhenXButton2;
		/// <summary>
        /// MouseButtonの値がXButton2の際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenXButton2
        {
            get
            {
                return _convertBackWhenXButton2;
            }
            set
            {
                _convertBackWhenXButton2 = value;
                _isConvertBackWhenXButton2Set = true;
            }
        }
    }
}