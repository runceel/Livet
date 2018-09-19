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
    /// PenLineCap列挙体とbool値の相互変換を行うIValueConverterです。
    /// </summary>
    public class PenLineCapAndBooleanConverter : IValueConverter
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
        private PenLineCap _convertWhenTrue;
		/// <summary>
        /// ソース値がTrueの際にどのPenLineCap列挙体メンバーに変換するかを指定、または取得します。
        /// </summary>
        public PenLineCap ConvertWhenTrue
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
        private PenLineCap _convertWhenFalse;
		/// <summary>
        /// ソース値がFalseの際にどのPenLineCap列挙体メンバーに変換するかを指定、または取得します。
        /// </summary>
        public PenLineCap ConvertWhenFalse
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
            if (!(value is PenLineCap)) throw new ArgumentException();

            var enumValue = (PenLineCap)value;

			switch(enumValue.ToString())
			{
				case "Flat":
					if (_isConvertBackWhenFlatSet)
					{
						return ConvertBackWhenFlat;
					}
					break;
				case "Square":
					if (_isConvertBackWhenSquareSet)
					{
						return ConvertBackWhenSquare;
					}
					break;
				case "Round":
					if (_isConvertBackWhenRoundSet)
					{
						return ConvertBackWhenRound;
					}
					break;
				case "Triangle":
					if (_isConvertBackWhenTriangleSet)
					{
						return ConvertBackWhenTriangle;
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
        /// PenLineCapの値をbool値に変換する際のデフォルト値を指定、または取得します。
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

        private bool _isConvertBackWhenFlatSet;
        private bool _convertBackWhenFlat;
		/// <summary>
        /// PenLineCapの値がFlatの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenFlat
        {
            get
            {
                return _convertBackWhenFlat;
            }
            set
            {
                _convertBackWhenFlat = value;
                _isConvertBackWhenFlatSet = true;
            }
        }
        private bool _isConvertBackWhenSquareSet;
        private bool _convertBackWhenSquare;
		/// <summary>
        /// PenLineCapの値がSquareの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenSquare
        {
            get
            {
                return _convertBackWhenSquare;
            }
            set
            {
                _convertBackWhenSquare = value;
                _isConvertBackWhenSquareSet = true;
            }
        }
        private bool _isConvertBackWhenRoundSet;
        private bool _convertBackWhenRound;
		/// <summary>
        /// PenLineCapの値がRoundの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
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
        private bool _isConvertBackWhenTriangleSet;
        private bool _convertBackWhenTriangle;
		/// <summary>
        /// PenLineCapの値がTriangleの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenTriangle
        {
            get
            {
                return _convertBackWhenTriangle;
            }
            set
            {
                _convertBackWhenTriangle = value;
                _isConvertBackWhenTriangleSet = true;
            }
        }
    }
}