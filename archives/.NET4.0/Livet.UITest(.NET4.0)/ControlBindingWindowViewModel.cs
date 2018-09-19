using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Livet.UITest
{
    public class ControlBindingWindowViewModel : ViewModel
    {

        #region Text変更通知プロパティ
        private string _Text;

        public string Text
        {
            get
            { return _Text; }
            set
            { 
                if (_Text == value)
                    return;
                _Text = value;
                RaisePropertyChanged("Text");
            }
        }
        #endregion


        #region Password変更通知プロパティ
        private string _Password;

        public string Password
        {
            get
            { return _Password; }
            set
            { 
                if (_Password == value)
                    return;
                _Password = value;
                RaisePropertyChanged("Password");
            }
        }
        #endregion


        #region ButtonMouseOver変更通知プロパティ
        private bool _ButtonMouseOver;

        public bool ButtonMouseOver
        {
            get
            { return _ButtonMouseOver; }
            set
            { 
                if (_ButtonMouseOver == value)
                    return;
                _ButtonMouseOver = value;
                RaisePropertyChanged("ButtonMouseOver");
            }
        }
        #endregion


        #region WebBrowserSource変更通知プロパティ
        private Uri _WebBrowserSource;

        public Uri WebBrowserSource
        {
            get
            { return _WebBrowserSource; }
            set
            { 
                if (_WebBrowserSource == value)
                    return;
                _WebBrowserSource = value;
                RaisePropertyChanged("WebBrowserSource");
            }
        }
        #endregion

        public void SetSource()
        {
            WebBrowserSource = new Uri("http://yahoo.co.jp");
        }


    }
}
