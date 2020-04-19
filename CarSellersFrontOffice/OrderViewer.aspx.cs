using CarSellersClasses;
using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class OrderViewer : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        clsOrder AnOrder = new clsOrder();
        AnOrder = (clsOrder)Session["AnOrder"];
        Response.Write(AnOrder.orderID);
        Response.Write(AnOrder.numberPlate);
        Response.Write(AnOrder.customerID);
        Response.Write(AnOrder.quantity);
        Response.Write(AnOrder.dateOrdered);
        Response.Write(AnOrder.price);

    }
}