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
        newCustomer.name = NameLabel.Text;
        Session["newCustomer"] = newCustomer;
        Response.Redirect("CustomerViewer.aspx");
    }
}