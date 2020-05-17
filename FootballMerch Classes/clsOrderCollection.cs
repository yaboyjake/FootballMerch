using System;
using System.Collections.Generic;

namespace FootballMerch_Classes
{
    public class clsOrderCollection
    {
        private List<clsOrder> mOrderList = new List<clsOrder>();

        public clsOrderCollection()
        {
            Int32 Index = 0;
            Int32 RecordCount = 0;
            clsDataConnection DB = new clsDataConnection();
            DB.Execute("sproc_tblOrder_SelectAll");
            RecordCount = DB.Count;

            while (Index < RecordCount)
            {
                clsOrder Order = new clsOrder();

                Order.OrderID = Convert.ToInt32(DB.DataTable.Rows[Index]["OrderID"]);
                Order.CustomerID = Convert.ToInt32(DB.DataTable.Rows[Index]["CustomerID"]);
                Order.ShippingAddress = Convert.ToString(DB.DataTable.Rows[Index]["ShippingAddress"]);
                Order.OrderDate = Convert.ToDateTime(DB.DataTable.Rows[Index]["OrderDate"]);
                Order.OrderShipped = Convert.ToBoolean(DB.DataTable.Rows[Index]["OrderShipped"]);

                mOrderList.Add(Order);
                Index++;
            }

        }
        
   
        public List<clsOrder> OrderList
        {
            get
            {
                return mOrderList;
            }
            set
            {
                mOrderList = value;
            }
        }
        public int Count
        {
            get
            {
                return mOrderList.Count;
            }
            set
            {

            }
        }
        public clsOrder ThisOrder { get; set; }
    }
}