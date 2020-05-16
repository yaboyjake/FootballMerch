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
            //set
            mStockNo = 50;
            mDateAdded = Convert.ToDateTime("16/9/2015");
            mProductNo = 5;
            mProductDescript = "Liverpool Shirt";
            mCost = 69;
            InStck = true;
            //always return true
            return true;
        }


    }
}