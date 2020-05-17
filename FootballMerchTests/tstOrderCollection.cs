using System;
using System.Collections.Generic;
using FootballMerch_Classes;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FootballMerchTests
{
    [TestClass]
    public class tstOrderCollection
    {
        [TestMethod]
        public void InstanceOK()
        {
            clsOrderCollection AllOrders = new clsOrderCollection();
            Assert.IsNotNull(AllOrders);

        }

        [TestMethod]
        public void OrderListOK()
        {
            clsOrderCollection AllOrders = new clsOrderCollection();

            List<clsOrder> TestList = new List<clsOrder>();
            clsOrder TestItem = new clsOrder();
            TestItem.OrderID = 1;
            TestItem.CustomerID = 1;
            TestItem.ShippingAddress = "AddressTest";
            TestItem.OrderDate = DateTime.Now.Date;
            TestItem.OrderShipped = true;

            TestList.Add(TestItem);
            AllOrders.OrderList = TestList;

            Assert.AreEqual(AllOrders.OrderList, TestList);
        }


        [TestMethod]
        public void ThisOrderPropertyOK()
        {
            clsOrderCollection AllOrders = new clsOrderCollection();
            clsOrder TestOrder = new clsOrder();
            TestOrder.OrderID = 1;
            TestOrder.CustomerID = 1;
            TestOrder.ShippingAddress = "AddressTest";
            TestOrder.OrderDate = DateTime.Now.Date;
            TestOrder.OrderShipped = true;

            AllOrders.ThisOrder = TestOrder;

            Assert.AreEqual(AllOrders.ThisOrder, TestOrder);
        }

        [TestMethod]
        public void ListAndCountOK()
        {
            clsOrderCollection AllOrders = new clsOrderCollection();

            List<clsOrder> TestList = new List<clsOrder>();
            clsOrder TestItem = new clsOrder();
            TestItem.OrderID = 1;
            TestItem.CustomerID = 1;
            TestItem.ShippingAddress = "AddressTest";
            TestItem.OrderDate = DateTime.Now.Date;
            TestItem.OrderShipped = true;

            TestList.Add(TestItem);
            AllOrders.OrderList = TestList;

            Assert.AreEqual(AllOrders.Count, TestList.Count);

        }

    }
}
