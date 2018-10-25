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
    /// FontCapitals列挙体とbool値の相互変換を行うIValueConverterです。
    /// </summary>
    public class FontCapitalsAndBooleanConverter : IValueConverter
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
        private FontCapitals _convertWhenTrue;
		/// <summary>
        /// ソース値がTrueの際にどのFontCapitals列挙体メンバーに変換するかを指定、または取得します。
        /// </summary>
        public FontCapitals ConvertWhenTrue
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
        private FontCapitals _convertWhenFalse;
		/// <summary>
        /// ソース値がFalseの際にどのFontCapitals列挙体メンバーに変換するかを指定、または取得します。
        /// </summary>
        public FontCapitals ConvertWhenFalse
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
            if (!(value is FontCapitals)) throw new ArgumentException();

            var enumValue = (FontCapitals)value;

			switch(enumValue.ToString())
			{
				case "Normal":
					if (_isConvertBackWhenNormalSet)
					{
						return ConvertBackWhenNormal;
					}
					break;
				case "AllSmallCaps":
					if (_isConvertBackWhenAllSmallCapsSet)
					{
						return ConvertBackWhenAllSmallCaps;
					}
					break;
				case "SmallCaps":
					if (_isConvertBackWhenSmallCapsSet)
					{
						return ConvertBackWhenSmallCaps;
					}
					break;
				case "AllPetiteCaps":
					if (_isConvertBackWhenAllPetiteCapsSet)
					{
						return ConvertBackWhenAllPetiteCaps;
					}
					break;
				case "PetiteCaps":
					if (_isConvertBackWhenPetiteCapsSet)
					{
						return ConvertBackWhenPetiteCaps;
					}
					break;
				case "Unicase":
					if (_isConvertBackWhenUnicaseSet)
					{
						return ConvertBackWhenUnicase;
					}
					break;
				case "Titling":
					if (_isConvertBackWhenTitlingSet)
					{
						return ConvertBackWhenTitling;
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
        /// FontCapitalsの値をbool値に変換する際のデフォルト値を指定、または取得します。
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
        /// FontCapitalsの値がNormalの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
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
        private bool _isConvertBackWhenAllSmallCapsSet;
        private bool _convertBackWhenAllSmallCaps;
		/// <summary>
        /// FontCapitalsの値がAllSmallCapsの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenAllSmallCaps
        {
            get
            {
                return _convertBackWhenAllSmallCaps;
            }
            set
            {
                _convertBackWhenAllSmallCaps = value;
                _isConvertBackWhenAllSmallCapsSet = true;
            }
        }
        private bool _isConvertBackWhenSmallCapsSet;
        private bool _convertBackWhenSmallCaps;
		/// <summary>
        /// FontCapitalsの値がSmallCapsの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenSmallCaps
        {
            get
            {
                return _convertBackWhenSmallCaps;
            }
            set
            {
                _convertBackWhenSmallCaps = value;
                _isConvertBackWhenSmallCapsSet = true;
            }
        }
        private bool _isConvertBackWhenAllPetiteCapsSet;
        private bool _convertBackWhenAllPetiteCaps;
		/// <summary>
        /// FontCapitalsの値がAllPetiteCapsの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenAllPetiteCaps
        {
            get
            {
                return _convertBackWhenAllPetiteCaps;
            }
            set
            {
                _convertBackWhenAllPetiteCaps = value;
                _isConvertBackWhenAllPetiteCapsSet = true;
            }
        }
        private bool _isConvertBackWhenPetiteCapsSet;
        private bool _convertBackWhenPetiteCaps;
		/// <summary>
        /// FontCapitalsの値がPetiteCapsの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenPetiteCaps
        {
            get
            {
                return _convertBackWhenPetiteCaps;
            }
            set
            {
                _convertBackWhenPetiteCaps = value;
                _isConvertBackWhenPetiteCapsSet = true;
            }
        }
        private bool _isConvertBackWhenUnicaseSet;
        private bool _convertBackWhenUnicase;
		/// <summary>
        /// FontCapitalsの値がUnicaseの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenUnicase
        {
            get
            {
                return _convertBackWhenUnicase;
            }
            set
            {
                _convertBackWhenUnicase = value;
                _isConvertBackWhenUnicaseSet = true;
            }
        }
        private bool _isConvertBackWhenTitlingSet;
        private bool _convertBackWhenTitling;
		/// <summary>
        /// FontCapitalsの値がTitlingの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenTitling
        {
            get
            {
                return _convertBackWhenTitling;
            }
            set
            {
                _convertBackWhenTitling = value;
                _isConvertBackWhenTitlingSet = true;
            }
        }
    }
}