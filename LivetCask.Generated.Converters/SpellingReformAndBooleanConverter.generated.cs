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
    /// SpellingReform列挙体とbool値の相互変換を行うIValueConverterです。
    /// </summary>
    public class SpellingReformAndBooleanConverter : IValueConverter
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
        private SpellingReform _convertWhenTrue;
		/// <summary>
        /// ソース値がTrueの際にどのSpellingReform列挙体メンバーに変換するかを指定、または取得します。
        /// </summary>
        public SpellingReform ConvertWhenTrue
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
        private SpellingReform _convertWhenFalse;
		/// <summary>
        /// ソース値がFalseの際にどのSpellingReform列挙体メンバーに変換するかを指定、または取得します。
        /// </summary>
        public SpellingReform ConvertWhenFalse
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
            if (!(value is SpellingReform)) throw new ArgumentException();

            var enumValue = (SpellingReform)value;

			switch(enumValue.ToString())
			{
				case "PreAndPostreform":
					if (_isConvertBackWhenPreAndPostreformSet)
					{
						return ConvertBackWhenPreAndPostreform;
					}
					break;
				case "Prereform":
					if (_isConvertBackWhenPrereformSet)
					{
						return ConvertBackWhenPrereform;
					}
					break;
				case "Postreform":
					if (_isConvertBackWhenPostreformSet)
					{
						return ConvertBackWhenPostreform;
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
        /// SpellingReformの値をbool値に変換する際のデフォルト値を指定、または取得します。
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

        private bool _isConvertBackWhenPreAndPostreformSet;
        private bool _convertBackWhenPreAndPostreform;
		/// <summary>
        /// SpellingReformの値がPreAndPostreformの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenPreAndPostreform
        {
            get
            {
                return _convertBackWhenPreAndPostreform;
            }
            set
            {
                _convertBackWhenPreAndPostreform = value;
                _isConvertBackWhenPreAndPostreformSet = true;
            }
        }
        private bool _isConvertBackWhenPrereformSet;
        private bool _convertBackWhenPrereform;
		/// <summary>
        /// SpellingReformの値がPrereformの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenPrereform
        {
            get
            {
                return _convertBackWhenPrereform;
            }
            set
            {
                _convertBackWhenPrereform = value;
                _isConvertBackWhenPrereformSet = true;
            }
        }
        private bool _isConvertBackWhenPostreformSet;
        private bool _convertBackWhenPostreform;
		/// <summary>
        /// SpellingReformの値がPostreformの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenPostreform
        {
            get
            {
                return _convertBackWhenPostreform;
            }
            set
            {
                _convertBackWhenPostreform = value;
                _isConvertBackWhenPostreformSet = true;
            }
        }
    }
}