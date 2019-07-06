using System;
using System.Xml.Serialization;
using Livet.Annotations;
using Livet.Messaging;

namespace Livet
{
    /// <summary>
    ///     ViewModelの基底クラスです。
    /// </summary>
    [Serializable]
    public abstract class ViewModel : NotificationObject, IDisposable
    {
        [NonSerialized] private LivetCompositeDisposable _compositeDisposable;

        [NonSerialized] private bool _disposed;

        [NonSerialized] private InteractionMessenger _messenger;

        /// <summary>
        ///     このViewModelクラスの基本CompositeDisposableです。
        /// </summary>
        [XmlIgnore]
        [NotNull]
        public LivetCompositeDisposable CompositeDisposable
        {
            get { return _compositeDisposable ?? (_compositeDisposable = new LivetCompositeDisposable()); }
            set { _compositeDisposable = value; }
        }

        /// <summary>
        ///     このViewModelクラスの基本Messengerインスタンスです。
        /// </summary>
        [XmlIgnore]
        [NotNull]
        public InteractionMessenger Messenger
        {
            get { return _messenger ?? (_messenger = new InteractionMessenger()); }
            set { _messenger = value; }
        }

        /// <summary>
        ///     このインスタンスによって使用されているすべてのリソースを解放します。
        /// </summary>
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (_disposed) return;
            if (disposing) _compositeDisposable?.Dispose();
            _disposed = true;
        }
    }
}