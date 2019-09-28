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
    /// Key列挙体とbool値の相互変換を行うIValueConverterです。
    /// </summary>
    public class KeyAndBooleanConverter : IValueConverter
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
        private Key _convertWhenTrue;
		/// <summary>
        /// ソース値がTrueの際にどのKey列挙体メンバーに変換するかを指定、または取得します。
        /// </summary>
        public Key ConvertWhenTrue
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
        private Key _convertWhenFalse;
		/// <summary>
        /// ソース値がFalseの際にどのKey列挙体メンバーに変換するかを指定、または取得します。
        /// </summary>
        public Key ConvertWhenFalse
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
            if (!(value is Key)) throw new ArgumentException();

            var enumValue = (Key)value;

			switch(enumValue.ToString())
			{
				case "None":
					if (_isConvertBackWhenNoneSet)
					{
						return ConvertBackWhenNone;
					}
					break;
				case "Cancel":
					if (_isConvertBackWhenCancelSet)
					{
						return ConvertBackWhenCancel;
					}
					break;
				case "Back":
					if (_isConvertBackWhenBackSet)
					{
						return ConvertBackWhenBack;
					}
					break;
				case "Tab":
					if (_isConvertBackWhenTabSet)
					{
						return ConvertBackWhenTab;
					}
					break;
				case "LineFeed":
					if (_isConvertBackWhenLineFeedSet)
					{
						return ConvertBackWhenLineFeed;
					}
					break;
				case "Clear":
					if (_isConvertBackWhenClearSet)
					{
						return ConvertBackWhenClear;
					}
					break;
				case "Return":
					if (_isConvertBackWhenReturnSet)
					{
						return ConvertBackWhenReturn;
					}
					break;
				case "Enter":
					if (_isConvertBackWhenEnterSet)
					{
						return ConvertBackWhenEnter;
					}
					break;
				case "Pause":
					if (_isConvertBackWhenPauseSet)
					{
						return ConvertBackWhenPause;
					}
					break;
				case "Capital":
					if (_isConvertBackWhenCapitalSet)
					{
						return ConvertBackWhenCapital;
					}
					break;
				case "CapsLock":
					if (_isConvertBackWhenCapsLockSet)
					{
						return ConvertBackWhenCapsLock;
					}
					break;
				case "KanaMode":
					if (_isConvertBackWhenKanaModeSet)
					{
						return ConvertBackWhenKanaMode;
					}
					break;
				case "HangulMode":
					if (_isConvertBackWhenHangulModeSet)
					{
						return ConvertBackWhenHangulMode;
					}
					break;
				case "JunjaMode":
					if (_isConvertBackWhenJunjaModeSet)
					{
						return ConvertBackWhenJunjaMode;
					}
					break;
				case "FinalMode":
					if (_isConvertBackWhenFinalModeSet)
					{
						return ConvertBackWhenFinalMode;
					}
					break;
				case "HanjaMode":
					if (_isConvertBackWhenHanjaModeSet)
					{
						return ConvertBackWhenHanjaMode;
					}
					break;
				case "KanjiMode":
					if (_isConvertBackWhenKanjiModeSet)
					{
						return ConvertBackWhenKanjiMode;
					}
					break;
				case "Escape":
					if (_isConvertBackWhenEscapeSet)
					{
						return ConvertBackWhenEscape;
					}
					break;
				case "ImeConvert":
					if (_isConvertBackWhenImeConvertSet)
					{
						return ConvertBackWhenImeConvert;
					}
					break;
				case "ImeNonConvert":
					if (_isConvertBackWhenImeNonConvertSet)
					{
						return ConvertBackWhenImeNonConvert;
					}
					break;
				case "ImeAccept":
					if (_isConvertBackWhenImeAcceptSet)
					{
						return ConvertBackWhenImeAccept;
					}
					break;
				case "ImeModeChange":
					if (_isConvertBackWhenImeModeChangeSet)
					{
						return ConvertBackWhenImeModeChange;
					}
					break;
				case "Space":
					if (_isConvertBackWhenSpaceSet)
					{
						return ConvertBackWhenSpace;
					}
					break;
				case "Prior":
					if (_isConvertBackWhenPriorSet)
					{
						return ConvertBackWhenPrior;
					}
					break;
				case "PageUp":
					if (_isConvertBackWhenPageUpSet)
					{
						return ConvertBackWhenPageUp;
					}
					break;
				case "Next":
					if (_isConvertBackWhenNextSet)
					{
						return ConvertBackWhenNext;
					}
					break;
				case "PageDown":
					if (_isConvertBackWhenPageDownSet)
					{
						return ConvertBackWhenPageDown;
					}
					break;
				case "End":
					if (_isConvertBackWhenEndSet)
					{
						return ConvertBackWhenEnd;
					}
					break;
				case "Home":
					if (_isConvertBackWhenHomeSet)
					{
						return ConvertBackWhenHome;
					}
					break;
				case "Left":
					if (_isConvertBackWhenLeftSet)
					{
						return ConvertBackWhenLeft;
					}
					break;
				case "Up":
					if (_isConvertBackWhenUpSet)
					{
						return ConvertBackWhenUp;
					}
					break;
				case "Right":
					if (_isConvertBackWhenRightSet)
					{
						return ConvertBackWhenRight;
					}
					break;
				case "Down":
					if (_isConvertBackWhenDownSet)
					{
						return ConvertBackWhenDown;
					}
					break;
				case "Select":
					if (_isConvertBackWhenSelectSet)
					{
						return ConvertBackWhenSelect;
					}
					break;
				case "Print":
					if (_isConvertBackWhenPrintSet)
					{
						return ConvertBackWhenPrint;
					}
					break;
				case "Execute":
					if (_isConvertBackWhenExecuteSet)
					{
						return ConvertBackWhenExecute;
					}
					break;
				case "Snapshot":
					if (_isConvertBackWhenSnapshotSet)
					{
						return ConvertBackWhenSnapshot;
					}
					break;
				case "PrintScreen":
					if (_isConvertBackWhenPrintScreenSet)
					{
						return ConvertBackWhenPrintScreen;
					}
					break;
				case "Insert":
					if (_isConvertBackWhenInsertSet)
					{
						return ConvertBackWhenInsert;
					}
					break;
				case "Delete":
					if (_isConvertBackWhenDeleteSet)
					{
						return ConvertBackWhenDelete;
					}
					break;
				case "Help":
					if (_isConvertBackWhenHelpSet)
					{
						return ConvertBackWhenHelp;
					}
					break;
				case "D0":
					if (_isConvertBackWhenD0Set)
					{
						return ConvertBackWhenD0;
					}
					break;
				case "D1":
					if (_isConvertBackWhenD1Set)
					{
						return ConvertBackWhenD1;
					}
					break;
				case "D2":
					if (_isConvertBackWhenD2Set)
					{
						return ConvertBackWhenD2;
					}
					break;
				case "D3":
					if (_isConvertBackWhenD3Set)
					{
						return ConvertBackWhenD3;
					}
					break;
				case "D4":
					if (_isConvertBackWhenD4Set)
					{
						return ConvertBackWhenD4;
					}
					break;
				case "D5":
					if (_isConvertBackWhenD5Set)
					{
						return ConvertBackWhenD5;
					}
					break;
				case "D6":
					if (_isConvertBackWhenD6Set)
					{
						return ConvertBackWhenD6;
					}
					break;
				case "D7":
					if (_isConvertBackWhenD7Set)
					{
						return ConvertBackWhenD7;
					}
					break;
				case "D8":
					if (_isConvertBackWhenD8Set)
					{
						return ConvertBackWhenD8;
					}
					break;
				case "D9":
					if (_isConvertBackWhenD9Set)
					{
						return ConvertBackWhenD9;
					}
					break;
				case "A":
					if (_isConvertBackWhenASet)
					{
						return ConvertBackWhenA;
					}
					break;
				case "B":
					if (_isConvertBackWhenBSet)
					{
						return ConvertBackWhenB;
					}
					break;
				case "C":
					if (_isConvertBackWhenCSet)
					{
						return ConvertBackWhenC;
					}
					break;
				case "D":
					if (_isConvertBackWhenDSet)
					{
						return ConvertBackWhenD;
					}
					break;
				case "E":
					if (_isConvertBackWhenESet)
					{
						return ConvertBackWhenE;
					}
					break;
				case "F":
					if (_isConvertBackWhenFSet)
					{
						return ConvertBackWhenF;
					}
					break;
				case "G":
					if (_isConvertBackWhenGSet)
					{
						return ConvertBackWhenG;
					}
					break;
				case "H":
					if (_isConvertBackWhenHSet)
					{
						return ConvertBackWhenH;
					}
					break;
				case "I":
					if (_isConvertBackWhenISet)
					{
						return ConvertBackWhenI;
					}
					break;
				case "J":
					if (_isConvertBackWhenJSet)
					{
						return ConvertBackWhenJ;
					}
					break;
				case "K":
					if (_isConvertBackWhenKSet)
					{
						return ConvertBackWhenK;
					}
					break;
				case "L":
					if (_isConvertBackWhenLSet)
					{
						return ConvertBackWhenL;
					}
					break;
				case "M":
					if (_isConvertBackWhenMSet)
					{
						return ConvertBackWhenM;
					}
					break;
				case "N":
					if (_isConvertBackWhenNSet)
					{
						return ConvertBackWhenN;
					}
					break;
				case "O":
					if (_isConvertBackWhenOSet)
					{
						return ConvertBackWhenO;
					}
					break;
				case "P":
					if (_isConvertBackWhenPSet)
					{
						return ConvertBackWhenP;
					}
					break;
				case "Q":
					if (_isConvertBackWhenQSet)
					{
						return ConvertBackWhenQ;
					}
					break;
				case "R":
					if (_isConvertBackWhenRSet)
					{
						return ConvertBackWhenR;
					}
					break;
				case "S":
					if (_isConvertBackWhenSSet)
					{
						return ConvertBackWhenS;
					}
					break;
				case "T":
					if (_isConvertBackWhenTSet)
					{
						return ConvertBackWhenT;
					}
					break;
				case "U":
					if (_isConvertBackWhenUSet)
					{
						return ConvertBackWhenU;
					}
					break;
				case "V":
					if (_isConvertBackWhenVSet)
					{
						return ConvertBackWhenV;
					}
					break;
				case "W":
					if (_isConvertBackWhenWSet)
					{
						return ConvertBackWhenW;
					}
					break;
				case "X":
					if (_isConvertBackWhenXSet)
					{
						return ConvertBackWhenX;
					}
					break;
				case "Y":
					if (_isConvertBackWhenYSet)
					{
						return ConvertBackWhenY;
					}
					break;
				case "Z":
					if (_isConvertBackWhenZSet)
					{
						return ConvertBackWhenZ;
					}
					break;
				case "LWin":
					if (_isConvertBackWhenLWinSet)
					{
						return ConvertBackWhenLWin;
					}
					break;
				case "RWin":
					if (_isConvertBackWhenRWinSet)
					{
						return ConvertBackWhenRWin;
					}
					break;
				case "Apps":
					if (_isConvertBackWhenAppsSet)
					{
						return ConvertBackWhenApps;
					}
					break;
				case "Sleep":
					if (_isConvertBackWhenSleepSet)
					{
						return ConvertBackWhenSleep;
					}
					break;
				case "NumPad0":
					if (_isConvertBackWhenNumPad0Set)
					{
						return ConvertBackWhenNumPad0;
					}
					break;
				case "NumPad1":
					if (_isConvertBackWhenNumPad1Set)
					{
						return ConvertBackWhenNumPad1;
					}
					break;
				case "NumPad2":
					if (_isConvertBackWhenNumPad2Set)
					{
						return ConvertBackWhenNumPad2;
					}
					break;
				case "NumPad3":
					if (_isConvertBackWhenNumPad3Set)
					{
						return ConvertBackWhenNumPad3;
					}
					break;
				case "NumPad4":
					if (_isConvertBackWhenNumPad4Set)
					{
						return ConvertBackWhenNumPad4;
					}
					break;
				case "NumPad5":
					if (_isConvertBackWhenNumPad5Set)
					{
						return ConvertBackWhenNumPad5;
					}
					break;
				case "NumPad6":
					if (_isConvertBackWhenNumPad6Set)
					{
						return ConvertBackWhenNumPad6;
					}
					break;
				case "NumPad7":
					if (_isConvertBackWhenNumPad7Set)
					{
						return ConvertBackWhenNumPad7;
					}
					break;
				case "NumPad8":
					if (_isConvertBackWhenNumPad8Set)
					{
						return ConvertBackWhenNumPad8;
					}
					break;
				case "NumPad9":
					if (_isConvertBackWhenNumPad9Set)
					{
						return ConvertBackWhenNumPad9;
					}
					break;
				case "Multiply":
					if (_isConvertBackWhenMultiplySet)
					{
						return ConvertBackWhenMultiply;
					}
					break;
				case "Add":
					if (_isConvertBackWhenAddSet)
					{
						return ConvertBackWhenAdd;
					}
					break;
				case "Separator":
					if (_isConvertBackWhenSeparatorSet)
					{
						return ConvertBackWhenSeparator;
					}
					break;
				case "Subtract":
					if (_isConvertBackWhenSubtractSet)
					{
						return ConvertBackWhenSubtract;
					}
					break;
				case "Decimal":
					if (_isConvertBackWhenDecimalSet)
					{
						return ConvertBackWhenDecimal;
					}
					break;
				case "Divide":
					if (_isConvertBackWhenDivideSet)
					{
						return ConvertBackWhenDivide;
					}
					break;
				case "F1":
					if (_isConvertBackWhenF1Set)
					{
						return ConvertBackWhenF1;
					}
					break;
				case "F2":
					if (_isConvertBackWhenF2Set)
					{
						return ConvertBackWhenF2;
					}
					break;
				case "F3":
					if (_isConvertBackWhenF3Set)
					{
						return ConvertBackWhenF3;
					}
					break;
				case "F4":
					if (_isConvertBackWhenF4Set)
					{
						return ConvertBackWhenF4;
					}
					break;
				case "F5":
					if (_isConvertBackWhenF5Set)
					{
						return ConvertBackWhenF5;
					}
					break;
				case "F6":
					if (_isConvertBackWhenF6Set)
					{
						return ConvertBackWhenF6;
					}
					break;
				case "F7":
					if (_isConvertBackWhenF7Set)
					{
						return ConvertBackWhenF7;
					}
					break;
				case "F8":
					if (_isConvertBackWhenF8Set)
					{
						return ConvertBackWhenF8;
					}
					break;
				case "F9":
					if (_isConvertBackWhenF9Set)
					{
						return ConvertBackWhenF9;
					}
					break;
				case "F10":
					if (_isConvertBackWhenF10Set)
					{
						return ConvertBackWhenF10;
					}
					break;
				case "F11":
					if (_isConvertBackWhenF11Set)
					{
						return ConvertBackWhenF11;
					}
					break;
				case "F12":
					if (_isConvertBackWhenF12Set)
					{
						return ConvertBackWhenF12;
					}
					break;
				case "F13":
					if (_isConvertBackWhenF13Set)
					{
						return ConvertBackWhenF13;
					}
					break;
				case "F14":
					if (_isConvertBackWhenF14Set)
					{
						return ConvertBackWhenF14;
					}
					break;
				case "F15":
					if (_isConvertBackWhenF15Set)
					{
						return ConvertBackWhenF15;
					}
					break;
				case "F16":
					if (_isConvertBackWhenF16Set)
					{
						return ConvertBackWhenF16;
					}
					break;
				case "F17":
					if (_isConvertBackWhenF17Set)
					{
						return ConvertBackWhenF17;
					}
					break;
				case "F18":
					if (_isConvertBackWhenF18Set)
					{
						return ConvertBackWhenF18;
					}
					break;
				case "F19":
					if (_isConvertBackWhenF19Set)
					{
						return ConvertBackWhenF19;
					}
					break;
				case "F20":
					if (_isConvertBackWhenF20Set)
					{
						return ConvertBackWhenF20;
					}
					break;
				case "F21":
					if (_isConvertBackWhenF21Set)
					{
						return ConvertBackWhenF21;
					}
					break;
				case "F22":
					if (_isConvertBackWhenF22Set)
					{
						return ConvertBackWhenF22;
					}
					break;
				case "F23":
					if (_isConvertBackWhenF23Set)
					{
						return ConvertBackWhenF23;
					}
					break;
				case "F24":
					if (_isConvertBackWhenF24Set)
					{
						return ConvertBackWhenF24;
					}
					break;
				case "NumLock":
					if (_isConvertBackWhenNumLockSet)
					{
						return ConvertBackWhenNumLock;
					}
					break;
				case "Scroll":
					if (_isConvertBackWhenScrollSet)
					{
						return ConvertBackWhenScroll;
					}
					break;
				case "LeftShift":
					if (_isConvertBackWhenLeftShiftSet)
					{
						return ConvertBackWhenLeftShift;
					}
					break;
				case "RightShift":
					if (_isConvertBackWhenRightShiftSet)
					{
						return ConvertBackWhenRightShift;
					}
					break;
				case "LeftCtrl":
					if (_isConvertBackWhenLeftCtrlSet)
					{
						return ConvertBackWhenLeftCtrl;
					}
					break;
				case "RightCtrl":
					if (_isConvertBackWhenRightCtrlSet)
					{
						return ConvertBackWhenRightCtrl;
					}
					break;
				case "LeftAlt":
					if (_isConvertBackWhenLeftAltSet)
					{
						return ConvertBackWhenLeftAlt;
					}
					break;
				case "RightAlt":
					if (_isConvertBackWhenRightAltSet)
					{
						return ConvertBackWhenRightAlt;
					}
					break;
				case "BrowserBack":
					if (_isConvertBackWhenBrowserBackSet)
					{
						return ConvertBackWhenBrowserBack;
					}
					break;
				case "BrowserForward":
					if (_isConvertBackWhenBrowserForwardSet)
					{
						return ConvertBackWhenBrowserForward;
					}
					break;
				case "BrowserRefresh":
					if (_isConvertBackWhenBrowserRefreshSet)
					{
						return ConvertBackWhenBrowserRefresh;
					}
					break;
				case "BrowserStop":
					if (_isConvertBackWhenBrowserStopSet)
					{
						return ConvertBackWhenBrowserStop;
					}
					break;
				case "BrowserSearch":
					if (_isConvertBackWhenBrowserSearchSet)
					{
						return ConvertBackWhenBrowserSearch;
					}
					break;
				case "BrowserFavorites":
					if (_isConvertBackWhenBrowserFavoritesSet)
					{
						return ConvertBackWhenBrowserFavorites;
					}
					break;
				case "BrowserHome":
					if (_isConvertBackWhenBrowserHomeSet)
					{
						return ConvertBackWhenBrowserHome;
					}
					break;
				case "VolumeMute":
					if (_isConvertBackWhenVolumeMuteSet)
					{
						return ConvertBackWhenVolumeMute;
					}
					break;
				case "VolumeDown":
					if (_isConvertBackWhenVolumeDownSet)
					{
						return ConvertBackWhenVolumeDown;
					}
					break;
				case "VolumeUp":
					if (_isConvertBackWhenVolumeUpSet)
					{
						return ConvertBackWhenVolumeUp;
					}
					break;
				case "MediaNextTrack":
					if (_isConvertBackWhenMediaNextTrackSet)
					{
						return ConvertBackWhenMediaNextTrack;
					}
					break;
				case "MediaPreviousTrack":
					if (_isConvertBackWhenMediaPreviousTrackSet)
					{
						return ConvertBackWhenMediaPreviousTrack;
					}
					break;
				case "MediaStop":
					if (_isConvertBackWhenMediaStopSet)
					{
						return ConvertBackWhenMediaStop;
					}
					break;
				case "MediaPlayPause":
					if (_isConvertBackWhenMediaPlayPauseSet)
					{
						return ConvertBackWhenMediaPlayPause;
					}
					break;
				case "LaunchMail":
					if (_isConvertBackWhenLaunchMailSet)
					{
						return ConvertBackWhenLaunchMail;
					}
					break;
				case "SelectMedia":
					if (_isConvertBackWhenSelectMediaSet)
					{
						return ConvertBackWhenSelectMedia;
					}
					break;
				case "LaunchApplication1":
					if (_isConvertBackWhenLaunchApplication1Set)
					{
						return ConvertBackWhenLaunchApplication1;
					}
					break;
				case "LaunchApplication2":
					if (_isConvertBackWhenLaunchApplication2Set)
					{
						return ConvertBackWhenLaunchApplication2;
					}
					break;
				case "Oem1":
					if (_isConvertBackWhenOem1Set)
					{
						return ConvertBackWhenOem1;
					}
					break;
				case "OemSemicolon":
					if (_isConvertBackWhenOemSemicolonSet)
					{
						return ConvertBackWhenOemSemicolon;
					}
					break;
				case "OemPlus":
					if (_isConvertBackWhenOemPlusSet)
					{
						return ConvertBackWhenOemPlus;
					}
					break;
				case "OemComma":
					if (_isConvertBackWhenOemCommaSet)
					{
						return ConvertBackWhenOemComma;
					}
					break;
				case "OemMinus":
					if (_isConvertBackWhenOemMinusSet)
					{
						return ConvertBackWhenOemMinus;
					}
					break;
				case "OemPeriod":
					if (_isConvertBackWhenOemPeriodSet)
					{
						return ConvertBackWhenOemPeriod;
					}
					break;
				case "Oem2":
					if (_isConvertBackWhenOem2Set)
					{
						return ConvertBackWhenOem2;
					}
					break;
				case "OemQuestion":
					if (_isConvertBackWhenOemQuestionSet)
					{
						return ConvertBackWhenOemQuestion;
					}
					break;
				case "Oem3":
					if (_isConvertBackWhenOem3Set)
					{
						return ConvertBackWhenOem3;
					}
					break;
				case "OemTilde":
					if (_isConvertBackWhenOemTildeSet)
					{
						return ConvertBackWhenOemTilde;
					}
					break;
				case "AbntC1":
					if (_isConvertBackWhenAbntC1Set)
					{
						return ConvertBackWhenAbntC1;
					}
					break;
				case "AbntC2":
					if (_isConvertBackWhenAbntC2Set)
					{
						return ConvertBackWhenAbntC2;
					}
					break;
				case "Oem4":
					if (_isConvertBackWhenOem4Set)
					{
						return ConvertBackWhenOem4;
					}
					break;
				case "OemOpenBrackets":
					if (_isConvertBackWhenOemOpenBracketsSet)
					{
						return ConvertBackWhenOemOpenBrackets;
					}
					break;
				case "Oem5":
					if (_isConvertBackWhenOem5Set)
					{
						return ConvertBackWhenOem5;
					}
					break;
				case "OemPipe":
					if (_isConvertBackWhenOemPipeSet)
					{
						return ConvertBackWhenOemPipe;
					}
					break;
				case "Oem6":
					if (_isConvertBackWhenOem6Set)
					{
						return ConvertBackWhenOem6;
					}
					break;
				case "OemCloseBrackets":
					if (_isConvertBackWhenOemCloseBracketsSet)
					{
						return ConvertBackWhenOemCloseBrackets;
					}
					break;
				case "Oem7":
					if (_isConvertBackWhenOem7Set)
					{
						return ConvertBackWhenOem7;
					}
					break;
				case "OemQuotes":
					if (_isConvertBackWhenOemQuotesSet)
					{
						return ConvertBackWhenOemQuotes;
					}
					break;
				case "Oem8":
					if (_isConvertBackWhenOem8Set)
					{
						return ConvertBackWhenOem8;
					}
					break;
				case "Oem102":
					if (_isConvertBackWhenOem102Set)
					{
						return ConvertBackWhenOem102;
					}
					break;
				case "OemBackslash":
					if (_isConvertBackWhenOemBackslashSet)
					{
						return ConvertBackWhenOemBackslash;
					}
					break;
				case "ImeProcessed":
					if (_isConvertBackWhenImeProcessedSet)
					{
						return ConvertBackWhenImeProcessed;
					}
					break;
				case "System":
					if (_isConvertBackWhenSystemSet)
					{
						return ConvertBackWhenSystem;
					}
					break;
				case "OemAttn":
					if (_isConvertBackWhenOemAttnSet)
					{
						return ConvertBackWhenOemAttn;
					}
					break;
				case "DbeAlphanumeric":
					if (_isConvertBackWhenDbeAlphanumericSet)
					{
						return ConvertBackWhenDbeAlphanumeric;
					}
					break;
				case "OemFinish":
					if (_isConvertBackWhenOemFinishSet)
					{
						return ConvertBackWhenOemFinish;
					}
					break;
				case "DbeKatakana":
					if (_isConvertBackWhenDbeKatakanaSet)
					{
						return ConvertBackWhenDbeKatakana;
					}
					break;
				case "OemCopy":
					if (_isConvertBackWhenOemCopySet)
					{
						return ConvertBackWhenOemCopy;
					}
					break;
				case "DbeHiragana":
					if (_isConvertBackWhenDbeHiraganaSet)
					{
						return ConvertBackWhenDbeHiragana;
					}
					break;
				case "OemAuto":
					if (_isConvertBackWhenOemAutoSet)
					{
						return ConvertBackWhenOemAuto;
					}
					break;
				case "DbeSbcsChar":
					if (_isConvertBackWhenDbeSbcsCharSet)
					{
						return ConvertBackWhenDbeSbcsChar;
					}
					break;
				case "OemEnlw":
					if (_isConvertBackWhenOemEnlwSet)
					{
						return ConvertBackWhenOemEnlw;
					}
					break;
				case "DbeDbcsChar":
					if (_isConvertBackWhenDbeDbcsCharSet)
					{
						return ConvertBackWhenDbeDbcsChar;
					}
					break;
				case "OemBackTab":
					if (_isConvertBackWhenOemBackTabSet)
					{
						return ConvertBackWhenOemBackTab;
					}
					break;
				case "DbeRoman":
					if (_isConvertBackWhenDbeRomanSet)
					{
						return ConvertBackWhenDbeRoman;
					}
					break;
				case "Attn":
					if (_isConvertBackWhenAttnSet)
					{
						return ConvertBackWhenAttn;
					}
					break;
				case "DbeNoRoman":
					if (_isConvertBackWhenDbeNoRomanSet)
					{
						return ConvertBackWhenDbeNoRoman;
					}
					break;
				case "CrSel":
					if (_isConvertBackWhenCrSelSet)
					{
						return ConvertBackWhenCrSel;
					}
					break;
				case "DbeEnterWordRegisterMode":
					if (_isConvertBackWhenDbeEnterWordRegisterModeSet)
					{
						return ConvertBackWhenDbeEnterWordRegisterMode;
					}
					break;
				case "ExSel":
					if (_isConvertBackWhenExSelSet)
					{
						return ConvertBackWhenExSel;
					}
					break;
				case "DbeEnterImeConfigureMode":
					if (_isConvertBackWhenDbeEnterImeConfigureModeSet)
					{
						return ConvertBackWhenDbeEnterImeConfigureMode;
					}
					break;
				case "EraseEof":
					if (_isConvertBackWhenEraseEofSet)
					{
						return ConvertBackWhenEraseEof;
					}
					break;
				case "DbeFlushString":
					if (_isConvertBackWhenDbeFlushStringSet)
					{
						return ConvertBackWhenDbeFlushString;
					}
					break;
				case "Play":
					if (_isConvertBackWhenPlaySet)
					{
						return ConvertBackWhenPlay;
					}
					break;
				case "DbeCodeInput":
					if (_isConvertBackWhenDbeCodeInputSet)
					{
						return ConvertBackWhenDbeCodeInput;
					}
					break;
				case "Zoom":
					if (_isConvertBackWhenZoomSet)
					{
						return ConvertBackWhenZoom;
					}
					break;
				case "DbeNoCodeInput":
					if (_isConvertBackWhenDbeNoCodeInputSet)
					{
						return ConvertBackWhenDbeNoCodeInput;
					}
					break;
				case "NoName":
					if (_isConvertBackWhenNoNameSet)
					{
						return ConvertBackWhenNoName;
					}
					break;
				case "DbeDetermineString":
					if (_isConvertBackWhenDbeDetermineStringSet)
					{
						return ConvertBackWhenDbeDetermineString;
					}
					break;
				case "Pa1":
					if (_isConvertBackWhenPa1Set)
					{
						return ConvertBackWhenPa1;
					}
					break;
				case "DbeEnterDialogConversionMode":
					if (_isConvertBackWhenDbeEnterDialogConversionModeSet)
					{
						return ConvertBackWhenDbeEnterDialogConversionMode;
					}
					break;
				case "OemClear":
					if (_isConvertBackWhenOemClearSet)
					{
						return ConvertBackWhenOemClear;
					}
					break;
				case "DeadCharProcessed":
					if (_isConvertBackWhenDeadCharProcessedSet)
					{
						return ConvertBackWhenDeadCharProcessed;
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
        /// Keyの値をbool値に変換する際のデフォルト値を指定、または取得します。
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
        /// Keyの値がNoneの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
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
        private bool _isConvertBackWhenCancelSet;
        private bool _convertBackWhenCancel;
		/// <summary>
        /// Keyの値がCancelの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenCancel
        {
            get
            {
                return _convertBackWhenCancel;
            }
            set
            {
                _convertBackWhenCancel = value;
                _isConvertBackWhenCancelSet = true;
            }
        }
        private bool _isConvertBackWhenBackSet;
        private bool _convertBackWhenBack;
		/// <summary>
        /// Keyの値がBackの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenBack
        {
            get
            {
                return _convertBackWhenBack;
            }
            set
            {
                _convertBackWhenBack = value;
                _isConvertBackWhenBackSet = true;
            }
        }
        private bool _isConvertBackWhenTabSet;
        private bool _convertBackWhenTab;
		/// <summary>
        /// Keyの値がTabの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenTab
        {
            get
            {
                return _convertBackWhenTab;
            }
            set
            {
                _convertBackWhenTab = value;
                _isConvertBackWhenTabSet = true;
            }
        }
        private bool _isConvertBackWhenLineFeedSet;
        private bool _convertBackWhenLineFeed;
		/// <summary>
        /// Keyの値がLineFeedの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenLineFeed
        {
            get
            {
                return _convertBackWhenLineFeed;
            }
            set
            {
                _convertBackWhenLineFeed = value;
                _isConvertBackWhenLineFeedSet = true;
            }
        }
        private bool _isConvertBackWhenClearSet;
        private bool _convertBackWhenClear;
		/// <summary>
        /// Keyの値がClearの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenClear
        {
            get
            {
                return _convertBackWhenClear;
            }
            set
            {
                _convertBackWhenClear = value;
                _isConvertBackWhenClearSet = true;
            }
        }
        private bool _isConvertBackWhenReturnSet;
        private bool _convertBackWhenReturn;
		/// <summary>
        /// Keyの値がReturnの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenReturn
        {
            get
            {
                return _convertBackWhenReturn;
            }
            set
            {
                _convertBackWhenReturn = value;
                _isConvertBackWhenReturnSet = true;
            }
        }
        private bool _isConvertBackWhenEnterSet;
        private bool _convertBackWhenEnter;
		/// <summary>
        /// Keyの値がEnterの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenEnter
        {
            get
            {
                return _convertBackWhenEnter;
            }
            set
            {
                _convertBackWhenEnter = value;
                _isConvertBackWhenEnterSet = true;
            }
        }
        private bool _isConvertBackWhenPauseSet;
        private bool _convertBackWhenPause;
		/// <summary>
        /// Keyの値がPauseの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenPause
        {
            get
            {
                return _convertBackWhenPause;
            }
            set
            {
                _convertBackWhenPause = value;
                _isConvertBackWhenPauseSet = true;
            }
        }
        private bool _isConvertBackWhenCapitalSet;
        private bool _convertBackWhenCapital;
		/// <summary>
        /// Keyの値がCapitalの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenCapital
        {
            get
            {
                return _convertBackWhenCapital;
            }
            set
            {
                _convertBackWhenCapital = value;
                _isConvertBackWhenCapitalSet = true;
            }
        }
        private bool _isConvertBackWhenCapsLockSet;
        private bool _convertBackWhenCapsLock;
		/// <summary>
        /// Keyの値がCapsLockの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenCapsLock
        {
            get
            {
                return _convertBackWhenCapsLock;
            }
            set
            {
                _convertBackWhenCapsLock = value;
                _isConvertBackWhenCapsLockSet = true;
            }
        }
        private bool _isConvertBackWhenKanaModeSet;
        private bool _convertBackWhenKanaMode;
		/// <summary>
        /// Keyの値がKanaModeの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenKanaMode
        {
            get
            {
                return _convertBackWhenKanaMode;
            }
            set
            {
                _convertBackWhenKanaMode = value;
                _isConvertBackWhenKanaModeSet = true;
            }
        }
        private bool _isConvertBackWhenHangulModeSet;
        private bool _convertBackWhenHangulMode;
		/// <summary>
        /// Keyの値がHangulModeの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenHangulMode
        {
            get
            {
                return _convertBackWhenHangulMode;
            }
            set
            {
                _convertBackWhenHangulMode = value;
                _isConvertBackWhenHangulModeSet = true;
            }
        }
        private bool _isConvertBackWhenJunjaModeSet;
        private bool _convertBackWhenJunjaMode;
		/// <summary>
        /// Keyの値がJunjaModeの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenJunjaMode
        {
            get
            {
                return _convertBackWhenJunjaMode;
            }
            set
            {
                _convertBackWhenJunjaMode = value;
                _isConvertBackWhenJunjaModeSet = true;
            }
        }
        private bool _isConvertBackWhenFinalModeSet;
        private bool _convertBackWhenFinalMode;
		/// <summary>
        /// Keyの値がFinalModeの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenFinalMode
        {
            get
            {
                return _convertBackWhenFinalMode;
            }
            set
            {
                _convertBackWhenFinalMode = value;
                _isConvertBackWhenFinalModeSet = true;
            }
        }
        private bool _isConvertBackWhenHanjaModeSet;
        private bool _convertBackWhenHanjaMode;
		/// <summary>
        /// Keyの値がHanjaModeの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenHanjaMode
        {
            get
            {
                return _convertBackWhenHanjaMode;
            }
            set
            {
                _convertBackWhenHanjaMode = value;
                _isConvertBackWhenHanjaModeSet = true;
            }
        }
        private bool _isConvertBackWhenKanjiModeSet;
        private bool _convertBackWhenKanjiMode;
		/// <summary>
        /// Keyの値がKanjiModeの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenKanjiMode
        {
            get
            {
                return _convertBackWhenKanjiMode;
            }
            set
            {
                _convertBackWhenKanjiMode = value;
                _isConvertBackWhenKanjiModeSet = true;
            }
        }
        private bool _isConvertBackWhenEscapeSet;
        private bool _convertBackWhenEscape;
		/// <summary>
        /// Keyの値がEscapeの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenEscape
        {
            get
            {
                return _convertBackWhenEscape;
            }
            set
            {
                _convertBackWhenEscape = value;
                _isConvertBackWhenEscapeSet = true;
            }
        }
        private bool _isConvertBackWhenImeConvertSet;
        private bool _convertBackWhenImeConvert;
		/// <summary>
        /// Keyの値がImeConvertの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenImeConvert
        {
            get
            {
                return _convertBackWhenImeConvert;
            }
            set
            {
                _convertBackWhenImeConvert = value;
                _isConvertBackWhenImeConvertSet = true;
            }
        }
        private bool _isConvertBackWhenImeNonConvertSet;
        private bool _convertBackWhenImeNonConvert;
		/// <summary>
        /// Keyの値がImeNonConvertの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenImeNonConvert
        {
            get
            {
                return _convertBackWhenImeNonConvert;
            }
            set
            {
                _convertBackWhenImeNonConvert = value;
                _isConvertBackWhenImeNonConvertSet = true;
            }
        }
        private bool _isConvertBackWhenImeAcceptSet;
        private bool _convertBackWhenImeAccept;
		/// <summary>
        /// Keyの値がImeAcceptの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenImeAccept
        {
            get
            {
                return _convertBackWhenImeAccept;
            }
            set
            {
                _convertBackWhenImeAccept = value;
                _isConvertBackWhenImeAcceptSet = true;
            }
        }
        private bool _isConvertBackWhenImeModeChangeSet;
        private bool _convertBackWhenImeModeChange;
		/// <summary>
        /// Keyの値がImeModeChangeの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenImeModeChange
        {
            get
            {
                return _convertBackWhenImeModeChange;
            }
            set
            {
                _convertBackWhenImeModeChange = value;
                _isConvertBackWhenImeModeChangeSet = true;
            }
        }
        private bool _isConvertBackWhenSpaceSet;
        private bool _convertBackWhenSpace;
		/// <summary>
        /// Keyの値がSpaceの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenSpace
        {
            get
            {
                return _convertBackWhenSpace;
            }
            set
            {
                _convertBackWhenSpace = value;
                _isConvertBackWhenSpaceSet = true;
            }
        }
        private bool _isConvertBackWhenPriorSet;
        private bool _convertBackWhenPrior;
		/// <summary>
        /// Keyの値がPriorの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenPrior
        {
            get
            {
                return _convertBackWhenPrior;
            }
            set
            {
                _convertBackWhenPrior = value;
                _isConvertBackWhenPriorSet = true;
            }
        }
        private bool _isConvertBackWhenPageUpSet;
        private bool _convertBackWhenPageUp;
		/// <summary>
        /// Keyの値がPageUpの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenPageUp
        {
            get
            {
                return _convertBackWhenPageUp;
            }
            set
            {
                _convertBackWhenPageUp = value;
                _isConvertBackWhenPageUpSet = true;
            }
        }
        private bool _isConvertBackWhenNextSet;
        private bool _convertBackWhenNext;
		/// <summary>
        /// Keyの値がNextの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenNext
        {
            get
            {
                return _convertBackWhenNext;
            }
            set
            {
                _convertBackWhenNext = value;
                _isConvertBackWhenNextSet = true;
            }
        }
        private bool _isConvertBackWhenPageDownSet;
        private bool _convertBackWhenPageDown;
		/// <summary>
        /// Keyの値がPageDownの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenPageDown
        {
            get
            {
                return _convertBackWhenPageDown;
            }
            set
            {
                _convertBackWhenPageDown = value;
                _isConvertBackWhenPageDownSet = true;
            }
        }
        private bool _isConvertBackWhenEndSet;
        private bool _convertBackWhenEnd;
		/// <summary>
        /// Keyの値がEndの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenEnd
        {
            get
            {
                return _convertBackWhenEnd;
            }
            set
            {
                _convertBackWhenEnd = value;
                _isConvertBackWhenEndSet = true;
            }
        }
        private bool _isConvertBackWhenHomeSet;
        private bool _convertBackWhenHome;
		/// <summary>
        /// Keyの値がHomeの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenHome
        {
            get
            {
                return _convertBackWhenHome;
            }
            set
            {
                _convertBackWhenHome = value;
                _isConvertBackWhenHomeSet = true;
            }
        }
        private bool _isConvertBackWhenLeftSet;
        private bool _convertBackWhenLeft;
		/// <summary>
        /// Keyの値がLeftの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
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
        private bool _isConvertBackWhenUpSet;
        private bool _convertBackWhenUp;
		/// <summary>
        /// Keyの値がUpの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
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
        private bool _isConvertBackWhenRightSet;
        private bool _convertBackWhenRight;
		/// <summary>
        /// Keyの値がRightの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
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
        private bool _isConvertBackWhenDownSet;
        private bool _convertBackWhenDown;
		/// <summary>
        /// Keyの値がDownの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
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
        private bool _isConvertBackWhenSelectSet;
        private bool _convertBackWhenSelect;
		/// <summary>
        /// Keyの値がSelectの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenSelect
        {
            get
            {
                return _convertBackWhenSelect;
            }
            set
            {
                _convertBackWhenSelect = value;
                _isConvertBackWhenSelectSet = true;
            }
        }
        private bool _isConvertBackWhenPrintSet;
        private bool _convertBackWhenPrint;
		/// <summary>
        /// Keyの値がPrintの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenPrint
        {
            get
            {
                return _convertBackWhenPrint;
            }
            set
            {
                _convertBackWhenPrint = value;
                _isConvertBackWhenPrintSet = true;
            }
        }
        private bool _isConvertBackWhenExecuteSet;
        private bool _convertBackWhenExecute;
		/// <summary>
        /// Keyの値がExecuteの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenExecute
        {
            get
            {
                return _convertBackWhenExecute;
            }
            set
            {
                _convertBackWhenExecute = value;
                _isConvertBackWhenExecuteSet = true;
            }
        }
        private bool _isConvertBackWhenSnapshotSet;
        private bool _convertBackWhenSnapshot;
		/// <summary>
        /// Keyの値がSnapshotの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenSnapshot
        {
            get
            {
                return _convertBackWhenSnapshot;
            }
            set
            {
                _convertBackWhenSnapshot = value;
                _isConvertBackWhenSnapshotSet = true;
            }
        }
        private bool _isConvertBackWhenPrintScreenSet;
        private bool _convertBackWhenPrintScreen;
		/// <summary>
        /// Keyの値がPrintScreenの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenPrintScreen
        {
            get
            {
                return _convertBackWhenPrintScreen;
            }
            set
            {
                _convertBackWhenPrintScreen = value;
                _isConvertBackWhenPrintScreenSet = true;
            }
        }
        private bool _isConvertBackWhenInsertSet;
        private bool _convertBackWhenInsert;
		/// <summary>
        /// Keyの値がInsertの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenInsert
        {
            get
            {
                return _convertBackWhenInsert;
            }
            set
            {
                _convertBackWhenInsert = value;
                _isConvertBackWhenInsertSet = true;
            }
        }
        private bool _isConvertBackWhenDeleteSet;
        private bool _convertBackWhenDelete;
		/// <summary>
        /// Keyの値がDeleteの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenDelete
        {
            get
            {
                return _convertBackWhenDelete;
            }
            set
            {
                _convertBackWhenDelete = value;
                _isConvertBackWhenDeleteSet = true;
            }
        }
        private bool _isConvertBackWhenHelpSet;
        private bool _convertBackWhenHelp;
		/// <summary>
        /// Keyの値がHelpの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
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
        private bool _isConvertBackWhenD0Set;
        private bool _convertBackWhenD0;
		/// <summary>
        /// Keyの値がD0の際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenD0
        {
            get
            {
                return _convertBackWhenD0;
            }
            set
            {
                _convertBackWhenD0 = value;
                _isConvertBackWhenD0Set = true;
            }
        }
        private bool _isConvertBackWhenD1Set;
        private bool _convertBackWhenD1;
		/// <summary>
        /// Keyの値がD1の際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenD1
        {
            get
            {
                return _convertBackWhenD1;
            }
            set
            {
                _convertBackWhenD1 = value;
                _isConvertBackWhenD1Set = true;
            }
        }
        private bool _isConvertBackWhenD2Set;
        private bool _convertBackWhenD2;
		/// <summary>
        /// Keyの値がD2の際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenD2
        {
            get
            {
                return _convertBackWhenD2;
            }
            set
            {
                _convertBackWhenD2 = value;
                _isConvertBackWhenD2Set = true;
            }
        }
        private bool _isConvertBackWhenD3Set;
        private bool _convertBackWhenD3;
		/// <summary>
        /// Keyの値がD3の際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenD3
        {
            get
            {
                return _convertBackWhenD3;
            }
            set
            {
                _convertBackWhenD3 = value;
                _isConvertBackWhenD3Set = true;
            }
        }
        private bool _isConvertBackWhenD4Set;
        private bool _convertBackWhenD4;
		/// <summary>
        /// Keyの値がD4の際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenD4
        {
            get
            {
                return _convertBackWhenD4;
            }
            set
            {
                _convertBackWhenD4 = value;
                _isConvertBackWhenD4Set = true;
            }
        }
        private bool _isConvertBackWhenD5Set;
        private bool _convertBackWhenD5;
		/// <summary>
        /// Keyの値がD5の際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenD5
        {
            get
            {
                return _convertBackWhenD5;
            }
            set
            {
                _convertBackWhenD5 = value;
                _isConvertBackWhenD5Set = true;
            }
        }
        private bool _isConvertBackWhenD6Set;
        private bool _convertBackWhenD6;
		/// <summary>
        /// Keyの値がD6の際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenD6
        {
            get
            {
                return _convertBackWhenD6;
            }
            set
            {
                _convertBackWhenD6 = value;
                _isConvertBackWhenD6Set = true;
            }
        }
        private bool _isConvertBackWhenD7Set;
        private bool _convertBackWhenD7;
		/// <summary>
        /// Keyの値がD7の際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenD7
        {
            get
            {
                return _convertBackWhenD7;
            }
            set
            {
                _convertBackWhenD7 = value;
                _isConvertBackWhenD7Set = true;
            }
        }
        private bool _isConvertBackWhenD8Set;
        private bool _convertBackWhenD8;
		/// <summary>
        /// Keyの値がD8の際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenD8
        {
            get
            {
                return _convertBackWhenD8;
            }
            set
            {
                _convertBackWhenD8 = value;
                _isConvertBackWhenD8Set = true;
            }
        }
        private bool _isConvertBackWhenD9Set;
        private bool _convertBackWhenD9;
		/// <summary>
        /// Keyの値がD9の際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenD9
        {
            get
            {
                return _convertBackWhenD9;
            }
            set
            {
                _convertBackWhenD9 = value;
                _isConvertBackWhenD9Set = true;
            }
        }
        private bool _isConvertBackWhenASet;
        private bool _convertBackWhenA;
		/// <summary>
        /// Keyの値がAの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenA
        {
            get
            {
                return _convertBackWhenA;
            }
            set
            {
                _convertBackWhenA = value;
                _isConvertBackWhenASet = true;
            }
        }
        private bool _isConvertBackWhenBSet;
        private bool _convertBackWhenB;
		/// <summary>
        /// Keyの値がBの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenB
        {
            get
            {
                return _convertBackWhenB;
            }
            set
            {
                _convertBackWhenB = value;
                _isConvertBackWhenBSet = true;
            }
        }
        private bool _isConvertBackWhenCSet;
        private bool _convertBackWhenC;
		/// <summary>
        /// Keyの値がCの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenC
        {
            get
            {
                return _convertBackWhenC;
            }
            set
            {
                _convertBackWhenC = value;
                _isConvertBackWhenCSet = true;
            }
        }
        private bool _isConvertBackWhenDSet;
        private bool _convertBackWhenD;
		/// <summary>
        /// Keyの値がDの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenD
        {
            get
            {
                return _convertBackWhenD;
            }
            set
            {
                _convertBackWhenD = value;
                _isConvertBackWhenDSet = true;
            }
        }
        private bool _isConvertBackWhenESet;
        private bool _convertBackWhenE;
		/// <summary>
        /// Keyの値がEの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenE
        {
            get
            {
                return _convertBackWhenE;
            }
            set
            {
                _convertBackWhenE = value;
                _isConvertBackWhenESet = true;
            }
        }
        private bool _isConvertBackWhenFSet;
        private bool _convertBackWhenF;
		/// <summary>
        /// Keyの値がFの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenF
        {
            get
            {
                return _convertBackWhenF;
            }
            set
            {
                _convertBackWhenF = value;
                _isConvertBackWhenFSet = true;
            }
        }
        private bool _isConvertBackWhenGSet;
        private bool _convertBackWhenG;
		/// <summary>
        /// Keyの値がGの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenG
        {
            get
            {
                return _convertBackWhenG;
            }
            set
            {
                _convertBackWhenG = value;
                _isConvertBackWhenGSet = true;
            }
        }
        private bool _isConvertBackWhenHSet;
        private bool _convertBackWhenH;
		/// <summary>
        /// Keyの値がHの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenH
        {
            get
            {
                return _convertBackWhenH;
            }
            set
            {
                _convertBackWhenH = value;
                _isConvertBackWhenHSet = true;
            }
        }
        private bool _isConvertBackWhenISet;
        private bool _convertBackWhenI;
		/// <summary>
        /// Keyの値がIの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenI
        {
            get
            {
                return _convertBackWhenI;
            }
            set
            {
                _convertBackWhenI = value;
                _isConvertBackWhenISet = true;
            }
        }
        private bool _isConvertBackWhenJSet;
        private bool _convertBackWhenJ;
		/// <summary>
        /// Keyの値がJの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenJ
        {
            get
            {
                return _convertBackWhenJ;
            }
            set
            {
                _convertBackWhenJ = value;
                _isConvertBackWhenJSet = true;
            }
        }
        private bool _isConvertBackWhenKSet;
        private bool _convertBackWhenK;
		/// <summary>
        /// Keyの値がKの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenK
        {
            get
            {
                return _convertBackWhenK;
            }
            set
            {
                _convertBackWhenK = value;
                _isConvertBackWhenKSet = true;
            }
        }
        private bool _isConvertBackWhenLSet;
        private bool _convertBackWhenL;
		/// <summary>
        /// Keyの値がLの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenL
        {
            get
            {
                return _convertBackWhenL;
            }
            set
            {
                _convertBackWhenL = value;
                _isConvertBackWhenLSet = true;
            }
        }
        private bool _isConvertBackWhenMSet;
        private bool _convertBackWhenM;
		/// <summary>
        /// Keyの値がMの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenM
        {
            get
            {
                return _convertBackWhenM;
            }
            set
            {
                _convertBackWhenM = value;
                _isConvertBackWhenMSet = true;
            }
        }
        private bool _isConvertBackWhenNSet;
        private bool _convertBackWhenN;
		/// <summary>
        /// Keyの値がNの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenN
        {
            get
            {
                return _convertBackWhenN;
            }
            set
            {
                _convertBackWhenN = value;
                _isConvertBackWhenNSet = true;
            }
        }
        private bool _isConvertBackWhenOSet;
        private bool _convertBackWhenO;
		/// <summary>
        /// Keyの値がOの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenO
        {
            get
            {
                return _convertBackWhenO;
            }
            set
            {
                _convertBackWhenO = value;
                _isConvertBackWhenOSet = true;
            }
        }
        private bool _isConvertBackWhenPSet;
        private bool _convertBackWhenP;
		/// <summary>
        /// Keyの値がPの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenP
        {
            get
            {
                return _convertBackWhenP;
            }
            set
            {
                _convertBackWhenP = value;
                _isConvertBackWhenPSet = true;
            }
        }
        private bool _isConvertBackWhenQSet;
        private bool _convertBackWhenQ;
		/// <summary>
        /// Keyの値がQの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenQ
        {
            get
            {
                return _convertBackWhenQ;
            }
            set
            {
                _convertBackWhenQ = value;
                _isConvertBackWhenQSet = true;
            }
        }
        private bool _isConvertBackWhenRSet;
        private bool _convertBackWhenR;
		/// <summary>
        /// Keyの値がRの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenR
        {
            get
            {
                return _convertBackWhenR;
            }
            set
            {
                _convertBackWhenR = value;
                _isConvertBackWhenRSet = true;
            }
        }
        private bool _isConvertBackWhenSSet;
        private bool _convertBackWhenS;
		/// <summary>
        /// Keyの値がSの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenS
        {
            get
            {
                return _convertBackWhenS;
            }
            set
            {
                _convertBackWhenS = value;
                _isConvertBackWhenSSet = true;
            }
        }
        private bool _isConvertBackWhenTSet;
        private bool _convertBackWhenT;
		/// <summary>
        /// Keyの値がTの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenT
        {
            get
            {
                return _convertBackWhenT;
            }
            set
            {
                _convertBackWhenT = value;
                _isConvertBackWhenTSet = true;
            }
        }
        private bool _isConvertBackWhenUSet;
        private bool _convertBackWhenU;
		/// <summary>
        /// Keyの値がUの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenU
        {
            get
            {
                return _convertBackWhenU;
            }
            set
            {
                _convertBackWhenU = value;
                _isConvertBackWhenUSet = true;
            }
        }
        private bool _isConvertBackWhenVSet;
        private bool _convertBackWhenV;
		/// <summary>
        /// Keyの値がVの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenV
        {
            get
            {
                return _convertBackWhenV;
            }
            set
            {
                _convertBackWhenV = value;
                _isConvertBackWhenVSet = true;
            }
        }
        private bool _isConvertBackWhenWSet;
        private bool _convertBackWhenW;
		/// <summary>
        /// Keyの値がWの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenW
        {
            get
            {
                return _convertBackWhenW;
            }
            set
            {
                _convertBackWhenW = value;
                _isConvertBackWhenWSet = true;
            }
        }
        private bool _isConvertBackWhenXSet;
        private bool _convertBackWhenX;
		/// <summary>
        /// Keyの値がXの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenX
        {
            get
            {
                return _convertBackWhenX;
            }
            set
            {
                _convertBackWhenX = value;
                _isConvertBackWhenXSet = true;
            }
        }
        private bool _isConvertBackWhenYSet;
        private bool _convertBackWhenY;
		/// <summary>
        /// Keyの値がYの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenY
        {
            get
            {
                return _convertBackWhenY;
            }
            set
            {
                _convertBackWhenY = value;
                _isConvertBackWhenYSet = true;
            }
        }
        private bool _isConvertBackWhenZSet;
        private bool _convertBackWhenZ;
		/// <summary>
        /// Keyの値がZの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenZ
        {
            get
            {
                return _convertBackWhenZ;
            }
            set
            {
                _convertBackWhenZ = value;
                _isConvertBackWhenZSet = true;
            }
        }
        private bool _isConvertBackWhenLWinSet;
        private bool _convertBackWhenLWin;
		/// <summary>
        /// Keyの値がLWinの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenLWin
        {
            get
            {
                return _convertBackWhenLWin;
            }
            set
            {
                _convertBackWhenLWin = value;
                _isConvertBackWhenLWinSet = true;
            }
        }
        private bool _isConvertBackWhenRWinSet;
        private bool _convertBackWhenRWin;
		/// <summary>
        /// Keyの値がRWinの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenRWin
        {
            get
            {
                return _convertBackWhenRWin;
            }
            set
            {
                _convertBackWhenRWin = value;
                _isConvertBackWhenRWinSet = true;
            }
        }
        private bool _isConvertBackWhenAppsSet;
        private bool _convertBackWhenApps;
		/// <summary>
        /// Keyの値がAppsの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenApps
        {
            get
            {
                return _convertBackWhenApps;
            }
            set
            {
                _convertBackWhenApps = value;
                _isConvertBackWhenAppsSet = true;
            }
        }
        private bool _isConvertBackWhenSleepSet;
        private bool _convertBackWhenSleep;
		/// <summary>
        /// Keyの値がSleepの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenSleep
        {
            get
            {
                return _convertBackWhenSleep;
            }
            set
            {
                _convertBackWhenSleep = value;
                _isConvertBackWhenSleepSet = true;
            }
        }
        private bool _isConvertBackWhenNumPad0Set;
        private bool _convertBackWhenNumPad0;
		/// <summary>
        /// Keyの値がNumPad0の際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenNumPad0
        {
            get
            {
                return _convertBackWhenNumPad0;
            }
            set
            {
                _convertBackWhenNumPad0 = value;
                _isConvertBackWhenNumPad0Set = true;
            }
        }
        private bool _isConvertBackWhenNumPad1Set;
        private bool _convertBackWhenNumPad1;
		/// <summary>
        /// Keyの値がNumPad1の際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenNumPad1
        {
            get
            {
                return _convertBackWhenNumPad1;
            }
            set
            {
                _convertBackWhenNumPad1 = value;
                _isConvertBackWhenNumPad1Set = true;
            }
        }
        private bool _isConvertBackWhenNumPad2Set;
        private bool _convertBackWhenNumPad2;
		/// <summary>
        /// Keyの値がNumPad2の際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenNumPad2
        {
            get
            {
                return _convertBackWhenNumPad2;
            }
            set
            {
                _convertBackWhenNumPad2 = value;
                _isConvertBackWhenNumPad2Set = true;
            }
        }
        private bool _isConvertBackWhenNumPad3Set;
        private bool _convertBackWhenNumPad3;
		/// <summary>
        /// Keyの値がNumPad3の際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenNumPad3
        {
            get
            {
                return _convertBackWhenNumPad3;
            }
            set
            {
                _convertBackWhenNumPad3 = value;
                _isConvertBackWhenNumPad3Set = true;
            }
        }
        private bool _isConvertBackWhenNumPad4Set;
        private bool _convertBackWhenNumPad4;
		/// <summary>
        /// Keyの値がNumPad4の際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenNumPad4
        {
            get
            {
                return _convertBackWhenNumPad4;
            }
            set
            {
                _convertBackWhenNumPad4 = value;
                _isConvertBackWhenNumPad4Set = true;
            }
        }
        private bool _isConvertBackWhenNumPad5Set;
        private bool _convertBackWhenNumPad5;
		/// <summary>
        /// Keyの値がNumPad5の際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenNumPad5
        {
            get
            {
                return _convertBackWhenNumPad5;
            }
            set
            {
                _convertBackWhenNumPad5 = value;
                _isConvertBackWhenNumPad5Set = true;
            }
        }
        private bool _isConvertBackWhenNumPad6Set;
        private bool _convertBackWhenNumPad6;
		/// <summary>
        /// Keyの値がNumPad6の際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenNumPad6
        {
            get
            {
                return _convertBackWhenNumPad6;
            }
            set
            {
                _convertBackWhenNumPad6 = value;
                _isConvertBackWhenNumPad6Set = true;
            }
        }
        private bool _isConvertBackWhenNumPad7Set;
        private bool _convertBackWhenNumPad7;
		/// <summary>
        /// Keyの値がNumPad7の際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenNumPad7
        {
            get
            {
                return _convertBackWhenNumPad7;
            }
            set
            {
                _convertBackWhenNumPad7 = value;
                _isConvertBackWhenNumPad7Set = true;
            }
        }
        private bool _isConvertBackWhenNumPad8Set;
        private bool _convertBackWhenNumPad8;
		/// <summary>
        /// Keyの値がNumPad8の際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenNumPad8
        {
            get
            {
                return _convertBackWhenNumPad8;
            }
            set
            {
                _convertBackWhenNumPad8 = value;
                _isConvertBackWhenNumPad8Set = true;
            }
        }
        private bool _isConvertBackWhenNumPad9Set;
        private bool _convertBackWhenNumPad9;
		/// <summary>
        /// Keyの値がNumPad9の際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenNumPad9
        {
            get
            {
                return _convertBackWhenNumPad9;
            }
            set
            {
                _convertBackWhenNumPad9 = value;
                _isConvertBackWhenNumPad9Set = true;
            }
        }
        private bool _isConvertBackWhenMultiplySet;
        private bool _convertBackWhenMultiply;
		/// <summary>
        /// Keyの値がMultiplyの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenMultiply
        {
            get
            {
                return _convertBackWhenMultiply;
            }
            set
            {
                _convertBackWhenMultiply = value;
                _isConvertBackWhenMultiplySet = true;
            }
        }
        private bool _isConvertBackWhenAddSet;
        private bool _convertBackWhenAdd;
		/// <summary>
        /// Keyの値がAddの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenAdd
        {
            get
            {
                return _convertBackWhenAdd;
            }
            set
            {
                _convertBackWhenAdd = value;
                _isConvertBackWhenAddSet = true;
            }
        }
        private bool _isConvertBackWhenSeparatorSet;
        private bool _convertBackWhenSeparator;
		/// <summary>
        /// Keyの値がSeparatorの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenSeparator
        {
            get
            {
                return _convertBackWhenSeparator;
            }
            set
            {
                _convertBackWhenSeparator = value;
                _isConvertBackWhenSeparatorSet = true;
            }
        }
        private bool _isConvertBackWhenSubtractSet;
        private bool _convertBackWhenSubtract;
		/// <summary>
        /// Keyの値がSubtractの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenSubtract
        {
            get
            {
                return _convertBackWhenSubtract;
            }
            set
            {
                _convertBackWhenSubtract = value;
                _isConvertBackWhenSubtractSet = true;
            }
        }
        private bool _isConvertBackWhenDecimalSet;
        private bool _convertBackWhenDecimal;
		/// <summary>
        /// Keyの値がDecimalの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenDecimal
        {
            get
            {
                return _convertBackWhenDecimal;
            }
            set
            {
                _convertBackWhenDecimal = value;
                _isConvertBackWhenDecimalSet = true;
            }
        }
        private bool _isConvertBackWhenDivideSet;
        private bool _convertBackWhenDivide;
		/// <summary>
        /// Keyの値がDivideの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenDivide
        {
            get
            {
                return _convertBackWhenDivide;
            }
            set
            {
                _convertBackWhenDivide = value;
                _isConvertBackWhenDivideSet = true;
            }
        }
        private bool _isConvertBackWhenF1Set;
        private bool _convertBackWhenF1;
		/// <summary>
        /// Keyの値がF1の際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenF1
        {
            get
            {
                return _convertBackWhenF1;
            }
            set
            {
                _convertBackWhenF1 = value;
                _isConvertBackWhenF1Set = true;
            }
        }
        private bool _isConvertBackWhenF2Set;
        private bool _convertBackWhenF2;
		/// <summary>
        /// Keyの値がF2の際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenF2
        {
            get
            {
                return _convertBackWhenF2;
            }
            set
            {
                _convertBackWhenF2 = value;
                _isConvertBackWhenF2Set = true;
            }
        }
        private bool _isConvertBackWhenF3Set;
        private bool _convertBackWhenF3;
		/// <summary>
        /// Keyの値がF3の際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenF3
        {
            get
            {
                return _convertBackWhenF3;
            }
            set
            {
                _convertBackWhenF3 = value;
                _isConvertBackWhenF3Set = true;
            }
        }
        private bool _isConvertBackWhenF4Set;
        private bool _convertBackWhenF4;
		/// <summary>
        /// Keyの値がF4の際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenF4
        {
            get
            {
                return _convertBackWhenF4;
            }
            set
            {
                _convertBackWhenF4 = value;
                _isConvertBackWhenF4Set = true;
            }
        }
        private bool _isConvertBackWhenF5Set;
        private bool _convertBackWhenF5;
		/// <summary>
        /// Keyの値がF5の際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenF5
        {
            get
            {
                return _convertBackWhenF5;
            }
            set
            {
                _convertBackWhenF5 = value;
                _isConvertBackWhenF5Set = true;
            }
        }
        private bool _isConvertBackWhenF6Set;
        private bool _convertBackWhenF6;
		/// <summary>
        /// Keyの値がF6の際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenF6
        {
            get
            {
                return _convertBackWhenF6;
            }
            set
            {
                _convertBackWhenF6 = value;
                _isConvertBackWhenF6Set = true;
            }
        }
        private bool _isConvertBackWhenF7Set;
        private bool _convertBackWhenF7;
		/// <summary>
        /// Keyの値がF7の際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenF7
        {
            get
            {
                return _convertBackWhenF7;
            }
            set
            {
                _convertBackWhenF7 = value;
                _isConvertBackWhenF7Set = true;
            }
        }
        private bool _isConvertBackWhenF8Set;
        private bool _convertBackWhenF8;
		/// <summary>
        /// Keyの値がF8の際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenF8
        {
            get
            {
                return _convertBackWhenF8;
            }
            set
            {
                _convertBackWhenF8 = value;
                _isConvertBackWhenF8Set = true;
            }
        }
        private bool _isConvertBackWhenF9Set;
        private bool _convertBackWhenF9;
		/// <summary>
        /// Keyの値がF9の際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenF9
        {
            get
            {
                return _convertBackWhenF9;
            }
            set
            {
                _convertBackWhenF9 = value;
                _isConvertBackWhenF9Set = true;
            }
        }
        private bool _isConvertBackWhenF10Set;
        private bool _convertBackWhenF10;
		/// <summary>
        /// Keyの値がF10の際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenF10
        {
            get
            {
                return _convertBackWhenF10;
            }
            set
            {
                _convertBackWhenF10 = value;
                _isConvertBackWhenF10Set = true;
            }
        }
        private bool _isConvertBackWhenF11Set;
        private bool _convertBackWhenF11;
		/// <summary>
        /// Keyの値がF11の際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenF11
        {
            get
            {
                return _convertBackWhenF11;
            }
            set
            {
                _convertBackWhenF11 = value;
                _isConvertBackWhenF11Set = true;
            }
        }
        private bool _isConvertBackWhenF12Set;
        private bool _convertBackWhenF12;
		/// <summary>
        /// Keyの値がF12の際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenF12
        {
            get
            {
                return _convertBackWhenF12;
            }
            set
            {
                _convertBackWhenF12 = value;
                _isConvertBackWhenF12Set = true;
            }
        }
        private bool _isConvertBackWhenF13Set;
        private bool _convertBackWhenF13;
		/// <summary>
        /// Keyの値がF13の際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenF13
        {
            get
            {
                return _convertBackWhenF13;
            }
            set
            {
                _convertBackWhenF13 = value;
                _isConvertBackWhenF13Set = true;
            }
        }
        private bool _isConvertBackWhenF14Set;
        private bool _convertBackWhenF14;
		/// <summary>
        /// Keyの値がF14の際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenF14
        {
            get
            {
                return _convertBackWhenF14;
            }
            set
            {
                _convertBackWhenF14 = value;
                _isConvertBackWhenF14Set = true;
            }
        }
        private bool _isConvertBackWhenF15Set;
        private bool _convertBackWhenF15;
		/// <summary>
        /// Keyの値がF15の際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenF15
        {
            get
            {
                return _convertBackWhenF15;
            }
            set
            {
                _convertBackWhenF15 = value;
                _isConvertBackWhenF15Set = true;
            }
        }
        private bool _isConvertBackWhenF16Set;
        private bool _convertBackWhenF16;
		/// <summary>
        /// Keyの値がF16の際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenF16
        {
            get
            {
                return _convertBackWhenF16;
            }
            set
            {
                _convertBackWhenF16 = value;
                _isConvertBackWhenF16Set = true;
            }
        }
        private bool _isConvertBackWhenF17Set;
        private bool _convertBackWhenF17;
		/// <summary>
        /// Keyの値がF17の際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenF17
        {
            get
            {
                return _convertBackWhenF17;
            }
            set
            {
                _convertBackWhenF17 = value;
                _isConvertBackWhenF17Set = true;
            }
        }
        private bool _isConvertBackWhenF18Set;
        private bool _convertBackWhenF18;
		/// <summary>
        /// Keyの値がF18の際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenF18
        {
            get
            {
                return _convertBackWhenF18;
            }
            set
            {
                _convertBackWhenF18 = value;
                _isConvertBackWhenF18Set = true;
            }
        }
        private bool _isConvertBackWhenF19Set;
        private bool _convertBackWhenF19;
		/// <summary>
        /// Keyの値がF19の際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenF19
        {
            get
            {
                return _convertBackWhenF19;
            }
            set
            {
                _convertBackWhenF19 = value;
                _isConvertBackWhenF19Set = true;
            }
        }
        private bool _isConvertBackWhenF20Set;
        private bool _convertBackWhenF20;
		/// <summary>
        /// Keyの値がF20の際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenF20
        {
            get
            {
                return _convertBackWhenF20;
            }
            set
            {
                _convertBackWhenF20 = value;
                _isConvertBackWhenF20Set = true;
            }
        }
        private bool _isConvertBackWhenF21Set;
        private bool _convertBackWhenF21;
		/// <summary>
        /// Keyの値がF21の際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenF21
        {
            get
            {
                return _convertBackWhenF21;
            }
            set
            {
                _convertBackWhenF21 = value;
                _isConvertBackWhenF21Set = true;
            }
        }
        private bool _isConvertBackWhenF22Set;
        private bool _convertBackWhenF22;
		/// <summary>
        /// Keyの値がF22の際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenF22
        {
            get
            {
                return _convertBackWhenF22;
            }
            set
            {
                _convertBackWhenF22 = value;
                _isConvertBackWhenF22Set = true;
            }
        }
        private bool _isConvertBackWhenF23Set;
        private bool _convertBackWhenF23;
		/// <summary>
        /// Keyの値がF23の際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenF23
        {
            get
            {
                return _convertBackWhenF23;
            }
            set
            {
                _convertBackWhenF23 = value;
                _isConvertBackWhenF23Set = true;
            }
        }
        private bool _isConvertBackWhenF24Set;
        private bool _convertBackWhenF24;
		/// <summary>
        /// Keyの値がF24の際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenF24
        {
            get
            {
                return _convertBackWhenF24;
            }
            set
            {
                _convertBackWhenF24 = value;
                _isConvertBackWhenF24Set = true;
            }
        }
        private bool _isConvertBackWhenNumLockSet;
        private bool _convertBackWhenNumLock;
		/// <summary>
        /// Keyの値がNumLockの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenNumLock
        {
            get
            {
                return _convertBackWhenNumLock;
            }
            set
            {
                _convertBackWhenNumLock = value;
                _isConvertBackWhenNumLockSet = true;
            }
        }
        private bool _isConvertBackWhenScrollSet;
        private bool _convertBackWhenScroll;
		/// <summary>
        /// Keyの値がScrollの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenScroll
        {
            get
            {
                return _convertBackWhenScroll;
            }
            set
            {
                _convertBackWhenScroll = value;
                _isConvertBackWhenScrollSet = true;
            }
        }
        private bool _isConvertBackWhenLeftShiftSet;
        private bool _convertBackWhenLeftShift;
		/// <summary>
        /// Keyの値がLeftShiftの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenLeftShift
        {
            get
            {
                return _convertBackWhenLeftShift;
            }
            set
            {
                _convertBackWhenLeftShift = value;
                _isConvertBackWhenLeftShiftSet = true;
            }
        }
        private bool _isConvertBackWhenRightShiftSet;
        private bool _convertBackWhenRightShift;
		/// <summary>
        /// Keyの値がRightShiftの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenRightShift
        {
            get
            {
                return _convertBackWhenRightShift;
            }
            set
            {
                _convertBackWhenRightShift = value;
                _isConvertBackWhenRightShiftSet = true;
            }
        }
        private bool _isConvertBackWhenLeftCtrlSet;
        private bool _convertBackWhenLeftCtrl;
		/// <summary>
        /// Keyの値がLeftCtrlの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenLeftCtrl
        {
            get
            {
                return _convertBackWhenLeftCtrl;
            }
            set
            {
                _convertBackWhenLeftCtrl = value;
                _isConvertBackWhenLeftCtrlSet = true;
            }
        }
        private bool _isConvertBackWhenRightCtrlSet;
        private bool _convertBackWhenRightCtrl;
		/// <summary>
        /// Keyの値がRightCtrlの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenRightCtrl
        {
            get
            {
                return _convertBackWhenRightCtrl;
            }
            set
            {
                _convertBackWhenRightCtrl = value;
                _isConvertBackWhenRightCtrlSet = true;
            }
        }
        private bool _isConvertBackWhenLeftAltSet;
        private bool _convertBackWhenLeftAlt;
		/// <summary>
        /// Keyの値がLeftAltの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenLeftAlt
        {
            get
            {
                return _convertBackWhenLeftAlt;
            }
            set
            {
                _convertBackWhenLeftAlt = value;
                _isConvertBackWhenLeftAltSet = true;
            }
        }
        private bool _isConvertBackWhenRightAltSet;
        private bool _convertBackWhenRightAlt;
		/// <summary>
        /// Keyの値がRightAltの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenRightAlt
        {
            get
            {
                return _convertBackWhenRightAlt;
            }
            set
            {
                _convertBackWhenRightAlt = value;
                _isConvertBackWhenRightAltSet = true;
            }
        }
        private bool _isConvertBackWhenBrowserBackSet;
        private bool _convertBackWhenBrowserBack;
		/// <summary>
        /// Keyの値がBrowserBackの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenBrowserBack
        {
            get
            {
                return _convertBackWhenBrowserBack;
            }
            set
            {
                _convertBackWhenBrowserBack = value;
                _isConvertBackWhenBrowserBackSet = true;
            }
        }
        private bool _isConvertBackWhenBrowserForwardSet;
        private bool _convertBackWhenBrowserForward;
		/// <summary>
        /// Keyの値がBrowserForwardの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenBrowserForward
        {
            get
            {
                return _convertBackWhenBrowserForward;
            }
            set
            {
                _convertBackWhenBrowserForward = value;
                _isConvertBackWhenBrowserForwardSet = true;
            }
        }
        private bool _isConvertBackWhenBrowserRefreshSet;
        private bool _convertBackWhenBrowserRefresh;
		/// <summary>
        /// Keyの値がBrowserRefreshの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenBrowserRefresh
        {
            get
            {
                return _convertBackWhenBrowserRefresh;
            }
            set
            {
                _convertBackWhenBrowserRefresh = value;
                _isConvertBackWhenBrowserRefreshSet = true;
            }
        }
        private bool _isConvertBackWhenBrowserStopSet;
        private bool _convertBackWhenBrowserStop;
		/// <summary>
        /// Keyの値がBrowserStopの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenBrowserStop
        {
            get
            {
                return _convertBackWhenBrowserStop;
            }
            set
            {
                _convertBackWhenBrowserStop = value;
                _isConvertBackWhenBrowserStopSet = true;
            }
        }
        private bool _isConvertBackWhenBrowserSearchSet;
        private bool _convertBackWhenBrowserSearch;
		/// <summary>
        /// Keyの値がBrowserSearchの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenBrowserSearch
        {
            get
            {
                return _convertBackWhenBrowserSearch;
            }
            set
            {
                _convertBackWhenBrowserSearch = value;
                _isConvertBackWhenBrowserSearchSet = true;
            }
        }
        private bool _isConvertBackWhenBrowserFavoritesSet;
        private bool _convertBackWhenBrowserFavorites;
		/// <summary>
        /// Keyの値がBrowserFavoritesの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenBrowserFavorites
        {
            get
            {
                return _convertBackWhenBrowserFavorites;
            }
            set
            {
                _convertBackWhenBrowserFavorites = value;
                _isConvertBackWhenBrowserFavoritesSet = true;
            }
        }
        private bool _isConvertBackWhenBrowserHomeSet;
        private bool _convertBackWhenBrowserHome;
		/// <summary>
        /// Keyの値がBrowserHomeの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenBrowserHome
        {
            get
            {
                return _convertBackWhenBrowserHome;
            }
            set
            {
                _convertBackWhenBrowserHome = value;
                _isConvertBackWhenBrowserHomeSet = true;
            }
        }
        private bool _isConvertBackWhenVolumeMuteSet;
        private bool _convertBackWhenVolumeMute;
		/// <summary>
        /// Keyの値がVolumeMuteの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenVolumeMute
        {
            get
            {
                return _convertBackWhenVolumeMute;
            }
            set
            {
                _convertBackWhenVolumeMute = value;
                _isConvertBackWhenVolumeMuteSet = true;
            }
        }
        private bool _isConvertBackWhenVolumeDownSet;
        private bool _convertBackWhenVolumeDown;
		/// <summary>
        /// Keyの値がVolumeDownの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenVolumeDown
        {
            get
            {
                return _convertBackWhenVolumeDown;
            }
            set
            {
                _convertBackWhenVolumeDown = value;
                _isConvertBackWhenVolumeDownSet = true;
            }
        }
        private bool _isConvertBackWhenVolumeUpSet;
        private bool _convertBackWhenVolumeUp;
		/// <summary>
        /// Keyの値がVolumeUpの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenVolumeUp
        {
            get
            {
                return _convertBackWhenVolumeUp;
            }
            set
            {
                _convertBackWhenVolumeUp = value;
                _isConvertBackWhenVolumeUpSet = true;
            }
        }
        private bool _isConvertBackWhenMediaNextTrackSet;
        private bool _convertBackWhenMediaNextTrack;
		/// <summary>
        /// Keyの値がMediaNextTrackの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenMediaNextTrack
        {
            get
            {
                return _convertBackWhenMediaNextTrack;
            }
            set
            {
                _convertBackWhenMediaNextTrack = value;
                _isConvertBackWhenMediaNextTrackSet = true;
            }
        }
        private bool _isConvertBackWhenMediaPreviousTrackSet;
        private bool _convertBackWhenMediaPreviousTrack;
		/// <summary>
        /// Keyの値がMediaPreviousTrackの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenMediaPreviousTrack
        {
            get
            {
                return _convertBackWhenMediaPreviousTrack;
            }
            set
            {
                _convertBackWhenMediaPreviousTrack = value;
                _isConvertBackWhenMediaPreviousTrackSet = true;
            }
        }
        private bool _isConvertBackWhenMediaStopSet;
        private bool _convertBackWhenMediaStop;
		/// <summary>
        /// Keyの値がMediaStopの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenMediaStop
        {
            get
            {
                return _convertBackWhenMediaStop;
            }
            set
            {
                _convertBackWhenMediaStop = value;
                _isConvertBackWhenMediaStopSet = true;
            }
        }
        private bool _isConvertBackWhenMediaPlayPauseSet;
        private bool _convertBackWhenMediaPlayPause;
		/// <summary>
        /// Keyの値がMediaPlayPauseの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenMediaPlayPause
        {
            get
            {
                return _convertBackWhenMediaPlayPause;
            }
            set
            {
                _convertBackWhenMediaPlayPause = value;
                _isConvertBackWhenMediaPlayPauseSet = true;
            }
        }
        private bool _isConvertBackWhenLaunchMailSet;
        private bool _convertBackWhenLaunchMail;
		/// <summary>
        /// Keyの値がLaunchMailの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenLaunchMail
        {
            get
            {
                return _convertBackWhenLaunchMail;
            }
            set
            {
                _convertBackWhenLaunchMail = value;
                _isConvertBackWhenLaunchMailSet = true;
            }
        }
        private bool _isConvertBackWhenSelectMediaSet;
        private bool _convertBackWhenSelectMedia;
		/// <summary>
        /// Keyの値がSelectMediaの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenSelectMedia
        {
            get
            {
                return _convertBackWhenSelectMedia;
            }
            set
            {
                _convertBackWhenSelectMedia = value;
                _isConvertBackWhenSelectMediaSet = true;
            }
        }
        private bool _isConvertBackWhenLaunchApplication1Set;
        private bool _convertBackWhenLaunchApplication1;
		/// <summary>
        /// Keyの値がLaunchApplication1の際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenLaunchApplication1
        {
            get
            {
                return _convertBackWhenLaunchApplication1;
            }
            set
            {
                _convertBackWhenLaunchApplication1 = value;
                _isConvertBackWhenLaunchApplication1Set = true;
            }
        }
        private bool _isConvertBackWhenLaunchApplication2Set;
        private bool _convertBackWhenLaunchApplication2;
		/// <summary>
        /// Keyの値がLaunchApplication2の際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenLaunchApplication2
        {
            get
            {
                return _convertBackWhenLaunchApplication2;
            }
            set
            {
                _convertBackWhenLaunchApplication2 = value;
                _isConvertBackWhenLaunchApplication2Set = true;
            }
        }
        private bool _isConvertBackWhenOem1Set;
        private bool _convertBackWhenOem1;
		/// <summary>
        /// Keyの値がOem1の際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenOem1
        {
            get
            {
                return _convertBackWhenOem1;
            }
            set
            {
                _convertBackWhenOem1 = value;
                _isConvertBackWhenOem1Set = true;
            }
        }
        private bool _isConvertBackWhenOemSemicolonSet;
        private bool _convertBackWhenOemSemicolon;
		/// <summary>
        /// Keyの値がOemSemicolonの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenOemSemicolon
        {
            get
            {
                return _convertBackWhenOemSemicolon;
            }
            set
            {
                _convertBackWhenOemSemicolon = value;
                _isConvertBackWhenOemSemicolonSet = true;
            }
        }
        private bool _isConvertBackWhenOemPlusSet;
        private bool _convertBackWhenOemPlus;
		/// <summary>
        /// Keyの値がOemPlusの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenOemPlus
        {
            get
            {
                return _convertBackWhenOemPlus;
            }
            set
            {
                _convertBackWhenOemPlus = value;
                _isConvertBackWhenOemPlusSet = true;
            }
        }
        private bool _isConvertBackWhenOemCommaSet;
        private bool _convertBackWhenOemComma;
		/// <summary>
        /// Keyの値がOemCommaの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenOemComma
        {
            get
            {
                return _convertBackWhenOemComma;
            }
            set
            {
                _convertBackWhenOemComma = value;
                _isConvertBackWhenOemCommaSet = true;
            }
        }
        private bool _isConvertBackWhenOemMinusSet;
        private bool _convertBackWhenOemMinus;
		/// <summary>
        /// Keyの値がOemMinusの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenOemMinus
        {
            get
            {
                return _convertBackWhenOemMinus;
            }
            set
            {
                _convertBackWhenOemMinus = value;
                _isConvertBackWhenOemMinusSet = true;
            }
        }
        private bool _isConvertBackWhenOemPeriodSet;
        private bool _convertBackWhenOemPeriod;
		/// <summary>
        /// Keyの値がOemPeriodの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenOemPeriod
        {
            get
            {
                return _convertBackWhenOemPeriod;
            }
            set
            {
                _convertBackWhenOemPeriod = value;
                _isConvertBackWhenOemPeriodSet = true;
            }
        }
        private bool _isConvertBackWhenOem2Set;
        private bool _convertBackWhenOem2;
		/// <summary>
        /// Keyの値がOem2の際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenOem2
        {
            get
            {
                return _convertBackWhenOem2;
            }
            set
            {
                _convertBackWhenOem2 = value;
                _isConvertBackWhenOem2Set = true;
            }
        }
        private bool _isConvertBackWhenOemQuestionSet;
        private bool _convertBackWhenOemQuestion;
		/// <summary>
        /// Keyの値がOemQuestionの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenOemQuestion
        {
            get
            {
                return _convertBackWhenOemQuestion;
            }
            set
            {
                _convertBackWhenOemQuestion = value;
                _isConvertBackWhenOemQuestionSet = true;
            }
        }
        private bool _isConvertBackWhenOem3Set;
        private bool _convertBackWhenOem3;
		/// <summary>
        /// Keyの値がOem3の際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenOem3
        {
            get
            {
                return _convertBackWhenOem3;
            }
            set
            {
                _convertBackWhenOem3 = value;
                _isConvertBackWhenOem3Set = true;
            }
        }
        private bool _isConvertBackWhenOemTildeSet;
        private bool _convertBackWhenOemTilde;
		/// <summary>
        /// Keyの値がOemTildeの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenOemTilde
        {
            get
            {
                return _convertBackWhenOemTilde;
            }
            set
            {
                _convertBackWhenOemTilde = value;
                _isConvertBackWhenOemTildeSet = true;
            }
        }
        private bool _isConvertBackWhenAbntC1Set;
        private bool _convertBackWhenAbntC1;
		/// <summary>
        /// Keyの値がAbntC1の際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenAbntC1
        {
            get
            {
                return _convertBackWhenAbntC1;
            }
            set
            {
                _convertBackWhenAbntC1 = value;
                _isConvertBackWhenAbntC1Set = true;
            }
        }
        private bool _isConvertBackWhenAbntC2Set;
        private bool _convertBackWhenAbntC2;
		/// <summary>
        /// Keyの値がAbntC2の際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenAbntC2
        {
            get
            {
                return _convertBackWhenAbntC2;
            }
            set
            {
                _convertBackWhenAbntC2 = value;
                _isConvertBackWhenAbntC2Set = true;
            }
        }
        private bool _isConvertBackWhenOem4Set;
        private bool _convertBackWhenOem4;
		/// <summary>
        /// Keyの値がOem4の際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenOem4
        {
            get
            {
                return _convertBackWhenOem4;
            }
            set
            {
                _convertBackWhenOem4 = value;
                _isConvertBackWhenOem4Set = true;
            }
        }
        private bool _isConvertBackWhenOemOpenBracketsSet;
        private bool _convertBackWhenOemOpenBrackets;
		/// <summary>
        /// Keyの値がOemOpenBracketsの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenOemOpenBrackets
        {
            get
            {
                return _convertBackWhenOemOpenBrackets;
            }
            set
            {
                _convertBackWhenOemOpenBrackets = value;
                _isConvertBackWhenOemOpenBracketsSet = true;
            }
        }
        private bool _isConvertBackWhenOem5Set;
        private bool _convertBackWhenOem5;
		/// <summary>
        /// Keyの値がOem5の際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenOem5
        {
            get
            {
                return _convertBackWhenOem5;
            }
            set
            {
                _convertBackWhenOem5 = value;
                _isConvertBackWhenOem5Set = true;
            }
        }
        private bool _isConvertBackWhenOemPipeSet;
        private bool _convertBackWhenOemPipe;
		/// <summary>
        /// Keyの値がOemPipeの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenOemPipe
        {
            get
            {
                return _convertBackWhenOemPipe;
            }
            set
            {
                _convertBackWhenOemPipe = value;
                _isConvertBackWhenOemPipeSet = true;
            }
        }
        private bool _isConvertBackWhenOem6Set;
        private bool _convertBackWhenOem6;
		/// <summary>
        /// Keyの値がOem6の際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenOem6
        {
            get
            {
                return _convertBackWhenOem6;
            }
            set
            {
                _convertBackWhenOem6 = value;
                _isConvertBackWhenOem6Set = true;
            }
        }
        private bool _isConvertBackWhenOemCloseBracketsSet;
        private bool _convertBackWhenOemCloseBrackets;
		/// <summary>
        /// Keyの値がOemCloseBracketsの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenOemCloseBrackets
        {
            get
            {
                return _convertBackWhenOemCloseBrackets;
            }
            set
            {
                _convertBackWhenOemCloseBrackets = value;
                _isConvertBackWhenOemCloseBracketsSet = true;
            }
        }
        private bool _isConvertBackWhenOem7Set;
        private bool _convertBackWhenOem7;
		/// <summary>
        /// Keyの値がOem7の際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenOem7
        {
            get
            {
                return _convertBackWhenOem7;
            }
            set
            {
                _convertBackWhenOem7 = value;
                _isConvertBackWhenOem7Set = true;
            }
        }
        private bool _isConvertBackWhenOemQuotesSet;
        private bool _convertBackWhenOemQuotes;
		/// <summary>
        /// Keyの値がOemQuotesの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenOemQuotes
        {
            get
            {
                return _convertBackWhenOemQuotes;
            }
            set
            {
                _convertBackWhenOemQuotes = value;
                _isConvertBackWhenOemQuotesSet = true;
            }
        }
        private bool _isConvertBackWhenOem8Set;
        private bool _convertBackWhenOem8;
		/// <summary>
        /// Keyの値がOem8の際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenOem8
        {
            get
            {
                return _convertBackWhenOem8;
            }
            set
            {
                _convertBackWhenOem8 = value;
                _isConvertBackWhenOem8Set = true;
            }
        }
        private bool _isConvertBackWhenOem102Set;
        private bool _convertBackWhenOem102;
		/// <summary>
        /// Keyの値がOem102の際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenOem102
        {
            get
            {
                return _convertBackWhenOem102;
            }
            set
            {
                _convertBackWhenOem102 = value;
                _isConvertBackWhenOem102Set = true;
            }
        }
        private bool _isConvertBackWhenOemBackslashSet;
        private bool _convertBackWhenOemBackslash;
		/// <summary>
        /// Keyの値がOemBackslashの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenOemBackslash
        {
            get
            {
                return _convertBackWhenOemBackslash;
            }
            set
            {
                _convertBackWhenOemBackslash = value;
                _isConvertBackWhenOemBackslashSet = true;
            }
        }
        private bool _isConvertBackWhenImeProcessedSet;
        private bool _convertBackWhenImeProcessed;
		/// <summary>
        /// Keyの値がImeProcessedの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenImeProcessed
        {
            get
            {
                return _convertBackWhenImeProcessed;
            }
            set
            {
                _convertBackWhenImeProcessed = value;
                _isConvertBackWhenImeProcessedSet = true;
            }
        }
        private bool _isConvertBackWhenSystemSet;
        private bool _convertBackWhenSystem;
		/// <summary>
        /// Keyの値がSystemの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenSystem
        {
            get
            {
                return _convertBackWhenSystem;
            }
            set
            {
                _convertBackWhenSystem = value;
                _isConvertBackWhenSystemSet = true;
            }
        }
        private bool _isConvertBackWhenOemAttnSet;
        private bool _convertBackWhenOemAttn;
		/// <summary>
        /// Keyの値がOemAttnの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenOemAttn
        {
            get
            {
                return _convertBackWhenOemAttn;
            }
            set
            {
                _convertBackWhenOemAttn = value;
                _isConvertBackWhenOemAttnSet = true;
            }
        }
        private bool _isConvertBackWhenDbeAlphanumericSet;
        private bool _convertBackWhenDbeAlphanumeric;
		/// <summary>
        /// Keyの値がDbeAlphanumericの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenDbeAlphanumeric
        {
            get
            {
                return _convertBackWhenDbeAlphanumeric;
            }
            set
            {
                _convertBackWhenDbeAlphanumeric = value;
                _isConvertBackWhenDbeAlphanumericSet = true;
            }
        }
        private bool _isConvertBackWhenOemFinishSet;
        private bool _convertBackWhenOemFinish;
		/// <summary>
        /// Keyの値がOemFinishの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenOemFinish
        {
            get
            {
                return _convertBackWhenOemFinish;
            }
            set
            {
                _convertBackWhenOemFinish = value;
                _isConvertBackWhenOemFinishSet = true;
            }
        }
        private bool _isConvertBackWhenDbeKatakanaSet;
        private bool _convertBackWhenDbeKatakana;
		/// <summary>
        /// Keyの値がDbeKatakanaの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenDbeKatakana
        {
            get
            {
                return _convertBackWhenDbeKatakana;
            }
            set
            {
                _convertBackWhenDbeKatakana = value;
                _isConvertBackWhenDbeKatakanaSet = true;
            }
        }
        private bool _isConvertBackWhenOemCopySet;
        private bool _convertBackWhenOemCopy;
		/// <summary>
        /// Keyの値がOemCopyの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenOemCopy
        {
            get
            {
                return _convertBackWhenOemCopy;
            }
            set
            {
                _convertBackWhenOemCopy = value;
                _isConvertBackWhenOemCopySet = true;
            }
        }
        private bool _isConvertBackWhenDbeHiraganaSet;
        private bool _convertBackWhenDbeHiragana;
		/// <summary>
        /// Keyの値がDbeHiraganaの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenDbeHiragana
        {
            get
            {
                return _convertBackWhenDbeHiragana;
            }
            set
            {
                _convertBackWhenDbeHiragana = value;
                _isConvertBackWhenDbeHiraganaSet = true;
            }
        }
        private bool _isConvertBackWhenOemAutoSet;
        private bool _convertBackWhenOemAuto;
		/// <summary>
        /// Keyの値がOemAutoの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenOemAuto
        {
            get
            {
                return _convertBackWhenOemAuto;
            }
            set
            {
                _convertBackWhenOemAuto = value;
                _isConvertBackWhenOemAutoSet = true;
            }
        }
        private bool _isConvertBackWhenDbeSbcsCharSet;
        private bool _convertBackWhenDbeSbcsChar;
		/// <summary>
        /// Keyの値がDbeSbcsCharの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenDbeSbcsChar
        {
            get
            {
                return _convertBackWhenDbeSbcsChar;
            }
            set
            {
                _convertBackWhenDbeSbcsChar = value;
                _isConvertBackWhenDbeSbcsCharSet = true;
            }
        }
        private bool _isConvertBackWhenOemEnlwSet;
        private bool _convertBackWhenOemEnlw;
		/// <summary>
        /// Keyの値がOemEnlwの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenOemEnlw
        {
            get
            {
                return _convertBackWhenOemEnlw;
            }
            set
            {
                _convertBackWhenOemEnlw = value;
                _isConvertBackWhenOemEnlwSet = true;
            }
        }
        private bool _isConvertBackWhenDbeDbcsCharSet;
        private bool _convertBackWhenDbeDbcsChar;
		/// <summary>
        /// Keyの値がDbeDbcsCharの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenDbeDbcsChar
        {
            get
            {
                return _convertBackWhenDbeDbcsChar;
            }
            set
            {
                _convertBackWhenDbeDbcsChar = value;
                _isConvertBackWhenDbeDbcsCharSet = true;
            }
        }
        private bool _isConvertBackWhenOemBackTabSet;
        private bool _convertBackWhenOemBackTab;
		/// <summary>
        /// Keyの値がOemBackTabの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenOemBackTab
        {
            get
            {
                return _convertBackWhenOemBackTab;
            }
            set
            {
                _convertBackWhenOemBackTab = value;
                _isConvertBackWhenOemBackTabSet = true;
            }
        }
        private bool _isConvertBackWhenDbeRomanSet;
        private bool _convertBackWhenDbeRoman;
		/// <summary>
        /// Keyの値がDbeRomanの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenDbeRoman
        {
            get
            {
                return _convertBackWhenDbeRoman;
            }
            set
            {
                _convertBackWhenDbeRoman = value;
                _isConvertBackWhenDbeRomanSet = true;
            }
        }
        private bool _isConvertBackWhenAttnSet;
        private bool _convertBackWhenAttn;
		/// <summary>
        /// Keyの値がAttnの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenAttn
        {
            get
            {
                return _convertBackWhenAttn;
            }
            set
            {
                _convertBackWhenAttn = value;
                _isConvertBackWhenAttnSet = true;
            }
        }
        private bool _isConvertBackWhenDbeNoRomanSet;
        private bool _convertBackWhenDbeNoRoman;
		/// <summary>
        /// Keyの値がDbeNoRomanの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenDbeNoRoman
        {
            get
            {
                return _convertBackWhenDbeNoRoman;
            }
            set
            {
                _convertBackWhenDbeNoRoman = value;
                _isConvertBackWhenDbeNoRomanSet = true;
            }
        }
        private bool _isConvertBackWhenCrSelSet;
        private bool _convertBackWhenCrSel;
		/// <summary>
        /// Keyの値がCrSelの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenCrSel
        {
            get
            {
                return _convertBackWhenCrSel;
            }
            set
            {
                _convertBackWhenCrSel = value;
                _isConvertBackWhenCrSelSet = true;
            }
        }
        private bool _isConvertBackWhenDbeEnterWordRegisterModeSet;
        private bool _convertBackWhenDbeEnterWordRegisterMode;
		/// <summary>
        /// Keyの値がDbeEnterWordRegisterModeの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenDbeEnterWordRegisterMode
        {
            get
            {
                return _convertBackWhenDbeEnterWordRegisterMode;
            }
            set
            {
                _convertBackWhenDbeEnterWordRegisterMode = value;
                _isConvertBackWhenDbeEnterWordRegisterModeSet = true;
            }
        }
        private bool _isConvertBackWhenExSelSet;
        private bool _convertBackWhenExSel;
		/// <summary>
        /// Keyの値がExSelの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenExSel
        {
            get
            {
                return _convertBackWhenExSel;
            }
            set
            {
                _convertBackWhenExSel = value;
                _isConvertBackWhenExSelSet = true;
            }
        }
        private bool _isConvertBackWhenDbeEnterImeConfigureModeSet;
        private bool _convertBackWhenDbeEnterImeConfigureMode;
		/// <summary>
        /// Keyの値がDbeEnterImeConfigureModeの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenDbeEnterImeConfigureMode
        {
            get
            {
                return _convertBackWhenDbeEnterImeConfigureMode;
            }
            set
            {
                _convertBackWhenDbeEnterImeConfigureMode = value;
                _isConvertBackWhenDbeEnterImeConfigureModeSet = true;
            }
        }
        private bool _isConvertBackWhenEraseEofSet;
        private bool _convertBackWhenEraseEof;
		/// <summary>
        /// Keyの値がEraseEofの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenEraseEof
        {
            get
            {
                return _convertBackWhenEraseEof;
            }
            set
            {
                _convertBackWhenEraseEof = value;
                _isConvertBackWhenEraseEofSet = true;
            }
        }
        private bool _isConvertBackWhenDbeFlushStringSet;
        private bool _convertBackWhenDbeFlushString;
		/// <summary>
        /// Keyの値がDbeFlushStringの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenDbeFlushString
        {
            get
            {
                return _convertBackWhenDbeFlushString;
            }
            set
            {
                _convertBackWhenDbeFlushString = value;
                _isConvertBackWhenDbeFlushStringSet = true;
            }
        }
        private bool _isConvertBackWhenPlaySet;
        private bool _convertBackWhenPlay;
		/// <summary>
        /// Keyの値がPlayの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenPlay
        {
            get
            {
                return _convertBackWhenPlay;
            }
            set
            {
                _convertBackWhenPlay = value;
                _isConvertBackWhenPlaySet = true;
            }
        }
        private bool _isConvertBackWhenDbeCodeInputSet;
        private bool _convertBackWhenDbeCodeInput;
		/// <summary>
        /// Keyの値がDbeCodeInputの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenDbeCodeInput
        {
            get
            {
                return _convertBackWhenDbeCodeInput;
            }
            set
            {
                _convertBackWhenDbeCodeInput = value;
                _isConvertBackWhenDbeCodeInputSet = true;
            }
        }
        private bool _isConvertBackWhenZoomSet;
        private bool _convertBackWhenZoom;
		/// <summary>
        /// Keyの値がZoomの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenZoom
        {
            get
            {
                return _convertBackWhenZoom;
            }
            set
            {
                _convertBackWhenZoom = value;
                _isConvertBackWhenZoomSet = true;
            }
        }
        private bool _isConvertBackWhenDbeNoCodeInputSet;
        private bool _convertBackWhenDbeNoCodeInput;
		/// <summary>
        /// Keyの値がDbeNoCodeInputの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenDbeNoCodeInput
        {
            get
            {
                return _convertBackWhenDbeNoCodeInput;
            }
            set
            {
                _convertBackWhenDbeNoCodeInput = value;
                _isConvertBackWhenDbeNoCodeInputSet = true;
            }
        }
        private bool _isConvertBackWhenNoNameSet;
        private bool _convertBackWhenNoName;
		/// <summary>
        /// Keyの値がNoNameの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenNoName
        {
            get
            {
                return _convertBackWhenNoName;
            }
            set
            {
                _convertBackWhenNoName = value;
                _isConvertBackWhenNoNameSet = true;
            }
        }
        private bool _isConvertBackWhenDbeDetermineStringSet;
        private bool _convertBackWhenDbeDetermineString;
		/// <summary>
        /// Keyの値がDbeDetermineStringの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenDbeDetermineString
        {
            get
            {
                return _convertBackWhenDbeDetermineString;
            }
            set
            {
                _convertBackWhenDbeDetermineString = value;
                _isConvertBackWhenDbeDetermineStringSet = true;
            }
        }
        private bool _isConvertBackWhenPa1Set;
        private bool _convertBackWhenPa1;
		/// <summary>
        /// Keyの値がPa1の際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenPa1
        {
            get
            {
                return _convertBackWhenPa1;
            }
            set
            {
                _convertBackWhenPa1 = value;
                _isConvertBackWhenPa1Set = true;
            }
        }
        private bool _isConvertBackWhenDbeEnterDialogConversionModeSet;
        private bool _convertBackWhenDbeEnterDialogConversionMode;
		/// <summary>
        /// Keyの値がDbeEnterDialogConversionModeの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenDbeEnterDialogConversionMode
        {
            get
            {
                return _convertBackWhenDbeEnterDialogConversionMode;
            }
            set
            {
                _convertBackWhenDbeEnterDialogConversionMode = value;
                _isConvertBackWhenDbeEnterDialogConversionModeSet = true;
            }
        }
        private bool _isConvertBackWhenOemClearSet;
        private bool _convertBackWhenOemClear;
		/// <summary>
        /// Keyの値がOemClearの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenOemClear
        {
            get
            {
                return _convertBackWhenOemClear;
            }
            set
            {
                _convertBackWhenOemClear = value;
                _isConvertBackWhenOemClearSet = true;
            }
        }
        private bool _isConvertBackWhenDeadCharProcessedSet;
        private bool _convertBackWhenDeadCharProcessed;
		/// <summary>
        /// Keyの値がDeadCharProcessedの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenDeadCharProcessed
        {
            get
            {
                return _convertBackWhenDeadCharProcessed;
            }
            set
            {
                _convertBackWhenDeadCharProcessed = value;
                _isConvertBackWhenDeadCharProcessedSet = true;
            }
        }
    }
}