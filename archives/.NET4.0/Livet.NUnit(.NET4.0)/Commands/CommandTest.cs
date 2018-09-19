using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using Livet.Commands;
using System.Windows.Input;

namespace Livet.NUnit.Commands
{
    [TestFixture()]
    public class CommandTest
    {
        [Test()]
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

                command.CanExecuteChanged += handler1;
                command.CanExecuteChanged += handler2;
                command.CanExecuteChanged += handler3;

                command.RaiseCanExecuteChanged();
                System.Threading.Thread.Sleep(1000);

                handlerResultList.Count.Is(3);
                handlerResultList[0].Is("Handler1");
                handlerResultList[1].Is("Handler2");
                handlerResultList[2].Is("Handler3");

                handlerResultList.Clear();

                command.CanExecuteChanged -= handler2;

                command.RaiseCanExecuteChanged();
                System.Threading.Thread.Sleep(1000);

                handlerResultList.Count.Is(2);
                handlerResultList[0].Is("Handler1");
                handlerResultList[1].Is("Handler3");
            }
        }

        [Test()]
        public void WeakHandlerTest()
        {
            using (var dispatcher = new TestDispatcherContext())
            {
                int eventReceivedCount = 0;

                DispatcherHelper.UIDispatcher = dispatcher.Dispatcher;

                var handlerResultList = new List<string>();

                var command = new ViewModelCommand(() => { }, () => true);

                var realReceiver1 = new EventReceiver(command,() => eventReceivedCount++);
                var realReceiver2 = new EventReceiver(command, () => eventReceivedCount++);

                var receiver1 = new WeakReference(realReceiver1);
                var receiver2 = new WeakReference(realReceiver2);
                var receiver3 = new EventReceiver(command, () => eventReceivedCount++);

                command.RaiseCanExecuteChanged();
                System.Threading.Thread.Sleep(1000);

                eventReceivedCount.Is(3);

                realReceiver1 = null;
                realReceiver2 = null;

                GC.Collect();
                GC.WaitForPendingFinalizers();
                GC.Collect();

                receiver1.IsAlive.Is(false);
                receiver2.IsAlive.Is(false);
                receiver3.IsNot(null);

                command.RaiseCanExecuteChanged();
                System.Threading.Thread.Sleep(1000);
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
