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

    protected void btnOk_Click(object sender, EventArgs e)
    {
        //create a new instance of clsCustomer
        clsCustomer AnCustomer = new clsCustomer();
        //capture the CustomerId
        //AnCustomer.CustomerId = txtCustomerId.Text;
        //capture the name
        AnCustomer.Name = txtCustomerName.Text;
        //capture the Address
        AnCustomer.Address = txtAddress.Text;
        //capture the Postcode
        AnCustomer.Postcode = txtPostcode.Text;
        //capture the Dob
        //AnCustomer.Dob = txtDoB.Text;
        //capture the GdrpRequest
        //AnCustomer.Gdpr = chkGdprRequest.CheckBox;
        //store the name in the session object
        Session["AnCustomer"] = AnCustomer;
    }
}