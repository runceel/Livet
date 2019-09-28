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
    /// Visibility列挙体とbool値の相互変換を行うIValueConverterです。
    /// </summary>
    public class VisibilityAndBooleanConverter : IValueConverter
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
        private Visibility _convertWhenTrue;
		/// <summary>
        /// ソース値がTrueの際にどのVisibility列挙体メンバーに変換するかを指定、または取得します。
        /// </summary>
        public Visibility ConvertWhenTrue
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
        private Visibility _convertWhenFalse;
		/// <summary>
        /// ソース値がFalseの際にどのVisibility列挙体メンバーに変換するかを指定、または取得します。
        /// </summary>
        public Visibility ConvertWhenFalse
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
            if (!(value is Visibility)) throw new ArgumentException();

            var enumValue = (Visibility)value;

			switch(enumValue.ToString())
			{
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
				case "Collapsed":
					if (_isConvertBackWhenCollapsedSet)
					{
						return ConvertBackWhenCollapsed;
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
        /// Visibilityの値をbool値に変換する際のデフォルト値を指定、または取得します。
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

        private bool _isConvertBackWhenVisibleSet;
        private bool _convertBackWhenVisible;
		/// <summary>
        /// Visibilityの値がVisibleの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
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
        /// Visibilityの値がHiddenの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
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
        private bool _isConvertBackWhenCollapsedSet;
        private bool _convertBackWhenCollapsed;
		/// <summary>
        /// Visibilityの値がCollapsedの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenCollapsed
        {
            get
            {
                return _convertBackWhenCollapsed;
            }
            set
            {
                _convertBackWhenCollapsed = value;
                _isConvertBackWhenCollapsedSet = true;
            }
        }
    }
}