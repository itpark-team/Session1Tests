using ClassLibrarySmyslov13;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace UnitTestProjectSmyslov13
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod_SUM_3_5_finish_8()
        {
            CalcClass calc = new CalcClass();

            int expected = 8;
            int actual = calc.Sum(3, 5);

            Assert.AreEqual(expected, actual);
        }
    }
}
