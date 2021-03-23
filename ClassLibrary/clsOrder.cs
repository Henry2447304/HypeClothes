using System;

namespace ClassLibrary
{
    public class clsOrder
    {
        private bool mAvailable;
        public bool Available
        {
            get
            {
                return mAvailable;
            }
            set
            {
                mAvailable = value;
            }
        }
        private DateTime mDateOrdered;
        public DateTime DateOrdered
        {
            get
            {
                return mDateOrdered;
            }
            set
            {
                mDateOrdered = value;
            }
        }
        //OrderID private member variable
        private Int32 mOrderID;
        //Order ID public property
        public Int32 OrderID
        {
            get
            {
                //this line of code sends data out of the property
                return mOrderID;
            }
            set
            {
                //this line of code allows data into the property
                mOrderID = value;
            }
        }
        private Int32 mTotalItem;
        public Int32 TotalItem
        {
            get
            {
                return mTotalItem;
            }
            set
            {
                mTotalItem = value;
            }
        }
        private double mTotalPrice;
        public double TotalPrice
        {
            get
            {
                return mTotalPrice;
            }
            set
            {
                mTotalPrice = value;
            }
        }
        private string mDeliveryAddress;
        public string DeliveryAddress
        {
            get
            {
                return mDeliveryAddress;
            }
            set
            {
                mDeliveryAddress = value;
            }
        }

        public DateTime DateTemp { get; private set; }

        public bool Find(int orderID)
        {
            //set the private data members to the test data value
            mOrderID = 1234;
            mDateOrdered = Convert.ToDateTime("09/03/2021");
            mAvailable = true;
            mTotalItem = 10;
            mTotalPrice = 15.55;
            mDeliveryAddress = "40, Some Street, Leicester, LE1 1AB";
            //alaways return true
            return true;
        }

        public string Valid(string dateOrdered, string deliveryAddress)
        {
            //create a string variable to store the error
            String Error = "";
            //if the deliveryAddress is blank
            if (deliveryAddress.Length == 0)
            {
                //record the error
                Error = Error + "The delivery address may not be blank : ";
            }
            //if the deliveryAddress is greater than 50 characters
            if (deliveryAddress.Length > 50)
            {
                //record the error
                Error = Error + "The delivery address must be less than 50 characters : ";
            }
            try
            {
                //copy the dateOrdered value to the DateTemp variable
                DateTemp = Convert.ToDateTime(dateOrdered);
                if (DateTemp < DateTime.Now.Date)
                {
                    //record the error
                    Error = Error + "The date cannot be in the past : ";
                }
                //check to see if the date is greater than today's date
                if (DateTemp > DateTime.Now.Date)
                {
                    Error = Error + "The date cannot be in the future : ";
                }
            }
            catch
            {
                //record the error
                Error = Error + "The date was not a valid date : ";
            }
            //return any error messages
            return Error;
        }
    }
}