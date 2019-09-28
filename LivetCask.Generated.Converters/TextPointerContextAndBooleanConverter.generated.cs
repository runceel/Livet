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
    /// TextPointerContext列挙体とbool値の相互変換を行うIValueConverterです。
    /// </summary>
    public class TextPointerContextAndBooleanConverter : IValueConverter
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
        private TextPointerContext _convertWhenTrue;
		/// <summary>
        /// ソース値がTrueの際にどのTextPointerContext列挙体メンバーに変換するかを指定、または取得します。
        /// </summary>
        public TextPointerContext ConvertWhenTrue
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
        private TextPointerContext _convertWhenFalse;
		/// <summary>
        /// ソース値がFalseの際にどのTextPointerContext列挙体メンバーに変換するかを指定、または取得します。
        /// </summary>
        public TextPointerContext ConvertWhenFalse
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
            if (!(value is TextPointerContext)) throw new ArgumentException();

            var enumValue = (TextPointerContext)value;

			switch(enumValue.ToString())
			{
				case "None":
					if (_isConvertBackWhenNoneSet)
					{
						return ConvertBackWhenNone;
					}
					break;
				case "Text":
					if (_isConvertBackWhenTextSet)
					{
						return ConvertBackWhenText;
					}
					break;
				case "EmbeddedElement":
					if (_isConvertBackWhenEmbeddedElementSet)
					{
						return ConvertBackWhenEmbeddedElement;
					}
					break;
				case "ElementStart":
					if (_isConvertBackWhenElementStartSet)
					{
						return ConvertBackWhenElementStart;
					}
					break;
				case "ElementEnd":
					if (_isConvertBackWhenElementEndSet)
					{
						return ConvertBackWhenElementEnd;
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
        /// TextPointerContextの値をbool値に変換する際のデフォルト値を指定、または取得します。
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
        /// TextPointerContextの値がNoneの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
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
        private bool _isConvertBackWhenTextSet;
        private bool _convertBackWhenText;
		/// <summary>
        /// TextPointerContextの値がTextの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenText
        {
            get
            {
                return _convertBackWhenText;
            }
            set
            {
                _convertBackWhenText = value;
                _isConvertBackWhenTextSet = true;
            }
        }
        private bool _isConvertBackWhenEmbeddedElementSet;
        private bool _convertBackWhenEmbeddedElement;
		/// <summary>
        /// TextPointerContextの値がEmbeddedElementの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenEmbeddedElement
        {
            get
            {
                return _convertBackWhenEmbeddedElement;
            }
            set
            {
                _convertBackWhenEmbeddedElement = value;
                _isConvertBackWhenEmbeddedElementSet = true;
            }
        }
        private bool _isConvertBackWhenElementStartSet;
        private bool _convertBackWhenElementStart;
		/// <summary>
        /// TextPointerContextの値がElementStartの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenElementStart
        {
            get
            {
                return _convertBackWhenElementStart;
            }
            set
            {
                _convertBackWhenElementStart = value;
                _isConvertBackWhenElementStartSet = true;
            }
        }
        private bool _isConvertBackWhenElementEndSet;
        private bool _convertBackWhenElementEnd;
		/// <summary>
        /// TextPointerContextの値がElementEndの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenElementEnd
        {
            get
            {
                return _convertBackWhenElementEnd;
            }
            set
            {
                _convertBackWhenElementEnd = value;
                _isConvertBackWhenElementEndSet = true;
            }
        }
    }
}