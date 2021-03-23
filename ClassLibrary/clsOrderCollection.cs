using System;
using System.Collections.Generic;

namespace ClassLibrary
{
    public class clsOrderCollection
    {
        //private data member for the list
        List<clsOrder> mOrderList = new List<clsOrder>();

        //public property for the order list
        public List<clsOrder> OrderList
        {
            get
            {
                //return the private data
                return mOrderList;
            }
            set
            {
                //set the private data
                mOrderList = value;
            }
        }
        //public property for count
        public int Count
        {
            get
            {
                return mOrderList.Count;
            }
            set
            {
                
            }
        }

        public clsOrderCollection()
        {
            //create the items of test data
            clsOrder TestItem = new clsOrder();
            TestItem.Available = true;
            TestItem.OrderID = 1234;
            TestItem.TotalItem = 10;
            TestItem.TotalPrice = 15.55;
            TestItem.DeliveryAddress = "40, Some Street, Leicester, LE1 1AB";
            TestItem.DateOrdered = DateTime.Now.Date;
            mOrderList.Add(TestItem);
            //re initialise the object for some new data
            TestItem = new clsOrder();
            TestItem.Available = true;
            TestItem.OrderID = 4567;
            TestItem.TotalItem = 15;
            TestItem.TotalPrice = 19.99;
            TestItem.DeliveryAddress = "80, Some Street, Leicester, LE1 1AB";
            TestItem.DateOrdered = DateTime.Now.Date;
            mOrderList.Add(TestItem);
        }

        public clsOrder ThisOrder { get; set; }
    }
}