using Livet.EventListeners.WeakEvents;
using NUnit.Framework;
using System;
using Livet.NUnit;

namespace Livet.NUnit.EventListeners
{
    [TestFixture()]
    public class LivetWeakEventListenerTest
    {
        [Test()]
        public void LifeCycleTest()
        {
            var listener1Success = false;

            var eventPublisher = new TestEventPublisher();

            var listener1 = new LivetWeakEventListener<EventHandler, EventArgs>(
                h => new EventHandler(h),
                h => eventPublisher.EmptyEvent += h,
                h => eventPublisher.EmptyEvent -= h,
                (sender, e) => listener1Success = true);

            //------------------
            listener1Success.Is(false);

            eventPublisher.RaiseEmptyEvent();

            listener1Success.Is(true);

            //------------------
            listener1Success = false;

            listener1.Dispose();
            eventPublisher.RaiseEmptyEvent();

            listener1Success.Is(false);
        }

        [Test()]
        public void WeakEventTest()
        {
            var listener1Success = false;

            var eventPublisher = new TestEventPublisher();

            var listener1 = new LivetWeakEventListener<EventHandler, EventArgs>(
                h => new EventHandler(h),
                h => eventPublisher.EmptyEvent += h,
                h => eventPublisher.EmptyEvent -= h,
                (sender, e) => listener1Success = true);

            var listenerWeakReference = new WeakReference(listener1);

            //------------------
            listener1Success.Is(false);

            eventPublisher.RaiseEmptyEvent();

            listener1Success.Is(true);

            //------------------
            listener1Success = false;

            listener1 = null;

            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();

            eventPublisher.RaiseEmptyEvent();

            listener1Success.Is(false);
        }
    }
}
