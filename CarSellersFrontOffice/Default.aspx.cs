using System;
//using System.Collections.Generic;
//using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CarSellersClasses;

public partial class _Default : System.Web.UI.Page
{
    public clsCustomer sessionCustomer;

    protected void Page_Load(object sender, EventArgs e)
    {

    }

    //reveals customer login menu,
    protected void CustomerLoginButton_Click(object sender, EventArgs e)
    { 
        if (CustomerLoginPanel.Visible == true)
        {
            CustomerLoginPanel.Visible = false;
        }
        else
        {
            CustomerLoginPanel.Visible = true;
        }
    }

    //writes the errors found in customer validation to the multiline textbox
    public void CustomerLoginErrorTextBoxOutput(String error)
    {
        CustomerLoginErrorTextBox.Text = "";
        CustomerLoginErrorTextBox.Visible = true;
        String[] errors = error.Split('\n');
        foreach (String errorCase in errors)
        {
            CustomerLoginErrorTextBox.Text += errorCase + "\r\n";
        }
    }

    //validates the users login
    //never included password into customer's required fields so instead it checks ID and email
    protected void CustomerLogin_Click(object sender, EventArgs e)
    {
        //retrieve input data
        String InputEmail = CustomerEmailTextBox.Text;
        String InputID = CustomerIDTextBox.Text;
        String error = "";
        //check if null
        try
        {
            error = sessionCustomer.ValidateEmail(InputEmail) + sessionCustomer.ValidateNumber(InputID);
        }
        catch (NullReferenceException)
        {
            error = "Fields have been left blank";
        }
        //if there is error output to error box
        if (error != "")
        {
            CustomerLoginErrorTextBoxOutput(error);
        }
        else
        {
            //attempt to find user
            // - if non-existent, output to error box
            // - otherwise set sessionCustomer to new customer
            clsCustomer tempCustomer = new clsCustomer();
            bool exists = tempCustomer.Find(Convert.ToInt32(InputID));
            if (exists == true)
            {
                if (tempCustomer.email == InputEmail)
                {
                    //correct user
                    sessionCustomer = tempCustomer;
                    CustomerLoginErrorTextBoxOutput("Login Successful");
                    IdentificationLabel.Text = "Logged in as : " + sessionCustomer.name + " " + sessionCustomer.surname;
                    //store current user into session object
                    Session["newCustomer"] = sessionCustomer;
                }
                else
                {
                    CustomerLoginErrorTextBoxOutput("Email or ID are incorrect");
                }
            }
        }
        
    }

    //lets customer view their own data (and edit it)
    protected void CustomerViewAccountButton_Click(object sender, EventArgs e)
    {
        //store the customer in the session object
        Session["newCustomer"] = sessionCustomer;
        //check if user is actually logged in
        if (sessionCustomer != null)
        {
            //redirect to the viewer page
            Response.Redirect("CustomerViewer.aspx");
        }
    }

    //lets customer create new accont
    protected void CustomerCreateAccountButton_Click(object sender, EventArgs e)
    {
        Response.Redirect("CustomerLayer.aspx");
    }


    //reveals the staff panel
    //staff panel would contain the staff controls
    protected void StaffControlsButton_Click(object sender, EventArgs e)
    {
        StaffPanel.Visible = true;
    }

}