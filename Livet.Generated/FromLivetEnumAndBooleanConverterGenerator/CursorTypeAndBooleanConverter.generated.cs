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
    /// CursorType列挙体とbool値の相互変換を行うIValueConverterです。
    /// </summary>
    public class CursorTypeAndBooleanConverter : IValueConverter
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
        private CursorType _convertWhenTrue;
		/// <summary>
        /// ソース値がTrueの際にどのCursorType列挙体メンバーに変換するかを指定、または取得します。
        /// </summary>
        public CursorType ConvertWhenTrue
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
        private CursorType _convertWhenFalse;
		/// <summary>
        /// ソース値がFalseの際にどのCursorType列挙体メンバーに変換するかを指定、または取得します。
        /// </summary>
        public CursorType ConvertWhenFalse
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
            if (!(value is CursorType)) throw new ArgumentException();

            var enumValue = (CursorType)value;

			switch(enumValue.ToString())
			{
				case "None":
					if (_isConvertBackWhenNoneSet)
					{
						return ConvertBackWhenNone;
					}
					break;
				case "No":
					if (_isConvertBackWhenNoSet)
					{
						return ConvertBackWhenNo;
					}
					break;
				case "Arrow":
					if (_isConvertBackWhenArrowSet)
					{
						return ConvertBackWhenArrow;
					}
					break;
				case "AppStarting":
					if (_isConvertBackWhenAppStartingSet)
					{
						return ConvertBackWhenAppStarting;
					}
					break;
				case "Cross":
					if (_isConvertBackWhenCrossSet)
					{
						return ConvertBackWhenCross;
					}
					break;
				case "Help":
					if (_isConvertBackWhenHelpSet)
					{
						return ConvertBackWhenHelp;
					}
					break;
				case "IBeam":
					if (_isConvertBackWhenIBeamSet)
					{
						return ConvertBackWhenIBeam;
					}
					break;
				case "SizeAll":
					if (_isConvertBackWhenSizeAllSet)
					{
						return ConvertBackWhenSizeAll;
					}
					break;
				case "SizeNESW":
					if (_isConvertBackWhenSizeNESWSet)
					{
						return ConvertBackWhenSizeNESW;
					}
					break;
				case "SizeNS":
					if (_isConvertBackWhenSizeNSSet)
					{
						return ConvertBackWhenSizeNS;
					}
					break;
				case "SizeNWSE":
					if (_isConvertBackWhenSizeNWSESet)
					{
						return ConvertBackWhenSizeNWSE;
					}
					break;
				case "SizeWE":
					if (_isConvertBackWhenSizeWESet)
					{
						return ConvertBackWhenSizeWE;
					}
					break;
				case "UpArrow":
					if (_isConvertBackWhenUpArrowSet)
					{
						return ConvertBackWhenUpArrow;
					}
					break;
				case "Wait":
					if (_isConvertBackWhenWaitSet)
					{
						return ConvertBackWhenWait;
					}
					break;
				case "Hand":
					if (_isConvertBackWhenHandSet)
					{
						return ConvertBackWhenHand;
					}
					break;
				case "Pen":
					if (_isConvertBackWhenPenSet)
					{
						return ConvertBackWhenPen;
					}
					break;
				case "ScrollNS":
					if (_isConvertBackWhenScrollNSSet)
					{
						return ConvertBackWhenScrollNS;
					}
					break;
				case "ScrollWE":
					if (_isConvertBackWhenScrollWESet)
					{
						return ConvertBackWhenScrollWE;
					}
					break;
				case "ScrollAll":
					if (_isConvertBackWhenScrollAllSet)
					{
						return ConvertBackWhenScrollAll;
					}
					break;
				case "ScrollN":
					if (_isConvertBackWhenScrollNSet)
					{
						return ConvertBackWhenScrollN;
					}
					break;
				case "ScrollS":
					if (_isConvertBackWhenScrollSSet)
					{
						return ConvertBackWhenScrollS;
					}
					break;
				case "ScrollW":
					if (_isConvertBackWhenScrollWSet)
					{
						return ConvertBackWhenScrollW;
					}
					break;
				case "ScrollE":
					if (_isConvertBackWhenScrollESet)
					{
						return ConvertBackWhenScrollE;
					}
					break;
				case "ScrollNW":
					if (_isConvertBackWhenScrollNWSet)
					{
						return ConvertBackWhenScrollNW;
					}
					break;
				case "ScrollNE":
					if (_isConvertBackWhenScrollNESet)
					{
						return ConvertBackWhenScrollNE;
					}
					break;
				case "ScrollSW":
					if (_isConvertBackWhenScrollSWSet)
					{
						return ConvertBackWhenScrollSW;
					}
					break;
				case "ScrollSE":
					if (_isConvertBackWhenScrollSESet)
					{
						return ConvertBackWhenScrollSE;
					}
					break;
				case "ArrowCD":
					if (_isConvertBackWhenArrowCDSet)
					{
						return ConvertBackWhenArrowCD;
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
        /// CursorTypeの値をbool値に変換する際のデフォルト値を指定、または取得します。
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
        /// CursorTypeの値がNoneの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
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
        private bool _isConvertBackWhenNoSet;
        private bool _convertBackWhenNo;
		/// <summary>
        /// CursorTypeの値がNoの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenNo
        {
            get
            {
                return _convertBackWhenNo;
            }
            set
            {
                _convertBackWhenNo = value;
                _isConvertBackWhenNoSet = true;
            }
        }
        private bool _isConvertBackWhenArrowSet;
        private bool _convertBackWhenArrow;
		/// <summary>
        /// CursorTypeの値がArrowの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenArrow
        {
            get
            {
                return _convertBackWhenArrow;
            }
            set
            {
                _convertBackWhenArrow = value;
                _isConvertBackWhenArrowSet = true;
            }
        }
        private bool _isConvertBackWhenAppStartingSet;
        private bool _convertBackWhenAppStarting;
		/// <summary>
        /// CursorTypeの値がAppStartingの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenAppStarting
        {
            get
            {
                return _convertBackWhenAppStarting;
            }
            set
            {
                _convertBackWhenAppStarting = value;
                _isConvertBackWhenAppStartingSet = true;
            }
        }
        private bool _isConvertBackWhenCrossSet;
        private bool _convertBackWhenCross;
		/// <summary>
        /// CursorTypeの値がCrossの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenCross
        {
            get
            {
                return _convertBackWhenCross;
            }
            set
            {
                _convertBackWhenCross = value;
                _isConvertBackWhenCrossSet = true;
            }
        }
        private bool _isConvertBackWhenHelpSet;
        private bool _convertBackWhenHelp;
		/// <summary>
        /// CursorTypeの値がHelpの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenHelp
        {
            get
            {
                return _convertBackWhenHelp;
            }
            set
            {
                _convertBackWhenHelp = value;
                _isConvertBackWhenHelpSet = true;
            }
        }
        private bool _isConvertBackWhenIBeamSet;
        private bool _convertBackWhenIBeam;
		/// <summary>
        /// CursorTypeの値がIBeamの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenIBeam
        {
            get
            {
                return _convertBackWhenIBeam;
            }
            set
            {
                _convertBackWhenIBeam = value;
                _isConvertBackWhenIBeamSet = true;
            }
        }
        private bool _isConvertBackWhenSizeAllSet;
        private bool _convertBackWhenSizeAll;
		/// <summary>
        /// CursorTypeの値がSizeAllの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenSizeAll
        {
            get
            {
                return _convertBackWhenSizeAll;
            }
            set
            {
                _convertBackWhenSizeAll = value;
                _isConvertBackWhenSizeAllSet = true;
            }
        }
        private bool _isConvertBackWhenSizeNESWSet;
        private bool _convertBackWhenSizeNESW;
		/// <summary>
        /// CursorTypeの値がSizeNESWの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenSizeNESW
        {
            get
            {
                return _convertBackWhenSizeNESW;
            }
            set
            {
                _convertBackWhenSizeNESW = value;
                _isConvertBackWhenSizeNESWSet = true;
            }
        }
        private bool _isConvertBackWhenSizeNSSet;
        private bool _convertBackWhenSizeNS;
		/// <summary>
        /// CursorTypeの値がSizeNSの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenSizeNS
        {
            get
            {
                return _convertBackWhenSizeNS;
            }
            set
            {
                _convertBackWhenSizeNS = value;
                _isConvertBackWhenSizeNSSet = true;
            }
        }
        private bool _isConvertBackWhenSizeNWSESet;
        private bool _convertBackWhenSizeNWSE;
		/// <summary>
        /// CursorTypeの値がSizeNWSEの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenSizeNWSE
        {
            get
            {
                return _convertBackWhenSizeNWSE;
            }
            set
            {
                _convertBackWhenSizeNWSE = value;
                _isConvertBackWhenSizeNWSESet = true;
            }
        }
        private bool _isConvertBackWhenSizeWESet;
        private bool _convertBackWhenSizeWE;
		/// <summary>
        /// CursorTypeの値がSizeWEの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenSizeWE
        {
            get
            {
                return _convertBackWhenSizeWE;
            }
            set
            {
                _convertBackWhenSizeWE = value;
                _isConvertBackWhenSizeWESet = true;
            }
        }
        private bool _isConvertBackWhenUpArrowSet;
        private bool _convertBackWhenUpArrow;
		/// <summary>
        /// CursorTypeの値がUpArrowの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenUpArrow
        {
            get
            {
                return _convertBackWhenUpArrow;
            }
            set
            {
                _convertBackWhenUpArrow = value;
                _isConvertBackWhenUpArrowSet = true;
            }
        }
        private bool _isConvertBackWhenWaitSet;
        private bool _convertBackWhenWait;
		/// <summary>
        /// CursorTypeの値がWaitの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenWait
        {
            get
            {
                return _convertBackWhenWait;
            }
            set
            {
                _convertBackWhenWait = value;
                _isConvertBackWhenWaitSet = true;
            }
        }
        private bool _isConvertBackWhenHandSet;
        private bool _convertBackWhenHand;
		/// <summary>
        /// CursorTypeの値がHandの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenHand
        {
            get
            {
                return _convertBackWhenHand;
            }
            set
            {
                _convertBackWhenHand = value;
                _isConvertBackWhenHandSet = true;
            }
        }
        private bool _isConvertBackWhenPenSet;
        private bool _convertBackWhenPen;
		/// <summary>
        /// CursorTypeの値がPenの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenPen
        {
            get
            {
                return _convertBackWhenPen;
            }
            set
            {
                _convertBackWhenPen = value;
                _isConvertBackWhenPenSet = true;
            }
        }
        private bool _isConvertBackWhenScrollNSSet;
        private bool _convertBackWhenScrollNS;
		/// <summary>
        /// CursorTypeの値がScrollNSの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenScrollNS
        {
            get
            {
                return _convertBackWhenScrollNS;
            }
            set
            {
                _convertBackWhenScrollNS = value;
                _isConvertBackWhenScrollNSSet = true;
            }
        }
        private bool _isConvertBackWhenScrollWESet;
        private bool _convertBackWhenScrollWE;
		/// <summary>
        /// CursorTypeの値がScrollWEの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenScrollWE
        {
            get
            {
                return _convertBackWhenScrollWE;
            }
            set
            {
                _convertBackWhenScrollWE = value;
                _isConvertBackWhenScrollWESet = true;
            }
        }
        private bool _isConvertBackWhenScrollAllSet;
        private bool _convertBackWhenScrollAll;
		/// <summary>
        /// CursorTypeの値がScrollAllの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenScrollAll
        {
            get
            {
                return _convertBackWhenScrollAll;
            }
            set
            {
                _convertBackWhenScrollAll = value;
                _isConvertBackWhenScrollAllSet = true;
            }
        }
        private bool _isConvertBackWhenScrollNSet;
        private bool _convertBackWhenScrollN;
		/// <summary>
        /// CursorTypeの値がScrollNの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenScrollN
        {
            get
            {
                return _convertBackWhenScrollN;
            }
            set
            {
                _convertBackWhenScrollN = value;
                _isConvertBackWhenScrollNSet = true;
            }
        }
        private bool _isConvertBackWhenScrollSSet;
        private bool _convertBackWhenScrollS;
		/// <summary>
        /// CursorTypeの値がScrollSの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenScrollS
        {
            get
            {
                return _convertBackWhenScrollS;
            }
            set
            {
                _convertBackWhenScrollS = value;
                _isConvertBackWhenScrollSSet = true;
            }
        }
        private bool _isConvertBackWhenScrollWSet;
        private bool _convertBackWhenScrollW;
		/// <summary>
        /// CursorTypeの値がScrollWの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenScrollW
        {
            get
            {
                return _convertBackWhenScrollW;
            }
            set
            {
                _convertBackWhenScrollW = value;
                _isConvertBackWhenScrollWSet = true;
            }
        }
        private bool _isConvertBackWhenScrollESet;
        private bool _convertBackWhenScrollE;
		/// <summary>
        /// CursorTypeの値がScrollEの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenScrollE
        {
            get
            {
                return _convertBackWhenScrollE;
            }
            set
            {
                _convertBackWhenScrollE = value;
                _isConvertBackWhenScrollESet = true;
            }
        }
        private bool _isConvertBackWhenScrollNWSet;
        private bool _convertBackWhenScrollNW;
		/// <summary>
        /// CursorTypeの値がScrollNWの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenScrollNW
        {
            get
            {
                return _convertBackWhenScrollNW;
            }
            set
            {
                _convertBackWhenScrollNW = value;
                _isConvertBackWhenScrollNWSet = true;
            }
        }
        private bool _isConvertBackWhenScrollNESet;
        private bool _convertBackWhenScrollNE;
		/// <summary>
        /// CursorTypeの値がScrollNEの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenScrollNE
        {
            get
            {
                return _convertBackWhenScrollNE;
            }
            set
            {
                _convertBackWhenScrollNE = value;
                _isConvertBackWhenScrollNESet = true;
            }
        }
        private bool _isConvertBackWhenScrollSWSet;
        private bool _convertBackWhenScrollSW;
		/// <summary>
        /// CursorTypeの値がScrollSWの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenScrollSW
        {
            get
            {
                return _convertBackWhenScrollSW;
            }
            set
            {
                _convertBackWhenScrollSW = value;
                _isConvertBackWhenScrollSWSet = true;
            }
        }
        private bool _isConvertBackWhenScrollSESet;
        private bool _convertBackWhenScrollSE;
		/// <summary>
        /// CursorTypeの値がScrollSEの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenScrollSE
        {
            get
            {
                return _convertBackWhenScrollSE;
            }
            set
            {
                _convertBackWhenScrollSE = value;
                _isConvertBackWhenScrollSESet = true;
            }
        }
        private bool _isConvertBackWhenArrowCDSet;
        private bool _convertBackWhenArrowCD;
		/// <summary>
        /// CursorTypeの値がArrowCDの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenArrowCD
        {
            get
            {
                return _convertBackWhenArrowCD;
            }
            set
            {
                _convertBackWhenArrowCD = value;
                _isConvertBackWhenArrowCDSet = true;
            }
        }
    }
}