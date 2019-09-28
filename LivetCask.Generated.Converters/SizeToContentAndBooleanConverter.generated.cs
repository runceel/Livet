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
    /// SizeToContent列挙体とbool値の相互変換を行うIValueConverterです。
    /// </summary>
    public class SizeToContentAndBooleanConverter : IValueConverter
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
        private SizeToContent _convertWhenTrue;
		/// <summary>
        /// ソース値がTrueの際にどのSizeToContent列挙体メンバーに変換するかを指定、または取得します。
        /// </summary>
        public SizeToContent ConvertWhenTrue
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
        private SizeToContent _convertWhenFalse;
		/// <summary>
        /// ソース値がFalseの際にどのSizeToContent列挙体メンバーに変換するかを指定、または取得します。
        /// </summary>
        public SizeToContent ConvertWhenFalse
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
            if (!(value is SizeToContent)) throw new ArgumentException();

            var enumValue = (SizeToContent)value;

			switch(enumValue.ToString())
			{
				case "Manual":
					if (_isConvertBackWhenManualSet)
					{
						return ConvertBackWhenManual;
					}
					break;
				case "Width":
					if (_isConvertBackWhenWidthSet)
					{
						return ConvertBackWhenWidth;
					}
					break;
				case "Height":
					if (_isConvertBackWhenHeightSet)
					{
						return ConvertBackWhenHeight;
					}
					break;
				case "WidthAndHeight":
					if (_isConvertBackWhenWidthAndHeightSet)
					{
						return ConvertBackWhenWidthAndHeight;
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
        /// SizeToContentの値をbool値に変換する際のデフォルト値を指定、または取得します。
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

        private bool _isConvertBackWhenManualSet;
        private bool _convertBackWhenManual;
		/// <summary>
        /// SizeToContentの値がManualの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenManual
        {
            get
            {
                return _convertBackWhenManual;
            }
            set
            {
                _convertBackWhenManual = value;
                _isConvertBackWhenManualSet = true;
            }
        }
        private bool _isConvertBackWhenWidthSet;
        private bool _convertBackWhenWidth;
		/// <summary>
        /// SizeToContentの値がWidthの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenWidth
        {
            get
            {
                return _convertBackWhenWidth;
            }
            set
            {
                _convertBackWhenWidth = value;
                _isConvertBackWhenWidthSet = true;
            }
        }
        private bool _isConvertBackWhenHeightSet;
        private bool _convertBackWhenHeight;
		/// <summary>
        /// SizeToContentの値がHeightの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenHeight
        {
            get
            {
                return _convertBackWhenHeight;
            }
            set
            {
                _convertBackWhenHeight = value;
                _isConvertBackWhenHeightSet = true;
            }
        }
        private bool _isConvertBackWhenWidthAndHeightSet;
        private bool _convertBackWhenWidthAndHeight;
		/// <summary>
        /// SizeToContentの値がWidthAndHeightの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenWidthAndHeight
        {
            get
            {
                return _convertBackWhenWidthAndHeight;
            }
            set
            {
                _convertBackWhenWidthAndHeight = value;
                _isConvertBackWhenWidthAndHeightSet = true;
            }
        }
    }
}