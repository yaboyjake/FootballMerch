using System;
using FootballMerch_Classes;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FootballMerchTests
{
    [TestClass]
    public class tstCustomer
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of a class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //test to see that it exists
            Assert.IsNotNull(AnCustomer);

        }

        [TestMethod]
        public void IsGuestPropertyOK()
        {
            //create an instance of customer class
            clsCustomer AnCustomer = new clsCustomer();
            //create some test data to assign to the proerty
            Boolean TestData = true;
            //assign the data to the property
            AnCustomer.IsGuest = TestData;
            //test to see that the 2 values are the same
            Assert.AreEqual(AnCustomer.IsGuest, TestData);

        }

        [TestMethod]
        public void DOBPropertyOK()
        {
            //creating instance of customer class
            clsCustomer AnCustomer = new clsCustomer();
            //creating test data for the DOB property
            DateTime TestData = DateTime.Now.Date;
            //assign the data to the property created
            AnCustomer.DOB = TestData;
            //teest to see that the 2 values are the same
            Assert.AreEqual(AnCustomer.DOB, TestData);

        }

        [TestMethod]
        public void FirstNamePropertyOK()
        {
            //creating instance of customer class
            clsCustomer AnCustomer = new clsCustomer();
            //creating test data for first name
            string TestData = "augustus";
            //assigning that data to the property created
            AnCustomer.FirstName = TestData;
            //test to see if the two are equal
            Assert.AreEqual(AnCustomer.FirstName, TestData);
        }

        [TestMethod]
        public void LastNamePropertyOK()
        {
            //creating instance of customer class
            clsCustomer AnCustomer = new clsCustomer();
            //creating test data for first name
            string TestData = "gloop";
            //assigning that data to the property created
            AnCustomer.LastName = TestData;
            //test to see if the two are equal
            Assert.AreEqual(AnCustomer.LastName, TestData);
        }

        [TestMethod]
        public void EmailPropertyOK()
        {
            //creating instance of customer class
            clsCustomer AnCustomer = new clsCustomer();
            //creating test data for first name
            string TestData = "someEmail357@hotmail.com";
            //assigning that data to the property created
            AnCustomer.Email = TestData;
            //test to see if the two are equal
            Assert.AreEqual(AnCustomer.Email, TestData);
        }

        [TestMethod]
        public void PhoneNoPropertyOK()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //create some test data to assign to the property
            Int64 TestData = 07812345678;
            //assign the data to the property
            AnCustomer.PhoneNo = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnCustomer.PhoneNo, TestData);
        }

        [TestMethod]
        public void AddressPropertyOK()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //create some test data to assign to the property
            string TestData = "21b";
            //assign the data to the property
            AnCustomer.Address = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnCustomer.Address, TestData);
        }

        [TestMethod]
        public void CityPropertyOK()
        {
            //creating instance of customer class
            clsCustomer AnCustomer = new clsCustomer();
            //creating test data for first name
            string TestData = "SomeTown";
            //assigning that data to the property created
            AnCustomer.City = TestData;
            //test to see if the two are equal
            Assert.AreEqual(AnCustomer.City, TestData);
        }

        [TestMethod]
        public void PostcodePropertyOK()
        {
            //creating instance of customer class
            clsCustomer AnCustomer = new clsCustomer();
            //creating test data for first name
            string TestData = "AB1 2CD";
            //assigning that data to the property created
            AnCustomer.Postcode = TestData;
            //test to see if the two are equal
            Assert.AreEqual(AnCustomer.Postcode, TestData);
        }
    }
}
