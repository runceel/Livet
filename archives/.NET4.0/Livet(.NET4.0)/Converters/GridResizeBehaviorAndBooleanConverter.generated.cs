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
    /// GridResizeBehavior列挙体とbool値の相互変換を行うIValueConverterです。
    /// </summary>
    public class GridResizeBehaviorAndBooleanConverter : IValueConverter
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
        private GridResizeBehavior _convertWhenTrue;
		/// <summary>
        /// ソース値がTrueの際にどのGridResizeBehavior列挙体メンバーに変換するかを指定、または取得します。
        /// </summary>
        public GridResizeBehavior ConvertWhenTrue
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
        private GridResizeBehavior _convertWhenFalse;
		/// <summary>
        /// ソース値がFalseの際にどのGridResizeBehavior列挙体メンバーに変換するかを指定、または取得します。
        /// </summary>
        public GridResizeBehavior ConvertWhenFalse
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
            if (!(value is GridResizeBehavior)) throw new ArgumentException();

            var enumValue = (GridResizeBehavior)value;

			switch(enumValue.ToString())
			{
				case "BasedOnAlignment":
					if (_isConvertBackWhenBasedOnAlignmentSet)
					{
						return ConvertBackWhenBasedOnAlignment;
					}
					break;
				case "CurrentAndNext":
					if (_isConvertBackWhenCurrentAndNextSet)
					{
						return ConvertBackWhenCurrentAndNext;
					}
					break;
				case "PreviousAndCurrent":
					if (_isConvertBackWhenPreviousAndCurrentSet)
					{
						return ConvertBackWhenPreviousAndCurrent;
					}
					break;
				case "PreviousAndNext":
					if (_isConvertBackWhenPreviousAndNextSet)
					{
						return ConvertBackWhenPreviousAndNext;
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
        /// GridResizeBehaviorの値をbool値に変換する際のデフォルト値を指定、または取得します。
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

        private bool _isConvertBackWhenBasedOnAlignmentSet;
        private bool _convertBackWhenBasedOnAlignment;
		/// <summary>
        /// GridResizeBehaviorの値がBasedOnAlignmentの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenBasedOnAlignment
        {
            get
            {
                return _convertBackWhenBasedOnAlignment;
            }
            set
            {
                _convertBackWhenBasedOnAlignment = value;
                _isConvertBackWhenBasedOnAlignmentSet = true;
            }
        }
        private bool _isConvertBackWhenCurrentAndNextSet;
        private bool _convertBackWhenCurrentAndNext;
		/// <summary>
        /// GridResizeBehaviorの値がCurrentAndNextの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenCurrentAndNext
        {
            get
            {
                return _convertBackWhenCurrentAndNext;
            }
            set
            {
                _convertBackWhenCurrentAndNext = value;
                _isConvertBackWhenCurrentAndNextSet = true;
            }
        }
        private bool _isConvertBackWhenPreviousAndCurrentSet;
        private bool _convertBackWhenPreviousAndCurrent;
		/// <summary>
        /// GridResizeBehaviorの値がPreviousAndCurrentの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenPreviousAndCurrent
        {
            get
            {
                return _convertBackWhenPreviousAndCurrent;
            }
            set
            {
                _convertBackWhenPreviousAndCurrent = value;
                _isConvertBackWhenPreviousAndCurrentSet = true;
            }
        }
        private bool _isConvertBackWhenPreviousAndNextSet;
        private bool _convertBackWhenPreviousAndNext;
		/// <summary>
        /// GridResizeBehaviorの値がPreviousAndNextの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenPreviousAndNext
        {
            get
            {
                return _convertBackWhenPreviousAndNext;
            }
            set
            {
                _convertBackWhenPreviousAndNext = value;
                _isConvertBackWhenPreviousAndNextSet = true;
            }
        }
    }
}