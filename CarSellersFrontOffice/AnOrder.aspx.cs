using CarSellersClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;



public partial class AnOrder : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        clsOrder new_order = new clsOrder();
        new_order = (clsOrder)Session["new_order"];
        Response.Write(new_order.OrderID);

    }

    protected void okBtn_Click(object sender, EventArgs e)
    {

    }
}