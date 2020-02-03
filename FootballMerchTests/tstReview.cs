using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FootballMerchTests
{
    [TestClass]
    public class tstReview
    {
        [TestMethod]
        public void TestMethod1()
        {
        }

        [TestMethod]
        public void InstanceOK()
        {
            clsReview aReview = new clsReview();
            Assert.IsNotNull(aReview);
        }
    }
}
