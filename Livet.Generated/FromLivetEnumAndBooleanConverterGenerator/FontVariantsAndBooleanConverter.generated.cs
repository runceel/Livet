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
    /// FontVariants列挙体とbool値の相互変換を行うIValueConverterです。
    /// </summary>
    public class FontVariantsAndBooleanConverter : IValueConverter
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
        private FontVariants _convertWhenTrue;
		/// <summary>
        /// ソース値がTrueの際にどのFontVariants列挙体メンバーに変換するかを指定、または取得します。
        /// </summary>
        public FontVariants ConvertWhenTrue
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
        private FontVariants _convertWhenFalse;
		/// <summary>
        /// ソース値がFalseの際にどのFontVariants列挙体メンバーに変換するかを指定、または取得します。
        /// </summary>
        public FontVariants ConvertWhenFalse
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
            if (!(value is FontVariants)) throw new ArgumentException();

            var enumValue = (FontVariants)value;

			switch(enumValue.ToString())
			{
				case "Normal":
					if (_isConvertBackWhenNormalSet)
					{
						return ConvertBackWhenNormal;
					}
					break;
				case "Superscript":
					if (_isConvertBackWhenSuperscriptSet)
					{
						return ConvertBackWhenSuperscript;
					}
					break;
				case "Subscript":
					if (_isConvertBackWhenSubscriptSet)
					{
						return ConvertBackWhenSubscript;
					}
					break;
				case "Ordinal":
					if (_isConvertBackWhenOrdinalSet)
					{
						return ConvertBackWhenOrdinal;
					}
					break;
				case "Inferior":
					if (_isConvertBackWhenInferiorSet)
					{
						return ConvertBackWhenInferior;
					}
					break;
				case "Ruby":
					if (_isConvertBackWhenRubySet)
					{
						return ConvertBackWhenRuby;
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
        /// FontVariantsの値をbool値に変換する際のデフォルト値を指定、または取得します。
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

        private bool _isConvertBackWhenNormalSet;
        private bool _convertBackWhenNormal;
		/// <summary>
        /// FontVariantsの値がNormalの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenNormal
        {
            get
            {
                return _convertBackWhenNormal;
            }
            set
            {
                _convertBackWhenNormal = value;
                _isConvertBackWhenNormalSet = true;
            }
        }
        private bool _isConvertBackWhenSuperscriptSet;
        private bool _convertBackWhenSuperscript;
		/// <summary>
        /// FontVariantsの値がSuperscriptの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenSuperscript
        {
            get
            {
                return _convertBackWhenSuperscript;
            }
            set
            {
                _convertBackWhenSuperscript = value;
                _isConvertBackWhenSuperscriptSet = true;
            }
        }
        private bool _isConvertBackWhenSubscriptSet;
        private bool _convertBackWhenSubscript;
		/// <summary>
        /// FontVariantsの値がSubscriptの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenSubscript
        {
            get
            {
                return _convertBackWhenSubscript;
            }
            set
            {
                _convertBackWhenSubscript = value;
                _isConvertBackWhenSubscriptSet = true;
            }
        }
        private bool _isConvertBackWhenOrdinalSet;
        private bool _convertBackWhenOrdinal;
		/// <summary>
        /// FontVariantsの値がOrdinalの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenOrdinal
        {
            get
            {
                return _convertBackWhenOrdinal;
            }
            set
            {
                _convertBackWhenOrdinal = value;
                _isConvertBackWhenOrdinalSet = true;
            }
        }
        private bool _isConvertBackWhenInferiorSet;
        private bool _convertBackWhenInferior;
		/// <summary>
        /// FontVariantsの値がInferiorの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenInferior
        {
            get
            {
                return _convertBackWhenInferior;
            }
            set
            {
                _convertBackWhenInferior = value;
                _isConvertBackWhenInferiorSet = true;
            }
        }
        private bool _isConvertBackWhenRubySet;
        private bool _convertBackWhenRuby;
		/// <summary>
        /// FontVariantsの値がRubyの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenRuby
        {
            get
            {
                return _convertBackWhenRuby;
            }
            set
            {
                _convertBackWhenRuby = value;
                _isConvertBackWhenRubySet = true;
            }
        }
    }
}