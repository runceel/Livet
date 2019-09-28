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
    /// MouseAction列挙体とbool値の相互変換を行うIValueConverterです。
    /// </summary>
    public class MouseActionAndBooleanConverter : IValueConverter
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
        private MouseAction _convertWhenTrue;
		/// <summary>
        /// ソース値がTrueの際にどのMouseAction列挙体メンバーに変換するかを指定、または取得します。
        /// </summary>
        public MouseAction ConvertWhenTrue
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
        private MouseAction _convertWhenFalse;
		/// <summary>
        /// ソース値がFalseの際にどのMouseAction列挙体メンバーに変換するかを指定、または取得します。
        /// </summary>
        public MouseAction ConvertWhenFalse
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
            if (!(value is MouseAction)) throw new ArgumentException();

            var enumValue = (MouseAction)value;

			switch(enumValue.ToString())
			{
				case "None":
					if (_isConvertBackWhenNoneSet)
					{
						return ConvertBackWhenNone;
					}
					break;
				case "LeftClick":
					if (_isConvertBackWhenLeftClickSet)
					{
						return ConvertBackWhenLeftClick;
					}
					break;
				case "RightClick":
					if (_isConvertBackWhenRightClickSet)
					{
						return ConvertBackWhenRightClick;
					}
					break;
				case "MiddleClick":
					if (_isConvertBackWhenMiddleClickSet)
					{
						return ConvertBackWhenMiddleClick;
					}
					break;
				case "WheelClick":
					if (_isConvertBackWhenWheelClickSet)
					{
						return ConvertBackWhenWheelClick;
					}
					break;
				case "LeftDoubleClick":
					if (_isConvertBackWhenLeftDoubleClickSet)
					{
						return ConvertBackWhenLeftDoubleClick;
					}
					break;
				case "RightDoubleClick":
					if (_isConvertBackWhenRightDoubleClickSet)
					{
						return ConvertBackWhenRightDoubleClick;
					}
					break;
				case "MiddleDoubleClick":
					if (_isConvertBackWhenMiddleDoubleClickSet)
					{
						return ConvertBackWhenMiddleDoubleClick;
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
        /// MouseActionの値をbool値に変換する際のデフォルト値を指定、または取得します。
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
        /// MouseActionの値がNoneの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
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
        private bool _isConvertBackWhenLeftClickSet;
        private bool _convertBackWhenLeftClick;
		/// <summary>
        /// MouseActionの値がLeftClickの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenLeftClick
        {
            get
            {
                return _convertBackWhenLeftClick;
            }
            set
            {
                _convertBackWhenLeftClick = value;
                _isConvertBackWhenLeftClickSet = true;
            }
        }
        private bool _isConvertBackWhenRightClickSet;
        private bool _convertBackWhenRightClick;
		/// <summary>
        /// MouseActionの値がRightClickの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenRightClick
        {
            get
            {
                return _convertBackWhenRightClick;
            }
            set
            {
                _convertBackWhenRightClick = value;
                _isConvertBackWhenRightClickSet = true;
            }
        }
        private bool _isConvertBackWhenMiddleClickSet;
        private bool _convertBackWhenMiddleClick;
		/// <summary>
        /// MouseActionの値がMiddleClickの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenMiddleClick
        {
            get
            {
                return _convertBackWhenMiddleClick;
            }
            set
            {
                _convertBackWhenMiddleClick = value;
                _isConvertBackWhenMiddleClickSet = true;
            }
        }
        private bool _isConvertBackWhenWheelClickSet;
        private bool _convertBackWhenWheelClick;
		/// <summary>
        /// MouseActionの値がWheelClickの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenWheelClick
        {
            get
            {
                return _convertBackWhenWheelClick;
            }
            set
            {
                _convertBackWhenWheelClick = value;
                _isConvertBackWhenWheelClickSet = true;
            }
        }
        private bool _isConvertBackWhenLeftDoubleClickSet;
        private bool _convertBackWhenLeftDoubleClick;
		/// <summary>
        /// MouseActionの値がLeftDoubleClickの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenLeftDoubleClick
        {
            get
            {
                return _convertBackWhenLeftDoubleClick;
            }
            set
            {
                _convertBackWhenLeftDoubleClick = value;
                _isConvertBackWhenLeftDoubleClickSet = true;
            }
        }
        private bool _isConvertBackWhenRightDoubleClickSet;
        private bool _convertBackWhenRightDoubleClick;
		/// <summary>
        /// MouseActionの値がRightDoubleClickの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenRightDoubleClick
        {
            get
            {
                return _convertBackWhenRightDoubleClick;
            }
            set
            {
                _convertBackWhenRightDoubleClick = value;
                _isConvertBackWhenRightDoubleClickSet = true;
            }
        }
        private bool _isConvertBackWhenMiddleDoubleClickSet;
        private bool _convertBackWhenMiddleDoubleClick;
		/// <summary>
        /// MouseActionの値がMiddleDoubleClickの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenMiddleDoubleClick
        {
            get
            {
                return _convertBackWhenMiddleDoubleClick;
            }
            set
            {
                _convertBackWhenMiddleDoubleClick = value;
                _isConvertBackWhenMiddleDoubleClickSet = true;
            }
        }
    }
}