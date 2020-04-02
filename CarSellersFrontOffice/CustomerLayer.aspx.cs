using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CarSellersClasses;

public partial class CustomerLayer : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        clsCustomer newCustomer = new clsCustomer();
        newCustomer = (clsCustomer)Session["newCustomer"];
        try
        {
            Response.Write(newCustomer.name);
        }
        catch (NullReferenceException)
        {
            
        }
    }

    protected void OkButton_Click(object sender, EventArgs e)
    {
        clsCustomer newCustomer = new clsCustomer();

        //validate user inputs
        String name = NameTextBox.Text;
        String surname = SurnameTextBox.Text;
        String phonenum = MobileTextBox.Text;
        String email = EmailTextBox.Text;
        String dob = DateTextBox.Text;
        String address = AddressTextBox.Text;

        String error = newCustomer.Valid(name, surname, dob, phonenum, email, address);

        if (error == "")
        {
            //no errors, program goes ahead

            //customerID is set to blank to prevent error, ID re-allocated by database
            newCustomer.CustomerID = 0;
            newCustomer.name = name;
            newCustomer.surname = surname;
            newCustomer.PhoneNumber = Convert.ToInt32(phonenum);
            newCustomer.email = email;
            newCustomer.Address = address;
            newCustomer.DOB = DateTime.Parse(dob);
            newCustomer.toDelete = DelCustomer.Checked;
            Session["newCustomer"] = newCustomer;
            Response.Redirect("CustomerViewer.aspx");
        }
        else
        {
            //make error box visible, set correct size and enter data into it
            errorOutput.Visible = true;
            String[] errors = error.Split('\n');
            errorOutput.Height = errors.Length * 25;
            errorOutput.Text = "Errors found within input: " + "\r\n\n";
            foreach (String errorCase in errors)
            {
                errorOutput.Text += errorCase + "\r\n";
            }
        }
        
    }

}