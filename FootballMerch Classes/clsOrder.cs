using System;

namespace FootballMerch_Classes
{
    public class clsOrder
    {
        public clsOrder()
        {
        }

        public bool Find(int OrderID)
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("OrderID", OrderID);
            DB.Execute("sproc_tblOrder_FilterByOrderID");
            if (DB.Count == 1)
            {
                mOrderID = Convert.ToInt32(DB.DataTable.Rows[0]["OrderID"]);
                mCustomerID = Convert.ToInt32(DB.DataTable.Rows[0]["CustomerID"]);
                mShippingAddress = Convert.ToString(DB.DataTable.Rows[0]["ShippingAddress"]);
                mOrderDate = Convert.ToDateTime(DB.DataTable.Rows[0]["OrderDate"]);
                mOrderShipped = Convert.ToBoolean(DB.DataTable.Rows[0]["OrderShipped"]);

                return true;
            }
            else
            {
                return false;
            }
            
        }

        private Int32 mOrderID;
        public int OrderID
        {
            get
            {
                return mOrderID;
            }
            set
            {
                mOrderID = value;
            }
        }
        private Int32 mCustomerID;
        public int CustomerID
        {
            get
            {
                return mCustomerID;
            }
            set
            {
                mCustomerID = value;
            }
        }
        private string mShippingAddress;
        public string ShippingAddress
        {
            get
            {
                return mShippingAddress;
            }
            set
            {
                mShippingAddress = value;
            }
        }

        private bool mOrderShipped;
        public bool OrderShipped
        {
            get
            {
                return mOrderShipped;
            }
            set
            {
                mOrderShipped = value;
            }
        }

        private DateTime mOrderDate;
        public DateTime OrderDate
        {
            get
            {
                return mOrderDate;
            }
            set
            {
                mOrderDate = value;
            }
        }

    }

   
}