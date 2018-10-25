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
    /// FlowDocumentReaderViewingMode列挙体とbool値の相互変換を行うIValueConverterです。
    /// </summary>
    public class FlowDocumentReaderViewingModeAndBooleanConverter : IValueConverter
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
        private FlowDocumentReaderViewingMode _convertWhenTrue;
		/// <summary>
        /// ソース値がTrueの際にどのFlowDocumentReaderViewingMode列挙体メンバーに変換するかを指定、または取得します。
        /// </summary>
        public FlowDocumentReaderViewingMode ConvertWhenTrue
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
        private FlowDocumentReaderViewingMode _convertWhenFalse;
		/// <summary>
        /// ソース値がFalseの際にどのFlowDocumentReaderViewingMode列挙体メンバーに変換するかを指定、または取得します。
        /// </summary>
        public FlowDocumentReaderViewingMode ConvertWhenFalse
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
            if (!(value is FlowDocumentReaderViewingMode)) throw new ArgumentException();

            var enumValue = (FlowDocumentReaderViewingMode)value;

			switch(enumValue.ToString())
			{
				case "Page":
					if (_isConvertBackWhenPageSet)
					{
						return ConvertBackWhenPage;
					}
					break;
				case "TwoPage":
					if (_isConvertBackWhenTwoPageSet)
					{
						return ConvertBackWhenTwoPage;
					}
					break;
				case "Scroll":
					if (_isConvertBackWhenScrollSet)
					{
						return ConvertBackWhenScroll;
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
        /// FlowDocumentReaderViewingModeの値をbool値に変換する際のデフォルト値を指定、または取得します。
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

        private bool _isConvertBackWhenPageSet;
        private bool _convertBackWhenPage;
		/// <summary>
        /// FlowDocumentReaderViewingModeの値がPageの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenPage
        {
            get
            {
                return _convertBackWhenPage;
            }
            set
            {
                _convertBackWhenPage = value;
                _isConvertBackWhenPageSet = true;
            }
        }
        private bool _isConvertBackWhenTwoPageSet;
        private bool _convertBackWhenTwoPage;
		/// <summary>
        /// FlowDocumentReaderViewingModeの値がTwoPageの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenTwoPage
        {
            get
            {
                return _convertBackWhenTwoPage;
            }
            set
            {
                _convertBackWhenTwoPage = value;
                _isConvertBackWhenTwoPageSet = true;
            }
        }
        private bool _isConvertBackWhenScrollSet;
        private bool _convertBackWhenScroll;
		/// <summary>
        /// FlowDocumentReaderViewingModeの値がScrollの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenScroll
        {
            get
            {
                return _convertBackWhenScroll;
            }
            set
            {
                _convertBackWhenScroll = value;
                _isConvertBackWhenScrollSet = true;
            }
        }
    }
}