using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using Livet.Behaviors;
using Livet.NUnit.TestInfrastructures;

namespace Livet.NUnit.Behaviors
{
    [TestFixture()]
    public class MethodBinderTest
    {
        [Test()]
        public void SimpleCaseTest()
        {
            var test1CalledCount = 0;
            var testObject = new TestViewModel(0, () => test1CalledCount++, s => {});

            var binder = new MethodBinder();

            binder.Invoke((object)testObject, "Test1");
            test1CalledCount.Is(1);
            binder.Invoke((object)testObject, "Test1");
            test1CalledCount.Is(2);

            //System.Threading.Thread.Sleep(3000);

            //キャッシュが更新されないか目視
            testObject = new TestViewModel(0, () => test1CalledCount++, s => { });

            binder.Invoke((object)testObject, "Test1");
            test1CalledCount.Is(3);
            binder.Invoke((object)testObject, "Test1");
            test1CalledCount.Is(4);

            //System.Threading.Thread.Sleep(3000);

            //キャッシュ辞書からメソッドキャッシュを取得するか目視
            binder = new MethodBinder();
            binder.Invoke((object)testObject, "Test1");
            test1CalledCount.Is(5);
            binder.Invoke((object)testObject, "Test1");
            test1CalledCount.Is(6);
        }

        [Test()]
        public void SimpleCaseTest2()
        {
            var test2CalledCount = 0;
            string test2Argument = null;
            var testObject = new TestViewModel(0, () => { }, s => { test2CalledCount++; test2Argument = s; });

            var binder = new MethodBinderWithArgument();

            binder.Invoke((object)testObject, "Test2","a");
            test2CalledCount.Is(1);
            test2Argument.Is("a");
            binder.Invoke((object)testObject, "Test2","b");
            test2CalledCount.Is(2);
            test2Argument.Is("b");

            //System.Threading.Thread.Sleep(3000);

            //キャッシュが更新されないか目視
            testObject = new TestViewModel(0, () => { }, s => { test2CalledCount++; test2Argument = s; });

            binder.Invoke((object)testObject, "Test2", "a");
            test2CalledCount.Is(3);
            test2Argument.Is("a");
            binder.Invoke((object)testObject, "Test2", "b");
            test2CalledCount.Is(4);
            test2Argument.Is("b");

            //System.Threading.Thread.Sleep(3000);

            //キャッシュ辞書からメソッドキャッシュを取得するか目視
            binder = new MethodBinderWithArgument();
            binder.Invoke((object)testObject, "Test2", "a");
            test2CalledCount.Is(5);
            test2Argument.Is("a");
            binder.Invoke((object)testObject, "Test2", "b");
            test2CalledCount.Is(6);
            test2Argument.Is("b");
        }
    }
}
