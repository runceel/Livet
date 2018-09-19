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
    /// FrameworkPropertyMetadataOptions列挙体とbool値の相互変換を行うIValueConverterです。
    /// </summary>
    public class FrameworkPropertyMetadataOptionsAndBooleanConverter : IValueConverter
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
        private FrameworkPropertyMetadataOptions _convertWhenTrue;
		/// <summary>
        /// ソース値がTrueの際にどのFrameworkPropertyMetadataOptions列挙体メンバーに変換するかを指定、または取得します。
        /// </summary>
        public FrameworkPropertyMetadataOptions ConvertWhenTrue
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
        private FrameworkPropertyMetadataOptions _convertWhenFalse;
		/// <summary>
        /// ソース値がFalseの際にどのFrameworkPropertyMetadataOptions列挙体メンバーに変換するかを指定、または取得します。
        /// </summary>
        public FrameworkPropertyMetadataOptions ConvertWhenFalse
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
            if (!(value is FrameworkPropertyMetadataOptions)) throw new ArgumentException();

            var enumValue = (FrameworkPropertyMetadataOptions)value;

			switch(enumValue.ToString())
			{
				case "None":
					if (_isConvertBackWhenNoneSet)
					{
						return ConvertBackWhenNone;
					}
					break;
				case "AffectsMeasure":
					if (_isConvertBackWhenAffectsMeasureSet)
					{
						return ConvertBackWhenAffectsMeasure;
					}
					break;
				case "AffectsArrange":
					if (_isConvertBackWhenAffectsArrangeSet)
					{
						return ConvertBackWhenAffectsArrange;
					}
					break;
				case "AffectsParentMeasure":
					if (_isConvertBackWhenAffectsParentMeasureSet)
					{
						return ConvertBackWhenAffectsParentMeasure;
					}
					break;
				case "AffectsParentArrange":
					if (_isConvertBackWhenAffectsParentArrangeSet)
					{
						return ConvertBackWhenAffectsParentArrange;
					}
					break;
				case "AffectsRender":
					if (_isConvertBackWhenAffectsRenderSet)
					{
						return ConvertBackWhenAffectsRender;
					}
					break;
				case "Inherits":
					if (_isConvertBackWhenInheritsSet)
					{
						return ConvertBackWhenInherits;
					}
					break;
				case "OverridesInheritanceBehavior":
					if (_isConvertBackWhenOverridesInheritanceBehaviorSet)
					{
						return ConvertBackWhenOverridesInheritanceBehavior;
					}
					break;
				case "NotDataBindable":
					if (_isConvertBackWhenNotDataBindableSet)
					{
						return ConvertBackWhenNotDataBindable;
					}
					break;
				case "BindsTwoWayByDefault":
					if (_isConvertBackWhenBindsTwoWayByDefaultSet)
					{
						return ConvertBackWhenBindsTwoWayByDefault;
					}
					break;
				case "Journal":
					if (_isConvertBackWhenJournalSet)
					{
						return ConvertBackWhenJournal;
					}
					break;
				case "SubPropertiesDoNotAffectRender":
					if (_isConvertBackWhenSubPropertiesDoNotAffectRenderSet)
					{
						return ConvertBackWhenSubPropertiesDoNotAffectRender;
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
        /// FrameworkPropertyMetadataOptionsの値をbool値に変換する際のデフォルト値を指定、または取得します。
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
        /// FrameworkPropertyMetadataOptionsの値がNoneの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
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
        private bool _isConvertBackWhenAffectsMeasureSet;
        private bool _convertBackWhenAffectsMeasure;
		/// <summary>
        /// FrameworkPropertyMetadataOptionsの値がAffectsMeasureの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenAffectsMeasure
        {
            get
            {
                return _convertBackWhenAffectsMeasure;
            }
            set
            {
                _convertBackWhenAffectsMeasure = value;
                _isConvertBackWhenAffectsMeasureSet = true;
            }
        }
        private bool _isConvertBackWhenAffectsArrangeSet;
        private bool _convertBackWhenAffectsArrange;
		/// <summary>
        /// FrameworkPropertyMetadataOptionsの値がAffectsArrangeの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenAffectsArrange
        {
            get
            {
                return _convertBackWhenAffectsArrange;
            }
            set
            {
                _convertBackWhenAffectsArrange = value;
                _isConvertBackWhenAffectsArrangeSet = true;
            }
        }
        private bool _isConvertBackWhenAffectsParentMeasureSet;
        private bool _convertBackWhenAffectsParentMeasure;
		/// <summary>
        /// FrameworkPropertyMetadataOptionsの値がAffectsParentMeasureの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenAffectsParentMeasure
        {
            get
            {
                return _convertBackWhenAffectsParentMeasure;
            }
            set
            {
                _convertBackWhenAffectsParentMeasure = value;
                _isConvertBackWhenAffectsParentMeasureSet = true;
            }
        }
        private bool _isConvertBackWhenAffectsParentArrangeSet;
        private bool _convertBackWhenAffectsParentArrange;
		/// <summary>
        /// FrameworkPropertyMetadataOptionsの値がAffectsParentArrangeの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenAffectsParentArrange
        {
            get
            {
                return _convertBackWhenAffectsParentArrange;
            }
            set
            {
                _convertBackWhenAffectsParentArrange = value;
                _isConvertBackWhenAffectsParentArrangeSet = true;
            }
        }
        private bool _isConvertBackWhenAffectsRenderSet;
        private bool _convertBackWhenAffectsRender;
		/// <summary>
        /// FrameworkPropertyMetadataOptionsの値がAffectsRenderの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenAffectsRender
        {
            get
            {
                return _convertBackWhenAffectsRender;
            }
            set
            {
                _convertBackWhenAffectsRender = value;
                _isConvertBackWhenAffectsRenderSet = true;
            }
        }
        private bool _isConvertBackWhenInheritsSet;
        private bool _convertBackWhenInherits;
		/// <summary>
        /// FrameworkPropertyMetadataOptionsの値がInheritsの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenInherits
        {
            get
            {
                return _convertBackWhenInherits;
            }
            set
            {
                _convertBackWhenInherits = value;
                _isConvertBackWhenInheritsSet = true;
            }
        }
        private bool _isConvertBackWhenOverridesInheritanceBehaviorSet;
        private bool _convertBackWhenOverridesInheritanceBehavior;
		/// <summary>
        /// FrameworkPropertyMetadataOptionsの値がOverridesInheritanceBehaviorの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenOverridesInheritanceBehavior
        {
            get
            {
                return _convertBackWhenOverridesInheritanceBehavior;
            }
            set
            {
                _convertBackWhenOverridesInheritanceBehavior = value;
                _isConvertBackWhenOverridesInheritanceBehaviorSet = true;
            }
        }
        private bool _isConvertBackWhenNotDataBindableSet;
        private bool _convertBackWhenNotDataBindable;
		/// <summary>
        /// FrameworkPropertyMetadataOptionsの値がNotDataBindableの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenNotDataBindable
        {
            get
            {
                return _convertBackWhenNotDataBindable;
            }
            set
            {
                _convertBackWhenNotDataBindable = value;
                _isConvertBackWhenNotDataBindableSet = true;
            }
        }
        private bool _isConvertBackWhenBindsTwoWayByDefaultSet;
        private bool _convertBackWhenBindsTwoWayByDefault;
		/// <summary>
        /// FrameworkPropertyMetadataOptionsの値がBindsTwoWayByDefaultの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenBindsTwoWayByDefault
        {
            get
            {
                return _convertBackWhenBindsTwoWayByDefault;
            }
            set
            {
                _convertBackWhenBindsTwoWayByDefault = value;
                _isConvertBackWhenBindsTwoWayByDefaultSet = true;
            }
        }
        private bool _isConvertBackWhenJournalSet;
        private bool _convertBackWhenJournal;
		/// <summary>
        /// FrameworkPropertyMetadataOptionsの値がJournalの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenJournal
        {
            get
            {
                return _convertBackWhenJournal;
            }
            set
            {
                _convertBackWhenJournal = value;
                _isConvertBackWhenJournalSet = true;
            }
        }
        private bool _isConvertBackWhenSubPropertiesDoNotAffectRenderSet;
        private bool _convertBackWhenSubPropertiesDoNotAffectRender;
		/// <summary>
        /// FrameworkPropertyMetadataOptionsの値がSubPropertiesDoNotAffectRenderの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenSubPropertiesDoNotAffectRender
        {
            get
            {
                return _convertBackWhenSubPropertiesDoNotAffectRender;
            }
            set
            {
                _convertBackWhenSubPropertiesDoNotAffectRender = value;
                _isConvertBackWhenSubPropertiesDoNotAffectRenderSet = true;
            }
        }
    }
}