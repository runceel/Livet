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
    /// Rotation列挙体とbool値の相互変換を行うIValueConverterです。
    /// </summary>
    public class RotationAndBooleanConverter : IValueConverter
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
        private Rotation _convertWhenTrue;
		/// <summary>
        /// ソース値がTrueの際にどのRotation列挙体メンバーに変換するかを指定、または取得します。
        /// </summary>
        public Rotation ConvertWhenTrue
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
        private Rotation _convertWhenFalse;
		/// <summary>
        /// ソース値がFalseの際にどのRotation列挙体メンバーに変換するかを指定、または取得します。
        /// </summary>
        public Rotation ConvertWhenFalse
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
            if (!(value is Rotation)) throw new ArgumentException();

            var enumValue = (Rotation)value;

			switch(enumValue.ToString())
			{
				case "Rotate0":
					if (_isConvertBackWhenRotate0Set)
					{
						return ConvertBackWhenRotate0;
					}
					break;
				case "Rotate90":
					if (_isConvertBackWhenRotate90Set)
					{
						return ConvertBackWhenRotate90;
					}
					break;
				case "Rotate180":
					if (_isConvertBackWhenRotate180Set)
					{
						return ConvertBackWhenRotate180;
					}
					break;
				case "Rotate270":
					if (_isConvertBackWhenRotate270Set)
					{
						return ConvertBackWhenRotate270;
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
        /// Rotationの値をbool値に変換する際のデフォルト値を指定、または取得します。
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

        private bool _isConvertBackWhenRotate0Set;
        private bool _convertBackWhenRotate0;
		/// <summary>
        /// Rotationの値がRotate0の際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenRotate0
        {
            get
            {
                return _convertBackWhenRotate0;
            }
            set
            {
                _convertBackWhenRotate0 = value;
                _isConvertBackWhenRotate0Set = true;
            }
        }
        private bool _isConvertBackWhenRotate90Set;
        private bool _convertBackWhenRotate90;
		/// <summary>
        /// Rotationの値がRotate90の際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenRotate90
        {
            get
            {
                return _convertBackWhenRotate90;
            }
            set
            {
                _convertBackWhenRotate90 = value;
                _isConvertBackWhenRotate90Set = true;
            }
        }
        private bool _isConvertBackWhenRotate180Set;
        private bool _convertBackWhenRotate180;
		/// <summary>
        /// Rotationの値がRotate180の際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenRotate180
        {
            get
            {
                return _convertBackWhenRotate180;
            }
            set
            {
                _convertBackWhenRotate180 = value;
                _isConvertBackWhenRotate180Set = true;
            }
        }
        private bool _isConvertBackWhenRotate270Set;
        private bool _convertBackWhenRotate270;
		/// <summary>
        /// Rotationの値がRotate270の際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenRotate270
        {
            get
            {
                return _convertBackWhenRotate270;
            }
            set
            {
                _convertBackWhenRotate270 = value;
                _isConvertBackWhenRotate270Set = true;
            }
        }
    }
}