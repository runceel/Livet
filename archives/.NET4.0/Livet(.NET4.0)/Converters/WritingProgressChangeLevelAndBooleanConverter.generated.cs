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
    /// WritingProgressChangeLevel列挙体とbool値の相互変換を行うIValueConverterです。
    /// </summary>
    public class WritingProgressChangeLevelAndBooleanConverter : IValueConverter
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
        private WritingProgressChangeLevel _convertWhenTrue;
		/// <summary>
        /// ソース値がTrueの際にどのWritingProgressChangeLevel列挙体メンバーに変換するかを指定、または取得します。
        /// </summary>
        public WritingProgressChangeLevel ConvertWhenTrue
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
        private WritingProgressChangeLevel _convertWhenFalse;
		/// <summary>
        /// ソース値がFalseの際にどのWritingProgressChangeLevel列挙体メンバーに変換するかを指定、または取得します。
        /// </summary>
        public WritingProgressChangeLevel ConvertWhenFalse
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
            if (!(value is WritingProgressChangeLevel)) throw new ArgumentException();

            var enumValue = (WritingProgressChangeLevel)value;

			switch(enumValue.ToString())
			{
				case "None":
					if (_isConvertBackWhenNoneSet)
					{
						return ConvertBackWhenNone;
					}
					break;
				case "FixedDocumentSequenceWritingProgress":
					if (_isConvertBackWhenFixedDocumentSequenceWritingProgressSet)
					{
						return ConvertBackWhenFixedDocumentSequenceWritingProgress;
					}
					break;
				case "FixedDocumentWritingProgress":
					if (_isConvertBackWhenFixedDocumentWritingProgressSet)
					{
						return ConvertBackWhenFixedDocumentWritingProgress;
					}
					break;
				case "FixedPageWritingProgress":
					if (_isConvertBackWhenFixedPageWritingProgressSet)
					{
						return ConvertBackWhenFixedPageWritingProgress;
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
        /// WritingProgressChangeLevelの値をbool値に変換する際のデフォルト値を指定、または取得します。
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
        /// WritingProgressChangeLevelの値がNoneの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
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
        private bool _isConvertBackWhenFixedDocumentSequenceWritingProgressSet;
        private bool _convertBackWhenFixedDocumentSequenceWritingProgress;
		/// <summary>
        /// WritingProgressChangeLevelの値がFixedDocumentSequenceWritingProgressの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenFixedDocumentSequenceWritingProgress
        {
            get
            {
                return _convertBackWhenFixedDocumentSequenceWritingProgress;
            }
            set
            {
                _convertBackWhenFixedDocumentSequenceWritingProgress = value;
                _isConvertBackWhenFixedDocumentSequenceWritingProgressSet = true;
            }
        }
        private bool _isConvertBackWhenFixedDocumentWritingProgressSet;
        private bool _convertBackWhenFixedDocumentWritingProgress;
		/// <summary>
        /// WritingProgressChangeLevelの値がFixedDocumentWritingProgressの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenFixedDocumentWritingProgress
        {
            get
            {
                return _convertBackWhenFixedDocumentWritingProgress;
            }
            set
            {
                _convertBackWhenFixedDocumentWritingProgress = value;
                _isConvertBackWhenFixedDocumentWritingProgressSet = true;
            }
        }
        private bool _isConvertBackWhenFixedPageWritingProgressSet;
        private bool _convertBackWhenFixedPageWritingProgress;
		/// <summary>
        /// WritingProgressChangeLevelの値がFixedPageWritingProgressの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenFixedPageWritingProgress
        {
            get
            {
                return _convertBackWhenFixedPageWritingProgress;
            }
            set
            {
                _convertBackWhenFixedPageWritingProgress = value;
                _isConvertBackWhenFixedPageWritingProgressSet = true;
            }
        }
    }
}