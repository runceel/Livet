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
    /// TextMarkerStyle列挙体とbool値の相互変換を行うIValueConverterです。
    /// </summary>
    public class TextMarkerStyleAndBooleanConverter : IValueConverter
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
        private TextMarkerStyle _convertWhenTrue;
		/// <summary>
        /// ソース値がTrueの際にどのTextMarkerStyle列挙体メンバーに変換するかを指定、または取得します。
        /// </summary>
        public TextMarkerStyle ConvertWhenTrue
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
        private TextMarkerStyle _convertWhenFalse;
		/// <summary>
        /// ソース値がFalseの際にどのTextMarkerStyle列挙体メンバーに変換するかを指定、または取得します。
        /// </summary>
        public TextMarkerStyle ConvertWhenFalse
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
            if (!(value is TextMarkerStyle)) throw new ArgumentException();

            var enumValue = (TextMarkerStyle)value;

			switch(enumValue.ToString())
			{
				case "None":
					if (_isConvertBackWhenNoneSet)
					{
						return ConvertBackWhenNone;
					}
					break;
				case "Disc":
					if (_isConvertBackWhenDiscSet)
					{
						return ConvertBackWhenDisc;
					}
					break;
				case "Circle":
					if (_isConvertBackWhenCircleSet)
					{
						return ConvertBackWhenCircle;
					}
					break;
				case "Square":
					if (_isConvertBackWhenSquareSet)
					{
						return ConvertBackWhenSquare;
					}
					break;
				case "Box":
					if (_isConvertBackWhenBoxSet)
					{
						return ConvertBackWhenBox;
					}
					break;
				case "LowerRoman":
					if (_isConvertBackWhenLowerRomanSet)
					{
						return ConvertBackWhenLowerRoman;
					}
					break;
				case "UpperRoman":
					if (_isConvertBackWhenUpperRomanSet)
					{
						return ConvertBackWhenUpperRoman;
					}
					break;
				case "LowerLatin":
					if (_isConvertBackWhenLowerLatinSet)
					{
						return ConvertBackWhenLowerLatin;
					}
					break;
				case "UpperLatin":
					if (_isConvertBackWhenUpperLatinSet)
					{
						return ConvertBackWhenUpperLatin;
					}
					break;
				case "Decimal":
					if (_isConvertBackWhenDecimalSet)
					{
						return ConvertBackWhenDecimal;
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
        /// TextMarkerStyleの値をbool値に変換する際のデフォルト値を指定、または取得します。
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
        /// TextMarkerStyleの値がNoneの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
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
        private bool _isConvertBackWhenDiscSet;
        private bool _convertBackWhenDisc;
		/// <summary>
        /// TextMarkerStyleの値がDiscの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenDisc
        {
            get
            {
                return _convertBackWhenDisc;
            }
            set
            {
                _convertBackWhenDisc = value;
                _isConvertBackWhenDiscSet = true;
            }
        }
        private bool _isConvertBackWhenCircleSet;
        private bool _convertBackWhenCircle;
		/// <summary>
        /// TextMarkerStyleの値がCircleの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenCircle
        {
            get
            {
                return _convertBackWhenCircle;
            }
            set
            {
                _convertBackWhenCircle = value;
                _isConvertBackWhenCircleSet = true;
            }
        }
        private bool _isConvertBackWhenSquareSet;
        private bool _convertBackWhenSquare;
		/// <summary>
        /// TextMarkerStyleの値がSquareの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenSquare
        {
            get
            {
                return _convertBackWhenSquare;
            }
            set
            {
                _convertBackWhenSquare = value;
                _isConvertBackWhenSquareSet = true;
            }
        }
        private bool _isConvertBackWhenBoxSet;
        private bool _convertBackWhenBox;
		/// <summary>
        /// TextMarkerStyleの値がBoxの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenBox
        {
            get
            {
                return _convertBackWhenBox;
            }
            set
            {
                _convertBackWhenBox = value;
                _isConvertBackWhenBoxSet = true;
            }
        }
        private bool _isConvertBackWhenLowerRomanSet;
        private bool _convertBackWhenLowerRoman;
		/// <summary>
        /// TextMarkerStyleの値がLowerRomanの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenLowerRoman
        {
            get
            {
                return _convertBackWhenLowerRoman;
            }
            set
            {
                _convertBackWhenLowerRoman = value;
                _isConvertBackWhenLowerRomanSet = true;
            }
        }
        private bool _isConvertBackWhenUpperRomanSet;
        private bool _convertBackWhenUpperRoman;
		/// <summary>
        /// TextMarkerStyleの値がUpperRomanの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenUpperRoman
        {
            get
            {
                return _convertBackWhenUpperRoman;
            }
            set
            {
                _convertBackWhenUpperRoman = value;
                _isConvertBackWhenUpperRomanSet = true;
            }
        }
        private bool _isConvertBackWhenLowerLatinSet;
        private bool _convertBackWhenLowerLatin;
		/// <summary>
        /// TextMarkerStyleの値がLowerLatinの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenLowerLatin
        {
            get
            {
                return _convertBackWhenLowerLatin;
            }
            set
            {
                _convertBackWhenLowerLatin = value;
                _isConvertBackWhenLowerLatinSet = true;
            }
        }
        private bool _isConvertBackWhenUpperLatinSet;
        private bool _convertBackWhenUpperLatin;
		/// <summary>
        /// TextMarkerStyleの値がUpperLatinの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenUpperLatin
        {
            get
            {
                return _convertBackWhenUpperLatin;
            }
            set
            {
                _convertBackWhenUpperLatin = value;
                _isConvertBackWhenUpperLatinSet = true;
            }
        }
        private bool _isConvertBackWhenDecimalSet;
        private bool _convertBackWhenDecimal;
		/// <summary>
        /// TextMarkerStyleの値がDecimalの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenDecimal
        {
            get
            {
                return _convertBackWhenDecimal;
            }
            set
            {
                _convertBackWhenDecimal = value;
                _isConvertBackWhenDecimalSet = true;
            }
        }
    }
}