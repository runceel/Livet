using Livet;
using System;
using System.Linq;
using System.Collections.Generic;
using System.Windows.Threading;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using System.Threading;
using System.Text;
using System.Windows;
using System.Diagnostics;
using System.IO;

using NUnit.Framework;
using Livet.NUnit.TestInfrastructures;

namespace Livet.NUnit
{
    [TestFixture()]
    public class ViewModelHelperTest
    {
        [Test()]
        public void LinkTest()
        {
            using (var dispatcher = new TestDispatcherContext())
            {
                var disposedCount = 0;

                //------------------Init
                var source = new ObservableCollection<int>() { 9, 8, 7 };

                var result = ViewModelHelper.CreateReadOnlyDispatcherCollection<int, TestViewModel>(
                    source,
                    i => new TestViewModel(i * i,() => disposedCount++),
                    dispatcher.Dispatcher);

                result.Count().Is(3);
                result[0].Number.Is(81);
                result[1].Number.Is(64);
                result[2].Number.Is(49);

                //------------------Add
                source.Add(1);

                result.Count().Is(4);
                result[3].Number.Is(1);

                //------------------Add & Remove
                source.Add(3);
                source.Add(4);
                source.Add(5);
                source.Add(6);
                source.Remove(5);

                result.Count().Is(7);
                result[4].Number.Is(9);
                result[5].Number.Is(16);
                result[6].Number.Is(36);

                //------------------Replace
                source[2] = 10;

                result.Count().Is(7);
                result[2].Number.Is(100);

                //------------------Clear
                source.Clear();

                result.Any().Is(false);

                //------------------Dispose
                result.Dispose();

                source.Add(1);

                result.Any().Is(false);

                disposedCount.Is(9);
            }
        }

        [Test()]
        public void OnDispatcherTest()
        {
            using (var dispatcher = new TestDispatcherContext())
            {
                bool propertyChangedCalled = false;
                bool collectionChangedCalled = false;

                Dispatcher.CurrentDispatcher.IsNot(dispatcher.Dispatcher);

                var source = new ObservableCollection<int>();
                var result = ViewModelHelper.CreateReadOnlyDispatcherCollection<int, int>(
                    source,
                    i => i * i,
                    dispatcher.Dispatcher);

                result.PropertyChanged += (sender, e) =>
                    {
                        propertyChangedCalled = true;
                        Dispatcher.CurrentDispatcher.Is(dispatcher.Dispatcher);
                    };

                result.CollectionChanged += (sender, e) =>
                    {
                        collectionChangedCalled = true;
                        Dispatcher.CurrentDispatcher.Is(dispatcher.Dispatcher);
                    };

                source.Add(1);

                propertyChangedCalled.Is(true);
                collectionChangedCalled.Is(true);
            }
        }
    }
}
