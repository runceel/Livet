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
    /// AuthenticationType列挙体とbool値の相互変換を行うIValueConverterです。
    /// </summary>
    public class AuthenticationTypeAndBooleanConverter : IValueConverter
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
        private AuthenticationType _convertWhenTrue;
		/// <summary>
        /// ソース値がTrueの際にどのAuthenticationType列挙体メンバーに変換するかを指定、または取得します。
        /// </summary>
        public AuthenticationType ConvertWhenTrue
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
        private AuthenticationType _convertWhenFalse;
		/// <summary>
        /// ソース値がFalseの際にどのAuthenticationType列挙体メンバーに変換するかを指定、または取得します。
        /// </summary>
        public AuthenticationType ConvertWhenFalse
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
            if (!(value is AuthenticationType)) throw new ArgumentException();

            var enumValue = (AuthenticationType)value;

			switch(enumValue.ToString())
			{
				case "Windows":
					if (_isConvertBackWhenWindowsSet)
					{
						return ConvertBackWhenWindows;
					}
					break;
				case "Passport":
					if (_isConvertBackWhenPassportSet)
					{
						return ConvertBackWhenPassport;
					}
					break;
				case "WindowsPassport":
					if (_isConvertBackWhenWindowsPassportSet)
					{
						return ConvertBackWhenWindowsPassport;
					}
					break;
				case "Internal":
					if (_isConvertBackWhenInternalSet)
					{
						return ConvertBackWhenInternal;
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
        /// AuthenticationTypeの値をbool値に変換する際のデフォルト値を指定、または取得します。
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

        private bool _isConvertBackWhenWindowsSet;
        private bool _convertBackWhenWindows;
		/// <summary>
        /// AuthenticationTypeの値がWindowsの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
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
        private bool _isConvertBackWhenPassportSet;
        private bool _convertBackWhenPassport;
		/// <summary>
        /// AuthenticationTypeの値がPassportの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenPassport
        {
            get
            {
                return _convertBackWhenPassport;
            }
            set
            {
                _convertBackWhenPassport = value;
                _isConvertBackWhenPassportSet = true;
            }
        }
        private bool _isConvertBackWhenWindowsPassportSet;
        private bool _convertBackWhenWindowsPassport;
		/// <summary>
        /// AuthenticationTypeの値がWindowsPassportの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenWindowsPassport
        {
            get
            {
                return _convertBackWhenWindowsPassport;
            }
            set
            {
                _convertBackWhenWindowsPassport = value;
                _isConvertBackWhenWindowsPassportSet = true;
            }
        }
        private bool _isConvertBackWhenInternalSet;
        private bool _convertBackWhenInternal;
		/// <summary>
        /// AuthenticationTypeの値がInternalの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenInternal
        {
            get
            {
                return _convertBackWhenInternal;
            }
            set
            {
                _convertBackWhenInternal = value;
                _isConvertBackWhenInternalSet = true;
            }
        }
    }
}