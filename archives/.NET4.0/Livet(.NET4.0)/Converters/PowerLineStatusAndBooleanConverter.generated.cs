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
    /// PowerLineStatus列挙体とbool値の相互変換を行うIValueConverterです。
    /// </summary>
    public class PowerLineStatusAndBooleanConverter : IValueConverter
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
        private PowerLineStatus _convertWhenTrue;
		/// <summary>
        /// ソース値がTrueの際にどのPowerLineStatus列挙体メンバーに変換するかを指定、または取得します。
        /// </summary>
        public PowerLineStatus ConvertWhenTrue
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
        private PowerLineStatus _convertWhenFalse;
		/// <summary>
        /// ソース値がFalseの際にどのPowerLineStatus列挙体メンバーに変換するかを指定、または取得します。
        /// </summary>
        public PowerLineStatus ConvertWhenFalse
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
            if (!(value is PowerLineStatus)) throw new ArgumentException();

            var enumValue = (PowerLineStatus)value;

			switch(enumValue.ToString())
			{
				case "Offline":
					if (_isConvertBackWhenOfflineSet)
					{
						return ConvertBackWhenOffline;
					}
					break;
				case "Online":
					if (_isConvertBackWhenOnlineSet)
					{
						return ConvertBackWhenOnline;
					}
					break;
				case "Unknown":
					if (_isConvertBackWhenUnknownSet)
					{
						return ConvertBackWhenUnknown;
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
        /// PowerLineStatusの値をbool値に変換する際のデフォルト値を指定、または取得します。
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

        private bool _isConvertBackWhenOfflineSet;
        private bool _convertBackWhenOffline;
		/// <summary>
        /// PowerLineStatusの値がOfflineの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenOffline
        {
            get
            {
                return _convertBackWhenOffline;
            }
            set
            {
                _convertBackWhenOffline = value;
                _isConvertBackWhenOfflineSet = true;
            }
        }
        private bool _isConvertBackWhenOnlineSet;
        private bool _convertBackWhenOnline;
		/// <summary>
        /// PowerLineStatusの値がOnlineの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenOnline
        {
            get
            {
                return _convertBackWhenOnline;
            }
            set
            {
                _convertBackWhenOnline = value;
                _isConvertBackWhenOnlineSet = true;
            }
        }
        private bool _isConvertBackWhenUnknownSet;
        private bool _convertBackWhenUnknown;
		/// <summary>
        /// PowerLineStatusの値がUnknownの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenUnknown
        {
            get
            {
                return _convertBackWhenUnknown;
            }
            set
            {
                _convertBackWhenUnknown = value;
                _isConvertBackWhenUnknownSet = true;
            }
        }
    }
}