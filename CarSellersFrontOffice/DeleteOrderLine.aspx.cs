using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CarSellersClasses;

public partial class DeleteOrderLine : System.Web.UI.Page
{
    // var for primary key of record to be deleted
    Int32 OrderLineID;
    protected void Page_Load(object sender, EventArgs e)
    {
        // get OrderLineID to be deleted
        OrderLineID = Convert.ToInt32(Session["OrderLineID"]);

    }

    protected void btnYes_Click(object sender, EventArgs e)
    {
        // new instance of order line collection
        clsOrderLineCollection OrderLineList = new clsOrderLineCollection();
        // find record to delete
        OrderLineList.ThisOrderLine.Find(OrderLineID);
        // delete record
        OrderLineList.Delete();
        // redirect to main page
        Response.Redirect("OrderLineList.aspx");
        
    }

    protected void btnNo_Click(object sender, EventArgs e)
    {

    }
}