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
    /// BindingMode列挙体とbool値の相互変換を行うIValueConverterです。
    /// </summary>
    public class BindingModeAndBooleanConverter : IValueConverter
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
        private BindingMode _convertWhenTrue;
		/// <summary>
        /// ソース値がTrueの際にどのBindingMode列挙体メンバーに変換するかを指定、または取得します。
        /// </summary>
        public BindingMode ConvertWhenTrue
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
        private BindingMode _convertWhenFalse;
		/// <summary>
        /// ソース値がFalseの際にどのBindingMode列挙体メンバーに変換するかを指定、または取得します。
        /// </summary>
        public BindingMode ConvertWhenFalse
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
            if (!(value is BindingMode)) throw new ArgumentException();

            var enumValue = (BindingMode)value;

			switch(enumValue.ToString())
			{
				case "TwoWay":
					if (_isConvertBackWhenTwoWaySet)
					{
						return ConvertBackWhenTwoWay;
					}
					break;
				case "OneWay":
					if (_isConvertBackWhenOneWaySet)
					{
						return ConvertBackWhenOneWay;
					}
					break;
				case "OneTime":
					if (_isConvertBackWhenOneTimeSet)
					{
						return ConvertBackWhenOneTime;
					}
					break;
				case "OneWayToSource":
					if (_isConvertBackWhenOneWayToSourceSet)
					{
						return ConvertBackWhenOneWayToSource;
					}
					break;
				case "Default":
					if (_isConvertBackWhenDefaultSet)
					{
						return ConvertBackWhenDefault;
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
        /// BindingModeの値をbool値に変換する際のデフォルト値を指定、または取得します。
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

        private bool _isConvertBackWhenTwoWaySet;
        private bool _convertBackWhenTwoWay;
		/// <summary>
        /// BindingModeの値がTwoWayの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenTwoWay
        {
            get
            {
                return _convertBackWhenTwoWay;
            }
            set
            {
                _convertBackWhenTwoWay = value;
                _isConvertBackWhenTwoWaySet = true;
            }
        }
        private bool _isConvertBackWhenOneWaySet;
        private bool _convertBackWhenOneWay;
		/// <summary>
        /// BindingModeの値がOneWayの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenOneWay
        {
            get
            {
                return _convertBackWhenOneWay;
            }
            set
            {
                _convertBackWhenOneWay = value;
                _isConvertBackWhenOneWaySet = true;
            }
        }
        private bool _isConvertBackWhenOneTimeSet;
        private bool _convertBackWhenOneTime;
		/// <summary>
        /// BindingModeの値がOneTimeの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenOneTime
        {
            get
            {
                return _convertBackWhenOneTime;
            }
            set
            {
                _convertBackWhenOneTime = value;
                _isConvertBackWhenOneTimeSet = true;
            }
        }
        private bool _isConvertBackWhenOneWayToSourceSet;
        private bool _convertBackWhenOneWayToSource;
		/// <summary>
        /// BindingModeの値がOneWayToSourceの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenOneWayToSource
        {
            get
            {
                return _convertBackWhenOneWayToSource;
            }
            set
            {
                _convertBackWhenOneWayToSource = value;
                _isConvertBackWhenOneWayToSourceSet = true;
            }
        }
        private bool _isConvertBackWhenDefaultSet;
        private bool _convertBackWhenDefault;
		/// <summary>
        /// BindingModeの値がDefaultの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenDefault
        {
            get
            {
                return _convertBackWhenDefault;
            }
            set
            {
                _convertBackWhenDefault = value;
                _isConvertBackWhenDefaultSet = true;
            }
        }
    }
}