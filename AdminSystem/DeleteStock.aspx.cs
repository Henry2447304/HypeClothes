using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class DeleteStock : System.Web.UI.Page
    { 

    //var to store the priamry key value of the record to be deleted
    Int32 ProductID;

    //event handler for the load event
    protected void Page_Load(object sender, EventArgs e)
    {
        //get the product ID to be deleted from the session object
        ProductID = Convert.ToInt32(Session["ProductID"]);
    }

    protected void BtnYes_Click(object sender, EventArgs e)
    {
        //create a new instance of the stock book
        clsStockCollection Stock = new clsStockCollection();
        //find the record to delete
        Stock.ThisStock.Find(ProductID);
        //delete the record
        Stock.Delete();
        //redirect back to the main page
        Response.Redirect("StockList.aspx");
    }
}