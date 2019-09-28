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
    /// NavigationMode列挙体とbool値の相互変換を行うIValueConverterです。
    /// </summary>
    public class NavigationModeAndBooleanConverter : IValueConverter
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
        private NavigationMode _convertWhenTrue;
		/// <summary>
        /// ソース値がTrueの際にどのNavigationMode列挙体メンバーに変換するかを指定、または取得します。
        /// </summary>
        public NavigationMode ConvertWhenTrue
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
        private NavigationMode _convertWhenFalse;
		/// <summary>
        /// ソース値がFalseの際にどのNavigationMode列挙体メンバーに変換するかを指定、または取得します。
        /// </summary>
        public NavigationMode ConvertWhenFalse
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
            if (!(value is NavigationMode)) throw new ArgumentException();

            var enumValue = (NavigationMode)value;

			switch(enumValue.ToString())
			{
				case "New":
					if (_isConvertBackWhenNewSet)
					{
						return ConvertBackWhenNew;
					}
					break;
				case "Back":
					if (_isConvertBackWhenBackSet)
					{
						return ConvertBackWhenBack;
					}
					break;
				case "Forward":
					if (_isConvertBackWhenForwardSet)
					{
						return ConvertBackWhenForward;
					}
					break;
				case "Refresh":
					if (_isConvertBackWhenRefreshSet)
					{
						return ConvertBackWhenRefresh;
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
        /// NavigationModeの値をbool値に変換する際のデフォルト値を指定、または取得します。
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

        private bool _isConvertBackWhenNewSet;
        private bool _convertBackWhenNew;
		/// <summary>
        /// NavigationModeの値がNewの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenNew
        {
            get
            {
                return _convertBackWhenNew;
            }
            set
            {
                _convertBackWhenNew = value;
                _isConvertBackWhenNewSet = true;
            }
        }
        private bool _isConvertBackWhenBackSet;
        private bool _convertBackWhenBack;
		/// <summary>
        /// NavigationModeの値がBackの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenBack
        {
            get
            {
                return _convertBackWhenBack;
            }
            set
            {
                _convertBackWhenBack = value;
                _isConvertBackWhenBackSet = true;
            }
        }
        private bool _isConvertBackWhenForwardSet;
        private bool _convertBackWhenForward;
		/// <summary>
        /// NavigationModeの値がForwardの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenForward
        {
            get
            {
                return _convertBackWhenForward;
            }
            set
            {
                _convertBackWhenForward = value;
                _isConvertBackWhenForwardSet = true;
            }
        }
        private bool _isConvertBackWhenRefreshSet;
        private bool _convertBackWhenRefresh;
		/// <summary>
        /// NavigationModeの値がRefreshの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenRefresh
        {
            get
            {
                return _convertBackWhenRefresh;
            }
            set
            {
                _convertBackWhenRefresh = value;
                _isConvertBackWhenRefreshSet = true;
            }
        }
    }
}