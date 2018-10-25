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
    /// InheritanceBehavior列挙体とbool値の相互変換を行うIValueConverterです。
    /// </summary>
    public class InheritanceBehaviorAndBooleanConverter : IValueConverter
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
        private InheritanceBehavior _convertWhenTrue;
		/// <summary>
        /// ソース値がTrueの際にどのInheritanceBehavior列挙体メンバーに変換するかを指定、または取得します。
        /// </summary>
        public InheritanceBehavior ConvertWhenTrue
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
        private InheritanceBehavior _convertWhenFalse;
		/// <summary>
        /// ソース値がFalseの際にどのInheritanceBehavior列挙体メンバーに変換するかを指定、または取得します。
        /// </summary>
        public InheritanceBehavior ConvertWhenFalse
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
            if (!(value is InheritanceBehavior)) throw new ArgumentException();

            var enumValue = (InheritanceBehavior)value;

			switch(enumValue.ToString())
			{
				case "Default":
					if (_isConvertBackWhenDefaultSet)
					{
						return ConvertBackWhenDefault;
					}
					break;
				case "SkipToAppNow":
					if (_isConvertBackWhenSkipToAppNowSet)
					{
						return ConvertBackWhenSkipToAppNow;
					}
					break;
				case "SkipToAppNext":
					if (_isConvertBackWhenSkipToAppNextSet)
					{
						return ConvertBackWhenSkipToAppNext;
					}
					break;
				case "SkipToThemeNow":
					if (_isConvertBackWhenSkipToThemeNowSet)
					{
						return ConvertBackWhenSkipToThemeNow;
					}
					break;
				case "SkipToThemeNext":
					if (_isConvertBackWhenSkipToThemeNextSet)
					{
						return ConvertBackWhenSkipToThemeNext;
					}
					break;
				case "SkipAllNow":
					if (_isConvertBackWhenSkipAllNowSet)
					{
						return ConvertBackWhenSkipAllNow;
					}
					break;
				case "SkipAllNext":
					if (_isConvertBackWhenSkipAllNextSet)
					{
						return ConvertBackWhenSkipAllNext;
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
        /// InheritanceBehaviorの値をbool値に変換する際のデフォルト値を指定、または取得します。
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

        private bool _isConvertBackWhenDefaultSet;
        private bool _convertBackWhenDefault;
		/// <summary>
        /// InheritanceBehaviorの値がDefaultの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenDefault
        {
            get
            {
                return _convertBackWhenDefault;
            }
            set
            {
                _convertBackWhenDefault = value;
                _isConvertBackWhenDefaultSet = true;
            }
        }
        private bool _isConvertBackWhenSkipToAppNowSet;
        private bool _convertBackWhenSkipToAppNow;
		/// <summary>
        /// InheritanceBehaviorの値がSkipToAppNowの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenSkipToAppNow
        {
            get
            {
                return _convertBackWhenSkipToAppNow;
            }
            set
            {
                _convertBackWhenSkipToAppNow = value;
                _isConvertBackWhenSkipToAppNowSet = true;
            }
        }
        private bool _isConvertBackWhenSkipToAppNextSet;
        private bool _convertBackWhenSkipToAppNext;
		/// <summary>
        /// InheritanceBehaviorの値がSkipToAppNextの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenSkipToAppNext
        {
            get
            {
                return _convertBackWhenSkipToAppNext;
            }
            set
            {
                _convertBackWhenSkipToAppNext = value;
                _isConvertBackWhenSkipToAppNextSet = true;
            }
        }
        private bool _isConvertBackWhenSkipToThemeNowSet;
        private bool _convertBackWhenSkipToThemeNow;
		/// <summary>
        /// InheritanceBehaviorの値がSkipToThemeNowの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenSkipToThemeNow
        {
            get
            {
                return _convertBackWhenSkipToThemeNow;
            }
            set
            {
                _convertBackWhenSkipToThemeNow = value;
                _isConvertBackWhenSkipToThemeNowSet = true;
            }
        }
        private bool _isConvertBackWhenSkipToThemeNextSet;
        private bool _convertBackWhenSkipToThemeNext;
		/// <summary>
        /// InheritanceBehaviorの値がSkipToThemeNextの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenSkipToThemeNext
        {
            get
            {
                return _convertBackWhenSkipToThemeNext;
            }
            set
            {
                _convertBackWhenSkipToThemeNext = value;
                _isConvertBackWhenSkipToThemeNextSet = true;
            }
        }
        private bool _isConvertBackWhenSkipAllNowSet;
        private bool _convertBackWhenSkipAllNow;
		/// <summary>
        /// InheritanceBehaviorの値がSkipAllNowの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenSkipAllNow
        {
            get
            {
                return _convertBackWhenSkipAllNow;
            }
            set
            {
                _convertBackWhenSkipAllNow = value;
                _isConvertBackWhenSkipAllNowSet = true;
            }
        }
        private bool _isConvertBackWhenSkipAllNextSet;
        private bool _convertBackWhenSkipAllNext;
		/// <summary>
        /// InheritanceBehaviorの値がSkipAllNextの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenSkipAllNext
        {
            get
            {
                return _convertBackWhenSkipAllNext;
            }
            set
            {
                _convertBackWhenSkipAllNext = value;
                _isConvertBackWhenSkipAllNextSet = true;
            }
        }
    }
}