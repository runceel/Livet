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
    /// PenLineJoin列挙体とbool値の相互変換を行うIValueConverterです。
    /// </summary>
    public class PenLineJoinAndBooleanConverter : IValueConverter
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
        private PenLineJoin _convertWhenTrue;
		/// <summary>
        /// ソース値がTrueの際にどのPenLineJoin列挙体メンバーに変換するかを指定、または取得します。
        /// </summary>
        public PenLineJoin ConvertWhenTrue
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
        private PenLineJoin _convertWhenFalse;
		/// <summary>
        /// ソース値がFalseの際にどのPenLineJoin列挙体メンバーに変換するかを指定、または取得します。
        /// </summary>
        public PenLineJoin ConvertWhenFalse
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
            if (!(value is PenLineJoin)) throw new ArgumentException();

            var enumValue = (PenLineJoin)value;

			switch(enumValue.ToString())
			{
				case "Miter":
					if (_isConvertBackWhenMiterSet)
					{
						return ConvertBackWhenMiter;
					}
					break;
				case "Bevel":
					if (_isConvertBackWhenBevelSet)
					{
						return ConvertBackWhenBevel;
					}
					break;
				case "Round":
					if (_isConvertBackWhenRoundSet)
					{
						return ConvertBackWhenRound;
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
        /// PenLineJoinの値をbool値に変換する際のデフォルト値を指定、または取得します。
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

        private bool _isConvertBackWhenMiterSet;
        private bool _convertBackWhenMiter;
		/// <summary>
        /// PenLineJoinの値がMiterの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenMiter
        {
            get
            {
                return _convertBackWhenMiter;
            }
            set
            {
                _convertBackWhenMiter = value;
                _isConvertBackWhenMiterSet = true;
            }
        }
        private bool _isConvertBackWhenBevelSet;
        private bool _convertBackWhenBevel;
		/// <summary>
        /// PenLineJoinの値がBevelの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenBevel
        {
            get
            {
                return _convertBackWhenBevel;
            }
            set
            {
                _convertBackWhenBevel = value;
                _isConvertBackWhenBevelSet = true;
            }
        }
        private bool _isConvertBackWhenRoundSet;
        private bool _convertBackWhenRound;
		/// <summary>
        /// PenLineJoinの値がRoundの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenRound
        {
            get
            {
                return _convertBackWhenRound;
            }
            set
            {
                _convertBackWhenRound = value;
                _isConvertBackWhenRoundSet = true;
            }
        }
    }
}