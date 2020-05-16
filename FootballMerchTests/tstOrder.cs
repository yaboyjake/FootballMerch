using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FootballMerchTests
{
    [TestClass]
    public class tstOrder
    {
        [TestMethod]
        public void TestMethod1()
        {
            clsOrder order = new clsOrder();
            Assert.IsNotNull(order);
        }
    }
}
