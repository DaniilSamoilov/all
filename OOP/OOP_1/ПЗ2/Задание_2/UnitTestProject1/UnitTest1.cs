using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using WindowsFormsApp1;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void FindNODEuclidTest1()
        {
            int a = 7396;
            int b = 1978;
            int c = 1204;
            int expected = 86;

            int actual = Form1.NOD(a, b, c);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void FindNODEuclidTest2()
        {
            int a = 7396;
            int b = 1978;
            int c = 1204;
            int d = 430;
            int expected = 86;

            int actual = Form1.NOD(a, b, c, d);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void FindNODEuclidTest3()
        {
            int a = 7396;
            int[] b = { 1204, 430, 258  };
            int expected = 86;

            int actual = Form1.NOD(a, b);

            Assert.AreEqual(expected, actual);
        }
    }
}
