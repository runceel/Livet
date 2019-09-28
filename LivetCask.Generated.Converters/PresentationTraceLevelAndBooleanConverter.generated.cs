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
    /// PresentationTraceLevel列挙体とbool値の相互変換を行うIValueConverterです。
    /// </summary>
    public class PresentationTraceLevelAndBooleanConverter : IValueConverter
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
        private PresentationTraceLevel _convertWhenTrue;
		/// <summary>
        /// ソース値がTrueの際にどのPresentationTraceLevel列挙体メンバーに変換するかを指定、または取得します。
        /// </summary>
        public PresentationTraceLevel ConvertWhenTrue
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
        private PresentationTraceLevel _convertWhenFalse;
		/// <summary>
        /// ソース値がFalseの際にどのPresentationTraceLevel列挙体メンバーに変換するかを指定、または取得します。
        /// </summary>
        public PresentationTraceLevel ConvertWhenFalse
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
            if (!(value is PresentationTraceLevel)) throw new ArgumentException();

            var enumValue = (PresentationTraceLevel)value;

			switch(enumValue.ToString())
			{
				case "None":
					if (_isConvertBackWhenNoneSet)
					{
						return ConvertBackWhenNone;
					}
					break;
				case "Low":
					if (_isConvertBackWhenLowSet)
					{
						return ConvertBackWhenLow;
					}
					break;
				case "Medium":
					if (_isConvertBackWhenMediumSet)
					{
						return ConvertBackWhenMedium;
					}
					break;
				case "High":
					if (_isConvertBackWhenHighSet)
					{
						return ConvertBackWhenHigh;
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
        /// PresentationTraceLevelの値をbool値に変換する際のデフォルト値を指定、または取得します。
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
        /// PresentationTraceLevelの値がNoneの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
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
        private bool _isConvertBackWhenLowSet;
        private bool _convertBackWhenLow;
		/// <summary>
        /// PresentationTraceLevelの値がLowの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenLow
        {
            get
            {
                return _convertBackWhenLow;
            }
            set
            {
                _convertBackWhenLow = value;
                _isConvertBackWhenLowSet = true;
            }
        }
        private bool _isConvertBackWhenMediumSet;
        private bool _convertBackWhenMedium;
		/// <summary>
        /// PresentationTraceLevelの値がMediumの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenMedium
        {
            get
            {
                return _convertBackWhenMedium;
            }
            set
            {
                _convertBackWhenMedium = value;
                _isConvertBackWhenMediumSet = true;
            }
        }
        private bool _isConvertBackWhenHighSet;
        private bool _convertBackWhenHigh;
		/// <summary>
        /// PresentationTraceLevelの値がHighの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenHigh
        {
            get
            {
                return _convertBackWhenHigh;
            }
            set
            {
                _convertBackWhenHigh = value;
                _isConvertBackWhenHighSet = true;
            }
        }
    }
}