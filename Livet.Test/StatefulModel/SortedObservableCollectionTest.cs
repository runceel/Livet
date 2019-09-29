using Livet.StatefulModel;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace Livet.NUnit.StatefulModel
{
    [TestFixture]
    public class SortedObservableCollectionTest
    {
        private SortedObservableCollection<(int key, string value), int> _target;
        private List<NotifyCollectionChangedEventArgs> _collectionChanged;

        [SetUp]
        public void SetUp()
        {
            _target = new SortedObservableCollection<(int key, string value), int>(x => x.key);
            _collectionChanged = new List<NotifyCollectionChangedEventArgs>();
            _target.CollectionChanged += (_, e) => _collectionChanged.Add(e);
        }

        [TearDown]
        public void TearDown()
        {
            _target = null;
            _collectionChanged = null;
        }

        [Test]
        public void BasicUsage()
        {
            _target.Add((100, "max"));
            _target.Add((0, "min"));
            _target.Add((50, "mid"));

            _target.Count.Is(3);
            _target.Is(
                (0, "min"),
                (50, "mid"),
                (100, "max")
            );

            _collectionChanged.Select(x => x.Action)
                .Is(NotifyCollectionChangedAction.Add, NotifyCollectionChangedAction.Add, NotifyCollectionChangedAction.Add);
            _collectionChanged.Select(x => x.NewStartingIndex)
                .Is(0, 0, 1);
        }
    }
}
