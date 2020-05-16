using System;
using System.Security.Policy;
using FootballMerch_Classes;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace FootballMerchTests
{
    [TestClass]
    public class tstOrder
    {
        [TestMethod]
        public void InstanceOK()
        {
            clsOrder Order = new clsOrder();
            Assert.IsNotNull(Order);
        }
        [TestMethod]
        public void OrderIDOK()
        {
            clsOrder Order = new clsOrder();
            Int32 TestData = 1;
            Order.OrderID = TestData;
            Assert.AreEqual(Order.OrderID, TestData);
        }

        [TestMethod]
        public void CustomerIDOK()
        {
            clsOrder Order = new clsOrder();
            Int32 TestData = 1;
            Order.CustomerID = TestData;
            Assert.AreEqual(Order.CustomerID, TestData);
        }

        [TestMethod]
        public void ShippingAddressOK()
        {
            clsOrder Order = new clsOrder();
            String TestData = "Red Road";
            Order.ShippingAddress = TestData;
            Assert.AreEqual(Order.ShippingAddress, TestData);
        }


        [TestMethod]
        public void OrderDateOK()
        {
            clsOrder Order = new clsOrder();
            DateTime TestData = DateTime.Now.Date;
            Order.OrderDate = TestData;
            Assert.AreEqual(Order.OrderDate, TestData);
        }

        [TestMethod]
        public void OrderShippedOK() {
            clsOrder Order = new clsOrder();
            Boolean TestData = true;
            Order.OrderShipped= TestData;
            Assert.AreEqual(Order.OrderShipped, TestData);
        }
    }
}
