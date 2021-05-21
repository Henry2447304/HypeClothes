using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_DataEntry : System.Web.UI.Page
{
    // variable to store the primary key with page level scope
    Int32 CustomerId;
    protected void Page_Load(object sender, EventArgs e)
    {
        //get the number of the Name to be processed
        CustomerId = Convert.ToInt32(Session["CustomerId"]);
        if (IsPostBack == false)
        {
            //if this is not a new record
            if (CustomerId != -1)
            {
                //display the current data for the record
                DisplayCustomer();
            }
        }
    }

    void DisplayCustomer()
    {
        clsCustomerCollection Customer = new clsCustomerCollection();
        //find the record to update
        Customer.ThisCustomer.Find(CustomerId);
        //display the data for this record
        txtCustomerName.Text = Customer.Name;
        txtAddress.Text = Customer.Address;
        txtDoB.Text = Customer.DoB.ToString();
        txtPostcode.Text = Customer.Postcode;
        chkGdprRequest.Text = Customer.GdprRequest.ToString();
    }

    protected void btnFind_Click(object sender, EventArgs e)
    {
        clsCustomer aCustomer = new clsCustomer();
        //variable to store the primary key
        Int32 CustomerId;
        //variable to store the result of the find operation
        Boolean found = false;
        int Temp;
        //check if invalid data was entered to CustomerID
        bool invalid = Int32.TryParse(txtCustomerId.Text, out Temp);
        while (invalid == false)
        {

            lblError.Text = "Please enter a number";
            txtCustomerName.Text = String.Empty;
            txtAddress.Text = String.Empty;
            txtPostcode.Text = String.Empty;
            txtDoB.Text = String.Empty;
            chkGdprRequest.Checked = aCustomer.GdprRequest;
            //check the data again
            invalid = Int32.TryParse(txtCustomerId.Text, out CustomerId);
            return;
        }
        //convert value 
        CustomerId = Convert.ToInt32(txtCustomerId.Text);
        //find the record
        found = aCustomer.Find(CustomerId);
        //if the ID is found
        if (found == true)
        {
            //display the values of the properties in the form
            lblError.Text = String.Empty;
            txtCustomerName.Text = aCustomer.Name;
            txtAddress.Text = aCustomer.Address;
            txtPostcode.Text = aCustomer.Postcode;
            txtDoB.Text = aCustomer.DoB.ToString();
            chkGdprRequest.Checked = aCustomer.GdprRequest;
        }
        else
        {
            lblError.Text = "No customer found";
            txtCustomerName.Text = String.Empty;
            txtAddress.Text = String.Empty;
            txtPostcode.Text = String.Empty;
            txtDoB.Text = String.Empty;
            chkGdprRequest.Checked = aCustomer.GdprRequest;
        }
    }


    protected void btnOk_Click(object sender, EventArgs e)
    {
            clsCustomer ACustomer = new clsCustomer();
            string Name = txtCustomerName.Text;
            string Address = txtAddress.Text;
            string PhoneNumber = txtPostcode.Text;
            string DateAdded = txtDoB.Text;
            Boolean GdprRequest = chkGdprRequest.Checked;
            // variable to store any error messages
            string Error = "";
            Error = ACustomer.Valid(Name, Address, Postcode, DoB);
            if (Error == "")
            {
                ACustomer.CustomerId = CustomerId;
                ACustomer.Name = Name;
                ACustomer.Address = Address;
                ACustomer.Postcode = Postcode;
                ACustomer.DoB = Convert.ToDateTime(DoB);
                ACustomer.GdprRequest = GdprRequest;
                //new instance of the Customer collection
                clsCustomerCollection CustomerList = new clsCustomerCollection();
                //if this is a new record
                if (CustomerId == -1)
                {
                    //setting the ThisCustomer property
                    CustomerList.ThisCustomer = ACustomer;
                    //add the new record
                    CustomerList.Add();
                }
                //otherwise it must be an update
                else
                {
                    //find the record to update
                    CustomerList.ThisCustomer.Find(CustomerId);
                    //set the ThisCustomer property
                    CustomerList.ThisCustomer = ACustomer;
                    //update the record
                    CustomerList.Update();

                }
                //redirect to the list page
                Response.Redirect("CustomerList.aspx");
            }
            else
            {
                //display the error message
                lblError.Text = Error;
            }

        }

    protected void btnCancel_Click1(object sender, EventArgs e)
    {
        {
            Response.Redirect("CustomerList.aspx");
        }
    }
}