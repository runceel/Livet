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
    /// MessageBoxOptions列挙体とbool値の相互変換を行うIValueConverterです。
    /// </summary>
    public class MessageBoxOptionsAndBooleanConverter : IValueConverter
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
        private MessageBoxOptions _convertWhenTrue;
		/// <summary>
        /// ソース値がTrueの際にどのMessageBoxOptions列挙体メンバーに変換するかを指定、または取得します。
        /// </summary>
        public MessageBoxOptions ConvertWhenTrue
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
        private MessageBoxOptions _convertWhenFalse;
		/// <summary>
        /// ソース値がFalseの際にどのMessageBoxOptions列挙体メンバーに変換するかを指定、または取得します。
        /// </summary>
        public MessageBoxOptions ConvertWhenFalse
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
            if (!(value is MessageBoxOptions)) throw new ArgumentException();

            var enumValue = (MessageBoxOptions)value;

			switch(enumValue.ToString())
			{
				case "None":
					if (_isConvertBackWhenNoneSet)
					{
						return ConvertBackWhenNone;
					}
					break;
				case "DefaultDesktopOnly":
					if (_isConvertBackWhenDefaultDesktopOnlySet)
					{
						return ConvertBackWhenDefaultDesktopOnly;
					}
					break;
				case "RightAlign":
					if (_isConvertBackWhenRightAlignSet)
					{
						return ConvertBackWhenRightAlign;
					}
					break;
				case "RtlReading":
					if (_isConvertBackWhenRtlReadingSet)
					{
						return ConvertBackWhenRtlReading;
					}
					break;
				case "ServiceNotification":
					if (_isConvertBackWhenServiceNotificationSet)
					{
						return ConvertBackWhenServiceNotification;
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
        /// MessageBoxOptionsの値をbool値に変換する際のデフォルト値を指定、または取得します。
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
        /// MessageBoxOptionsの値がNoneの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
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
        private bool _isConvertBackWhenDefaultDesktopOnlySet;
        private bool _convertBackWhenDefaultDesktopOnly;
		/// <summary>
        /// MessageBoxOptionsの値がDefaultDesktopOnlyの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenDefaultDesktopOnly
        {
            get
            {
                return _convertBackWhenDefaultDesktopOnly;
            }
            set
            {
                _convertBackWhenDefaultDesktopOnly = value;
                _isConvertBackWhenDefaultDesktopOnlySet = true;
            }
        }
        private bool _isConvertBackWhenRightAlignSet;
        private bool _convertBackWhenRightAlign;
		/// <summary>
        /// MessageBoxOptionsの値がRightAlignの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenRightAlign
        {
            get
            {
                return _convertBackWhenRightAlign;
            }
            set
            {
                _convertBackWhenRightAlign = value;
                _isConvertBackWhenRightAlignSet = true;
            }
        }
        private bool _isConvertBackWhenRtlReadingSet;
        private bool _convertBackWhenRtlReading;
		/// <summary>
        /// MessageBoxOptionsの値がRtlReadingの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenRtlReading
        {
            get
            {
                return _convertBackWhenRtlReading;
            }
            set
            {
                _convertBackWhenRtlReading = value;
                _isConvertBackWhenRtlReadingSet = true;
            }
        }
        private bool _isConvertBackWhenServiceNotificationSet;
        private bool _convertBackWhenServiceNotification;
		/// <summary>
        /// MessageBoxOptionsの値がServiceNotificationの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenServiceNotification
        {
            get
            {
                return _convertBackWhenServiceNotification;
            }
            set
            {
                _convertBackWhenServiceNotification = value;
                _isConvertBackWhenServiceNotificationSet = true;
            }
        }
    }
}