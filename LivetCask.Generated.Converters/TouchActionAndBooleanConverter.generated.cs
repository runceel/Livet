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
    /// TouchAction列挙体とbool値の相互変換を行うIValueConverterです。
    /// </summary>
    public class TouchActionAndBooleanConverter : IValueConverter
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
        private TouchAction _convertWhenTrue;
		/// <summary>
        /// ソース値がTrueの際にどのTouchAction列挙体メンバーに変換するかを指定、または取得します。
        /// </summary>
        public TouchAction ConvertWhenTrue
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
        private TouchAction _convertWhenFalse;
		/// <summary>
        /// ソース値がFalseの際にどのTouchAction列挙体メンバーに変換するかを指定、または取得します。
        /// </summary>
        public TouchAction ConvertWhenFalse
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
            if (!(value is TouchAction)) throw new ArgumentException();

            var enumValue = (TouchAction)value;

			switch(enumValue.ToString())
			{
				case "Down":
					if (_isConvertBackWhenDownSet)
					{
						return ConvertBackWhenDown;
					}
					break;
				case "Move":
					if (_isConvertBackWhenMoveSet)
					{
						return ConvertBackWhenMove;
					}
					break;
				case "Up":
					if (_isConvertBackWhenUpSet)
					{
						return ConvertBackWhenUp;
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
        /// TouchActionの値をbool値に変換する際のデフォルト値を指定、または取得します。
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

        private bool _isConvertBackWhenDownSet;
        private bool _convertBackWhenDown;
		/// <summary>
        /// TouchActionの値がDownの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenDown
        {
            get
            {
                return _convertBackWhenDown;
            }
            set
            {
                _convertBackWhenDown = value;
                _isConvertBackWhenDownSet = true;
            }
        }
        private bool _isConvertBackWhenMoveSet;
        private bool _convertBackWhenMove;
		/// <summary>
        /// TouchActionの値がMoveの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenMove
        {
            get
            {
                return _convertBackWhenMove;
            }
            set
            {
                _convertBackWhenMove = value;
                _isConvertBackWhenMoveSet = true;
            }
        }
        private bool _isConvertBackWhenUpSet;
        private bool _convertBackWhenUp;
		/// <summary>
        /// TouchActionの値がUpの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenUp
        {
            get
            {
                return _convertBackWhenUp;
            }
            set
            {
                _convertBackWhenUp = value;
                _isConvertBackWhenUpSet = true;
            }
        }
    }
}