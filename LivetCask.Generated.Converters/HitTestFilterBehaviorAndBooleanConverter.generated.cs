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
    /// HitTestFilterBehavior列挙体とbool値の相互変換を行うIValueConverterです。
    /// </summary>
    public class HitTestFilterBehaviorAndBooleanConverter : IValueConverter
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
        private HitTestFilterBehavior _convertWhenTrue;
		/// <summary>
        /// ソース値がTrueの際にどのHitTestFilterBehavior列挙体メンバーに変換するかを指定、または取得します。
        /// </summary>
        public HitTestFilterBehavior ConvertWhenTrue
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
        private HitTestFilterBehavior _convertWhenFalse;
		/// <summary>
        /// ソース値がFalseの際にどのHitTestFilterBehavior列挙体メンバーに変換するかを指定、または取得します。
        /// </summary>
        public HitTestFilterBehavior ConvertWhenFalse
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
            if (!(value is HitTestFilterBehavior)) throw new ArgumentException();

            var enumValue = (HitTestFilterBehavior)value;

			switch(enumValue.ToString())
			{
				case "ContinueSkipSelfAndChildren":
					if (_isConvertBackWhenContinueSkipSelfAndChildrenSet)
					{
						return ConvertBackWhenContinueSkipSelfAndChildren;
					}
					break;
				case "ContinueSkipChildren":
					if (_isConvertBackWhenContinueSkipChildrenSet)
					{
						return ConvertBackWhenContinueSkipChildren;
					}
					break;
				case "ContinueSkipSelf":
					if (_isConvertBackWhenContinueSkipSelfSet)
					{
						return ConvertBackWhenContinueSkipSelf;
					}
					break;
				case "Continue":
					if (_isConvertBackWhenContinueSet)
					{
						return ConvertBackWhenContinue;
					}
					break;
				case "Stop":
					if (_isConvertBackWhenStopSet)
					{
						return ConvertBackWhenStop;
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
        /// HitTestFilterBehaviorの値をbool値に変換する際のデフォルト値を指定、または取得します。
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

        private bool _isConvertBackWhenContinueSkipSelfAndChildrenSet;
        private bool _convertBackWhenContinueSkipSelfAndChildren;
		/// <summary>
        /// HitTestFilterBehaviorの値がContinueSkipSelfAndChildrenの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenContinueSkipSelfAndChildren
        {
            get
            {
                return _convertBackWhenContinueSkipSelfAndChildren;
            }
            set
            {
                _convertBackWhenContinueSkipSelfAndChildren = value;
                _isConvertBackWhenContinueSkipSelfAndChildrenSet = true;
            }
        }
        private bool _isConvertBackWhenContinueSkipChildrenSet;
        private bool _convertBackWhenContinueSkipChildren;
		/// <summary>
        /// HitTestFilterBehaviorの値がContinueSkipChildrenの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenContinueSkipChildren
        {
            get
            {
                return _convertBackWhenContinueSkipChildren;
            }
            set
            {
                _convertBackWhenContinueSkipChildren = value;
                _isConvertBackWhenContinueSkipChildrenSet = true;
            }
        }
        private bool _isConvertBackWhenContinueSkipSelfSet;
        private bool _convertBackWhenContinueSkipSelf;
		/// <summary>
        /// HitTestFilterBehaviorの値がContinueSkipSelfの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenContinueSkipSelf
        {
            get
            {
                return _convertBackWhenContinueSkipSelf;
            }
            set
            {
                _convertBackWhenContinueSkipSelf = value;
                _isConvertBackWhenContinueSkipSelfSet = true;
            }
        }
        private bool _isConvertBackWhenContinueSet;
        private bool _convertBackWhenContinue;
		/// <summary>
        /// HitTestFilterBehaviorの値がContinueの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenContinue
        {
            get
            {
                return _convertBackWhenContinue;
            }
            set
            {
                _convertBackWhenContinue = value;
                _isConvertBackWhenContinueSet = true;
            }
        }
        private bool _isConvertBackWhenStopSet;
        private bool _convertBackWhenStop;
		/// <summary>
        /// HitTestFilterBehaviorの値がStopの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenStop
        {
            get
            {
                return _convertBackWhenStop;
            }
            set
            {
                _convertBackWhenStop = value;
                _isConvertBackWhenStopSet = true;
            }
        }
    }
}