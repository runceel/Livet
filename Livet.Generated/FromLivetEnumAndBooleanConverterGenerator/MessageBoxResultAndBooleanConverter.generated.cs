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
    /// MessageBoxResult列挙体とbool値の相互変換を行うIValueConverterです。
    /// </summary>
    public class MessageBoxResultAndBooleanConverter : IValueConverter
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
        private MessageBoxResult _convertWhenTrue;
		/// <summary>
        /// ソース値がTrueの際にどのMessageBoxResult列挙体メンバーに変換するかを指定、または取得します。
        /// </summary>
        public MessageBoxResult ConvertWhenTrue
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
        private MessageBoxResult _convertWhenFalse;
		/// <summary>
        /// ソース値がFalseの際にどのMessageBoxResult列挙体メンバーに変換するかを指定、または取得します。
        /// </summary>
        public MessageBoxResult ConvertWhenFalse
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
            if (!(value is MessageBoxResult)) throw new ArgumentException();

            var enumValue = (MessageBoxResult)value;

			switch(enumValue.ToString())
			{
				case "None":
					if (_isConvertBackWhenNoneSet)
					{
						return ConvertBackWhenNone;
					}
					break;
				case "OK":
					if (_isConvertBackWhenOKSet)
					{
						return ConvertBackWhenOK;
					}
					break;
				case "Cancel":
					if (_isConvertBackWhenCancelSet)
					{
						return ConvertBackWhenCancel;
					}
					break;
				case "Yes":
					if (_isConvertBackWhenYesSet)
					{
						return ConvertBackWhenYes;
					}
					break;
				case "No":
					if (_isConvertBackWhenNoSet)
					{
						return ConvertBackWhenNo;
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
        /// MessageBoxResultの値をbool値に変換する際のデフォルト値を指定、または取得します。
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
        /// MessageBoxResultの値がNoneの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
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
        private bool _isConvertBackWhenOKSet;
        private bool _convertBackWhenOK;
		/// <summary>
        /// MessageBoxResultの値がOKの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
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
        private bool _isConvertBackWhenCancelSet;
        private bool _convertBackWhenCancel;
		/// <summary>
        /// MessageBoxResultの値がCancelの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenCancel
        {
            get
            {
                return _convertBackWhenCancel;
            }
            set
            {
                _convertBackWhenCancel = value;
                _isConvertBackWhenCancelSet = true;
            }
        }
        private bool _isConvertBackWhenYesSet;
        private bool _convertBackWhenYes;
		/// <summary>
        /// MessageBoxResultの値がYesの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenYes
        {
            get
            {
                return _convertBackWhenYes;
            }
            set
            {
                _convertBackWhenYes = value;
                _isConvertBackWhenYesSet = true;
            }
        }
        private bool _isConvertBackWhenNoSet;
        private bool _convertBackWhenNo;
		/// <summary>
        /// MessageBoxResultの値がNoの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenNo
        {
            get
            {
                return _convertBackWhenNo;
            }
            set
            {
                _convertBackWhenNo = value;
                _isConvertBackWhenNoSet = true;
            }
        }
    }
}