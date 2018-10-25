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
    /// MessageBoxButton列挙体とbool値の相互変換を行うIValueConverterです。
    /// </summary>
    public class MessageBoxButtonAndBooleanConverter : IValueConverter
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
        private MessageBoxButton _convertWhenTrue;
		/// <summary>
        /// ソース値がTrueの際にどのMessageBoxButton列挙体メンバーに変換するかを指定、または取得します。
        /// </summary>
        public MessageBoxButton ConvertWhenTrue
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
        private MessageBoxButton _convertWhenFalse;
		/// <summary>
        /// ソース値がFalseの際にどのMessageBoxButton列挙体メンバーに変換するかを指定、または取得します。
        /// </summary>
        public MessageBoxButton ConvertWhenFalse
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
            if (!(value is MessageBoxButton)) throw new ArgumentException();

            var enumValue = (MessageBoxButton)value;

			switch(enumValue.ToString())
			{
				case "OK":
					if (_isConvertBackWhenOKSet)
					{
						return ConvertBackWhenOK;
					}
					break;
				case "OKCancel":
					if (_isConvertBackWhenOKCancelSet)
					{
						return ConvertBackWhenOKCancel;
					}
					break;
				case "YesNoCancel":
					if (_isConvertBackWhenYesNoCancelSet)
					{
						return ConvertBackWhenYesNoCancel;
					}
					break;
				case "YesNo":
					if (_isConvertBackWhenYesNoSet)
					{
						return ConvertBackWhenYesNo;
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
        /// MessageBoxButtonの値をbool値に変換する際のデフォルト値を指定、または取得します。
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

        private bool _isConvertBackWhenOKSet;
        private bool _convertBackWhenOK;
		/// <summary>
        /// MessageBoxButtonの値がOKの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenOK
        {
            get
            {
                return _convertBackWhenOK;
            }
            set
            {
                _convertBackWhenOK = value;
                _isConvertBackWhenOKSet = true;
            }
        }
        private bool _isConvertBackWhenOKCancelSet;
        private bool _convertBackWhenOKCancel;
		/// <summary>
        /// MessageBoxButtonの値がOKCancelの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenOKCancel
        {
            get
            {
                return _convertBackWhenOKCancel;
            }
            set
            {
                _convertBackWhenOKCancel = value;
                _isConvertBackWhenOKCancelSet = true;
            }
        }
        private bool _isConvertBackWhenYesNoCancelSet;
        private bool _convertBackWhenYesNoCancel;
		/// <summary>
        /// MessageBoxButtonの値がYesNoCancelの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenYesNoCancel
        {
            get
            {
                return _convertBackWhenYesNoCancel;
            }
            set
            {
                _convertBackWhenYesNoCancel = value;
                _isConvertBackWhenYesNoCancelSet = true;
            }
        }
        private bool _isConvertBackWhenYesNoSet;
        private bool _convertBackWhenYesNo;
		/// <summary>
        /// MessageBoxButtonの値がYesNoの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenYesNo
        {
            get
            {
                return _convertBackWhenYesNo;
            }
            set
            {
                _convertBackWhenYesNo = value;
                _isConvertBackWhenYesNoSet = true;
            }
        }
    }
}