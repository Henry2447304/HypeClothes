using System;
using System.Collections.Generic;

namespace ClassLibrary
{
    public class clsOrderCollection
    {
        List<clsOrder> mOrderList = new List<clsOrder>();
        clsOrder mThisOrder = new clsOrder();

        public List<clsOrder> OrderList
        {
            get
            {
                return mOrderList;
            }
            set
            {
                mOrderList = value;
            }
        }
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
        public clsOrder ThisOrder
        {
            get
            {
                return mThisOrder;
            }
            set
            {
                mThisOrder = value;
            }
        }

        public clsOrderCollection()
        {
            Int32 Index = 0;
            Int32 RecordCount = 0;
            clsDataConnection DB = new clsDataConnection();
            DB.Execute("sproc_tblOrder_SelectAll");
            RecordCount = DB.Count;
            while (Index < RecordCount)
            {
                clsOrder AnOrder = new clsOrder();
                AnOrder.ItemAvailable = Convert.ToBoolean(DB.DataTable.Rows[Index]["ItemAvailable"]);
                AnOrder.OrderID = Convert.ToInt32(DB.DataTable.Rows[Index]["OrderID"]);
                AnOrder.TotalItem = Convert.ToInt32(DB.DataTable.Rows[Index]["TotalItem"]);
                AnOrder.TotalPrice = Convert.ToDouble(DB.DataTable.Rows[Index]["TotalPrice"]);
                AnOrder.DeliveryAddress = Convert.ToString(DB.DataTable.Rows[Index]["DeliveryAddress"]);
                AnOrder.DateOrdered = Convert.ToDateTime(DB.DataTable.Rows[Index]["DateOrdered"]);

                mOrderList.Add(AnOrder);
                Index++;
            }

        }

        public int Add()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@TotalItem", mThisOrder.TotalItem);
            DB.AddParameter("@TotalPrice", mThisOrder.TotalPrice);
            DB.AddParameter("@DeliveryAddress", mThisOrder.DeliveryAddress);
            DB.AddParameter("@DateOrdered", mThisOrder.DateOrdered);
            DB.AddParameter("@ItemAvailable", mThisOrder.ItemAvailable);
            return DB.Execute("sproc_tblOrder_Insert");
        }

        public void Update()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@OrderID", mThisOrder.OrderID);
            DB.AddParameter("@TotalItem", mThisOrder.TotalItem);
            DB.AddParameter("@TotalPrice", mThisOrder.TotalPrice);
            DB.AddParameter("@DeliveryAddress", mThisOrder.DeliveryAddress);
            DB.AddParameter("@DateOrdered", mThisOrder.DateOrdered);
            DB.AddParameter("@ItemAvailable", mThisOrder.ItemAvailable);
            DB.Execute("sproc_tblOrder_Update");
        }

        public void Delete()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@OrderID", mThisOrder.OrderID);
            DB.Execute("sproc_tblOrder_Delete");
        }
    }
}