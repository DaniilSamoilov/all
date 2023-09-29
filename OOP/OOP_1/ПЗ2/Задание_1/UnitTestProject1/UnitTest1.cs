using Microsoft.VisualStudio.TestTools.UnitTesting;
using WindowsFormsApp1;

namespace TestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void NOD_2806and345_return23()
        {
            int a = 2806;
            int b = 345;
            int expected = 23;

            int actual = Form1.NOD(a, b);

            Assert.AreEqual(expected, actual);
        }
    }
}