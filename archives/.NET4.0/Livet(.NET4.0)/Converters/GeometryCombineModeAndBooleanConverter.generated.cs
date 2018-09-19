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
    /// GeometryCombineMode列挙体とbool値の相互変換を行うIValueConverterです。
    /// </summary>
    public class GeometryCombineModeAndBooleanConverter : IValueConverter
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
        private GeometryCombineMode _convertWhenTrue;
		/// <summary>
        /// ソース値がTrueの際にどのGeometryCombineMode列挙体メンバーに変換するかを指定、または取得します。
        /// </summary>
        public GeometryCombineMode ConvertWhenTrue
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
        private GeometryCombineMode _convertWhenFalse;
		/// <summary>
        /// ソース値がFalseの際にどのGeometryCombineMode列挙体メンバーに変換するかを指定、または取得します。
        /// </summary>
        public GeometryCombineMode ConvertWhenFalse
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
            if (!(value is GeometryCombineMode)) throw new ArgumentException();

            var enumValue = (GeometryCombineMode)value;

			switch(enumValue.ToString())
			{
				case "Union":
					if (_isConvertBackWhenUnionSet)
					{
						return ConvertBackWhenUnion;
					}
					break;
				case "Intersect":
					if (_isConvertBackWhenIntersectSet)
					{
						return ConvertBackWhenIntersect;
					}
					break;
				case "Xor":
					if (_isConvertBackWhenXorSet)
					{
						return ConvertBackWhenXor;
					}
					break;
				case "Exclude":
					if (_isConvertBackWhenExcludeSet)
					{
						return ConvertBackWhenExclude;
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
        /// GeometryCombineModeの値をbool値に変換する際のデフォルト値を指定、または取得します。
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

        private bool _isConvertBackWhenUnionSet;
        private bool _convertBackWhenUnion;
		/// <summary>
        /// GeometryCombineModeの値がUnionの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenUnion
        {
            get
            {
                return _convertBackWhenUnion;
            }
            set
            {
                _convertBackWhenUnion = value;
                _isConvertBackWhenUnionSet = true;
            }
        }
        private bool _isConvertBackWhenIntersectSet;
        private bool _convertBackWhenIntersect;
		/// <summary>
        /// GeometryCombineModeの値がIntersectの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenIntersect
        {
            get
            {
                return _convertBackWhenIntersect;
            }
            set
            {
                _convertBackWhenIntersect = value;
                _isConvertBackWhenIntersectSet = true;
            }
        }
        private bool _isConvertBackWhenXorSet;
        private bool _convertBackWhenXor;
		/// <summary>
        /// GeometryCombineModeの値がXorの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenXor
        {
            get
            {
                return _convertBackWhenXor;
            }
            set
            {
                _convertBackWhenXor = value;
                _isConvertBackWhenXorSet = true;
            }
        }
        private bool _isConvertBackWhenExcludeSet;
        private bool _convertBackWhenExclude;
		/// <summary>
        /// GeometryCombineModeの値がExcludeの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenExclude
        {
            get
            {
                return _convertBackWhenExclude;
            }
            set
            {
                _convertBackWhenExclude = value;
                _isConvertBackWhenExcludeSet = true;
            }
        }
    }
}