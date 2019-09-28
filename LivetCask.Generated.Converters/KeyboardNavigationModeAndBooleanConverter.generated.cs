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
    /// KeyboardNavigationMode列挙体とbool値の相互変換を行うIValueConverterです。
    /// </summary>
    public class KeyboardNavigationModeAndBooleanConverter : IValueConverter
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
        private KeyboardNavigationMode _convertWhenTrue;
		/// <summary>
        /// ソース値がTrueの際にどのKeyboardNavigationMode列挙体メンバーに変換するかを指定、または取得します。
        /// </summary>
        public KeyboardNavigationMode ConvertWhenTrue
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
        private KeyboardNavigationMode _convertWhenFalse;
		/// <summary>
        /// ソース値がFalseの際にどのKeyboardNavigationMode列挙体メンバーに変換するかを指定、または取得します。
        /// </summary>
        public KeyboardNavigationMode ConvertWhenFalse
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
            if (!(value is KeyboardNavigationMode)) throw new ArgumentException();

            var enumValue = (KeyboardNavigationMode)value;

			switch(enumValue.ToString())
			{
				case "Continue":
					if (_isConvertBackWhenContinueSet)
					{
						return ConvertBackWhenContinue;
					}
					break;
				case "Once":
					if (_isConvertBackWhenOnceSet)
					{
						return ConvertBackWhenOnce;
					}
					break;
				case "Cycle":
					if (_isConvertBackWhenCycleSet)
					{
						return ConvertBackWhenCycle;
					}
					break;
				case "None":
					if (_isConvertBackWhenNoneSet)
					{
						return ConvertBackWhenNone;
					}
					break;
				case "Contained":
					if (_isConvertBackWhenContainedSet)
					{
						return ConvertBackWhenContained;
					}
					break;
				case "Local":
					if (_isConvertBackWhenLocalSet)
					{
						return ConvertBackWhenLocal;
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
        /// KeyboardNavigationModeの値をbool値に変換する際のデフォルト値を指定、または取得します。
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

        private bool _isConvertBackWhenContinueSet;
        private bool _convertBackWhenContinue;
		/// <summary>
        /// KeyboardNavigationModeの値がContinueの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenContinue
        {
            get
            {
                return _convertBackWhenContinue;
            }
            set
            {
                _convertBackWhenContinue = value;
                _isConvertBackWhenContinueSet = true;
            }
        }
        private bool _isConvertBackWhenOnceSet;
        private bool _convertBackWhenOnce;
		/// <summary>
        /// KeyboardNavigationModeの値がOnceの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenOnce
        {
            get
            {
                return _convertBackWhenOnce;
            }
            set
            {
                _convertBackWhenOnce = value;
                _isConvertBackWhenOnceSet = true;
            }
        }
        private bool _isConvertBackWhenCycleSet;
        private bool _convertBackWhenCycle;
		/// <summary>
        /// KeyboardNavigationModeの値がCycleの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenCycle
        {
            get
            {
                return _convertBackWhenCycle;
            }
            set
            {
                _convertBackWhenCycle = value;
                _isConvertBackWhenCycleSet = true;
            }
        }
        private bool _isConvertBackWhenNoneSet;
        private bool _convertBackWhenNone;
		/// <summary>
        /// KeyboardNavigationModeの値がNoneの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
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
        private bool _isConvertBackWhenContainedSet;
        private bool _convertBackWhenContained;
		/// <summary>
        /// KeyboardNavigationModeの値がContainedの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenContained
        {
            get
            {
                return _convertBackWhenContained;
            }
            set
            {
                _convertBackWhenContained = value;
                _isConvertBackWhenContainedSet = true;
            }
        }
        private bool _isConvertBackWhenLocalSet;
        private bool _convertBackWhenLocal;
		/// <summary>
        /// KeyboardNavigationModeの値がLocalの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenLocal
        {
            get
            {
                return _convertBackWhenLocal;
            }
            set
            {
                _convertBackWhenLocal = value;
                _isConvertBackWhenLocalSet = true;
            }
        }
    }
}