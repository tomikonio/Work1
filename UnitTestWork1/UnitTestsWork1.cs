using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using work1;

namespace UnitTestWork1
{
    [TestClass]
    public class UnitTestsWork1
    {
        [TestMethod]
        public void TestGenarationOfWorkers()
        {
            var form = new Form1();
            int expectedSize = 10000;
            form.addListview();
            Assert.AreEqual(expectedSize, form.workers.Length);
        }
    }
}
