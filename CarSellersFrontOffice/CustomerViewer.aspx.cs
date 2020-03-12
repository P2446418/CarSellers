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
        if (newCustomer != null)
        {
            IDAppearBox.Text = Convert.ToString(newCustomer.CustomerID);
            NameAppearBox.Text = newCustomer.name;
            SurnameAppearBox.Text = newCustomer.surname;
            MobileAppearBox.Text = Convert.ToString(newCustomer.PhoneNumber);
            EmailAppearBox.Text = newCustomer.email;
            AddressAppearBox.Text = newCustomer.Address;
            DateAppearBox.Text = Convert.ToString(newCustomer.DOB);
            DeleteCustomerLabel.Text = Convert.ToString(newCustomer.toDelete);
        }
    }


    protected void EmailAppearBox_TextChanged(object sender, EventArgs e)
    {

    }

    protected void FindButton_Click(object sender, EventArgs e)
    {
        clsCustomer newCustomer = new clsCustomer();
        Int32 CustomerNo;
        Boolean Found = false;
        CustomerNo = Convert.ToInt32(IDAppearBox.Text);
        try
        {
            Found = newCustomer.Find(CustomerNo);
            if (Found == true)
            {
                NameAppearBox.Text = newCustomer.name;
                SurnameAppearBox.Text = newCustomer.surname;
                MobileAppearBox.Text = Convert.ToString(newCustomer.PhoneNumber);
                EmailAppearBox.Text = newCustomer.email;
                AddressAppearBox.Text = newCustomer.Address;
                DateAppearBox.Text = Convert.ToString(newCustomer.DOB);
                DeleteCustomerLabel.Text = Convert.ToString(newCustomer.toDelete);
            }
            else
            {
                IDAppearBox.Text = "Customer Not Found";
            }
        }
        catch (System.FormatException)
        {
            IDAppearBox.Text = "Invalid Input";
        }
    }
}