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
        
    }

    public void outputErrors(String error)
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

    protected void OkButton_Click(object sender, EventArgs e)
    {
        clsCustomer newCustomer = new clsCustomer();
        clsCustomerCollection collection = new clsCustomerCollection();

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
            newCustomer.name = name;
            newCustomer.surname = surname;
            newCustomer.PhoneNumber = Convert.ToInt32(phonenum);
            newCustomer.email = email;
            newCustomer.Address = address;
            newCustomer.DOB = DateTime.Parse(dob);
            newCustomer.toDelete = false;

            //adds new customer to database
            int ID = collection.add(newCustomer);
            newCustomer.CustomerID = ID;

            //stores customer in session and redirects to account viewer
            Session["newCustomer"] = newCustomer;
            Response.Redirect("CustomerViewer.aspx");
        }
        else
        {
            outputErrors(error);
        }
        
    }


    protected void DefaultReturnButton_Click(object sender, EventArgs e)
    {
        Response.Redirect("Default.aspx");
    }
}