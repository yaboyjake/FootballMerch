using System;
using System.Collections.Generic;

namespace FootballMerch_Classes
{
    public class clsOrderCollection
    {
        private List<clsOrder> mOrderList = new List<clsOrder>();
        private clsOrder mThisOrder = new clsOrder();
        public clsOrderCollection()
        {
            Int32 Index = 0;
            Int32 RecordCount = 0;
            clsDataConnection DB = new clsDataConnection();
            DB.Execute("sproc_tblOrder_SelectAll");
            PopulateArray(DB);

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
        public clsOrder ThisOrder
        {
            get
            {
                return mThisOrder;
            }
            set
            {
                mThisOrder = value;
            }
        }

        public int Add()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@CustomerID", mThisOrder.CustomerID);
            DB.AddParameter("@ShippingAddress", mThisOrder.ShippingAddress);
            DB.AddParameter("@OrderDate", mThisOrder.OrderDate);
            DB.AddParameter("@OrderShipped", mThisOrder.OrderShipped);
            return DB.Execute("sproc_tblOrder_Insert");
        }

        public void Delete()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@OrderID", mThisOrder.OrderID);
            DB.Execute("sproc_tblOrder_Delete");
        }

        public void Update()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@OrderID", mThisOrder.OrderID);
            DB.AddParameter("@CustomerID", mThisOrder.CustomerID);
            DB.AddParameter("@ShippingAddress", mThisOrder.ShippingAddress);
            DB.AddParameter("@OrderDate", mThisOrder.OrderDate);
            DB.AddParameter("@OrderShipped", mThisOrder.OrderShipped);
            DB.Execute("sproc_tblOrder_Update");
        }

        public void ReportByShippingAddress(string ShippingAddress)
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@ShippingAddress", ShippingAddress);
            DB.Execute("sproc_tblOrder_FilterByShippingAddress");
            PopulateArray(DB);
        }

        void PopulateArray(clsDataConnection DB)
        {
            Int32 Index = 0;
            Int32 RecordCount;
            RecordCount = DB.Count;
            mOrderList = new List<clsOrder>();
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
    }
}