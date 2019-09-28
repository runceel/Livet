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
    /// BaseValueSource列挙体とbool値の相互変換を行うIValueConverterです。
    /// </summary>
    public class BaseValueSourceAndBooleanConverter : IValueConverter
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
        private BaseValueSource _convertWhenTrue;
		/// <summary>
        /// ソース値がTrueの際にどのBaseValueSource列挙体メンバーに変換するかを指定、または取得します。
        /// </summary>
        public BaseValueSource ConvertWhenTrue
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
        private BaseValueSource _convertWhenFalse;
		/// <summary>
        /// ソース値がFalseの際にどのBaseValueSource列挙体メンバーに変換するかを指定、または取得します。
        /// </summary>
        public BaseValueSource ConvertWhenFalse
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
            if (!(value is BaseValueSource)) throw new ArgumentException();

            var enumValue = (BaseValueSource)value;

			switch(enumValue.ToString())
			{
				case "Unknown":
					if (_isConvertBackWhenUnknownSet)
					{
						return ConvertBackWhenUnknown;
					}
					break;
				case "Default":
					if (_isConvertBackWhenDefaultSet)
					{
						return ConvertBackWhenDefault;
					}
					break;
				case "Inherited":
					if (_isConvertBackWhenInheritedSet)
					{
						return ConvertBackWhenInherited;
					}
					break;
				case "DefaultStyle":
					if (_isConvertBackWhenDefaultStyleSet)
					{
						return ConvertBackWhenDefaultStyle;
					}
					break;
				case "DefaultStyleTrigger":
					if (_isConvertBackWhenDefaultStyleTriggerSet)
					{
						return ConvertBackWhenDefaultStyleTrigger;
					}
					break;
				case "Style":
					if (_isConvertBackWhenStyleSet)
					{
						return ConvertBackWhenStyle;
					}
					break;
				case "TemplateTrigger":
					if (_isConvertBackWhenTemplateTriggerSet)
					{
						return ConvertBackWhenTemplateTrigger;
					}
					break;
				case "StyleTrigger":
					if (_isConvertBackWhenStyleTriggerSet)
					{
						return ConvertBackWhenStyleTrigger;
					}
					break;
				case "ImplicitStyleReference":
					if (_isConvertBackWhenImplicitStyleReferenceSet)
					{
						return ConvertBackWhenImplicitStyleReference;
					}
					break;
				case "ParentTemplate":
					if (_isConvertBackWhenParentTemplateSet)
					{
						return ConvertBackWhenParentTemplate;
					}
					break;
				case "ParentTemplateTrigger":
					if (_isConvertBackWhenParentTemplateTriggerSet)
					{
						return ConvertBackWhenParentTemplateTrigger;
					}
					break;
				case "Local":
					if (_isConvertBackWhenLocalSet)
					{
						return ConvertBackWhenLocal;
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
        /// BaseValueSourceの値をbool値に変換する際のデフォルト値を指定、または取得します。
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

        private bool _isConvertBackWhenUnknownSet;
        private bool _convertBackWhenUnknown;
		/// <summary>
        /// BaseValueSourceの値がUnknownの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenUnknown
        {
            get
            {
                return _convertBackWhenUnknown;
            }
            set
            {
                _convertBackWhenUnknown = value;
                _isConvertBackWhenUnknownSet = true;
            }
        }
        private bool _isConvertBackWhenDefaultSet;
        private bool _convertBackWhenDefault;
		/// <summary>
        /// BaseValueSourceの値がDefaultの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
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
        private bool _isConvertBackWhenInheritedSet;
        private bool _convertBackWhenInherited;
		/// <summary>
        /// BaseValueSourceの値がInheritedの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenInherited
        {
            get
            {
                return _convertBackWhenInherited;
            }
            set
            {
                _convertBackWhenInherited = value;
                _isConvertBackWhenInheritedSet = true;
            }
        }
        private bool _isConvertBackWhenDefaultStyleSet;
        private bool _convertBackWhenDefaultStyle;
		/// <summary>
        /// BaseValueSourceの値がDefaultStyleの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenDefaultStyle
        {
            get
            {
                return _convertBackWhenDefaultStyle;
            }
            set
            {
                _convertBackWhenDefaultStyle = value;
                _isConvertBackWhenDefaultStyleSet = true;
            }
        }
        private bool _isConvertBackWhenDefaultStyleTriggerSet;
        private bool _convertBackWhenDefaultStyleTrigger;
		/// <summary>
        /// BaseValueSourceの値がDefaultStyleTriggerの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenDefaultStyleTrigger
        {
            get
            {
                return _convertBackWhenDefaultStyleTrigger;
            }
            set
            {
                _convertBackWhenDefaultStyleTrigger = value;
                _isConvertBackWhenDefaultStyleTriggerSet = true;
            }
        }
        private bool _isConvertBackWhenStyleSet;
        private bool _convertBackWhenStyle;
		/// <summary>
        /// BaseValueSourceの値がStyleの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenStyle
        {
            get
            {
                return _convertBackWhenStyle;
            }
            set
            {
                _convertBackWhenStyle = value;
                _isConvertBackWhenStyleSet = true;
            }
        }
        private bool _isConvertBackWhenTemplateTriggerSet;
        private bool _convertBackWhenTemplateTrigger;
		/// <summary>
        /// BaseValueSourceの値がTemplateTriggerの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenTemplateTrigger
        {
            get
            {
                return _convertBackWhenTemplateTrigger;
            }
            set
            {
                _convertBackWhenTemplateTrigger = value;
                _isConvertBackWhenTemplateTriggerSet = true;
            }
        }
        private bool _isConvertBackWhenStyleTriggerSet;
        private bool _convertBackWhenStyleTrigger;
		/// <summary>
        /// BaseValueSourceの値がStyleTriggerの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenStyleTrigger
        {
            get
            {
                return _convertBackWhenStyleTrigger;
            }
            set
            {
                _convertBackWhenStyleTrigger = value;
                _isConvertBackWhenStyleTriggerSet = true;
            }
        }
        private bool _isConvertBackWhenImplicitStyleReferenceSet;
        private bool _convertBackWhenImplicitStyleReference;
		/// <summary>
        /// BaseValueSourceの値がImplicitStyleReferenceの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenImplicitStyleReference
        {
            get
            {
                return _convertBackWhenImplicitStyleReference;
            }
            set
            {
                _convertBackWhenImplicitStyleReference = value;
                _isConvertBackWhenImplicitStyleReferenceSet = true;
            }
        }
        private bool _isConvertBackWhenParentTemplateSet;
        private bool _convertBackWhenParentTemplate;
		/// <summary>
        /// BaseValueSourceの値がParentTemplateの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenParentTemplate
        {
            get
            {
                return _convertBackWhenParentTemplate;
            }
            set
            {
                _convertBackWhenParentTemplate = value;
                _isConvertBackWhenParentTemplateSet = true;
            }
        }
        private bool _isConvertBackWhenParentTemplateTriggerSet;
        private bool _convertBackWhenParentTemplateTrigger;
		/// <summary>
        /// BaseValueSourceの値がParentTemplateTriggerの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenParentTemplateTrigger
        {
            get
            {
                return _convertBackWhenParentTemplateTrigger;
            }
            set
            {
                _convertBackWhenParentTemplateTrigger = value;
                _isConvertBackWhenParentTemplateTriggerSet = true;
            }
        }
        private bool _isConvertBackWhenLocalSet;
        private bool _convertBackWhenLocal;
		/// <summary>
        /// BaseValueSourceの値がLocalの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenLocal
        {
            get
            {
                return _convertBackWhenLocal;
            }
            set
            {
                _convertBackWhenLocal = value;
                _isConvertBackWhenLocalSet = true;
            }
        }
    }
}