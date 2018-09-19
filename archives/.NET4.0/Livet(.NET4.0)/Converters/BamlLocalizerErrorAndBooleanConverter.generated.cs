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
    /// BamlLocalizerError列挙体とbool値の相互変換を行うIValueConverterです。
    /// </summary>
    public class BamlLocalizerErrorAndBooleanConverter : IValueConverter
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
        private BamlLocalizerError _convertWhenTrue;
		/// <summary>
        /// ソース値がTrueの際にどのBamlLocalizerError列挙体メンバーに変換するかを指定、または取得します。
        /// </summary>
        public BamlLocalizerError ConvertWhenTrue
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
        private BamlLocalizerError _convertWhenFalse;
		/// <summary>
        /// ソース値がFalseの際にどのBamlLocalizerError列挙体メンバーに変換するかを指定、または取得します。
        /// </summary>
        public BamlLocalizerError ConvertWhenFalse
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
            if (!(value is BamlLocalizerError)) throw new ArgumentException();

            var enumValue = (BamlLocalizerError)value;

			switch(enumValue.ToString())
			{
				case "DuplicateUid":
					if (_isConvertBackWhenDuplicateUidSet)
					{
						return ConvertBackWhenDuplicateUid;
					}
					break;
				case "DuplicateElement":
					if (_isConvertBackWhenDuplicateElementSet)
					{
						return ConvertBackWhenDuplicateElement;
					}
					break;
				case "IncompleteElementPlaceholder":
					if (_isConvertBackWhenIncompleteElementPlaceholderSet)
					{
						return ConvertBackWhenIncompleteElementPlaceholder;
					}
					break;
				case "InvalidCommentingXml":
					if (_isConvertBackWhenInvalidCommentingXmlSet)
					{
						return ConvertBackWhenInvalidCommentingXml;
					}
					break;
				case "InvalidLocalizationAttributes":
					if (_isConvertBackWhenInvalidLocalizationAttributesSet)
					{
						return ConvertBackWhenInvalidLocalizationAttributes;
					}
					break;
				case "InvalidLocalizationComments":
					if (_isConvertBackWhenInvalidLocalizationCommentsSet)
					{
						return ConvertBackWhenInvalidLocalizationComments;
					}
					break;
				case "InvalidUid":
					if (_isConvertBackWhenInvalidUidSet)
					{
						return ConvertBackWhenInvalidUid;
					}
					break;
				case "MismatchedElements":
					if (_isConvertBackWhenMismatchedElementsSet)
					{
						return ConvertBackWhenMismatchedElements;
					}
					break;
				case "SubstitutionAsPlaintext":
					if (_isConvertBackWhenSubstitutionAsPlaintextSet)
					{
						return ConvertBackWhenSubstitutionAsPlaintext;
					}
					break;
				case "UidMissingOnChildElement":
					if (_isConvertBackWhenUidMissingOnChildElementSet)
					{
						return ConvertBackWhenUidMissingOnChildElement;
					}
					break;
				case "UnknownFormattingTag":
					if (_isConvertBackWhenUnknownFormattingTagSet)
					{
						return ConvertBackWhenUnknownFormattingTag;
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
        /// BamlLocalizerErrorの値をbool値に変換する際のデフォルト値を指定、または取得します。
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

        private bool _isConvertBackWhenDuplicateUidSet;
        private bool _convertBackWhenDuplicateUid;
		/// <summary>
        /// BamlLocalizerErrorの値がDuplicateUidの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenDuplicateUid
        {
            get
            {
                return _convertBackWhenDuplicateUid;
            }
            set
            {
                _convertBackWhenDuplicateUid = value;
                _isConvertBackWhenDuplicateUidSet = true;
            }
        }
        private bool _isConvertBackWhenDuplicateElementSet;
        private bool _convertBackWhenDuplicateElement;
		/// <summary>
        /// BamlLocalizerErrorの値がDuplicateElementの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenDuplicateElement
        {
            get
            {
                return _convertBackWhenDuplicateElement;
            }
            set
            {
                _convertBackWhenDuplicateElement = value;
                _isConvertBackWhenDuplicateElementSet = true;
            }
        }
        private bool _isConvertBackWhenIncompleteElementPlaceholderSet;
        private bool _convertBackWhenIncompleteElementPlaceholder;
		/// <summary>
        /// BamlLocalizerErrorの値がIncompleteElementPlaceholderの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenIncompleteElementPlaceholder
        {
            get
            {
                return _convertBackWhenIncompleteElementPlaceholder;
            }
            set
            {
                _convertBackWhenIncompleteElementPlaceholder = value;
                _isConvertBackWhenIncompleteElementPlaceholderSet = true;
            }
        }
        private bool _isConvertBackWhenInvalidCommentingXmlSet;
        private bool _convertBackWhenInvalidCommentingXml;
		/// <summary>
        /// BamlLocalizerErrorの値がInvalidCommentingXmlの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenInvalidCommentingXml
        {
            get
            {
                return _convertBackWhenInvalidCommentingXml;
            }
            set
            {
                _convertBackWhenInvalidCommentingXml = value;
                _isConvertBackWhenInvalidCommentingXmlSet = true;
            }
        }
        private bool _isConvertBackWhenInvalidLocalizationAttributesSet;
        private bool _convertBackWhenInvalidLocalizationAttributes;
		/// <summary>
        /// BamlLocalizerErrorの値がInvalidLocalizationAttributesの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenInvalidLocalizationAttributes
        {
            get
            {
                return _convertBackWhenInvalidLocalizationAttributes;
            }
            set
            {
                _convertBackWhenInvalidLocalizationAttributes = value;
                _isConvertBackWhenInvalidLocalizationAttributesSet = true;
            }
        }
        private bool _isConvertBackWhenInvalidLocalizationCommentsSet;
        private bool _convertBackWhenInvalidLocalizationComments;
		/// <summary>
        /// BamlLocalizerErrorの値がInvalidLocalizationCommentsの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenInvalidLocalizationComments
        {
            get
            {
                return _convertBackWhenInvalidLocalizationComments;
            }
            set
            {
                _convertBackWhenInvalidLocalizationComments = value;
                _isConvertBackWhenInvalidLocalizationCommentsSet = true;
            }
        }
        private bool _isConvertBackWhenInvalidUidSet;
        private bool _convertBackWhenInvalidUid;
		/// <summary>
        /// BamlLocalizerErrorの値がInvalidUidの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenInvalidUid
        {
            get
            {
                return _convertBackWhenInvalidUid;
            }
            set
            {
                _convertBackWhenInvalidUid = value;
                _isConvertBackWhenInvalidUidSet = true;
            }
        }
        private bool _isConvertBackWhenMismatchedElementsSet;
        private bool _convertBackWhenMismatchedElements;
		/// <summary>
        /// BamlLocalizerErrorの値がMismatchedElementsの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenMismatchedElements
        {
            get
            {
                return _convertBackWhenMismatchedElements;
            }
            set
            {
                _convertBackWhenMismatchedElements = value;
                _isConvertBackWhenMismatchedElementsSet = true;
            }
        }
        private bool _isConvertBackWhenSubstitutionAsPlaintextSet;
        private bool _convertBackWhenSubstitutionAsPlaintext;
		/// <summary>
        /// BamlLocalizerErrorの値がSubstitutionAsPlaintextの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenSubstitutionAsPlaintext
        {
            get
            {
                return _convertBackWhenSubstitutionAsPlaintext;
            }
            set
            {
                _convertBackWhenSubstitutionAsPlaintext = value;
                _isConvertBackWhenSubstitutionAsPlaintextSet = true;
            }
        }
        private bool _isConvertBackWhenUidMissingOnChildElementSet;
        private bool _convertBackWhenUidMissingOnChildElement;
		/// <summary>
        /// BamlLocalizerErrorの値がUidMissingOnChildElementの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenUidMissingOnChildElement
        {
            get
            {
                return _convertBackWhenUidMissingOnChildElement;
            }
            set
            {
                _convertBackWhenUidMissingOnChildElement = value;
                _isConvertBackWhenUidMissingOnChildElementSet = true;
            }
        }
        private bool _isConvertBackWhenUnknownFormattingTagSet;
        private bool _convertBackWhenUnknownFormattingTag;
		/// <summary>
        /// BamlLocalizerErrorの値がUnknownFormattingTagの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenUnknownFormattingTag
        {
            get
            {
                return _convertBackWhenUnknownFormattingTag;
            }
            set
            {
                _convertBackWhenUnknownFormattingTag = value;
                _isConvertBackWhenUnknownFormattingTagSet = true;
            }
        }
    }
}