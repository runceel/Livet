using Livet.StatefulModel;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace Livet.NUnit.StatefulModel
{
    [TestFixture]
    public class ConvertingTest
    {
        [Test]
        public void ToReadOnlyTest()
        {
            var src = new ObservableSynchronizedCollection<string>();
        }
    }
}
