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
    /// FigureVerticalAnchor列挙体とbool値の相互変換を行うIValueConverterです。
    /// </summary>
    public class FigureVerticalAnchorAndBooleanConverter : IValueConverter
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
        private FigureVerticalAnchor _convertWhenTrue;
		/// <summary>
        /// ソース値がTrueの際にどのFigureVerticalAnchor列挙体メンバーに変換するかを指定、または取得します。
        /// </summary>
        public FigureVerticalAnchor ConvertWhenTrue
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
        private FigureVerticalAnchor _convertWhenFalse;
		/// <summary>
        /// ソース値がFalseの際にどのFigureVerticalAnchor列挙体メンバーに変換するかを指定、または取得します。
        /// </summary>
        public FigureVerticalAnchor ConvertWhenFalse
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
            if (!(value is FigureVerticalAnchor)) throw new ArgumentException();

            var enumValue = (FigureVerticalAnchor)value;

			switch(enumValue.ToString())
			{
				case "PageTop":
					if (_isConvertBackWhenPageTopSet)
					{
						return ConvertBackWhenPageTop;
					}
					break;
				case "PageCenter":
					if (_isConvertBackWhenPageCenterSet)
					{
						return ConvertBackWhenPageCenter;
					}
					break;
				case "PageBottom":
					if (_isConvertBackWhenPageBottomSet)
					{
						return ConvertBackWhenPageBottom;
					}
					break;
				case "ContentTop":
					if (_isConvertBackWhenContentTopSet)
					{
						return ConvertBackWhenContentTop;
					}
					break;
				case "ContentCenter":
					if (_isConvertBackWhenContentCenterSet)
					{
						return ConvertBackWhenContentCenter;
					}
					break;
				case "ContentBottom":
					if (_isConvertBackWhenContentBottomSet)
					{
						return ConvertBackWhenContentBottom;
					}
					break;
				case "ParagraphTop":
					if (_isConvertBackWhenParagraphTopSet)
					{
						return ConvertBackWhenParagraphTop;
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
        /// FigureVerticalAnchorの値をbool値に変換する際のデフォルト値を指定、または取得します。
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

        private bool _isConvertBackWhenPageTopSet;
        private bool _convertBackWhenPageTop;
		/// <summary>
        /// FigureVerticalAnchorの値がPageTopの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenPageTop
        {
            get
            {
                return _convertBackWhenPageTop;
            }
            set
            {
                _convertBackWhenPageTop = value;
                _isConvertBackWhenPageTopSet = true;
            }
        }
        private bool _isConvertBackWhenPageCenterSet;
        private bool _convertBackWhenPageCenter;
		/// <summary>
        /// FigureVerticalAnchorの値がPageCenterの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
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
        private bool _isConvertBackWhenPageBottomSet;
        private bool _convertBackWhenPageBottom;
		/// <summary>
        /// FigureVerticalAnchorの値がPageBottomの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenPageBottom
        {
            get
            {
                return _convertBackWhenPageBottom;
            }
            set
            {
                _convertBackWhenPageBottom = value;
                _isConvertBackWhenPageBottomSet = true;
            }
        }
        private bool _isConvertBackWhenContentTopSet;
        private bool _convertBackWhenContentTop;
		/// <summary>
        /// FigureVerticalAnchorの値がContentTopの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenContentTop
        {
            get
            {
                return _convertBackWhenContentTop;
            }
            set
            {
                _convertBackWhenContentTop = value;
                _isConvertBackWhenContentTopSet = true;
            }
        }
        private bool _isConvertBackWhenContentCenterSet;
        private bool _convertBackWhenContentCenter;
		/// <summary>
        /// FigureVerticalAnchorの値がContentCenterの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
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
        private bool _isConvertBackWhenContentBottomSet;
        private bool _convertBackWhenContentBottom;
		/// <summary>
        /// FigureVerticalAnchorの値がContentBottomの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenContentBottom
        {
            get
            {
                return _convertBackWhenContentBottom;
            }
            set
            {
                _convertBackWhenContentBottom = value;
                _isConvertBackWhenContentBottomSet = true;
            }
        }
        private bool _isConvertBackWhenParagraphTopSet;
        private bool _convertBackWhenParagraphTop;
		/// <summary>
        /// FigureVerticalAnchorの値がParagraphTopの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenParagraphTop
        {
            get
            {
                return _convertBackWhenParagraphTop;
            }
            set
            {
                _convertBackWhenParagraphTop = value;
                _isConvertBackWhenParagraphTopSet = true;
            }
        }
    }
}