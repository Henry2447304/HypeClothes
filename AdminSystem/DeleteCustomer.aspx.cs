﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class DeleteCustomer : System.Web.UI.Page
{
    Int32 CustomerId;
    protected void Page_Load(object sender, EventArgs e)
    {
        CustomerId = Convert.ToInt32(Session["CustomerId"]);
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        clsCustomerCollection Customers = new clsCustomerCollection();
        Customers.ThisCustomer.Find(CustomerId);
        Customers.Delete();
        Response.Redirect("CustomerList.aspx");
            
    }

    protected void Button2_Click(object sender, EventArgs e)
    {

    }
}