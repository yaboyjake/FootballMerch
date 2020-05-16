using System;

namespace FootballMerchTests
{
    internal class clsOrder
    {
        public clsOrder()
        {
        }

        public bool OrderShipped { get; internal set; }
        public DateTime OrderDate { get; internal set; }
        public int OrderID { get; internal set; }
        public int CustomerID { get; internal set; }
        public string ShippingAddress { get; internal set; }
    }
}