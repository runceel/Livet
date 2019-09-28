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
    /// LocalizationCategory列挙体とbool値の相互変換を行うIValueConverterです。
    /// </summary>
    public class LocalizationCategoryAndBooleanConverter : IValueConverter
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
        private LocalizationCategory _convertWhenTrue;
		/// <summary>
        /// ソース値がTrueの際にどのLocalizationCategory列挙体メンバーに変換するかを指定、または取得します。
        /// </summary>
        public LocalizationCategory ConvertWhenTrue
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
        private LocalizationCategory _convertWhenFalse;
		/// <summary>
        /// ソース値がFalseの際にどのLocalizationCategory列挙体メンバーに変換するかを指定、または取得します。
        /// </summary>
        public LocalizationCategory ConvertWhenFalse
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
            if (!(value is LocalizationCategory)) throw new ArgumentException();

            var enumValue = (LocalizationCategory)value;

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
				case "Title":
					if (_isConvertBackWhenTitleSet)
					{
						return ConvertBackWhenTitle;
					}
					break;
				case "Label":
					if (_isConvertBackWhenLabelSet)
					{
						return ConvertBackWhenLabel;
					}
					break;
				case "Button":
					if (_isConvertBackWhenButtonSet)
					{
						return ConvertBackWhenButton;
					}
					break;
				case "CheckBox":
					if (_isConvertBackWhenCheckBoxSet)
					{
						return ConvertBackWhenCheckBox;
					}
					break;
				case "ComboBox":
					if (_isConvertBackWhenComboBoxSet)
					{
						return ConvertBackWhenComboBox;
					}
					break;
				case "ListBox":
					if (_isConvertBackWhenListBoxSet)
					{
						return ConvertBackWhenListBox;
					}
					break;
				case "Menu":
					if (_isConvertBackWhenMenuSet)
					{
						return ConvertBackWhenMenu;
					}
					break;
				case "RadioButton":
					if (_isConvertBackWhenRadioButtonSet)
					{
						return ConvertBackWhenRadioButton;
					}
					break;
				case "ToolTip":
					if (_isConvertBackWhenToolTipSet)
					{
						return ConvertBackWhenToolTip;
					}
					break;
				case "Hyperlink":
					if (_isConvertBackWhenHyperlinkSet)
					{
						return ConvertBackWhenHyperlink;
					}
					break;
				case "TextFlow":
					if (_isConvertBackWhenTextFlowSet)
					{
						return ConvertBackWhenTextFlow;
					}
					break;
				case "XmlData":
					if (_isConvertBackWhenXmlDataSet)
					{
						return ConvertBackWhenXmlData;
					}
					break;
				case "Font":
					if (_isConvertBackWhenFontSet)
					{
						return ConvertBackWhenFont;
					}
					break;
				case "Inherit":
					if (_isConvertBackWhenInheritSet)
					{
						return ConvertBackWhenInherit;
					}
					break;
				case "Ignore":
					if (_isConvertBackWhenIgnoreSet)
					{
						return ConvertBackWhenIgnore;
					}
					break;
				case "NeverLocalize":
					if (_isConvertBackWhenNeverLocalizeSet)
					{
						return ConvertBackWhenNeverLocalize;
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
        /// LocalizationCategoryの値をbool値に変換する際のデフォルト値を指定、または取得します。
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
        /// LocalizationCategoryの値がNoneの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
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
        /// LocalizationCategoryの値がTextの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
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
        private bool _isConvertBackWhenTitleSet;
        private bool _convertBackWhenTitle;
		/// <summary>
        /// LocalizationCategoryの値がTitleの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenTitle
        {
            get
            {
                return _convertBackWhenTitle;
            }
            set
            {
                _convertBackWhenTitle = value;
                _isConvertBackWhenTitleSet = true;
            }
        }
        private bool _isConvertBackWhenLabelSet;
        private bool _convertBackWhenLabel;
		/// <summary>
        /// LocalizationCategoryの値がLabelの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenLabel
        {
            get
            {
                return _convertBackWhenLabel;
            }
            set
            {
                _convertBackWhenLabel = value;
                _isConvertBackWhenLabelSet = true;
            }
        }
        private bool _isConvertBackWhenButtonSet;
        private bool _convertBackWhenButton;
		/// <summary>
        /// LocalizationCategoryの値がButtonの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenButton
        {
            get
            {
                return _convertBackWhenButton;
            }
            set
            {
                _convertBackWhenButton = value;
                _isConvertBackWhenButtonSet = true;
            }
        }
        private bool _isConvertBackWhenCheckBoxSet;
        private bool _convertBackWhenCheckBox;
		/// <summary>
        /// LocalizationCategoryの値がCheckBoxの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenCheckBox
        {
            get
            {
                return _convertBackWhenCheckBox;
            }
            set
            {
                _convertBackWhenCheckBox = value;
                _isConvertBackWhenCheckBoxSet = true;
            }
        }
        private bool _isConvertBackWhenComboBoxSet;
        private bool _convertBackWhenComboBox;
		/// <summary>
        /// LocalizationCategoryの値がComboBoxの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenComboBox
        {
            get
            {
                return _convertBackWhenComboBox;
            }
            set
            {
                _convertBackWhenComboBox = value;
                _isConvertBackWhenComboBoxSet = true;
            }
        }
        private bool _isConvertBackWhenListBoxSet;
        private bool _convertBackWhenListBox;
		/// <summary>
        /// LocalizationCategoryの値がListBoxの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenListBox
        {
            get
            {
                return _convertBackWhenListBox;
            }
            set
            {
                _convertBackWhenListBox = value;
                _isConvertBackWhenListBoxSet = true;
            }
        }
        private bool _isConvertBackWhenMenuSet;
        private bool _convertBackWhenMenu;
		/// <summary>
        /// LocalizationCategoryの値がMenuの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenMenu
        {
            get
            {
                return _convertBackWhenMenu;
            }
            set
            {
                _convertBackWhenMenu = value;
                _isConvertBackWhenMenuSet = true;
            }
        }
        private bool _isConvertBackWhenRadioButtonSet;
        private bool _convertBackWhenRadioButton;
		/// <summary>
        /// LocalizationCategoryの値がRadioButtonの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenRadioButton
        {
            get
            {
                return _convertBackWhenRadioButton;
            }
            set
            {
                _convertBackWhenRadioButton = value;
                _isConvertBackWhenRadioButtonSet = true;
            }
        }
        private bool _isConvertBackWhenToolTipSet;
        private bool _convertBackWhenToolTip;
		/// <summary>
        /// LocalizationCategoryの値がToolTipの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenToolTip
        {
            get
            {
                return _convertBackWhenToolTip;
            }
            set
            {
                _convertBackWhenToolTip = value;
                _isConvertBackWhenToolTipSet = true;
            }
        }
        private bool _isConvertBackWhenHyperlinkSet;
        private bool _convertBackWhenHyperlink;
		/// <summary>
        /// LocalizationCategoryの値がHyperlinkの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenHyperlink
        {
            get
            {
                return _convertBackWhenHyperlink;
            }
            set
            {
                _convertBackWhenHyperlink = value;
                _isConvertBackWhenHyperlinkSet = true;
            }
        }
        private bool _isConvertBackWhenTextFlowSet;
        private bool _convertBackWhenTextFlow;
		/// <summary>
        /// LocalizationCategoryの値がTextFlowの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenTextFlow
        {
            get
            {
                return _convertBackWhenTextFlow;
            }
            set
            {
                _convertBackWhenTextFlow = value;
                _isConvertBackWhenTextFlowSet = true;
            }
        }
        private bool _isConvertBackWhenXmlDataSet;
        private bool _convertBackWhenXmlData;
		/// <summary>
        /// LocalizationCategoryの値がXmlDataの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenXmlData
        {
            get
            {
                return _convertBackWhenXmlData;
            }
            set
            {
                _convertBackWhenXmlData = value;
                _isConvertBackWhenXmlDataSet = true;
            }
        }
        private bool _isConvertBackWhenFontSet;
        private bool _convertBackWhenFont;
		/// <summary>
        /// LocalizationCategoryの値がFontの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenFont
        {
            get
            {
                return _convertBackWhenFont;
            }
            set
            {
                _convertBackWhenFont = value;
                _isConvertBackWhenFontSet = true;
            }
        }
        private bool _isConvertBackWhenInheritSet;
        private bool _convertBackWhenInherit;
		/// <summary>
        /// LocalizationCategoryの値がInheritの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenInherit
        {
            get
            {
                return _convertBackWhenInherit;
            }
            set
            {
                _convertBackWhenInherit = value;
                _isConvertBackWhenInheritSet = true;
            }
        }
        private bool _isConvertBackWhenIgnoreSet;
        private bool _convertBackWhenIgnore;
		/// <summary>
        /// LocalizationCategoryの値がIgnoreの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenIgnore
        {
            get
            {
                return _convertBackWhenIgnore;
            }
            set
            {
                _convertBackWhenIgnore = value;
                _isConvertBackWhenIgnoreSet = true;
            }
        }
        private bool _isConvertBackWhenNeverLocalizeSet;
        private bool _convertBackWhenNeverLocalize;
		/// <summary>
        /// LocalizationCategoryの値がNeverLocalizeの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenNeverLocalize
        {
            get
            {
                return _convertBackWhenNeverLocalize;
            }
            set
            {
                _convertBackWhenNeverLocalize = value;
                _isConvertBackWhenNeverLocalizeSet = true;
            }
        }
    }
}