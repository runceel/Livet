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
    /// FontEastAsianLanguage列挙体とbool値の相互変換を行うIValueConverterです。
    /// </summary>
    public class FontEastAsianLanguageAndBooleanConverter : IValueConverter
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
        private FontEastAsianLanguage _convertWhenTrue;
		/// <summary>
        /// ソース値がTrueの際にどのFontEastAsianLanguage列挙体メンバーに変換するかを指定、または取得します。
        /// </summary>
        public FontEastAsianLanguage ConvertWhenTrue
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
        private FontEastAsianLanguage _convertWhenFalse;
		/// <summary>
        /// ソース値がFalseの際にどのFontEastAsianLanguage列挙体メンバーに変換するかを指定、または取得します。
        /// </summary>
        public FontEastAsianLanguage ConvertWhenFalse
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
            if (!(value is FontEastAsianLanguage)) throw new ArgumentException();

            var enumValue = (FontEastAsianLanguage)value;

			switch(enumValue.ToString())
			{
				case "Normal":
					if (_isConvertBackWhenNormalSet)
					{
						return ConvertBackWhenNormal;
					}
					break;
				case "Jis78":
					if (_isConvertBackWhenJis78Set)
					{
						return ConvertBackWhenJis78;
					}
					break;
				case "Jis83":
					if (_isConvertBackWhenJis83Set)
					{
						return ConvertBackWhenJis83;
					}
					break;
				case "Jis90":
					if (_isConvertBackWhenJis90Set)
					{
						return ConvertBackWhenJis90;
					}
					break;
				case "Jis04":
					if (_isConvertBackWhenJis04Set)
					{
						return ConvertBackWhenJis04;
					}
					break;
				case "HojoKanji":
					if (_isConvertBackWhenHojoKanjiSet)
					{
						return ConvertBackWhenHojoKanji;
					}
					break;
				case "NlcKanji":
					if (_isConvertBackWhenNlcKanjiSet)
					{
						return ConvertBackWhenNlcKanji;
					}
					break;
				case "Simplified":
					if (_isConvertBackWhenSimplifiedSet)
					{
						return ConvertBackWhenSimplified;
					}
					break;
				case "Traditional":
					if (_isConvertBackWhenTraditionalSet)
					{
						return ConvertBackWhenTraditional;
					}
					break;
				case "TraditionalNames":
					if (_isConvertBackWhenTraditionalNamesSet)
					{
						return ConvertBackWhenTraditionalNames;
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
        /// FontEastAsianLanguageの値をbool値に変換する際のデフォルト値を指定、または取得します。
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
        /// FontEastAsianLanguageの値がNormalの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
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
        private bool _isConvertBackWhenJis78Set;
        private bool _convertBackWhenJis78;
		/// <summary>
        /// FontEastAsianLanguageの値がJis78の際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenJis78
        {
            get
            {
                return _convertBackWhenJis78;
            }
            set
            {
                _convertBackWhenJis78 = value;
                _isConvertBackWhenJis78Set = true;
            }
        }
        private bool _isConvertBackWhenJis83Set;
        private bool _convertBackWhenJis83;
		/// <summary>
        /// FontEastAsianLanguageの値がJis83の際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenJis83
        {
            get
            {
                return _convertBackWhenJis83;
            }
            set
            {
                _convertBackWhenJis83 = value;
                _isConvertBackWhenJis83Set = true;
            }
        }
        private bool _isConvertBackWhenJis90Set;
        private bool _convertBackWhenJis90;
		/// <summary>
        /// FontEastAsianLanguageの値がJis90の際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenJis90
        {
            get
            {
                return _convertBackWhenJis90;
            }
            set
            {
                _convertBackWhenJis90 = value;
                _isConvertBackWhenJis90Set = true;
            }
        }
        private bool _isConvertBackWhenJis04Set;
        private bool _convertBackWhenJis04;
		/// <summary>
        /// FontEastAsianLanguageの値がJis04の際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenJis04
        {
            get
            {
                return _convertBackWhenJis04;
            }
            set
            {
                _convertBackWhenJis04 = value;
                _isConvertBackWhenJis04Set = true;
            }
        }
        private bool _isConvertBackWhenHojoKanjiSet;
        private bool _convertBackWhenHojoKanji;
		/// <summary>
        /// FontEastAsianLanguageの値がHojoKanjiの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenHojoKanji
        {
            get
            {
                return _convertBackWhenHojoKanji;
            }
            set
            {
                _convertBackWhenHojoKanji = value;
                _isConvertBackWhenHojoKanjiSet = true;
            }
        }
        private bool _isConvertBackWhenNlcKanjiSet;
        private bool _convertBackWhenNlcKanji;
		/// <summary>
        /// FontEastAsianLanguageの値がNlcKanjiの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenNlcKanji
        {
            get
            {
                return _convertBackWhenNlcKanji;
            }
            set
            {
                _convertBackWhenNlcKanji = value;
                _isConvertBackWhenNlcKanjiSet = true;
            }
        }
        private bool _isConvertBackWhenSimplifiedSet;
        private bool _convertBackWhenSimplified;
		/// <summary>
        /// FontEastAsianLanguageの値がSimplifiedの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenSimplified
        {
            get
            {
                return _convertBackWhenSimplified;
            }
            set
            {
                _convertBackWhenSimplified = value;
                _isConvertBackWhenSimplifiedSet = true;
            }
        }
        private bool _isConvertBackWhenTraditionalSet;
        private bool _convertBackWhenTraditional;
		/// <summary>
        /// FontEastAsianLanguageの値がTraditionalの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
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
        private bool _isConvertBackWhenTraditionalNamesSet;
        private bool _convertBackWhenTraditionalNames;
		/// <summary>
        /// FontEastAsianLanguageの値がTraditionalNamesの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenTraditionalNames
        {
            get
            {
                return _convertBackWhenTraditionalNames;
            }
            set
            {
                _convertBackWhenTraditionalNames = value;
                _isConvertBackWhenTraditionalNamesSet = true;
            }
        }
    }
}