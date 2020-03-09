using System;

namespace FootballMerchTests
{
    public class clsOrder
    {
        public clsOrder()
        {
        }

        public int OrderID { get; set; }
        public int CustomerID { get; set; }
        public DateTime OrderDate { get; set; }
        public string ShippingAddress { get; set; }
        public bool OrderShipped { get; set; }
    }
}