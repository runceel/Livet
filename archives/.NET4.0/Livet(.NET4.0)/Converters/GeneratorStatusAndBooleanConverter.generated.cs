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
    /// GeneratorStatus列挙体とbool値の相互変換を行うIValueConverterです。
    /// </summary>
    public class GeneratorStatusAndBooleanConverter : IValueConverter
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
        private GeneratorStatus _convertWhenTrue;
		/// <summary>
        /// ソース値がTrueの際にどのGeneratorStatus列挙体メンバーに変換するかを指定、または取得します。
        /// </summary>
        public GeneratorStatus ConvertWhenTrue
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
        private GeneratorStatus _convertWhenFalse;
		/// <summary>
        /// ソース値がFalseの際にどのGeneratorStatus列挙体メンバーに変換するかを指定、または取得します。
        /// </summary>
        public GeneratorStatus ConvertWhenFalse
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
            if (!(value is GeneratorStatus)) throw new ArgumentException();

            var enumValue = (GeneratorStatus)value;

			switch(enumValue.ToString())
			{
				case "NotStarted":
					if (_isConvertBackWhenNotStartedSet)
					{
						return ConvertBackWhenNotStarted;
					}
					break;
				case "GeneratingContainers":
					if (_isConvertBackWhenGeneratingContainersSet)
					{
						return ConvertBackWhenGeneratingContainers;
					}
					break;
				case "ContainersGenerated":
					if (_isConvertBackWhenContainersGeneratedSet)
					{
						return ConvertBackWhenContainersGenerated;
					}
					break;
				case "Error":
					if (_isConvertBackWhenErrorSet)
					{
						return ConvertBackWhenError;
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
        /// GeneratorStatusの値をbool値に変換する際のデフォルト値を指定、または取得します。
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

        private bool _isConvertBackWhenNotStartedSet;
        private bool _convertBackWhenNotStarted;
		/// <summary>
        /// GeneratorStatusの値がNotStartedの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenNotStarted
        {
            get
            {
                return _convertBackWhenNotStarted;
            }
            set
            {
                _convertBackWhenNotStarted = value;
                _isConvertBackWhenNotStartedSet = true;
            }
        }
        private bool _isConvertBackWhenGeneratingContainersSet;
        private bool _convertBackWhenGeneratingContainers;
		/// <summary>
        /// GeneratorStatusの値がGeneratingContainersの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenGeneratingContainers
        {
            get
            {
                return _convertBackWhenGeneratingContainers;
            }
            set
            {
                _convertBackWhenGeneratingContainers = value;
                _isConvertBackWhenGeneratingContainersSet = true;
            }
        }
        private bool _isConvertBackWhenContainersGeneratedSet;
        private bool _convertBackWhenContainersGenerated;
		/// <summary>
        /// GeneratorStatusの値がContainersGeneratedの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenContainersGenerated
        {
            get
            {
                return _convertBackWhenContainersGenerated;
            }
            set
            {
                _convertBackWhenContainersGenerated = value;
                _isConvertBackWhenContainersGeneratedSet = true;
            }
        }
        private bool _isConvertBackWhenErrorSet;
        private bool _convertBackWhenError;
		/// <summary>
        /// GeneratorStatusの値がErrorの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenError
        {
            get
            {
                return _convertBackWhenError;
            }
            set
            {
                _convertBackWhenError = value;
                _isConvertBackWhenErrorSet = true;
            }
        }
    }
}