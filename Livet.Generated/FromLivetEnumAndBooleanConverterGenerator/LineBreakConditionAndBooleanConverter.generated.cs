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
    /// LineBreakCondition列挙体とbool値の相互変換を行うIValueConverterです。
    /// </summary>
    public class LineBreakConditionAndBooleanConverter : IValueConverter
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
        private LineBreakCondition _convertWhenTrue;
		/// <summary>
        /// ソース値がTrueの際にどのLineBreakCondition列挙体メンバーに変換するかを指定、または取得します。
        /// </summary>
        public LineBreakCondition ConvertWhenTrue
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
        private LineBreakCondition _convertWhenFalse;
		/// <summary>
        /// ソース値がFalseの際にどのLineBreakCondition列挙体メンバーに変換するかを指定、または取得します。
        /// </summary>
        public LineBreakCondition ConvertWhenFalse
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
            if (!(value is LineBreakCondition)) throw new ArgumentException();

            var enumValue = (LineBreakCondition)value;

			switch(enumValue.ToString())
			{
				case "BreakDesired":
					if (_isConvertBackWhenBreakDesiredSet)
					{
						return ConvertBackWhenBreakDesired;
					}
					break;
				case "BreakPossible":
					if (_isConvertBackWhenBreakPossibleSet)
					{
						return ConvertBackWhenBreakPossible;
					}
					break;
				case "BreakRestrained":
					if (_isConvertBackWhenBreakRestrainedSet)
					{
						return ConvertBackWhenBreakRestrained;
					}
					break;
				case "BreakAlways":
					if (_isConvertBackWhenBreakAlwaysSet)
					{
						return ConvertBackWhenBreakAlways;
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
        /// LineBreakConditionの値をbool値に変換する際のデフォルト値を指定、または取得します。
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

        private bool _isConvertBackWhenBreakDesiredSet;
        private bool _convertBackWhenBreakDesired;
		/// <summary>
        /// LineBreakConditionの値がBreakDesiredの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenBreakDesired
        {
            get
            {
                return _convertBackWhenBreakDesired;
            }
            set
            {
                _convertBackWhenBreakDesired = value;
                _isConvertBackWhenBreakDesiredSet = true;
            }
        }
        private bool _isConvertBackWhenBreakPossibleSet;
        private bool _convertBackWhenBreakPossible;
		/// <summary>
        /// LineBreakConditionの値がBreakPossibleの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenBreakPossible
        {
            get
            {
                return _convertBackWhenBreakPossible;
            }
            set
            {
                _convertBackWhenBreakPossible = value;
                _isConvertBackWhenBreakPossibleSet = true;
            }
        }
        private bool _isConvertBackWhenBreakRestrainedSet;
        private bool _convertBackWhenBreakRestrained;
		/// <summary>
        /// LineBreakConditionの値がBreakRestrainedの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenBreakRestrained
        {
            get
            {
                return _convertBackWhenBreakRestrained;
            }
            set
            {
                _convertBackWhenBreakRestrained = value;
                _isConvertBackWhenBreakRestrainedSet = true;
            }
        }
        private bool _isConvertBackWhenBreakAlwaysSet;
        private bool _convertBackWhenBreakAlways;
		/// <summary>
        /// LineBreakConditionの値がBreakAlwaysの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenBreakAlways
        {
            get
            {
                return _convertBackWhenBreakAlways;
            }
            set
            {
                _convertBackWhenBreakAlways = value;
                _isConvertBackWhenBreakAlwaysSet = true;
            }
        }
    }
}