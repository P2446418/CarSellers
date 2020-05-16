using System;
using System.Collections.Generic;
using System.Web.UI;
using System.Web.UI.WebControls;
using CarSellersClasses;

public partial class CustomerList : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (IsPostBack == false)
        {
            DisplayUsers();
        }
    }

    void DisplayUsers()
    {
        clsCustomerCollection Customers = new clsCustomerCollection();
        CustomerListBox.DataSource = Customers.CustomerList;
        CustomerListBox.DataValueField = "CustomerId";
        CustomerListBox.DataTextField = "Name";
        CustomerListBox.DataBind();
    }

    protected void CustomerListBox_SelectedIndexChanged(object sender, EventArgs e)
    {

    }

    protected void CustomerAddButton_Click(object sender, EventArgs e)
    {
        Response.Redirect("CustomerLayer.aspx");
    }

    protected void CustomerEditButton_Click(object sender, EventArgs e)
    {
        clsCustomerCollection Customers = new clsCustomerCollection();
        if (CustomerListBox.SelectedIndex != -1)
        {
            int Id = Convert.ToInt32(CustomerListBox.SelectedValue);
            Customers.thisCustomer.Find(Id);
            Session["newCustomer"] = Customers.thisCustomer;
            Response.Redirect("CustomerViewer.aspx");
        }
        else
        {
            ErrorLabel.Text = "[!] A record must be selected";
        }
    }

    protected void CustomerDeleteButton_Click(object sender, EventArgs e)
    {
        clsCustomerCollection Customers = new clsCustomerCollection();
        if (CustomerListBox.SelectedIndex != -1)
        {
            int Id = Convert.ToInt32(CustomerListBox.SelectedValue);
            Customers.thisCustomer.Find(Id);
            clsCustomer selectedCustomer = Customers.thisCustomer;
            Customers.delete();
        }
        else
        {
            ErrorLabel.Text = "[!] A record must be selected";
        }
    }
}