using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FootballMerch_Classes;

namespace FootballMerchTests
{
    [TestClass]
    public class UnitTest1
    {
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
    }
}
