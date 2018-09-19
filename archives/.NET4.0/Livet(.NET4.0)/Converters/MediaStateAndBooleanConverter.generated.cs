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
    /// MediaState列挙体とbool値の相互変換を行うIValueConverterです。
    /// </summary>
    public class MediaStateAndBooleanConverter : IValueConverter
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
        private MediaState _convertWhenTrue;
		/// <summary>
        /// ソース値がTrueの際にどのMediaState列挙体メンバーに変換するかを指定、または取得します。
        /// </summary>
        public MediaState ConvertWhenTrue
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
        private MediaState _convertWhenFalse;
		/// <summary>
        /// ソース値がFalseの際にどのMediaState列挙体メンバーに変換するかを指定、または取得します。
        /// </summary>
        public MediaState ConvertWhenFalse
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
            if (!(value is MediaState)) throw new ArgumentException();

            var enumValue = (MediaState)value;

			switch(enumValue.ToString())
			{
				case "Manual":
					if (_isConvertBackWhenManualSet)
					{
						return ConvertBackWhenManual;
					}
					break;
				case "Play":
					if (_isConvertBackWhenPlaySet)
					{
						return ConvertBackWhenPlay;
					}
					break;
				case "Close":
					if (_isConvertBackWhenCloseSet)
					{
						return ConvertBackWhenClose;
					}
					break;
				case "Pause":
					if (_isConvertBackWhenPauseSet)
					{
						return ConvertBackWhenPause;
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
        /// MediaStateの値をbool値に変換する際のデフォルト値を指定、または取得します。
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

        private bool _isConvertBackWhenManualSet;
        private bool _convertBackWhenManual;
		/// <summary>
        /// MediaStateの値がManualの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenManual
        {
            get
            {
                return _convertBackWhenManual;
            }
            set
            {
                _convertBackWhenManual = value;
                _isConvertBackWhenManualSet = true;
            }
        }
        private bool _isConvertBackWhenPlaySet;
        private bool _convertBackWhenPlay;
		/// <summary>
        /// MediaStateの値がPlayの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenPlay
        {
            get
            {
                return _convertBackWhenPlay;
            }
            set
            {
                _convertBackWhenPlay = value;
                _isConvertBackWhenPlaySet = true;
            }
        }
        private bool _isConvertBackWhenCloseSet;
        private bool _convertBackWhenClose;
		/// <summary>
        /// MediaStateの値がCloseの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenClose
        {
            get
            {
                return _convertBackWhenClose;
            }
            set
            {
                _convertBackWhenClose = value;
                _isConvertBackWhenCloseSet = true;
            }
        }
        private bool _isConvertBackWhenPauseSet;
        private bool _convertBackWhenPause;
		/// <summary>
        /// MediaStateの値がPauseの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenPause
        {
            get
            {
                return _convertBackWhenPause;
            }
            set
            {
                _convertBackWhenPause = value;
                _isConvertBackWhenPauseSet = true;
            }
        }
        private bool _isConvertBackWhenStopSet;
        private bool _convertBackWhenStop;
		/// <summary>
        /// MediaStateの値がStopの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
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