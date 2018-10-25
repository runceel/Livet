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
    /// TileMode列挙体とbool値の相互変換を行うIValueConverterです。
    /// </summary>
    public class TileModeAndBooleanConverter : IValueConverter
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
        private TileMode _convertWhenTrue;
		/// <summary>
        /// ソース値がTrueの際にどのTileMode列挙体メンバーに変換するかを指定、または取得します。
        /// </summary>
        public TileMode ConvertWhenTrue
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
        private TileMode _convertWhenFalse;
		/// <summary>
        /// ソース値がFalseの際にどのTileMode列挙体メンバーに変換するかを指定、または取得します。
        /// </summary>
        public TileMode ConvertWhenFalse
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
            if (!(value is TileMode)) throw new ArgumentException();

            var enumValue = (TileMode)value;

			switch(enumValue.ToString())
			{
				case "None":
					if (_isConvertBackWhenNoneSet)
					{
						return ConvertBackWhenNone;
					}
					break;
				case "FlipX":
					if (_isConvertBackWhenFlipXSet)
					{
						return ConvertBackWhenFlipX;
					}
					break;
				case "FlipY":
					if (_isConvertBackWhenFlipYSet)
					{
						return ConvertBackWhenFlipY;
					}
					break;
				case "FlipXY":
					if (_isConvertBackWhenFlipXYSet)
					{
						return ConvertBackWhenFlipXY;
					}
					break;
				case "Tile":
					if (_isConvertBackWhenTileSet)
					{
						return ConvertBackWhenTile;
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
        /// TileModeの値をbool値に変換する際のデフォルト値を指定、または取得します。
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
        /// TileModeの値がNoneの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
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
        private bool _isConvertBackWhenFlipXSet;
        private bool _convertBackWhenFlipX;
		/// <summary>
        /// TileModeの値がFlipXの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenFlipX
        {
            get
            {
                return _convertBackWhenFlipX;
            }
            set
            {
                _convertBackWhenFlipX = value;
                _isConvertBackWhenFlipXSet = true;
            }
        }
        private bool _isConvertBackWhenFlipYSet;
        private bool _convertBackWhenFlipY;
		/// <summary>
        /// TileModeの値がFlipYの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenFlipY
        {
            get
            {
                return _convertBackWhenFlipY;
            }
            set
            {
                _convertBackWhenFlipY = value;
                _isConvertBackWhenFlipYSet = true;
            }
        }
        private bool _isConvertBackWhenFlipXYSet;
        private bool _convertBackWhenFlipXY;
		/// <summary>
        /// TileModeの値がFlipXYの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenFlipXY
        {
            get
            {
                return _convertBackWhenFlipXY;
            }
            set
            {
                _convertBackWhenFlipXY = value;
                _isConvertBackWhenFlipXYSet = true;
            }
        }
        private bool _isConvertBackWhenTileSet;
        private bool _convertBackWhenTile;
		/// <summary>
        /// TileModeの値がTileの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenTile
        {
            get
            {
                return _convertBackWhenTile;
            }
            set
            {
                _convertBackWhenTile = value;
                _isConvertBackWhenTileSet = true;
            }
        }
    }
}