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
            //TestItem.OrderID = 1;
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
            //TestOrder.OrderID = 1;
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
            //TestItem.OrderID = 1;
            TestItem.CustomerID = 1;
            TestItem.ShippingAddress = "AddressTest";
            TestItem.OrderDate = DateTime.Now.Date;
            TestItem.OrderShipped = true;

            TestList.Add(TestItem);
            AllOrders.OrderList = TestList;

            Assert.AreEqual(AllOrders.Count, TestList.Count);

        }

        [TestMethod]
        public void AddMethodOK()
        {
            clsOrderCollection AllOrders = new clsOrderCollection();
            clsOrder TestItem = new clsOrder();
            Int32 PrimaryKey = 0;

            //TestItem.OrderID = 1;
            TestItem.CustomerID = 1;
            TestItem.ShippingAddress = "AddressTest";
            TestItem.OrderDate = DateTime.Now.Date;
            TestItem.OrderShipped = true;

            AllOrders.ThisOrder = TestItem;
            PrimaryKey = AllOrders.Add();

            AllOrders.ThisOrder.Find(PrimaryKey);

            Assert.AreEqual(AllOrders.ThisOrder, TestItem);

        }

        [TestMethod]
        public void DeleteMethodOK()
        {
            clsOrderCollection AllOrders = new clsOrderCollection();
            clsOrder TestItem = new clsOrder();
            Int32 PrimaryKey = 0;

            //TestItem.OrderID = 1;
            TestItem.CustomerID = 1;
            TestItem.ShippingAddress = "AddressTest";
            TestItem.OrderDate = DateTime.Now.Date;
            TestItem.OrderShipped = true;

            AllOrders.ThisOrder = TestItem;
            PrimaryKey = AllOrders.Add();

            AllOrders.ThisOrder.Find(PrimaryKey);
            AllOrders.Delete();

            Boolean Found = AllOrders.ThisOrder.Find(PrimaryKey);

            Assert.IsFalse(Found);
        }

        [TestMethod]
        public void UpdateMethodOK()
        {
            clsOrderCollection AllOrders = new clsOrderCollection();
            clsOrder TestItem = new clsOrder();
            Int32 PrimaryKey = 0;

            TestItem.CustomerID = 1;
            TestItem.ShippingAddress = "AddressTest";
            TestItem.OrderDate = DateTime.Now.Date;
            TestItem.OrderShipped = true;

            AllOrders.ThisOrder = TestItem;
            PrimaryKey = AllOrders.Add();

            TestItem.OrderID = PrimaryKey;

            TestItem.CustomerID = 2;
            TestItem.ShippingAddress = "AddressTest2Edited";
            TestItem.OrderDate = DateTime.Now.Date;
            TestItem.OrderShipped = false;

            AllOrders.ThisOrder = TestItem;

            AllOrders.Update();
            AllOrders.ThisOrder.Find(PrimaryKey);

            Assert.AreEqual(AllOrders.ThisOrder, TestItem);
        }

        [TestMethod]
        public void ReportByShippingAddressMethodOK()
        {
            clsOrderCollection AllOrders = new clsOrderCollection();
            clsOrderCollection FilteredOrders = new clsOrderCollection();
            FilteredOrders.ReportByShippingAddress("");
            Assert.AreEqual(AllOrders.Count, FilteredOrders.Count);
        }

        [TestMethod]
        public void ReportByShippingAddressNoneFound()
        {
            clsOrderCollection FilteredOrders = new clsOrderCollection();
            FilteredOrders.ReportByShippingAddress("xxx");
            Assert.AreEqual(0, FilteredOrders.Count);

        }

        //this test will fail if test data is deleted
        [TestMethod]
        public void ReportByShippingAddressTestDataFound()
        {
            clsOrderCollection FilteredOrders = new clsOrderCollection();
            Boolean OK = true;
            FilteredOrders.ReportByShippingAddress("TestData1");
            if (FilteredOrders.Count == 2)
            {
                if (FilteredOrders.OrderList[0].OrderID != 39)
                {
                    OK = false;
                }
                if (FilteredOrders.OrderList[1].OrderID != 40)
                {
                    OK = false;
                }
            }
            else
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }
    }
}
