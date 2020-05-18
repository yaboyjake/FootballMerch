using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FootballMerch_Classes;

namespace FootballMerchTests
{
    [TestClass]
    public class TstStock
    {
        //good test data
        //create some test data to pass to the method
        string ProductDescript = "Liverpool Shirt";
        string Cost = "69";
        string StockNo = "50";
        string DateAdded = DateTime.Now.ToString();

        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create
            ClsStock AnStock = new ClsStock();
            //test to see that it exists
            Assert.IsNotNull(AnStock);

        }

        [TestMethod]
        public void ProductIDOK()
        {
            //create an instance of the class we want to create
            ClsStock AnStock = new ClsStock();
            //create some test data to assign to the property
            Int32 TestData = 5;
            //assign the data to the property
            AnStock.ProductNo = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnStock.ProductNo, TestData);
        }

        [TestMethod]
        public void ProductDescriptionOK()
        {
            //create an instance of the class we want to create
            ClsStock AnStock = new ClsStock();
            //create some test data to assign to the property
            string TestData = "Liverpool Shirt";
            //assign the data to the property
            AnStock.ProductDescript = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnStock.ProductDescript, TestData);
        }

        [TestMethod]
        public void PriceOK()
        {
            //create an instance of the class we want to create
            ClsStock AnStock = new ClsStock();
            //create some test data to assign to the property
            Int32 TestData = 69;
            //assign the data to the property
            AnStock.Cost = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnStock.Cost, TestData);
        }

        [TestMethod]
        public void StockQuantityOK()
        {
            //create an instance of the class we want to create
            ClsStock AnStock = new ClsStock();
            //create some test data to assign to the property
            Int32 TestData = 50;
            //assign the data to the property
            AnStock.StockNo = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnStock.StockNo, TestData);
        }



        [TestMethod]
        public void StockDateOK()
        {
            //create an instance of the class we want to create
            ClsStock AnStock = new ClsStock();
            //create some test data to assign to the property
            DateTime TestData = DateTime.Now.Date;
            //assign the data to the property
            AnStock.DateAdded = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnStock.DateAdded, TestData);
        }

        [TestMethod]
        public void InStockOK()
        {
            //create an instance of the class we want to create
            ClsStock AnStock = new ClsStock();
            //create some test data to assign to the property
            Boolean TestData = true;
            //assign the data to the property
            AnStock.InStck = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnStock.InStck, TestData);
        }

        [TestMethod]
        public void FindMethodOK()
        {
            //create
            ClsStock AnStock = new ClsStock();
            //boolean
            Boolean Found = false;
            //create
            Int32 StockNo = 1;
            //invoke
            Found = AnStock.Find(StockNo);
            //test
            Assert.IsTrue(Found);
        }

        [TestMethod]
        public void TestStockNoFound()
        {
            //create an instance of the class we want to create
            ClsStock AnStock = new ClsStock();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method 
            Int32 StockNo = 50;
            //invoke the method
            Found = AnStock.Find(StockNo);
            //check the address no
            if (AnStock.StockNo != 50)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }


        [TestMethod]
        public void TestProductIDFound()
        {
            //create an instance of the class we want to create
            ClsStock AnStock = new ClsStock();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 ProductNo = 5;
            //invoke the method
            Found = AnStock.Find(ProductNo);
            //check the property
            if (AnStock.ProductNo != 5)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestProductDescriptionFound()
        {
            //create an instance of the class we want to create
            ClsStock AnStock = new ClsStock();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            string ProductDescript = "Liverpool Shirt";
            //invoke the method
            Found = AnStock.Find(ProductDescript);
            //check the property
            if (AnStock.ProductDescript != "Liverpool Shirt")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestCostFound()
        {
            //create an instance of the class we want to create
            ClsStock AnStock = new ClsStock();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            int Cost = 69;
            //invoke the method
            Found = AnStock.Find(Cost);
            //check the property
            if (AnStock.Cost != 69)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestDateAddedFound()
        {
            //create an instance of the class we want to create
            ClsStock AnStock = new ClsStock();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 StockNo = 50;
            //invoke the method
            Found = AnStock.Find(StockNo);
            //check the property
            if (AnStock.DateAdded != Convert.ToDateTime(12 / 04 / 2020))
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestInStockFound()
        {
            //create an instance of the class we want to create
            ClsStock AnStock = new ClsStock();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 StockNo = 50;
            //invoke the method
            Found = AnStock.Find(StockNo);
            //check the property
            if (AnStock.InStck != true)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void ValidMethodOK()
        {
            //create an instance of the class we want to create
            ClsStock AnStock = new ClsStock();
            //string variable to store any error message
            String Error = "";
            //invoke the method
            Error = AnStock.Valid(ProductDescript, Cost, StockNo, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ProductDescriptMinLessOne()
        {
            //create and instance of the class we want to create
            ClsStock AnStock = new ClsStock();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string ProductDescript = ""; //this should trigger an error
            //invoke  the method
            Error = AnStock.Valid(ProductDescript, Cost, StockNo, DateAdded);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        public void ProductDescriptMin()
        {
            //create an instance of the class we want to create
            ClsStock AnStock = new ClsStock();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string ProductDescript = "a"; //this should be ok
            //invoke the method
            Error = AnStock.Valid(ProductDescript, Cost, StockNo, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ProductDescriptMinPlusOne()
        {
            //create an instance of the class we want to create
            ClsStock AnStock = new ClsStock();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string ProductDescript = "a"; //this should be ok
            //invoke the method
            Error = AnStock.Valid(ProductDescript, Cost, StockNo, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ProductDescriptMaxLessOne()
        {
            //create an instance of the class we want to create
            ClsStock AnStock = new ClsStock();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string ProductDescript = "aa"; //this should be ok
            //invoke the method
            Error = AnStock.Valid(ProductDescript, Cost, StockNo, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ProductDescriptMax()
        {
            //create an instance of the class we want to create
            ClsStock AnStock = new ClsStock();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string ProductDescript = "aaa"; //this should be ok
            //invoke the method
            Error = AnStock.Valid(ProductDescript, Cost, StockNo, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ProductDescriptMid()
        {
            //create an instance of the class we want to create
            ClsStock AnStock = new ClsStock();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string ProductDescript = "aaaa"; //this should be ok
            //invoke the method
            Error = AnStock.Valid(ProductDescript, Cost, StockNo, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ProductDescriptExtremeMax()
        {
            //create an instance of the class we want to create
            ClsStock AnStock = new ClsStock();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string ProductDescript = ""; //this should be ok
            ProductDescript = ProductDescript.PadRight(500, 'a'); //this should fail
            //invoke the method
            Error = AnStock.Valid(ProductDescript, Cost, StockNo, DateAdded);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DateAddedExtremeMin()
        {
            //create an instance of the class we want to create
            ClsStock AnStock = new ClsStock();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            DateTime TestDate;
            //set the date to today's date
            TestDate = DateTime.Now.Date;
            //change the data to whatever the date is less than 100 years
            TestDate = TestDate.AddYears(-100);
            //convert the date variable to a string variable
            string DateAdded = TestDate.ToString();
            //invoke the method
            Error = AnStock.Valid(ProductDescript, Cost, StockNo, DateAdded);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void DateAddedMinLessOne()
        {
            //create an instance of the class we want to create
            ClsStock AnStock = new ClsStock();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date totodays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is less 1 day
            TestDate = TestDate.AddDays(-1);
            //convert the date variable to a string variable
            string DateAdded = TestDate.ToString();
            //invoke the method
            Error = AnStock.Valid(ProductDescript, Cost, StockNo, DateAdded);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DateAddedMin()
        {
            //create an instance of the class we want to create
            ClsStock AnStock = new ClsStock();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date totodays date
            TestDate = DateTime.Now.Date;
            //convert the date variable to a string variable
            string DateAdded = TestDate.ToString();
            //invoke the method
            Error = AnStock.Valid(ProductDescript, Cost, StockNo, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void DateAddedMinPlusOne()
        {
            //create an instance of the class we want to create
            ClsStock AnStock = new ClsStock();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date totodays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is plus 1 day
            TestDate = TestDate.AddDays(1);
            //convert the date variable to a string variable
            string DateAdded = TestDate.ToString();
            //invoke the method
            Error = AnStock.Valid(ProductDescript, Cost, StockNo, DateAdded);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DateAddedExtremeMax()
        {
            //create an instance of the class we want to create
            ClsStock AnStock = new ClsStock();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date totodays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is plus 100 years
            TestDate = TestDate.AddYears(100);
            //convert the date variable to a string variable
            string DateAdded = TestDate.ToString();
            //invoke the method
            Error = AnStock.Valid(ProductDescript, Cost, StockNo, DateAdded);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DateAddedInvalidData()
        {
            //create an instance of the class we want to create
            ClsStock AnStock = new ClsStock();
            //string variable to store any error message
            String Error = "";
            //set the DateAdded to a non date value
            string DateAdded = "this is not a date";
            //invoke the method
            Error = AnStock.Valid(ProductDescript, Cost, StockNo, DateAdded);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void CostMinLessOne()
        {
            //create an instance of the class we want to create
            ClsStock AnStock = new ClsStock();
            //string variable to store any error message
            String Error = "";
            //this should fail
            string Cost = "";
            //invoke the method
            Error = AnStock.Valid(ProductDescript, Cost, StockNo, DateAdded);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void CostMin()
        {
            //create an instance of the class we want to create
            ClsStock AnStock = new ClsStock();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string Cost = "a";
            //invoke the method
            Error = AnStock.Valid(ProductDescript, Cost, StockNo, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CostMinPlusOne()
        {
            //create an instance of the class we want to create
            ClsStock AnStock = new ClsStock();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string Cost = "aa";
            //invoke the method
            Error = AnStock.Valid(ProductDescript, Cost, StockNo, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CostMaxLessOne()
        {
            //create an instance of the class we want to create
            ClsStock AnStock = new ClsStock();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string Cost = "aaaaaaaa";
            //invoke the method
            Error = AnStock.Valid(ProductDescript, Cost, StockNo, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CostMax()
        {
            //create an instance of the class we want to create
            ClsStock AnStock = new ClsStock();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string Cost = "aaaaaaaaa";
            //invoke the method
            Error = AnStock.Valid(ProductDescript, Cost, StockNo, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CostMaxPlusOne()
        {
            //create an instance of the class we want to create
            ClsStock AnStock = new ClsStock();
            //string variable to store any error message
            String Error = "";
            //this should fail
            string Cost = "aaaaaaaaaa";
            //invoke the method
            Error = AnStock.Valid(ProductDescript, Cost, StockNo, DateAdded);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void CostMid()
        {
            //create an instance of the class we want to create
            ClsStock AnStock = new ClsStock();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string Cost = "aaaa";
            //invoke the method
            Error = AnStock.Valid(ProductDescript, Cost, StockNo, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }




        [TestMethod]
        public void StockNoMinLessOne()
        {
            //create an instance of the class we want to create
            ClsStock AnStock = new ClsStock();
            //string variable to store any error message
            String Error = "";
            //this should fail
            string StockNo = "";
            //invoke the method
            Error = AnStock.Valid(ProductDescript, Cost, StockNo, DateAdded);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void StockNoMin()
        {
            //create an instance of the class we want to create
            ClsStock AnStock = new ClsStock();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string StockNo = "a";
            //invoke the method
            Error = AnStock.Valid(ProductDescript, Cost, StockNo, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StockNoMinPlusOne()
        {
            //create an instance of the class we want to create
            ClsStock AnStock = new ClsStock();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string StockNo = "aa";
            //invoke the method
            Error = AnStock.Valid(ProductDescript, Cost, StockNo, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StockNoMaxLessOne()
        {
            //create an instance of the class we want to create
            ClsStock AnStock = new ClsStock();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string StockNo = "aaaaaaaa";
            //invoke the method
            Error = AnStock.Valid(ProductDescript, Cost, StockNo, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StockNoMax()
        {
            //create an instance of the class we want to create
            ClsStock AnStock = new ClsStock();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string StockNo = "aaaaaaaaa";
            //invoke the method
            Error = AnStock.Valid(ProductDescript, Cost, StockNo, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, ""); 
        }

        [TestMethod]
        public void StockNoMaxPlusOne()
        {
            //create an instance of the class we want to create
            ClsStock AnStock = new ClsStock();
            //string variable to store any error message
            String Error = "";
            //this should fail
            string StockNo = "aaaaaaaaaa";
            //invoke the method
            Error = AnStock.Valid(ProductDescript, Cost, StockNo, DateAdded);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void StockNoMid()
        {
            //create an instance of the class we want to create
            ClsStock AnStock = new ClsStock();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string StockNo = "aaaa";
            //invoke the method
            Error = AnStock.Valid(ProductDescript, Cost, StockNo, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

    }
}