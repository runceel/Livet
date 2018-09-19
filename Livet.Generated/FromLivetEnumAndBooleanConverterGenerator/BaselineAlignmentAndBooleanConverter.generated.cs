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
    /// BaselineAlignment列挙体とbool値の相互変換を行うIValueConverterです。
    /// </summary>
    public class BaselineAlignmentAndBooleanConverter : IValueConverter
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
        private BaselineAlignment _convertWhenTrue;
		/// <summary>
        /// ソース値がTrueの際にどのBaselineAlignment列挙体メンバーに変換するかを指定、または取得します。
        /// </summary>
        public BaselineAlignment ConvertWhenTrue
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
        private BaselineAlignment _convertWhenFalse;
		/// <summary>
        /// ソース値がFalseの際にどのBaselineAlignment列挙体メンバーに変換するかを指定、または取得します。
        /// </summary>
        public BaselineAlignment ConvertWhenFalse
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
            if (!(value is BaselineAlignment)) throw new ArgumentException();

            var enumValue = (BaselineAlignment)value;

			switch(enumValue.ToString())
			{
				case "Top":
					if (_isConvertBackWhenTopSet)
					{
						return ConvertBackWhenTop;
					}
					break;
				case "Center":
					if (_isConvertBackWhenCenterSet)
					{
						return ConvertBackWhenCenter;
					}
					break;
				case "Bottom":
					if (_isConvertBackWhenBottomSet)
					{
						return ConvertBackWhenBottom;
					}
					break;
				case "Baseline":
					if (_isConvertBackWhenBaselineSet)
					{
						return ConvertBackWhenBaseline;
					}
					break;
				case "TextTop":
					if (_isConvertBackWhenTextTopSet)
					{
						return ConvertBackWhenTextTop;
					}
					break;
				case "TextBottom":
					if (_isConvertBackWhenTextBottomSet)
					{
						return ConvertBackWhenTextBottom;
					}
					break;
				case "Subscript":
					if (_isConvertBackWhenSubscriptSet)
					{
						return ConvertBackWhenSubscript;
					}
					break;
				case "Superscript":
					if (_isConvertBackWhenSuperscriptSet)
					{
						return ConvertBackWhenSuperscript;
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
        /// BaselineAlignmentの値をbool値に変換する際のデフォルト値を指定、または取得します。
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

        private bool _isConvertBackWhenTopSet;
        private bool _convertBackWhenTop;
		/// <summary>
        /// BaselineAlignmentの値がTopの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenTop
        {
            get
            {
                return _convertBackWhenTop;
            }
            set
            {
                _convertBackWhenTop = value;
                _isConvertBackWhenTopSet = true;
            }
        }
        private bool _isConvertBackWhenCenterSet;
        private bool _convertBackWhenCenter;
		/// <summary>
        /// BaselineAlignmentの値がCenterの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenCenter
        {
            get
            {
                return _convertBackWhenCenter;
            }
            set
            {
                _convertBackWhenCenter = value;
                _isConvertBackWhenCenterSet = true;
            }
        }
        private bool _isConvertBackWhenBottomSet;
        private bool _convertBackWhenBottom;
		/// <summary>
        /// BaselineAlignmentの値がBottomの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenBottom
        {
            get
            {
                return _convertBackWhenBottom;
            }
            set
            {
                _convertBackWhenBottom = value;
                _isConvertBackWhenBottomSet = true;
            }
        }
        private bool _isConvertBackWhenBaselineSet;
        private bool _convertBackWhenBaseline;
		/// <summary>
        /// BaselineAlignmentの値がBaselineの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
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
        private bool _isConvertBackWhenTextTopSet;
        private bool _convertBackWhenTextTop;
		/// <summary>
        /// BaselineAlignmentの値がTextTopの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenTextTop
        {
            get
            {
                return _convertBackWhenTextTop;
            }
            set
            {
                _convertBackWhenTextTop = value;
                _isConvertBackWhenTextTopSet = true;
            }
        }
        private bool _isConvertBackWhenTextBottomSet;
        private bool _convertBackWhenTextBottom;
		/// <summary>
        /// BaselineAlignmentの値がTextBottomの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenTextBottom
        {
            get
            {
                return _convertBackWhenTextBottom;
            }
            set
            {
                _convertBackWhenTextBottom = value;
                _isConvertBackWhenTextBottomSet = true;
            }
        }
        private bool _isConvertBackWhenSubscriptSet;
        private bool _convertBackWhenSubscript;
		/// <summary>
        /// BaselineAlignmentの値がSubscriptの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
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
        private bool _isConvertBackWhenSuperscriptSet;
        private bool _convertBackWhenSuperscript;
		/// <summary>
        /// BaselineAlignmentの値がSuperscriptの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
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
    }
}