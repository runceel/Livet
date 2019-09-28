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
    /// StylusPointPropertyUnit列挙体とbool値の相互変換を行うIValueConverterです。
    /// </summary>
    public class StylusPointPropertyUnitAndBooleanConverter : IValueConverter
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
        private StylusPointPropertyUnit _convertWhenTrue;
		/// <summary>
        /// ソース値がTrueの際にどのStylusPointPropertyUnit列挙体メンバーに変換するかを指定、または取得します。
        /// </summary>
        public StylusPointPropertyUnit ConvertWhenTrue
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
        private StylusPointPropertyUnit _convertWhenFalse;
		/// <summary>
        /// ソース値がFalseの際にどのStylusPointPropertyUnit列挙体メンバーに変換するかを指定、または取得します。
        /// </summary>
        public StylusPointPropertyUnit ConvertWhenFalse
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
            if (!(value is StylusPointPropertyUnit)) throw new ArgumentException();

            var enumValue = (StylusPointPropertyUnit)value;

			switch(enumValue.ToString())
			{
				case "None":
					if (_isConvertBackWhenNoneSet)
					{
						return ConvertBackWhenNone;
					}
					break;
				case "Inches":
					if (_isConvertBackWhenInchesSet)
					{
						return ConvertBackWhenInches;
					}
					break;
				case "Centimeters":
					if (_isConvertBackWhenCentimetersSet)
					{
						return ConvertBackWhenCentimeters;
					}
					break;
				case "Degrees":
					if (_isConvertBackWhenDegreesSet)
					{
						return ConvertBackWhenDegrees;
					}
					break;
				case "Radians":
					if (_isConvertBackWhenRadiansSet)
					{
						return ConvertBackWhenRadians;
					}
					break;
				case "Seconds":
					if (_isConvertBackWhenSecondsSet)
					{
						return ConvertBackWhenSeconds;
					}
					break;
				case "Pounds":
					if (_isConvertBackWhenPoundsSet)
					{
						return ConvertBackWhenPounds;
					}
					break;
				case "Grams":
					if (_isConvertBackWhenGramsSet)
					{
						return ConvertBackWhenGrams;
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
        /// StylusPointPropertyUnitの値をbool値に変換する際のデフォルト値を指定、または取得します。
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
        /// StylusPointPropertyUnitの値がNoneの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
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
        private bool _isConvertBackWhenInchesSet;
        private bool _convertBackWhenInches;
		/// <summary>
        /// StylusPointPropertyUnitの値がInchesの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenInches
        {
            get
            {
                return _convertBackWhenInches;
            }
            set
            {
                _convertBackWhenInches = value;
                _isConvertBackWhenInchesSet = true;
            }
        }
        private bool _isConvertBackWhenCentimetersSet;
        private bool _convertBackWhenCentimeters;
		/// <summary>
        /// StylusPointPropertyUnitの値がCentimetersの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenCentimeters
        {
            get
            {
                return _convertBackWhenCentimeters;
            }
            set
            {
                _convertBackWhenCentimeters = value;
                _isConvertBackWhenCentimetersSet = true;
            }
        }
        private bool _isConvertBackWhenDegreesSet;
        private bool _convertBackWhenDegrees;
		/// <summary>
        /// StylusPointPropertyUnitの値がDegreesの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenDegrees
        {
            get
            {
                return _convertBackWhenDegrees;
            }
            set
            {
                _convertBackWhenDegrees = value;
                _isConvertBackWhenDegreesSet = true;
            }
        }
        private bool _isConvertBackWhenRadiansSet;
        private bool _convertBackWhenRadians;
		/// <summary>
        /// StylusPointPropertyUnitの値がRadiansの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenRadians
        {
            get
            {
                return _convertBackWhenRadians;
            }
            set
            {
                _convertBackWhenRadians = value;
                _isConvertBackWhenRadiansSet = true;
            }
        }
        private bool _isConvertBackWhenSecondsSet;
        private bool _convertBackWhenSeconds;
		/// <summary>
        /// StylusPointPropertyUnitの値がSecondsの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenSeconds
        {
            get
            {
                return _convertBackWhenSeconds;
            }
            set
            {
                _convertBackWhenSeconds = value;
                _isConvertBackWhenSecondsSet = true;
            }
        }
        private bool _isConvertBackWhenPoundsSet;
        private bool _convertBackWhenPounds;
		/// <summary>
        /// StylusPointPropertyUnitの値がPoundsの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenPounds
        {
            get
            {
                return _convertBackWhenPounds;
            }
            set
            {
                _convertBackWhenPounds = value;
                _isConvertBackWhenPoundsSet = true;
            }
        }
        private bool _isConvertBackWhenGramsSet;
        private bool _convertBackWhenGrams;
		/// <summary>
        /// StylusPointPropertyUnitの値がGramsの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenGrams
        {
            get
            {
                return _convertBackWhenGrams;
            }
            set
            {
                _convertBackWhenGrams = value;
                _isConvertBackWhenGramsSet = true;
            }
        }
    }
}