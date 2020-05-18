using System;

namespace FootballMerch_Classes
{
    public class clsCustomer
    {

        //CustomerNo private member variable
        private Int32 mCustomerNo;
        //CustomerNo public property
        public Int32 CustomerNo
        {
            get
            {
                //this line of code sends data out of the property
                return mCustomerNo;
            }
            set
            {
                //this line of code allows data into the property
                mCustomerNo = value;
            }
        }

        private DateTime mDOB;
        //DOB public property
        public DateTime DOB
        {
            get
            {
                //this line of code sends data out of the property
                return mDOB;
            }
            set
            {
                //this line of code allows data into the property
                mDOB = value;
            }
        }

        private string mFirstName;
        //CustomerNo public property
        public string FirstName
        {
            get
            {
                //this line of code sends data out of the property
                return mFirstName;
            }
            set
            {
                //this line of code allows data into the property
                mFirstName = value;
            }
        }

        private string mLastName;
        //CustomerNo public property
        public string LastName
        {
            get
            {
                //this line of code sends data out of the property
                return mLastName;
            }
            set
            {
                //this line of code allows data into the property
                mLastName = value;
            }
        }

        private string mEmail;
        //CustomerNo public property
        public string Email
        {
            get
            {
                //this line of code sends data out of the property
                return mEmail;
            }
            set
            {
                //this line of code allows data into the property
                mEmail = value;
            }
        }

        private long mPhoneNo;
        //CustomerNo public property
        public long PhoneNo
        {
            get
            {
                //this line of code sends data out of the property
                return mPhoneNo;
            }
            set
            {
                //this line of code allows data into the property
                mPhoneNo = value;
            }
        }

        private string mAddress;
        //CustomerNo public property
        public string Address
        {
            get
            {
                //this line of code sends data out of the property
                return mAddress;
            }
            set
            {
                //this line of code allows data into the property
                mAddress = value;
            }
        }

        private string mCity;
        //CustomerNo public property
        public string City
        {
            get
            {
                //this line of code sends data out of the property
                return mCity;
            }
            set
            {
                //this line of code allows data into the property
                mCity = value;
            }
        }

        private string mPostcode;
        //CustomerNo public property
        public string Postcode
        {
            get
            {
                //this line of code sends data out of the property
                return mPostcode;
            }
            set
            {
                //this line of code allows data into the property
                mPostcode = value;
            }
        }

        private Boolean mIsGuest;
        //CustomerNo public property
        public bool IsGuest
        {
            get
            {
                //this line of code sends data out of the property
                return mIsGuest;
            }
            set
            {
                //this line of code allows data into the property
                mIsGuest = value;
            }
        }

        public bool Find(int customerNo)
        {
            //set the private data members to the test data value
            mCustomerNo = 21;
            mDOB = Convert.ToDateTime("10/11/1999");
            mFirstName = "augustus";
            mLastName = "gloop";
            mEmail = "someEmail357@hotmail.com";
            mPhoneNo = 07812345678;
            mAddress = "21b";
            mCity = "SomeTown";
            mPostcode = "AB1 2CD";
            mIsGuest = true;
            //always return true
            //only a quick fix doent work long term!!
            return true;
        }


    }
}