using System;
using System.Linq;

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

        public string Valid(string customerID, string shippingAddress, string orderDate)
        {
            string Error = "";
            DateTime DateTemp;
            //Validation for customerID 
            //If customerID is blank

            bool isNumeric = !string.IsNullOrEmpty(customerID) && customerID.All(Char.IsDigit);
            if (isNumeric)
            {
                if (customerID.Length == 0)
                {
                    Error = Error + "Customer ID Cannot be blank\n";
                }
                //If customerID exceeds upper bound
                if (customerID.Length > 8)
                {
                    Error = Error + "Customer ID exeeds upper bound\n";
                }
            }
            else
            {
                Error = Error + "Customer ID must be an integer\n";
            }

            //validation for orderDate
            //check if entered date is before now
            try
            {
                DateTemp = Convert.ToDateTime(orderDate);


                if (DateTemp < DateTime.Now.Date)
                {
                    Error = Error + "The date can not be in the past\n";
                }
                //check if date is in the future
                if (DateTemp > DateTime.Now.Date)
                {
                    Error = Error + "The date can not be in the future\n";
                }
            }
            catch
            {
                Error = Error + "The date is not a valid date\n";
            }

            //Validation for shipping address
            if (shippingAddress.Length == 0)
            {
                Error = Error + "Shipping address Cannot be blank\n ";
            }
            //If customerID exceeds upper bound
            if (shippingAddress.Length > 50)
            {
                Error = Error + "Shipping address too long\n ";
            }
            return Error;
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