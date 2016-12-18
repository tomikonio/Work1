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

        [TestMethod]
        public void TestBubleSort()
        {
            var form = new Form1();
            
            form.addListview();
            form.bubblesort();
            form.sortTable();
            bool istrue = isorted(form.workers);
            Assert.AreEqual(true, istrue);

        }

        private bool isorted(Worker[] workerArray)
        {
            for(int i = 0;i< workerArray.Length; i++)
            {
                if (i != workerArray.Length - 1)
                {
                    if (workerArray[i].salary > workerArray[i + 1].salary)
                        return false;
                }
            }
            return true;
        }

        [TestMethod]
        public void QuickSortTest()
        {
            var form = new Form1();
            form.addListview();
            form.Quicksort(0,form.workers.Length-1);
            form.sortTable();
        }
    }
}
