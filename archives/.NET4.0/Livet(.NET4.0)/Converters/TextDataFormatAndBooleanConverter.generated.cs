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
    /// TextDataFormat列挙体とbool値の相互変換を行うIValueConverterです。
    /// </summary>
    public class TextDataFormatAndBooleanConverter : IValueConverter
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
        private TextDataFormat _convertWhenTrue;
		/// <summary>
        /// ソース値がTrueの際にどのTextDataFormat列挙体メンバーに変換するかを指定、または取得します。
        /// </summary>
        public TextDataFormat ConvertWhenTrue
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
        private TextDataFormat _convertWhenFalse;
		/// <summary>
        /// ソース値がFalseの際にどのTextDataFormat列挙体メンバーに変換するかを指定、または取得します。
        /// </summary>
        public TextDataFormat ConvertWhenFalse
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
            if (!(value is TextDataFormat)) throw new ArgumentException();

            var enumValue = (TextDataFormat)value;

			switch(enumValue.ToString())
			{
				case "Text":
					if (_isConvertBackWhenTextSet)
					{
						return ConvertBackWhenText;
					}
					break;
				case "UnicodeText":
					if (_isConvertBackWhenUnicodeTextSet)
					{
						return ConvertBackWhenUnicodeText;
					}
					break;
				case "Rtf":
					if (_isConvertBackWhenRtfSet)
					{
						return ConvertBackWhenRtf;
					}
					break;
				case "Html":
					if (_isConvertBackWhenHtmlSet)
					{
						return ConvertBackWhenHtml;
					}
					break;
				case "CommaSeparatedValue":
					if (_isConvertBackWhenCommaSeparatedValueSet)
					{
						return ConvertBackWhenCommaSeparatedValue;
					}
					break;
				case "Xaml":
					if (_isConvertBackWhenXamlSet)
					{
						return ConvertBackWhenXaml;
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
        /// TextDataFormatの値をbool値に変換する際のデフォルト値を指定、または取得します。
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

        private bool _isConvertBackWhenTextSet;
        private bool _convertBackWhenText;
		/// <summary>
        /// TextDataFormatの値がTextの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenText
        {
            get
            {
                return _convertBackWhenText;
            }
            set
            {
                _convertBackWhenText = value;
                _isConvertBackWhenTextSet = true;
            }
        }
        private bool _isConvertBackWhenUnicodeTextSet;
        private bool _convertBackWhenUnicodeText;
		/// <summary>
        /// TextDataFormatの値がUnicodeTextの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenUnicodeText
        {
            get
            {
                return _convertBackWhenUnicodeText;
            }
            set
            {
                _convertBackWhenUnicodeText = value;
                _isConvertBackWhenUnicodeTextSet = true;
            }
        }
        private bool _isConvertBackWhenRtfSet;
        private bool _convertBackWhenRtf;
		/// <summary>
        /// TextDataFormatの値がRtfの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenRtf
        {
            get
            {
                return _convertBackWhenRtf;
            }
            set
            {
                _convertBackWhenRtf = value;
                _isConvertBackWhenRtfSet = true;
            }
        }
        private bool _isConvertBackWhenHtmlSet;
        private bool _convertBackWhenHtml;
		/// <summary>
        /// TextDataFormatの値がHtmlの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenHtml
        {
            get
            {
                return _convertBackWhenHtml;
            }
            set
            {
                _convertBackWhenHtml = value;
                _isConvertBackWhenHtmlSet = true;
            }
        }
        private bool _isConvertBackWhenCommaSeparatedValueSet;
        private bool _convertBackWhenCommaSeparatedValue;
		/// <summary>
        /// TextDataFormatの値がCommaSeparatedValueの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenCommaSeparatedValue
        {
            get
            {
                return _convertBackWhenCommaSeparatedValue;
            }
            set
            {
                _convertBackWhenCommaSeparatedValue = value;
                _isConvertBackWhenCommaSeparatedValueSet = true;
            }
        }
        private bool _isConvertBackWhenXamlSet;
        private bool _convertBackWhenXaml;
		/// <summary>
        /// TextDataFormatの値がXamlの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenXaml
        {
            get
            {
                return _convertBackWhenXaml;
            }
            set
            {
                _convertBackWhenXaml = value;
                _isConvertBackWhenXamlSet = true;
            }
        }
    }
}