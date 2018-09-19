using System;
using Livet.Messaging;
using System.Xml.Serialization;

namespace Livet
{
    /// <summary>
    /// ViewModelの基底クラスです。
    /// </summary>
    [Serializable]
    public abstract class ViewModel : NotificationObject,IDisposable
    {
        [NonSerialized]
        private bool _disposed;
        [NonSerialized]
        private InteractionMessenger _messenger;
        [NonSerialized]
        private LivetCompositeDisposable _compositeDisposable;

        /// <summary>
        /// このViewModelクラスの基本CompositeDisposableです。
        /// </summary>
        [XmlIgnore]
        public LivetCompositeDisposable CompositeDisposable
        {
            get
            {
                if (_compositeDisposable == null)
                {
                    _compositeDisposable = new LivetCompositeDisposable();
                }
                return _compositeDisposable;
            }
            set
            {
                _compositeDisposable = value;
            }
        }

        /// <summary>
        /// このViewModelクラスの基本Messegerインスタンスです。
        /// </summary>
        [XmlIgnore]
        public InteractionMessenger Messenger
        {
            get
            {
                if (_messenger == null)
                {
                    _messenger = new InteractionMessenger();
                }
                return _messenger;
            }
            set
            {
                _messenger = value;
            }
        }

        /// <summary>
        /// このインスタンスによって使用されているすべてのリソースを解放します。
        /// </summary>
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (_disposed) return;
            if (disposing)
            {
                if (_compositeDisposable != null)
                {
                    _compositeDisposable.Dispose();
                }
            }
            _disposed = true;
        }
    }
}