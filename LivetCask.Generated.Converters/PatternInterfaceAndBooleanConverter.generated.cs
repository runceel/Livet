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
    /// PatternInterface列挙体とbool値の相互変換を行うIValueConverterです。
    /// </summary>
    public class PatternInterfaceAndBooleanConverter : IValueConverter
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
        private PatternInterface _convertWhenTrue;
		/// <summary>
        /// ソース値がTrueの際にどのPatternInterface列挙体メンバーに変換するかを指定、または取得します。
        /// </summary>
        public PatternInterface ConvertWhenTrue
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
        private PatternInterface _convertWhenFalse;
		/// <summary>
        /// ソース値がFalseの際にどのPatternInterface列挙体メンバーに変換するかを指定、または取得します。
        /// </summary>
        public PatternInterface ConvertWhenFalse
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
            if (!(value is PatternInterface)) throw new ArgumentException();

            var enumValue = (PatternInterface)value;

			switch(enumValue.ToString())
			{
				case "Invoke":
					if (_isConvertBackWhenInvokeSet)
					{
						return ConvertBackWhenInvoke;
					}
					break;
				case "Selection":
					if (_isConvertBackWhenSelectionSet)
					{
						return ConvertBackWhenSelection;
					}
					break;
				case "Value":
					if (_isConvertBackWhenValueSet)
					{
						return ConvertBackWhenValue;
					}
					break;
				case "RangeValue":
					if (_isConvertBackWhenRangeValueSet)
					{
						return ConvertBackWhenRangeValue;
					}
					break;
				case "Scroll":
					if (_isConvertBackWhenScrollSet)
					{
						return ConvertBackWhenScroll;
					}
					break;
				case "ScrollItem":
					if (_isConvertBackWhenScrollItemSet)
					{
						return ConvertBackWhenScrollItem;
					}
					break;
				case "ExpandCollapse":
					if (_isConvertBackWhenExpandCollapseSet)
					{
						return ConvertBackWhenExpandCollapse;
					}
					break;
				case "Grid":
					if (_isConvertBackWhenGridSet)
					{
						return ConvertBackWhenGrid;
					}
					break;
				case "GridItem":
					if (_isConvertBackWhenGridItemSet)
					{
						return ConvertBackWhenGridItem;
					}
					break;
				case "MultipleView":
					if (_isConvertBackWhenMultipleViewSet)
					{
						return ConvertBackWhenMultipleView;
					}
					break;
				case "Window":
					if (_isConvertBackWhenWindowSet)
					{
						return ConvertBackWhenWindow;
					}
					break;
				case "SelectionItem":
					if (_isConvertBackWhenSelectionItemSet)
					{
						return ConvertBackWhenSelectionItem;
					}
					break;
				case "Dock":
					if (_isConvertBackWhenDockSet)
					{
						return ConvertBackWhenDock;
					}
					break;
				case "Table":
					if (_isConvertBackWhenTableSet)
					{
						return ConvertBackWhenTable;
					}
					break;
				case "TableItem":
					if (_isConvertBackWhenTableItemSet)
					{
						return ConvertBackWhenTableItem;
					}
					break;
				case "Toggle":
					if (_isConvertBackWhenToggleSet)
					{
						return ConvertBackWhenToggle;
					}
					break;
				case "Transform":
					if (_isConvertBackWhenTransformSet)
					{
						return ConvertBackWhenTransform;
					}
					break;
				case "Text":
					if (_isConvertBackWhenTextSet)
					{
						return ConvertBackWhenText;
					}
					break;
				case "ItemContainer":
					if (_isConvertBackWhenItemContainerSet)
					{
						return ConvertBackWhenItemContainer;
					}
					break;
				case "VirtualizedItem":
					if (_isConvertBackWhenVirtualizedItemSet)
					{
						return ConvertBackWhenVirtualizedItem;
					}
					break;
				case "SynchronizedInput":
					if (_isConvertBackWhenSynchronizedInputSet)
					{
						return ConvertBackWhenSynchronizedInput;
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
        /// PatternInterfaceの値をbool値に変換する際のデフォルト値を指定、または取得します。
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

        private bool _isConvertBackWhenInvokeSet;
        private bool _convertBackWhenInvoke;
		/// <summary>
        /// PatternInterfaceの値がInvokeの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenInvoke
        {
            get
            {
                return _convertBackWhenInvoke;
            }
            set
            {
                _convertBackWhenInvoke = value;
                _isConvertBackWhenInvokeSet = true;
            }
        }
        private bool _isConvertBackWhenSelectionSet;
        private bool _convertBackWhenSelection;
		/// <summary>
        /// PatternInterfaceの値がSelectionの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenSelection
        {
            get
            {
                return _convertBackWhenSelection;
            }
            set
            {
                _convertBackWhenSelection = value;
                _isConvertBackWhenSelectionSet = true;
            }
        }
        private bool _isConvertBackWhenValueSet;
        private bool _convertBackWhenValue;
		/// <summary>
        /// PatternInterfaceの値がValueの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenValue
        {
            get
            {
                return _convertBackWhenValue;
            }
            set
            {
                _convertBackWhenValue = value;
                _isConvertBackWhenValueSet = true;
            }
        }
        private bool _isConvertBackWhenRangeValueSet;
        private bool _convertBackWhenRangeValue;
		/// <summary>
        /// PatternInterfaceの値がRangeValueの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenRangeValue
        {
            get
            {
                return _convertBackWhenRangeValue;
            }
            set
            {
                _convertBackWhenRangeValue = value;
                _isConvertBackWhenRangeValueSet = true;
            }
        }
        private bool _isConvertBackWhenScrollSet;
        private bool _convertBackWhenScroll;
		/// <summary>
        /// PatternInterfaceの値がScrollの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
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
        private bool _isConvertBackWhenScrollItemSet;
        private bool _convertBackWhenScrollItem;
		/// <summary>
        /// PatternInterfaceの値がScrollItemの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenScrollItem
        {
            get
            {
                return _convertBackWhenScrollItem;
            }
            set
            {
                _convertBackWhenScrollItem = value;
                _isConvertBackWhenScrollItemSet = true;
            }
        }
        private bool _isConvertBackWhenExpandCollapseSet;
        private bool _convertBackWhenExpandCollapse;
		/// <summary>
        /// PatternInterfaceの値がExpandCollapseの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenExpandCollapse
        {
            get
            {
                return _convertBackWhenExpandCollapse;
            }
            set
            {
                _convertBackWhenExpandCollapse = value;
                _isConvertBackWhenExpandCollapseSet = true;
            }
        }
        private bool _isConvertBackWhenGridSet;
        private bool _convertBackWhenGrid;
		/// <summary>
        /// PatternInterfaceの値がGridの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenGrid
        {
            get
            {
                return _convertBackWhenGrid;
            }
            set
            {
                _convertBackWhenGrid = value;
                _isConvertBackWhenGridSet = true;
            }
        }
        private bool _isConvertBackWhenGridItemSet;
        private bool _convertBackWhenGridItem;
		/// <summary>
        /// PatternInterfaceの値がGridItemの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenGridItem
        {
            get
            {
                return _convertBackWhenGridItem;
            }
            set
            {
                _convertBackWhenGridItem = value;
                _isConvertBackWhenGridItemSet = true;
            }
        }
        private bool _isConvertBackWhenMultipleViewSet;
        private bool _convertBackWhenMultipleView;
		/// <summary>
        /// PatternInterfaceの値がMultipleViewの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenMultipleView
        {
            get
            {
                return _convertBackWhenMultipleView;
            }
            set
            {
                _convertBackWhenMultipleView = value;
                _isConvertBackWhenMultipleViewSet = true;
            }
        }
        private bool _isConvertBackWhenWindowSet;
        private bool _convertBackWhenWindow;
		/// <summary>
        /// PatternInterfaceの値がWindowの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
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
        private bool _isConvertBackWhenSelectionItemSet;
        private bool _convertBackWhenSelectionItem;
		/// <summary>
        /// PatternInterfaceの値がSelectionItemの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenSelectionItem
        {
            get
            {
                return _convertBackWhenSelectionItem;
            }
            set
            {
                _convertBackWhenSelectionItem = value;
                _isConvertBackWhenSelectionItemSet = true;
            }
        }
        private bool _isConvertBackWhenDockSet;
        private bool _convertBackWhenDock;
		/// <summary>
        /// PatternInterfaceの値がDockの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenDock
        {
            get
            {
                return _convertBackWhenDock;
            }
            set
            {
                _convertBackWhenDock = value;
                _isConvertBackWhenDockSet = true;
            }
        }
        private bool _isConvertBackWhenTableSet;
        private bool _convertBackWhenTable;
		/// <summary>
        /// PatternInterfaceの値がTableの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
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
        private bool _isConvertBackWhenTableItemSet;
        private bool _convertBackWhenTableItem;
		/// <summary>
        /// PatternInterfaceの値がTableItemの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenTableItem
        {
            get
            {
                return _convertBackWhenTableItem;
            }
            set
            {
                _convertBackWhenTableItem = value;
                _isConvertBackWhenTableItemSet = true;
            }
        }
        private bool _isConvertBackWhenToggleSet;
        private bool _convertBackWhenToggle;
		/// <summary>
        /// PatternInterfaceの値がToggleの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenToggle
        {
            get
            {
                return _convertBackWhenToggle;
            }
            set
            {
                _convertBackWhenToggle = value;
                _isConvertBackWhenToggleSet = true;
            }
        }
        private bool _isConvertBackWhenTransformSet;
        private bool _convertBackWhenTransform;
		/// <summary>
        /// PatternInterfaceの値がTransformの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenTransform
        {
            get
            {
                return _convertBackWhenTransform;
            }
            set
            {
                _convertBackWhenTransform = value;
                _isConvertBackWhenTransformSet = true;
            }
        }
        private bool _isConvertBackWhenTextSet;
        private bool _convertBackWhenText;
		/// <summary>
        /// PatternInterfaceの値がTextの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
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
        private bool _isConvertBackWhenItemContainerSet;
        private bool _convertBackWhenItemContainer;
		/// <summary>
        /// PatternInterfaceの値がItemContainerの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenItemContainer
        {
            get
            {
                return _convertBackWhenItemContainer;
            }
            set
            {
                _convertBackWhenItemContainer = value;
                _isConvertBackWhenItemContainerSet = true;
            }
        }
        private bool _isConvertBackWhenVirtualizedItemSet;
        private bool _convertBackWhenVirtualizedItem;
		/// <summary>
        /// PatternInterfaceの値がVirtualizedItemの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenVirtualizedItem
        {
            get
            {
                return _convertBackWhenVirtualizedItem;
            }
            set
            {
                _convertBackWhenVirtualizedItem = value;
                _isConvertBackWhenVirtualizedItemSet = true;
            }
        }
        private bool _isConvertBackWhenSynchronizedInputSet;
        private bool _convertBackWhenSynchronizedInput;
		/// <summary>
        /// PatternInterfaceの値がSynchronizedInputの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenSynchronizedInput
        {
            get
            {
                return _convertBackWhenSynchronizedInput;
            }
            set
            {
                _convertBackWhenSynchronizedInput = value;
                _isConvertBackWhenSynchronizedInputSet = true;
            }
        }
    }
}