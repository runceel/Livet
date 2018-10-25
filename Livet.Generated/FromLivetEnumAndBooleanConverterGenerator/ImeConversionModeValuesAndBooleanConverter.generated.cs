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
    /// ImeConversionModeValues列挙体とbool値の相互変換を行うIValueConverterです。
    /// </summary>
    public class ImeConversionModeValuesAndBooleanConverter : IValueConverter
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
        private ImeConversionModeValues _convertWhenTrue;
		/// <summary>
        /// ソース値がTrueの際にどのImeConversionModeValues列挙体メンバーに変換するかを指定、または取得します。
        /// </summary>
        public ImeConversionModeValues ConvertWhenTrue
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
        private ImeConversionModeValues _convertWhenFalse;
		/// <summary>
        /// ソース値がFalseの際にどのImeConversionModeValues列挙体メンバーに変換するかを指定、または取得します。
        /// </summary>
        public ImeConversionModeValues ConvertWhenFalse
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
            if (!(value is ImeConversionModeValues)) throw new ArgumentException();

            var enumValue = (ImeConversionModeValues)value;

			switch(enumValue.ToString())
			{
				case "Native":
					if (_isConvertBackWhenNativeSet)
					{
						return ConvertBackWhenNative;
					}
					break;
				case "Katakana":
					if (_isConvertBackWhenKatakanaSet)
					{
						return ConvertBackWhenKatakana;
					}
					break;
				case "FullShape":
					if (_isConvertBackWhenFullShapeSet)
					{
						return ConvertBackWhenFullShape;
					}
					break;
				case "Roman":
					if (_isConvertBackWhenRomanSet)
					{
						return ConvertBackWhenRoman;
					}
					break;
				case "CharCode":
					if (_isConvertBackWhenCharCodeSet)
					{
						return ConvertBackWhenCharCode;
					}
					break;
				case "NoConversion":
					if (_isConvertBackWhenNoConversionSet)
					{
						return ConvertBackWhenNoConversion;
					}
					break;
				case "Eudc":
					if (_isConvertBackWhenEudcSet)
					{
						return ConvertBackWhenEudc;
					}
					break;
				case "Symbol":
					if (_isConvertBackWhenSymbolSet)
					{
						return ConvertBackWhenSymbol;
					}
					break;
				case "Fixed":
					if (_isConvertBackWhenFixedSet)
					{
						return ConvertBackWhenFixed;
					}
					break;
				case "Alphanumeric":
					if (_isConvertBackWhenAlphanumericSet)
					{
						return ConvertBackWhenAlphanumeric;
					}
					break;
				case "DoNotCare":
					if (_isConvertBackWhenDoNotCareSet)
					{
						return ConvertBackWhenDoNotCare;
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
        /// ImeConversionModeValuesの値をbool値に変換する際のデフォルト値を指定、または取得します。
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

        private bool _isConvertBackWhenNativeSet;
        private bool _convertBackWhenNative;
		/// <summary>
        /// ImeConversionModeValuesの値がNativeの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenNative
        {
            get
            {
                return _convertBackWhenNative;
            }
            set
            {
                _convertBackWhenNative = value;
                _isConvertBackWhenNativeSet = true;
            }
        }
        private bool _isConvertBackWhenKatakanaSet;
        private bool _convertBackWhenKatakana;
		/// <summary>
        /// ImeConversionModeValuesの値がKatakanaの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenKatakana
        {
            get
            {
                return _convertBackWhenKatakana;
            }
            set
            {
                _convertBackWhenKatakana = value;
                _isConvertBackWhenKatakanaSet = true;
            }
        }
        private bool _isConvertBackWhenFullShapeSet;
        private bool _convertBackWhenFullShape;
		/// <summary>
        /// ImeConversionModeValuesの値がFullShapeの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenFullShape
        {
            get
            {
                return _convertBackWhenFullShape;
            }
            set
            {
                _convertBackWhenFullShape = value;
                _isConvertBackWhenFullShapeSet = true;
            }
        }
        private bool _isConvertBackWhenRomanSet;
        private bool _convertBackWhenRoman;
		/// <summary>
        /// ImeConversionModeValuesの値がRomanの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenRoman
        {
            get
            {
                return _convertBackWhenRoman;
            }
            set
            {
                _convertBackWhenRoman = value;
                _isConvertBackWhenRomanSet = true;
            }
        }
        private bool _isConvertBackWhenCharCodeSet;
        private bool _convertBackWhenCharCode;
		/// <summary>
        /// ImeConversionModeValuesの値がCharCodeの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenCharCode
        {
            get
            {
                return _convertBackWhenCharCode;
            }
            set
            {
                _convertBackWhenCharCode = value;
                _isConvertBackWhenCharCodeSet = true;
            }
        }
        private bool _isConvertBackWhenNoConversionSet;
        private bool _convertBackWhenNoConversion;
		/// <summary>
        /// ImeConversionModeValuesの値がNoConversionの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenNoConversion
        {
            get
            {
                return _convertBackWhenNoConversion;
            }
            set
            {
                _convertBackWhenNoConversion = value;
                _isConvertBackWhenNoConversionSet = true;
            }
        }
        private bool _isConvertBackWhenEudcSet;
        private bool _convertBackWhenEudc;
		/// <summary>
        /// ImeConversionModeValuesの値がEudcの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenEudc
        {
            get
            {
                return _convertBackWhenEudc;
            }
            set
            {
                _convertBackWhenEudc = value;
                _isConvertBackWhenEudcSet = true;
            }
        }
        private bool _isConvertBackWhenSymbolSet;
        private bool _convertBackWhenSymbol;
		/// <summary>
        /// ImeConversionModeValuesの値がSymbolの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenSymbol
        {
            get
            {
                return _convertBackWhenSymbol;
            }
            set
            {
                _convertBackWhenSymbol = value;
                _isConvertBackWhenSymbolSet = true;
            }
        }
        private bool _isConvertBackWhenFixedSet;
        private bool _convertBackWhenFixed;
		/// <summary>
        /// ImeConversionModeValuesの値がFixedの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenFixed
        {
            get
            {
                return _convertBackWhenFixed;
            }
            set
            {
                _convertBackWhenFixed = value;
                _isConvertBackWhenFixedSet = true;
            }
        }
        private bool _isConvertBackWhenAlphanumericSet;
        private bool _convertBackWhenAlphanumeric;
		/// <summary>
        /// ImeConversionModeValuesの値がAlphanumericの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenAlphanumeric
        {
            get
            {
                return _convertBackWhenAlphanumeric;
            }
            set
            {
                _convertBackWhenAlphanumeric = value;
                _isConvertBackWhenAlphanumericSet = true;
            }
        }
        private bool _isConvertBackWhenDoNotCareSet;
        private bool _convertBackWhenDoNotCare;
		/// <summary>
        /// ImeConversionModeValuesの値がDoNotCareの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenDoNotCare
        {
            get
            {
                return _convertBackWhenDoNotCare;
            }
            set
            {
                _convertBackWhenDoNotCare = value;
                _isConvertBackWhenDoNotCareSet = true;
            }
        }
    }
}