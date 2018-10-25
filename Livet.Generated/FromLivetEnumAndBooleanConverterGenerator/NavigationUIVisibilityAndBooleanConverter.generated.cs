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
    /// NavigationUIVisibility列挙体とbool値の相互変換を行うIValueConverterです。
    /// </summary>
    public class NavigationUIVisibilityAndBooleanConverter : IValueConverter
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
        private NavigationUIVisibility _convertWhenTrue;
		/// <summary>
        /// ソース値がTrueの際にどのNavigationUIVisibility列挙体メンバーに変換するかを指定、または取得します。
        /// </summary>
        public NavigationUIVisibility ConvertWhenTrue
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
        private NavigationUIVisibility _convertWhenFalse;
		/// <summary>
        /// ソース値がFalseの際にどのNavigationUIVisibility列挙体メンバーに変換するかを指定、または取得します。
        /// </summary>
        public NavigationUIVisibility ConvertWhenFalse
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
            if (!(value is NavigationUIVisibility)) throw new ArgumentException();

            var enumValue = (NavigationUIVisibility)value;

			switch(enumValue.ToString())
			{
				case "Automatic":
					if (_isConvertBackWhenAutomaticSet)
					{
						return ConvertBackWhenAutomatic;
					}
					break;
				case "Visible":
					if (_isConvertBackWhenVisibleSet)
					{
						return ConvertBackWhenVisible;
					}
					break;
				case "Hidden":
					if (_isConvertBackWhenHiddenSet)
					{
						return ConvertBackWhenHidden;
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
        /// NavigationUIVisibilityの値をbool値に変換する際のデフォルト値を指定、または取得します。
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

        private bool _isConvertBackWhenAutomaticSet;
        private bool _convertBackWhenAutomatic;
		/// <summary>
        /// NavigationUIVisibilityの値がAutomaticの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenAutomatic
        {
            get
            {
                return _convertBackWhenAutomatic;
            }
            set
            {
                _convertBackWhenAutomatic = value;
                _isConvertBackWhenAutomaticSet = true;
            }
        }
        private bool _isConvertBackWhenVisibleSet;
        private bool _convertBackWhenVisible;
		/// <summary>
        /// NavigationUIVisibilityの値がVisibleの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenVisible
        {
            get
            {
                return _convertBackWhenVisible;
            }
            set
            {
                _convertBackWhenVisible = value;
                _isConvertBackWhenVisibleSet = true;
            }
        }
        private bool _isConvertBackWhenHiddenSet;
        private bool _convertBackWhenHidden;
		/// <summary>
        /// NavigationUIVisibilityの値がHiddenの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenHidden
        {
            get
            {
                return _convertBackWhenHidden;
            }
            set
            {
                _convertBackWhenHidden = value;
                _isConvertBackWhenHiddenSet = true;
            }
        }
    }
}