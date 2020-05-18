using System;

namespace FootballMerch_Classes
{
    public class clsCustomer
    {
        public bool IsGuest { get; set; }
        public DateTime DOB { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public long PhoneNo { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string Postcode { get; set; }
    }
}