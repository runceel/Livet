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
    /// DispatcherOperationStatus列挙体とbool値の相互変換を行うIValueConverterです。
    /// </summary>
    public class DispatcherOperationStatusAndBooleanConverter : IValueConverter
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
        private DispatcherOperationStatus _convertWhenTrue;
		/// <summary>
        /// ソース値がTrueの際にどのDispatcherOperationStatus列挙体メンバーに変換するかを指定、または取得します。
        /// </summary>
        public DispatcherOperationStatus ConvertWhenTrue
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
        private DispatcherOperationStatus _convertWhenFalse;
		/// <summary>
        /// ソース値がFalseの際にどのDispatcherOperationStatus列挙体メンバーに変換するかを指定、または取得します。
        /// </summary>
        public DispatcherOperationStatus ConvertWhenFalse
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
            if (!(value is DispatcherOperationStatus)) throw new ArgumentException();

            var enumValue = (DispatcherOperationStatus)value;

			switch(enumValue.ToString())
			{
				case "Pending":
					if (_isConvertBackWhenPendingSet)
					{
						return ConvertBackWhenPending;
					}
					break;
				case "Aborted":
					if (_isConvertBackWhenAbortedSet)
					{
						return ConvertBackWhenAborted;
					}
					break;
				case "Completed":
					if (_isConvertBackWhenCompletedSet)
					{
						return ConvertBackWhenCompleted;
					}
					break;
				case "Executing":
					if (_isConvertBackWhenExecutingSet)
					{
						return ConvertBackWhenExecuting;
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
        /// DispatcherOperationStatusの値をbool値に変換する際のデフォルト値を指定、または取得します。
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

        private bool _isConvertBackWhenPendingSet;
        private bool _convertBackWhenPending;
		/// <summary>
        /// DispatcherOperationStatusの値がPendingの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenPending
        {
            get
            {
                return _convertBackWhenPending;
            }
            set
            {
                _convertBackWhenPending = value;
                _isConvertBackWhenPendingSet = true;
            }
        }
        private bool _isConvertBackWhenAbortedSet;
        private bool _convertBackWhenAborted;
		/// <summary>
        /// DispatcherOperationStatusの値がAbortedの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenAborted
        {
            get
            {
                return _convertBackWhenAborted;
            }
            set
            {
                _convertBackWhenAborted = value;
                _isConvertBackWhenAbortedSet = true;
            }
        }
        private bool _isConvertBackWhenCompletedSet;
        private bool _convertBackWhenCompleted;
		/// <summary>
        /// DispatcherOperationStatusの値がCompletedの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenCompleted
        {
            get
            {
                return _convertBackWhenCompleted;
            }
            set
            {
                _convertBackWhenCompleted = value;
                _isConvertBackWhenCompletedSet = true;
            }
        }
        private bool _isConvertBackWhenExecutingSet;
        private bool _convertBackWhenExecuting;
		/// <summary>
        /// DispatcherOperationStatusの値がExecutingの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenExecuting
        {
            get
            {
                return _convertBackWhenExecuting;
            }
            set
            {
                _convertBackWhenExecuting = value;
                _isConvertBackWhenExecutingSet = true;
            }
        }
    }
}