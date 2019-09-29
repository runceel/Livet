using Livet.StatefulModel;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace Livet.NUnit.StatefulModel
{
    [TestFixture]
    public class ObservableSynchronizedCollectionTest
    {
        private ObservableSynchronizedCollection<string> _target;
        private List<NotifyCollectionChangedEventArgs> _collectionChanged;
        [SetUp]
        public void SetUp()
        {
            _target = new ObservableSynchronizedCollection<string>();
            _collectionChanged = new List<NotifyCollectionChangedEventArgs>();
            _target.CollectionChanged += (_, args) => _collectionChanged.Add(args);
        }

        [TearDown]
        public void TearDown()
        {
            _target = null;
            _collectionChanged = null;
        }

        [Test]
        public void ConstructorTest()
        {
            var c = new ObservableSynchronizedCollection<string>(new[] { "a", "b", "c" });
            c.Count.Is(3);
        }

        [Test]
        public void BasicUsage()
        {
            _target.Count.Is(0);

            _target.Add("xxx");
            _collectionChanged.Count.Is(1);
            var collectionChangedEventArgs = _collectionChanged.First();
            collectionChangedEventArgs.IsNotNull();
            collectionChangedEventArgs.Action.Is(NotifyCollectionChangedAction.Add);
            collectionChangedEventArgs.NewItems.Count.Is(1);
            collectionChangedEventArgs.NewItems.Cast<string>().First().Is("xxx");
        }

        [Test]
        public void InsertTest()
        {
            _target.Add("1");
            _target.Add("2");
            _target.Insert(1, "xxx");

            _target.Is("1", "xxx", "2");
            _collectionChanged.SelectMany(x => x.NewItems.Cast<string>())
                .Is("1", "2", "xxx");
            _collectionChanged.Select(x => x.Action)
                .Is(NotifyCollectionChangedAction.Add, NotifyCollectionChangedAction.Add, NotifyCollectionChangedAction.Add);
        }

        [Test]
        public void RemoveTest()
        {
            _target.Add("1");
            _target.Add("2");

            _target.Remove("1");
            _target.Is("2");

            _collectionChanged.Select(x => x.Action)
                .Is(NotifyCollectionChangedAction.Add, NotifyCollectionChangedAction.Add, NotifyCollectionChangedAction.Remove);
            _collectionChanged.SelectMany(x => x.NewItems?.Cast<string>() ?? Enumerable.Empty<string>())
                .Is("1", "2");
            _collectionChanged.Last().OldItems.Count.Is(1);
            _collectionChanged.Last().OldItems.Cast<string>().Is("1");
        }
    }
}
