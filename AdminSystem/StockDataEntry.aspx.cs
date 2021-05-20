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

    protected void btnFind_Click(object sender, EventArgs e)
    {
        //create an instance of the stock class
        clsStock AnStock = new clsStock();
        //variable to store the primary key
        Int32 ProductNo;
        //variable to store the result of the find operation
        Boolean Found = false;
        //get the primary key entered by the user
        ProductNo = Convert.ToInt32(txtProductID.Text);
        //find the record
        Found = AnStock.Find(ProductNo);
        //if found
        if (Found == true)
        {
            //display the values of the properties in the form
            txtProductID.Text = AnStock.ProductID;
            txtProductDescription.Text = AnStock.ProductDescript;
            txtPrice.Text = AnStock.Cost;
            txtStockQuantity.Text = AnStock.StockNo;
            txtStockDate.Text = AnStock.DateAdded.ToString();

        }

    }
}