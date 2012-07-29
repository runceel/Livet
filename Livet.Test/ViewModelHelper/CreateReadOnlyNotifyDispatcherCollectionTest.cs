using Livet;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.ObjectModel;
using System.Windows.Threading;
using System.Collections.Generic;
using System.Linq;
using System.Collections;
using System.Windows.Controls;
using System.Threading;

namespace Livet.Test
{
    [TestClass()]
    public class CreateReadOnlyNotifyDispatcherCollectionTest
    {
        #region テストリソース

        #region テスト用ViewModel型とModel型定義
        private class TestViewModel
        {
            public string Name
            {
                get;
                set;
            }

            public int Age
            {
                get;
                set;
            }

            public DateTime Birthday
            {
                get;
                set;
            }

            public string StringBirthday
            {
                get;
                set;
            }
        }

        private class TestModel
        {
            public string Name
            {
                get;
                set;
            }

            public int Age
            {
                get;
                set;
            }

            public DateTime Birthday
            {
                get;
                set;
            }
        }
        #endregion

        #region テスト共通フィールド
        private ObservableCollection<TestModel> _source;

        private Func<TestModel, TestViewModel> _create;

        private DispatcherCollection<TestViewModel> _expectSourceCollection;

        private ReadOnlyDispatcherCollection<TestViewModel> _expectCollection;

        private Dispatcher TestDispatcher;
        #endregion

        //CollectionAssert用IComparer
        private class ViewModelComparer : IComparer
        {
            public int Compare(object x, object y)
            {
                var ex = (TestViewModel)x;
                var ac = (TestViewModel)y;

                if (ex.Name != ac.Name)
                    return 1;
                if (ex.Age != ac.Age)
                    return 2;
                if (ex.Birthday != ac.Birthday)
                    return 3;
                if (ex.StringBirthday != ac.StringBirthday)
                    return 4;

                return 0;
            }
        }

        [TestInitialize]
        public void InitializeTestField()
        {
            TestDispatcher = Dispatcher.CurrentDispatcher;

            var model1 = new TestModel() { Name = "テスト太郎", Age = 27, Birthday = new DateTime(1983, 10, 23) };
            var model2 = new TestModel() { Name = "テスト花子", Age = 21, Birthday = new DateTime(1989, 4, 13)};
            var model3 = new TestModel() { Name = "テスト二郎", Age = 24 };

            _source = new ObservableCollection<TestModel>(new TestModel[] { model1, model2, model3 });

            var viewModel1 = new TestViewModel() { Name = "テスト太郎", Age = 27, Birthday = new DateTime(1983, 10, 23), StringBirthday = "1983/10/23" };
            var viewModel2 = new TestViewModel() { Name = "テスト花子", Age = 21, Birthday = new DateTime(1989, 4, 13), StringBirthday = "1989/04/13"};
            var viewModel3 = new TestViewModel() { Name = "テスト二郎", Age = 24, Birthday = DateTime.MinValue, StringBirthday = string.Empty};

            _expectSourceCollection = new DispatcherCollection<TestViewModel>(new ObservableCollection<TestViewModel>(new TestViewModel[] { viewModel1, viewModel2, viewModel3 }), TestDispatcher);

            _expectCollection = new ReadOnlyDispatcherCollection<TestViewModel>(_expectSourceCollection);

            _create = m => new TestViewModel()
            {
                Name = m.Name,
                Age = m.Age,
                Birthday = m.Birthday,
                StringBirthday = m.Birthday == DateTime.MinValue ? string.Empty : m.Birthday.ToString("yyyy/MM/dd")
            };
        }

        public TestContext TestContext
        {
            get;
            set;
        }

        #endregion

        /// <summary>
        /// 作成されたラッパーの中身がソースと等しい事を確認
        /// </summary>
        [TestMethod]
        public void CreateTest()
        {
            var target = ViewModelHelper.CreateReadOnlyDispatcherCollection<TestViewModel,TestModel>(
                _source,
                _create,
                TestDispatcher);

            CollectionAssert.AreEqual(_expectCollection, target,new ViewModelComparer(),"生成されたコレクションの中身が正しくありません");
            Assert.AreEqual(3, target.Count, "Countプロパティが更新されていません");
        }

