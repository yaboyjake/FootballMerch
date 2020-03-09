using System;

namespace FootballMerchTests
{
    public class clsAddress
    {
        public clsAddress()
        {
        }

        public bool Active { get; internal set; }
        public DateTime DateAdded { get; internal set; }
        public int AddressNo { get; internal set; }
        public int CountyNo { get; internal set; }
        public string HouseNo { get; internal set; }
        public string PostCode { get; internal set; }
        public string Street { get; internal set; }
        public string Town { get; internal set; }
        public string ProductDescription { get; internal set; }
        public string ProductDescript { get; internal set; }
    }
}