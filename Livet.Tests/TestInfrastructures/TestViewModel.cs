using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Livet.NUnit.TestInfrastructures
{
    public class TestViewModel : ViewModel
    {
        Action _disposeAction;
        Action _test1Action;
        Action<string> _test2Action;

        public TestViewModel(int i, Action test1Action, Action<string> test2Action, Action disposeAction)
        {
            Number = i;
            _disposeAction = disposeAction;
            _test1Action = test1Action;
            _test2Action = test2Action;
        }

        public TestViewModel(int i) : this(i, () => { }, _ => { }, () => { }) { }

        public TestViewModel(int i, Action disposeAction) : this(i, () => { }, _ => { }, disposeAction) { }

        public TestViewModel(int i, Action test1Action, Action<string> test2Action) : this(i, test1Action,test2Action, () => { }) { }

        public int Number
        {
            get;
            private set;
        }

        public void Test1()
        {
            _test1Action();
        }

        public void Test2(string argument)
        {
            _test2Action(argument);
        }

        protected override void Dispose(bool disposing)
        {
            _disposeAction();
            base.Dispose(disposing);
        }
    }
}
