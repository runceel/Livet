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
    /// BitmapCreateOptions列挙体とbool値の相互変換を行うIValueConverterです。
    /// </summary>
    public class BitmapCreateOptionsAndBooleanConverter : IValueConverter
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
        private BitmapCreateOptions _convertWhenTrue;
		/// <summary>
        /// ソース値がTrueの際にどのBitmapCreateOptions列挙体メンバーに変換するかを指定、または取得します。
        /// </summary>
        public BitmapCreateOptions ConvertWhenTrue
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
        private BitmapCreateOptions _convertWhenFalse;
		/// <summary>
        /// ソース値がFalseの際にどのBitmapCreateOptions列挙体メンバーに変換するかを指定、または取得します。
        /// </summary>
        public BitmapCreateOptions ConvertWhenFalse
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
            if (!(value is BitmapCreateOptions)) throw new ArgumentException();

            var enumValue = (BitmapCreateOptions)value;

			switch(enumValue.ToString())
			{
				case "None":
					if (_isConvertBackWhenNoneSet)
					{
						return ConvertBackWhenNone;
					}
					break;
				case "PreservePixelFormat":
					if (_isConvertBackWhenPreservePixelFormatSet)
					{
						return ConvertBackWhenPreservePixelFormat;
					}
					break;
				case "DelayCreation":
					if (_isConvertBackWhenDelayCreationSet)
					{
						return ConvertBackWhenDelayCreation;
					}
					break;
				case "IgnoreColorProfile":
					if (_isConvertBackWhenIgnoreColorProfileSet)
					{
						return ConvertBackWhenIgnoreColorProfile;
					}
					break;
				case "IgnoreImageCache":
					if (_isConvertBackWhenIgnoreImageCacheSet)
					{
						return ConvertBackWhenIgnoreImageCache;
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
        /// BitmapCreateOptionsの値をbool値に変換する際のデフォルト値を指定、または取得します。
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
        /// BitmapCreateOptionsの値がNoneの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
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
        private bool _isConvertBackWhenPreservePixelFormatSet;
        private bool _convertBackWhenPreservePixelFormat;
		/// <summary>
        /// BitmapCreateOptionsの値がPreservePixelFormatの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenPreservePixelFormat
        {
            get
            {
                return _convertBackWhenPreservePixelFormat;
            }
            set
            {
                _convertBackWhenPreservePixelFormat = value;
                _isConvertBackWhenPreservePixelFormatSet = true;
            }
        }
        private bool _isConvertBackWhenDelayCreationSet;
        private bool _convertBackWhenDelayCreation;
		/// <summary>
        /// BitmapCreateOptionsの値がDelayCreationの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenDelayCreation
        {
            get
            {
                return _convertBackWhenDelayCreation;
            }
            set
            {
                _convertBackWhenDelayCreation = value;
                _isConvertBackWhenDelayCreationSet = true;
            }
        }
        private bool _isConvertBackWhenIgnoreColorProfileSet;
        private bool _convertBackWhenIgnoreColorProfile;
		/// <summary>
        /// BitmapCreateOptionsの値がIgnoreColorProfileの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenIgnoreColorProfile
        {
            get
            {
                return _convertBackWhenIgnoreColorProfile;
            }
            set
            {
                _convertBackWhenIgnoreColorProfile = value;
                _isConvertBackWhenIgnoreColorProfileSet = true;
            }
        }
        private bool _isConvertBackWhenIgnoreImageCacheSet;
        private bool _convertBackWhenIgnoreImageCache;
		/// <summary>
        /// BitmapCreateOptionsの値がIgnoreImageCacheの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenIgnoreImageCache
        {
            get
            {
                return _convertBackWhenIgnoreImageCache;
            }
            set
            {
                _convertBackWhenIgnoreImageCache = value;
                _isConvertBackWhenIgnoreImageCacheSet = true;
            }
        }
    }
}