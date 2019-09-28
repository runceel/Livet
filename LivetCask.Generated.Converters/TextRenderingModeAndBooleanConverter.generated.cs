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
    /// TextRenderingMode列挙体とbool値の相互変換を行うIValueConverterです。
    /// </summary>
    public class TextRenderingModeAndBooleanConverter : IValueConverter
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
        private TextRenderingMode _convertWhenTrue;
		/// <summary>
        /// ソース値がTrueの際にどのTextRenderingMode列挙体メンバーに変換するかを指定、または取得します。
        /// </summary>
        public TextRenderingMode ConvertWhenTrue
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
        private TextRenderingMode _convertWhenFalse;
		/// <summary>
        /// ソース値がFalseの際にどのTextRenderingMode列挙体メンバーに変換するかを指定、または取得します。
        /// </summary>
        public TextRenderingMode ConvertWhenFalse
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
            if (!(value is TextRenderingMode)) throw new ArgumentException();

            var enumValue = (TextRenderingMode)value;

			switch(enumValue.ToString())
			{
				case "Auto":
					if (_isConvertBackWhenAutoSet)
					{
						return ConvertBackWhenAuto;
					}
					break;
				case "Aliased":
					if (_isConvertBackWhenAliasedSet)
					{
						return ConvertBackWhenAliased;
					}
					break;
				case "Grayscale":
					if (_isConvertBackWhenGrayscaleSet)
					{
						return ConvertBackWhenGrayscale;
					}
					break;
				case "ClearType":
					if (_isConvertBackWhenClearTypeSet)
					{
						return ConvertBackWhenClearType;
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
        /// TextRenderingModeの値をbool値に変換する際のデフォルト値を指定、または取得します。
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

        private bool _isConvertBackWhenAutoSet;
        private bool _convertBackWhenAuto;
		/// <summary>
        /// TextRenderingModeの値がAutoの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenAuto
        {
            get
            {
                return _convertBackWhenAuto;
            }
            set
            {
                _convertBackWhenAuto = value;
                _isConvertBackWhenAutoSet = true;
            }
        }
        private bool _isConvertBackWhenAliasedSet;
        private bool _convertBackWhenAliased;
		/// <summary>
        /// TextRenderingModeの値がAliasedの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenAliased
        {
            get
            {
                return _convertBackWhenAliased;
            }
            set
            {
                _convertBackWhenAliased = value;
                _isConvertBackWhenAliasedSet = true;
            }
        }
        private bool _isConvertBackWhenGrayscaleSet;
        private bool _convertBackWhenGrayscale;
		/// <summary>
        /// TextRenderingModeの値がGrayscaleの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenGrayscale
        {
            get
            {
                return _convertBackWhenGrayscale;
            }
            set
            {
                _convertBackWhenGrayscale = value;
                _isConvertBackWhenGrayscaleSet = true;
            }
        }
        private bool _isConvertBackWhenClearTypeSet;
        private bool _convertBackWhenClearType;
		/// <summary>
        /// TextRenderingModeの値がClearTypeの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenClearType
        {
            get
            {
                return _convertBackWhenClearType;
            }
            set
            {
                _convertBackWhenClearType = value;
                _isConvertBackWhenClearTypeSet = true;
            }
        }
    }
}