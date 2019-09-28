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
    /// BindingStatus列挙体とbool値の相互変換を行うIValueConverterです。
    /// </summary>
    public class BindingStatusAndBooleanConverter : IValueConverter
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
        private BindingStatus _convertWhenTrue;
		/// <summary>
        /// ソース値がTrueの際にどのBindingStatus列挙体メンバーに変換するかを指定、または取得します。
        /// </summary>
        public BindingStatus ConvertWhenTrue
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
        private BindingStatus _convertWhenFalse;
		/// <summary>
        /// ソース値がFalseの際にどのBindingStatus列挙体メンバーに変換するかを指定、または取得します。
        /// </summary>
        public BindingStatus ConvertWhenFalse
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
            if (!(value is BindingStatus)) throw new ArgumentException();

            var enumValue = (BindingStatus)value;

			switch(enumValue.ToString())
			{
				case "Unattached":
					if (_isConvertBackWhenUnattachedSet)
					{
						return ConvertBackWhenUnattached;
					}
					break;
				case "Inactive":
					if (_isConvertBackWhenInactiveSet)
					{
						return ConvertBackWhenInactive;
					}
					break;
				case "Active":
					if (_isConvertBackWhenActiveSet)
					{
						return ConvertBackWhenActive;
					}
					break;
				case "Detached":
					if (_isConvertBackWhenDetachedSet)
					{
						return ConvertBackWhenDetached;
					}
					break;
				case "AsyncRequestPending":
					if (_isConvertBackWhenAsyncRequestPendingSet)
					{
						return ConvertBackWhenAsyncRequestPending;
					}
					break;
				case "PathError":
					if (_isConvertBackWhenPathErrorSet)
					{
						return ConvertBackWhenPathError;
					}
					break;
				case "UpdateTargetError":
					if (_isConvertBackWhenUpdateTargetErrorSet)
					{
						return ConvertBackWhenUpdateTargetError;
					}
					break;
				case "UpdateSourceError":
					if (_isConvertBackWhenUpdateSourceErrorSet)
					{
						return ConvertBackWhenUpdateSourceError;
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
        /// BindingStatusの値をbool値に変換する際のデフォルト値を指定、または取得します。
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

        private bool _isConvertBackWhenUnattachedSet;
        private bool _convertBackWhenUnattached;
		/// <summary>
        /// BindingStatusの値がUnattachedの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenUnattached
        {
            get
            {
                return _convertBackWhenUnattached;
            }
            set
            {
                _convertBackWhenUnattached = value;
                _isConvertBackWhenUnattachedSet = true;
            }
        }
        private bool _isConvertBackWhenInactiveSet;
        private bool _convertBackWhenInactive;
		/// <summary>
        /// BindingStatusの値がInactiveの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenInactive
        {
            get
            {
                return _convertBackWhenInactive;
            }
            set
            {
                _convertBackWhenInactive = value;
                _isConvertBackWhenInactiveSet = true;
            }
        }
        private bool _isConvertBackWhenActiveSet;
        private bool _convertBackWhenActive;
		/// <summary>
        /// BindingStatusの値がActiveの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenActive
        {
            get
            {
                return _convertBackWhenActive;
            }
            set
            {
                _convertBackWhenActive = value;
                _isConvertBackWhenActiveSet = true;
            }
        }
        private bool _isConvertBackWhenDetachedSet;
        private bool _convertBackWhenDetached;
		/// <summary>
        /// BindingStatusの値がDetachedの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenDetached
        {
            get
            {
                return _convertBackWhenDetached;
            }
            set
            {
                _convertBackWhenDetached = value;
                _isConvertBackWhenDetachedSet = true;
            }
        }
        private bool _isConvertBackWhenAsyncRequestPendingSet;
        private bool _convertBackWhenAsyncRequestPending;
		/// <summary>
        /// BindingStatusの値がAsyncRequestPendingの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenAsyncRequestPending
        {
            get
            {
                return _convertBackWhenAsyncRequestPending;
            }
            set
            {
                _convertBackWhenAsyncRequestPending = value;
                _isConvertBackWhenAsyncRequestPendingSet = true;
            }
        }
        private bool _isConvertBackWhenPathErrorSet;
        private bool _convertBackWhenPathError;
		/// <summary>
        /// BindingStatusの値がPathErrorの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenPathError
        {
            get
            {
                return _convertBackWhenPathError;
            }
            set
            {
                _convertBackWhenPathError = value;
                _isConvertBackWhenPathErrorSet = true;
            }
        }
        private bool _isConvertBackWhenUpdateTargetErrorSet;
        private bool _convertBackWhenUpdateTargetError;
		/// <summary>
        /// BindingStatusの値がUpdateTargetErrorの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenUpdateTargetError
        {
            get
            {
                return _convertBackWhenUpdateTargetError;
            }
            set
            {
                _convertBackWhenUpdateTargetError = value;
                _isConvertBackWhenUpdateTargetErrorSet = true;
            }
        }
        private bool _isConvertBackWhenUpdateSourceErrorSet;
        private bool _convertBackWhenUpdateSourceError;
		/// <summary>
        /// BindingStatusの値がUpdateSourceErrorの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenUpdateSourceError
        {
            get
            {
                return _convertBackWhenUpdateSourceError;
            }
            set
            {
                _convertBackWhenUpdateSourceError = value;
                _isConvertBackWhenUpdateSourceErrorSet = true;
            }
        }
    }
}