using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using WindowsFormsApp1;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void FindNODEuclidTest()
        {
            int a = 298467352;
            int b = 569484;
            int expected = 4;

            int actual = Form1.NOD(a, b).nod;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void FindNODSteinTest()
        {
            int a = 298467352;
            int b = 569484;
            int expected = 4;

            int actual = Form1.FindGCDStein(a, b).nod;

            Assert.AreEqual(expected, actual);
        }
    }
}
