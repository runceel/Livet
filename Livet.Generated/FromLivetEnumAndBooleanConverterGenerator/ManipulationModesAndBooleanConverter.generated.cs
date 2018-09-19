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
    /// ManipulationModes列挙体とbool値の相互変換を行うIValueConverterです。
    /// </summary>
    public class ManipulationModesAndBooleanConverter : IValueConverter
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
        private ManipulationModes _convertWhenTrue;
		/// <summary>
        /// ソース値がTrueの際にどのManipulationModes列挙体メンバーに変換するかを指定、または取得します。
        /// </summary>
        public ManipulationModes ConvertWhenTrue
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
        private ManipulationModes _convertWhenFalse;
		/// <summary>
        /// ソース値がFalseの際にどのManipulationModes列挙体メンバーに変換するかを指定、または取得します。
        /// </summary>
        public ManipulationModes ConvertWhenFalse
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
            if (!(value is ManipulationModes)) throw new ArgumentException();

            var enumValue = (ManipulationModes)value;

			switch(enumValue.ToString())
			{
				case "None":
					if (_isConvertBackWhenNoneSet)
					{
						return ConvertBackWhenNone;
					}
					break;
				case "TranslateX":
					if (_isConvertBackWhenTranslateXSet)
					{
						return ConvertBackWhenTranslateX;
					}
					break;
				case "TranslateY":
					if (_isConvertBackWhenTranslateYSet)
					{
						return ConvertBackWhenTranslateY;
					}
					break;
				case "Translate":
					if (_isConvertBackWhenTranslateSet)
					{
						return ConvertBackWhenTranslate;
					}
					break;
				case "Rotate":
					if (_isConvertBackWhenRotateSet)
					{
						return ConvertBackWhenRotate;
					}
					break;
				case "Scale":
					if (_isConvertBackWhenScaleSet)
					{
						return ConvertBackWhenScale;
					}
					break;
				case "All":
					if (_isConvertBackWhenAllSet)
					{
						return ConvertBackWhenAll;
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
        /// ManipulationModesの値をbool値に変換する際のデフォルト値を指定、または取得します。
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
        /// ManipulationModesの値がNoneの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
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
        private bool _isConvertBackWhenTranslateXSet;
        private bool _convertBackWhenTranslateX;
		/// <summary>
        /// ManipulationModesの値がTranslateXの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenTranslateX
        {
            get
            {
                return _convertBackWhenTranslateX;
            }
            set
            {
                _convertBackWhenTranslateX = value;
                _isConvertBackWhenTranslateXSet = true;
            }
        }
        private bool _isConvertBackWhenTranslateYSet;
        private bool _convertBackWhenTranslateY;
		/// <summary>
        /// ManipulationModesの値がTranslateYの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenTranslateY
        {
            get
            {
                return _convertBackWhenTranslateY;
            }
            set
            {
                _convertBackWhenTranslateY = value;
                _isConvertBackWhenTranslateYSet = true;
            }
        }
        private bool _isConvertBackWhenTranslateSet;
        private bool _convertBackWhenTranslate;
		/// <summary>
        /// ManipulationModesの値がTranslateの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenTranslate
        {
            get
            {
                return _convertBackWhenTranslate;
            }
            set
            {
                _convertBackWhenTranslate = value;
                _isConvertBackWhenTranslateSet = true;
            }
        }
        private bool _isConvertBackWhenRotateSet;
        private bool _convertBackWhenRotate;
		/// <summary>
        /// ManipulationModesの値がRotateの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenRotate
        {
            get
            {
                return _convertBackWhenRotate;
            }
            set
            {
                _convertBackWhenRotate = value;
                _isConvertBackWhenRotateSet = true;
            }
        }
        private bool _isConvertBackWhenScaleSet;
        private bool _convertBackWhenScale;
		/// <summary>
        /// ManipulationModesの値がScaleの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenScale
        {
            get
            {
                return _convertBackWhenScale;
            }
            set
            {
                _convertBackWhenScale = value;
                _isConvertBackWhenScaleSet = true;
            }
        }
        private bool _isConvertBackWhenAllSet;
        private bool _convertBackWhenAll;
		/// <summary>
        /// ManipulationModesの値がAllの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenAll
        {
            get
            {
                return _convertBackWhenAll;
            }
            set
            {
                _convertBackWhenAll = value;
                _isConvertBackWhenAllSet = true;
            }
        }
    }
}