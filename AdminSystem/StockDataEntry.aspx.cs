using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_DataEntry : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void TextBox1_TextChanged(object sender, EventArgs e)
    {

    }

    protected void TextBox1_TextChanged1(object sender, EventArgs e)
    {

    }

    protected void BtnOK_Click(object sender, EventArgs e)
    {
        //create a new instance for class stock
        clsStock AnStock = new clsStock();
        //capture the product description
        AnStock.ProductDescript = txtProductDescription.Text;
        //store product description
        Session["AnProduct"] = AnStock;
        //navigate to the viewer page
        Response.Redirect("StockViewer.aspx");
    }
}