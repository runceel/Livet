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
    /// VerifyResult列挙体とbool値の相互変換を行うIValueConverterです。
    /// </summary>
    public class VerifyResultAndBooleanConverter : IValueConverter
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
        private VerifyResult _convertWhenTrue;
		/// <summary>
        /// ソース値がTrueの際にどのVerifyResult列挙体メンバーに変換するかを指定、または取得します。
        /// </summary>
        public VerifyResult ConvertWhenTrue
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
        private VerifyResult _convertWhenFalse;
		/// <summary>
        /// ソース値がFalseの際にどのVerifyResult列挙体メンバーに変換するかを指定、または取得します。
        /// </summary>
        public VerifyResult ConvertWhenFalse
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
            if (!(value is VerifyResult)) throw new ArgumentException();

            var enumValue = (VerifyResult)value;

			switch(enumValue.ToString())
			{
				case "Success":
					if (_isConvertBackWhenSuccessSet)
					{
						return ConvertBackWhenSuccess;
					}
					break;
				case "InvalidSignature":
					if (_isConvertBackWhenInvalidSignatureSet)
					{
						return ConvertBackWhenInvalidSignature;
					}
					break;
				case "CertificateRequired":
					if (_isConvertBackWhenCertificateRequiredSet)
					{
						return ConvertBackWhenCertificateRequired;
					}
					break;
				case "InvalidCertificate":
					if (_isConvertBackWhenInvalidCertificateSet)
					{
						return ConvertBackWhenInvalidCertificate;
					}
					break;
				case "ReferenceNotFound":
					if (_isConvertBackWhenReferenceNotFoundSet)
					{
						return ConvertBackWhenReferenceNotFound;
					}
					break;
				case "NotSigned":
					if (_isConvertBackWhenNotSignedSet)
					{
						return ConvertBackWhenNotSigned;
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
        /// VerifyResultの値をbool値に変換する際のデフォルト値を指定、または取得します。
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

        private bool _isConvertBackWhenSuccessSet;
        private bool _convertBackWhenSuccess;
		/// <summary>
        /// VerifyResultの値がSuccessの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenSuccess
        {
            get
            {
                return _convertBackWhenSuccess;
            }
            set
            {
                _convertBackWhenSuccess = value;
                _isConvertBackWhenSuccessSet = true;
            }
        }
        private bool _isConvertBackWhenInvalidSignatureSet;
        private bool _convertBackWhenInvalidSignature;
		/// <summary>
        /// VerifyResultの値がInvalidSignatureの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenInvalidSignature
        {
            get
            {
                return _convertBackWhenInvalidSignature;
            }
            set
            {
                _convertBackWhenInvalidSignature = value;
                _isConvertBackWhenInvalidSignatureSet = true;
            }
        }
        private bool _isConvertBackWhenCertificateRequiredSet;
        private bool _convertBackWhenCertificateRequired;
		/// <summary>
        /// VerifyResultの値がCertificateRequiredの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenCertificateRequired
        {
            get
            {
                return _convertBackWhenCertificateRequired;
            }
            set
            {
                _convertBackWhenCertificateRequired = value;
                _isConvertBackWhenCertificateRequiredSet = true;
            }
        }
        private bool _isConvertBackWhenInvalidCertificateSet;
        private bool _convertBackWhenInvalidCertificate;
		/// <summary>
        /// VerifyResultの値がInvalidCertificateの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenInvalidCertificate
        {
            get
            {
                return _convertBackWhenInvalidCertificate;
            }
            set
            {
                _convertBackWhenInvalidCertificate = value;
                _isConvertBackWhenInvalidCertificateSet = true;
            }
        }
        private bool _isConvertBackWhenReferenceNotFoundSet;
        private bool _convertBackWhenReferenceNotFound;
		/// <summary>
        /// VerifyResultの値がReferenceNotFoundの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenReferenceNotFound
        {
            get
            {
                return _convertBackWhenReferenceNotFound;
            }
            set
            {
                _convertBackWhenReferenceNotFound = value;
                _isConvertBackWhenReferenceNotFoundSet = true;
            }
        }
        private bool _isConvertBackWhenNotSignedSet;
        private bool _convertBackWhenNotSigned;
		/// <summary>
        /// VerifyResultの値がNotSignedの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenNotSigned
        {
            get
            {
                return _convertBackWhenNotSigned;
            }
            set
            {
                _convertBackWhenNotSigned = value;
                _isConvertBackWhenNotSignedSet = true;
            }
        }
    }
}