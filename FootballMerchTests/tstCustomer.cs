using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FootballMerchTests
{
    [TestClass]
    public class tstCustomer
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of a class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //test to see that it exists
            Assert.IsNotNull(AnCustomer);

        }
    }
}
