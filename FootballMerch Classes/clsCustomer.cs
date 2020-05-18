using System;

namespace FootballMerch_Classes
{
    public class clsCustomer
    {

        //CustomerID private member variable
        private Int32 mCustomerID;
        //CustomerID public property
        public Int32 CustomerID
        {
            get
            {
                //this line of code sends data out of the property
                return mCustomerID;
            }
            set
            {
                //this line of code allows data into the property
                mCustomerID = value;
            }
        }
        //DOB private member variable
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

        //First name private member variable
        private string mFirstName;
        //First name public property
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

        //last name private member variable
        private string mLastName;
        //last name public property
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

        //email private member variable
        private string mEmail;
        //email public property
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

        //phone no. private member variable
        private long mPhoneNo;
        //phone no. public property
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

        //address private member variable
        private string mAddress;
        //address public property
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

        //city private member variable
        private string mCity;
        //city public property
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

        //postcode private member variable
        private string mPostcode;
        //podtcode public property
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

        //isGuest private member variable
        private Boolean mIsGuest;
        //isGuest public property
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
            //create an instance of the data connection 
            clsDataConnection DB = new clsDataConnection();
            //add the parameter for the customer id to search for 
            DB.AddParameter("@CustomerID", CustomerID);
            //execute the stored parameters
            DB.Execute("sproc_tblCustomer_FilterByCustomerID");
            //if one is found (there should be either one or zero!)
            if (DB.Count == 1 )
            {
                mCustomerID = Convert.ToInt32(DB.DataTable.Rows[0]["CustomerID"]);
                mDOB = Convert.ToDateTime(DB.DataTable.Rows[0]["DOB"]);
                mFirstName = Convert.ToString(DB.DataTable.Rows[0]["FirstName"]);
                mLastName = Convert.ToString(DB.DataTable.Rows[0]["LastName"]);
                mEmail = Convert.ToString(DB.DataTable.Rows[0]["Email"]);
                mPhoneNo = Convert.ToInt64(DB.DataTable.Rows[0]["PhoneNo"]);
                mAddress = Convert.ToString(DB.DataTable.Rows[0]["Address"]);
                mCity = Convert.ToString(DB.DataTable.Rows[0]["City"]);
                mPostcode = Convert.ToString(DB.DataTable.Rows[0]["Postcode"]);
                mIsGuest = Convert.ToBoolean(DB.DataTable.Rows[0]["IsGuest"]);
                //return that everything true
                return true;
            }
            //if no record was found
            else
            {
                //return false indicating a prblem
                return false;
            }
        }


    }
}