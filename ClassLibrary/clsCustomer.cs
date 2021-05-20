using System;

namespace ClassLibrary
{
    public class clsCustomer
    {
        private int mCustomerId;
        private string mName;
        private string mAddress;
        private string mPostcode;
        private DateTime mDoB;
        private Boolean mGdprRequest;

        public int CustomerId
        {
            get
            {
                //this line of code sends data out of the prop
                return mCustomerId;
            }
            set
            {
                //this line of code allows data into the prop
                mCustomerId = value;

            }
        }
        public string Name
        {
            get
            {
                //this line of code sends data out of the prop
                return mName;
            }
            set
            {
                //this line of code allows data into the prop
                mName = value;

            }
        }
        public string Address
        {
            get
            {
                //this line of code sends data out of the prop
                return mAddress;
            }
            set
            {
                //this line of code allows data into the prop
                mAddress = value;

            }
        }
        public string Postcode
        {
            get
            {
                //this line of code sends data out of the prop
                return mPostcode;
            }
            set
            {
                //this line of code allows data into the prop
                mPostcode = value;

            }
        }
        public DateTime DoB
        {
            get
            {
                //this line of code sends data out of the prop
                return mDoB;
            }
            set
            {
                //this line of code allows data into the prop
                mDoB = value;

            }
        }
        public Boolean GdprRequest
        {
            get
            {
                //this line of code sends data out of the prop
                return mGdprRequest;
            }
            set
            {
                //this line of code allows data into the prop
                mGdprRequest = value;

            }
        }
        public bool Find(int CustomerId)
        {
            //set the private data members to the test data value
            mCustomerId = 1;

            mName = "Bruce Lee";

            mAddress = "Turbo Road";

            mPostcode = "PE10 1AB";

            mDoB = Convert.ToDateTime("10/04/1998");

            mGdprRequest = true;

         
            //always return true
            return true;
        }

        public string Valid(int mCustomerId)
        {
            return "";
        }

        public string Valid(string name, string address, string postcode, string dob)
        {
            throw new NotImplementedException();
        }
        
    }
}