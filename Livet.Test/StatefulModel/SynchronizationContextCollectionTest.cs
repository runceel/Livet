using Livet.StatefulModel;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;

namespace Livet.NUnit.StatefulModel
{
    [TestFixture]
    public class SynchronizationContextCollectionTest
    {
        private TestSynchronizationContext _context;
        private SynchronizationContextCollection<string> _target;
        private List<NotifyCollectionChangedEventArgs> _collectionChanged;

        [SetUp]
        public void SetUp()
        {
            _context = new TestSynchronizationContext();
            _target = new SynchronizationContextCollection<string>(_context);
            _collectionChanged = new List<NotifyCollectionChangedEventArgs>();
            _target.CollectionChanged += (_, e) => _collectionChanged.Add(e);
        }

        [TearDown]
        public void TearDown()
        {
            _target = null;
            _context = null;
        }

        [Test]
        public void BasicUsage()
        {
            _target.Add("a");
            _target.Add("b");
            _target.Add("c");
            _target.Remove("b");
            _target[1] = "C";

            _target.Is("a", "C");
            _context.Count.Is(5);

            _collectionChanged.Select(x => x.Action)
                .Is(
                    NotifyCollectionChangedAction.Add,
                    NotifyCollectionChangedAction.Add,
                    NotifyCollectionChangedAction.Add,
                    NotifyCollectionChangedAction.Remove,
                    NotifyCollectionChangedAction.Replace
                );
            _collectionChanged.SelectMany(x => x.NewItems?.Cast<string>() ?? Enumerable.Empty<string>())
                .Is("a", "b", "c", "C");
            _collectionChanged[3].OldItems.Cast<string>().Is("b");
            _collectionChanged[4].Is(
                x => x.Action == NotifyCollectionChangedAction.Replace && x.NewItems.Cast<string>().ElementAt(0) == "C" && x.NewStartingIndex == 1);
        }

        class TestSynchronizationContext : SynchronizationContext
        {
            public int Count { get; set; }
            public override void Post(SendOrPostCallback d, object state)
            {
                Count++;
                d(state);
            }
        }
    }
}
