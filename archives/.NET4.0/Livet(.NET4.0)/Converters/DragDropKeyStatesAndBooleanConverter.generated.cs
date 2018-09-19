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
    /// DragDropKeyStates列挙体とbool値の相互変換を行うIValueConverterです。
    /// </summary>
    public class DragDropKeyStatesAndBooleanConverter : IValueConverter
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
        private DragDropKeyStates _convertWhenTrue;
		/// <summary>
        /// ソース値がTrueの際にどのDragDropKeyStates列挙体メンバーに変換するかを指定、または取得します。
        /// </summary>
        public DragDropKeyStates ConvertWhenTrue
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
        private DragDropKeyStates _convertWhenFalse;
		/// <summary>
        /// ソース値がFalseの際にどのDragDropKeyStates列挙体メンバーに変換するかを指定、または取得します。
        /// </summary>
        public DragDropKeyStates ConvertWhenFalse
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
            if (!(value is DragDropKeyStates)) throw new ArgumentException();

            var enumValue = (DragDropKeyStates)value;

			switch(enumValue.ToString())
			{
				case "None":
					if (_isConvertBackWhenNoneSet)
					{
						return ConvertBackWhenNone;
					}
					break;
				case "LeftMouseButton":
					if (_isConvertBackWhenLeftMouseButtonSet)
					{
						return ConvertBackWhenLeftMouseButton;
					}
					break;
				case "RightMouseButton":
					if (_isConvertBackWhenRightMouseButtonSet)
					{
						return ConvertBackWhenRightMouseButton;
					}
					break;
				case "ShiftKey":
					if (_isConvertBackWhenShiftKeySet)
					{
						return ConvertBackWhenShiftKey;
					}
					break;
				case "ControlKey":
					if (_isConvertBackWhenControlKeySet)
					{
						return ConvertBackWhenControlKey;
					}
					break;
				case "MiddleMouseButton":
					if (_isConvertBackWhenMiddleMouseButtonSet)
					{
						return ConvertBackWhenMiddleMouseButton;
					}
					break;
				case "AltKey":
					if (_isConvertBackWhenAltKeySet)
					{
						return ConvertBackWhenAltKey;
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
        /// DragDropKeyStatesの値をbool値に変換する際のデフォルト値を指定、または取得します。
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
        /// DragDropKeyStatesの値がNoneの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
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
        private bool _isConvertBackWhenLeftMouseButtonSet;
        private bool _convertBackWhenLeftMouseButton;
		/// <summary>
        /// DragDropKeyStatesの値がLeftMouseButtonの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenLeftMouseButton
        {
            get
            {
                return _convertBackWhenLeftMouseButton;
            }
            set
            {
                _convertBackWhenLeftMouseButton = value;
                _isConvertBackWhenLeftMouseButtonSet = true;
            }
        }
        private bool _isConvertBackWhenRightMouseButtonSet;
        private bool _convertBackWhenRightMouseButton;
		/// <summary>
        /// DragDropKeyStatesの値がRightMouseButtonの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenRightMouseButton
        {
            get
            {
                return _convertBackWhenRightMouseButton;
            }
            set
            {
                _convertBackWhenRightMouseButton = value;
                _isConvertBackWhenRightMouseButtonSet = true;
            }
        }
        private bool _isConvertBackWhenShiftKeySet;
        private bool _convertBackWhenShiftKey;
		/// <summary>
        /// DragDropKeyStatesの値がShiftKeyの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenShiftKey
        {
            get
            {
                return _convertBackWhenShiftKey;
            }
            set
            {
                _convertBackWhenShiftKey = value;
                _isConvertBackWhenShiftKeySet = true;
            }
        }
        private bool _isConvertBackWhenControlKeySet;
        private bool _convertBackWhenControlKey;
		/// <summary>
        /// DragDropKeyStatesの値がControlKeyの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenControlKey
        {
            get
            {
                return _convertBackWhenControlKey;
            }
            set
            {
                _convertBackWhenControlKey = value;
                _isConvertBackWhenControlKeySet = true;
            }
        }
        private bool _isConvertBackWhenMiddleMouseButtonSet;
        private bool _convertBackWhenMiddleMouseButton;
		/// <summary>
        /// DragDropKeyStatesの値がMiddleMouseButtonの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenMiddleMouseButton
        {
            get
            {
                return _convertBackWhenMiddleMouseButton;
            }
            set
            {
                _convertBackWhenMiddleMouseButton = value;
                _isConvertBackWhenMiddleMouseButtonSet = true;
            }
        }
        private bool _isConvertBackWhenAltKeySet;
        private bool _convertBackWhenAltKey;
		/// <summary>
        /// DragDropKeyStatesの値がAltKeyの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenAltKey
        {
            get
            {
                return _convertBackWhenAltKey;
            }
            set
            {
                _convertBackWhenAltKey = value;
                _isConvertBackWhenAltKeySet = true;
            }
        }
    }
}