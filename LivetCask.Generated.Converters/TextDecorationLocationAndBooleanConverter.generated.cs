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
    /// TextDecorationLocation列挙体とbool値の相互変換を行うIValueConverterです。
    /// </summary>
    public class TextDecorationLocationAndBooleanConverter : IValueConverter
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
        private TextDecorationLocation _convertWhenTrue;
		/// <summary>
        /// ソース値がTrueの際にどのTextDecorationLocation列挙体メンバーに変換するかを指定、または取得します。
        /// </summary>
        public TextDecorationLocation ConvertWhenTrue
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
        private TextDecorationLocation _convertWhenFalse;
		/// <summary>
        /// ソース値がFalseの際にどのTextDecorationLocation列挙体メンバーに変換するかを指定、または取得します。
        /// </summary>
        public TextDecorationLocation ConvertWhenFalse
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
            if (!(value is TextDecorationLocation)) throw new ArgumentException();

            var enumValue = (TextDecorationLocation)value;

			switch(enumValue.ToString())
			{
				case "Underline":
					if (_isConvertBackWhenUnderlineSet)
					{
						return ConvertBackWhenUnderline;
					}
					break;
				case "OverLine":
					if (_isConvertBackWhenOverLineSet)
					{
						return ConvertBackWhenOverLine;
					}
					break;
				case "Strikethrough":
					if (_isConvertBackWhenStrikethroughSet)
					{
						return ConvertBackWhenStrikethrough;
					}
					break;
				case "Baseline":
					if (_isConvertBackWhenBaselineSet)
					{
						return ConvertBackWhenBaseline;
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
        /// TextDecorationLocationの値をbool値に変換する際のデフォルト値を指定、または取得します。
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

        private bool _isConvertBackWhenUnderlineSet;
        private bool _convertBackWhenUnderline;
		/// <summary>
        /// TextDecorationLocationの値がUnderlineの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenUnderline
        {
            get
            {
                return _convertBackWhenUnderline;
            }
            set
            {
                _convertBackWhenUnderline = value;
                _isConvertBackWhenUnderlineSet = true;
            }
        }
        private bool _isConvertBackWhenOverLineSet;
        private bool _convertBackWhenOverLine;
		/// <summary>
        /// TextDecorationLocationの値がOverLineの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenOverLine
        {
            get
            {
                return _convertBackWhenOverLine;
            }
            set
            {
                _convertBackWhenOverLine = value;
                _isConvertBackWhenOverLineSet = true;
            }
        }
        private bool _isConvertBackWhenStrikethroughSet;
        private bool _convertBackWhenStrikethrough;
		/// <summary>
        /// TextDecorationLocationの値がStrikethroughの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenStrikethrough
        {
            get
            {
                return _convertBackWhenStrikethrough;
            }
            set
            {
                _convertBackWhenStrikethrough = value;
                _isConvertBackWhenStrikethroughSet = true;
            }
        }
        private bool _isConvertBackWhenBaselineSet;
        private bool _convertBackWhenBaseline;
		/// <summary>
        /// TextDecorationLocationの値がBaselineの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenBaseline
        {
            get
            {
                return _convertBackWhenBaseline;
            }
            set
            {
                _convertBackWhenBaseline = value;
                _isConvertBackWhenBaselineSet = true;
            }
        }
    }
}