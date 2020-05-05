using CarSellersClasses;
using System;
using System.Collections.Generic;

using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class OrderLineList : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        // if first time on page
        if (IsPostBack == false)
        {
            // update list
            DisplayOrderLines();
        }

    }

    void DisplayOrderLines()
    {
        // create instance of order line collection
        clsOrderLineCollection OrderLines = new clsOrderLineCollection();
        // set data source to collection
        lstOrderLineList.DataSource = OrderLines.OrderLineList;
        // set primary key
        lstOrderLineList.DataValueField = "OrderLineID";
        // set field to display
        lstOrderLineList.DataTextField = "OrderID";
        // bind data to list
        lstOrderLineList.DataBind();
    }

    protected void lstOrderLineList_SelectedIndexChanged(object sender, EventArgs e)
    {

    }

    protected void btnAdd_Click(object sender, EventArgs e)
    {

    }

    protected void btnEdit_Click(object sender, EventArgs e)
    {

    }

    protected void btnDelete_Click(object sender, EventArgs e)
    {

    }

    protected void btnApply_Click(object sender, EventArgs e)
    {

    }

    protected void btnClear_Click(object sender, EventArgs e)
    {

    }
}