using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_DataEntry : System.Web.UI.Page
{
    Int32 CustomerId;
    protected void Page_Load(object sender, EventArgs e)
    {
        CustomerId = Convert.ToInt32(Session["CustomerId"]);
        if (IsPostBack == false)
        {
            DisplayCustomer();
        }
    }
    void DisplayCustomer()
    {
        clsCustomerCollection Customers = new clsCustomerCollection();
        //find the record to update
        Customers.ThisCustomer.Find(CustomerId);
        //display the data for this record
        txtCustomerId.Text = Customers.ThisCustomer.CustomerId.ToString();
        txtCustomerName.Text = Customers.ThisCustomer.Name;
        txtAddress.Text = Customers.ThisCustomer.Address;
        txtPostcode.Text = Customers.ThisCustomer.Postcode;
        txtDoB.Text = Customers.ThisCustomer.DoB.ToString();
        chkGdprRequest.Checked = Customers.ThisCustomer.GdprRequest;
    }

    protected void btnOk_Click(object sender, EventArgs e)

    {
        clsCustomer AnCustomer = new clsCustomer();
        String Name = txtCustomerName.Text;
        String Address = txtAddress.Text;
        String Postcode = txtPostcode.Text;
        String DoB = txtDoB.Text;
        string Error = "";
        Error = AnCustomer.Valid(Name, Address, Postcode, DoB);
        if (Error == "")
        {
            //capture the name
            AnCustomer.Name = CustomerId;
            //capture the Address
            AnCustomer.Address = Address;
            //capture the Postcode
            AnCustomer.Postcode = Postcode;
            //capture the Dob
            AnCustomer.DoB = Convert.ToDateTime(DoB);
            //cap Gdpr
            AnCustomer.GdprRequest = chkGdprRequest.Checked;
            //new cust col
            clsCustomerCollection CustomerList = new clsCustomerCollection();

            if (CustomerId == -1)
            {
                CustomerList.ThisCustomer = AnCustomer;
                CustomerList.Add();
            }
            else
            {
                CustomerList.ThisCustomer.Find(CustomerId);
                CustomerList.ThisCustomer = AnCustomer;
                CustomerList.Update();
            }
            Response.Redirect("CustomerList.aspx");
        }
        else
        {
            lblError.Text = Error;
        }

        
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