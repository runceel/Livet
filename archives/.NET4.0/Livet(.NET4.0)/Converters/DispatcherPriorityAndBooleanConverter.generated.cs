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
    /// DispatcherPriority列挙体とbool値の相互変換を行うIValueConverterです。
    /// </summary>
    public class DispatcherPriorityAndBooleanConverter : IValueConverter
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
        private DispatcherPriority _convertWhenTrue;
		/// <summary>
        /// ソース値がTrueの際にどのDispatcherPriority列挙体メンバーに変換するかを指定、または取得します。
        /// </summary>
        public DispatcherPriority ConvertWhenTrue
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
        private DispatcherPriority _convertWhenFalse;
		/// <summary>
        /// ソース値がFalseの際にどのDispatcherPriority列挙体メンバーに変換するかを指定、または取得します。
        /// </summary>
        public DispatcherPriority ConvertWhenFalse
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
            if (!(value is DispatcherPriority)) throw new ArgumentException();

            var enumValue = (DispatcherPriority)value;

			switch(enumValue.ToString())
			{
				case "Inactive":
					if (_isConvertBackWhenInactiveSet)
					{
						return ConvertBackWhenInactive;
					}
					break;
				case "SystemIdle":
					if (_isConvertBackWhenSystemIdleSet)
					{
						return ConvertBackWhenSystemIdle;
					}
					break;
				case "ApplicationIdle":
					if (_isConvertBackWhenApplicationIdleSet)
					{
						return ConvertBackWhenApplicationIdle;
					}
					break;
				case "ContextIdle":
					if (_isConvertBackWhenContextIdleSet)
					{
						return ConvertBackWhenContextIdle;
					}
					break;
				case "Background":
					if (_isConvertBackWhenBackgroundSet)
					{
						return ConvertBackWhenBackground;
					}
					break;
				case "Input":
					if (_isConvertBackWhenInputSet)
					{
						return ConvertBackWhenInput;
					}
					break;
				case "Loaded":
					if (_isConvertBackWhenLoadedSet)
					{
						return ConvertBackWhenLoaded;
					}
					break;
				case "Render":
					if (_isConvertBackWhenRenderSet)
					{
						return ConvertBackWhenRender;
					}
					break;
				case "DataBind":
					if (_isConvertBackWhenDataBindSet)
					{
						return ConvertBackWhenDataBind;
					}
					break;
				case "Normal":
					if (_isConvertBackWhenNormalSet)
					{
						return ConvertBackWhenNormal;
					}
					break;
				case "Send":
					if (_isConvertBackWhenSendSet)
					{
						return ConvertBackWhenSend;
					}
					break;
				case "Invalid":
					if (_isConvertBackWhenInvalidSet)
					{
						return ConvertBackWhenInvalid;
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
        /// DispatcherPriorityの値をbool値に変換する際のデフォルト値を指定、または取得します。
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

        private bool _isConvertBackWhenInactiveSet;
        private bool _convertBackWhenInactive;
		/// <summary>
        /// DispatcherPriorityの値がInactiveの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
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
        private bool _isConvertBackWhenSystemIdleSet;
        private bool _convertBackWhenSystemIdle;
		/// <summary>
        /// DispatcherPriorityの値がSystemIdleの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenSystemIdle
        {
            get
            {
                return _convertBackWhenSystemIdle;
            }
            set
            {
                _convertBackWhenSystemIdle = value;
                _isConvertBackWhenSystemIdleSet = true;
            }
        }
        private bool _isConvertBackWhenApplicationIdleSet;
        private bool _convertBackWhenApplicationIdle;
		/// <summary>
        /// DispatcherPriorityの値がApplicationIdleの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenApplicationIdle
        {
            get
            {
                return _convertBackWhenApplicationIdle;
            }
            set
            {
                _convertBackWhenApplicationIdle = value;
                _isConvertBackWhenApplicationIdleSet = true;
            }
        }
        private bool _isConvertBackWhenContextIdleSet;
        private bool _convertBackWhenContextIdle;
		/// <summary>
        /// DispatcherPriorityの値がContextIdleの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenContextIdle
        {
            get
            {
                return _convertBackWhenContextIdle;
            }
            set
            {
                _convertBackWhenContextIdle = value;
                _isConvertBackWhenContextIdleSet = true;
            }
        }
        private bool _isConvertBackWhenBackgroundSet;
        private bool _convertBackWhenBackground;
		/// <summary>
        /// DispatcherPriorityの値がBackgroundの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenBackground
        {
            get
            {
                return _convertBackWhenBackground;
            }
            set
            {
                _convertBackWhenBackground = value;
                _isConvertBackWhenBackgroundSet = true;
            }
        }
        private bool _isConvertBackWhenInputSet;
        private bool _convertBackWhenInput;
		/// <summary>
        /// DispatcherPriorityの値がInputの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenInput
        {
            get
            {
                return _convertBackWhenInput;
            }
            set
            {
                _convertBackWhenInput = value;
                _isConvertBackWhenInputSet = true;
            }
        }
        private bool _isConvertBackWhenLoadedSet;
        private bool _convertBackWhenLoaded;
		/// <summary>
        /// DispatcherPriorityの値がLoadedの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenLoaded
        {
            get
            {
                return _convertBackWhenLoaded;
            }
            set
            {
                _convertBackWhenLoaded = value;
                _isConvertBackWhenLoadedSet = true;
            }
        }
        private bool _isConvertBackWhenRenderSet;
        private bool _convertBackWhenRender;
		/// <summary>
        /// DispatcherPriorityの値がRenderの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenRender
        {
            get
            {
                return _convertBackWhenRender;
            }
            set
            {
                _convertBackWhenRender = value;
                _isConvertBackWhenRenderSet = true;
            }
        }
        private bool _isConvertBackWhenDataBindSet;
        private bool _convertBackWhenDataBind;
		/// <summary>
        /// DispatcherPriorityの値がDataBindの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenDataBind
        {
            get
            {
                return _convertBackWhenDataBind;
            }
            set
            {
                _convertBackWhenDataBind = value;
                _isConvertBackWhenDataBindSet = true;
            }
        }
        private bool _isConvertBackWhenNormalSet;
        private bool _convertBackWhenNormal;
		/// <summary>
        /// DispatcherPriorityの値がNormalの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenNormal
        {
            get
            {
                return _convertBackWhenNormal;
            }
            set
            {
                _convertBackWhenNormal = value;
                _isConvertBackWhenNormalSet = true;
            }
        }
        private bool _isConvertBackWhenSendSet;
        private bool _convertBackWhenSend;
		/// <summary>
        /// DispatcherPriorityの値がSendの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenSend
        {
            get
            {
                return _convertBackWhenSend;
            }
            set
            {
                _convertBackWhenSend = value;
                _isConvertBackWhenSendSet = true;
            }
        }
        private bool _isConvertBackWhenInvalidSet;
        private bool _convertBackWhenInvalid;
		/// <summary>
        /// DispatcherPriorityの値がInvalidの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenInvalid
        {
            get
            {
                return _convertBackWhenInvalid;
            }
            set
            {
                _convertBackWhenInvalid = value;
                _isConvertBackWhenInvalidSet = true;
            }
        }
    }
}