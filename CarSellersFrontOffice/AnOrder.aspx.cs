using CarSellersClasses;
using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;



public partial class AnOrder : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        clsOrder AnOrder = new clsOrder();
        AnOrder = (clsOrder)Session["AnOrder"];
        //Response.Write(AnOrder.orderID);

    }

    protected void OkBtn_Click(object sender, EventArgs e)
    {
        clsOrder AnOrder = new clsOrder();
        AnOrder.orderID = Convert.ToInt32(txtOrderID.Text);
        AnOrder.numberPlate = txtNumberPlate.Text;
        AnOrder.customerID = Convert.ToInt32(txtCustID.Text);
        AnOrder.quantity = Convert.ToInt32(txtQuantity.Text);
        AnOrder.dateOrdered = Convert.ToDateTime(txtOrderDate.Text);
        AnOrder.price = Convert.ToDouble(txtPrice.Text);
        Session["AnOrder"] = AnOrder;
        Response.Redirect("OrderViewer.aspx");
    }


    protected void btnFind_Click(object sender, EventArgs e)
    {
        clsOrder anOrder = new clsOrder();
        Int32 OrderID;
        Boolean Found = false;
        OrderID = Convert.ToInt32(txtOrderID.Text);
        Found = anOrder.Find(OrderID);
        if (Found == true)
        {
            txtCustID.Text = anOrder.customerID.ToString();
            txtNumberPlate.Text = anOrder.numberPlate;
            txtOrderDate.Text = anOrder.dateOrdered.ToString();
            txtPrice.Text = anOrder.price.ToString();
            txtQuantity.Text = anOrder.quantity.ToString();
        }

    }
}