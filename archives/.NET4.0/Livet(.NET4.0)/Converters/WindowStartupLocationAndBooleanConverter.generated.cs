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
    /// WindowStartupLocation列挙体とbool値の相互変換を行うIValueConverterです。
    /// </summary>
    public class WindowStartupLocationAndBooleanConverter : IValueConverter
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
        private WindowStartupLocation _convertWhenTrue;
		/// <summary>
        /// ソース値がTrueの際にどのWindowStartupLocation列挙体メンバーに変換するかを指定、または取得します。
        /// </summary>
        public WindowStartupLocation ConvertWhenTrue
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
        private WindowStartupLocation _convertWhenFalse;
		/// <summary>
        /// ソース値がFalseの際にどのWindowStartupLocation列挙体メンバーに変換するかを指定、または取得します。
        /// </summary>
        public WindowStartupLocation ConvertWhenFalse
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
            if (!(value is WindowStartupLocation)) throw new ArgumentException();

            var enumValue = (WindowStartupLocation)value;

			switch(enumValue.ToString())
			{
				case "Manual":
					if (_isConvertBackWhenManualSet)
					{
						return ConvertBackWhenManual;
					}
					break;
				case "CenterScreen":
					if (_isConvertBackWhenCenterScreenSet)
					{
						return ConvertBackWhenCenterScreen;
					}
					break;
				case "CenterOwner":
					if (_isConvertBackWhenCenterOwnerSet)
					{
						return ConvertBackWhenCenterOwner;
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
        /// WindowStartupLocationの値をbool値に変換する際のデフォルト値を指定、または取得します。
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

        private bool _isConvertBackWhenManualSet;
        private bool _convertBackWhenManual;
		/// <summary>
        /// WindowStartupLocationの値がManualの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenManual
        {
            get
            {
                return _convertBackWhenManual;
            }
            set
            {
                _convertBackWhenManual = value;
                _isConvertBackWhenManualSet = true;
            }
        }
        private bool _isConvertBackWhenCenterScreenSet;
        private bool _convertBackWhenCenterScreen;
		/// <summary>
        /// WindowStartupLocationの値がCenterScreenの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenCenterScreen
        {
            get
            {
                return _convertBackWhenCenterScreen;
            }
            set
            {
                _convertBackWhenCenterScreen = value;
                _isConvertBackWhenCenterScreenSet = true;
            }
        }
        private bool _isConvertBackWhenCenterOwnerSet;
        private bool _convertBackWhenCenterOwner;
		/// <summary>
        /// WindowStartupLocationの値がCenterOwnerの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenCenterOwner
        {
            get
            {
                return _convertBackWhenCenterOwner;
            }
            set
            {
                _convertBackWhenCenterOwner = value;
                _isConvertBackWhenCenterOwnerSet = true;
            }
        }
    }
}