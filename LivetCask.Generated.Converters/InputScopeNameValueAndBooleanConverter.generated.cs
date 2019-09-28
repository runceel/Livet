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
    /// InputScopeNameValue列挙体とbool値の相互変換を行うIValueConverterです。
    /// </summary>
    public class InputScopeNameValueAndBooleanConverter : IValueConverter
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
        private InputScopeNameValue _convertWhenTrue;
		/// <summary>
        /// ソース値がTrueの際にどのInputScopeNameValue列挙体メンバーに変換するかを指定、または取得します。
        /// </summary>
        public InputScopeNameValue ConvertWhenTrue
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
        private InputScopeNameValue _convertWhenFalse;
		/// <summary>
        /// ソース値がFalseの際にどのInputScopeNameValue列挙体メンバーに変換するかを指定、または取得します。
        /// </summary>
        public InputScopeNameValue ConvertWhenFalse
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
            if (!(value is InputScopeNameValue)) throw new ArgumentException();

            var enumValue = (InputScopeNameValue)value;

			switch(enumValue.ToString())
			{
				case "Default":
					if (_isConvertBackWhenDefaultSet)
					{
						return ConvertBackWhenDefault;
					}
					break;
				case "Url":
					if (_isConvertBackWhenUrlSet)
					{
						return ConvertBackWhenUrl;
					}
					break;
				case "FullFilePath":
					if (_isConvertBackWhenFullFilePathSet)
					{
						return ConvertBackWhenFullFilePath;
					}
					break;
				case "FileName":
					if (_isConvertBackWhenFileNameSet)
					{
						return ConvertBackWhenFileName;
					}
					break;
				case "EmailUserName":
					if (_isConvertBackWhenEmailUserNameSet)
					{
						return ConvertBackWhenEmailUserName;
					}
					break;
				case "EmailSmtpAddress":
					if (_isConvertBackWhenEmailSmtpAddressSet)
					{
						return ConvertBackWhenEmailSmtpAddress;
					}
					break;
				case "LogOnName":
					if (_isConvertBackWhenLogOnNameSet)
					{
						return ConvertBackWhenLogOnName;
					}
					break;
				case "PersonalFullName":
					if (_isConvertBackWhenPersonalFullNameSet)
					{
						return ConvertBackWhenPersonalFullName;
					}
					break;
				case "PersonalNamePrefix":
					if (_isConvertBackWhenPersonalNamePrefixSet)
					{
						return ConvertBackWhenPersonalNamePrefix;
					}
					break;
				case "PersonalGivenName":
					if (_isConvertBackWhenPersonalGivenNameSet)
					{
						return ConvertBackWhenPersonalGivenName;
					}
					break;
				case "PersonalMiddleName":
					if (_isConvertBackWhenPersonalMiddleNameSet)
					{
						return ConvertBackWhenPersonalMiddleName;
					}
					break;
				case "PersonalSurname":
					if (_isConvertBackWhenPersonalSurnameSet)
					{
						return ConvertBackWhenPersonalSurname;
					}
					break;
				case "PersonalNameSuffix":
					if (_isConvertBackWhenPersonalNameSuffixSet)
					{
						return ConvertBackWhenPersonalNameSuffix;
					}
					break;
				case "PostalAddress":
					if (_isConvertBackWhenPostalAddressSet)
					{
						return ConvertBackWhenPostalAddress;
					}
					break;
				case "PostalCode":
					if (_isConvertBackWhenPostalCodeSet)
					{
						return ConvertBackWhenPostalCode;
					}
					break;
				case "AddressStreet":
					if (_isConvertBackWhenAddressStreetSet)
					{
						return ConvertBackWhenAddressStreet;
					}
					break;
				case "AddressStateOrProvince":
					if (_isConvertBackWhenAddressStateOrProvinceSet)
					{
						return ConvertBackWhenAddressStateOrProvince;
					}
					break;
				case "AddressCity":
					if (_isConvertBackWhenAddressCitySet)
					{
						return ConvertBackWhenAddressCity;
					}
					break;
				case "AddressCountryName":
					if (_isConvertBackWhenAddressCountryNameSet)
					{
						return ConvertBackWhenAddressCountryName;
					}
					break;
				case "AddressCountryShortName":
					if (_isConvertBackWhenAddressCountryShortNameSet)
					{
						return ConvertBackWhenAddressCountryShortName;
					}
					break;
				case "CurrencyAmountAndSymbol":
					if (_isConvertBackWhenCurrencyAmountAndSymbolSet)
					{
						return ConvertBackWhenCurrencyAmountAndSymbol;
					}
					break;
				case "CurrencyAmount":
					if (_isConvertBackWhenCurrencyAmountSet)
					{
						return ConvertBackWhenCurrencyAmount;
					}
					break;
				case "Date":
					if (_isConvertBackWhenDateSet)
					{
						return ConvertBackWhenDate;
					}
					break;
				case "DateMonth":
					if (_isConvertBackWhenDateMonthSet)
					{
						return ConvertBackWhenDateMonth;
					}
					break;
				case "DateDay":
					if (_isConvertBackWhenDateDaySet)
					{
						return ConvertBackWhenDateDay;
					}
					break;
				case "DateYear":
					if (_isConvertBackWhenDateYearSet)
					{
						return ConvertBackWhenDateYear;
					}
					break;
				case "DateMonthName":
					if (_isConvertBackWhenDateMonthNameSet)
					{
						return ConvertBackWhenDateMonthName;
					}
					break;
				case "DateDayName":
					if (_isConvertBackWhenDateDayNameSet)
					{
						return ConvertBackWhenDateDayName;
					}
					break;
				case "Digits":
					if (_isConvertBackWhenDigitsSet)
					{
						return ConvertBackWhenDigits;
					}
					break;
				case "Number":
					if (_isConvertBackWhenNumberSet)
					{
						return ConvertBackWhenNumber;
					}
					break;
				case "OneChar":
					if (_isConvertBackWhenOneCharSet)
					{
						return ConvertBackWhenOneChar;
					}
					break;
				case "Password":
					if (_isConvertBackWhenPasswordSet)
					{
						return ConvertBackWhenPassword;
					}
					break;
				case "TelephoneNumber":
					if (_isConvertBackWhenTelephoneNumberSet)
					{
						return ConvertBackWhenTelephoneNumber;
					}
					break;
				case "TelephoneCountryCode":
					if (_isConvertBackWhenTelephoneCountryCodeSet)
					{
						return ConvertBackWhenTelephoneCountryCode;
					}
					break;
				case "TelephoneAreaCode":
					if (_isConvertBackWhenTelephoneAreaCodeSet)
					{
						return ConvertBackWhenTelephoneAreaCode;
					}
					break;
				case "TelephoneLocalNumber":
					if (_isConvertBackWhenTelephoneLocalNumberSet)
					{
						return ConvertBackWhenTelephoneLocalNumber;
					}
					break;
				case "Time":
					if (_isConvertBackWhenTimeSet)
					{
						return ConvertBackWhenTime;
					}
					break;
				case "TimeHour":
					if (_isConvertBackWhenTimeHourSet)
					{
						return ConvertBackWhenTimeHour;
					}
					break;
				case "TimeMinorSec":
					if (_isConvertBackWhenTimeMinorSecSet)
					{
						return ConvertBackWhenTimeMinorSec;
					}
					break;
				case "NumberFullWidth":
					if (_isConvertBackWhenNumberFullWidthSet)
					{
						return ConvertBackWhenNumberFullWidth;
					}
					break;
				case "AlphanumericHalfWidth":
					if (_isConvertBackWhenAlphanumericHalfWidthSet)
					{
						return ConvertBackWhenAlphanumericHalfWidth;
					}
					break;
				case "AlphanumericFullWidth":
					if (_isConvertBackWhenAlphanumericFullWidthSet)
					{
						return ConvertBackWhenAlphanumericFullWidth;
					}
					break;
				case "CurrencyChinese":
					if (_isConvertBackWhenCurrencyChineseSet)
					{
						return ConvertBackWhenCurrencyChinese;
					}
					break;
				case "Bopomofo":
					if (_isConvertBackWhenBopomofoSet)
					{
						return ConvertBackWhenBopomofo;
					}
					break;
				case "Hiragana":
					if (_isConvertBackWhenHiraganaSet)
					{
						return ConvertBackWhenHiragana;
					}
					break;
				case "KatakanaHalfWidth":
					if (_isConvertBackWhenKatakanaHalfWidthSet)
					{
						return ConvertBackWhenKatakanaHalfWidth;
					}
					break;
				case "KatakanaFullWidth":
					if (_isConvertBackWhenKatakanaFullWidthSet)
					{
						return ConvertBackWhenKatakanaFullWidth;
					}
					break;
				case "Hanja":
					if (_isConvertBackWhenHanjaSet)
					{
						return ConvertBackWhenHanja;
					}
					break;
				case "Xml":
					if (_isConvertBackWhenXmlSet)
					{
						return ConvertBackWhenXml;
					}
					break;
				case "Srgs":
					if (_isConvertBackWhenSrgsSet)
					{
						return ConvertBackWhenSrgs;
					}
					break;
				case "RegularExpression":
					if (_isConvertBackWhenRegularExpressionSet)
					{
						return ConvertBackWhenRegularExpression;
					}
					break;
				case "PhraseList":
					if (_isConvertBackWhenPhraseListSet)
					{
						return ConvertBackWhenPhraseList;
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
        /// InputScopeNameValueの値をbool値に変換する際のデフォルト値を指定、または取得します。
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

        private bool _isConvertBackWhenDefaultSet;
        private bool _convertBackWhenDefault;
		/// <summary>
        /// InputScopeNameValueの値がDefaultの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenDefault
        {
            get
            {
                return _convertBackWhenDefault;
            }
            set
            {
                _convertBackWhenDefault = value;
                _isConvertBackWhenDefaultSet = true;
            }
        }
        private bool _isConvertBackWhenUrlSet;
        private bool _convertBackWhenUrl;
		/// <summary>
        /// InputScopeNameValueの値がUrlの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenUrl
        {
            get
            {
                return _convertBackWhenUrl;
            }
            set
            {
                _convertBackWhenUrl = value;
                _isConvertBackWhenUrlSet = true;
            }
        }
        private bool _isConvertBackWhenFullFilePathSet;
        private bool _convertBackWhenFullFilePath;
		/// <summary>
        /// InputScopeNameValueの値がFullFilePathの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenFullFilePath
        {
            get
            {
                return _convertBackWhenFullFilePath;
            }
            set
            {
                _convertBackWhenFullFilePath = value;
                _isConvertBackWhenFullFilePathSet = true;
            }
        }
        private bool _isConvertBackWhenFileNameSet;
        private bool _convertBackWhenFileName;
		/// <summary>
        /// InputScopeNameValueの値がFileNameの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenFileName
        {
            get
            {
                return _convertBackWhenFileName;
            }
            set
            {
                _convertBackWhenFileName = value;
                _isConvertBackWhenFileNameSet = true;
            }
        }
        private bool _isConvertBackWhenEmailUserNameSet;
        private bool _convertBackWhenEmailUserName;
		/// <summary>
        /// InputScopeNameValueの値がEmailUserNameの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenEmailUserName
        {
            get
            {
                return _convertBackWhenEmailUserName;
            }
            set
            {
                _convertBackWhenEmailUserName = value;
                _isConvertBackWhenEmailUserNameSet = true;
            }
        }
        private bool _isConvertBackWhenEmailSmtpAddressSet;
        private bool _convertBackWhenEmailSmtpAddress;
		/// <summary>
        /// InputScopeNameValueの値がEmailSmtpAddressの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenEmailSmtpAddress
        {
            get
            {
                return _convertBackWhenEmailSmtpAddress;
            }
            set
            {
                _convertBackWhenEmailSmtpAddress = value;
                _isConvertBackWhenEmailSmtpAddressSet = true;
            }
        }
        private bool _isConvertBackWhenLogOnNameSet;
        private bool _convertBackWhenLogOnName;
		/// <summary>
        /// InputScopeNameValueの値がLogOnNameの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenLogOnName
        {
            get
            {
                return _convertBackWhenLogOnName;
            }
            set
            {
                _convertBackWhenLogOnName = value;
                _isConvertBackWhenLogOnNameSet = true;
            }
        }
        private bool _isConvertBackWhenPersonalFullNameSet;
        private bool _convertBackWhenPersonalFullName;
		/// <summary>
        /// InputScopeNameValueの値がPersonalFullNameの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenPersonalFullName
        {
            get
            {
                return _convertBackWhenPersonalFullName;
            }
            set
            {
                _convertBackWhenPersonalFullName = value;
                _isConvertBackWhenPersonalFullNameSet = true;
            }
        }
        private bool _isConvertBackWhenPersonalNamePrefixSet;
        private bool _convertBackWhenPersonalNamePrefix;
		/// <summary>
        /// InputScopeNameValueの値がPersonalNamePrefixの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenPersonalNamePrefix
        {
            get
            {
                return _convertBackWhenPersonalNamePrefix;
            }
            set
            {
                _convertBackWhenPersonalNamePrefix = value;
                _isConvertBackWhenPersonalNamePrefixSet = true;
            }
        }
        private bool _isConvertBackWhenPersonalGivenNameSet;
        private bool _convertBackWhenPersonalGivenName;
		/// <summary>
        /// InputScopeNameValueの値がPersonalGivenNameの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenPersonalGivenName
        {
            get
            {
                return _convertBackWhenPersonalGivenName;
            }
            set
            {
                _convertBackWhenPersonalGivenName = value;
                _isConvertBackWhenPersonalGivenNameSet = true;
            }
        }
        private bool _isConvertBackWhenPersonalMiddleNameSet;
        private bool _convertBackWhenPersonalMiddleName;
		/// <summary>
        /// InputScopeNameValueの値がPersonalMiddleNameの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenPersonalMiddleName
        {
            get
            {
                return _convertBackWhenPersonalMiddleName;
            }
            set
            {
                _convertBackWhenPersonalMiddleName = value;
                _isConvertBackWhenPersonalMiddleNameSet = true;
            }
        }
        private bool _isConvertBackWhenPersonalSurnameSet;
        private bool _convertBackWhenPersonalSurname;
		/// <summary>
        /// InputScopeNameValueの値がPersonalSurnameの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenPersonalSurname
        {
            get
            {
                return _convertBackWhenPersonalSurname;
            }
            set
            {
                _convertBackWhenPersonalSurname = value;
                _isConvertBackWhenPersonalSurnameSet = true;
            }
        }
        private bool _isConvertBackWhenPersonalNameSuffixSet;
        private bool _convertBackWhenPersonalNameSuffix;
		/// <summary>
        /// InputScopeNameValueの値がPersonalNameSuffixの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenPersonalNameSuffix
        {
            get
            {
                return _convertBackWhenPersonalNameSuffix;
            }
            set
            {
                _convertBackWhenPersonalNameSuffix = value;
                _isConvertBackWhenPersonalNameSuffixSet = true;
            }
        }
        private bool _isConvertBackWhenPostalAddressSet;
        private bool _convertBackWhenPostalAddress;
		/// <summary>
        /// InputScopeNameValueの値がPostalAddressの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenPostalAddress
        {
            get
            {
                return _convertBackWhenPostalAddress;
            }
            set
            {
                _convertBackWhenPostalAddress = value;
                _isConvertBackWhenPostalAddressSet = true;
            }
        }
        private bool _isConvertBackWhenPostalCodeSet;
        private bool _convertBackWhenPostalCode;
		/// <summary>
        /// InputScopeNameValueの値がPostalCodeの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenPostalCode
        {
            get
            {
                return _convertBackWhenPostalCode;
            }
            set
            {
                _convertBackWhenPostalCode = value;
                _isConvertBackWhenPostalCodeSet = true;
            }
        }
        private bool _isConvertBackWhenAddressStreetSet;
        private bool _convertBackWhenAddressStreet;
		/// <summary>
        /// InputScopeNameValueの値がAddressStreetの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenAddressStreet
        {
            get
            {
                return _convertBackWhenAddressStreet;
            }
            set
            {
                _convertBackWhenAddressStreet = value;
                _isConvertBackWhenAddressStreetSet = true;
            }
        }
        private bool _isConvertBackWhenAddressStateOrProvinceSet;
        private bool _convertBackWhenAddressStateOrProvince;
		/// <summary>
        /// InputScopeNameValueの値がAddressStateOrProvinceの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenAddressStateOrProvince
        {
            get
            {
                return _convertBackWhenAddressStateOrProvince;
            }
            set
            {
                _convertBackWhenAddressStateOrProvince = value;
                _isConvertBackWhenAddressStateOrProvinceSet = true;
            }
        }
        private bool _isConvertBackWhenAddressCitySet;
        private bool _convertBackWhenAddressCity;
		/// <summary>
        /// InputScopeNameValueの値がAddressCityの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenAddressCity
        {
            get
            {
                return _convertBackWhenAddressCity;
            }
            set
            {
                _convertBackWhenAddressCity = value;
                _isConvertBackWhenAddressCitySet = true;
            }
        }
        private bool _isConvertBackWhenAddressCountryNameSet;
        private bool _convertBackWhenAddressCountryName;
		/// <summary>
        /// InputScopeNameValueの値がAddressCountryNameの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenAddressCountryName
        {
            get
            {
                return _convertBackWhenAddressCountryName;
            }
            set
            {
                _convertBackWhenAddressCountryName = value;
                _isConvertBackWhenAddressCountryNameSet = true;
            }
        }
        private bool _isConvertBackWhenAddressCountryShortNameSet;
        private bool _convertBackWhenAddressCountryShortName;
		/// <summary>
        /// InputScopeNameValueの値がAddressCountryShortNameの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenAddressCountryShortName
        {
            get
            {
                return _convertBackWhenAddressCountryShortName;
            }
            set
            {
                _convertBackWhenAddressCountryShortName = value;
                _isConvertBackWhenAddressCountryShortNameSet = true;
            }
        }
        private bool _isConvertBackWhenCurrencyAmountAndSymbolSet;
        private bool _convertBackWhenCurrencyAmountAndSymbol;
		/// <summary>
        /// InputScopeNameValueの値がCurrencyAmountAndSymbolの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenCurrencyAmountAndSymbol
        {
            get
            {
                return _convertBackWhenCurrencyAmountAndSymbol;
            }
            set
            {
                _convertBackWhenCurrencyAmountAndSymbol = value;
                _isConvertBackWhenCurrencyAmountAndSymbolSet = true;
            }
        }
        private bool _isConvertBackWhenCurrencyAmountSet;
        private bool _convertBackWhenCurrencyAmount;
		/// <summary>
        /// InputScopeNameValueの値がCurrencyAmountの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenCurrencyAmount
        {
            get
            {
                return _convertBackWhenCurrencyAmount;
            }
            set
            {
                _convertBackWhenCurrencyAmount = value;
                _isConvertBackWhenCurrencyAmountSet = true;
            }
        }
        private bool _isConvertBackWhenDateSet;
        private bool _convertBackWhenDate;
		/// <summary>
        /// InputScopeNameValueの値がDateの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenDate
        {
            get
            {
                return _convertBackWhenDate;
            }
            set
            {
                _convertBackWhenDate = value;
                _isConvertBackWhenDateSet = true;
            }
        }
        private bool _isConvertBackWhenDateMonthSet;
        private bool _convertBackWhenDateMonth;
		/// <summary>
        /// InputScopeNameValueの値がDateMonthの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenDateMonth
        {
            get
            {
                return _convertBackWhenDateMonth;
            }
            set
            {
                _convertBackWhenDateMonth = value;
                _isConvertBackWhenDateMonthSet = true;
            }
        }
        private bool _isConvertBackWhenDateDaySet;
        private bool _convertBackWhenDateDay;
		/// <summary>
        /// InputScopeNameValueの値がDateDayの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenDateDay
        {
            get
            {
                return _convertBackWhenDateDay;
            }
            set
            {
                _convertBackWhenDateDay = value;
                _isConvertBackWhenDateDaySet = true;
            }
        }
        private bool _isConvertBackWhenDateYearSet;
        private bool _convertBackWhenDateYear;
		/// <summary>
        /// InputScopeNameValueの値がDateYearの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenDateYear
        {
            get
            {
                return _convertBackWhenDateYear;
            }
            set
            {
                _convertBackWhenDateYear = value;
                _isConvertBackWhenDateYearSet = true;
            }
        }
        private bool _isConvertBackWhenDateMonthNameSet;
        private bool _convertBackWhenDateMonthName;
		/// <summary>
        /// InputScopeNameValueの値がDateMonthNameの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenDateMonthName
        {
            get
            {
                return _convertBackWhenDateMonthName;
            }
            set
            {
                _convertBackWhenDateMonthName = value;
                _isConvertBackWhenDateMonthNameSet = true;
            }
        }
        private bool _isConvertBackWhenDateDayNameSet;
        private bool _convertBackWhenDateDayName;
		/// <summary>
        /// InputScopeNameValueの値がDateDayNameの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenDateDayName
        {
            get
            {
                return _convertBackWhenDateDayName;
            }
            set
            {
                _convertBackWhenDateDayName = value;
                _isConvertBackWhenDateDayNameSet = true;
            }
        }
        private bool _isConvertBackWhenDigitsSet;
        private bool _convertBackWhenDigits;
		/// <summary>
        /// InputScopeNameValueの値がDigitsの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenDigits
        {
            get
            {
                return _convertBackWhenDigits;
            }
            set
            {
                _convertBackWhenDigits = value;
                _isConvertBackWhenDigitsSet = true;
            }
        }
        private bool _isConvertBackWhenNumberSet;
        private bool _convertBackWhenNumber;
		/// <summary>
        /// InputScopeNameValueの値がNumberの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenNumber
        {
            get
            {
                return _convertBackWhenNumber;
            }
            set
            {
                _convertBackWhenNumber = value;
                _isConvertBackWhenNumberSet = true;
            }
        }
        private bool _isConvertBackWhenOneCharSet;
        private bool _convertBackWhenOneChar;
		/// <summary>
        /// InputScopeNameValueの値がOneCharの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenOneChar
        {
            get
            {
                return _convertBackWhenOneChar;
            }
            set
            {
                _convertBackWhenOneChar = value;
                _isConvertBackWhenOneCharSet = true;
            }
        }
        private bool _isConvertBackWhenPasswordSet;
        private bool _convertBackWhenPassword;
		/// <summary>
        /// InputScopeNameValueの値がPasswordの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenPassword
        {
            get
            {
                return _convertBackWhenPassword;
            }
            set
            {
                _convertBackWhenPassword = value;
                _isConvertBackWhenPasswordSet = true;
            }
        }
        private bool _isConvertBackWhenTelephoneNumberSet;
        private bool _convertBackWhenTelephoneNumber;
		/// <summary>
        /// InputScopeNameValueの値がTelephoneNumberの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenTelephoneNumber
        {
            get
            {
                return _convertBackWhenTelephoneNumber;
            }
            set
            {
                _convertBackWhenTelephoneNumber = value;
                _isConvertBackWhenTelephoneNumberSet = true;
            }
        }
        private bool _isConvertBackWhenTelephoneCountryCodeSet;
        private bool _convertBackWhenTelephoneCountryCode;
		/// <summary>
        /// InputScopeNameValueの値がTelephoneCountryCodeの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenTelephoneCountryCode
        {
            get
            {
                return _convertBackWhenTelephoneCountryCode;
            }
            set
            {
                _convertBackWhenTelephoneCountryCode = value;
                _isConvertBackWhenTelephoneCountryCodeSet = true;
            }
        }
        private bool _isConvertBackWhenTelephoneAreaCodeSet;
        private bool _convertBackWhenTelephoneAreaCode;
		/// <summary>
        /// InputScopeNameValueの値がTelephoneAreaCodeの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenTelephoneAreaCode
        {
            get
            {
                return _convertBackWhenTelephoneAreaCode;
            }
            set
            {
                _convertBackWhenTelephoneAreaCode = value;
                _isConvertBackWhenTelephoneAreaCodeSet = true;
            }
        }
        private bool _isConvertBackWhenTelephoneLocalNumberSet;
        private bool _convertBackWhenTelephoneLocalNumber;
		/// <summary>
        /// InputScopeNameValueの値がTelephoneLocalNumberの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenTelephoneLocalNumber
        {
            get
            {
                return _convertBackWhenTelephoneLocalNumber;
            }
            set
            {
                _convertBackWhenTelephoneLocalNumber = value;
                _isConvertBackWhenTelephoneLocalNumberSet = true;
            }
        }
        private bool _isConvertBackWhenTimeSet;
        private bool _convertBackWhenTime;
		/// <summary>
        /// InputScopeNameValueの値がTimeの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenTime
        {
            get
            {
                return _convertBackWhenTime;
            }
            set
            {
                _convertBackWhenTime = value;
                _isConvertBackWhenTimeSet = true;
            }
        }
        private bool _isConvertBackWhenTimeHourSet;
        private bool _convertBackWhenTimeHour;
		/// <summary>
        /// InputScopeNameValueの値がTimeHourの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenTimeHour
        {
            get
            {
                return _convertBackWhenTimeHour;
            }
            set
            {
                _convertBackWhenTimeHour = value;
                _isConvertBackWhenTimeHourSet = true;
            }
        }
        private bool _isConvertBackWhenTimeMinorSecSet;
        private bool _convertBackWhenTimeMinorSec;
		/// <summary>
        /// InputScopeNameValueの値がTimeMinorSecの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenTimeMinorSec
        {
            get
            {
                return _convertBackWhenTimeMinorSec;
            }
            set
            {
                _convertBackWhenTimeMinorSec = value;
                _isConvertBackWhenTimeMinorSecSet = true;
            }
        }
        private bool _isConvertBackWhenNumberFullWidthSet;
        private bool _convertBackWhenNumberFullWidth;
		/// <summary>
        /// InputScopeNameValueの値がNumberFullWidthの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenNumberFullWidth
        {
            get
            {
                return _convertBackWhenNumberFullWidth;
            }
            set
            {
                _convertBackWhenNumberFullWidth = value;
                _isConvertBackWhenNumberFullWidthSet = true;
            }
        }
        private bool _isConvertBackWhenAlphanumericHalfWidthSet;
        private bool _convertBackWhenAlphanumericHalfWidth;
		/// <summary>
        /// InputScopeNameValueの値がAlphanumericHalfWidthの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenAlphanumericHalfWidth
        {
            get
            {
                return _convertBackWhenAlphanumericHalfWidth;
            }
            set
            {
                _convertBackWhenAlphanumericHalfWidth = value;
                _isConvertBackWhenAlphanumericHalfWidthSet = true;
            }
        }
        private bool _isConvertBackWhenAlphanumericFullWidthSet;
        private bool _convertBackWhenAlphanumericFullWidth;
		/// <summary>
        /// InputScopeNameValueの値がAlphanumericFullWidthの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenAlphanumericFullWidth
        {
            get
            {
                return _convertBackWhenAlphanumericFullWidth;
            }
            set
            {
                _convertBackWhenAlphanumericFullWidth = value;
                _isConvertBackWhenAlphanumericFullWidthSet = true;
            }
        }
        private bool _isConvertBackWhenCurrencyChineseSet;
        private bool _convertBackWhenCurrencyChinese;
		/// <summary>
        /// InputScopeNameValueの値がCurrencyChineseの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenCurrencyChinese
        {
            get
            {
                return _convertBackWhenCurrencyChinese;
            }
            set
            {
                _convertBackWhenCurrencyChinese = value;
                _isConvertBackWhenCurrencyChineseSet = true;
            }
        }
        private bool _isConvertBackWhenBopomofoSet;
        private bool _convertBackWhenBopomofo;
		/// <summary>
        /// InputScopeNameValueの値がBopomofoの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenBopomofo
        {
            get
            {
                return _convertBackWhenBopomofo;
            }
            set
            {
                _convertBackWhenBopomofo = value;
                _isConvertBackWhenBopomofoSet = true;
            }
        }
        private bool _isConvertBackWhenHiraganaSet;
        private bool _convertBackWhenHiragana;
		/// <summary>
        /// InputScopeNameValueの値がHiraganaの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenHiragana
        {
            get
            {
                return _convertBackWhenHiragana;
            }
            set
            {
                _convertBackWhenHiragana = value;
                _isConvertBackWhenHiraganaSet = true;
            }
        }
        private bool _isConvertBackWhenKatakanaHalfWidthSet;
        private bool _convertBackWhenKatakanaHalfWidth;
		/// <summary>
        /// InputScopeNameValueの値がKatakanaHalfWidthの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenKatakanaHalfWidth
        {
            get
            {
                return _convertBackWhenKatakanaHalfWidth;
            }
            set
            {
                _convertBackWhenKatakanaHalfWidth = value;
                _isConvertBackWhenKatakanaHalfWidthSet = true;
            }
        }
        private bool _isConvertBackWhenKatakanaFullWidthSet;
        private bool _convertBackWhenKatakanaFullWidth;
		/// <summary>
        /// InputScopeNameValueの値がKatakanaFullWidthの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenKatakanaFullWidth
        {
            get
            {
                return _convertBackWhenKatakanaFullWidth;
            }
            set
            {
                _convertBackWhenKatakanaFullWidth = value;
                _isConvertBackWhenKatakanaFullWidthSet = true;
            }
        }
        private bool _isConvertBackWhenHanjaSet;
        private bool _convertBackWhenHanja;
		/// <summary>
        /// InputScopeNameValueの値がHanjaの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenHanja
        {
            get
            {
                return _convertBackWhenHanja;
            }
            set
            {
                _convertBackWhenHanja = value;
                _isConvertBackWhenHanjaSet = true;
            }
        }
        private bool _isConvertBackWhenXmlSet;
        private bool _convertBackWhenXml;
		/// <summary>
        /// InputScopeNameValueの値がXmlの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenXml
        {
            get
            {
                return _convertBackWhenXml;
            }
            set
            {
                _convertBackWhenXml = value;
                _isConvertBackWhenXmlSet = true;
            }
        }
        private bool _isConvertBackWhenSrgsSet;
        private bool _convertBackWhenSrgs;
		/// <summary>
        /// InputScopeNameValueの値がSrgsの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenSrgs
        {
            get
            {
                return _convertBackWhenSrgs;
            }
            set
            {
                _convertBackWhenSrgs = value;
                _isConvertBackWhenSrgsSet = true;
            }
        }
        private bool _isConvertBackWhenRegularExpressionSet;
        private bool _convertBackWhenRegularExpression;
		/// <summary>
        /// InputScopeNameValueの値がRegularExpressionの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenRegularExpression
        {
            get
            {
                return _convertBackWhenRegularExpression;
            }
            set
            {
                _convertBackWhenRegularExpression = value;
                _isConvertBackWhenRegularExpressionSet = true;
            }
        }
        private bool _isConvertBackWhenPhraseListSet;
        private bool _convertBackWhenPhraseList;
		/// <summary>
        /// InputScopeNameValueの値がPhraseListの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenPhraseList
        {
            get
            {
                return _convertBackWhenPhraseList;
            }
            set
            {
                _convertBackWhenPhraseList = value;
                _isConvertBackWhenPhraseListSet = true;
            }
        }
    }
}