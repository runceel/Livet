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
    /// DataGridSelectionUnit列挙体とbool値の相互変換を行うIValueConverterです。
    /// </summary>
    public class DataGridSelectionUnitAndBooleanConverter : IValueConverter
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
        private DataGridSelectionUnit _convertWhenTrue;
		/// <summary>
        /// ソース値がTrueの際にどのDataGridSelectionUnit列挙体メンバーに変換するかを指定、または取得します。
        /// </summary>
        public DataGridSelectionUnit ConvertWhenTrue
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
        private DataGridSelectionUnit _convertWhenFalse;
		/// <summary>
        /// ソース値がFalseの際にどのDataGridSelectionUnit列挙体メンバーに変換するかを指定、または取得します。
        /// </summary>
        public DataGridSelectionUnit ConvertWhenFalse
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
            if (!(value is DataGridSelectionUnit)) throw new ArgumentException();

            var enumValue = (DataGridSelectionUnit)value;

			switch(enumValue.ToString())
			{
				case "Cell":
					if (_isConvertBackWhenCellSet)
					{
						return ConvertBackWhenCell;
					}
					break;
				case "FullRow":
					if (_isConvertBackWhenFullRowSet)
					{
						return ConvertBackWhenFullRow;
					}
					break;
				case "CellOrRowHeader":
					if (_isConvertBackWhenCellOrRowHeaderSet)
					{
						return ConvertBackWhenCellOrRowHeader;
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
        /// DataGridSelectionUnitの値をbool値に変換する際のデフォルト値を指定、または取得します。
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

        private bool _isConvertBackWhenCellSet;
        private bool _convertBackWhenCell;
		/// <summary>
        /// DataGridSelectionUnitの値がCellの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenCell
        {
            get
            {
                return _convertBackWhenCell;
            }
            set
            {
                _convertBackWhenCell = value;
                _isConvertBackWhenCellSet = true;
            }
        }
        private bool _isConvertBackWhenFullRowSet;
        private bool _convertBackWhenFullRow;
		/// <summary>
        /// DataGridSelectionUnitの値がFullRowの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenFullRow
        {
            get
            {
                return _convertBackWhenFullRow;
            }
            set
            {
                _convertBackWhenFullRow = value;
                _isConvertBackWhenFullRowSet = true;
            }
        }
        private bool _isConvertBackWhenCellOrRowHeaderSet;
        private bool _convertBackWhenCellOrRowHeader;
		/// <summary>
        /// DataGridSelectionUnitの値がCellOrRowHeaderの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenCellOrRowHeader
        {
            get
            {
                return _convertBackWhenCellOrRowHeader;
            }
            set
            {
                _convertBackWhenCellOrRowHeader = value;
                _isConvertBackWhenCellOrRowHeaderSet = true;
            }
        }
    }
}