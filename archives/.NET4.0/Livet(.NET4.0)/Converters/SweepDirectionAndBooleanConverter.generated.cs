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
    /// SweepDirection列挙体とbool値の相互変換を行うIValueConverterです。
    /// </summary>
    public class SweepDirectionAndBooleanConverter : IValueConverter
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
        private SweepDirection _convertWhenTrue;
		/// <summary>
        /// ソース値がTrueの際にどのSweepDirection列挙体メンバーに変換するかを指定、または取得します。
        /// </summary>
        public SweepDirection ConvertWhenTrue
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
        private SweepDirection _convertWhenFalse;
		/// <summary>
        /// ソース値がFalseの際にどのSweepDirection列挙体メンバーに変換するかを指定、または取得します。
        /// </summary>
        public SweepDirection ConvertWhenFalse
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
            if (!(value is SweepDirection)) throw new ArgumentException();

            var enumValue = (SweepDirection)value;

			switch(enumValue.ToString())
			{
				case "Counterclockwise":
					if (_isConvertBackWhenCounterclockwiseSet)
					{
						return ConvertBackWhenCounterclockwise;
					}
					break;
				case "Clockwise":
					if (_isConvertBackWhenClockwiseSet)
					{
						return ConvertBackWhenClockwise;
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
        /// SweepDirectionの値をbool値に変換する際のデフォルト値を指定、または取得します。
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

        private bool _isConvertBackWhenCounterclockwiseSet;
        private bool _convertBackWhenCounterclockwise;
		/// <summary>
        /// SweepDirectionの値がCounterclockwiseの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenCounterclockwise
        {
            get
            {
                return _convertBackWhenCounterclockwise;
            }
            set
            {
                _convertBackWhenCounterclockwise = value;
                _isConvertBackWhenCounterclockwiseSet = true;
            }
        }
        private bool _isConvertBackWhenClockwiseSet;
        private bool _convertBackWhenClockwise;
		/// <summary>
        /// SweepDirectionの値がClockwiseの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenClockwise
        {
            get
            {
                return _convertBackWhenClockwise;
            }
            set
            {
                _convertBackWhenClockwise = value;
                _isConvertBackWhenClockwiseSet = true;
            }
        }
    }
}