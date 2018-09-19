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
    /// DragDropEffects列挙体とbool値の相互変換を行うIValueConverterです。
    /// </summary>
    public class DragDropEffectsAndBooleanConverter : IValueConverter
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
        private DragDropEffects _convertWhenTrue;
		/// <summary>
        /// ソース値がTrueの際にどのDragDropEffects列挙体メンバーに変換するかを指定、または取得します。
        /// </summary>
        public DragDropEffects ConvertWhenTrue
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
        private DragDropEffects _convertWhenFalse;
		/// <summary>
        /// ソース値がFalseの際にどのDragDropEffects列挙体メンバーに変換するかを指定、または取得します。
        /// </summary>
        public DragDropEffects ConvertWhenFalse
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
            if (!(value is DragDropEffects)) throw new ArgumentException();

            var enumValue = (DragDropEffects)value;

			switch(enumValue.ToString())
			{
				case "None":
					if (_isConvertBackWhenNoneSet)
					{
						return ConvertBackWhenNone;
					}
					break;
				case "Copy":
					if (_isConvertBackWhenCopySet)
					{
						return ConvertBackWhenCopy;
					}
					break;
				case "Move":
					if (_isConvertBackWhenMoveSet)
					{
						return ConvertBackWhenMove;
					}
					break;
				case "Link":
					if (_isConvertBackWhenLinkSet)
					{
						return ConvertBackWhenLink;
					}
					break;
				case "Scroll":
					if (_isConvertBackWhenScrollSet)
					{
						return ConvertBackWhenScroll;
					}
					break;
				case "All":
					if (_isConvertBackWhenAllSet)
					{
						return ConvertBackWhenAll;
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
        /// DragDropEffectsの値をbool値に変換する際のデフォルト値を指定、または取得します。
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
        /// DragDropEffectsの値がNoneの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
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
        private bool _isConvertBackWhenCopySet;
        private bool _convertBackWhenCopy;
		/// <summary>
        /// DragDropEffectsの値がCopyの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenCopy
        {
            get
            {
                return _convertBackWhenCopy;
            }
            set
            {
                _convertBackWhenCopy = value;
                _isConvertBackWhenCopySet = true;
            }
        }
        private bool _isConvertBackWhenMoveSet;
        private bool _convertBackWhenMove;
		/// <summary>
        /// DragDropEffectsの値がMoveの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenMove
        {
            get
            {
                return _convertBackWhenMove;
            }
            set
            {
                _convertBackWhenMove = value;
                _isConvertBackWhenMoveSet = true;
            }
        }
        private bool _isConvertBackWhenLinkSet;
        private bool _convertBackWhenLink;
		/// <summary>
        /// DragDropEffectsの値がLinkの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenLink
        {
            get
            {
                return _convertBackWhenLink;
            }
            set
            {
                _convertBackWhenLink = value;
                _isConvertBackWhenLinkSet = true;
            }
        }
        private bool _isConvertBackWhenScrollSet;
        private bool _convertBackWhenScroll;
		/// <summary>
        /// DragDropEffectsの値がScrollの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
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
        private bool _isConvertBackWhenAllSet;
        private bool _convertBackWhenAll;
		/// <summary>
        /// DragDropEffectsの値がAllの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenAll
        {
            get
            {
                return _convertBackWhenAll;
            }
            set
            {
                _convertBackWhenAll = value;
                _isConvertBackWhenAllSet = true;
            }
        }
    }
}