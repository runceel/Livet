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
    /// MenuItemRole列挙体とbool値の相互変換を行うIValueConverterです。
    /// </summary>
    public class MenuItemRoleAndBooleanConverter : IValueConverter
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
        private MenuItemRole _convertWhenTrue;
		/// <summary>
        /// ソース値がTrueの際にどのMenuItemRole列挙体メンバーに変換するかを指定、または取得します。
        /// </summary>
        public MenuItemRole ConvertWhenTrue
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
        private MenuItemRole _convertWhenFalse;
		/// <summary>
        /// ソース値がFalseの際にどのMenuItemRole列挙体メンバーに変換するかを指定、または取得します。
        /// </summary>
        public MenuItemRole ConvertWhenFalse
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
            if (!(value is MenuItemRole)) throw new ArgumentException();

            var enumValue = (MenuItemRole)value;

			switch(enumValue.ToString())
			{
				case "TopLevelItem":
					if (_isConvertBackWhenTopLevelItemSet)
					{
						return ConvertBackWhenTopLevelItem;
					}
					break;
				case "TopLevelHeader":
					if (_isConvertBackWhenTopLevelHeaderSet)
					{
						return ConvertBackWhenTopLevelHeader;
					}
					break;
				case "SubmenuItem":
					if (_isConvertBackWhenSubmenuItemSet)
					{
						return ConvertBackWhenSubmenuItem;
					}
					break;
				case "SubmenuHeader":
					if (_isConvertBackWhenSubmenuHeaderSet)
					{
						return ConvertBackWhenSubmenuHeader;
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
        /// MenuItemRoleの値をbool値に変換する際のデフォルト値を指定、または取得します。
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

        private bool _isConvertBackWhenTopLevelItemSet;
        private bool _convertBackWhenTopLevelItem;
		/// <summary>
        /// MenuItemRoleの値がTopLevelItemの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenTopLevelItem
        {
            get
            {
                return _convertBackWhenTopLevelItem;
            }
            set
            {
                _convertBackWhenTopLevelItem = value;
                _isConvertBackWhenTopLevelItemSet = true;
            }
        }
        private bool _isConvertBackWhenTopLevelHeaderSet;
        private bool _convertBackWhenTopLevelHeader;
		/// <summary>
        /// MenuItemRoleの値がTopLevelHeaderの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenTopLevelHeader
        {
            get
            {
                return _convertBackWhenTopLevelHeader;
            }
            set
            {
                _convertBackWhenTopLevelHeader = value;
                _isConvertBackWhenTopLevelHeaderSet = true;
            }
        }
        private bool _isConvertBackWhenSubmenuItemSet;
        private bool _convertBackWhenSubmenuItem;
		/// <summary>
        /// MenuItemRoleの値がSubmenuItemの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenSubmenuItem
        {
            get
            {
                return _convertBackWhenSubmenuItem;
            }
            set
            {
                _convertBackWhenSubmenuItem = value;
                _isConvertBackWhenSubmenuItemSet = true;
            }
        }
        private bool _isConvertBackWhenSubmenuHeaderSet;
        private bool _convertBackWhenSubmenuHeader;
		/// <summary>
        /// MenuItemRoleの値がSubmenuHeaderの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenSubmenuHeader
        {
            get
            {
                return _convertBackWhenSubmenuHeader;
            }
            set
            {
                _convertBackWhenSubmenuHeader = value;
                _isConvertBackWhenSubmenuHeaderSet = true;
            }
        }
    }
}