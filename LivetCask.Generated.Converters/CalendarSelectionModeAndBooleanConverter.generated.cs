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
    /// CalendarSelectionMode列挙体とbool値の相互変換を行うIValueConverterです。
    /// </summary>
    public class CalendarSelectionModeAndBooleanConverter : IValueConverter
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
        private CalendarSelectionMode _convertWhenTrue;
		/// <summary>
        /// ソース値がTrueの際にどのCalendarSelectionMode列挙体メンバーに変換するかを指定、または取得します。
        /// </summary>
        public CalendarSelectionMode ConvertWhenTrue
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
        private CalendarSelectionMode _convertWhenFalse;
		/// <summary>
        /// ソース値がFalseの際にどのCalendarSelectionMode列挙体メンバーに変換するかを指定、または取得します。
        /// </summary>
        public CalendarSelectionMode ConvertWhenFalse
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
            if (!(value is CalendarSelectionMode)) throw new ArgumentException();

            var enumValue = (CalendarSelectionMode)value;

			switch(enumValue.ToString())
			{
				case "SingleDate":
					if (_isConvertBackWhenSingleDateSet)
					{
						return ConvertBackWhenSingleDate;
					}
					break;
				case "SingleRange":
					if (_isConvertBackWhenSingleRangeSet)
					{
						return ConvertBackWhenSingleRange;
					}
					break;
				case "MultipleRange":
					if (_isConvertBackWhenMultipleRangeSet)
					{
						return ConvertBackWhenMultipleRange;
					}
					break;
				case "None":
					if (_isConvertBackWhenNoneSet)
					{
						return ConvertBackWhenNone;
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
        /// CalendarSelectionModeの値をbool値に変換する際のデフォルト値を指定、または取得します。
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

        private bool _isConvertBackWhenSingleDateSet;
        private bool _convertBackWhenSingleDate;
		/// <summary>
        /// CalendarSelectionModeの値がSingleDateの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenSingleDate
        {
            get
            {
                return _convertBackWhenSingleDate;
            }
            set
            {
                _convertBackWhenSingleDate = value;
                _isConvertBackWhenSingleDateSet = true;
            }
        }
        private bool _isConvertBackWhenSingleRangeSet;
        private bool _convertBackWhenSingleRange;
		/// <summary>
        /// CalendarSelectionModeの値がSingleRangeの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenSingleRange
        {
            get
            {
                return _convertBackWhenSingleRange;
            }
            set
            {
                _convertBackWhenSingleRange = value;
                _isConvertBackWhenSingleRangeSet = true;
            }
        }
        private bool _isConvertBackWhenMultipleRangeSet;
        private bool _convertBackWhenMultipleRange;
		/// <summary>
        /// CalendarSelectionModeの値がMultipleRangeの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenMultipleRange
        {
            get
            {
                return _convertBackWhenMultipleRange;
            }
            set
            {
                _convertBackWhenMultipleRange = value;
                _isConvertBackWhenMultipleRangeSet = true;
            }
        }
        private bool _isConvertBackWhenNoneSet;
        private bool _convertBackWhenNone;
		/// <summary>
        /// CalendarSelectionModeの値がNoneの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
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
    }
}