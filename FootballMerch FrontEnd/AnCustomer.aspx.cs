using FootballMerch_Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class AnCustomer : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //create a new instance of clsCustomer
        clsCustomer AnCustomer = new clsCustomer();
        //get the data from the session object
        AnCustomer = (clsCustomer)Session["AnCustomer"];
        //display the address number for this entry
        Response.Write(AnCustomer.Address);
    }

    protected void txtFirstName_TextChanged(object sender, EventArgs e)
    {

    }

    protected void txtLastName_TextChanged(object sender, EventArgs e)
    {

    }

    protected void txtPhoneNo_TextChanged(object sender, EventArgs e)
    {

    }

    protected void txtEmail_TextChanged(object sender, EventArgs e)
    {

    }

    protected void txtDOB_TextChanged(object sender, EventArgs e)
    {

    }

    protected void txtAddress_TextChanged(object sender, EventArgs e)
    {

    }

    protected void txtCity_TextChanged(object sender, EventArgs e)
    {

    }

    protected void txtPostcode_TextChanged(object sender, EventArgs e)
    {

    }

    protected void IsGuestValid_CheckedChanged(object sender, EventArgs e)
    {

    }

    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        //create a new instance of clsCustomer
        clsCustomer AnCustomer = new clsCustomer();
        //capture First name
        AnCustomer.FirstName = txtFirstName.Text;
        //capture second name
        AnCustomer.LastName = txtLastName.Text;
        //capture phone number
        AnCustomer.PhoneNo = Convert.ToInt16(txtPhoneNo.Text);
        //capture the email
        AnCustomer.Email = txtEmail.Text;
        //capture the DOB
        AnCustomer.DOB = Convert.ToDateTime(txtDOB.Text);
        //capture the address
        AnCustomer.Address = txtAddress.Text;
        //capture the city
        AnCustomer.City = txtCity.Text;
        //capture the postcode
        AnCustomer.Postcode = txtPostcode.Text;
        //capture guest validation
        
        // store the address in the session object
        Session["AnCustomer"] = AnCustomer;
        //redirect to Viewer page
        Response.Redirect("CustomerViewer.aspx");
    
    }

    protected void btnCancel_Click(object sender, EventArgs e)
    {

    }
}