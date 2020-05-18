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

        [TestMethod]
        public void CustomerIDPropertyOK()
        {
            //creating instance of customer class
            clsCustomer AnCustomer = new clsCustomer();
            //creating test data for customer number
            Int32 TestData = 1;
            //assigning that data to the property created
            AnCustomer.CustomerID = TestData;
            //test to see if the two are equal
            Assert.AreEqual(AnCustomer.CustomerID, TestData);
        }


        [TestMethod]
        public void FindMethodOK()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //boolean variable to store the result of the validation
            Boolean Found = false;
            //create some test data to use with the method
            Int32 CustomerID = 1;
            //invoke the method 
            Found = AnCustomer.Find(CustomerID);
            //test to see that the result is correct
            Assert.IsTrue(Found);

        }
        [TestMethod]
        public void TestCustomerOK()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //boolean variable to store the result of the validation
            Boolean Found = false;
            //boolean variable to record if data is ok (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 CustomerID = 21;
            //invoke the method 
            Found = AnCustomer.Find(CustomerID);
            //check the customer no
            if (AnCustomer.CustomerID != 21)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestDOBFound()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //boolean variable to store the result of the validation
            Boolean Found = false;
            //boolean variable to record if data is ok (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 CustomerID = 21;
            //invoke the method 
            Found = AnCustomer.Find(CustomerID);
            //check the customer no
            if (AnCustomer.DOB != Convert.ToDateTime("10/11/1999"))
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestFirstNameFound()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //boolean variable to store the result of the validation
            Boolean Found = false;
            //boolean variable to record if data is ok (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 CustomerID = 21;
            //invoke the method 
            Found = AnCustomer.Find(CustomerID);
            //check the property
            if (AnCustomer.FirstName != "augustus")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestLastNameFound()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //boolean variable to store the result of the validation
            Boolean Found = false;
            //boolean variable to record if data is ok (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 CustomerID = 21;
            //invoke the method 
            Found = AnCustomer.Find(CustomerID);
            //check the property
            if (AnCustomer.LastName != "gloop")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestEmailFound()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //boolean variable to store the result of the validation
            Boolean Found = false;
            //boolean variable to record if data is ok (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 CustomerID = 21;
            //invoke the method 
            Found = AnCustomer.Find(CustomerID);
            //check the property
            if (AnCustomer.Email != "someEmail357@hotmail.com")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestPhoneNoFound()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //boolean variable to store the result of the validation
            Boolean Found = false;
            //boolean variable to record if data is ok (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 CustomerID = 21;
            //invoke the method 
            Found = AnCustomer.Find(CustomerID);
            //check the property
            if (AnCustomer.PhoneNo != 07812345678)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestAddressFound()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //boolean variable to store the result of the validation
            Boolean Found = false;
            //boolean variable to record if data is ok (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 CustomerID = 21;
            //invoke the method 
            Found = AnCustomer.Find(CustomerID);
            //check the property
            if (AnCustomer.Address != "21b")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestCityFound()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //boolean variable to store the result of the validation
            Boolean Found = false;
            //boolean variable to record if data is ok (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 CustomerID = 21;
            //invoke the method 
            Found = AnCustomer.Find(CustomerID);
            //check the property
            if (AnCustomer.City != "SomeTown")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestPostcodeFound()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //boolean variable to store the result of the validation
            Boolean Found = false;
            //boolean variable to record if data is ok (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 CustomerID = 21;
            //invoke the method 
            Found = AnCustomer.Find(CustomerID);
            //check the property
            if (AnCustomer.Postcode != "AB1 2CD")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestIsGuestFound()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //boolean variable to store the result of the validation
            Boolean Found = false;
            //boolean variable to record if data is ok (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 CustomerID = 21;
            //invoke the method 
            Found = AnCustomer.Find(CustomerID);
            //check the property
            if (AnCustomer.IsGuest != true)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
    }
}
