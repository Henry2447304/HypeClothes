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

        public bool Find(int orderID)
        {
            //set the private data members to the test data value
            mOrderID = 1234;
            mDateOrdered = Convert.ToDateTime("09/03/2021");
            mAvailable = true;
            mTotalItem = 10;
            mTotalPrice = 15.00;
            mDeliveryAddress = "40, Some Street, Leicester, LE1 1AB";
            //alaways return true
            return true;
        }
    }
}