using System;

namespace ClassLibrary
{
    public class clsCustomer
    {
        public int CustomerId { get; set; }
        public DateTime Dob { get; set; }
        public string Postcode { get; set; }
        public bool Gdpr { get; set; }
        public string Address { get; set; }

        public string Valid(int mCustomerId)
        {
            return "";
        }
    }
}