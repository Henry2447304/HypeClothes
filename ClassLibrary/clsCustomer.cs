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
            //Create an instance of the data conneciton
            clsDataConnection DB = new clsDataConnection();
            //add the para for the Customer ID to search for
            DB.AddParameter("@CustomerId", CustomerId);
            //excute the stored procedure
            DB.Execute("sproc_tblCustomer_FilterByCustomerId");
            //if one record is found (there should be either one or zero
            if (DB.Count == 1)
            {
                //copy the data from the database to the private data members
                mCustomerId = Convert.ToInt32(DB.DataTable.Rows[0]["CustomerId"]);
                mName = Convert.ToString(DB.DataTable.Rows[0]["Name"]);
                mAddress = Convert.ToString(DB.DataTable.Rows[0]["Address"]);
                mDoB = Convert.ToDateTime(DB.DataTable.Rows[0]["DoB"]);
                mPostcode = Convert.ToString(DB.DataTable.Rows[0]["Postcode"]);
                mGdprRequest = Convert.ToBoolean(DB.DataTable.Rows[0]["GdprRequest"]);
                //return everything that worked
                return true;
            }
            //if no record was found
            else
            {
                //return false indi a problem
                return false;
            }
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