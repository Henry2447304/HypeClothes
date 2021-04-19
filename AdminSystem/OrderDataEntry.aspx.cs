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
        clsOrder AnOrder = new clsOrder();
        string OrderID = txtOrderID.Text;
        string TotalItem = txtTotalItem.Text;
        string TotalPrice = txtTotalPrice.Text;
        string DeliveryAddress = txtDeliveryAddress.Text;
        string DateOrdered = txtDateOrdered.Text;
        string Error = "";
        Error = AnOrder.Valid(DateOrdered, DeliveryAddress);
        if (Error == "")
        {
            AnOrder.OrderID = Convert.ToInt32(OrderID);
            AnOrder.TotalItem = Convert.ToInt32(TotalItem);
            AnOrder.TotalPrice = Convert.ToDouble(TotalPrice);
            AnOrder.DeliveryAddress = DeliveryAddress;
            AnOrder.DateOrdered = Convert.ToDateTime(DateOrdered);
            AnOrder.Available = chkAvailable.Checked;
            clsOrderCollection OrderList = new clsOrderCollection();
            OrderList.ThisOrder = AnOrder;
            OrderList.Add();
            Response.Redirect("OrderList.aspx");
        }
        else
        {
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