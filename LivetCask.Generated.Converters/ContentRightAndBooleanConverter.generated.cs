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
    /// ContentRight列挙体とbool値の相互変換を行うIValueConverterです。
    /// </summary>
    public class ContentRightAndBooleanConverter : IValueConverter
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
        private ContentRight _convertWhenTrue;
		/// <summary>
        /// ソース値がTrueの際にどのContentRight列挙体メンバーに変換するかを指定、または取得します。
        /// </summary>
        public ContentRight ConvertWhenTrue
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
        private ContentRight _convertWhenFalse;
		/// <summary>
        /// ソース値がFalseの際にどのContentRight列挙体メンバーに変換するかを指定、または取得します。
        /// </summary>
        public ContentRight ConvertWhenFalse
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
            if (!(value is ContentRight)) throw new ArgumentException();

            var enumValue = (ContentRight)value;

			switch(enumValue.ToString())
			{
				case "View":
					if (_isConvertBackWhenViewSet)
					{
						return ConvertBackWhenView;
					}
					break;
				case "Edit":
					if (_isConvertBackWhenEditSet)
					{
						return ConvertBackWhenEdit;
					}
					break;
				case "Print":
					if (_isConvertBackWhenPrintSet)
					{
						return ConvertBackWhenPrint;
					}
					break;
				case "Extract":
					if (_isConvertBackWhenExtractSet)
					{
						return ConvertBackWhenExtract;
					}
					break;
				case "ObjectModel":
					if (_isConvertBackWhenObjectModelSet)
					{
						return ConvertBackWhenObjectModel;
					}
					break;
				case "Owner":
					if (_isConvertBackWhenOwnerSet)
					{
						return ConvertBackWhenOwner;
					}
					break;
				case "ViewRightsData":
					if (_isConvertBackWhenViewRightsDataSet)
					{
						return ConvertBackWhenViewRightsData;
					}
					break;
				case "Forward":
					if (_isConvertBackWhenForwardSet)
					{
						return ConvertBackWhenForward;
					}
					break;
				case "Reply":
					if (_isConvertBackWhenReplySet)
					{
						return ConvertBackWhenReply;
					}
					break;
				case "ReplyAll":
					if (_isConvertBackWhenReplyAllSet)
					{
						return ConvertBackWhenReplyAll;
					}
					break;
				case "Sign":
					if (_isConvertBackWhenSignSet)
					{
						return ConvertBackWhenSign;
					}
					break;
				case "DocumentEdit":
					if (_isConvertBackWhenDocumentEditSet)
					{
						return ConvertBackWhenDocumentEdit;
					}
					break;
				case "Export":
					if (_isConvertBackWhenExportSet)
					{
						return ConvertBackWhenExport;
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
        /// ContentRightの値をbool値に変換する際のデフォルト値を指定、または取得します。
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

        private bool _isConvertBackWhenViewSet;
        private bool _convertBackWhenView;
		/// <summary>
        /// ContentRightの値がViewの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenView
        {
            get
            {
                return _convertBackWhenView;
            }
            set
            {
                _convertBackWhenView = value;
                _isConvertBackWhenViewSet = true;
            }
        }
        private bool _isConvertBackWhenEditSet;
        private bool _convertBackWhenEdit;
		/// <summary>
        /// ContentRightの値がEditの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenEdit
        {
            get
            {
                return _convertBackWhenEdit;
            }
            set
            {
                _convertBackWhenEdit = value;
                _isConvertBackWhenEditSet = true;
            }
        }
        private bool _isConvertBackWhenPrintSet;
        private bool _convertBackWhenPrint;
		/// <summary>
        /// ContentRightの値がPrintの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
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
        private bool _isConvertBackWhenExtractSet;
        private bool _convertBackWhenExtract;
		/// <summary>
        /// ContentRightの値がExtractの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenExtract
        {
            get
            {
                return _convertBackWhenExtract;
            }
            set
            {
                _convertBackWhenExtract = value;
                _isConvertBackWhenExtractSet = true;
            }
        }
        private bool _isConvertBackWhenObjectModelSet;
        private bool _convertBackWhenObjectModel;
		/// <summary>
        /// ContentRightの値がObjectModelの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenObjectModel
        {
            get
            {
                return _convertBackWhenObjectModel;
            }
            set
            {
                _convertBackWhenObjectModel = value;
                _isConvertBackWhenObjectModelSet = true;
            }
        }
        private bool _isConvertBackWhenOwnerSet;
        private bool _convertBackWhenOwner;
		/// <summary>
        /// ContentRightの値がOwnerの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenOwner
        {
            get
            {
                return _convertBackWhenOwner;
            }
            set
            {
                _convertBackWhenOwner = value;
                _isConvertBackWhenOwnerSet = true;
            }
        }
        private bool _isConvertBackWhenViewRightsDataSet;
        private bool _convertBackWhenViewRightsData;
		/// <summary>
        /// ContentRightの値がViewRightsDataの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenViewRightsData
        {
            get
            {
                return _convertBackWhenViewRightsData;
            }
            set
            {
                _convertBackWhenViewRightsData = value;
                _isConvertBackWhenViewRightsDataSet = true;
            }
        }
        private bool _isConvertBackWhenForwardSet;
        private bool _convertBackWhenForward;
		/// <summary>
        /// ContentRightの値がForwardの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenForward
        {
            get
            {
                return _convertBackWhenForward;
            }
            set
            {
                _convertBackWhenForward = value;
                _isConvertBackWhenForwardSet = true;
            }
        }
        private bool _isConvertBackWhenReplySet;
        private bool _convertBackWhenReply;
		/// <summary>
        /// ContentRightの値がReplyの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenReply
        {
            get
            {
                return _convertBackWhenReply;
            }
            set
            {
                _convertBackWhenReply = value;
                _isConvertBackWhenReplySet = true;
            }
        }
        private bool _isConvertBackWhenReplyAllSet;
        private bool _convertBackWhenReplyAll;
		/// <summary>
        /// ContentRightの値がReplyAllの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenReplyAll
        {
            get
            {
                return _convertBackWhenReplyAll;
            }
            set
            {
                _convertBackWhenReplyAll = value;
                _isConvertBackWhenReplyAllSet = true;
            }
        }
        private bool _isConvertBackWhenSignSet;
        private bool _convertBackWhenSign;
		/// <summary>
        /// ContentRightの値がSignの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenSign
        {
            get
            {
                return _convertBackWhenSign;
            }
            set
            {
                _convertBackWhenSign = value;
                _isConvertBackWhenSignSet = true;
            }
        }
        private bool _isConvertBackWhenDocumentEditSet;
        private bool _convertBackWhenDocumentEdit;
		/// <summary>
        /// ContentRightの値がDocumentEditの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenDocumentEdit
        {
            get
            {
                return _convertBackWhenDocumentEdit;
            }
            set
            {
                _convertBackWhenDocumentEdit = value;
                _isConvertBackWhenDocumentEditSet = true;
            }
        }
        private bool _isConvertBackWhenExportSet;
        private bool _convertBackWhenExport;
		/// <summary>
        /// ContentRightの値がExportの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenExport
        {
            get
            {
                return _convertBackWhenExport;
            }
            set
            {
                _convertBackWhenExport = value;
                _isConvertBackWhenExportSet = true;
            }
        }
    }
}