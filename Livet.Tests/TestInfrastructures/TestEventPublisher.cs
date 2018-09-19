using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using System.Collections.Specialized;

namespace Livet.NUnit
{
    public class TestEventPublisher : INotifyPropertyChanged,INotifyCollectionChanged
    {
        public EventHandler EmptyEvent;

        public EventHandler<StringEventArgs> StringEvent;

        public event PropertyChangedEventHandler PropertyChanged;

        public event NotifyCollectionChangedEventHandler CollectionChanged;

        public object Dummy2 { get; set; }

        public void RaiseEmptyEvent()
        {
            var handler = EmptyEvent;

            if (handler != null)
            {
                handler(this, EventArgs.Empty);
            }
        }

        public void RaiseStringEvent(string arg)
        {
            var handler = StringEvent;

            if (handler != null)
            {
                handler(this,new StringEventArgs(arg));
            }
        }

        public void RaisePropertyChanged(string propertyName)
        {
            var handler = PropertyChanged;

            if (handler != null)
            {
                handler(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        public void RaiseCollectionChanged(NotifyCollectionChangedAction action,object item)
        {
            var handler = CollectionChanged;

            if (handler != null)
            {
                handler(this,new NotifyCollectionChangedEventArgs(action,item));
            }
        }
    }

    public class StringEventArgs : EventArgs
    {
        public StringEventArgs(string message)
        {
            Message = message;
        }

        public string Message
        {
            get;
            private set;
        }
    }
}
