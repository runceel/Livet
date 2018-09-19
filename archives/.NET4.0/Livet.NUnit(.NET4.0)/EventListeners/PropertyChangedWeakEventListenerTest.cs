using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Livet.EventListeners.WeakEvents;
using NUnit.Framework;
using System.ComponentModel;

namespace Livet.NUnit.EventListeners
{
    [TestFixture()]
    public class PropertyChangedWeakEventListenerTest
    {
        [Test()]
        public void BasicConstructorLifeCycleTest()
        {
            var listenerSuccess = false;

            var publisher = new TestEventPublisher();

            var listener = new PropertyChangedWeakEventListener(publisher, (sender, e) => listenerSuccess = true);

            //------------------
            listenerSuccess.Is(false);

            publisher.RaisePropertyChanged(string.Empty);

            listenerSuccess.Is(true);

            //------------------
            listenerSuccess = false;

            listener.Dispose();
            publisher.RaisePropertyChanged(string.Empty);

            listenerSuccess.Is(false);

            try
            {
                listener.RegisterHandler((sender, e) => listenerSuccess = true);
            }
            catch (Exception e)
            {
                e.GetType().Is(typeof(ObjectDisposedException));
            }

        }

        [Test()]
        public void MultipleHandlerLifeCycleTest()
        {
            var handler1Success = false;
            var handler2Success = false;

            var publisher = new TestEventPublisher();

            var listener = new PropertyChangedWeakEventListener(publisher);

            //------------------
            handler1Success.Is(false);
            handler2Success.Is(false);

            publisher.RaisePropertyChanged(string.Empty);

            handler1Success.Is(false);
            handler2Success.Is(false);

            //------------------
            listener.RegisterHandler((sender, e) => handler1Success = true);

            publisher.RaisePropertyChanged(string.Empty);

            handler1Success.Is(true);
            handler2Success.Is(false);

            //------------------
            handler1Success = false;
            handler2Success = false;

            listener.RegisterHandler((sender, e) => handler2Success = true);

            publisher.RaisePropertyChanged(string.Empty);

            handler1Success.Is(true);
            handler2Success.Is(true);

            //------------------
            handler1Success = false;
            handler2Success = false;

            listener.Dispose();
            publisher.RaisePropertyChanged(string.Empty);

            handler1Success.Is(false);
            handler2Success.Is(false);
        }

        [Test()]
        public void FilteredHandlerLifeCycleTest()
        {
            var handler1Called = false;
            var handler2Called = false;
            var handler3Called = false;

            var publisher = new TestEventPublisher();

            var listener = new PropertyChangedWeakEventListener(publisher);

            listener.RegisterHandler("Dummy1", (sender, e) => { e.PropertyName.Is("Dummy1"); handler1Called = true; });
            listener.RegisterHandler("Dummy2", (sender, e) => { e.PropertyName.Is("Dummy2"); handler2Called = true; });
            listener.RegisterHandler("Dummy1", (sender, e) => { e.PropertyName.Is("Dummy1"); handler3Called = true; });

            publisher.RaisePropertyChanged("Dummy1");
            publisher.RaisePropertyChanged("Dummy2");

            handler1Called.Is(true);
            handler2Called.Is(true);
            handler3Called.Is(true);

            //------------------
            handler1Called = false;
            handler2Called = false;
            handler3Called = false;

            listener.Dispose();
            publisher.RaisePropertyChanged("Dummy1");
            publisher.RaisePropertyChanged("Dummy2");

            handler1Called.Is(false);
            handler2Called.Is(false);
            handler3Called.Is(false);
        }

        [Test()]
        public void AddHandlerKindTest()
        {
            var handler1Called = false;
            var handler2Called = false;
            var handler3Called = false;
            var handler4Called = false;
            var handler5Called = false;

            var publisher = new TestEventPublisher();
            var listener1 = new PropertyChangedWeakEventListener(publisher)
            {
                {"Dummy1", (sender, e) => { e.PropertyName.Is("Dummy1"); handler1Called = true; }},
                {() => publisher.Dummy2, 
                        (sender, e) => { e.PropertyName.Is("Dummy2"); handler2Called = true;},
                        (sender, e) => { e.PropertyName.Is("Dummy2"); handler3Called = true;}
                },
                (sender,e) => handler4Called = true,
                {"Dummy1", (sender, e) => { e.PropertyName.Is("Dummy1"); handler5Called = true; }}
            };

            publisher.RaisePropertyChanged(null);

            handler1Called.Is(false);
            handler2Called.Is(false);
            handler3Called.Is(false);
            handler4Called.Is(true);
            handler5Called.Is(false);

            handler4Called = false;

            publisher.RaisePropertyChanged("Dummy1");

            handler1Called.Is(true);
            handler2Called.Is(false);
            handler3Called.Is(false);
            handler4Called.Is(true);
            handler5Called.Is(true);

            handler1Called = false;
            handler4Called = false;
            handler5Called = false;

            publisher.RaisePropertyChanged("Dummy2");

            handler1Called.Is(false);
            handler2Called.Is(true);
            handler3Called.Is(true);
            handler4Called.Is(true);
            handler5Called.Is(false);

            handler1Called = false;
            handler2Called = false;
            handler3Called = false;
            handler4Called = false;
            handler5Called = false;

            listener1.Dispose();

            publisher.RaisePropertyChanged("Dummy1");
            publisher.RaisePropertyChanged("Dummy2");

            handler1Called.Is(false);
            handler2Called.Is(false);
            handler3Called.Is(false);
            handler4Called.Is(false);
            handler5Called.Is(false);

        }

