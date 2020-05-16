using CarSellersClasses;
using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class DeleteOrder : System.Web.UI.Page
{
    int OrderID;

    protected void Page_Load(object sender, EventArgs e)
    {
        // get record to be deleted from session object
        OrderID = Convert.ToInt32(Session["OrderID"]);
    }

    protected void btnYes_Click(object sender, EventArgs e)
    {
        // create new instance of orderList collection
        clsOrderCollection OrderList = new clsOrderCollection();
        // find record to be deleted
        OrderList.ThisOrder.Find(OrderID);
        // delete record
        OrderList.Delete();
        // redirect to main page
        Response.Redirect("OrderList.aspx");

    }

    protected void btnNo_Click(object sender, EventArgs e)
    {

    }
}