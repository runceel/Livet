using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Threading;
using NUnit.Framework;
using Livet.Messaging;

namespace Livet.NUnit.Messaging
{
    [TestFixture]
    public class MessageListenerTest
    {
        [Test()]
        public void LifeCycleTest()
        {
            var listenerSuccess = false;

            var publisher = new InteractionMessenger();
            var message = new GenericInteractionMessage<int>(1);

            var listener = new MessageListener(publisher, m => 
            { 
                ((GenericInteractionMessage<int>)m).Value.Is(1);
                listenerSuccess = true;
            });

            //------------------
            listenerSuccess.Is(false);

            publisher.Raise(message);

            listenerSuccess.Is(true);

            //------------------
            listenerSuccess = false;

            listener.Dispose();
            publisher.Raise(message);

            listenerSuccess.Is(false);

            try
            {
                listener.RegisterAction(_ =>{});
            }
            catch (Exception e)
            {
                e.GetType().Is(typeof(ObjectDisposedException));
            }
        }

        [Test()]
        public void AddHandlerKindTest()
        {
            var handler1Called = false;
            var handler2Called = false;
            var handler3Called = false;
            var handler4Called = false;
            var handler5Called = false;

            var publisher = new InteractionMessenger();
            var message0 = new GenericInteractionMessage<int>(1);
            var message1 = new GenericInteractionMessage<int>(1, "Dummy1");
            var message2 = new GenericInteractionMessage<int>(1, "Dummy2");

            var listener1 = new MessageListener(publisher)
            {
                {"Dummy1", _ => handler1Called = true},
                {"Dummy2", 
                        _ => handler2Called = true,
                        _ => handler3Called = true
                },
                _ => handler4Called = true,
                {"Dummy1", _ => handler5Called = true}
            };

            publisher.Raise(message0);

            handler1Called.Is(false);
            handler2Called.Is(false);
            handler3Called.Is(false);
            handler4Called.Is(true);
            handler5Called.Is(false);

            handler4Called = false;

            publisher.Raise(message1);

            handler1Called.Is(true);
            handler2Called.Is(false);
            handler3Called.Is(false);
            handler4Called.Is(true);
            handler5Called.Is(true);

            handler1Called = false;
            handler4Called = false;
            handler5Called = false;

            publisher.Raise(message2);

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

            publisher.Raise(message0);
            publisher.Raise(message1);
            publisher.Raise(message2);

            handler1Called.Is(false);
            handler2Called.Is(false);
            handler3Called.Is(false);
            handler4Called.Is(false);
            handler5Called.Is(false);

        }

        [Test()]
        public void ResponsiveMessageTest()
        {
            var listenerSuccess = false;

            var publisher = new InteractionMessenger();
            var message = new GenericResponsiveInteractionMessage<int,string>(1);

            var listener = new MessageListener(publisher, m =>
            {
                var rm = (GenericResponsiveInteractionMessage<int, string>)m;
                rm.Value.Is(1);
                rm.Response = "test";
                listenerSuccess = true;
            });

            listenerSuccess.Is(false);

            publisher.GetResponse(message).Response.Is("test");
            listenerSuccess.Is(true);
        }

        [Test()]
        public void SourceReferenceMemoryLeakTest()
        {
            var handler1Called = false;

            var publisherStrongReference = new InteractionMessenger();
            var publisherWeakReference = new WeakReference<InteractionMessenger>(publisherStrongReference);
            var message = new GenericInteractionMessage<int>(1, "Dummy1");

            var listener = new MessageListener(publisherStrongReference);
            listener.RegisterAction("Dummy1", _ =>handler1Called = true);

            publisherStrongReference.Raise(message);

            handler1Called.Is(true);

            listener.Dispose();
            publisherStrongReference = null;

            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();

            InteractionMessenger resultPublisher = null;
            publisherWeakReference.TryGetTarget(out resultPublisher).Is(false);
            resultPublisher.IsNull();
        }
    }
}
