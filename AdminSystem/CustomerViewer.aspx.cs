using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1Viewer : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //create a new instance of ClsCustomer
        clsCustomer AnCustomer = new clsCustomer();
        //get the data from the session object
        AnCustomer = (clsCustomer)Session["AnCustomer"];
        //display the CustomerId for this entry
        Response.Write(AnCustomer.CustomerId);
        //display the name for this entry
        Response.Write(AnCustomer.Name);
        //display the Address for this entry
        Response.Write(AnCustomer.Address);
        //display the Postcode for this entry
        Response.Write(AnCustomer.Postcode);
        //display the DoB for this entry
        Response.Write(AnCustomer.DoB);
        //display the Gdpr for this entry
        Response.Write(AnCustomer.GdprRequest);

    }
}