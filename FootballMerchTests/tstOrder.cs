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

        [TestMethod]
        public void FindMethodOK()
        {
            clsOrder Order = new clsOrder();
            Boolean Found = false;
            Int32 OrderID = 1;
            Found = Order.Find(OrderID);
            Assert.IsTrue(Found);
        }

        [TestMethod]
        public void TestOrderIDFound()
        {
            clsOrder Order = new clsOrder();
            Boolean found = false;
            Boolean OK = true;
            Int32 OrderID = 2;
            found = Order.Find(OrderID);
            if (Order.OrderID != 2)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestCustomerIDFound()
        {
            clsOrder Order = new clsOrder();
            Boolean found = false;
            Boolean OK = true;
            Int32 OrderID = 3;
            found = Order.Find(OrderID);
            if (Order.CustomerID != 10)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestShippingAddressFound()
        {
            clsOrder Order = new clsOrder();
            Boolean found = false;
            Boolean OK = true;
            Int32 OrderID = 3;
            found = Order.Find(OrderID);
            if (Order.ShippingAddress != "20 Test Road")
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestOrderDateFound()
        {
            clsOrder Order = new clsOrder();
            Boolean found = false;
            Boolean OK = true;
            Int32 OrderID = 3;
            found = Order.Find(OrderID);
            if (Order.OrderDate != Convert.ToDateTime("01/01/2000"))
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestOrderShippedFound()
        {
            clsOrder Order = new clsOrder();
            Boolean found = false;
            Boolean OK = true;
            Int32 OrderID = 3;
            found = Order.Find(OrderID);
            if (Order.OrderShipped != true)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }
    }
}
