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
    /// FocusNavigationDirection列挙体とbool値の相互変換を行うIValueConverterです。
    /// </summary>
    public class FocusNavigationDirectionAndBooleanConverter : IValueConverter
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
        private FocusNavigationDirection _convertWhenTrue;
		/// <summary>
        /// ソース値がTrueの際にどのFocusNavigationDirection列挙体メンバーに変換するかを指定、または取得します。
        /// </summary>
        public FocusNavigationDirection ConvertWhenTrue
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
        private FocusNavigationDirection _convertWhenFalse;
		/// <summary>
        /// ソース値がFalseの際にどのFocusNavigationDirection列挙体メンバーに変換するかを指定、または取得します。
        /// </summary>
        public FocusNavigationDirection ConvertWhenFalse
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
            if (!(value is FocusNavigationDirection)) throw new ArgumentException();

            var enumValue = (FocusNavigationDirection)value;

			switch(enumValue.ToString())
			{
				case "Next":
					if (_isConvertBackWhenNextSet)
					{
						return ConvertBackWhenNext;
					}
					break;
				case "Previous":
					if (_isConvertBackWhenPreviousSet)
					{
						return ConvertBackWhenPrevious;
					}
					break;
				case "First":
					if (_isConvertBackWhenFirstSet)
					{
						return ConvertBackWhenFirst;
					}
					break;
				case "Last":
					if (_isConvertBackWhenLastSet)
					{
						return ConvertBackWhenLast;
					}
					break;
				case "Left":
					if (_isConvertBackWhenLeftSet)
					{
						return ConvertBackWhenLeft;
					}
					break;
				case "Right":
					if (_isConvertBackWhenRightSet)
					{
						return ConvertBackWhenRight;
					}
					break;
				case "Up":
					if (_isConvertBackWhenUpSet)
					{
						return ConvertBackWhenUp;
					}
					break;
				case "Down":
					if (_isConvertBackWhenDownSet)
					{
						return ConvertBackWhenDown;
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
        /// FocusNavigationDirectionの値をbool値に変換する際のデフォルト値を指定、または取得します。
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

        private bool _isConvertBackWhenNextSet;
        private bool _convertBackWhenNext;
		/// <summary>
        /// FocusNavigationDirectionの値がNextの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenNext
        {
            get
            {
                return _convertBackWhenNext;
            }
            set
            {
                _convertBackWhenNext = value;
                _isConvertBackWhenNextSet = true;
            }
        }
        private bool _isConvertBackWhenPreviousSet;
        private bool _convertBackWhenPrevious;
		/// <summary>
        /// FocusNavigationDirectionの値がPreviousの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenPrevious
        {
            get
            {
                return _convertBackWhenPrevious;
            }
            set
            {
                _convertBackWhenPrevious = value;
                _isConvertBackWhenPreviousSet = true;
            }
        }
        private bool _isConvertBackWhenFirstSet;
        private bool _convertBackWhenFirst;
		/// <summary>
        /// FocusNavigationDirectionの値がFirstの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenFirst
        {
            get
            {
                return _convertBackWhenFirst;
            }
            set
            {
                _convertBackWhenFirst = value;
                _isConvertBackWhenFirstSet = true;
            }
        }
        private bool _isConvertBackWhenLastSet;
        private bool _convertBackWhenLast;
		/// <summary>
        /// FocusNavigationDirectionの値がLastの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenLast
        {
            get
            {
                return _convertBackWhenLast;
            }
            set
            {
                _convertBackWhenLast = value;
                _isConvertBackWhenLastSet = true;
            }
        }
        private bool _isConvertBackWhenLeftSet;
        private bool _convertBackWhenLeft;
		/// <summary>
        /// FocusNavigationDirectionの値がLeftの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
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
        private bool _isConvertBackWhenRightSet;
        private bool _convertBackWhenRight;
		/// <summary>
        /// FocusNavigationDirectionの値がRightの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
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
        private bool _isConvertBackWhenUpSet;
        private bool _convertBackWhenUp;
		/// <summary>
        /// FocusNavigationDirectionの値がUpの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenUp
        {
            get
            {
                return _convertBackWhenUp;
            }
            set
            {
                _convertBackWhenUp = value;
                _isConvertBackWhenUpSet = true;
            }
        }
        private bool _isConvertBackWhenDownSet;
        private bool _convertBackWhenDown;
		/// <summary>
        /// FocusNavigationDirectionの値がDownの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenDown
        {
            get
            {
                return _convertBackWhenDown;
            }
            set
            {
                _convertBackWhenDown = value;
                _isConvertBackWhenDownSet = true;
            }
        }
    }
}