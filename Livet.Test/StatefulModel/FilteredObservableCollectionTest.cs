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
    public class FilteredObservableCollectionTest
    {
        private FilteredObservableCollection<string> _target;
        private List<NotifyCollectionChangedEventArgs> _collectionChanged;
        [SetUp]
        public void SetUp()
        {
            _target = new FilteredObservableCollection<string>(x => !x.Contains("x"));
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
            _target.Add("aaa");
            _target.Add("axa");
            _target.Add("bbb");
            _target.Add("bxb");
            _target.Is("aaa", "bbb");

            _collectionChanged.SelectMany(x => x.NewItems.Cast<string>())
                .Is("aaa", "bbb");
            _collectionChanged.Select(x => x.Action)
                .Is(
                    NotifyCollectionChangedAction.Add,
                    NotifyCollectionChangedAction.Add
                );
        }
    }
}
