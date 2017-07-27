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

    }
}
