using System;
using System.Security.Policy;
using FootballMerch_Classes;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace FootballMerchTests
{
    [TestClass]
    public class tstOrder
    {
        //good test data 
        string CustomerID = "10";
        string ShippingAddress = "20 Test Road";
        string OrderDate = DateTime.Now.Date.ToString();
        string OrderShipped = "true";
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
            Order.OrderShipped = TestData;
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
        //Testing for valid method
        [TestMethod]
        public void ValidMethodOK()
        {
            clsOrder Order = new clsOrder();
            String Error = "";
            Error = Order.Valid(CustomerID, ShippingAddress, OrderDate);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerIDMinLessOne()
        {
            //test if blank customer id returns error
            clsOrder Order = new clsOrder();
            String Error = "";
            CustomerID = "";
            Error = Order.Valid(CustomerID, ShippingAddress, OrderDate);
            Assert.AreNotEqual(Error, "");

        }

        [TestMethod]
        public void CustomerIDMinPlusOne()
        {
            //test if valid customer id passes
            clsOrder Order = new clsOrder();
            String Error = "";
            CustomerID = "1";
            Error = Order.Valid(CustomerID, ShippingAddress, OrderDate);
            Assert.AreEqual(Error, "");

        }

        [TestMethod]
        public void CustomerIDMaxLessOne()
        {
            //test if valid customer id passes
            clsOrder Order = new clsOrder();
            String Error = "";
            CustomerID = "11111";
            Error = Order.Valid(CustomerID, ShippingAddress, OrderDate);
            Assert.AreEqual(Error, "");

        }
        [TestMethod]
        public void CustomerIDMaxPlusOne()
        {
            //test if exeeding max customer id returns error
            clsOrder Order = new clsOrder();
            String Error = "";
            CustomerID = "1111111";
            Error = Order.Valid(CustomerID, ShippingAddress, OrderDate);
            Assert.AreNotEqual(Error, "");

        }

        [TestMethod]
        public void CustomerIDMax()
        {
            //test if valid customer id passes Max
            clsOrder Order = new clsOrder();
            String Error = "";
            CustomerID = "111111";
            Error = Order.Valid(CustomerID, ShippingAddress, OrderDate);
            Assert.AreEqual(Error, "");

        }

        [TestMethod]
        public void CustomerIDMid()
        {
            //test if valid customer id passes Mid
            clsOrder Order = new clsOrder();
            String Error = "";
            CustomerID = "111";
            Error = Order.Valid(CustomerID, ShippingAddress, OrderDate);
            Assert.AreEqual(Error, "");

        }

        [TestMethod]
        public void CustomerIDExtremeMax()
        {
            //test if exeeding max customer id returns error
            clsOrder Order = new clsOrder();
            String Error = "";
            CustomerID = "999999999999999999999";
            Error = Order.Valid(CustomerID, ShippingAddress, OrderDate);
            Assert.AreNotEqual(Error, "");

        }

        //customer ID must be an integer
        [TestMethod]
        public void CustomerIDInvalidDataString()
        {
            //test if exeeding max customer id returns error
            clsOrder Order = new clsOrder();
            String Error = "";
            CustomerID = "Non integer";
            Error = Order.Valid(CustomerID, ShippingAddress, OrderDate);
            Assert.AreNotEqual(Error, "");

        }

        [TestMethod]
        public void CustomerIDInvalidDataDecimal()
        {
            //test if exeeding max customer id returns error
            clsOrder Order = new clsOrder();
            String Error = "";
            CustomerID = "11.1";
            Error = Order.Valid(CustomerID, ShippingAddress, OrderDate);
            Assert.AreNotEqual(Error, "");

        }


        //Test order date valid
        [TestMethod]
        public void OrderDateExtremeMin()
        {
            clsOrder Order = new clsOrder();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddYears(-100);
            string OrderDate = TestDate.ToString();
            Error = Order.Valid(CustomerID, ShippingAddress, OrderDate);
            Assert.AreNotEqual(Error, "");

        }

        [TestMethod]
        public void OrderDateMinLessOne()
        {
            clsOrder Order = new clsOrder();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddDays(-1);
            string OrderDate = TestDate.ToString();
            Error = Order.Valid(CustomerID, ShippingAddress, OrderDate);
            Assert.AreNotEqual(Error, "");

        }

        [TestMethod]
        public void OrderDateMin()
        {
            clsOrder Order = new clsOrder();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            string OrderDate = TestDate.ToString();
            Error = Order.Valid(CustomerID, ShippingAddress, OrderDate);
            Assert.AreEqual(Error, "");

        }

        [TestMethod]
        public void OrderDateMinPlusOne()
        {
            clsOrder Order = new clsOrder();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddDays(1);
            string OrderDate = TestDate.ToString();
            Error = Order.Valid(CustomerID, ShippingAddress, OrderDate);
            Assert.AreNotEqual(Error, "");

        }

        [TestMethod]
        public void OrderDateExtremeMax()
        {
            clsOrder Order = new clsOrder();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddYears(100);
            string OrderDate = TestDate.ToString();
            Error = Order.Valid(CustomerID, ShippingAddress, OrderDate);
            Assert.AreNotEqual(Error, "");

        }

        [TestMethod]
        public void OrderDateInvalidData()
        {
            clsOrder Order = new clsOrder();
            String Error = "";
            string OrderDate = "Not A Date Test Value!";
            Error = Order.Valid(CustomerID, ShippingAddress, OrderDate);
            Assert.AreNotEqual(Error, "");

        }

        //TEst shipping address valid
        [TestMethod]
        public void ShippingAddressMinLessOne()
        {
            //test if blank customer id returns error
            clsOrder Order = new clsOrder();
            String Error = "";
            CustomerID = "";
            Error = Order.Valid(CustomerID, ShippingAddress, OrderDate);
            Assert.AreNotEqual(Error, "");

        }

        [TestMethod]
        public void ShippingAddressMinPlusOne()
        {
            //test if valid customer id passes
            clsOrder Order = new clsOrder();
            String Error = "";
            ShippingAddress = "aa";
            Error = Order.Valid(CustomerID, ShippingAddress, OrderDate);
            Assert.AreEqual(Error, "");

        }

        [TestMethod]
        public void ShippingAddressMaxLessOne()
        {
            //test if valid customer id passes
            clsOrder Order = new clsOrder();
            String Error = "";
            ShippingAddress = "";
            ShippingAddress = ShippingAddress.PadRight(49, 'a');
            Error = Order.Valid(CustomerID, ShippingAddress, OrderDate);
            Assert.AreEqual(Error, "");

        }
        [TestMethod]
        public void ShippingAddressMaxPlusOne()
        {
            //test if exeeding max customer id returns error
            clsOrder Order = new clsOrder();
            String Error = "";
            ShippingAddress = "";
            ShippingAddress = ShippingAddress.PadRight(51, 'a');
            Error = Order.Valid(CustomerID, ShippingAddress, OrderDate);
            Assert.AreNotEqual(Error, "");

        }

        [TestMethod]
        public void ShippingAddressMax()
        {
            //test if valid customer id passes Max
            clsOrder Order = new clsOrder();
            String Error = "";
            ShippingAddress = "";
            ShippingAddress = ShippingAddress.PadRight(50, 'a');
            Error = Order.Valid(CustomerID, ShippingAddress, OrderDate);
            Assert.AreEqual(Error, "");

        }

        [TestMethod]
        public void ShippingAddressMid()
        {
            //test if valid customer id passes Mid
            clsOrder Order = new clsOrder();
            String Error = "";
            ShippingAddress = "";
            ShippingAddress = ShippingAddress.PadRight(25, 'a');
            Error = Order.Valid(CustomerID, ShippingAddress, OrderDate);
            Assert.AreEqual(Error, "");

        }

        [TestMethod]
        public void ShippingAddressExtremeMax()
        {
            //test extreme max shipping address
            clsOrder Order = new clsOrder();
            String Error = "";
            ShippingAddress = "";
            ShippingAddress = ShippingAddress.PadRight(500, 'a');
            Error = Order.Valid(CustomerID, ShippingAddress, OrderDate);
            Assert.AreNotEqual(Error, "");

        }
    }
}
