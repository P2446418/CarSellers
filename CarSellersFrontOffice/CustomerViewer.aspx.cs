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
        Response.Write(newCustomer.name);
    }

}