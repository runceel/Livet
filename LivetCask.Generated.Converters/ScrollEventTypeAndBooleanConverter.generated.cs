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
    /// ScrollEventType列挙体とbool値の相互変換を行うIValueConverterです。
    /// </summary>
    public class ScrollEventTypeAndBooleanConverter : IValueConverter
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
        private ScrollEventType _convertWhenTrue;
		/// <summary>
        /// ソース値がTrueの際にどのScrollEventType列挙体メンバーに変換するかを指定、または取得します。
        /// </summary>
        public ScrollEventType ConvertWhenTrue
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
        private ScrollEventType _convertWhenFalse;
		/// <summary>
        /// ソース値がFalseの際にどのScrollEventType列挙体メンバーに変換するかを指定、または取得します。
        /// </summary>
        public ScrollEventType ConvertWhenFalse
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
            if (!(value is ScrollEventType)) throw new ArgumentException();

            var enumValue = (ScrollEventType)value;

			switch(enumValue.ToString())
			{
				case "EndScroll":
					if (_isConvertBackWhenEndScrollSet)
					{
						return ConvertBackWhenEndScroll;
					}
					break;
				case "First":
					if (_isConvertBackWhenFirstSet)
					{
						return ConvertBackWhenFirst;
					}
					break;
				case "LargeDecrement":
					if (_isConvertBackWhenLargeDecrementSet)
					{
						return ConvertBackWhenLargeDecrement;
					}
					break;
				case "LargeIncrement":
					if (_isConvertBackWhenLargeIncrementSet)
					{
						return ConvertBackWhenLargeIncrement;
					}
					break;
				case "Last":
					if (_isConvertBackWhenLastSet)
					{
						return ConvertBackWhenLast;
					}
					break;
				case "SmallDecrement":
					if (_isConvertBackWhenSmallDecrementSet)
					{
						return ConvertBackWhenSmallDecrement;
					}
					break;
				case "SmallIncrement":
					if (_isConvertBackWhenSmallIncrementSet)
					{
						return ConvertBackWhenSmallIncrement;
					}
					break;
				case "ThumbPosition":
					if (_isConvertBackWhenThumbPositionSet)
					{
						return ConvertBackWhenThumbPosition;
					}
					break;
				case "ThumbTrack":
					if (_isConvertBackWhenThumbTrackSet)
					{
						return ConvertBackWhenThumbTrack;
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
        /// ScrollEventTypeの値をbool値に変換する際のデフォルト値を指定、または取得します。
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

        private bool _isConvertBackWhenEndScrollSet;
        private bool _convertBackWhenEndScroll;
		/// <summary>
        /// ScrollEventTypeの値がEndScrollの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenEndScroll
        {
            get
            {
                return _convertBackWhenEndScroll;
            }
            set
            {
                _convertBackWhenEndScroll = value;
                _isConvertBackWhenEndScrollSet = true;
            }
        }
        private bool _isConvertBackWhenFirstSet;
        private bool _convertBackWhenFirst;
		/// <summary>
        /// ScrollEventTypeの値がFirstの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenFirst
        {
            get
            {
                return _convertBackWhenFirst;
            }
            set
            {
                _convertBackWhenFirst = value;
                _isConvertBackWhenFirstSet = true;
            }
        }
        private bool _isConvertBackWhenLargeDecrementSet;
        private bool _convertBackWhenLargeDecrement;
		/// <summary>
        /// ScrollEventTypeの値がLargeDecrementの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenLargeDecrement
        {
            get
            {
                return _convertBackWhenLargeDecrement;
            }
            set
            {
                _convertBackWhenLargeDecrement = value;
                _isConvertBackWhenLargeDecrementSet = true;
            }
        }
        private bool _isConvertBackWhenLargeIncrementSet;
        private bool _convertBackWhenLargeIncrement;
		/// <summary>
        /// ScrollEventTypeの値がLargeIncrementの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenLargeIncrement
        {
            get
            {
                return _convertBackWhenLargeIncrement;
            }
            set
            {
                _convertBackWhenLargeIncrement = value;
                _isConvertBackWhenLargeIncrementSet = true;
            }
        }
        private bool _isConvertBackWhenLastSet;
        private bool _convertBackWhenLast;
		/// <summary>
        /// ScrollEventTypeの値がLastの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenLast
        {
            get
            {
                return _convertBackWhenLast;
            }
            set
            {
                _convertBackWhenLast = value;
                _isConvertBackWhenLastSet = true;
            }
        }
        private bool _isConvertBackWhenSmallDecrementSet;
        private bool _convertBackWhenSmallDecrement;
		/// <summary>
        /// ScrollEventTypeの値がSmallDecrementの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenSmallDecrement
        {
            get
            {
                return _convertBackWhenSmallDecrement;
            }
            set
            {
                _convertBackWhenSmallDecrement = value;
                _isConvertBackWhenSmallDecrementSet = true;
            }
        }
        private bool _isConvertBackWhenSmallIncrementSet;
        private bool _convertBackWhenSmallIncrement;
		/// <summary>
        /// ScrollEventTypeの値がSmallIncrementの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenSmallIncrement
        {
            get
            {
                return _convertBackWhenSmallIncrement;
            }
            set
            {
                _convertBackWhenSmallIncrement = value;
                _isConvertBackWhenSmallIncrementSet = true;
            }
        }
        private bool _isConvertBackWhenThumbPositionSet;
        private bool _convertBackWhenThumbPosition;
		/// <summary>
        /// ScrollEventTypeの値がThumbPositionの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenThumbPosition
        {
            get
            {
                return _convertBackWhenThumbPosition;
            }
            set
            {
                _convertBackWhenThumbPosition = value;
                _isConvertBackWhenThumbPositionSet = true;
            }
        }
        private bool _isConvertBackWhenThumbTrackSet;
        private bool _convertBackWhenThumbTrack;
		/// <summary>
        /// ScrollEventTypeの値がThumbTrackの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenThumbTrack
        {
            get
            {
                return _convertBackWhenThumbTrack;
            }
            set
            {
                _convertBackWhenThumbTrack = value;
                _isConvertBackWhenThumbTrackSet = true;
            }
        }
    }
}