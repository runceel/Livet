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
    /// Readability列挙体とbool値の相互変換を行うIValueConverterです。
    /// </summary>
    public class ReadabilityAndBooleanConverter : IValueConverter
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
        private Readability _convertWhenTrue;
		/// <summary>
        /// ソース値がTrueの際にどのReadability列挙体メンバーに変換するかを指定、または取得します。
        /// </summary>
        public Readability ConvertWhenTrue
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
        private Readability _convertWhenFalse;
		/// <summary>
        /// ソース値がFalseの際にどのReadability列挙体メンバーに変換するかを指定、または取得します。
        /// </summary>
        public Readability ConvertWhenFalse
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
            if (!(value is Readability)) throw new ArgumentException();

            var enumValue = (Readability)value;

			switch(enumValue.ToString())
			{
				case "Unreadable":
					if (_isConvertBackWhenUnreadableSet)
					{
						return ConvertBackWhenUnreadable;
					}
					break;
				case "Readable":
					if (_isConvertBackWhenReadableSet)
					{
						return ConvertBackWhenReadable;
					}
					break;
				case "Inherit":
					if (_isConvertBackWhenInheritSet)
					{
						return ConvertBackWhenInherit;
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
        /// Readabilityの値をbool値に変換する際のデフォルト値を指定、または取得します。
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

        private bool _isConvertBackWhenUnreadableSet;
        private bool _convertBackWhenUnreadable;
		/// <summary>
        /// Readabilityの値がUnreadableの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenUnreadable
        {
            get
            {
                return _convertBackWhenUnreadable;
            }
            set
            {
                _convertBackWhenUnreadable = value;
                _isConvertBackWhenUnreadableSet = true;
            }
        }
        private bool _isConvertBackWhenReadableSet;
        private bool _convertBackWhenReadable;
		/// <summary>
        /// Readabilityの値がReadableの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenReadable
        {
            get
            {
                return _convertBackWhenReadable;
            }
            set
            {
                _convertBackWhenReadable = value;
                _isConvertBackWhenReadableSet = true;
            }
        }
        private bool _isConvertBackWhenInheritSet;
        private bool _convertBackWhenInherit;
		/// <summary>
        /// Readabilityの値がInheritの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenInherit
        {
            get
            {
                return _convertBackWhenInherit;
            }
            set
            {
                _convertBackWhenInherit = value;
                _isConvertBackWhenInheritSet = true;
            }
        }
    }
}