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
    /// ResizeMode列挙体とbool値の相互変換を行うIValueConverterです。
    /// </summary>
    public class ResizeModeAndBooleanConverter : IValueConverter
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
        private ResizeMode _convertWhenTrue;
		/// <summary>
        /// ソース値がTrueの際にどのResizeMode列挙体メンバーに変換するかを指定、または取得します。
        /// </summary>
        public ResizeMode ConvertWhenTrue
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
        private ResizeMode _convertWhenFalse;
		/// <summary>
        /// ソース値がFalseの際にどのResizeMode列挙体メンバーに変換するかを指定、または取得します。
        /// </summary>
        public ResizeMode ConvertWhenFalse
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
            if (!(value is ResizeMode)) throw new ArgumentException();

            var enumValue = (ResizeMode)value;

			switch(enumValue.ToString())
			{
				case "NoResize":
					if (_isConvertBackWhenNoResizeSet)
					{
						return ConvertBackWhenNoResize;
					}
					break;
				case "CanMinimize":
					if (_isConvertBackWhenCanMinimizeSet)
					{
						return ConvertBackWhenCanMinimize;
					}
					break;
				case "CanResize":
					if (_isConvertBackWhenCanResizeSet)
					{
						return ConvertBackWhenCanResize;
					}
					break;
				case "CanResizeWithGrip":
					if (_isConvertBackWhenCanResizeWithGripSet)
					{
						return ConvertBackWhenCanResizeWithGrip;
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
        /// ResizeModeの値をbool値に変換する際のデフォルト値を指定、または取得します。
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

        private bool _isConvertBackWhenNoResizeSet;
        private bool _convertBackWhenNoResize;
		/// <summary>
        /// ResizeModeの値がNoResizeの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenNoResize
        {
            get
            {
                return _convertBackWhenNoResize;
            }
            set
            {
                _convertBackWhenNoResize = value;
                _isConvertBackWhenNoResizeSet = true;
            }
        }
        private bool _isConvertBackWhenCanMinimizeSet;
        private bool _convertBackWhenCanMinimize;
		/// <summary>
        /// ResizeModeの値がCanMinimizeの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenCanMinimize
        {
            get
            {
                return _convertBackWhenCanMinimize;
            }
            set
            {
                _convertBackWhenCanMinimize = value;
                _isConvertBackWhenCanMinimizeSet = true;
            }
        }
        private bool _isConvertBackWhenCanResizeSet;
        private bool _convertBackWhenCanResize;
		/// <summary>
        /// ResizeModeの値がCanResizeの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenCanResize
        {
            get
            {
                return _convertBackWhenCanResize;
            }
            set
            {
                _convertBackWhenCanResize = value;
                _isConvertBackWhenCanResizeSet = true;
            }
        }
        private bool _isConvertBackWhenCanResizeWithGripSet;
        private bool _convertBackWhenCanResizeWithGrip;
		/// <summary>
        /// ResizeModeの値がCanResizeWithGripの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenCanResizeWithGrip
        {
            get
            {
                return _convertBackWhenCanResizeWithGrip;
            }
            set
            {
                _convertBackWhenCanResizeWithGrip = value;
                _isConvertBackWhenCanResizeWithGripSet = true;
            }
        }
    }
}