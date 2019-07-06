using NUnit.Framework;
using System.Collections.Generic;
using System.ComponentModel;

namespace Livet.NUnit
{
    [TestFixture]
    public class NotificationObjectTest
    {
        [Test]
        public void RaisePropertyChangedIfSet()
        {
            var eventArgs = new List<PropertyChangedEventArgs>();
            var n = new RaisePropertyChangedIfSetTestObject();
            n.PropertyChanged += (_, e) => eventArgs.Add(e);

            n.Prop1 = "Changed";
            eventArgs.Count.Is(1);
            eventArgs[0].Is(x => x.PropertyName == nameof(RaisePropertyChangedIfSetTestObject.Prop1));
        }

        [Test]
        public void RaisePropertyChangedIfSetWithRelatedProperty()
        {
            var eventArgs = new List<PropertyChangedEventArgs>();
            var n = new RaisePropertyChangedIfSetWithRelatedPropertyTestObject();
            n.PropertyChanged += (_, e) => eventArgs.Add(e);
            n.Source = "test";
            n.Output.Is("Source is test");
            eventArgs.Count.Is(2);
            eventArgs[0].Is(x => x.PropertyName == nameof(RaisePropertyChangedIfSetWithRelatedPropertyTestObject.Source));
            eventArgs[1].Is(x => x.PropertyName == nameof(RaisePropertyChangedIfSetWithRelatedPropertyTestObject.Output));
        }

        [Test]
        public void RaisePropertyChangedIfSetWithManyRelatedProperties()
        {
            var eventArgs = new List<PropertyChangedEventArgs>();
            var n = new RaisePropertyChangedIfSetWithManyRelatedPropertiesTestObject();
            n.PropertyChanged += (_, e) => eventArgs.Add(e);
            n.Source = "test";
            n.Output1.Is("Output1: test");
            n.Output2.Is("Output2: test");
            eventArgs.Count.Is(3);
            eventArgs[0].Is(x => x.PropertyName == nameof(RaisePropertyChangedIfSetWithManyRelatedPropertiesTestObject.Source));
            eventArgs[1].Is(x => x.PropertyName == nameof(RaisePropertyChangedIfSetWithManyRelatedPropertiesTestObject.Output1));
            eventArgs[2].Is(x => x.PropertyName == nameof(RaisePropertyChangedIfSetWithManyRelatedPropertiesTestObject.Output2));
        }

        class RaisePropertyChangedIfSetTestObject : NotificationObject
        {

            private string _Prop1;

            public string Prop1
            {
                get => _Prop1;
                set => RaisePropertyChangedIfSet(ref _Prop1, value);
            }
        }

        class RaisePropertyChangedIfSetWithRelatedPropertyTestObject : NotificationObject
        {

            private string _Source;

            public string Source
            {
                get => _Source;
                set => RaisePropertyChangedIfSet(ref _Source, value, nameof(Output));
            }

            public string Output => $"Source is {Source}";
        }
        class RaisePropertyChangedIfSetWithManyRelatedPropertiesTestObject : NotificationObject
        {

            private string _Source;

            public string Source
            {
                get => _Source;
                set => RaisePropertyChangedIfSet(ref _Source, value, 
                    new[] { nameof(Output1), nameof(Output2) });
            }

            public string Output1 => $"Output1: {Source}";
            public string Output2 => $"Output2: {Source}";
        }
    }
}
