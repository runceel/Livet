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
    /// StretchDirection列挙体とbool値の相互変換を行うIValueConverterです。
    /// </summary>
    public class StretchDirectionAndBooleanConverter : IValueConverter
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
        private StretchDirection _convertWhenTrue;
		/// <summary>
        /// ソース値がTrueの際にどのStretchDirection列挙体メンバーに変換するかを指定、または取得します。
        /// </summary>
        public StretchDirection ConvertWhenTrue
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
        private StretchDirection _convertWhenFalse;
		/// <summary>
        /// ソース値がFalseの際にどのStretchDirection列挙体メンバーに変換するかを指定、または取得します。
        /// </summary>
        public StretchDirection ConvertWhenFalse
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
            if (!(value is StretchDirection)) throw new ArgumentException();

            var enumValue = (StretchDirection)value;

			switch(enumValue.ToString())
			{
				case "UpOnly":
					if (_isConvertBackWhenUpOnlySet)
					{
						return ConvertBackWhenUpOnly;
					}
					break;
				case "DownOnly":
					if (_isConvertBackWhenDownOnlySet)
					{
						return ConvertBackWhenDownOnly;
					}
					break;
				case "Both":
					if (_isConvertBackWhenBothSet)
					{
						return ConvertBackWhenBoth;
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
        /// StretchDirectionの値をbool値に変換する際のデフォルト値を指定、または取得します。
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

        private bool _isConvertBackWhenUpOnlySet;
        private bool _convertBackWhenUpOnly;
		/// <summary>
        /// StretchDirectionの値がUpOnlyの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenUpOnly
        {
            get
            {
                return _convertBackWhenUpOnly;
            }
            set
            {
                _convertBackWhenUpOnly = value;
                _isConvertBackWhenUpOnlySet = true;
            }
        }
        private bool _isConvertBackWhenDownOnlySet;
        private bool _convertBackWhenDownOnly;
		/// <summary>
        /// StretchDirectionの値がDownOnlyの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenDownOnly
        {
            get
            {
                return _convertBackWhenDownOnly;
            }
            set
            {
                _convertBackWhenDownOnly = value;
                _isConvertBackWhenDownOnlySet = true;
            }
        }
        private bool _isConvertBackWhenBothSet;
        private bool _convertBackWhenBoth;
		/// <summary>
        /// StretchDirectionの値がBothの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
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
    }
}