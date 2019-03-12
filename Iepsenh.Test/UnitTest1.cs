using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Iepsenh.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Is1Equalto1()
        {
            Assert.AreEqual(1, 1);
        }

        [TestMethod]
        public void Is3NotEqualto2()
        {
            Assert.AreNotEqual(3, 2);
        }
    }
}