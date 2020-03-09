using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
        public void OrderIDPropertyOK()
        {
            clsOrder Order = new clsOrder();
            Int32 TestData = 1;
            Order.OrderID = TestData;
            Assert.AreEqual(Order.OrderID, TestData);
        }

        [TestMethod]
        public void CustomerIDPropertyOK()
        {
            clsOrder Order = new clsOrder();
            Int32 TestData = 1;
            Order.CustomerID = TestData;
            Assert.AreEqual(Order.CustomerID, TestData);

        }

        [TestMethod]
        public void OrderDatePropertyOK()
        {
            clsOrder Order = new clsOrder();
            DateTime TestData = DateTime.Now.Date;
            Order.OrderDate = TestData;
            Assert.AreEqual(Order.OrderDate, TestData);

        }

        [TestMethod]
        public void AddressPropertyOK()
        {
            clsOrder Order = new clsOrder();
            String TestData = "";
            Order.ShippingAddress = TestData;
            Assert.AreEqual(Order.ShippingAddress, TestData);

        }

        [TestMethod]
        public void OrderShippedPropertyOkay()
        {
            clsOrder Order = new clsOrder();
            Boolean TestData = true;
            Order.OrderShipped = TestData;
            Assert.AreEqual(Order.OrderShipped, TestData);

        }

    }
}
