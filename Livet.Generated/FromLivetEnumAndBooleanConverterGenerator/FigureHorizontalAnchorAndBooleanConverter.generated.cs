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
    /// FigureHorizontalAnchor列挙体とbool値の相互変換を行うIValueConverterです。
    /// </summary>
    public class FigureHorizontalAnchorAndBooleanConverter : IValueConverter
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
        private FigureHorizontalAnchor _convertWhenTrue;
		/// <summary>
        /// ソース値がTrueの際にどのFigureHorizontalAnchor列挙体メンバーに変換するかを指定、または取得します。
        /// </summary>
        public FigureHorizontalAnchor ConvertWhenTrue
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
        private FigureHorizontalAnchor _convertWhenFalse;
		/// <summary>
        /// ソース値がFalseの際にどのFigureHorizontalAnchor列挙体メンバーに変換するかを指定、または取得します。
        /// </summary>
        public FigureHorizontalAnchor ConvertWhenFalse
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
            if (!(value is FigureHorizontalAnchor)) throw new ArgumentException();

            var enumValue = (FigureHorizontalAnchor)value;

			switch(enumValue.ToString())
			{
				case "PageLeft":
					if (_isConvertBackWhenPageLeftSet)
					{
						return ConvertBackWhenPageLeft;
					}
					break;
				case "PageCenter":
					if (_isConvertBackWhenPageCenterSet)
					{
						return ConvertBackWhenPageCenter;
					}
					break;
				case "PageRight":
					if (_isConvertBackWhenPageRightSet)
					{
						return ConvertBackWhenPageRight;
					}
					break;
				case "ContentLeft":
					if (_isConvertBackWhenContentLeftSet)
					{
						return ConvertBackWhenContentLeft;
					}
					break;
				case "ContentCenter":
					if (_isConvertBackWhenContentCenterSet)
					{
						return ConvertBackWhenContentCenter;
					}
					break;
				case "ContentRight":
					if (_isConvertBackWhenContentRightSet)
					{
						return ConvertBackWhenContentRight;
					}
					break;
				case "ColumnLeft":
					if (_isConvertBackWhenColumnLeftSet)
					{
						return ConvertBackWhenColumnLeft;
					}
					break;
				case "ColumnCenter":
					if (_isConvertBackWhenColumnCenterSet)
					{
						return ConvertBackWhenColumnCenter;
					}
					break;
				case "ColumnRight":
					if (_isConvertBackWhenColumnRightSet)
					{
						return ConvertBackWhenColumnRight;
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
        /// FigureHorizontalAnchorの値をbool値に変換する際のデフォルト値を指定、または取得します。
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

        private bool _isConvertBackWhenPageLeftSet;
        private bool _convertBackWhenPageLeft;
		/// <summary>
        /// FigureHorizontalAnchorの値がPageLeftの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenPageLeft
        {
            get
            {
                return _convertBackWhenPageLeft;
            }
            set
            {
                _convertBackWhenPageLeft = value;
                _isConvertBackWhenPageLeftSet = true;
            }
        }
        private bool _isConvertBackWhenPageCenterSet;
        private bool _convertBackWhenPageCenter;
		/// <summary>
        /// FigureHorizontalAnchorの値がPageCenterの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenPageCenter
        {
            get
            {
                return _convertBackWhenPageCenter;
            }
            set
            {
                _convertBackWhenPageCenter = value;
                _isConvertBackWhenPageCenterSet = true;
            }
        }
        private bool _isConvertBackWhenPageRightSet;
        private bool _convertBackWhenPageRight;
		/// <summary>
        /// FigureHorizontalAnchorの値がPageRightの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenPageRight
        {
            get
            {
                return _convertBackWhenPageRight;
            }
            set
            {
                _convertBackWhenPageRight = value;
                _isConvertBackWhenPageRightSet = true;
            }
        }
        private bool _isConvertBackWhenContentLeftSet;
        private bool _convertBackWhenContentLeft;
		/// <summary>
        /// FigureHorizontalAnchorの値がContentLeftの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenContentLeft
        {
            get
            {
                return _convertBackWhenContentLeft;
            }
            set
            {
                _convertBackWhenContentLeft = value;
                _isConvertBackWhenContentLeftSet = true;
            }
        }
        private bool _isConvertBackWhenContentCenterSet;
        private bool _convertBackWhenContentCenter;
		/// <summary>
        /// FigureHorizontalAnchorの値がContentCenterの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenContentCenter
        {
            get
            {
                return _convertBackWhenContentCenter;
            }
            set
            {
                _convertBackWhenContentCenter = value;
                _isConvertBackWhenContentCenterSet = true;
            }
        }
        private bool _isConvertBackWhenContentRightSet;
        private bool _convertBackWhenContentRight;
		/// <summary>
        /// FigureHorizontalAnchorの値がContentRightの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenContentRight
        {
            get
            {
                return _convertBackWhenContentRight;
            }
            set
            {
                _convertBackWhenContentRight = value;
                _isConvertBackWhenContentRightSet = true;
            }
        }
        private bool _isConvertBackWhenColumnLeftSet;
        private bool _convertBackWhenColumnLeft;
		/// <summary>
        /// FigureHorizontalAnchorの値がColumnLeftの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenColumnLeft
        {
            get
            {
                return _convertBackWhenColumnLeft;
            }
            set
            {
                _convertBackWhenColumnLeft = value;
                _isConvertBackWhenColumnLeftSet = true;
            }
        }
        private bool _isConvertBackWhenColumnCenterSet;
        private bool _convertBackWhenColumnCenter;
		/// <summary>
        /// FigureHorizontalAnchorの値がColumnCenterの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenColumnCenter
        {
            get
            {
                return _convertBackWhenColumnCenter;
            }
            set
            {
                _convertBackWhenColumnCenter = value;
                _isConvertBackWhenColumnCenterSet = true;
            }
        }
        private bool _isConvertBackWhenColumnRightSet;
        private bool _convertBackWhenColumnRight;
		/// <summary>
        /// FigureHorizontalAnchorの値がColumnRightの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenColumnRight
        {
            get
            {
                return _convertBackWhenColumnRight;
            }
            set
            {
                _convertBackWhenColumnRight = value;
                _isConvertBackWhenColumnRightSet = true;
            }
        }
    }
}