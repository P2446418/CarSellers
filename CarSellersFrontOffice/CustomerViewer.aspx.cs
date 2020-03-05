using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CarSellersClasses;

public partial class CustomerViewer : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        clsCustomer newCustomer = new clsCustomer();
        newCustomer = (clsCustomer)Session["newCustomer"];
        //Response.Write(newCustomer.name);
        IDAppearBox.Text = Convert.ToString(newCustomer.CustomerID);
        NameAppearBox.Text = newCustomer.name;
        SurnameAppearBox.Text = newCustomer.surname;
        MobileAppearBox.Text = Convert.ToString(newCustomer.PhoneNumber);
        EmailAppearBox.Text = newCustomer.email;
        AddressAppearBox.Text = newCustomer.Address;
        DateAppearBox.Text = Convert.ToString(newCustomer.DOB);
        
        if (newCustomer.toDelete == true)
        {
            DeleteCustomerLabel.BackColor = System.Drawing.Color.Green;
        }
        else
        {
            DeleteCustomerLabel.BackColor = System.Drawing.Color.Red;
        }
    }


    protected void EmailAppearBox_TextChanged(object sender, EventArgs e)
    {

    }
}