using System;
using System.Collections.Generic;

namespace ClassLibrary
{

    public class clsCustomerCollection
    {


        public clsCustomerCollection()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.Execute("sproc_TblCustomer_SelectAll");
            PopulateArray(DB);

        }
        List<clsCustomer> mCustomerList = new List<clsCustomer>();
        public List<clsCustomer> CustomerList
        {
            get
            {
                return mCustomerList;
            }
            set
            {
                mCustomerList = value;
            }
        }
        public int Count
        {
            get
            {
                return mCustomerList.Count;
            }
            set
            {
               
            }
        }
        clsCustomer mThisCustomer = new clsCustomer();
        public clsCustomer ThisCustomer
        {
            get
            {
                return mThisCustomer;
            }
            set
            {
                mThisCustomer = value;
            }

        }

        public int Add()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("CustomerName", mThisCustomer.Name);
            DB.AddParameter("Address", mThisCustomer.Address);
            DB.AddParameter("Postcode", mThisCustomer.Postcode);
            DB.AddParameter("DoB", mThisCustomer.DoB);
            DB.AddParameter("GdprRequest", mThisCustomer.GdprRequest);
            return DB.Execute("sproc_TblCustomer_Insert");
        }
        public void Update()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("CustomerId", mThisCustomer.CustomerId);
            DB.AddParameter("CustomerName", mThisCustomer.Name);
            DB.AddParameter("Address", mThisCustomer.Address);
            DB.AddParameter("Postcode", mThisCustomer.Postcode);
            DB.AddParameter("DoB", mThisCustomer.DoB);
            DB.AddParameter("GdprRequest", mThisCustomer.GdprRequest);
            DB.Execute("sproc_TblCustomer_Update");
        }

        public void Delete()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@CustomerId", mThisCustomer.CustomerId);
            DB.Execute("sproc_tblCustomer_Delete");
        }


        public void ReportByName(string Name)
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@CustomerName", Name);
            DB.Execute("sproc_TblCustomer_FilterByName");
            PopulateArray(DB);
        }

        void PopulateArray(clsDataConnection DB)
        {
            Int32 Index = 0;
            Int32 NameCount;
            NameCount = DB.Count;
            mCustomerList = new List<clsCustomer>();
            while (Index < NameCount)
            {
                clsCustomer ACustomer = new clsCustomer();
                ACustomer.CustomerId = Convert.ToInt32(DB.DataTable.Rows[Index]["CustomerId"]);
                ACustomer.Name = Convert.ToString(DB.DataTable.Rows[Index]["CustomerName"]);
                ACustomer.Address = Convert.ToString(DB.DataTable.Rows[Index]["Address"]);
                ACustomer.Postcode = Convert.ToString(DB.DataTable.Rows[Index]["Postcode"]);
                ACustomer.DoB = Convert.ToDateTime(DB.DataTable.Rows[Index]["DoB"]);
                ACustomer.GdprRequest = Convert.ToBoolean(DB.DataTable.Rows[Index]["GdprRequest"]);
                mCustomerList.Add(ACustomer);
                Index++;
            }
        }
    }
}