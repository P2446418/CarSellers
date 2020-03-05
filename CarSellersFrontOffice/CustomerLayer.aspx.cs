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
        newCustomer.CustomerID = Convert.ToInt32(IDTextBox.Text);
        newCustomer.name = NameTextBox.Text;
        newCustomer.surname = SurnameTextBox.Text;
        newCustomer.PhoneNumber = Convert.ToInt32(MobileTextBox.Text);
        newCustomer.email = EmailTextBox.Text;
        newCustomer.Address = AddressTextBox.Text;
        newCustomer.DOB = DateTime.Parse(DateTextBox.Text);
        newCustomer.toDelete = DelCustomer.Checked;
        Session["newCustomer"] = newCustomer;
        Response.Redirect("CustomerViewer.aspx");
        
    }

}