        [Test()]
        public void MultiThreadHandlerTest()
        {
            var publisher = new TestEventPublisher();

            var listener = new PropertyChangedWeakEventListener(publisher);

            var handlerCalledCount = 0;

            var parentTask = new Task(() =>
            {
                var tf = new TaskFactory(TaskCreationOptions.AttachedToParent, TaskContinuationOptions.AttachedToParent);

                for (int i = 0; i < 50; i++)
                {
                    tf.StartNew(() =>
                    {
                        for (int f = 0; f < 500; f++)
                        {
                            listener.RegisterHandler("Dummy1", (sender, e) => { e.PropertyName.Is("Dummy1"); handlerCalledCount++; });
                        }

                    });
                }
            });

            parentTask.Start();
            parentTask.Wait();

            handlerCalledCount.Is(0);

            publisher.RaisePropertyChanged("Dummy1");

            handlerCalledCount.Is(25000);

            handlerCalledCount = 0;

            listener.Dispose();
            publisher.RaisePropertyChanged("Dummy1");

            handlerCalledCount.Is(0);
        }

        [Test()]
        public void SourceReferenceMemoryLeakTest()
        {
            var handler1Called = false;

            var publisherStrongReference = new TestEventPublisher();
            var publisherWeakReference = new WeakReference<TestEventPublisher>(publisherStrongReference);

            var listener = new PropertyChangedWeakEventListener(publisherStrongReference);
            listener.RegisterHandler("Dummy1", (sender, e) => { e.PropertyName.Is("Dummy1"); handler1Called = true; });

            publisherStrongReference.RaisePropertyChanged("Dummy1");

            handler1Called.Is(true);

            listener.Dispose();
            publisherStrongReference = null;

            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();

            TestEventPublisher resultPublisher = null;
            publisherWeakReference.TryGetTarget(out resultPublisher).Is(false);
            resultPublisher.IsNull();
        }

        [Test()]
        public void WeakEventTest()
        {
            var listener1Success = false;

            var eventPublisher = new TestEventPublisher();

            var listener1 = new PropertyChangedWeakEventListener(eventPublisher, (sender, e) => listener1Success = true);

            var listenerWeakReference = new WeakReference(listener1);

            //------------------
            listener1Success.Is(false);

            eventPublisher.RaisePropertyChanged(null);

            listener1Success.Is(true);

            //------------------
            listener1Success = false;

            listener1 = null;

            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();

            eventPublisher.RaisePropertyChanged(null);

            listener1Success.Is(false);
        }

        private class HandlerMemoryLeakTestClass : IDisposable
        {
            public readonly PropertyChangedWeakEventListener Listener;

            public HandlerMemoryLeakTestClass(INotifyPropertyChanged publisher)
            {
                Listener = new PropertyChangedWeakEventListener(publisher);

                // This handler refers "this".
                PropertyChangedEventHandler handler = (sender, e) => { ToString(); };
                Listener.RegisterHandler(handler);
                Listener.RegisterHandler("Dummy1", handler);
            }

            public void Dispose()
            {
                Listener.Dispose();
            }
        }

        [Test()]
        public void HandlerMemoryLeakTest()
        {
            var publisher = new TestEventPublisher();

            var testObject = new HandlerMemoryLeakTestClass(publisher);
            var dummyWeakReference = new WeakReference<HandlerMemoryLeakTestClass>(testObject);

            testObject.Dispose();
            testObject = null;

            GC.Collect();
            GC.WaitForPendingFinalizers();

            HandlerMemoryLeakTestClass result = null;
            dummyWeakReference.TryGetTarget(out result).Is(false);
            result.IsNull();
        }
    }
}
