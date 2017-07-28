using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NumericSequenceCore;

namespace NumericSequenceTest
{
    [TestClass]
    public class NumericSequenceTest
    {
        [TestMethod]
        public void AllTest()
        {
            var numService = new NumericSequenceService();
            numService.TheNumber = 10;
            var allList = numService.All();
            Assert.AreEqual(allList.Count, 11);
        }

        [TestMethod]
        public void OddTest()
        {
            var numService = new NumericSequenceService();
            numService.TheNumber = 10;
            var oddList = numService.Odd();
            foreach(var num in oddList)
            {
                Assert.AreNotEqual(num % 2, 0);
            }
        }

        [TestMethod]
        public void EvenTest()
        {
            var numService = new NumericSequenceService();
            numService.TheNumber = 10;
            var evenList = numService.Even();
            foreach (var num in evenList)
            {
                Assert.AreEqual(num % 2, 0);
            }
        }

        [TestMethod]
        public void MultiplerTest()
        {
            var numService = new NumericSequenceService();
            numService.TheNumber = 15;
            var multiplerList = numService.Multipler();
            for (int i = 0; i <= numService.TheNumber; i++)
            {
                if ((string) multiplerList[i] == "C")
                {
                    Assert.AreEqual(i%3, 0);
                }

                if ((string) multiplerList[i] == "E")
                {
                    Assert.AreEqual(i%5, 0);
                }

                if ((string) multiplerList[i] == "Z")
                {
                    Assert.AreEqual(i%15, 0);
                }
            }
        }

        [TestMethod]
        public void FibonacciTest()
        {
            var numService = new NumericSequenceService();
            numService.TheNumber = 50;
            var fibonacciList = numService.FibonacciGenerate();
            Assert.AreEqual((int) fibonacciList[0], 0);
            Assert.AreEqual((int) fibonacciList[1], 1);

            for (int i = 2; (int) fibonacciList[i-1] <= numService.TheNumber; i++)
            {
                if ((int)fibonacciList[i - 1] + (int)fibonacciList[i - 2] > numService.TheNumber)
                    break;
                Assert.AreEqual((int)fibonacciList[i], (int)fibonacciList[i - 1] + (int)fibonacciList[i - 2]);
            }

        }


    }
}
