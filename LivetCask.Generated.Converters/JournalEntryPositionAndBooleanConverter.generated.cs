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
    /// JournalEntryPosition列挙体とbool値の相互変換を行うIValueConverterです。
    /// </summary>
    public class JournalEntryPositionAndBooleanConverter : IValueConverter
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
        private JournalEntryPosition _convertWhenTrue;
		/// <summary>
        /// ソース値がTrueの際にどのJournalEntryPosition列挙体メンバーに変換するかを指定、または取得します。
        /// </summary>
        public JournalEntryPosition ConvertWhenTrue
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
        private JournalEntryPosition _convertWhenFalse;
		/// <summary>
        /// ソース値がFalseの際にどのJournalEntryPosition列挙体メンバーに変換するかを指定、または取得します。
        /// </summary>
        public JournalEntryPosition ConvertWhenFalse
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
            if (!(value is JournalEntryPosition)) throw new ArgumentException();

            var enumValue = (JournalEntryPosition)value;

			switch(enumValue.ToString())
			{
				case "Back":
					if (_isConvertBackWhenBackSet)
					{
						return ConvertBackWhenBack;
					}
					break;
				case "Current":
					if (_isConvertBackWhenCurrentSet)
					{
						return ConvertBackWhenCurrent;
					}
					break;
				case "Forward":
					if (_isConvertBackWhenForwardSet)
					{
						return ConvertBackWhenForward;
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
        /// JournalEntryPositionの値をbool値に変換する際のデフォルト値を指定、または取得します。
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

        private bool _isConvertBackWhenBackSet;
        private bool _convertBackWhenBack;
		/// <summary>
        /// JournalEntryPositionの値がBackの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenBack
        {
            get
            {
                return _convertBackWhenBack;
            }
            set
            {
                _convertBackWhenBack = value;
                _isConvertBackWhenBackSet = true;
            }
        }
        private bool _isConvertBackWhenCurrentSet;
        private bool _convertBackWhenCurrent;
		/// <summary>
        /// JournalEntryPositionの値がCurrentの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenCurrent
        {
            get
            {
                return _convertBackWhenCurrent;
            }
            set
            {
                _convertBackWhenCurrent = value;
                _isConvertBackWhenCurrentSet = true;
            }
        }
        private bool _isConvertBackWhenForwardSet;
        private bool _convertBackWhenForward;
		/// <summary>
        /// JournalEntryPositionの値がForwardの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenForward
        {
            get
            {
                return _convertBackWhenForward;
            }
            set
            {
                _convertBackWhenForward = value;
                _isConvertBackWhenForwardSet = true;
            }
        }
    }
}