        /// <summary>
        /// sourceパラメータがnullの時にArgumentExeceptionが発生する事を確認
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException),"sourceがnullなのに例外が発生していません")]
        public void CreateTestWithSourceNull()
        {

            var target = ViewModelHelper.CreateReadOnlyDispatcherCollection<TestViewModel, TestModel>(
                null,
                _create,
                TestDispatcher);
        }

        /// <summary>
        /// createパラメータがnullの時にArgumentExceptionが発生する事を確認
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException),"createがnullなのに例外が発生していません")]
        public void CreateTestWithCreateNull()
        {
            var target = ViewModelHelper.CreateReadOnlyDispatcherCollection<TestViewModel, TestModel>(
                _source,
                null,
                TestDispatcher);
        }

        /// <summary>
        /// 削除が伝播する事を確認
        /// </summary>
        [TestMethod]
        public void RemoveTest()
        {
            var target = ViewModelHelper.CreateReadOnlyDispatcherCollection<TestViewModel, TestModel>(
                _source,
                _create,
                TestDispatcher);

            _source.RemoveAt(1);
            _expectSourceCollection.RemoveAt(1);
            
            CollectionAssert.AreEqual(_expectSourceCollection, target, new ViewModelComparer(), "削除が正常に伝播していません");
            Assert.AreEqual(2, target.Count, "Countプロパティが更新されていません");
        }

        /// <summary>
        /// 追加が伝播する事を確認
        /// </summary>
        [TestMethod]
        public void AddTest()
        {
            var target = ViewModelHelper.CreateReadOnlyDispatcherCollection<TestViewModel, TestModel>(
                _source,
                _create,
                TestDispatcher);

            _source.Add(new TestModel() { Name = "test" });
            var addViewModel = new TestViewModel() { Name = "test", StringBirthday = string.Empty };
            _expectSourceCollection.Add(addViewModel);

            CollectionAssert.AreEqual(_expectSourceCollection, target, new ViewModelComparer(), "Addによる追加が正常に伝播していません");
            Assert.AreEqual(4, target.Count, "Countプロパティが更新されていません");
        }

        /// <summary>
        /// 挿入が伝播する事を確認
        /// </summary>
        [TestMethod]
        public void InsertTest()
        {
            var target = ViewModelHelper.CreateReadOnlyDispatcherCollection<TestViewModel, TestModel>(
                _source,
                _create,
                TestDispatcher);

            _source.Insert(1, new TestModel() { Name = "test2" });
            var insertViewModel = new TestViewModel() { Name = "test2", StringBirthday = string.Empty };
            _expectSourceCollection.Insert(1, insertViewModel);

            CollectionAssert.AreEqual(_expectSourceCollection, target, new ViewModelComparer(), "Insertによる追加が正常に伝播していません");
            Assert.AreEqual(4, target.Count, "Countプロパティが更新されていません");
        }

        /// <summary>
        /// 移動が伝播する事を確認
        /// </summary>
        [TestMethod]
        public void MoveTest()
        {
            var target = ViewModelHelper.CreateReadOnlyDispatcherCollection<TestViewModel, TestModel>(
                _source,
                _create,
                TestDispatcher);

            _source.Move(0, 2);
            _expectSourceCollection.Move(0, 2);

            CollectionAssert.AreEqual(_expectSourceCollection, target, new ViewModelComparer(), "Moveによる移動が正常に伝播していません");
        }

        /// <summary>
        /// 置換が伝播する事を確認
        /// </summary>
        [TestMethod]
        public void ReplaceTest()
        {
            var target = ViewModelHelper.CreateReadOnlyDispatcherCollection<TestViewModel, TestModel>(
                _source,
                _create,
                TestDispatcher);

            _source[1] = new TestModel { Name="testtest"};
            _expectSourceCollection[1] = new TestViewModel { Name = "testtest", StringBirthday = string.Empty };

            CollectionAssert.AreEqual(_expectSourceCollection, target, new ViewModelComparer(), "Replaceによる置換が正常に伝播していません");
        }

        /// <summary>
        /// 全項目削除が伝播する事を確認
        /// </summary>
        [TestMethod]
        public void ClearTest()
        {
            var target = ViewModelHelper.CreateReadOnlyDispatcherCollection<TestViewModel, TestModel>(
                _source,
                _create,
                TestDispatcher);

            _source.Clear();
            _expectSourceCollection.Clear();

            CollectionAssert.AreEqual(_expectSourceCollection, target, new ViewModelComparer(), "Clearによる全削除が正常に伝播していません");
            Assert.AreEqual(0, target.Count, "Countプロパティが更新されていません");
        }

        /// <summary>
        /// 追加・挿入・削除・移動・全項目削除を行って、伝播する事を確認
        /// </summary>
        [TestMethod]
        public void CompositChangeTest()
        {
            var target = ViewModelHelper.CreateReadOnlyDispatcherCollection<TestViewModel, TestModel>(
                _source,
                _create,
                TestDispatcher);

            _source.RemoveAt(1);
            _expectSourceCollection.RemoveAt(1);
            
            CollectionAssert.AreEqual(_expectSourceCollection, target, new ViewModelComparer(), "削除が正常に伝播していません");
            Assert.AreEqual(2, target.Count, "Countプロパティが更新されていません");

            _source.Add(new TestModel(){Name = "test"});
            var addViewModel = new TestViewModel() { Name = "test", StringBirthday = string.Empty};
            _expectSourceCollection.Add(addViewModel);

            CollectionAssert.AreEqual(_expectSourceCollection, target, new ViewModelComparer(), "Addによる追加が正常に伝播していません");
            Assert.AreEqual(3, target.Count, "Countプロパティが更新されていません");

            _source.Insert(1,new TestModel(){Name="test2"});
            var insertViewModel = new TestViewModel() { Name = "test2", StringBirthday = string.Empty };
            _expectSourceCollection.Insert(1, insertViewModel);

            CollectionAssert.AreEqual(_expectSourceCollection, target, new ViewModelComparer(), "Insertによる追加が正常に伝播していません");
            Assert.AreEqual(4, target.Count, "Countプロパティが更新されていません");

            _source.Move(1, 3);
            _expectSourceCollection.Move(1, 3);

            CollectionAssert.AreEqual(_expectSourceCollection, target, new ViewModelComparer(), "Moveによる移動が正常に伝播していません");

            _source.Clear();
            _expectSourceCollection.Clear();

            CollectionAssert.AreEqual(_expectSourceCollection, target, new ViewModelComparer(), "Clearによる全削除が正常に伝播していません");
            Assert.AreEqual(0, target.Count, "Countプロパティが更新されていません");
        }

        /// <summary>
        /// WeakEventを使用していないとリークする事の確認
        /// </summary>
        [TestMethod]
        public void LeakTest()
        {
            var souceCollection = new DispatcherCollection<TestViewModel>(_expectCollection, TestDispatcher);

            WeakReference targetWeakReference = new WeakReference(
                new ReadOnlyDispatcherCollection<TestViewModel>(souceCollection));

            Assert.IsTrue(targetWeakReference.IsAlive, "インスタンスが作成されていません");

            GC.Collect();
            GC.WaitForPendingFinalizers();

            //sourceCollectionがGCされていていないので、
            //sourceCollectionのイベントを購読しているtargetWeakReferenceの中身も消えない。
            Assert.IsTrue(souceCollection != null, "ソースコレクションが消えています");

            Assert.IsTrue(targetWeakReference.IsAlive, "リークしていません");
        }

        /// <summary>
        /// WeakEventを使用しているとリークしない事の確認
        /// </summary>
        [TestMethod]
        public void NotLeakTest()
        {
            WeakReference targetWeakReference = new WeakReference(
                ViewModelHelper.CreateReadOnlyDispatcherCollection<TestViewModel, TestModel>(
                _source,
                _create,
                TestDispatcher));

            Assert.IsTrue(targetWeakReference.IsAlive, "インスタンスが作成されていません");

            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();

            //_sourceはフィールドなので、_sourceのイベントを購読している
            //targetWeakReferenceの中身は消えないはずだけど、
            //ViewModelHelperがWeakEventかましているので消えれる。
            Assert.IsTrue(!targetWeakReference.IsAlive, "リークしています");

        }

        /// <summary>
        /// GC後も変更が伝播する事を確認
        /// </summary>
        [TestMethod]
        public void ObserveAfterGCTest()
        {
            var target = ViewModelHelper.CreateReadOnlyDispatcherCollection<TestViewModel, TestModel>(
                _source,
                _create,
                TestDispatcher);

            GC.Collect();
            GC.WaitForPendingFinalizers();

            _source.RemoveAt(1);
            _expectSourceCollection.RemoveAt(1);

            CollectionAssert.AreEqual(_expectSourceCollection, target, new ViewModelComparer(), "削除が正常に伝播していません");
            Assert.AreEqual(2, target.Count, "Countプロパティが更新されていません");
        }


    }
}
