using System;
using System.Collections.Generic;

namespace ClassLibrary
{
    public class clsStockCollection
    {
        private List<clsStock> mStockList = new List<clsStock>();
        private clsStock mThisStock = new clsStock();
        public clsStockCollection()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.Execute("sproc_tblStock_SelectAll");
            PopulateArray(DB);

        }


        public List<clsStock> StockList
        {
            get
            {
                return mStockList;
            }
            set
            {
                mStockList = value;
            }
        }
        public int Count
        {
            get
            {
                return mStockList.Count;
            }
            set
            {

            }
        }
        public clsStock ThisStock
        {
            get
            {
                return mThisStock;
            }
            set
            {
                mThisStock = value;
            }
        }

        public int Add()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@ProductID", mThisStock.ProductID);
            DB.AddParameter("@ProductDescript", mThisStock.ProductDescript);
            DB.AddParameter("@Cost", mThisStock.Cost);
            DB.AddParameter("@StockNo", mThisStock.StockNo);
            DB.AddParameter("@DateAdded", mThisStock.DateAdded);
            DB.AddParameter("@InStck", mThisStock.InStck);
            return DB.Execute("sproc_tblStock_Insert");
        }

        public void Delete()
        {
            //deletes the record pointed to by thisStock
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure
            DB.AddParameter("@ProductID", mThisStock.ProductID);
            //execute the stored procedure
            DB.Execute("sproc_tblStock_Delete");
        }

        public void Update()
        {
            //update an existing record based on the values of thisStock
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@StockNo", mThisStock.StockNo);
            DB.AddParameter("@ProductNo", mThisStock.ProductID);
            DB.AddParameter("@ProductDescript", mThisStock.ProductDescript);
            DB.AddParameter("@Cost", mThisStock.Cost);
            DB.AddParameter("@DateAdded", mThisStock.DateAdded);
            DB.AddParameter("@InStck", mThisStock.InStck);
            //execute the stored procedure
            DB.Execute("sproc_tblStock_Update");
        }

        public void ReportByProductDescript(string ProductDescript)
        {
            //filters the records
            //connect to database
            clsDataConnection DB = new clsDataConnection();
            //send the product descript parameter to database
            DB.AddParameter("@ProductDescript", ProductDescript);
            DB.Execute("sproc_tblStock_FilterByProductDescript");
            PopulateArray(DB);
        }

        void ClsStockCollection()
        {
            Int32 Index = 0;
            Int32 RecordCount = 0;
            clsDataConnection DB = new clsDataConnection();
            DB.Execute("sproc_tblStock_SelectAll");
            RecordCount = DB.Count;
            while (Index < RecordCount)
            {
                clsStock AnStock = new clsStock();

                AnStock.ProductID = Convert.ToInt32(DB.DataTable.Rows[Index]["ProductID"]);
                AnStock.StockNo = Convert.ToInt32(DB.DataTable.Rows[Index]["StockNo"]);
                AnStock.ProductDescript = Convert.ToString(DB.DataTable.Rows[Index]["ProductDescript"]);
                AnStock.DateAdded = Convert.ToDateTime(DB.DataTable.Rows[Index]["DateAdded"]);
                AnStock.InStck = Convert.ToBoolean(DB.DataTable.Rows[Index]["InStck"]);
                AnStock.Cost = Convert.ToInt32(DB.DataTable.Rows[Index]["Cost"]);
                mStockList.Add(AnStock);
                Index++;
            }
        }

        void PopulateArray(clsDataConnection DB)
        {
            Int32 Index = 0;
            Int32 RecordCount;
            RecordCount = DB.Count;
            mStockList = new List<clsStock>();
            while (Index < RecordCount)
            {
                clsStock AnStock = new clsStock();
                AnStock.ProductID = Convert.ToInt32(DB.DataTable.Rows[Index]["ProductID"]);
                AnStock.StockNo = Convert.ToInt32(DB.DataTable.Rows[Index]["StockNo"]);
                AnStock.ProductDescript = Convert.ToString(DB.DataTable.Rows[Index]["ProductDescript"]);
                AnStock.DateAdded = Convert.ToDateTime(DB.DataTable.Rows[Index]["DateAdded"]);
                AnStock.InStck = Convert.ToBoolean(DB.DataTable.Rows[Index]["InStck"]);
                AnStock.Cost = Convert.ToInt32(DB.DataTable.Rows[Index]["Cost"]);
                mStockList.Add(AnStock);
                Index++;
            }
        }
    }
}