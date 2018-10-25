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
    /// MediaPermissionAudio列挙体とbool値の相互変換を行うIValueConverterです。
    /// </summary>
    public class MediaPermissionAudioAndBooleanConverter : IValueConverter
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
        private MediaPermissionAudio _convertWhenTrue;
		/// <summary>
        /// ソース値がTrueの際にどのMediaPermissionAudio列挙体メンバーに変換するかを指定、または取得します。
        /// </summary>
        public MediaPermissionAudio ConvertWhenTrue
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
        private MediaPermissionAudio _convertWhenFalse;
		/// <summary>
        /// ソース値がFalseの際にどのMediaPermissionAudio列挙体メンバーに変換するかを指定、または取得します。
        /// </summary>
        public MediaPermissionAudio ConvertWhenFalse
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
            if (!(value is MediaPermissionAudio)) throw new ArgumentException();

            var enumValue = (MediaPermissionAudio)value;

			switch(enumValue.ToString())
			{
				case "NoAudio":
					if (_isConvertBackWhenNoAudioSet)
					{
						return ConvertBackWhenNoAudio;
					}
					break;
				case "SiteOfOriginAudio":
					if (_isConvertBackWhenSiteOfOriginAudioSet)
					{
						return ConvertBackWhenSiteOfOriginAudio;
					}
					break;
				case "SafeAudio":
					if (_isConvertBackWhenSafeAudioSet)
					{
						return ConvertBackWhenSafeAudio;
					}
					break;
				case "AllAudio":
					if (_isConvertBackWhenAllAudioSet)
					{
						return ConvertBackWhenAllAudio;
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
        /// MediaPermissionAudioの値をbool値に変換する際のデフォルト値を指定、または取得します。
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

        private bool _isConvertBackWhenNoAudioSet;
        private bool _convertBackWhenNoAudio;
		/// <summary>
        /// MediaPermissionAudioの値がNoAudioの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenNoAudio
        {
            get
            {
                return _convertBackWhenNoAudio;
            }
            set
            {
                _convertBackWhenNoAudio = value;
                _isConvertBackWhenNoAudioSet = true;
            }
        }
        private bool _isConvertBackWhenSiteOfOriginAudioSet;
        private bool _convertBackWhenSiteOfOriginAudio;
		/// <summary>
        /// MediaPermissionAudioの値がSiteOfOriginAudioの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenSiteOfOriginAudio
        {
            get
            {
                return _convertBackWhenSiteOfOriginAudio;
            }
            set
            {
                _convertBackWhenSiteOfOriginAudio = value;
                _isConvertBackWhenSiteOfOriginAudioSet = true;
            }
        }
        private bool _isConvertBackWhenSafeAudioSet;
        private bool _convertBackWhenSafeAudio;
		/// <summary>
        /// MediaPermissionAudioの値がSafeAudioの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenSafeAudio
        {
            get
            {
                return _convertBackWhenSafeAudio;
            }
            set
            {
                _convertBackWhenSafeAudio = value;
                _isConvertBackWhenSafeAudioSet = true;
            }
        }
        private bool _isConvertBackWhenAllAudioSet;
        private bool _convertBackWhenAllAudio;
		/// <summary>
        /// MediaPermissionAudioの値がAllAudioの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenAllAudio
        {
            get
            {
                return _convertBackWhenAllAudio;
            }
            set
            {
                _convertBackWhenAllAudio = value;
                _isConvertBackWhenAllAudioSet = true;
            }
        }
    }
}