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
        public void IDPropertyOK()
        {
            clsOrder Order = new clsOrder();
            Int32 TestData = 1;
            Order.ID = TestData;
            Assert.AreEqual(Order.ID, TestData);
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
            Order.Address = TestData;
            Assert.AreEqual(Order.Address, TestData);

        }

        [TestMethod]
        public void HasShippedPropertyOkay()
        {
            clsOrder Order = new clsOrder();
            Boolean TestData = false;
            Order.HasShipped = TestData;
            Assert.AreEqual(Order.HasShipped, TestData);

        }

    }
}
