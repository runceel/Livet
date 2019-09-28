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
    /// PanningMode列挙体とbool値の相互変換を行うIValueConverterです。
    /// </summary>
    public class PanningModeAndBooleanConverter : IValueConverter
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
        private PanningMode _convertWhenTrue;
		/// <summary>
        /// ソース値がTrueの際にどのPanningMode列挙体メンバーに変換するかを指定、または取得します。
        /// </summary>
        public PanningMode ConvertWhenTrue
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
        private PanningMode _convertWhenFalse;
		/// <summary>
        /// ソース値がFalseの際にどのPanningMode列挙体メンバーに変換するかを指定、または取得します。
        /// </summary>
        public PanningMode ConvertWhenFalse
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
            if (!(value is PanningMode)) throw new ArgumentException();

            var enumValue = (PanningMode)value;

			switch(enumValue.ToString())
			{
				case "None":
					if (_isConvertBackWhenNoneSet)
					{
						return ConvertBackWhenNone;
					}
					break;
				case "HorizontalOnly":
					if (_isConvertBackWhenHorizontalOnlySet)
					{
						return ConvertBackWhenHorizontalOnly;
					}
					break;
				case "VerticalOnly":
					if (_isConvertBackWhenVerticalOnlySet)
					{
						return ConvertBackWhenVerticalOnly;
					}
					break;
				case "Both":
					if (_isConvertBackWhenBothSet)
					{
						return ConvertBackWhenBoth;
					}
					break;
				case "HorizontalFirst":
					if (_isConvertBackWhenHorizontalFirstSet)
					{
						return ConvertBackWhenHorizontalFirst;
					}
					break;
				case "VerticalFirst":
					if (_isConvertBackWhenVerticalFirstSet)
					{
						return ConvertBackWhenVerticalFirst;
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
        /// PanningModeの値をbool値に変換する際のデフォルト値を指定、または取得します。
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
        /// PanningModeの値がNoneの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
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
        private bool _isConvertBackWhenHorizontalOnlySet;
        private bool _convertBackWhenHorizontalOnly;
		/// <summary>
        /// PanningModeの値がHorizontalOnlyの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenHorizontalOnly
        {
            get
            {
                return _convertBackWhenHorizontalOnly;
            }
            set
            {
                _convertBackWhenHorizontalOnly = value;
                _isConvertBackWhenHorizontalOnlySet = true;
            }
        }
        private bool _isConvertBackWhenVerticalOnlySet;
        private bool _convertBackWhenVerticalOnly;
		/// <summary>
        /// PanningModeの値がVerticalOnlyの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenVerticalOnly
        {
            get
            {
                return _convertBackWhenVerticalOnly;
            }
            set
            {
                _convertBackWhenVerticalOnly = value;
                _isConvertBackWhenVerticalOnlySet = true;
            }
        }
        private bool _isConvertBackWhenBothSet;
        private bool _convertBackWhenBoth;
		/// <summary>
        /// PanningModeの値がBothの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenBoth
        {
            get
            {
                return _convertBackWhenBoth;
            }
            set
            {
                _convertBackWhenBoth = value;
                _isConvertBackWhenBothSet = true;
            }
        }
        private bool _isConvertBackWhenHorizontalFirstSet;
        private bool _convertBackWhenHorizontalFirst;
		/// <summary>
        /// PanningModeの値がHorizontalFirstの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenHorizontalFirst
        {
            get
            {
                return _convertBackWhenHorizontalFirst;
            }
            set
            {
                _convertBackWhenHorizontalFirst = value;
                _isConvertBackWhenHorizontalFirstSet = true;
            }
        }
        private bool _isConvertBackWhenVerticalFirstSet;
        private bool _convertBackWhenVerticalFirst;
		/// <summary>
        /// PanningModeの値がVerticalFirstの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenVerticalFirst
        {
            get
            {
                return _convertBackWhenVerticalFirst;
            }
            set
            {
                _convertBackWhenVerticalFirst = value;
                _isConvertBackWhenVerticalFirstSet = true;
            }
        }
    }
}