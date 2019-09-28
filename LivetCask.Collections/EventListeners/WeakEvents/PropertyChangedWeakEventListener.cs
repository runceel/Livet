using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;

namespace Livet.Collections.EventListeners.WeakEvents
{
    public sealed class PropertyChangedWeakEventListener : WeakEventListener<PropertyChangedEventHandler, PropertyChangedEventArgs>, IEnumerable<KeyValuePair<string, List<PropertyChangedEventHandler>>>
    {
        private readonly AnonymousPropertyChangedEventHandlerBag _bag;

        public PropertyChangedWeakEventListener(INotifyPropertyChanged source)
        {
            _bag = new AnonymousPropertyChangedEventHandlerBag(source);
            Initialize(
                h => new PropertyChangedEventHandler(h),
                h => source.PropertyChanged += h,
                h => source.PropertyChanged -= h,
                (sender, e) => _bag.ExecuteHandler(e));
        }

        public PropertyChangedWeakEventListener(INotifyPropertyChanged source, PropertyChangedEventHandler handler)
        {
            _bag = new AnonymousPropertyChangedEventHandlerBag(source, handler);
            Initialize(
                 h => new PropertyChangedEventHandler(h),
                 h => source.PropertyChanged += h,
                 h => source.PropertyChanged -= h,
                 (sender, e) => _bag.ExecuteHandler(e));
        }

        public void RegisterHandler(PropertyChangedEventHandler handler)
        {
            ThrowExceptionIfDisposed();
            _bag.RegisterHandler(handler);
        }

        public void RegisterHandler(string propertyName, PropertyChangedEventHandler handler)
        {
            ThrowExceptionIfDisposed();
            _bag.RegisterHandler(propertyName, handler);
        }

        IEnumerator<KeyValuePair<string, List<PropertyChangedEventHandler>>> IEnumerable<KeyValuePair<string, List<PropertyChangedEventHandler>>>.GetEnumerator()
        {
            ThrowExceptionIfDisposed();
            return
                ((IEnumerable<KeyValuePair<string, List<PropertyChangedEventHandler>>>)_bag)
                    .GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            ThrowExceptionIfDisposed();
            return ((IEnumerable<KeyValuePair<string, List<PropertyChangedEventHandler>>>)_bag).GetEnumerator();
        }

        public void Add(PropertyChangedEventHandler handler)
        {
            ThrowExceptionIfDisposed();
            _bag.Add(handler);
        }

        public void Add(string propertyName, PropertyChangedEventHandler handler)
        {
            ThrowExceptionIfDisposed();
            _bag.Add(propertyName, handler);
        }


        public void Add(string propertyName, params PropertyChangedEventHandler[] handlers)
        {
            ThrowExceptionIfDisposed();
            _bag.Add(propertyName, handlers);
        }
    }
}
