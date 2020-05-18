﻿using System;
using FootballMerch_Classes;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace FootballMerchTests
{

    [TestClass]
    public class tstStockCollection
    {

        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create
            clsStockCollection AllStock = new clsStockCollection();
            //test to see that it exists
            Assert.IsNotNull(AllStock);
        }


        [TestMethod]
        public void StockListOK()
        {
            //create an instance of the class we want to create
            clsStockCollection AllStock = new clsStockCollection();
            //create some test data to assign to the property
            //in this case the data needs to be a list of objects
            List<ClsStock> TestList = new List<ClsStock>();
            //add an item to the list 
            //create the item of test data
            ClsStock TestItem = new ClsStock();
            //set its properties
            TestItem.ProductNo = 5;
            TestItem.ProductDescript = "Liverpool Shirt";
            TestItem.Cost = 69;
            TestItem.DateAdded = DateTime.Now.Date;
            TestItem.StockNo = 50;
            TestItem.InStck = true;
            //add the item to the test list
            TestList.Add(TestItem);
            //assign the data to the property
            AllStock.StockList = TestList;
            //test to see that the two values are the same
            Assert.AreEqual(AllStock.StockList, TestList);
        }


        [TestMethod]
        public void ThisStockPropertyOK()
        {
            //create an instance of the class we want to create
            clsStockCollection AllStock = new clsStockCollection();
            //create some test data to assign to the property
            ClsStock TestStock = new ClsStock();
            //set the properties of the test object
            TestStock.InStck = true;
            TestStock.ProductNo = 5;
            TestStock.ProductDescript = "Liverpool Shirt";
            TestStock.Cost = 69;
            TestStock.StockNo = 50;
            TestStock.DateAdded = DateTime.Now.Date;
            //assign the data to the property
            AllStock.ThisStock = TestStock;
            //test to see that the two values are the same
            Assert.AreEqual(AllStock.ThisStock, TestStock);
        }

        [TestMethod]
        public void ListAndCountOK()
        {
            //create an instance of the class we want to create
            clsStockCollection AllStock = new clsStockCollection();
            //create some test data to assign to the property
            //in this case the data needs to be a list of objects
            List<ClsStock> TestList = new List<ClsStock>();
            //add an item to the list
            //create the item of test data
            ClsStock TestItem = new ClsStock();
            //set its properties
            TestItem.ProductNo = 5;
            TestItem.ProductDescript = "Liverpool Shirt";
            TestItem.Cost = 69;
            TestItem.DateAdded = DateTime.Now.Date;
            TestItem.StockNo = 50;
            TestItem.InStck = true;
            //add the item to the test list
            TestList.Add(TestItem);
            //assign the data to the property
            AllStock.StockList = TestList;
            //test to see that the two values are the same
            Assert.AreEqual(AllStock.Count, TestList.Count);
        }

        [TestMethod]
        public void AddMethodOK()
        {
            //create an instance of the class we want to create
            clsStockCollection AllStock = new clsStockCollection();
            //create the item of test data
            ClsStock TestItem = new ClsStock();
            //var to store the primary key
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.InStck = true;
            TestItem.ProductNo = 1;
            TestItem.ProductDescript = "Liverpool Shirt";
            TestItem.Cost = 59;
            TestItem.StockNo = 50;
            TestItem.DateAdded = DateTime.Now.Date;
            //set ThisStock to the test data
            AllStock.ThisStock = TestItem;
            //add the record
            PrimaryKey = AllStock.Add();
            //set the primary key of the test data
            TestItem.ProductNo = PrimaryKey;
            //find the record
            AllStock.ThisStock.Find(PrimaryKey);
            //test to see that the two values are the same
            Assert.AreEqual(AllStock.ThisStock, TestItem);
        }

        [TestMethod]
        public void DeleteMethodOK()
        {
            //create an instance of the class we want to create
            clsStockCollection AllStock = new clsStockCollection();
            //create the item of test data
            ClsStock TestItem = new ClsStock();
            //var to store the primary key
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.InStck = true;
            TestItem.ProductNo = 1;
            TestItem.ProductDescript = "Liverpool Shirt";
            TestItem.Cost = 59;
            TestItem.StockNo = 50;
            TestItem.DateAdded = DateTime.Now.Date;
            //set ThisStock to the test data
            AllStock.ThisStock = TestItem;
            //add the record
            PrimaryKey = AllStock.Add();
            //set the primary key of the test data
            TestItem.StockNo = PrimaryKey;
            //find the record
            AllStock.ThisStock.Find(PrimaryKey);
            //delete the record
            AllStock.Delete();
            //now find the record
            Boolean Found = AllStock.ThisStock.Find(PrimaryKey);
            //test to see that the record was not found
            Assert.IsFalse(Found);
        }

        [TestMethod]
        public void UpdateMethodOK()
        {
            //create an instance of the class we want to create
            clsStockCollection AllStock = new clsStockCollection();
            //create the item of test data
            ClsStock TestItem = new ClsStock();
            //var to store the primary key
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.InStck = true;
            TestItem.ProductNo = 1;
            TestItem.ProductDescript = "Liverpool Shirt";
            TestItem.Cost = 59;
            TestItem.StockNo = 50;
            TestItem.DateAdded = DateTime.Now.Date;
            //set ThisStock to the test data
            AllStock.ThisStock = TestItem;
            //add the record
            PrimaryKey = AllStock.Add();
            //set the primary key of the test data
            TestItem.StockNo = PrimaryKey;
            //modify the test data
            TestItem.InStck = false;
            TestItem.ProductNo = 3;
            TestItem.ProductDescript = "Chelsea Shirt";
            TestItem.Cost = 59;
            TestItem.StockNo = 49;
            TestItem.DateAdded = DateTime.Now.Date;
            //set the record based on the new test data
            //update the record
            AllStock.ThisStock = TestItem;
            //update the record
            AllStock.Update();
            //find the record
            AllStock.ThisStock.Find(PrimaryKey);
            //test to see ThisStock matches the test data
            Assert.AreEqual(AllStock.ThisStock, TestItem);
        }

        [TestMethod]
        public void ReportByProductDescriptMethodOK()
        {
            //create an instance of the class we want to create
            clsStockCollection AllStock = new clsStockCollection();
            //create the item of test data
            clsStockCollection FilteredStock = new clsStockCollection();
            //apply a blank string
            FilteredStock.ReportByProductDescript("");
            Assert.AreEqual(AllStock.Count, FilteredStock.Count);
        }

        [TestMethod]
        public void ReportByProductDescriptNoneFoundOK()
        {
            //create an instance of the filtered data
            clsStockCollection FilterStock = new clsStockCollection();
            //apply a product description that doesn't exist
            FilterStock.ReportByProductDescript("xxx xxx");
            //test to see that there are no records
            Assert.AreEqual(0, FilterStock.Count);
        }

        [TestMethod]
        public void ReportByProductDescriptTestDataFound()
        {
            clsStockCollection FilteredStock = new clsStockCollection();
            Boolean OK = true;
            FilteredStock.ReportByProductDescript("yyy yyy");
            if (FilteredStock.Count == 2)
            {
                if (FilteredStock.StockList[0].ProductNo != 36)
                {
                    OK = false;
                }
                if (FilteredStock.StockList[1].ProductNo != 37)
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