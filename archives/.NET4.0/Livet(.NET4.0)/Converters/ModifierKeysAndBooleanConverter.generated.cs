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
    /// ModifierKeys列挙体とbool値の相互変換を行うIValueConverterです。
    /// </summary>
    public class ModifierKeysAndBooleanConverter : IValueConverter
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
        private ModifierKeys _convertWhenTrue;
		/// <summary>
        /// ソース値がTrueの際にどのModifierKeys列挙体メンバーに変換するかを指定、または取得します。
        /// </summary>
        public ModifierKeys ConvertWhenTrue
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
        private ModifierKeys _convertWhenFalse;
		/// <summary>
        /// ソース値がFalseの際にどのModifierKeys列挙体メンバーに変換するかを指定、または取得します。
        /// </summary>
        public ModifierKeys ConvertWhenFalse
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
            if (!(value is ModifierKeys)) throw new ArgumentException();

            var enumValue = (ModifierKeys)value;

			switch(enumValue.ToString())
			{
				case "None":
					if (_isConvertBackWhenNoneSet)
					{
						return ConvertBackWhenNone;
					}
					break;
				case "Alt":
					if (_isConvertBackWhenAltSet)
					{
						return ConvertBackWhenAlt;
					}
					break;
				case "Control":
					if (_isConvertBackWhenControlSet)
					{
						return ConvertBackWhenControl;
					}
					break;
				case "Shift":
					if (_isConvertBackWhenShiftSet)
					{
						return ConvertBackWhenShift;
					}
					break;
				case "Windows":
					if (_isConvertBackWhenWindowsSet)
					{
						return ConvertBackWhenWindows;
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
        /// ModifierKeysの値をbool値に変換する際のデフォルト値を指定、または取得します。
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
        /// ModifierKeysの値がNoneの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
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
        private bool _isConvertBackWhenAltSet;
        private bool _convertBackWhenAlt;
		/// <summary>
        /// ModifierKeysの値がAltの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenAlt
        {
            get
            {
                return _convertBackWhenAlt;
            }
            set
            {
                _convertBackWhenAlt = value;
                _isConvertBackWhenAltSet = true;
            }
        }
        private bool _isConvertBackWhenControlSet;
        private bool _convertBackWhenControl;
		/// <summary>
        /// ModifierKeysの値がControlの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenControl
        {
            get
            {
                return _convertBackWhenControl;
            }
            set
            {
                _convertBackWhenControl = value;
                _isConvertBackWhenControlSet = true;
            }
        }
        private bool _isConvertBackWhenShiftSet;
        private bool _convertBackWhenShift;
		/// <summary>
        /// ModifierKeysの値がShiftの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenShift
        {
            get
            {
                return _convertBackWhenShift;
            }
            set
            {
                _convertBackWhenShift = value;
                _isConvertBackWhenShiftSet = true;
            }
        }
        private bool _isConvertBackWhenWindowsSet;
        private bool _convertBackWhenWindows;
		/// <summary>
        /// ModifierKeysの値がWindowsの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenWindows
        {
            get
            {
                return _convertBackWhenWindows;
            }
            set
            {
                _convertBackWhenWindows = value;
                _isConvertBackWhenWindowsSet = true;
            }
        }
    }
}