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
        //AnCustomer.DoB = DoB.Text;
        //capture the GdrpRequest 
        AnCustomer.GdprRequest = chkGdprRequest.Checked;
        //store the name in the session object
        Session["AnCustomer"] = AnCustomer;
        //Navigate to the viewer page
        Response.Redirect("CustomerViewer.aspx");
    }

    protected void btnFind_Click(object sender, EventArgs e)
    {
        //create an inst of the customer class
        clsCustomer AnCustomer = new clsCustomer();
        //var to store the prim key
        Int32 CustomerId;
        //var to store the result of the find op
        Boolean Found = false;
        //get the prim key entered by the user
        CustomerId = Convert.ToInt32(txtCustomerId.Text);
        //find the record
        Found = AnCustomer.Find(CustomerId);
        //if found
        if (Found == true)
        {
            //display the values of the prop in the form
            txtCustomerName.Text = AnCustomer.Name;
            txtAddress.Text = AnCustomer.Address;
            txtDoB.Text = AnCustomer.DoB.ToString();
            txtPostcode.Text = AnCustomer.Postcode;
            chkGdprRequest.Text = AnCustomer.GdprRequest.ToString();



        }
    }
}