using System;
using CarSellersClasses;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class AnOrderLine : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        clsOrderLine AnOrderLine = new clsOrderLine();
        AnOrderLine = (clsOrderLine)Session["AnOrderLine"];
        //Response.Write(AnOrder.orderID);

    }

    protected void btnOK_Click(object sender, EventArgs e)
    {
        clsOrderLine AnOrderLine = new clsOrderLine();
        AnOrderLine.orderLineID = Convert.ToInt32(txtOrderLineID.Text);
        AnOrderLine.staffID = Convert.ToInt32(txtStaffID.Text);
        AnOrderLine.orderID = Convert.ToInt32(txtOrderID.Text);
        AnOrderLine.orderComplete = Convert.ToBoolean(chkOrderComplete.Checked);
        Session["AnOrderLine"] = AnOrderLine;
        Response.Redirect("OrderLineViewer.aspx");
    }

    protected void btnFind_Click(object sender, EventArgs e)
    {
        clsOrderLine anOrderLine = new clsOrderLine();
        Int32 OrderLineID;
        Boolean Found = false;
        OrderLineID = Convert.ToInt32(txtOrderLineID.Text);
        Found = anOrderLine.Find(OrderLineID);
        if (Found == true)
        {
            txtOrderID.Text = anOrderLine.orderID.ToString();
            txtStaffID.Text = anOrderLine.staffID.ToString();
            chkOrderComplete.Checked = anOrderLine.orderComplete;
        }
    }
}