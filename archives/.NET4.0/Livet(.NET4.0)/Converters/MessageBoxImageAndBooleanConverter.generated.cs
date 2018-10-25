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
    /// MessageBoxImage列挙体とbool値の相互変換を行うIValueConverterです。
    /// </summary>
    public class MessageBoxImageAndBooleanConverter : IValueConverter
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
        private MessageBoxImage _convertWhenTrue;
		/// <summary>
        /// ソース値がTrueの際にどのMessageBoxImage列挙体メンバーに変換するかを指定、または取得します。
        /// </summary>
        public MessageBoxImage ConvertWhenTrue
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
        private MessageBoxImage _convertWhenFalse;
		/// <summary>
        /// ソース値がFalseの際にどのMessageBoxImage列挙体メンバーに変換するかを指定、または取得します。
        /// </summary>
        public MessageBoxImage ConvertWhenFalse
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
            if (!(value is MessageBoxImage)) throw new ArgumentException();

            var enumValue = (MessageBoxImage)value;

			switch(enumValue.ToString())
			{
				case "None":
					if (_isConvertBackWhenNoneSet)
					{
						return ConvertBackWhenNone;
					}
					break;
				case "Hand":
					if (_isConvertBackWhenHandSet)
					{
						return ConvertBackWhenHand;
					}
					break;
				case "Error":
					if (_isConvertBackWhenErrorSet)
					{
						return ConvertBackWhenError;
					}
					break;
				case "Stop":
					if (_isConvertBackWhenStopSet)
					{
						return ConvertBackWhenStop;
					}
					break;
				case "Question":
					if (_isConvertBackWhenQuestionSet)
					{
						return ConvertBackWhenQuestion;
					}
					break;
				case "Exclamation":
					if (_isConvertBackWhenExclamationSet)
					{
						return ConvertBackWhenExclamation;
					}
					break;
				case "Warning":
					if (_isConvertBackWhenWarningSet)
					{
						return ConvertBackWhenWarning;
					}
					break;
				case "Asterisk":
					if (_isConvertBackWhenAsteriskSet)
					{
						return ConvertBackWhenAsterisk;
					}
					break;
				case "Information":
					if (_isConvertBackWhenInformationSet)
					{
						return ConvertBackWhenInformation;
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
        /// MessageBoxImageの値をbool値に変換する際のデフォルト値を指定、または取得します。
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
        /// MessageBoxImageの値がNoneの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
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
        private bool _isConvertBackWhenHandSet;
        private bool _convertBackWhenHand;
		/// <summary>
        /// MessageBoxImageの値がHandの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenHand
        {
            get
            {
                return _convertBackWhenHand;
            }
            set
            {
                _convertBackWhenHand = value;
                _isConvertBackWhenHandSet = true;
            }
        }
        private bool _isConvertBackWhenErrorSet;
        private bool _convertBackWhenError;
		/// <summary>
        /// MessageBoxImageの値がErrorの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenError
        {
            get
            {
                return _convertBackWhenError;
            }
            set
            {
                _convertBackWhenError = value;
                _isConvertBackWhenErrorSet = true;
            }
        }
        private bool _isConvertBackWhenStopSet;
        private bool _convertBackWhenStop;
		/// <summary>
        /// MessageBoxImageの値がStopの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenStop
        {
            get
            {
                return _convertBackWhenStop;
            }
            set
            {
                _convertBackWhenStop = value;
                _isConvertBackWhenStopSet = true;
            }
        }
        private bool _isConvertBackWhenQuestionSet;
        private bool _convertBackWhenQuestion;
		/// <summary>
        /// MessageBoxImageの値がQuestionの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenQuestion
        {
            get
            {
                return _convertBackWhenQuestion;
            }
            set
            {
                _convertBackWhenQuestion = value;
                _isConvertBackWhenQuestionSet = true;
            }
        }
        private bool _isConvertBackWhenExclamationSet;
        private bool _convertBackWhenExclamation;
		/// <summary>
        /// MessageBoxImageの値がExclamationの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenExclamation
        {
            get
            {
                return _convertBackWhenExclamation;
            }
            set
            {
                _convertBackWhenExclamation = value;
                _isConvertBackWhenExclamationSet = true;
            }
        }
        private bool _isConvertBackWhenWarningSet;
        private bool _convertBackWhenWarning;
		/// <summary>
        /// MessageBoxImageの値がWarningの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenWarning
        {
            get
            {
                return _convertBackWhenWarning;
            }
            set
            {
                _convertBackWhenWarning = value;
                _isConvertBackWhenWarningSet = true;
            }
        }
        private bool _isConvertBackWhenAsteriskSet;
        private bool _convertBackWhenAsterisk;
		/// <summary>
        /// MessageBoxImageの値がAsteriskの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenAsterisk
        {
            get
            {
                return _convertBackWhenAsterisk;
            }
            set
            {
                _convertBackWhenAsterisk = value;
                _isConvertBackWhenAsteriskSet = true;
            }
        }
        private bool _isConvertBackWhenInformationSet;
        private bool _convertBackWhenInformation;
		/// <summary>
        /// MessageBoxImageの値がInformationの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenInformation
        {
            get
            {
                return _convertBackWhenInformation;
            }
            set
            {
                _convertBackWhenInformation = value;
                _isConvertBackWhenInformationSet = true;
            }
        }
    }
}