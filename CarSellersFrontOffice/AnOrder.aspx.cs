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
        clsOrder AnOrder = new clsOrder();
        AnOrder = (clsOrder)Session["AnOrder"];
        Response.Write(AnOrder.orderID);

    }

    protected void OkBtn_Click(object sender, EventArgs e)
    {
        clsOrder AnOrder = new clsOrder();
        AnOrder.orderID = txtOrderID.Text;
        AnOrder.numberPlate = txtNumberPlate.Text;
        AnOrder.customerID = txtCustID.Text;
        AnOrder.quantity = txtQuantity.Text;
        AnOrder.dateOrdered = Convert.ToDateTime(txtOrderDate.Text);
        AnOrder.price = txtPrice.Text;
        Session["AnOrder"] = AnOrder;
        Response.Redirect("OrderViewer.aspx");
    }
}