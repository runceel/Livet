using System;
using System.Collections;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Threading;
using Livet.Annotations;
using Livet.EventListeners.WeakEvents;

namespace Livet.Messaging
{
    public sealed class MessageListener : IDisposable,
        IEnumerable<KeyValuePair<string, ConcurrentBag<Action<InteractionMessage>>>>
    {
        [NotNull]
        private readonly ConcurrentDictionary<string, ConcurrentBag<Action<InteractionMessage>>> _actionDictionary =
            new ConcurrentDictionary<string, ConcurrentBag<Action<InteractionMessage>>>();

        [NotNull] private readonly LivetWeakEventListener<EventHandler<InteractionMessageRaisedEventArgs>,
            InteractionMessageRaisedEventArgs> _listener;

        [NotNull] private readonly WeakReference<InteractionMessenger> _source;
        [NotNull] private Dispatcher _dispatcher;

        private bool _disposed;

        public MessageListener([NotNull] InteractionMessenger messenger)
        {
            if (messenger == null) throw new ArgumentNullException(nameof(messenger));

            _dispatcher = Dispatcher.CurrentDispatcher;
            _source = new WeakReference<InteractionMessenger>(messenger);
            _listener =
                new LivetWeakEventListener<EventHandler<InteractionMessageRaisedEventArgs>,
                    InteractionMessageRaisedEventArgs>
                (
                    h => h,
                    h => messenger.Raised += h,
                    h => messenger.Raised -= h,
                    MessageReceived
                );
        }

        public MessageListener([NotNull] InteractionMessenger messenger, [CanBeNull] string messageKey,
            [NotNull] Action<InteractionMessage> action)
            : this(messenger)
        {
            if (action == null) throw new ArgumentNullException(nameof(action));
            if (messageKey == null) messageKey = string.Empty;

            RegisterAction(messageKey, action);
        }

        public MessageListener([NotNull] InteractionMessenger messenger, [NotNull] Action<InteractionMessage> action)
            : this(messenger, null, action) { }

        [NotNull]
        public Dispatcher Dispatcher
        {
            get { return _dispatcher; }
            set { _dispatcher = value ?? throw new ArgumentNullException(nameof(value)); }
        }

        public void Dispose()
        {
            Dispose(true);

            // ReSharper disable once GCSuppressFinalizeForTypeWithoutDestructor
            GC.SuppressFinalize(this);
        }

        IEnumerator<KeyValuePair<string, ConcurrentBag<Action<InteractionMessage>>>>
            IEnumerable<KeyValuePair<string, ConcurrentBag<Action<InteractionMessage>>>>.GetEnumerator()
        {
            ThrowExceptionIfDisposed();
            return _actionDictionary.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            ThrowExceptionIfDisposed();
            return _actionDictionary.GetEnumerator();
        }

        public void RegisterAction([NotNull] Action<InteractionMessage> action)
        {
            if (action == null) throw new ArgumentNullException(nameof(action));

            ThrowExceptionIfDisposed();
            var dic = _actionDictionary.GetOrAdd(string.Empty, _ => new ConcurrentBag<Action<InteractionMessage>>())
                      ?? throw new InvalidOperationException();

            dic.Add(action);
        }

        public void RegisterAction([NotNull] string messageKey, [NotNull] Action<InteractionMessage> action)
        {
            if (messageKey == null) throw new ArgumentNullException(nameof(messageKey));
            if (action == null) throw new ArgumentNullException(nameof(action));

            ThrowExceptionIfDisposed();
            var dic = _actionDictionary.GetOrAdd(messageKey, _ => new ConcurrentBag<Action<InteractionMessage>>())
                      ?? throw new InvalidOperationException();

            dic.Add(action);
        }

        private void MessageReceived(object sender, [NotNull] InteractionMessageRaisedEventArgs e)
        {
            if (e == null) throw new ArgumentNullException(nameof(e));
            if (_disposed) return;

            var message = e.Message;
            var clonedMessage = (InteractionMessage) message.Clone();

            clonedMessage.Freeze();

            DoActionOnDispatcher(() => { GetValue(e, clonedMessage); });

            var responsiveMessage = message as ResponsiveInteractionMessage;

            object response;
            if (responsiveMessage != null &&
                (response = ((ResponsiveInteractionMessage) clonedMessage).Response) != null)
                responsiveMessage.Response = response;
        }

        private void GetValue([NotNull] InteractionMessageRaisedEventArgs e, InteractionMessage cloneMessage)
        {
            if (e == null) throw new ArgumentNullException(nameof(e));

            var result = _source.TryGetTarget(out _);

            if (!result) return;

            if (e.Message.MessageKey != null)
            {
                _actionDictionary.TryGetValue(e.Message.MessageKey, out var list);

                if (list != null)
                {
                    foreach (var action in list)
                        action(cloneMessage);
                }
            }

            _actionDictionary.TryGetValue(string.Empty, out var allList);
            if (allList == null) return;

            foreach (var action in allList)
                action(cloneMessage);
        }

        private void DoActionOnDispatcher([NotNull] Action action)
        {
            if (action == null) throw new ArgumentNullException(nameof(action));

            if (Dispatcher.CheckAccess())
                action();
            else
                Dispatcher.Invoke(action);
        }

        public void Add([NotNull] Action<InteractionMessage> action)
        {
            if (action == null) throw new ArgumentNullException(nameof(action));

            RegisterAction(action);
        }

        public void Add([NotNull] string messageKey, [NotNull] Action<InteractionMessage> action)
        {
            if (messageKey == null) throw new ArgumentNullException(nameof(messageKey));
            if (action == null) throw new ArgumentNullException(nameof(action));

            RegisterAction(messageKey, action);
        }

        public void Add([NotNull] string messageKey, [NotNull] params Action<InteractionMessage>[] actions)
        {
            if (messageKey == null) throw new ArgumentNullException(nameof(messageKey));
            if (actions == null) throw new ArgumentNullException(nameof(actions));

            foreach (var action in actions.Where(a => a != null)) RegisterAction(messageKey, action);
        }

        private void ThrowExceptionIfDisposed()
        {
            if (_disposed) throw new ObjectDisposedException("EventListener");
        }

        private void Dispose(bool disposing)
        {
            if (_disposed) return;

            if (disposing) _listener.Dispose();
            _disposed = true;
        }
    }
}