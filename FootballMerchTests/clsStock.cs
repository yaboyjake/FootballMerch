using System;

namespace FootballMerchTests
{
    public class clsStock
    {
        public clsStock()
        {
        }

        public bool InStock { get; internal set; }
        public DateTime DateAdded { get; internal set; }
        public int ProductID { get; internal set; }
    }
}