using System;
using CarSellersClasses;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class OrderLineViewer : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        clsOrderLine AnOrderLine = new clsOrderLine();
        AnOrderLine = (clsOrderLine)Session["AnOrderLine"];
        Response.Write(AnOrderLine.orderLineID);
    }
}