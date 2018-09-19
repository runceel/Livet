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
    /// OverflowMode列挙体とbool値の相互変換を行うIValueConverterです。
    /// </summary>
    public class OverflowModeAndBooleanConverter : IValueConverter
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
        private OverflowMode _convertWhenTrue;
		/// <summary>
        /// ソース値がTrueの際にどのOverflowMode列挙体メンバーに変換するかを指定、または取得します。
        /// </summary>
        public OverflowMode ConvertWhenTrue
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
        private OverflowMode _convertWhenFalse;
		/// <summary>
        /// ソース値がFalseの際にどのOverflowMode列挙体メンバーに変換するかを指定、または取得します。
        /// </summary>
        public OverflowMode ConvertWhenFalse
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
            if (!(value is OverflowMode)) throw new ArgumentException();

            var enumValue = (OverflowMode)value;

			switch(enumValue.ToString())
			{
				case "AsNeeded":
					if (_isConvertBackWhenAsNeededSet)
					{
						return ConvertBackWhenAsNeeded;
					}
					break;
				case "Always":
					if (_isConvertBackWhenAlwaysSet)
					{
						return ConvertBackWhenAlways;
					}
					break;
				case "Never":
					if (_isConvertBackWhenNeverSet)
					{
						return ConvertBackWhenNever;
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
        /// OverflowModeの値をbool値に変換する際のデフォルト値を指定、または取得します。
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

        private bool _isConvertBackWhenAsNeededSet;
        private bool _convertBackWhenAsNeeded;
		/// <summary>
        /// OverflowModeの値がAsNeededの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenAsNeeded
        {
            get
            {
                return _convertBackWhenAsNeeded;
            }
            set
            {
                _convertBackWhenAsNeeded = value;
                _isConvertBackWhenAsNeededSet = true;
            }
        }
        private bool _isConvertBackWhenAlwaysSet;
        private bool _convertBackWhenAlways;
		/// <summary>
        /// OverflowModeの値がAlwaysの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenAlways
        {
            get
            {
                return _convertBackWhenAlways;
            }
            set
            {
                _convertBackWhenAlways = value;
                _isConvertBackWhenAlwaysSet = true;
            }
        }
        private bool _isConvertBackWhenNeverSet;
        private bool _convertBackWhenNever;
		/// <summary>
        /// OverflowModeの値がNeverの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenNever
        {
            get
            {
                return _convertBackWhenNever;
            }
            set
            {
                _convertBackWhenNever = value;
                _isConvertBackWhenNeverSet = true;
            }
        }
    }
}