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



        public bool Find(int StockNo)
        {
            //create an instance of the data connection
            clsDataConnection DB = new clsDataConnection();
            //add the parameter for the stock number to search for
            DB.AddParameter("@StockNo", StockNo);
            //execute the stored procedure
            DB.Execute("sproc_tblStock_FilterByStockNo");
            //if one record is found (there should be either one or zero)
            if (DB.Count == 1)
            {
                //copy the data from the database to the private data members
                mStockNo = Convert.ToInt32(DB.DataTable.Rows[0]["StockNo"]);
                mDateAdded = Convert.ToDateTime(DB.DataTable.Rows[0]["DateAdded"]);
                mProductNo = Convert.ToInt32(DB.DataTable.Rows[0]["ProductNo"]);
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
    }
}