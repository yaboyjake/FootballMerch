using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FootballMerch_Classes;

namespace FootballMerchTests
{
    [TestClass]
    public class TstStock
    {

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
            Int32 TestData = 1;
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
            Int32 TestData = 1;
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
            Int32 TestData = 1;
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
            Int32 StockNo = 5;
            //invoke the method
            Found = AnStock.Find(StockNo);
            //check the address no
            if (AnStock.StockNo != 5)
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
            if (AnStock.InStck != true)
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
            if (AnStock.DateAdded != Convert.ToDateTime(12/04/2020))
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
    }
}