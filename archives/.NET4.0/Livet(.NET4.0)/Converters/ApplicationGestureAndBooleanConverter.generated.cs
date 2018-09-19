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
    /// ApplicationGesture列挙体とbool値の相互変換を行うIValueConverterです。
    /// </summary>
    public class ApplicationGestureAndBooleanConverter : IValueConverter
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
        private ApplicationGesture _convertWhenTrue;
		/// <summary>
        /// ソース値がTrueの際にどのApplicationGesture列挙体メンバーに変換するかを指定、または取得します。
        /// </summary>
        public ApplicationGesture ConvertWhenTrue
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
        private ApplicationGesture _convertWhenFalse;
		/// <summary>
        /// ソース値がFalseの際にどのApplicationGesture列挙体メンバーに変換するかを指定、または取得します。
        /// </summary>
        public ApplicationGesture ConvertWhenFalse
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
            if (!(value is ApplicationGesture)) throw new ArgumentException();

            var enumValue = (ApplicationGesture)value;

			switch(enumValue.ToString())
			{
				case "AllGestures":
					if (_isConvertBackWhenAllGesturesSet)
					{
						return ConvertBackWhenAllGestures;
					}
					break;
				case "NoGesture":
					if (_isConvertBackWhenNoGestureSet)
					{
						return ConvertBackWhenNoGesture;
					}
					break;
				case "ScratchOut":
					if (_isConvertBackWhenScratchOutSet)
					{
						return ConvertBackWhenScratchOut;
					}
					break;
				case "Triangle":
					if (_isConvertBackWhenTriangleSet)
					{
						return ConvertBackWhenTriangle;
					}
					break;
				case "Square":
					if (_isConvertBackWhenSquareSet)
					{
						return ConvertBackWhenSquare;
					}
					break;
				case "Star":
					if (_isConvertBackWhenStarSet)
					{
						return ConvertBackWhenStar;
					}
					break;
				case "Check":
					if (_isConvertBackWhenCheckSet)
					{
						return ConvertBackWhenCheck;
					}
					break;
				case "Curlicue":
					if (_isConvertBackWhenCurlicueSet)
					{
						return ConvertBackWhenCurlicue;
					}
					break;
				case "DoubleCurlicue":
					if (_isConvertBackWhenDoubleCurlicueSet)
					{
						return ConvertBackWhenDoubleCurlicue;
					}
					break;
				case "Circle":
					if (_isConvertBackWhenCircleSet)
					{
						return ConvertBackWhenCircle;
					}
					break;
				case "DoubleCircle":
					if (_isConvertBackWhenDoubleCircleSet)
					{
						return ConvertBackWhenDoubleCircle;
					}
					break;
				case "SemicircleLeft":
					if (_isConvertBackWhenSemicircleLeftSet)
					{
						return ConvertBackWhenSemicircleLeft;
					}
					break;
				case "SemicircleRight":
					if (_isConvertBackWhenSemicircleRightSet)
					{
						return ConvertBackWhenSemicircleRight;
					}
					break;
				case "ChevronUp":
					if (_isConvertBackWhenChevronUpSet)
					{
						return ConvertBackWhenChevronUp;
					}
					break;
				case "ChevronDown":
					if (_isConvertBackWhenChevronDownSet)
					{
						return ConvertBackWhenChevronDown;
					}
					break;
				case "ChevronLeft":
					if (_isConvertBackWhenChevronLeftSet)
					{
						return ConvertBackWhenChevronLeft;
					}
					break;
				case "ChevronRight":
					if (_isConvertBackWhenChevronRightSet)
					{
						return ConvertBackWhenChevronRight;
					}
					break;
				case "ArrowUp":
					if (_isConvertBackWhenArrowUpSet)
					{
						return ConvertBackWhenArrowUp;
					}
					break;
				case "ArrowDown":
					if (_isConvertBackWhenArrowDownSet)
					{
						return ConvertBackWhenArrowDown;
					}
					break;
				case "ArrowLeft":
					if (_isConvertBackWhenArrowLeftSet)
					{
						return ConvertBackWhenArrowLeft;
					}
					break;
				case "ArrowRight":
					if (_isConvertBackWhenArrowRightSet)
					{
						return ConvertBackWhenArrowRight;
					}
					break;
				case "Up":
					if (_isConvertBackWhenUpSet)
					{
						return ConvertBackWhenUp;
					}
					break;
				case "Down":
					if (_isConvertBackWhenDownSet)
					{
						return ConvertBackWhenDown;
					}
					break;
				case "Left":
					if (_isConvertBackWhenLeftSet)
					{
						return ConvertBackWhenLeft;
					}
					break;
				case "Right":
					if (_isConvertBackWhenRightSet)
					{
						return ConvertBackWhenRight;
					}
					break;
				case "UpDown":
					if (_isConvertBackWhenUpDownSet)
					{
						return ConvertBackWhenUpDown;
					}
					break;
				case "DownUp":
					if (_isConvertBackWhenDownUpSet)
					{
						return ConvertBackWhenDownUp;
					}
					break;
				case "LeftRight":
					if (_isConvertBackWhenLeftRightSet)
					{
						return ConvertBackWhenLeftRight;
					}
					break;
				case "RightLeft":
					if (_isConvertBackWhenRightLeftSet)
					{
						return ConvertBackWhenRightLeft;
					}
					break;
				case "UpLeftLong":
					if (_isConvertBackWhenUpLeftLongSet)
					{
						return ConvertBackWhenUpLeftLong;
					}
					break;
				case "UpRightLong":
					if (_isConvertBackWhenUpRightLongSet)
					{
						return ConvertBackWhenUpRightLong;
					}
					break;
				case "DownLeftLong":
					if (_isConvertBackWhenDownLeftLongSet)
					{
						return ConvertBackWhenDownLeftLong;
					}
					break;
				case "DownRightLong":
					if (_isConvertBackWhenDownRightLongSet)
					{
						return ConvertBackWhenDownRightLong;
					}
					break;
				case "UpLeft":
					if (_isConvertBackWhenUpLeftSet)
					{
						return ConvertBackWhenUpLeft;
					}
					break;
				case "UpRight":
					if (_isConvertBackWhenUpRightSet)
					{
						return ConvertBackWhenUpRight;
					}
					break;
				case "DownLeft":
					if (_isConvertBackWhenDownLeftSet)
					{
						return ConvertBackWhenDownLeft;
					}
					break;
				case "DownRight":
					if (_isConvertBackWhenDownRightSet)
					{
						return ConvertBackWhenDownRight;
					}
					break;
				case "LeftUp":
					if (_isConvertBackWhenLeftUpSet)
					{
						return ConvertBackWhenLeftUp;
					}
					break;
				case "LeftDown":
					if (_isConvertBackWhenLeftDownSet)
					{
						return ConvertBackWhenLeftDown;
					}
					break;
				case "RightUp":
					if (_isConvertBackWhenRightUpSet)
					{
						return ConvertBackWhenRightUp;
					}
					break;
				case "RightDown":
					if (_isConvertBackWhenRightDownSet)
					{
						return ConvertBackWhenRightDown;
					}
					break;
				case "Exclamation":
					if (_isConvertBackWhenExclamationSet)
					{
						return ConvertBackWhenExclamation;
					}
					break;
				case "Tap":
					if (_isConvertBackWhenTapSet)
					{
						return ConvertBackWhenTap;
					}
					break;
				case "DoubleTap":
					if (_isConvertBackWhenDoubleTapSet)
					{
						return ConvertBackWhenDoubleTap;
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
        /// ApplicationGestureの値をbool値に変換する際のデフォルト値を指定、または取得します。
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

        private bool _isConvertBackWhenAllGesturesSet;
        private bool _convertBackWhenAllGestures;
		/// <summary>
        /// ApplicationGestureの値がAllGesturesの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenAllGestures
        {
            get
            {
                return _convertBackWhenAllGestures;
            }
            set
            {
                _convertBackWhenAllGestures = value;
                _isConvertBackWhenAllGesturesSet = true;
            }
        }
        private bool _isConvertBackWhenNoGestureSet;
        private bool _convertBackWhenNoGesture;
		/// <summary>
        /// ApplicationGestureの値がNoGestureの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenNoGesture
        {
            get
            {
                return _convertBackWhenNoGesture;
            }
            set
            {
                _convertBackWhenNoGesture = value;
                _isConvertBackWhenNoGestureSet = true;
            }
        }
        private bool _isConvertBackWhenScratchOutSet;
        private bool _convertBackWhenScratchOut;
		/// <summary>
        /// ApplicationGestureの値がScratchOutの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenScratchOut
        {
            get
            {
                return _convertBackWhenScratchOut;
            }
            set
            {
                _convertBackWhenScratchOut = value;
                _isConvertBackWhenScratchOutSet = true;
            }
        }
        private bool _isConvertBackWhenTriangleSet;
        private bool _convertBackWhenTriangle;
		/// <summary>
        /// ApplicationGestureの値がTriangleの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
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
        private bool _isConvertBackWhenSquareSet;
        private bool _convertBackWhenSquare;
		/// <summary>
        /// ApplicationGestureの値がSquareの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
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
        private bool _isConvertBackWhenStarSet;
        private bool _convertBackWhenStar;
		/// <summary>
        /// ApplicationGestureの値がStarの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenStar
        {
            get
            {
                return _convertBackWhenStar;
            }
            set
            {
                _convertBackWhenStar = value;
                _isConvertBackWhenStarSet = true;
            }
        }
        private bool _isConvertBackWhenCheckSet;
        private bool _convertBackWhenCheck;
		/// <summary>
        /// ApplicationGestureの値がCheckの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenCheck
        {
            get
            {
                return _convertBackWhenCheck;
            }
            set
            {
                _convertBackWhenCheck = value;
                _isConvertBackWhenCheckSet = true;
            }
        }
        private bool _isConvertBackWhenCurlicueSet;
        private bool _convertBackWhenCurlicue;
		/// <summary>
        /// ApplicationGestureの値がCurlicueの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenCurlicue
        {
            get
            {
                return _convertBackWhenCurlicue;
            }
            set
            {
                _convertBackWhenCurlicue = value;
                _isConvertBackWhenCurlicueSet = true;
            }
        }
        private bool _isConvertBackWhenDoubleCurlicueSet;
        private bool _convertBackWhenDoubleCurlicue;
		/// <summary>
        /// ApplicationGestureの値がDoubleCurlicueの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenDoubleCurlicue
        {
            get
            {
                return _convertBackWhenDoubleCurlicue;
            }
            set
            {
                _convertBackWhenDoubleCurlicue = value;
                _isConvertBackWhenDoubleCurlicueSet = true;
            }
        }
        private bool _isConvertBackWhenCircleSet;
        private bool _convertBackWhenCircle;
		/// <summary>
        /// ApplicationGestureの値がCircleの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenCircle
        {
            get
            {
                return _convertBackWhenCircle;
            }
            set
            {
                _convertBackWhenCircle = value;
                _isConvertBackWhenCircleSet = true;
            }
        }
        private bool _isConvertBackWhenDoubleCircleSet;
        private bool _convertBackWhenDoubleCircle;
		/// <summary>
        /// ApplicationGestureの値がDoubleCircleの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenDoubleCircle
        {
            get
            {
                return _convertBackWhenDoubleCircle;
            }
            set
            {
                _convertBackWhenDoubleCircle = value;
                _isConvertBackWhenDoubleCircleSet = true;
            }
        }
        private bool _isConvertBackWhenSemicircleLeftSet;
        private bool _convertBackWhenSemicircleLeft;
		/// <summary>
        /// ApplicationGestureの値がSemicircleLeftの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenSemicircleLeft
        {
            get
            {
                return _convertBackWhenSemicircleLeft;
            }
            set
            {
                _convertBackWhenSemicircleLeft = value;
                _isConvertBackWhenSemicircleLeftSet = true;
            }
        }
        private bool _isConvertBackWhenSemicircleRightSet;
        private bool _convertBackWhenSemicircleRight;
		/// <summary>
        /// ApplicationGestureの値がSemicircleRightの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenSemicircleRight
        {
            get
            {
                return _convertBackWhenSemicircleRight;
            }
            set
            {
                _convertBackWhenSemicircleRight = value;
                _isConvertBackWhenSemicircleRightSet = true;
            }
        }
        private bool _isConvertBackWhenChevronUpSet;
        private bool _convertBackWhenChevronUp;
		/// <summary>
        /// ApplicationGestureの値がChevronUpの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenChevronUp
        {
            get
            {
                return _convertBackWhenChevronUp;
            }
            set
            {
                _convertBackWhenChevronUp = value;
                _isConvertBackWhenChevronUpSet = true;
            }
        }
        private bool _isConvertBackWhenChevronDownSet;
        private bool _convertBackWhenChevronDown;
		/// <summary>
        /// ApplicationGestureの値がChevronDownの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenChevronDown
        {
            get
            {
                return _convertBackWhenChevronDown;
            }
            set
            {
                _convertBackWhenChevronDown = value;
                _isConvertBackWhenChevronDownSet = true;
            }
        }
        private bool _isConvertBackWhenChevronLeftSet;
        private bool _convertBackWhenChevronLeft;
		/// <summary>
        /// ApplicationGestureの値がChevronLeftの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenChevronLeft
        {
            get
            {
                return _convertBackWhenChevronLeft;
            }
            set
            {
                _convertBackWhenChevronLeft = value;
                _isConvertBackWhenChevronLeftSet = true;
            }
        }
        private bool _isConvertBackWhenChevronRightSet;
        private bool _convertBackWhenChevronRight;
		/// <summary>
        /// ApplicationGestureの値がChevronRightの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenChevronRight
        {
            get
            {
                return _convertBackWhenChevronRight;
            }
            set
            {
                _convertBackWhenChevronRight = value;
                _isConvertBackWhenChevronRightSet = true;
            }
        }
        private bool _isConvertBackWhenArrowUpSet;
        private bool _convertBackWhenArrowUp;
		/// <summary>
        /// ApplicationGestureの値がArrowUpの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenArrowUp
        {
            get
            {
                return _convertBackWhenArrowUp;
            }
            set
            {
                _convertBackWhenArrowUp = value;
                _isConvertBackWhenArrowUpSet = true;
            }
        }
        private bool _isConvertBackWhenArrowDownSet;
        private bool _convertBackWhenArrowDown;
		/// <summary>
        /// ApplicationGestureの値がArrowDownの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenArrowDown
        {
            get
            {
                return _convertBackWhenArrowDown;
            }
            set
            {
                _convertBackWhenArrowDown = value;
                _isConvertBackWhenArrowDownSet = true;
            }
        }
        private bool _isConvertBackWhenArrowLeftSet;
        private bool _convertBackWhenArrowLeft;
		/// <summary>
        /// ApplicationGestureの値がArrowLeftの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenArrowLeft
        {
            get
            {
                return _convertBackWhenArrowLeft;
            }
            set
            {
                _convertBackWhenArrowLeft = value;
                _isConvertBackWhenArrowLeftSet = true;
            }
        }
        private bool _isConvertBackWhenArrowRightSet;
        private bool _convertBackWhenArrowRight;
		/// <summary>
        /// ApplicationGestureの値がArrowRightの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenArrowRight
        {
            get
            {
                return _convertBackWhenArrowRight;
            }
            set
            {
                _convertBackWhenArrowRight = value;
                _isConvertBackWhenArrowRightSet = true;
            }
        }
        private bool _isConvertBackWhenUpSet;
        private bool _convertBackWhenUp;
		/// <summary>
        /// ApplicationGestureの値がUpの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenUp
        {
            get
            {
                return _convertBackWhenUp;
            }
            set
            {
                _convertBackWhenUp = value;
                _isConvertBackWhenUpSet = true;
            }
        }
        private bool _isConvertBackWhenDownSet;
        private bool _convertBackWhenDown;
		/// <summary>
        /// ApplicationGestureの値がDownの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenDown
        {
            get
            {
                return _convertBackWhenDown;
            }
            set
            {
                _convertBackWhenDown = value;
                _isConvertBackWhenDownSet = true;
            }
        }
        private bool _isConvertBackWhenLeftSet;
        private bool _convertBackWhenLeft;
		/// <summary>
        /// ApplicationGestureの値がLeftの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenLeft
        {
            get
            {
                return _convertBackWhenLeft;
            }
            set
            {
                _convertBackWhenLeft = value;
                _isConvertBackWhenLeftSet = true;
            }
        }
        private bool _isConvertBackWhenRightSet;
        private bool _convertBackWhenRight;
		/// <summary>
        /// ApplicationGestureの値がRightの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenRight
        {
            get
            {
                return _convertBackWhenRight;
            }
            set
            {
                _convertBackWhenRight = value;
                _isConvertBackWhenRightSet = true;
            }
        }
        private bool _isConvertBackWhenUpDownSet;
        private bool _convertBackWhenUpDown;
		/// <summary>
        /// ApplicationGestureの値がUpDownの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenUpDown
        {
            get
            {
                return _convertBackWhenUpDown;
            }
            set
            {
                _convertBackWhenUpDown = value;
                _isConvertBackWhenUpDownSet = true;
            }
        }
        private bool _isConvertBackWhenDownUpSet;
        private bool _convertBackWhenDownUp;
		/// <summary>
        /// ApplicationGestureの値がDownUpの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenDownUp
        {
            get
            {
                return _convertBackWhenDownUp;
            }
            set
            {
                _convertBackWhenDownUp = value;
                _isConvertBackWhenDownUpSet = true;
            }
        }
        private bool _isConvertBackWhenLeftRightSet;
        private bool _convertBackWhenLeftRight;
		/// <summary>
        /// ApplicationGestureの値がLeftRightの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenLeftRight
        {
            get
            {
                return _convertBackWhenLeftRight;
            }
            set
            {
                _convertBackWhenLeftRight = value;
                _isConvertBackWhenLeftRightSet = true;
            }
        }
        private bool _isConvertBackWhenRightLeftSet;
        private bool _convertBackWhenRightLeft;
		/// <summary>
        /// ApplicationGestureの値がRightLeftの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenRightLeft
        {
            get
            {
                return _convertBackWhenRightLeft;
            }
            set
            {
                _convertBackWhenRightLeft = value;
                _isConvertBackWhenRightLeftSet = true;
            }
        }
        private bool _isConvertBackWhenUpLeftLongSet;
        private bool _convertBackWhenUpLeftLong;
		/// <summary>
        /// ApplicationGestureの値がUpLeftLongの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenUpLeftLong
        {
            get
            {
                return _convertBackWhenUpLeftLong;
            }
            set
            {
                _convertBackWhenUpLeftLong = value;
                _isConvertBackWhenUpLeftLongSet = true;
            }
        }
        private bool _isConvertBackWhenUpRightLongSet;
        private bool _convertBackWhenUpRightLong;
		/// <summary>
        /// ApplicationGestureの値がUpRightLongの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenUpRightLong
        {
            get
            {
                return _convertBackWhenUpRightLong;
            }
            set
            {
                _convertBackWhenUpRightLong = value;
                _isConvertBackWhenUpRightLongSet = true;
            }
        }
        private bool _isConvertBackWhenDownLeftLongSet;
        private bool _convertBackWhenDownLeftLong;
		/// <summary>
        /// ApplicationGestureの値がDownLeftLongの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenDownLeftLong
        {
            get
            {
                return _convertBackWhenDownLeftLong;
            }
            set
            {
                _convertBackWhenDownLeftLong = value;
                _isConvertBackWhenDownLeftLongSet = true;
            }
        }
        private bool _isConvertBackWhenDownRightLongSet;
        private bool _convertBackWhenDownRightLong;
		/// <summary>
        /// ApplicationGestureの値がDownRightLongの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenDownRightLong
        {
            get
            {
                return _convertBackWhenDownRightLong;
            }
            set
            {
                _convertBackWhenDownRightLong = value;
                _isConvertBackWhenDownRightLongSet = true;
            }
        }
        private bool _isConvertBackWhenUpLeftSet;
        private bool _convertBackWhenUpLeft;
		/// <summary>
        /// ApplicationGestureの値がUpLeftの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenUpLeft
        {
            get
            {
                return _convertBackWhenUpLeft;
            }
            set
            {
                _convertBackWhenUpLeft = value;
                _isConvertBackWhenUpLeftSet = true;
            }
        }
        private bool _isConvertBackWhenUpRightSet;
        private bool _convertBackWhenUpRight;
		/// <summary>
        /// ApplicationGestureの値がUpRightの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenUpRight
        {
            get
            {
                return _convertBackWhenUpRight;
            }
            set
            {
                _convertBackWhenUpRight = value;
                _isConvertBackWhenUpRightSet = true;
            }
        }
        private bool _isConvertBackWhenDownLeftSet;
        private bool _convertBackWhenDownLeft;
		/// <summary>
        /// ApplicationGestureの値がDownLeftの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenDownLeft
        {
            get
            {
                return _convertBackWhenDownLeft;
            }
            set
            {
                _convertBackWhenDownLeft = value;
                _isConvertBackWhenDownLeftSet = true;
            }
        }
        private bool _isConvertBackWhenDownRightSet;
        private bool _convertBackWhenDownRight;
		/// <summary>
        /// ApplicationGestureの値がDownRightの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenDownRight
        {
            get
            {
                return _convertBackWhenDownRight;
            }
            set
            {
                _convertBackWhenDownRight = value;
                _isConvertBackWhenDownRightSet = true;
            }
        }
        private bool _isConvertBackWhenLeftUpSet;
        private bool _convertBackWhenLeftUp;
		/// <summary>
        /// ApplicationGestureの値がLeftUpの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenLeftUp
        {
            get
            {
                return _convertBackWhenLeftUp;
            }
            set
            {
                _convertBackWhenLeftUp = value;
                _isConvertBackWhenLeftUpSet = true;
            }
        }
        private bool _isConvertBackWhenLeftDownSet;
        private bool _convertBackWhenLeftDown;
		/// <summary>
        /// ApplicationGestureの値がLeftDownの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenLeftDown
        {
            get
            {
                return _convertBackWhenLeftDown;
            }
            set
            {
                _convertBackWhenLeftDown = value;
                _isConvertBackWhenLeftDownSet = true;
            }
        }
        private bool _isConvertBackWhenRightUpSet;
        private bool _convertBackWhenRightUp;
		/// <summary>
        /// ApplicationGestureの値がRightUpの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenRightUp
        {
            get
            {
                return _convertBackWhenRightUp;
            }
            set
            {
                _convertBackWhenRightUp = value;
                _isConvertBackWhenRightUpSet = true;
            }
        }
        private bool _isConvertBackWhenRightDownSet;
        private bool _convertBackWhenRightDown;
		/// <summary>
        /// ApplicationGestureの値がRightDownの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenRightDown
        {
            get
            {
                return _convertBackWhenRightDown;
            }
            set
            {
                _convertBackWhenRightDown = value;
                _isConvertBackWhenRightDownSet = true;
            }
        }
        private bool _isConvertBackWhenExclamationSet;
        private bool _convertBackWhenExclamation;
		/// <summary>
        /// ApplicationGestureの値がExclamationの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenExclamation
        {
            get
            {
                return _convertBackWhenExclamation;
            }
            set
            {
                _convertBackWhenExclamation = value;
                _isConvertBackWhenExclamationSet = true;
            }
        }
        private bool _isConvertBackWhenTapSet;
        private bool _convertBackWhenTap;
		/// <summary>
        /// ApplicationGestureの値がTapの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenTap
        {
            get
            {
                return _convertBackWhenTap;
            }
            set
            {
                _convertBackWhenTap = value;
                _isConvertBackWhenTapSet = true;
            }
        }
        private bool _isConvertBackWhenDoubleTapSet;
        private bool _convertBackWhenDoubleTap;
		/// <summary>
        /// ApplicationGestureの値がDoubleTapの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenDoubleTap
        {
            get
            {
                return _convertBackWhenDoubleTap;
            }
            set
            {
                _convertBackWhenDoubleTap = value;
                _isConvertBackWhenDoubleTapSet = true;
            }
        }
    }
}