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
    /// NumberSubstitutionMethod列挙体とbool値の相互変換を行うIValueConverterです。
    /// </summary>
    public class NumberSubstitutionMethodAndBooleanConverter : IValueConverter
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
        private NumberSubstitutionMethod _convertWhenTrue;
		/// <summary>
        /// ソース値がTrueの際にどのNumberSubstitutionMethod列挙体メンバーに変換するかを指定、または取得します。
        /// </summary>
        public NumberSubstitutionMethod ConvertWhenTrue
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
        private NumberSubstitutionMethod _convertWhenFalse;
		/// <summary>
        /// ソース値がFalseの際にどのNumberSubstitutionMethod列挙体メンバーに変換するかを指定、または取得します。
        /// </summary>
        public NumberSubstitutionMethod ConvertWhenFalse
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
            if (!(value is NumberSubstitutionMethod)) throw new ArgumentException();

            var enumValue = (NumberSubstitutionMethod)value;

			switch(enumValue.ToString())
			{
				case "AsCulture":
					if (_isConvertBackWhenAsCultureSet)
					{
						return ConvertBackWhenAsCulture;
					}
					break;
				case "Context":
					if (_isConvertBackWhenContextSet)
					{
						return ConvertBackWhenContext;
					}
					break;
				case "European":
					if (_isConvertBackWhenEuropeanSet)
					{
						return ConvertBackWhenEuropean;
					}
					break;
				case "NativeNational":
					if (_isConvertBackWhenNativeNationalSet)
					{
						return ConvertBackWhenNativeNational;
					}
					break;
				case "Traditional":
					if (_isConvertBackWhenTraditionalSet)
					{
						return ConvertBackWhenTraditional;
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
        /// NumberSubstitutionMethodの値をbool値に変換する際のデフォルト値を指定、または取得します。
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

        private bool _isConvertBackWhenAsCultureSet;
        private bool _convertBackWhenAsCulture;
		/// <summary>
        /// NumberSubstitutionMethodの値がAsCultureの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenAsCulture
        {
            get
            {
                return _convertBackWhenAsCulture;
            }
            set
            {
                _convertBackWhenAsCulture = value;
                _isConvertBackWhenAsCultureSet = true;
            }
        }
        private bool _isConvertBackWhenContextSet;
        private bool _convertBackWhenContext;
		/// <summary>
        /// NumberSubstitutionMethodの値がContextの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenContext
        {
            get
            {
                return _convertBackWhenContext;
            }
            set
            {
                _convertBackWhenContext = value;
                _isConvertBackWhenContextSet = true;
            }
        }
        private bool _isConvertBackWhenEuropeanSet;
        private bool _convertBackWhenEuropean;
		/// <summary>
        /// NumberSubstitutionMethodの値がEuropeanの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenEuropean
        {
            get
            {
                return _convertBackWhenEuropean;
            }
            set
            {
                _convertBackWhenEuropean = value;
                _isConvertBackWhenEuropeanSet = true;
            }
        }
        private bool _isConvertBackWhenNativeNationalSet;
        private bool _convertBackWhenNativeNational;
		/// <summary>
        /// NumberSubstitutionMethodの値がNativeNationalの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenNativeNational
        {
            get
            {
                return _convertBackWhenNativeNational;
            }
            set
            {
                _convertBackWhenNativeNational = value;
                _isConvertBackWhenNativeNationalSet = true;
            }
        }
        private bool _isConvertBackWhenTraditionalSet;
        private bool _convertBackWhenTraditional;
		/// <summary>
        /// NumberSubstitutionMethodの値がTraditionalの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenTraditional
        {
            get
            {
                return _convertBackWhenTraditional;
            }
            set
            {
                _convertBackWhenTraditional = value;
                _isConvertBackWhenTraditionalSet = true;
            }
        }
    }
}