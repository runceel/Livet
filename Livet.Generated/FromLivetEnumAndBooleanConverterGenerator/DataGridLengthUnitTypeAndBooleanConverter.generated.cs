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
    /// DataGridLengthUnitType列挙体とbool値の相互変換を行うIValueConverterです。
    /// </summary>
    public class DataGridLengthUnitTypeAndBooleanConverter : IValueConverter
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
        private DataGridLengthUnitType _convertWhenTrue;
		/// <summary>
        /// ソース値がTrueの際にどのDataGridLengthUnitType列挙体メンバーに変換するかを指定、または取得します。
        /// </summary>
        public DataGridLengthUnitType ConvertWhenTrue
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
        private DataGridLengthUnitType _convertWhenFalse;
		/// <summary>
        /// ソース値がFalseの際にどのDataGridLengthUnitType列挙体メンバーに変換するかを指定、または取得します。
        /// </summary>
        public DataGridLengthUnitType ConvertWhenFalse
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
            if (!(value is DataGridLengthUnitType)) throw new ArgumentException();

            var enumValue = (DataGridLengthUnitType)value;

			switch(enumValue.ToString())
			{
				case "Auto":
					if (_isConvertBackWhenAutoSet)
					{
						return ConvertBackWhenAuto;
					}
					break;
				case "Pixel":
					if (_isConvertBackWhenPixelSet)
					{
						return ConvertBackWhenPixel;
					}
					break;
				case "SizeToCells":
					if (_isConvertBackWhenSizeToCellsSet)
					{
						return ConvertBackWhenSizeToCells;
					}
					break;
				case "SizeToHeader":
					if (_isConvertBackWhenSizeToHeaderSet)
					{
						return ConvertBackWhenSizeToHeader;
					}
					break;
				case "Star":
					if (_isConvertBackWhenStarSet)
					{
						return ConvertBackWhenStar;
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
        /// DataGridLengthUnitTypeの値をbool値に変換する際のデフォルト値を指定、または取得します。
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

        private bool _isConvertBackWhenAutoSet;
        private bool _convertBackWhenAuto;
		/// <summary>
        /// DataGridLengthUnitTypeの値がAutoの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenAuto
        {
            get
            {
                return _convertBackWhenAuto;
            }
            set
            {
                _convertBackWhenAuto = value;
                _isConvertBackWhenAutoSet = true;
            }
        }
        private bool _isConvertBackWhenPixelSet;
        private bool _convertBackWhenPixel;
		/// <summary>
        /// DataGridLengthUnitTypeの値がPixelの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenPixel
        {
            get
            {
                return _convertBackWhenPixel;
            }
            set
            {
                _convertBackWhenPixel = value;
                _isConvertBackWhenPixelSet = true;
            }
        }
        private bool _isConvertBackWhenSizeToCellsSet;
        private bool _convertBackWhenSizeToCells;
		/// <summary>
        /// DataGridLengthUnitTypeの値がSizeToCellsの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenSizeToCells
        {
            get
            {
                return _convertBackWhenSizeToCells;
            }
            set
            {
                _convertBackWhenSizeToCells = value;
                _isConvertBackWhenSizeToCellsSet = true;
            }
        }
        private bool _isConvertBackWhenSizeToHeaderSet;
        private bool _convertBackWhenSizeToHeader;
		/// <summary>
        /// DataGridLengthUnitTypeの値がSizeToHeaderの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenSizeToHeader
        {
            get
            {
                return _convertBackWhenSizeToHeader;
            }
            set
            {
                _convertBackWhenSizeToHeader = value;
                _isConvertBackWhenSizeToHeaderSet = true;
            }
        }
        private bool _isConvertBackWhenStarSet;
        private bool _convertBackWhenStar;
		/// <summary>
        /// DataGridLengthUnitTypeの値がStarの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenStar
        {
            get
            {
                return _convertBackWhenStar;
            }
            set
            {
                _convertBackWhenStar = value;
                _isConvertBackWhenStarSet = true;
            }
        }
    }
}