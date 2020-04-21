using CarSellersClasses;
using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class OrderList : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        // if first time page is displayed
        if (IsPostBack == false)
        {
            // update order list
            DisplayOrders();
        }

    }

    void DisplayOrders()
    {
        // create collection instance
        clsOrderCollection Orders = new clsOrderCollection();
        // set data source for list to the Orders collection
        lstOrderList.DataSource = Orders.OrderList;
        //set primary key
        lstOrderList.DataValueField = "OrderID";
        // set data field to display
        lstOrderList.DataTextField = "numberPlate";
        // bind data to text field
        lstOrderList.DataBind();
    }

    protected void lstOrderList_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
}