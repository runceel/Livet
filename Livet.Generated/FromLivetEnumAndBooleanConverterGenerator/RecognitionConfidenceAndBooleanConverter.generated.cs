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
    /// RecognitionConfidence列挙体とbool値の相互変換を行うIValueConverterです。
    /// </summary>
    public class RecognitionConfidenceAndBooleanConverter : IValueConverter
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
        private RecognitionConfidence _convertWhenTrue;
		/// <summary>
        /// ソース値がTrueの際にどのRecognitionConfidence列挙体メンバーに変換するかを指定、または取得します。
        /// </summary>
        public RecognitionConfidence ConvertWhenTrue
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
        private RecognitionConfidence _convertWhenFalse;
		/// <summary>
        /// ソース値がFalseの際にどのRecognitionConfidence列挙体メンバーに変換するかを指定、または取得します。
        /// </summary>
        public RecognitionConfidence ConvertWhenFalse
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
            if (!(value is RecognitionConfidence)) throw new ArgumentException();

            var enumValue = (RecognitionConfidence)value;

			switch(enumValue.ToString())
			{
				case "Strong":
					if (_isConvertBackWhenStrongSet)
					{
						return ConvertBackWhenStrong;
					}
					break;
				case "Intermediate":
					if (_isConvertBackWhenIntermediateSet)
					{
						return ConvertBackWhenIntermediate;
					}
					break;
				case "Poor":
					if (_isConvertBackWhenPoorSet)
					{
						return ConvertBackWhenPoor;
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
        /// RecognitionConfidenceの値をbool値に変換する際のデフォルト値を指定、または取得します。
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

        private bool _isConvertBackWhenStrongSet;
        private bool _convertBackWhenStrong;
		/// <summary>
        /// RecognitionConfidenceの値がStrongの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenStrong
        {
            get
            {
                return _convertBackWhenStrong;
            }
            set
            {
                _convertBackWhenStrong = value;
                _isConvertBackWhenStrongSet = true;
            }
        }
        private bool _isConvertBackWhenIntermediateSet;
        private bool _convertBackWhenIntermediate;
		/// <summary>
        /// RecognitionConfidenceの値がIntermediateの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenIntermediate
        {
            get
            {
                return _convertBackWhenIntermediate;
            }
            set
            {
                _convertBackWhenIntermediate = value;
                _isConvertBackWhenIntermediateSet = true;
            }
        }
        private bool _isConvertBackWhenPoorSet;
        private bool _convertBackWhenPoor;
		/// <summary>
        /// RecognitionConfidenceの値がPoorの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenPoor
        {
            get
            {
                return _convertBackWhenPoor;
            }
            set
            {
                _convertBackWhenPoor = value;
                _isConvertBackWhenPoorSet = true;
            }
        }
    }
}