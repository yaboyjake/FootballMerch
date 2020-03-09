using System;

namespace FootballMerchTests
{
    public class clsOrder
    {
        public clsOrder()
        {
        }

        public int ID { get; set; }
        public int CustomerID { get; set; }
        public DateTime OrderDate { get; set; }
        public Boolean HasShipped { get; set; }
        public string Address { get; set; }
    }
}