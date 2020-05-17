using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CarSellersClasses;

public partial class CustomerViewer : System.Web.UI.Page
{
    clsCustomer globalCustomer = new clsCustomer();

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
            toDeleteCheckBox.Checked = newCustomer.toDelete;
            globalCustomer = newCustomer;
        }
    }

    //update the customer's data in the database
    protected void UpdateCustomerButton_Click(object sender, EventArgs e)
    {
        clsCustomerCollection collection = new clsCustomerCollection();
        collection.thisCustomer = globalCustomer;
        collection.update();
    }
}