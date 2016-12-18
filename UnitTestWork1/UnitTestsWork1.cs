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
            int actualSize = CountArray(form.workers);
            Assert.AreEqual(expectedSize, actualSize);
        }

        private int CountArray(Worker[] workerArray)
        {
            int count=0;
            for(int i = 0; i < workerArray.Length; i++)
            {
                if (workerArray[i] != null)
                    count++;
            }
            return count;
        }
    }
}
