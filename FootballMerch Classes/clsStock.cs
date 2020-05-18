using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace FootballMerch_Classes
{
    public class ClsStock
    {
        //product ID private member variable
        private int mProductNo;
        //product ID public property
        public int ProductNo
        {
            get
            {
                return mProductNo;
            }
            set
            {
                mProductNo = value;
            }
        }

        //product description private member variable
        private string mProductDescript;
        //Product description public property
        public string ProductDescript
        {
            get
            {
                return mProductDescript;
            }
            set
            {
                mProductDescript = value;
            }
        }

        //product cost private member variable
        private int mCost;
        //product cost public property
        public int Cost
        {
            get
            {
                return mCost;
            }
            set
            {
                mCost = value;
            }
        }

        //stockNo private member variable
        private Int32 mStockNo;
        //StockNo public property
        public int StockNo
        {
            get
            {
                //this line of code sends data out of the property
                return mStockNo;
            }
            set
            {
                //this line of code allows data into the property
                mStockNo = value;
            }
        }
        //dateAdded private member variable
        private DateTime mDateAdded;
        //DateAdded public property
        public DateTime DateAdded
        {
            get
            {
                return mDateAdded;
            }
            set
            {
                mDateAdded = value;
            }
        }

        //private data member for active
        private Boolean mInStck;
        //public property for active
        public bool InStck
        {
            get
            {
                //return the private data
                return mInStck;
            }
            set
            {
                //set the private data
                mInStck = value;
            }
        }



        public bool Find(int ProductNo)
        {
            //create an instance of the data connection
            clsDataConnection DB = new clsDataConnection();
            //add the parameter for the stock number to search for
            DB.AddParameter("@ProductNo", ProductNo);
            //execute the stored procedure
            DB.Execute("sproc_tblStock_FilterByStockNo");
            //if one record is found (there should be either one or zero)
            if (DB.Count == 1)
            {
                //copy the data from the database to the private data members
                mProductNo = Convert.ToInt32(DB.DataTable.Rows[0]["ProductNo"]);
                mStockNo = Convert.ToInt32(DB.DataTable.Rows[0]["StockNo"]);
                mDateAdded = Convert.ToDateTime(DB.DataTable.Rows[0]["DateAdded"]);
                mProductDescript = Convert.ToString(DB.DataTable.Rows[0]["ProductDescript"]);
                mCost = Convert.ToInt32(DB.DataTable.Rows[0]["Cost"]);
                mInStck = Convert.ToBoolean(DB.DataTable.Rows[0]["InStck"]);
                //always return true
                return true;
            }
            //if no record was found
            else
            {
                //return false indicating a problem
                return false;
            }

        }


        public bool Find(string productDescript)
        {
            throw new NotImplementedException();
        }


        ///this function accepts 5 parameters for validation
        ///the function returns a string containing any error message
        ///if no errors found then a blank string is returned

        public string Valid(string productDescript, string cost, string stockNo, string dateAdded)
        {
            //create a string variable to store the error
            String Error = "";
            //create a temporary variable to store date values
            DateTime DateTemp;
            //if the product description is blank
            if (productDescript.Length == 0)
            {
                //record the error
                Error = Error + "The product may not be blank : ";
            }
            //if product description is greater than 40 characters
            if (productDescript.Length > 40)
            {
                //record the error 
                Error = Error + "The product description must be less than 40 characters : ";
            }
            try
            {
                //copy the dateAdded value to the DateTemp variable
                DateTemp = Convert.ToDateTime(dateAdded);
                if (DateTemp < DateTime.Now.Date)
                {
                    //record the error
                    Error = Error + "The date cannot be in the past : ";
                }
                //check to see if the date is greater than today's date
                if (DateTemp > DateTime.Now.Date)
                { //record the error
                    Error = Error + "The date cannot be in the future : ";
                }
            }
            catch
            { //record the error 
                Error = Error + "The date was not a valid date : ";
            }

            {
                //record the error
                Error = Error + "The date was not a valid date : ";
            }
            //is the post code blank
            if (cost.Length == 0)
            {
                //record the error
                Error = Error + "The cost may not be blank : ";
            }
            //if the cost is too long
            if (cost.Length > 7)
            {
                //record the error
                Error = Error + "The cost must be less than 9 characters : ";
            }
            //is the town blank
            if (stockNo.Length == 0)
            {
                //record the error
                Error = Error + "The town may not be blank : ";
            }
            //if the town is too long
            if (stockNo.Length > 7)
            {
                //record the error
                Error = Error + "The stock number must be less than 7 characters : ";
            }
            //return any error messages
            return Error;
        }
    }
}