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
    /// PopupAnimation列挙体とbool値の相互変換を行うIValueConverterです。
    /// </summary>
    public class PopupAnimationAndBooleanConverter : IValueConverter
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
        private PopupAnimation _convertWhenTrue;
		/// <summary>
        /// ソース値がTrueの際にどのPopupAnimation列挙体メンバーに変換するかを指定、または取得します。
        /// </summary>
        public PopupAnimation ConvertWhenTrue
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
        private PopupAnimation _convertWhenFalse;
		/// <summary>
        /// ソース値がFalseの際にどのPopupAnimation列挙体メンバーに変換するかを指定、または取得します。
        /// </summary>
        public PopupAnimation ConvertWhenFalse
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
            if (!(value is PopupAnimation)) throw new ArgumentException();

            var enumValue = (PopupAnimation)value;

			switch(enumValue.ToString())
			{
				case "None":
					if (_isConvertBackWhenNoneSet)
					{
						return ConvertBackWhenNone;
					}
					break;
				case "Fade":
					if (_isConvertBackWhenFadeSet)
					{
						return ConvertBackWhenFade;
					}
					break;
				case "Slide":
					if (_isConvertBackWhenSlideSet)
					{
						return ConvertBackWhenSlide;
					}
					break;
				case "Scroll":
					if (_isConvertBackWhenScrollSet)
					{
						return ConvertBackWhenScroll;
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
        /// PopupAnimationの値をbool値に変換する際のデフォルト値を指定、または取得します。
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
        /// PopupAnimationの値がNoneの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
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
        private bool _isConvertBackWhenFadeSet;
        private bool _convertBackWhenFade;
		/// <summary>
        /// PopupAnimationの値がFadeの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenFade
        {
            get
            {
                return _convertBackWhenFade;
            }
            set
            {
                _convertBackWhenFade = value;
                _isConvertBackWhenFadeSet = true;
            }
        }
        private bool _isConvertBackWhenSlideSet;
        private bool _convertBackWhenSlide;
		/// <summary>
        /// PopupAnimationの値がSlideの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenSlide
        {
            get
            {
                return _convertBackWhenSlide;
            }
            set
            {
                _convertBackWhenSlide = value;
                _isConvertBackWhenSlideSet = true;
            }
        }
        private bool _isConvertBackWhenScrollSet;
        private bool _convertBackWhenScroll;
		/// <summary>
        /// PopupAnimationの値がScrollの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenScroll
        {
            get
            {
                return _convertBackWhenScroll;
            }
            set
            {
                _convertBackWhenScroll = value;
                _isConvertBackWhenScrollSet = true;
            }
        }
    }
}