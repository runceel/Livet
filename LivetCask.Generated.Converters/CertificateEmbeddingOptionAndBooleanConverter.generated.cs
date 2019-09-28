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
    /// CertificateEmbeddingOption列挙体とbool値の相互変換を行うIValueConverterです。
    /// </summary>
    public class CertificateEmbeddingOptionAndBooleanConverter : IValueConverter
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
        private CertificateEmbeddingOption _convertWhenTrue;
		/// <summary>
        /// ソース値がTrueの際にどのCertificateEmbeddingOption列挙体メンバーに変換するかを指定、または取得します。
        /// </summary>
        public CertificateEmbeddingOption ConvertWhenTrue
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
        private CertificateEmbeddingOption _convertWhenFalse;
		/// <summary>
        /// ソース値がFalseの際にどのCertificateEmbeddingOption列挙体メンバーに変換するかを指定、または取得します。
        /// </summary>
        public CertificateEmbeddingOption ConvertWhenFalse
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
            if (!(value is CertificateEmbeddingOption)) throw new ArgumentException();

            var enumValue = (CertificateEmbeddingOption)value;

			switch(enumValue.ToString())
			{
				case "InCertificatePart":
					if (_isConvertBackWhenInCertificatePartSet)
					{
						return ConvertBackWhenInCertificatePart;
					}
					break;
				case "InSignaturePart":
					if (_isConvertBackWhenInSignaturePartSet)
					{
						return ConvertBackWhenInSignaturePart;
					}
					break;
				case "NotEmbedded":
					if (_isConvertBackWhenNotEmbeddedSet)
					{
						return ConvertBackWhenNotEmbedded;
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
        /// CertificateEmbeddingOptionの値をbool値に変換する際のデフォルト値を指定、または取得します。
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

        private bool _isConvertBackWhenInCertificatePartSet;
        private bool _convertBackWhenInCertificatePart;
		/// <summary>
        /// CertificateEmbeddingOptionの値がInCertificatePartの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenInCertificatePart
        {
            get
            {
                return _convertBackWhenInCertificatePart;
            }
            set
            {
                _convertBackWhenInCertificatePart = value;
                _isConvertBackWhenInCertificatePartSet = true;
            }
        }
        private bool _isConvertBackWhenInSignaturePartSet;
        private bool _convertBackWhenInSignaturePart;
		/// <summary>
        /// CertificateEmbeddingOptionの値がInSignaturePartの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenInSignaturePart
        {
            get
            {
                return _convertBackWhenInSignaturePart;
            }
            set
            {
                _convertBackWhenInSignaturePart = value;
                _isConvertBackWhenInSignaturePartSet = true;
            }
        }
        private bool _isConvertBackWhenNotEmbeddedSet;
        private bool _convertBackWhenNotEmbedded;
		/// <summary>
        /// CertificateEmbeddingOptionの値がNotEmbeddedの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenNotEmbedded
        {
            get
            {
                return _convertBackWhenNotEmbedded;
            }
            set
            {
                _convertBackWhenNotEmbedded = value;
                _isConvertBackWhenNotEmbeddedSet = true;
            }
        }
    }
}