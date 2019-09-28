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
    /// UpdateSourceTrigger列挙体とbool値の相互変換を行うIValueConverterです。
    /// </summary>
    public class UpdateSourceTriggerAndBooleanConverter : IValueConverter
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
        private UpdateSourceTrigger _convertWhenTrue;
		/// <summary>
        /// ソース値がTrueの際にどのUpdateSourceTrigger列挙体メンバーに変換するかを指定、または取得します。
        /// </summary>
        public UpdateSourceTrigger ConvertWhenTrue
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
        private UpdateSourceTrigger _convertWhenFalse;
		/// <summary>
        /// ソース値がFalseの際にどのUpdateSourceTrigger列挙体メンバーに変換するかを指定、または取得します。
        /// </summary>
        public UpdateSourceTrigger ConvertWhenFalse
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
            if (!(value is UpdateSourceTrigger)) throw new ArgumentException();

            var enumValue = (UpdateSourceTrigger)value;

			switch(enumValue.ToString())
			{
				case "Default":
					if (_isConvertBackWhenDefaultSet)
					{
						return ConvertBackWhenDefault;
					}
					break;
				case "PropertyChanged":
					if (_isConvertBackWhenPropertyChangedSet)
					{
						return ConvertBackWhenPropertyChanged;
					}
					break;
				case "LostFocus":
					if (_isConvertBackWhenLostFocusSet)
					{
						return ConvertBackWhenLostFocus;
					}
					break;
				case "Explicit":
					if (_isConvertBackWhenExplicitSet)
					{
						return ConvertBackWhenExplicit;
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
        /// UpdateSourceTriggerの値をbool値に変換する際のデフォルト値を指定、または取得します。
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
        /// UpdateSourceTriggerの値がDefaultの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
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
        private bool _isConvertBackWhenPropertyChangedSet;
        private bool _convertBackWhenPropertyChanged;
		/// <summary>
        /// UpdateSourceTriggerの値がPropertyChangedの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenPropertyChanged
        {
            get
            {
                return _convertBackWhenPropertyChanged;
            }
            set
            {
                _convertBackWhenPropertyChanged = value;
                _isConvertBackWhenPropertyChangedSet = true;
            }
        }
        private bool _isConvertBackWhenLostFocusSet;
        private bool _convertBackWhenLostFocus;
		/// <summary>
        /// UpdateSourceTriggerの値がLostFocusの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenLostFocus
        {
            get
            {
                return _convertBackWhenLostFocus;
            }
            set
            {
                _convertBackWhenLostFocus = value;
                _isConvertBackWhenLostFocusSet = true;
            }
        }
        private bool _isConvertBackWhenExplicitSet;
        private bool _convertBackWhenExplicit;
		/// <summary>
        /// UpdateSourceTriggerの値がExplicitの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenExplicit
        {
            get
            {
                return _convertBackWhenExplicit;
            }
            set
            {
                _convertBackWhenExplicit = value;
                _isConvertBackWhenExplicitSet = true;
            }
        }
    }
}