using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FootballMerchTests
{
    [TestClass]
    public class tstStock
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create
            clsStock AnStock = new clsStock();
            //test to see that it exists
            Assert.IsNotNull(AnStock);
        }


    }
    [TestMethod]
    public int ProductIDOK()
    {
        //create an instance of the class we want to create
        clsStock AnStock = new clsStock();
        //create some test data to assign to the property
        int TestData = 1;
        //assign the data to the property
        AnStock.ProductID = TestData;
        //test to see that the two values are the same
        Assert.AreEqual(AnStock.ProductID, TestData);
    }

    [TestMethod]
    public void ProductDescriptionOK()
    {
        //create an instance of the class we want to create
        clsAddress AnAddress = new clsAddress();
        //create some test data to assign to the property
        string TestData = "Red Football Socks";
        //assign the data to the property
        Stock.Stock = TestData;
        //test to see that the two values are the same
        Assert.AreEqual(AnAddress.Street, TestData);
    }

    [TestMethod]
    public void PriceOK()
    {
        //create an instance of the class we want to create
        clsStock AnStock = new clsStock();
        //create some test data to assign to the property
        var TestData = 1;
        //assign the data to the property
        AnStock.Stock = TestData;
        //test to see that the two values are the same
        Assert.AreEqual(AnStock.AddressNo, TestData);
    }

    [TestMethod]
    public void StockQuantityOK()
    {
        //create an instance of the class we want to create
        clsStock AnStock = new clsStock();
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
        clsStock AnStock = new clsStock();
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
        clsStock AnStock = new clsStock();
        //create some test data to assign to the property
        Boolean TestData = true;
        //assign the data to the property
        AnStock.Active = TestData;
        //test to see that the two values are the same
        Assert.AreEqual(AnStock.Active, TestData);
    }
}
