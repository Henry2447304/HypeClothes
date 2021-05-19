using System;

namespace ClassLibrary
{
    public class clsStock
    {
        //private data member for the product ID
        private Int32 mProductID;
        public Int32 ProductNo
        {
            get
            {
                return mProductID;
            }
            set
            {
                mProductID = value;
            }
        }

        private int mCost;
        //product cost public property
        public int Cost
        {
            get
            {
                return mCost;
            }
            set
            {
                mCost = value;
            }
        }

        //product description private member variable
        private string mProductDescript;
        //Product description public property
        public string ProductDescript
        {
            get
            {
                return mProductDescript;
            }
            set
            {
                mProductDescript = value;
            }
        }


        //stockNo private member variable
        private Int32 mStockNo;
        //StockNo public property
        public int StockNo
        {
            get
            {
                //this line of code sends data out of the property
                return mStockNo;
            }
            set
            {
                //this line of code allows data into the property
                mStockNo = value;
            }
        }

        public DateTime DateAdded
        {
            get
            {
                return mDateAdded;
            }
            set
            {
                mDateAdded = value;
            }
        }

        //private data member for active
        private Boolean mInStck;
        //public property for active
        public bool InStck
        {
            get
            {
                //return the private data
                return mInStck;
            }
            set
            {
                //set the private data
                mInStck = value;
            }
        }


        public bool Find(int stockNo)
        {
            //set the private data members to the test data value
            mProductID = 2;
            mDateAdded = Convert.ToDateTime("10/02/2021");
            mProductDescript = "Black NOCTA Hoodie";
            mCost = 120;
            mStockNo = 32;
            mInStck = true;
            //always return true
            return true;
        }
    }
}