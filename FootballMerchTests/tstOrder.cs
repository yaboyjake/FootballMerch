using System;
using System.Security.Policy;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FootballMerchTests
{
    [TestClass]
    public class tstOrder
    {
        [TestMethod]
        public void InstanceOK()
        {
            clsOrder order = new clsOrder();
            Assert.IsNotNull(order);
        }
        [TestMethod]
        public void OrderIDOK()
        {
            clsOrder order = new clsOrder();
            Int32 TestData = 1;
            order.OrderID = TestData;
            Assert.AreEqual(order.OrderID, TestData);
        }

        [TestMethod]
        public void CustomerIDOK()
        {
            clsOrder order = new clsOrder();
            Int32 TestData = 1;
            order.CustomerID = TestData;
            Assert.AreEqual(order.CustomerID, TestData);
        }

        [TestMethod]
        public void ShippingAddressOK()
        {
            clsOrder order = new clsOrder();
            String TestData = "Red Road";
            order.ShippingAddress = TestData;
            Assert.AreEqual(order.ShippingAddress, TestData);
        }


        [TestMethod]
        public void OrderDateOK()
        {
            clsOrder order = new clsOrder();
            DateTime TestData = DateTime.Now.Date;
            order.OrderDate = TestData;
            Assert.AreEqual(order.OrderDate, TestData);
        }

        [TestMethod]
        public void OrderShippedOK() {
            clsOrder order = new clsOrder();
            Boolean TestData = true;
            order.OrderShipped= TestData;
            Assert.AreEqual(order.OrderShipped, TestData);
        }
    }
}
