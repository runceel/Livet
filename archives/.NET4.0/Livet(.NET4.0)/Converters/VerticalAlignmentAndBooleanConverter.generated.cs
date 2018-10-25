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
    /// VerticalAlignment列挙体とbool値の相互変換を行うIValueConverterです。
    /// </summary>
    public class VerticalAlignmentAndBooleanConverter : IValueConverter
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
        private VerticalAlignment _convertWhenTrue;
		/// <summary>
        /// ソース値がTrueの際にどのVerticalAlignment列挙体メンバーに変換するかを指定、または取得します。
        /// </summary>
        public VerticalAlignment ConvertWhenTrue
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
        private VerticalAlignment _convertWhenFalse;
		/// <summary>
        /// ソース値がFalseの際にどのVerticalAlignment列挙体メンバーに変換するかを指定、または取得します。
        /// </summary>
        public VerticalAlignment ConvertWhenFalse
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
            if (!(value is VerticalAlignment)) throw new ArgumentException();

            var enumValue = (VerticalAlignment)value;

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
				case "Stretch":
					if (_isConvertBackWhenStretchSet)
					{
						return ConvertBackWhenStretch;
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
        /// VerticalAlignmentの値をbool値に変換する際のデフォルト値を指定、または取得します。
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
        /// VerticalAlignmentの値がTopの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
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
        /// VerticalAlignmentの値がCenterの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
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
        /// VerticalAlignmentの値がBottomの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
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
        private bool _isConvertBackWhenStretchSet;
        private bool _convertBackWhenStretch;
		/// <summary>
        /// VerticalAlignmentの値がStretchの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenStretch
        {
            get
            {
                return _convertBackWhenStretch;
            }
            set
            {
                _convertBackWhenStretch = value;
                _isConvertBackWhenStretchSet = true;
            }
        }
    }
}