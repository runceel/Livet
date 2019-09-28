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
    /// KeyTimeType列挙体とbool値の相互変換を行うIValueConverterです。
    /// </summary>
    public class KeyTimeTypeAndBooleanConverter : IValueConverter
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
        private KeyTimeType _convertWhenTrue;
		/// <summary>
        /// ソース値がTrueの際にどのKeyTimeType列挙体メンバーに変換するかを指定、または取得します。
        /// </summary>
        public KeyTimeType ConvertWhenTrue
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
        private KeyTimeType _convertWhenFalse;
		/// <summary>
        /// ソース値がFalseの際にどのKeyTimeType列挙体メンバーに変換するかを指定、または取得します。
        /// </summary>
        public KeyTimeType ConvertWhenFalse
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
            if (!(value is KeyTimeType)) throw new ArgumentException();

            var enumValue = (KeyTimeType)value;

			switch(enumValue.ToString())
			{
				case "Uniform":
					if (_isConvertBackWhenUniformSet)
					{
						return ConvertBackWhenUniform;
					}
					break;
				case "Percent":
					if (_isConvertBackWhenPercentSet)
					{
						return ConvertBackWhenPercent;
					}
					break;
				case "TimeSpan":
					if (_isConvertBackWhenTimeSpanSet)
					{
						return ConvertBackWhenTimeSpan;
					}
					break;
				case "Paced":
					if (_isConvertBackWhenPacedSet)
					{
						return ConvertBackWhenPaced;
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
        /// KeyTimeTypeの値をbool値に変換する際のデフォルト値を指定、または取得します。
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

        private bool _isConvertBackWhenUniformSet;
        private bool _convertBackWhenUniform;
		/// <summary>
        /// KeyTimeTypeの値がUniformの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenUniform
        {
            get
            {
                return _convertBackWhenUniform;
            }
            set
            {
                _convertBackWhenUniform = value;
                _isConvertBackWhenUniformSet = true;
            }
        }
        private bool _isConvertBackWhenPercentSet;
        private bool _convertBackWhenPercent;
		/// <summary>
        /// KeyTimeTypeの値がPercentの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenPercent
        {
            get
            {
                return _convertBackWhenPercent;
            }
            set
            {
                _convertBackWhenPercent = value;
                _isConvertBackWhenPercentSet = true;
            }
        }
        private bool _isConvertBackWhenTimeSpanSet;
        private bool _convertBackWhenTimeSpan;
		/// <summary>
        /// KeyTimeTypeの値がTimeSpanの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenTimeSpan
        {
            get
            {
                return _convertBackWhenTimeSpan;
            }
            set
            {
                _convertBackWhenTimeSpan = value;
                _isConvertBackWhenTimeSpanSet = true;
            }
        }
        private bool _isConvertBackWhenPacedSet;
        private bool _convertBackWhenPaced;
		/// <summary>
        /// KeyTimeTypeの値がPacedの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenPaced
        {
            get
            {
                return _convertBackWhenPaced;
            }
            set
            {
                _convertBackWhenPaced = value;
                _isConvertBackWhenPacedSet = true;
            }
        }
    }
}