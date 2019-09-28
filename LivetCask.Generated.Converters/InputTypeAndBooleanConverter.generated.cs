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
    /// InputType列挙体とbool値の相互変換を行うIValueConverterです。
    /// </summary>
    public class InputTypeAndBooleanConverter : IValueConverter
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
        private InputType _convertWhenTrue;
		/// <summary>
        /// ソース値がTrueの際にどのInputType列挙体メンバーに変換するかを指定、または取得します。
        /// </summary>
        public InputType ConvertWhenTrue
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
        private InputType _convertWhenFalse;
		/// <summary>
        /// ソース値がFalseの際にどのInputType列挙体メンバーに変換するかを指定、または取得します。
        /// </summary>
        public InputType ConvertWhenFalse
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
            if (!(value is InputType)) throw new ArgumentException();

            var enumValue = (InputType)value;

			switch(enumValue.ToString())
			{
				case "Keyboard":
					if (_isConvertBackWhenKeyboardSet)
					{
						return ConvertBackWhenKeyboard;
					}
					break;
				case "Mouse":
					if (_isConvertBackWhenMouseSet)
					{
						return ConvertBackWhenMouse;
					}
					break;
				case "Stylus":
					if (_isConvertBackWhenStylusSet)
					{
						return ConvertBackWhenStylus;
					}
					break;
				case "Hid":
					if (_isConvertBackWhenHidSet)
					{
						return ConvertBackWhenHid;
					}
					break;
				case "Text":
					if (_isConvertBackWhenTextSet)
					{
						return ConvertBackWhenText;
					}
					break;
				case "Command":
					if (_isConvertBackWhenCommandSet)
					{
						return ConvertBackWhenCommand;
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
        /// InputTypeの値をbool値に変換する際のデフォルト値を指定、または取得します。
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

        private bool _isConvertBackWhenKeyboardSet;
        private bool _convertBackWhenKeyboard;
		/// <summary>
        /// InputTypeの値がKeyboardの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenKeyboard
        {
            get
            {
                return _convertBackWhenKeyboard;
            }
            set
            {
                _convertBackWhenKeyboard = value;
                _isConvertBackWhenKeyboardSet = true;
            }
        }
        private bool _isConvertBackWhenMouseSet;
        private bool _convertBackWhenMouse;
		/// <summary>
        /// InputTypeの値がMouseの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenMouse
        {
            get
            {
                return _convertBackWhenMouse;
            }
            set
            {
                _convertBackWhenMouse = value;
                _isConvertBackWhenMouseSet = true;
            }
        }
        private bool _isConvertBackWhenStylusSet;
        private bool _convertBackWhenStylus;
		/// <summary>
        /// InputTypeの値がStylusの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenStylus
        {
            get
            {
                return _convertBackWhenStylus;
            }
            set
            {
                _convertBackWhenStylus = value;
                _isConvertBackWhenStylusSet = true;
            }
        }
        private bool _isConvertBackWhenHidSet;
        private bool _convertBackWhenHid;
		/// <summary>
        /// InputTypeの値がHidの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenHid
        {
            get
            {
                return _convertBackWhenHid;
            }
            set
            {
                _convertBackWhenHid = value;
                _isConvertBackWhenHidSet = true;
            }
        }
        private bool _isConvertBackWhenTextSet;
        private bool _convertBackWhenText;
		/// <summary>
        /// InputTypeの値がTextの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenText
        {
            get
            {
                return _convertBackWhenText;
            }
            set
            {
                _convertBackWhenText = value;
                _isConvertBackWhenTextSet = true;
            }
        }
        private bool _isConvertBackWhenCommandSet;
        private bool _convertBackWhenCommand;
		/// <summary>
        /// InputTypeの値がCommandの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenCommand
        {
            get
            {
                return _convertBackWhenCommand;
            }
            set
            {
                _convertBackWhenCommand = value;
                _isConvertBackWhenCommandSet = true;
            }
        }
    }
}