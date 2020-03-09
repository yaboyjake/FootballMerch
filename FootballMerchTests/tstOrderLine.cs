using System;
using FootballMerch_Classes;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FootballMerchTests
{
    [TestClass]
    public class tstOrderLine
    {
        [TestMethod]
        public void InstanceOK()
        {
            clsOrderLine OrderLine = new clsOrderLine();
            Assert.IsNotNull(OrderLine);

        }

        [TestMethod]
        public void IDPropertyOK()
        {
            clsOrderLine OrderLine = new clsOrderLine();
            Int32 TestData = 1;
            OrderLine.ID = TestData;
            Assert.AreEqual(OrderLine.ID, TestData);
        }

        [TestMethod]
        public void OrderIDPropertyOK()
        {
            clsOrderLine OrderLine = new clsOrderLine();
            Int32 TestData = 1;
            OrderLine.OrderID = TestData;
            Assert.AreEqual(OrderLine.OrderID, TestData);

        }

        [TestMethod]
        public void ProductIDPropertyOK()
        {
            clsOrderLine OrderLine = new clsOrderLine();
            Int32 TestData = 1;
            OrderLine.ProductID = TestData;
            Assert.AreEqual(OrderLine.ProductID, TestData);
        }

        [TestMethod]
        public void QuantityPropertyOK()
        {
            clsOrderLine OrderLine = new clsOrderLine();
            Int32 TestData = 1;
            OrderLine.Quantity = TestData;
            Assert.AreEqual(OrderLine.Quantity, TestData);
        }

        [TestMethod]
        public void UnitPricePropertyOK()
        {
            clsOrderLine OrderLine = new clsOrderLine();
            Int32 TestData = 1;
            OrderLine.UnitPrice = TestData;
            Assert.AreEqual(OrderLine.UnitPrice, TestData);
        }


    }
}
