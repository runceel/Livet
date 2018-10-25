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
    /// TabletHardwareCapabilities列挙体とbool値の相互変換を行うIValueConverterです。
    /// </summary>
    public class TabletHardwareCapabilitiesAndBooleanConverter : IValueConverter
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
        private TabletHardwareCapabilities _convertWhenTrue;
		/// <summary>
        /// ソース値がTrueの際にどのTabletHardwareCapabilities列挙体メンバーに変換するかを指定、または取得します。
        /// </summary>
        public TabletHardwareCapabilities ConvertWhenTrue
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
        private TabletHardwareCapabilities _convertWhenFalse;
		/// <summary>
        /// ソース値がFalseの際にどのTabletHardwareCapabilities列挙体メンバーに変換するかを指定、または取得します。
        /// </summary>
        public TabletHardwareCapabilities ConvertWhenFalse
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
            if (!(value is TabletHardwareCapabilities)) throw new ArgumentException();

            var enumValue = (TabletHardwareCapabilities)value;

			switch(enumValue.ToString())
			{
				case "None":
					if (_isConvertBackWhenNoneSet)
					{
						return ConvertBackWhenNone;
					}
					break;
				case "Integrated":
					if (_isConvertBackWhenIntegratedSet)
					{
						return ConvertBackWhenIntegrated;
					}
					break;
				case "StylusMustTouch":
					if (_isConvertBackWhenStylusMustTouchSet)
					{
						return ConvertBackWhenStylusMustTouch;
					}
					break;
				case "HardProximity":
					if (_isConvertBackWhenHardProximitySet)
					{
						return ConvertBackWhenHardProximity;
					}
					break;
				case "StylusHasPhysicalIds":
					if (_isConvertBackWhenStylusHasPhysicalIdsSet)
					{
						return ConvertBackWhenStylusHasPhysicalIds;
					}
					break;
				case "SupportsPressure":
					if (_isConvertBackWhenSupportsPressureSet)
					{
						return ConvertBackWhenSupportsPressure;
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
        /// TabletHardwareCapabilitiesの値をbool値に変換する際のデフォルト値を指定、または取得します。
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

        private bool _isConvertBackWhenNoneSet;
        private bool _convertBackWhenNone;
		/// <summary>
        /// TabletHardwareCapabilitiesの値がNoneの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenNone
        {
            get
            {
                return _convertBackWhenNone;
            }
            set
            {
                _convertBackWhenNone = value;
                _isConvertBackWhenNoneSet = true;
            }
        }
        private bool _isConvertBackWhenIntegratedSet;
        private bool _convertBackWhenIntegrated;
		/// <summary>
        /// TabletHardwareCapabilitiesの値がIntegratedの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenIntegrated
        {
            get
            {
                return _convertBackWhenIntegrated;
            }
            set
            {
                _convertBackWhenIntegrated = value;
                _isConvertBackWhenIntegratedSet = true;
            }
        }
        private bool _isConvertBackWhenStylusMustTouchSet;
        private bool _convertBackWhenStylusMustTouch;
		/// <summary>
        /// TabletHardwareCapabilitiesの値がStylusMustTouchの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenStylusMustTouch
        {
            get
            {
                return _convertBackWhenStylusMustTouch;
            }
            set
            {
                _convertBackWhenStylusMustTouch = value;
                _isConvertBackWhenStylusMustTouchSet = true;
            }
        }
        private bool _isConvertBackWhenHardProximitySet;
        private bool _convertBackWhenHardProximity;
		/// <summary>
        /// TabletHardwareCapabilitiesの値がHardProximityの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenHardProximity
        {
            get
            {
                return _convertBackWhenHardProximity;
            }
            set
            {
                _convertBackWhenHardProximity = value;
                _isConvertBackWhenHardProximitySet = true;
            }
        }
        private bool _isConvertBackWhenStylusHasPhysicalIdsSet;
        private bool _convertBackWhenStylusHasPhysicalIds;
		/// <summary>
        /// TabletHardwareCapabilitiesの値がStylusHasPhysicalIdsの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenStylusHasPhysicalIds
        {
            get
            {
                return _convertBackWhenStylusHasPhysicalIds;
            }
            set
            {
                _convertBackWhenStylusHasPhysicalIds = value;
                _isConvertBackWhenStylusHasPhysicalIdsSet = true;
            }
        }
        private bool _isConvertBackWhenSupportsPressureSet;
        private bool _convertBackWhenSupportsPressure;
		/// <summary>
        /// TabletHardwareCapabilitiesの値がSupportsPressureの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenSupportsPressure
        {
            get
            {
                return _convertBackWhenSupportsPressure;
            }
            set
            {
                _convertBackWhenSupportsPressure = value;
                _isConvertBackWhenSupportsPressureSet = true;
            }
        }
    }
}