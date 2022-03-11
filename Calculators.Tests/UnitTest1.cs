using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Calculators.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Calculators_SixAndTree_ReturnTwo()
        {
            var division = new Division();
            var expected = 2;
            var actual = division.Calculate(6, 3);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        [ExpectedException(typeof(DivideByZeroException))]
        public void Calculators_SixAndZero_ReturnException()
        {
            var division = new Division();
            var actual = division.Calculate(6, 0);
        }
    }

}
