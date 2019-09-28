using System;
using System.Collections.Generic;
using NUnit.Framework;
using Livet.Commands;
using System.Windows.Input;
using System.Threading;

namespace Livet.NUnit.Commands
{
    [TestFixture()]
    public class CommandTest
    {
        [Test()]
        [Timeout(3000)]
        public void CanExecuteHandlerBasicTest()
        {
            using (var dispatcher = new TestDispatcherContext())
            {
                DispatcherHelper.UIDispatcher = dispatcher.Dispatcher;

                var handlerResultList = new List<string>();

                var command = new ViewModelCommand(() => { }, () => true);

                EventHandler handler1 = (sender, e) => handlerResultList.Add("Handler1");
                EventHandler handler2 = (sender, e) => handlerResultList.Add("Handler2");
                EventHandler handler3 = (sender, e) => handlerResultList.Add("Handler3");

                var semaphore = new Semaphore(0, 1);
                EventHandler releaseHandler = (sender, e) => semaphore.Release();

                command.CanExecuteChanged += handler1;
                command.CanExecuteChanged += handler2;
                command.CanExecuteChanged += handler3;
                command.CanExecuteChanged += releaseHandler;

                command.RaiseCanExecuteChanged();
                semaphore.WaitOne(1000).Is(true);

                handlerResultList.Count.Is(3);
                handlerResultList.Is("Handler1", "Handler2", "Handler3");

                handlerResultList.Clear();

                command.CanExecuteChanged -= handler2;

                command.RaiseCanExecuteChanged();
                semaphore.WaitOne(1000).Is(true);

                handlerResultList.Count.Is(2);
                handlerResultList.Is("Handler1", "Handler3");
            }
        }

        [Test()]
        [Timeout(3000)]
        public void WeakHandlerTest()
        {
#if DEBUG
            Assert.Warn("This test case should run on release build.");
            return;
#endif
            using (var dispatcher = new TestDispatcherContext())
            {
                int eventReceivedCount = 0;

                DispatcherHelper.UIDispatcher = dispatcher.Dispatcher;

                var handlerResultList = new List<string>();

                var command = new ViewModelCommand(() => { }, () => true);

                var realReceiver1 = new EventReceiver(command, () => eventReceivedCount++);
                var realReceiver2 = new EventReceiver(command, () => eventReceivedCount++);

                var receiver1 = new WeakReference(realReceiver1);
                var receiver2 = new WeakReference(realReceiver2);
                var receiver3 = new EventReceiver(command, () => eventReceivedCount++);

                var semaphore = new Semaphore(0, 1);
                var releaseReceiver = new EventReceiver(command, () => semaphore.Release());

                command.RaiseCanExecuteChanged();
                semaphore.WaitOne(1000).Is(true);

                eventReceivedCount.Is(3);

                realReceiver1 = null;
                realReceiver2 = null;

                GC.Collect();
                GC.WaitForPendingFinalizers();
                GC.Collect();
                receiver1.IsAlive.Is(false);
                receiver2.IsAlive.Is(false);

                receiver3.IsNot(null); // do not remove this line. this line is for no released receiver3 by GC.
                releaseReceiver.IsNot(null); // do not remove this line. this line is for no released releaseReceiver by GC.

                command.RaiseCanExecuteChanged();
                semaphore.WaitOne(1000).Is(true);
                eventReceivedCount.Is(4);
            }
        }

        public class EventReceiver
        {
            public EventReceiver(ICommand command,Action eventReceivedAction)
            {
                HandlerStrongReference = new EventHandler((sender,e) => eventReceivedAction());
                command.CanExecuteChanged += HandlerStrongReference;
            }

            public EventHandler HandlerStrongReference
            {
                get;
                private set;
            }

        }
    }
}
