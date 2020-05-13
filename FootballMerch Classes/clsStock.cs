using System;

namespace FootballMerch_Classes
{
    public class ClsStock
    {
        public int ProductNo { get; set; }
        public string ProductDescript { get; set; }
        public int Cost { get; set; }
        public int StockNo { get; set; }
        public DateTime DateAdded { get; set; }
        public bool InStck { get; set; }
    }
}