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
    /// ReasonSessionEnding列挙体とbool値の相互変換を行うIValueConverterです。
    /// </summary>
    public class ReasonSessionEndingAndBooleanConverter : IValueConverter
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
        private ReasonSessionEnding _convertWhenTrue;
		/// <summary>
        /// ソース値がTrueの際にどのReasonSessionEnding列挙体メンバーに変換するかを指定、または取得します。
        /// </summary>
        public ReasonSessionEnding ConvertWhenTrue
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
        private ReasonSessionEnding _convertWhenFalse;
		/// <summary>
        /// ソース値がFalseの際にどのReasonSessionEnding列挙体メンバーに変換するかを指定、または取得します。
        /// </summary>
        public ReasonSessionEnding ConvertWhenFalse
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
            if (!(value is ReasonSessionEnding)) throw new ArgumentException();

            var enumValue = (ReasonSessionEnding)value;

			switch(enumValue.ToString())
			{
				case "Logoff":
					if (_isConvertBackWhenLogoffSet)
					{
						return ConvertBackWhenLogoff;
					}
					break;
				case "Shutdown":
					if (_isConvertBackWhenShutdownSet)
					{
						return ConvertBackWhenShutdown;
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
        /// ReasonSessionEndingの値をbool値に変換する際のデフォルト値を指定、または取得します。
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

        private bool _isConvertBackWhenLogoffSet;
        private bool _convertBackWhenLogoff;
		/// <summary>
        /// ReasonSessionEndingの値がLogoffの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenLogoff
        {
            get
            {
                return _convertBackWhenLogoff;
            }
            set
            {
                _convertBackWhenLogoff = value;
                _isConvertBackWhenLogoffSet = true;
            }
        }
        private bool _isConvertBackWhenShutdownSet;
        private bool _convertBackWhenShutdown;
		/// <summary>
        /// ReasonSessionEndingの値がShutdownの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenShutdown
        {
            get
            {
                return _convertBackWhenShutdown;
            }
            set
            {
                _convertBackWhenShutdown = value;
                _isConvertBackWhenShutdownSet = true;
            }
        }
    }
}