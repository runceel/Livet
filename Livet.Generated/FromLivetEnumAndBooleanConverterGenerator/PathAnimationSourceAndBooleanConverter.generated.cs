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
    /// PathAnimationSource列挙体とbool値の相互変換を行うIValueConverterです。
    /// </summary>
    public class PathAnimationSourceAndBooleanConverter : IValueConverter
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
        private PathAnimationSource _convertWhenTrue;
		/// <summary>
        /// ソース値がTrueの際にどのPathAnimationSource列挙体メンバーに変換するかを指定、または取得します。
        /// </summary>
        public PathAnimationSource ConvertWhenTrue
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
        private PathAnimationSource _convertWhenFalse;
		/// <summary>
        /// ソース値がFalseの際にどのPathAnimationSource列挙体メンバーに変換するかを指定、または取得します。
        /// </summary>
        public PathAnimationSource ConvertWhenFalse
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
            if (!(value is PathAnimationSource)) throw new ArgumentException();

            var enumValue = (PathAnimationSource)value;

			switch(enumValue.ToString())
			{
				case "X":
					if (_isConvertBackWhenXSet)
					{
						return ConvertBackWhenX;
					}
					break;
				case "Y":
					if (_isConvertBackWhenYSet)
					{
						return ConvertBackWhenY;
					}
					break;
				case "Angle":
					if (_isConvertBackWhenAngleSet)
					{
						return ConvertBackWhenAngle;
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
        /// PathAnimationSourceの値をbool値に変換する際のデフォルト値を指定、または取得します。
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

        private bool _isConvertBackWhenXSet;
        private bool _convertBackWhenX;
		/// <summary>
        /// PathAnimationSourceの値がXの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenX
        {
            get
            {
                return _convertBackWhenX;
            }
            set
            {
                _convertBackWhenX = value;
                _isConvertBackWhenXSet = true;
            }
        }
        private bool _isConvertBackWhenYSet;
        private bool _convertBackWhenY;
		/// <summary>
        /// PathAnimationSourceの値がYの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenY
        {
            get
            {
                return _convertBackWhenY;
            }
            set
            {
                _convertBackWhenY = value;
                _isConvertBackWhenYSet = true;
            }
        }
        private bool _isConvertBackWhenAngleSet;
        private bool _convertBackWhenAngle;
		/// <summary>
        /// PathAnimationSourceの値がAngleの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenAngle
        {
            get
            {
                return _convertBackWhenAngle;
            }
            set
            {
                _convertBackWhenAngle = value;
                _isConvertBackWhenAngleSet = true;
            }
        }
    }
}