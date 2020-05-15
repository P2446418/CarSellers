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
        // indicate new record
        Session["OrderLineID"] = -1;
        // Redirect to Data Entry page
        Response.Redirect("AnOrderLine.aspx");
    }

    protected void btnEdit_Click(object sender, EventArgs e)
    {
        // primary key of record to be updated
        Int32 OrderLineID;
        // if record selected from list
        if (lstOrderLineList.SelectedIndex != -1)
        {
            // get primary key of record to be updated
            OrderLineID = Convert.ToInt32(lstOrderLineList.SelectedValue);
            // store data to session
            Session["OrderLineID"] = OrderLineID;
            // redirect to edit page
            Response.Redirect("AnOrderLine.aspx");
        }
        else // if no record selected
        {
            // display errror
            lblError.Text = "Please select a record to edit from the list";
        }
    }

    protected void btnDelete_Click(object sender, EventArgs e)
    {
        // primary key of record to be deleted
        Int32 OrderLineID;
        // if record selected from list
        if(lstOrderLineList.SelectedIndex != -1)
        {
            // get primary key value of record to delete
            OrderLineID = Convert.ToInt32(lstOrderLineList.SelectedValue);
            // store data in session
            Session["OrderLineID"] = OrderLineID;
            // redirect to delete page
            Response.Redirect("DeleteOrderLine.aspx");
        }
        else
        {
            // display error
            lblError.Text = "Please select a record to delete from the list";
        }
    }

    protected void btnApply_Click(object sender, EventArgs e)
    {
        // create instance of orderLine collection
        clsOrderLineCollection OrderLines = new clsOrderLineCollection();
        OrderLines.ReportbyOrderID(Convert.ToInt32(txtFilter.Text));
        lstOrderLineList.DataSource = OrderLines.OrderLineList;
        //set primary key
        lstOrderLineList.DataValueField = "OrderLineID";
        // set field to display
        lstOrderLineList.DataTextField = "OrderID";
        // bind data to list
        lstOrderLineList.DataBind();
    }

    protected void btnClear_Click(object sender, EventArgs e)
    {
        // instance of orderline collection
        clsOrderLineCollection OrderLines = new clsOrderLineCollection();
        DisplayOrderLines();
        txtFilter.Text = "";

    }
}