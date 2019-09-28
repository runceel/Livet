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
    /// ImeSentenceModeValues列挙体とbool値の相互変換を行うIValueConverterです。
    /// </summary>
    public class ImeSentenceModeValuesAndBooleanConverter : IValueConverter
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
        private ImeSentenceModeValues _convertWhenTrue;
		/// <summary>
        /// ソース値がTrueの際にどのImeSentenceModeValues列挙体メンバーに変換するかを指定、または取得します。
        /// </summary>
        public ImeSentenceModeValues ConvertWhenTrue
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
        private ImeSentenceModeValues _convertWhenFalse;
		/// <summary>
        /// ソース値がFalseの際にどのImeSentenceModeValues列挙体メンバーに変換するかを指定、または取得します。
        /// </summary>
        public ImeSentenceModeValues ConvertWhenFalse
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
            if (!(value is ImeSentenceModeValues)) throw new ArgumentException();

            var enumValue = (ImeSentenceModeValues)value;

			switch(enumValue.ToString())
			{
				case "None":
					if (_isConvertBackWhenNoneSet)
					{
						return ConvertBackWhenNone;
					}
					break;
				case "PluralClause":
					if (_isConvertBackWhenPluralClauseSet)
					{
						return ConvertBackWhenPluralClause;
					}
					break;
				case "SingleConversion":
					if (_isConvertBackWhenSingleConversionSet)
					{
						return ConvertBackWhenSingleConversion;
					}
					break;
				case "Automatic":
					if (_isConvertBackWhenAutomaticSet)
					{
						return ConvertBackWhenAutomatic;
					}
					break;
				case "PhrasePrediction":
					if (_isConvertBackWhenPhrasePredictionSet)
					{
						return ConvertBackWhenPhrasePrediction;
					}
					break;
				case "Conversation":
					if (_isConvertBackWhenConversationSet)
					{
						return ConvertBackWhenConversation;
					}
					break;
				case "DoNotCare":
					if (_isConvertBackWhenDoNotCareSet)
					{
						return ConvertBackWhenDoNotCare;
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
        /// ImeSentenceModeValuesの値をbool値に変換する際のデフォルト値を指定、または取得します。
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
        /// ImeSentenceModeValuesの値がNoneの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
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
        private bool _isConvertBackWhenPluralClauseSet;
        private bool _convertBackWhenPluralClause;
		/// <summary>
        /// ImeSentenceModeValuesの値がPluralClauseの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenPluralClause
        {
            get
            {
                return _convertBackWhenPluralClause;
            }
            set
            {
                _convertBackWhenPluralClause = value;
                _isConvertBackWhenPluralClauseSet = true;
            }
        }
        private bool _isConvertBackWhenSingleConversionSet;
        private bool _convertBackWhenSingleConversion;
		/// <summary>
        /// ImeSentenceModeValuesの値がSingleConversionの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenSingleConversion
        {
            get
            {
                return _convertBackWhenSingleConversion;
            }
            set
            {
                _convertBackWhenSingleConversion = value;
                _isConvertBackWhenSingleConversionSet = true;
            }
        }
        private bool _isConvertBackWhenAutomaticSet;
        private bool _convertBackWhenAutomatic;
		/// <summary>
        /// ImeSentenceModeValuesの値がAutomaticの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenAutomatic
        {
            get
            {
                return _convertBackWhenAutomatic;
            }
            set
            {
                _convertBackWhenAutomatic = value;
                _isConvertBackWhenAutomaticSet = true;
            }
        }
        private bool _isConvertBackWhenPhrasePredictionSet;
        private bool _convertBackWhenPhrasePrediction;
		/// <summary>
        /// ImeSentenceModeValuesの値がPhrasePredictionの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenPhrasePrediction
        {
            get
            {
                return _convertBackWhenPhrasePrediction;
            }
            set
            {
                _convertBackWhenPhrasePrediction = value;
                _isConvertBackWhenPhrasePredictionSet = true;
            }
        }
        private bool _isConvertBackWhenConversationSet;
        private bool _convertBackWhenConversation;
		/// <summary>
        /// ImeSentenceModeValuesの値がConversationの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenConversation
        {
            get
            {
                return _convertBackWhenConversation;
            }
            set
            {
                _convertBackWhenConversation = value;
                _isConvertBackWhenConversationSet = true;
            }
        }
        private bool _isConvertBackWhenDoNotCareSet;
        private bool _convertBackWhenDoNotCare;
		/// <summary>
        /// ImeSentenceModeValuesの値がDoNotCareの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenDoNotCare
        {
            get
            {
                return _convertBackWhenDoNotCare;
            }
            set
            {
                _convertBackWhenDoNotCare = value;
                _isConvertBackWhenDoNotCareSet = true;
            }
        }
    }
}