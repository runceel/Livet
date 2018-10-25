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
    /// CompressionOption列挙体とbool値の相互変換を行うIValueConverterです。
    /// </summary>
    public class CompressionOptionAndBooleanConverter : IValueConverter
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
        private CompressionOption _convertWhenTrue;
		/// <summary>
        /// ソース値がTrueの際にどのCompressionOption列挙体メンバーに変換するかを指定、または取得します。
        /// </summary>
        public CompressionOption ConvertWhenTrue
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
        private CompressionOption _convertWhenFalse;
		/// <summary>
        /// ソース値がFalseの際にどのCompressionOption列挙体メンバーに変換するかを指定、または取得します。
        /// </summary>
        public CompressionOption ConvertWhenFalse
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
            if (!(value is CompressionOption)) throw new ArgumentException();

            var enumValue = (CompressionOption)value;

			switch(enumValue.ToString())
			{
				case "Normal":
					if (_isConvertBackWhenNormalSet)
					{
						return ConvertBackWhenNormal;
					}
					break;
				case "Maximum":
					if (_isConvertBackWhenMaximumSet)
					{
						return ConvertBackWhenMaximum;
					}
					break;
				case "Fast":
					if (_isConvertBackWhenFastSet)
					{
						return ConvertBackWhenFast;
					}
					break;
				case "SuperFast":
					if (_isConvertBackWhenSuperFastSet)
					{
						return ConvertBackWhenSuperFast;
					}
					break;
				case "NotCompressed":
					if (_isConvertBackWhenNotCompressedSet)
					{
						return ConvertBackWhenNotCompressed;
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
        /// CompressionOptionの値をbool値に変換する際のデフォルト値を指定、または取得します。
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

        private bool _isConvertBackWhenNormalSet;
        private bool _convertBackWhenNormal;
		/// <summary>
        /// CompressionOptionの値がNormalの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenNormal
        {
            get
            {
                return _convertBackWhenNormal;
            }
            set
            {
                _convertBackWhenNormal = value;
                _isConvertBackWhenNormalSet = true;
            }
        }
        private bool _isConvertBackWhenMaximumSet;
        private bool _convertBackWhenMaximum;
		/// <summary>
        /// CompressionOptionの値がMaximumの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenMaximum
        {
            get
            {
                return _convertBackWhenMaximum;
            }
            set
            {
                _convertBackWhenMaximum = value;
                _isConvertBackWhenMaximumSet = true;
            }
        }
        private bool _isConvertBackWhenFastSet;
        private bool _convertBackWhenFast;
		/// <summary>
        /// CompressionOptionの値がFastの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenFast
        {
            get
            {
                return _convertBackWhenFast;
            }
            set
            {
                _convertBackWhenFast = value;
                _isConvertBackWhenFastSet = true;
            }
        }
        private bool _isConvertBackWhenSuperFastSet;
        private bool _convertBackWhenSuperFast;
		/// <summary>
        /// CompressionOptionの値がSuperFastの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenSuperFast
        {
            get
            {
                return _convertBackWhenSuperFast;
            }
            set
            {
                _convertBackWhenSuperFast = value;
                _isConvertBackWhenSuperFastSet = true;
            }
        }
        private bool _isConvertBackWhenNotCompressedSet;
        private bool _convertBackWhenNotCompressed;
		/// <summary>
        /// CompressionOptionの値がNotCompressedの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenNotCompressed
        {
            get
            {
                return _convertBackWhenNotCompressed;
            }
            set
            {
                _convertBackWhenNotCompressed = value;
                _isConvertBackWhenNotCompressedSet = true;
            }
        }
    }
}