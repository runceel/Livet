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
    /// FontEmbeddingRight列挙体とbool値の相互変換を行うIValueConverterです。
    /// </summary>
    public class FontEmbeddingRightAndBooleanConverter : IValueConverter
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
        private FontEmbeddingRight _convertWhenTrue;
		/// <summary>
        /// ソース値がTrueの際にどのFontEmbeddingRight列挙体メンバーに変換するかを指定、または取得します。
        /// </summary>
        public FontEmbeddingRight ConvertWhenTrue
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
        private FontEmbeddingRight _convertWhenFalse;
		/// <summary>
        /// ソース値がFalseの際にどのFontEmbeddingRight列挙体メンバーに変換するかを指定、または取得します。
        /// </summary>
        public FontEmbeddingRight ConvertWhenFalse
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
            if (!(value is FontEmbeddingRight)) throw new ArgumentException();

            var enumValue = (FontEmbeddingRight)value;

			switch(enumValue.ToString())
			{
				case "Installable":
					if (_isConvertBackWhenInstallableSet)
					{
						return ConvertBackWhenInstallable;
					}
					break;
				case "InstallableButNoSubsetting":
					if (_isConvertBackWhenInstallableButNoSubsettingSet)
					{
						return ConvertBackWhenInstallableButNoSubsetting;
					}
					break;
				case "InstallableButWithBitmapsOnly":
					if (_isConvertBackWhenInstallableButWithBitmapsOnlySet)
					{
						return ConvertBackWhenInstallableButWithBitmapsOnly;
					}
					break;
				case "InstallableButNoSubsettingAndWithBitmapsOnly":
					if (_isConvertBackWhenInstallableButNoSubsettingAndWithBitmapsOnlySet)
					{
						return ConvertBackWhenInstallableButNoSubsettingAndWithBitmapsOnly;
					}
					break;
				case "RestrictedLicense":
					if (_isConvertBackWhenRestrictedLicenseSet)
					{
						return ConvertBackWhenRestrictedLicense;
					}
					break;
				case "PreviewAndPrint":
					if (_isConvertBackWhenPreviewAndPrintSet)
					{
						return ConvertBackWhenPreviewAndPrint;
					}
					break;
				case "PreviewAndPrintButNoSubsetting":
					if (_isConvertBackWhenPreviewAndPrintButNoSubsettingSet)
					{
						return ConvertBackWhenPreviewAndPrintButNoSubsetting;
					}
					break;
				case "PreviewAndPrintButWithBitmapsOnly":
					if (_isConvertBackWhenPreviewAndPrintButWithBitmapsOnlySet)
					{
						return ConvertBackWhenPreviewAndPrintButWithBitmapsOnly;
					}
					break;
				case "PreviewAndPrintButNoSubsettingAndWithBitmapsOnly":
					if (_isConvertBackWhenPreviewAndPrintButNoSubsettingAndWithBitmapsOnlySet)
					{
						return ConvertBackWhenPreviewAndPrintButNoSubsettingAndWithBitmapsOnly;
					}
					break;
				case "Editable":
					if (_isConvertBackWhenEditableSet)
					{
						return ConvertBackWhenEditable;
					}
					break;
				case "EditableButNoSubsetting":
					if (_isConvertBackWhenEditableButNoSubsettingSet)
					{
						return ConvertBackWhenEditableButNoSubsetting;
					}
					break;
				case "EditableButWithBitmapsOnly":
					if (_isConvertBackWhenEditableButWithBitmapsOnlySet)
					{
						return ConvertBackWhenEditableButWithBitmapsOnly;
					}
					break;
				case "EditableButNoSubsettingAndWithBitmapsOnly":
					if (_isConvertBackWhenEditableButNoSubsettingAndWithBitmapsOnlySet)
					{
						return ConvertBackWhenEditableButNoSubsettingAndWithBitmapsOnly;
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
        /// FontEmbeddingRightの値をbool値に変換する際のデフォルト値を指定、または取得します。
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

        private bool _isConvertBackWhenInstallableSet;
        private bool _convertBackWhenInstallable;
		/// <summary>
        /// FontEmbeddingRightの値がInstallableの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenInstallable
        {
            get
            {
                return _convertBackWhenInstallable;
            }
            set
            {
                _convertBackWhenInstallable = value;
                _isConvertBackWhenInstallableSet = true;
            }
        }
        private bool _isConvertBackWhenInstallableButNoSubsettingSet;
        private bool _convertBackWhenInstallableButNoSubsetting;
		/// <summary>
        /// FontEmbeddingRightの値がInstallableButNoSubsettingの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenInstallableButNoSubsetting
        {
            get
            {
                return _convertBackWhenInstallableButNoSubsetting;
            }
            set
            {
                _convertBackWhenInstallableButNoSubsetting = value;
                _isConvertBackWhenInstallableButNoSubsettingSet = true;
            }
        }
        private bool _isConvertBackWhenInstallableButWithBitmapsOnlySet;
        private bool _convertBackWhenInstallableButWithBitmapsOnly;
		/// <summary>
        /// FontEmbeddingRightの値がInstallableButWithBitmapsOnlyの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenInstallableButWithBitmapsOnly
        {
            get
            {
                return _convertBackWhenInstallableButWithBitmapsOnly;
            }
            set
            {
                _convertBackWhenInstallableButWithBitmapsOnly = value;
                _isConvertBackWhenInstallableButWithBitmapsOnlySet = true;
            }
        }
        private bool _isConvertBackWhenInstallableButNoSubsettingAndWithBitmapsOnlySet;
        private bool _convertBackWhenInstallableButNoSubsettingAndWithBitmapsOnly;
		/// <summary>
        /// FontEmbeddingRightの値がInstallableButNoSubsettingAndWithBitmapsOnlyの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenInstallableButNoSubsettingAndWithBitmapsOnly
        {
            get
            {
                return _convertBackWhenInstallableButNoSubsettingAndWithBitmapsOnly;
            }
            set
            {
                _convertBackWhenInstallableButNoSubsettingAndWithBitmapsOnly = value;
                _isConvertBackWhenInstallableButNoSubsettingAndWithBitmapsOnlySet = true;
            }
        }
        private bool _isConvertBackWhenRestrictedLicenseSet;
        private bool _convertBackWhenRestrictedLicense;
		/// <summary>
        /// FontEmbeddingRightの値がRestrictedLicenseの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenRestrictedLicense
        {
            get
            {
                return _convertBackWhenRestrictedLicense;
            }
            set
            {
                _convertBackWhenRestrictedLicense = value;
                _isConvertBackWhenRestrictedLicenseSet = true;
            }
        }
        private bool _isConvertBackWhenPreviewAndPrintSet;
        private bool _convertBackWhenPreviewAndPrint;
		/// <summary>
        /// FontEmbeddingRightの値がPreviewAndPrintの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenPreviewAndPrint
        {
            get
            {
                return _convertBackWhenPreviewAndPrint;
            }
            set
            {
                _convertBackWhenPreviewAndPrint = value;
                _isConvertBackWhenPreviewAndPrintSet = true;
            }
        }
        private bool _isConvertBackWhenPreviewAndPrintButNoSubsettingSet;
        private bool _convertBackWhenPreviewAndPrintButNoSubsetting;
		/// <summary>
        /// FontEmbeddingRightの値がPreviewAndPrintButNoSubsettingの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenPreviewAndPrintButNoSubsetting
        {
            get
            {
                return _convertBackWhenPreviewAndPrintButNoSubsetting;
            }
            set
            {
                _convertBackWhenPreviewAndPrintButNoSubsetting = value;
                _isConvertBackWhenPreviewAndPrintButNoSubsettingSet = true;
            }
        }
        private bool _isConvertBackWhenPreviewAndPrintButWithBitmapsOnlySet;
        private bool _convertBackWhenPreviewAndPrintButWithBitmapsOnly;
		/// <summary>
        /// FontEmbeddingRightの値がPreviewAndPrintButWithBitmapsOnlyの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenPreviewAndPrintButWithBitmapsOnly
        {
            get
            {
                return _convertBackWhenPreviewAndPrintButWithBitmapsOnly;
            }
            set
            {
                _convertBackWhenPreviewAndPrintButWithBitmapsOnly = value;
                _isConvertBackWhenPreviewAndPrintButWithBitmapsOnlySet = true;
            }
        }
        private bool _isConvertBackWhenPreviewAndPrintButNoSubsettingAndWithBitmapsOnlySet;
        private bool _convertBackWhenPreviewAndPrintButNoSubsettingAndWithBitmapsOnly;
		/// <summary>
        /// FontEmbeddingRightの値がPreviewAndPrintButNoSubsettingAndWithBitmapsOnlyの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenPreviewAndPrintButNoSubsettingAndWithBitmapsOnly
        {
            get
            {
                return _convertBackWhenPreviewAndPrintButNoSubsettingAndWithBitmapsOnly;
            }
            set
            {
                _convertBackWhenPreviewAndPrintButNoSubsettingAndWithBitmapsOnly = value;
                _isConvertBackWhenPreviewAndPrintButNoSubsettingAndWithBitmapsOnlySet = true;
            }
        }
        private bool _isConvertBackWhenEditableSet;
        private bool _convertBackWhenEditable;
		/// <summary>
        /// FontEmbeddingRightの値がEditableの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenEditable
        {
            get
            {
                return _convertBackWhenEditable;
            }
            set
            {
                _convertBackWhenEditable = value;
                _isConvertBackWhenEditableSet = true;
            }
        }
        private bool _isConvertBackWhenEditableButNoSubsettingSet;
        private bool _convertBackWhenEditableButNoSubsetting;
		/// <summary>
        /// FontEmbeddingRightの値がEditableButNoSubsettingの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenEditableButNoSubsetting
        {
            get
            {
                return _convertBackWhenEditableButNoSubsetting;
            }
            set
            {
                _convertBackWhenEditableButNoSubsetting = value;
                _isConvertBackWhenEditableButNoSubsettingSet = true;
            }
        }
        private bool _isConvertBackWhenEditableButWithBitmapsOnlySet;
        private bool _convertBackWhenEditableButWithBitmapsOnly;
		/// <summary>
        /// FontEmbeddingRightの値がEditableButWithBitmapsOnlyの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenEditableButWithBitmapsOnly
        {
            get
            {
                return _convertBackWhenEditableButWithBitmapsOnly;
            }
            set
            {
                _convertBackWhenEditableButWithBitmapsOnly = value;
                _isConvertBackWhenEditableButWithBitmapsOnlySet = true;
            }
        }
        private bool _isConvertBackWhenEditableButNoSubsettingAndWithBitmapsOnlySet;
        private bool _convertBackWhenEditableButNoSubsettingAndWithBitmapsOnly;
		/// <summary>
        /// FontEmbeddingRightの値がEditableButNoSubsettingAndWithBitmapsOnlyの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenEditableButNoSubsettingAndWithBitmapsOnly
        {
            get
            {
                return _convertBackWhenEditableButNoSubsettingAndWithBitmapsOnly;
            }
            set
            {
                _convertBackWhenEditableButNoSubsettingAndWithBitmapsOnly = value;
                _isConvertBackWhenEditableButNoSubsettingAndWithBitmapsOnlySet = true;
            }
        }
    }
}