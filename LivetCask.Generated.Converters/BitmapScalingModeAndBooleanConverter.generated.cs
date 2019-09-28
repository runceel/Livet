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
    /// BitmapScalingMode列挙体とbool値の相互変換を行うIValueConverterです。
    /// </summary>
    public class BitmapScalingModeAndBooleanConverter : IValueConverter
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
        private BitmapScalingMode _convertWhenTrue;
		/// <summary>
        /// ソース値がTrueの際にどのBitmapScalingMode列挙体メンバーに変換するかを指定、または取得します。
        /// </summary>
        public BitmapScalingMode ConvertWhenTrue
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
        private BitmapScalingMode _convertWhenFalse;
		/// <summary>
        /// ソース値がFalseの際にどのBitmapScalingMode列挙体メンバーに変換するかを指定、または取得します。
        /// </summary>
        public BitmapScalingMode ConvertWhenFalse
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
            if (!(value is BitmapScalingMode)) throw new ArgumentException();

            var enumValue = (BitmapScalingMode)value;

			switch(enumValue.ToString())
			{
				case "Unspecified":
					if (_isConvertBackWhenUnspecifiedSet)
					{
						return ConvertBackWhenUnspecified;
					}
					break;
				case "LowQuality":
					if (_isConvertBackWhenLowQualitySet)
					{
						return ConvertBackWhenLowQuality;
					}
					break;
				case "Linear":
					if (_isConvertBackWhenLinearSet)
					{
						return ConvertBackWhenLinear;
					}
					break;
				case "HighQuality":
					if (_isConvertBackWhenHighQualitySet)
					{
						return ConvertBackWhenHighQuality;
					}
					break;
				case "Fant":
					if (_isConvertBackWhenFantSet)
					{
						return ConvertBackWhenFant;
					}
					break;
				case "NearestNeighbor":
					if (_isConvertBackWhenNearestNeighborSet)
					{
						return ConvertBackWhenNearestNeighbor;
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
        /// BitmapScalingModeの値をbool値に変換する際のデフォルト値を指定、または取得します。
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

        private bool _isConvertBackWhenUnspecifiedSet;
        private bool _convertBackWhenUnspecified;
		/// <summary>
        /// BitmapScalingModeの値がUnspecifiedの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenUnspecified
        {
            get
            {
                return _convertBackWhenUnspecified;
            }
            set
            {
                _convertBackWhenUnspecified = value;
                _isConvertBackWhenUnspecifiedSet = true;
            }
        }
        private bool _isConvertBackWhenLowQualitySet;
        private bool _convertBackWhenLowQuality;
		/// <summary>
        /// BitmapScalingModeの値がLowQualityの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenLowQuality
        {
            get
            {
                return _convertBackWhenLowQuality;
            }
            set
            {
                _convertBackWhenLowQuality = value;
                _isConvertBackWhenLowQualitySet = true;
            }
        }
        private bool _isConvertBackWhenLinearSet;
        private bool _convertBackWhenLinear;
		/// <summary>
        /// BitmapScalingModeの値がLinearの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenLinear
        {
            get
            {
                return _convertBackWhenLinear;
            }
            set
            {
                _convertBackWhenLinear = value;
                _isConvertBackWhenLinearSet = true;
            }
        }
        private bool _isConvertBackWhenHighQualitySet;
        private bool _convertBackWhenHighQuality;
		/// <summary>
        /// BitmapScalingModeの値がHighQualityの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenHighQuality
        {
            get
            {
                return _convertBackWhenHighQuality;
            }
            set
            {
                _convertBackWhenHighQuality = value;
                _isConvertBackWhenHighQualitySet = true;
            }
        }
        private bool _isConvertBackWhenFantSet;
        private bool _convertBackWhenFant;
		/// <summary>
        /// BitmapScalingModeの値がFantの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenFant
        {
            get
            {
                return _convertBackWhenFant;
            }
            set
            {
                _convertBackWhenFant = value;
                _isConvertBackWhenFantSet = true;
            }
        }
        private bool _isConvertBackWhenNearestNeighborSet;
        private bool _convertBackWhenNearestNeighbor;
		/// <summary>
        /// BitmapScalingModeの値がNearestNeighborの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenNearestNeighbor
        {
            get
            {
                return _convertBackWhenNearestNeighbor;
            }
            set
            {
                _convertBackWhenNearestNeighbor = value;
                _isConvertBackWhenNearestNeighborSet = true;
            }
        }
    }
}