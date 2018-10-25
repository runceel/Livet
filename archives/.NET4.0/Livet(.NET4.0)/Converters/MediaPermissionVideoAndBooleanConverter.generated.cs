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
    /// MediaPermissionVideo列挙体とbool値の相互変換を行うIValueConverterです。
    /// </summary>
    public class MediaPermissionVideoAndBooleanConverter : IValueConverter
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
        private MediaPermissionVideo _convertWhenTrue;
		/// <summary>
        /// ソース値がTrueの際にどのMediaPermissionVideo列挙体メンバーに変換するかを指定、または取得します。
        /// </summary>
        public MediaPermissionVideo ConvertWhenTrue
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
        private MediaPermissionVideo _convertWhenFalse;
		/// <summary>
        /// ソース値がFalseの際にどのMediaPermissionVideo列挙体メンバーに変換するかを指定、または取得します。
        /// </summary>
        public MediaPermissionVideo ConvertWhenFalse
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
            if (!(value is MediaPermissionVideo)) throw new ArgumentException();

            var enumValue = (MediaPermissionVideo)value;

			switch(enumValue.ToString())
			{
				case "NoVideo":
					if (_isConvertBackWhenNoVideoSet)
					{
						return ConvertBackWhenNoVideo;
					}
					break;
				case "SiteOfOriginVideo":
					if (_isConvertBackWhenSiteOfOriginVideoSet)
					{
						return ConvertBackWhenSiteOfOriginVideo;
					}
					break;
				case "SafeVideo":
					if (_isConvertBackWhenSafeVideoSet)
					{
						return ConvertBackWhenSafeVideo;
					}
					break;
				case "AllVideo":
					if (_isConvertBackWhenAllVideoSet)
					{
						return ConvertBackWhenAllVideo;
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
        /// MediaPermissionVideoの値をbool値に変換する際のデフォルト値を指定、または取得します。
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

        private bool _isConvertBackWhenNoVideoSet;
        private bool _convertBackWhenNoVideo;
		/// <summary>
        /// MediaPermissionVideoの値がNoVideoの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenNoVideo
        {
            get
            {
                return _convertBackWhenNoVideo;
            }
            set
            {
                _convertBackWhenNoVideo = value;
                _isConvertBackWhenNoVideoSet = true;
            }
        }
        private bool _isConvertBackWhenSiteOfOriginVideoSet;
        private bool _convertBackWhenSiteOfOriginVideo;
		/// <summary>
        /// MediaPermissionVideoの値がSiteOfOriginVideoの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenSiteOfOriginVideo
        {
            get
            {
                return _convertBackWhenSiteOfOriginVideo;
            }
            set
            {
                _convertBackWhenSiteOfOriginVideo = value;
                _isConvertBackWhenSiteOfOriginVideoSet = true;
            }
        }
        private bool _isConvertBackWhenSafeVideoSet;
        private bool _convertBackWhenSafeVideo;
		/// <summary>
        /// MediaPermissionVideoの値がSafeVideoの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenSafeVideo
        {
            get
            {
                return _convertBackWhenSafeVideo;
            }
            set
            {
                _convertBackWhenSafeVideo = value;
                _isConvertBackWhenSafeVideoSet = true;
            }
        }
        private bool _isConvertBackWhenAllVideoSet;
        private bool _convertBackWhenAllVideo;
		/// <summary>
        /// MediaPermissionVideoの値がAllVideoの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenAllVideo
        {
            get
            {
                return _convertBackWhenAllVideo;
            }
            set
            {
                _convertBackWhenAllVideo = value;
                _isConvertBackWhenAllVideoSet = true;
            }
        }
    }
}