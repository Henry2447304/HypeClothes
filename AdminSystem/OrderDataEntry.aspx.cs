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

    protected void btnOK_Click(object sender, EventArgs e)
    {
        //create a new instance of clsOrder
        clsOrder AnOrder = new clsOrder();
        //capture the order id
        string OrderID = txtOrderID.Text;
        //capture the total item
        string TotalItem = txtTotalItem.Text;
        //capture the total price
        string TotalPrice = txtTotalPrice.Text;
        //capture the delivery address
        string DeliveryAddress = txtDeliveryAddress.Text;
        //capture the date ordered
        string DateOrdered = txtDateOrdered.Text;
        //variable to store any error messages
        string Error = "";
        //validate the data
        Error = AnOrder.Valid(DateOrdered, DeliveryAddress);
        if (Error == "")
        {
            //capture the order id
            AnOrder.OrderID = Convert.ToInt32(OrderID);
            //capture the total item
            AnOrder.TotalItem = Convert.ToInt32(TotalItem);
            //capture the total price
            AnOrder.TotalPrice = Convert.ToDouble(TotalPrice);
            //capture the delivery address
            AnOrder.DeliveryAddress = DeliveryAddress;
            //capture date ordered
            AnOrder.DateOrdered = Convert.ToDateTime(DateOrdered);
            //store the id in the session object
            Session["AnOrder"] = AnOrder;
            //navigate to the viewer page
            Response.Redirect("OrderViewer.aspx");
        }
        else
        {
            //display the error message
            lblError.Text = Error;
        }
    }

    protected void btnFind_Click1(object sender, EventArgs e)
    {
        //create an instance of the address class
        clsOrder AnOrder = new clsOrder();
        //variable to store the primary key
        Int32 OrderID;
        //variable to store the result of the find operation
        Boolean Found = false;
        //get the primary key entered by the user
        OrderID = Convert.ToInt32(txtOrderID.Text);
        //find the record
        Found = AnOrder.Find(OrderID);
        //if found
        if (Found == true)
        {
            //display the values of the properties in the form
            txtTotalItem.Text = AnOrder.TotalItem.ToString();
            txtTotalPrice.Text = AnOrder.TotalPrice.ToString();
            txtDeliveryAddress.Text = AnOrder.DeliveryAddress;
            txtDateOrdered.Text = AnOrder.DateOrdered.ToString();
        }
    }
}