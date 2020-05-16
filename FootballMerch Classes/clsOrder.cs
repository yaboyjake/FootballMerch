using System;

namespace FootballMerch_Classes
{
    public class clsOrder
    {
        public clsOrder()
        {
        }

        public bool OrderShipped { get; set; }
        public DateTime OrderDate { get; set; }
        public int OrderID { get; set; }
        public int CustomerID { get; set; }
        public string ShippingAddress { get; set; }
    }

   
}