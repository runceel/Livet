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
    /// AutomationControlType列挙体とbool値の相互変換を行うIValueConverterです。
    /// </summary>
    public class AutomationControlTypeAndBooleanConverter : IValueConverter
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
        private AutomationControlType _convertWhenTrue;
		/// <summary>
        /// ソース値がTrueの際にどのAutomationControlType列挙体メンバーに変換するかを指定、または取得します。
        /// </summary>
        public AutomationControlType ConvertWhenTrue
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
        private AutomationControlType _convertWhenFalse;
		/// <summary>
        /// ソース値がFalseの際にどのAutomationControlType列挙体メンバーに変換するかを指定、または取得します。
        /// </summary>
        public AutomationControlType ConvertWhenFalse
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
            if (!(value is AutomationControlType)) throw new ArgumentException();

            var enumValue = (AutomationControlType)value;

			switch(enumValue.ToString())
			{
				case "Button":
					if (_isConvertBackWhenButtonSet)
					{
						return ConvertBackWhenButton;
					}
					break;
				case "Calendar":
					if (_isConvertBackWhenCalendarSet)
					{
						return ConvertBackWhenCalendar;
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
				case "Edit":
					if (_isConvertBackWhenEditSet)
					{
						return ConvertBackWhenEdit;
					}
					break;
				case "Hyperlink":
					if (_isConvertBackWhenHyperlinkSet)
					{
						return ConvertBackWhenHyperlink;
					}
					break;
				case "Image":
					if (_isConvertBackWhenImageSet)
					{
						return ConvertBackWhenImage;
					}
					break;
				case "ListItem":
					if (_isConvertBackWhenListItemSet)
					{
						return ConvertBackWhenListItem;
					}
					break;
				case "List":
					if (_isConvertBackWhenListSet)
					{
						return ConvertBackWhenList;
					}
					break;
				case "Menu":
					if (_isConvertBackWhenMenuSet)
					{
						return ConvertBackWhenMenu;
					}
					break;
				case "MenuBar":
					if (_isConvertBackWhenMenuBarSet)
					{
						return ConvertBackWhenMenuBar;
					}
					break;
				case "MenuItem":
					if (_isConvertBackWhenMenuItemSet)
					{
						return ConvertBackWhenMenuItem;
					}
					break;
				case "ProgressBar":
					if (_isConvertBackWhenProgressBarSet)
					{
						return ConvertBackWhenProgressBar;
					}
					break;
				case "RadioButton":
					if (_isConvertBackWhenRadioButtonSet)
					{
						return ConvertBackWhenRadioButton;
					}
					break;
				case "ScrollBar":
					if (_isConvertBackWhenScrollBarSet)
					{
						return ConvertBackWhenScrollBar;
					}
					break;
				case "Slider":
					if (_isConvertBackWhenSliderSet)
					{
						return ConvertBackWhenSlider;
					}
					break;
				case "Spinner":
					if (_isConvertBackWhenSpinnerSet)
					{
						return ConvertBackWhenSpinner;
					}
					break;
				case "StatusBar":
					if (_isConvertBackWhenStatusBarSet)
					{
						return ConvertBackWhenStatusBar;
					}
					break;
				case "Tab":
					if (_isConvertBackWhenTabSet)
					{
						return ConvertBackWhenTab;
					}
					break;
				case "TabItem":
					if (_isConvertBackWhenTabItemSet)
					{
						return ConvertBackWhenTabItem;
					}
					break;
				case "Text":
					if (_isConvertBackWhenTextSet)
					{
						return ConvertBackWhenText;
					}
					break;
				case "ToolBar":
					if (_isConvertBackWhenToolBarSet)
					{
						return ConvertBackWhenToolBar;
					}
					break;
				case "ToolTip":
					if (_isConvertBackWhenToolTipSet)
					{
						return ConvertBackWhenToolTip;
					}
					break;
				case "Tree":
					if (_isConvertBackWhenTreeSet)
					{
						return ConvertBackWhenTree;
					}
					break;
				case "TreeItem":
					if (_isConvertBackWhenTreeItemSet)
					{
						return ConvertBackWhenTreeItem;
					}
					break;
				case "Custom":
					if (_isConvertBackWhenCustomSet)
					{
						return ConvertBackWhenCustom;
					}
					break;
				case "Group":
					if (_isConvertBackWhenGroupSet)
					{
						return ConvertBackWhenGroup;
					}
					break;
				case "Thumb":
					if (_isConvertBackWhenThumbSet)
					{
						return ConvertBackWhenThumb;
					}
					break;
				case "DataGrid":
					if (_isConvertBackWhenDataGridSet)
					{
						return ConvertBackWhenDataGrid;
					}
					break;
				case "DataItem":
					if (_isConvertBackWhenDataItemSet)
					{
						return ConvertBackWhenDataItem;
					}
					break;
				case "Document":
					if (_isConvertBackWhenDocumentSet)
					{
						return ConvertBackWhenDocument;
					}
					break;
				case "SplitButton":
					if (_isConvertBackWhenSplitButtonSet)
					{
						return ConvertBackWhenSplitButton;
					}
					break;
				case "Window":
					if (_isConvertBackWhenWindowSet)
					{
						return ConvertBackWhenWindow;
					}
					break;
				case "Pane":
					if (_isConvertBackWhenPaneSet)
					{
						return ConvertBackWhenPane;
					}
					break;
				case "Header":
					if (_isConvertBackWhenHeaderSet)
					{
						return ConvertBackWhenHeader;
					}
					break;
				case "HeaderItem":
					if (_isConvertBackWhenHeaderItemSet)
					{
						return ConvertBackWhenHeaderItem;
					}
					break;
				case "Table":
					if (_isConvertBackWhenTableSet)
					{
						return ConvertBackWhenTable;
					}
					break;
				case "TitleBar":
					if (_isConvertBackWhenTitleBarSet)
					{
						return ConvertBackWhenTitleBar;
					}
					break;
				case "Separator":
					if (_isConvertBackWhenSeparatorSet)
					{
						return ConvertBackWhenSeparator;
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
        /// AutomationControlTypeの値をbool値に変換する際のデフォルト値を指定、または取得します。
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

        private bool _isConvertBackWhenButtonSet;
        private bool _convertBackWhenButton;
		/// <summary>
        /// AutomationControlTypeの値がButtonの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
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
        private bool _isConvertBackWhenCalendarSet;
        private bool _convertBackWhenCalendar;
		/// <summary>
        /// AutomationControlTypeの値がCalendarの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenCalendar
        {
            get
            {
                return _convertBackWhenCalendar;
            }
            set
            {
                _convertBackWhenCalendar = value;
                _isConvertBackWhenCalendarSet = true;
            }
        }
        private bool _isConvertBackWhenCheckBoxSet;
        private bool _convertBackWhenCheckBox;
		/// <summary>
        /// AutomationControlTypeの値がCheckBoxの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
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
        /// AutomationControlTypeの値がComboBoxの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
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
        private bool _isConvertBackWhenEditSet;
        private bool _convertBackWhenEdit;
		/// <summary>
        /// AutomationControlTypeの値がEditの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenEdit
        {
            get
            {
                return _convertBackWhenEdit;
            }
            set
            {
                _convertBackWhenEdit = value;
                _isConvertBackWhenEditSet = true;
            }
        }
        private bool _isConvertBackWhenHyperlinkSet;
        private bool _convertBackWhenHyperlink;
		/// <summary>
        /// AutomationControlTypeの値がHyperlinkの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
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
        private bool _isConvertBackWhenImageSet;
        private bool _convertBackWhenImage;
		/// <summary>
        /// AutomationControlTypeの値がImageの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenImage
        {
            get
            {
                return _convertBackWhenImage;
            }
            set
            {
                _convertBackWhenImage = value;
                _isConvertBackWhenImageSet = true;
            }
        }
        private bool _isConvertBackWhenListItemSet;
        private bool _convertBackWhenListItem;
		/// <summary>
        /// AutomationControlTypeの値がListItemの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenListItem
        {
            get
            {
                return _convertBackWhenListItem;
            }
            set
            {
                _convertBackWhenListItem = value;
                _isConvertBackWhenListItemSet = true;
            }
        }
        private bool _isConvertBackWhenListSet;
        private bool _convertBackWhenList;
		/// <summary>
        /// AutomationControlTypeの値がListの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenList
        {
            get
            {
                return _convertBackWhenList;
            }
            set
            {
                _convertBackWhenList = value;
                _isConvertBackWhenListSet = true;
            }
        }
        private bool _isConvertBackWhenMenuSet;
        private bool _convertBackWhenMenu;
		/// <summary>
        /// AutomationControlTypeの値がMenuの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
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
        private bool _isConvertBackWhenMenuBarSet;
        private bool _convertBackWhenMenuBar;
		/// <summary>
        /// AutomationControlTypeの値がMenuBarの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenMenuBar
        {
            get
            {
                return _convertBackWhenMenuBar;
            }
            set
            {
                _convertBackWhenMenuBar = value;
                _isConvertBackWhenMenuBarSet = true;
            }
        }
        private bool _isConvertBackWhenMenuItemSet;
        private bool _convertBackWhenMenuItem;
		/// <summary>
        /// AutomationControlTypeの値がMenuItemの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenMenuItem
        {
            get
            {
                return _convertBackWhenMenuItem;
            }
            set
            {
                _convertBackWhenMenuItem = value;
                _isConvertBackWhenMenuItemSet = true;
            }
        }
        private bool _isConvertBackWhenProgressBarSet;
        private bool _convertBackWhenProgressBar;
		/// <summary>
        /// AutomationControlTypeの値がProgressBarの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenProgressBar
        {
            get
            {
                return _convertBackWhenProgressBar;
            }
            set
            {
                _convertBackWhenProgressBar = value;
                _isConvertBackWhenProgressBarSet = true;
            }
        }
        private bool _isConvertBackWhenRadioButtonSet;
        private bool _convertBackWhenRadioButton;
		/// <summary>
        /// AutomationControlTypeの値がRadioButtonの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
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
        private bool _isConvertBackWhenScrollBarSet;
        private bool _convertBackWhenScrollBar;
		/// <summary>
        /// AutomationControlTypeの値がScrollBarの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenScrollBar
        {
            get
            {
                return _convertBackWhenScrollBar;
            }
            set
            {
                _convertBackWhenScrollBar = value;
                _isConvertBackWhenScrollBarSet = true;
            }
        }
        private bool _isConvertBackWhenSliderSet;
        private bool _convertBackWhenSlider;
		/// <summary>
        /// AutomationControlTypeの値がSliderの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenSlider
        {
            get
            {
                return _convertBackWhenSlider;
            }
            set
            {
                _convertBackWhenSlider = value;
                _isConvertBackWhenSliderSet = true;
            }
        }
        private bool _isConvertBackWhenSpinnerSet;
        private bool _convertBackWhenSpinner;
		/// <summary>
        /// AutomationControlTypeの値がSpinnerの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenSpinner
        {
            get
            {
                return _convertBackWhenSpinner;
            }
            set
            {
                _convertBackWhenSpinner = value;
                _isConvertBackWhenSpinnerSet = true;
            }
        }
        private bool _isConvertBackWhenStatusBarSet;
        private bool _convertBackWhenStatusBar;
		/// <summary>
        /// AutomationControlTypeの値がStatusBarの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenStatusBar
        {
            get
            {
                return _convertBackWhenStatusBar;
            }
            set
            {
                _convertBackWhenStatusBar = value;
                _isConvertBackWhenStatusBarSet = true;
            }
        }
        private bool _isConvertBackWhenTabSet;
        private bool _convertBackWhenTab;
		/// <summary>
        /// AutomationControlTypeの値がTabの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenTab
        {
            get
            {
                return _convertBackWhenTab;
            }
            set
            {
                _convertBackWhenTab = value;
                _isConvertBackWhenTabSet = true;
            }
        }
        private bool _isConvertBackWhenTabItemSet;
        private bool _convertBackWhenTabItem;
		/// <summary>
        /// AutomationControlTypeの値がTabItemの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenTabItem
        {
            get
            {
                return _convertBackWhenTabItem;
            }
            set
            {
                _convertBackWhenTabItem = value;
                _isConvertBackWhenTabItemSet = true;
            }
        }
        private bool _isConvertBackWhenTextSet;
        private bool _convertBackWhenText;
		/// <summary>
        /// AutomationControlTypeの値がTextの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
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
        private bool _isConvertBackWhenToolBarSet;
        private bool _convertBackWhenToolBar;
		/// <summary>
        /// AutomationControlTypeの値がToolBarの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenToolBar
        {
            get
            {
                return _convertBackWhenToolBar;
            }
            set
            {
                _convertBackWhenToolBar = value;
                _isConvertBackWhenToolBarSet = true;
            }
        }
        private bool _isConvertBackWhenToolTipSet;
        private bool _convertBackWhenToolTip;
		/// <summary>
        /// AutomationControlTypeの値がToolTipの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
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
        private bool _isConvertBackWhenTreeSet;
        private bool _convertBackWhenTree;
		/// <summary>
        /// AutomationControlTypeの値がTreeの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenTree
        {
            get
            {
                return _convertBackWhenTree;
            }
            set
            {
                _convertBackWhenTree = value;
                _isConvertBackWhenTreeSet = true;
            }
        }
        private bool _isConvertBackWhenTreeItemSet;
        private bool _convertBackWhenTreeItem;
		/// <summary>
        /// AutomationControlTypeの値がTreeItemの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenTreeItem
        {
            get
            {
                return _convertBackWhenTreeItem;
            }
            set
            {
                _convertBackWhenTreeItem = value;
                _isConvertBackWhenTreeItemSet = true;
            }
        }
        private bool _isConvertBackWhenCustomSet;
        private bool _convertBackWhenCustom;
		/// <summary>
        /// AutomationControlTypeの値がCustomの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenCustom
        {
            get
            {
                return _convertBackWhenCustom;
            }
            set
            {
                _convertBackWhenCustom = value;
                _isConvertBackWhenCustomSet = true;
            }
        }
        private bool _isConvertBackWhenGroupSet;
        private bool _convertBackWhenGroup;
		/// <summary>
        /// AutomationControlTypeの値がGroupの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenGroup
        {
            get
            {
                return _convertBackWhenGroup;
            }
            set
            {
                _convertBackWhenGroup = value;
                _isConvertBackWhenGroupSet = true;
            }
        }
        private bool _isConvertBackWhenThumbSet;
        private bool _convertBackWhenThumb;
		/// <summary>
        /// AutomationControlTypeの値がThumbの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenThumb
        {
            get
            {
                return _convertBackWhenThumb;
            }
            set
            {
                _convertBackWhenThumb = value;
                _isConvertBackWhenThumbSet = true;
            }
        }
        private bool _isConvertBackWhenDataGridSet;
        private bool _convertBackWhenDataGrid;
		/// <summary>
        /// AutomationControlTypeの値がDataGridの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenDataGrid
        {
            get
            {
                return _convertBackWhenDataGrid;
            }
            set
            {
                _convertBackWhenDataGrid = value;
                _isConvertBackWhenDataGridSet = true;
            }
        }
        private bool _isConvertBackWhenDataItemSet;
        private bool _convertBackWhenDataItem;
		/// <summary>
        /// AutomationControlTypeの値がDataItemの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenDataItem
        {
            get
            {
                return _convertBackWhenDataItem;
            }
            set
            {
                _convertBackWhenDataItem = value;
                _isConvertBackWhenDataItemSet = true;
            }
        }
        private bool _isConvertBackWhenDocumentSet;
        private bool _convertBackWhenDocument;
		/// <summary>
        /// AutomationControlTypeの値がDocumentの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenDocument
        {
            get
            {
                return _convertBackWhenDocument;
            }
            set
            {
                _convertBackWhenDocument = value;
                _isConvertBackWhenDocumentSet = true;
            }
        }
        private bool _isConvertBackWhenSplitButtonSet;
        private bool _convertBackWhenSplitButton;
		/// <summary>
        /// AutomationControlTypeの値がSplitButtonの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenSplitButton
        {
            get
            {
                return _convertBackWhenSplitButton;
            }
            set
            {
                _convertBackWhenSplitButton = value;
                _isConvertBackWhenSplitButtonSet = true;
            }
        }
        private bool _isConvertBackWhenWindowSet;
        private bool _convertBackWhenWindow;
		/// <summary>
        /// AutomationControlTypeの値がWindowの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenWindow
        {
            get
            {
                return _convertBackWhenWindow;
            }
            set
            {
                _convertBackWhenWindow = value;
                _isConvertBackWhenWindowSet = true;
            }
        }
        private bool _isConvertBackWhenPaneSet;
        private bool _convertBackWhenPane;
		/// <summary>
        /// AutomationControlTypeの値がPaneの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenPane
        {
            get
            {
                return _convertBackWhenPane;
            }
            set
            {
                _convertBackWhenPane = value;
                _isConvertBackWhenPaneSet = true;
            }
        }
        private bool _isConvertBackWhenHeaderSet;
        private bool _convertBackWhenHeader;
		/// <summary>
        /// AutomationControlTypeの値がHeaderの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenHeader
        {
            get
            {
                return _convertBackWhenHeader;
            }
            set
            {
                _convertBackWhenHeader = value;
                _isConvertBackWhenHeaderSet = true;
            }
        }
        private bool _isConvertBackWhenHeaderItemSet;
        private bool _convertBackWhenHeaderItem;
		/// <summary>
        /// AutomationControlTypeの値がHeaderItemの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenHeaderItem
        {
            get
            {
                return _convertBackWhenHeaderItem;
            }
            set
            {
                _convertBackWhenHeaderItem = value;
                _isConvertBackWhenHeaderItemSet = true;
            }
        }
        private bool _isConvertBackWhenTableSet;
        private bool _convertBackWhenTable;
		/// <summary>
        /// AutomationControlTypeの値がTableの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenTable
        {
            get
            {
                return _convertBackWhenTable;
            }
            set
            {
                _convertBackWhenTable = value;
                _isConvertBackWhenTableSet = true;
            }
        }
        private bool _isConvertBackWhenTitleBarSet;
        private bool _convertBackWhenTitleBar;
		/// <summary>
        /// AutomationControlTypeの値がTitleBarの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenTitleBar
        {
            get
            {
                return _convertBackWhenTitleBar;
            }
            set
            {
                _convertBackWhenTitleBar = value;
                _isConvertBackWhenTitleBarSet = true;
            }
        }
        private bool _isConvertBackWhenSeparatorSet;
        private bool _convertBackWhenSeparator;
		/// <summary>
        /// AutomationControlTypeの値がSeparatorの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenSeparator
        {
            get
            {
                return _convertBackWhenSeparator;
            }
            set
            {
                _convertBackWhenSeparator = value;
                _isConvertBackWhenSeparatorSet = true;
            }
        }
    }
}