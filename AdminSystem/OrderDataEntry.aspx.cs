using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_DataEntry : System.Web.UI.Page
{
    Int32 OrderID;
    protected void Page_Load(object sender, EventArgs e)
    {
        OrderID = Convert.ToInt32(Session["OrderID"]);
        if (IsPostBack == false)
        {
            if (OrderID != -1)
            {
                DisplayOrders();
            }
        }
    }

    void DisplayOrders()
    {
        clsOrderCollection OrderBook = new clsOrderCollection();
        OrderBook.ThisOrder.Find(OrderID);
        txtOrderID.Text = OrderBook.ThisOrder.OrderID.ToString();
        txtTotalItem.Text = OrderBook.ThisOrder.TotalItem.ToString();
        txtTotalPrice.Text = OrderBook.ThisOrder.TotalPrice.ToString();
        txtDeliveryAddress.Text = OrderBook.ThisOrder.DeliveryAddress;
        txtDateOrdered.Text = OrderBook.ThisOrder.DateOrdered.ToString();
        chkAvailable.Checked = OrderBook.ThisOrder.ItemAvailable;

    }

    protected void btnOK_Click(object sender, EventArgs e)
    {
        clsOrder AnOrder = new clsOrder();
        Int32 OrderID = Convert.ToInt32(txtOrderID.Text);
        string TotalItem = txtTotalItem.Text;
        string TotalPrice = txtTotalPrice.Text;
        string DeliveryAddress = txtDeliveryAddress.Text;
        string DateOrdered = txtDateOrdered.Text;
        string Error = "";
        Error = AnOrder.Valid(DateOrdered, DeliveryAddress);
        if (Error == "")
        {
            AnOrder.OrderID = OrderID;
            AnOrder.TotalItem = Convert.ToInt32(TotalItem);
            AnOrder.TotalPrice = Convert.ToDouble(TotalPrice);
            AnOrder.DeliveryAddress = DeliveryAddress;
            AnOrder.DateOrdered = Convert.ToDateTime(DateOrdered);
            AnOrder.ItemAvailable = chkAvailable.Checked;
            clsOrderCollection OrderList = new clsOrderCollection();

            if (OrderID == -1)
            {
                OrderList.ThisOrder = AnOrder;
                OrderList.Add();
            }
            else
            {
                OrderList.ThisOrder.Find(OrderID);
                OrderList.ThisOrder = AnOrder;
                OrderList.Update();
            }
            Response.Redirect("OrderList.aspx");
        }
        else
        {
            lblError.Text = Error;
        }
    }

    protected void btnFind_Click(object sender, EventArgs e)
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