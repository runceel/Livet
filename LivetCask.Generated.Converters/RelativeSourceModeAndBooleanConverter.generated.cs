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
    /// RelativeSourceMode列挙体とbool値の相互変換を行うIValueConverterです。
    /// </summary>
    public class RelativeSourceModeAndBooleanConverter : IValueConverter
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
        private RelativeSourceMode _convertWhenTrue;
		/// <summary>
        /// ソース値がTrueの際にどのRelativeSourceMode列挙体メンバーに変換するかを指定、または取得します。
        /// </summary>
        public RelativeSourceMode ConvertWhenTrue
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
        private RelativeSourceMode _convertWhenFalse;
		/// <summary>
        /// ソース値がFalseの際にどのRelativeSourceMode列挙体メンバーに変換するかを指定、または取得します。
        /// </summary>
        public RelativeSourceMode ConvertWhenFalse
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
            if (!(value is RelativeSourceMode)) throw new ArgumentException();

            var enumValue = (RelativeSourceMode)value;

			switch(enumValue.ToString())
			{
				case "PreviousData":
					if (_isConvertBackWhenPreviousDataSet)
					{
						return ConvertBackWhenPreviousData;
					}
					break;
				case "TemplatedParent":
					if (_isConvertBackWhenTemplatedParentSet)
					{
						return ConvertBackWhenTemplatedParent;
					}
					break;
				case "Self":
					if (_isConvertBackWhenSelfSet)
					{
						return ConvertBackWhenSelf;
					}
					break;
				case "FindAncestor":
					if (_isConvertBackWhenFindAncestorSet)
					{
						return ConvertBackWhenFindAncestor;
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
        /// RelativeSourceModeの値をbool値に変換する際のデフォルト値を指定、または取得します。
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

        private bool _isConvertBackWhenPreviousDataSet;
        private bool _convertBackWhenPreviousData;
		/// <summary>
        /// RelativeSourceModeの値がPreviousDataの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenPreviousData
        {
            get
            {
                return _convertBackWhenPreviousData;
            }
            set
            {
                _convertBackWhenPreviousData = value;
                _isConvertBackWhenPreviousDataSet = true;
            }
        }
        private bool _isConvertBackWhenTemplatedParentSet;
        private bool _convertBackWhenTemplatedParent;
		/// <summary>
        /// RelativeSourceModeの値がTemplatedParentの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenTemplatedParent
        {
            get
            {
                return _convertBackWhenTemplatedParent;
            }
            set
            {
                _convertBackWhenTemplatedParent = value;
                _isConvertBackWhenTemplatedParentSet = true;
            }
        }
        private bool _isConvertBackWhenSelfSet;
        private bool _convertBackWhenSelf;
		/// <summary>
        /// RelativeSourceModeの値がSelfの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenSelf
        {
            get
            {
                return _convertBackWhenSelf;
            }
            set
            {
                _convertBackWhenSelf = value;
                _isConvertBackWhenSelfSet = true;
            }
        }
        private bool _isConvertBackWhenFindAncestorSet;
        private bool _convertBackWhenFindAncestor;
		/// <summary>
        /// RelativeSourceModeの値がFindAncestorの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenFindAncestor
        {
            get
            {
                return _convertBackWhenFindAncestor;
            }
            set
            {
                _convertBackWhenFindAncestor = value;
                _isConvertBackWhenFindAncestorSet = true;
            }
        }
    }
}