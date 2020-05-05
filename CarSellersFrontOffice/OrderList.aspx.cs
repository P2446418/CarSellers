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

    protected void btnAdd_Click(object sender, EventArgs e)
    {
        // store -1 in session to indicate a new record
        Session["OrderID"] = -1;
        // redirect to data entry page
        Response.Redirect("AnOrder.aspx");
    }

    protected void btnDelete_Click(object sender, EventArgs e)
    {
        // var of record to be deleted
        Int32 OrderID;
        // if record selected from list
        if(lstOrderList.SelectedIndex != -1)
        {
            // get primary key of record to be deleted
            OrderID = Convert.ToInt32(lstOrderList.SelectedValue);
            // store data in session object
            Session["OrderID"] = OrderID;
            // redirect to delete page
            Response.Redirect("DeleteOrder.aspx");
        }
        else // if no record selected
        {
            // display error
            lblError.Text = "Please select a record from the list";
        }
    }

    protected void btnEdit_Click(object sender, EventArgs e)
    {
        // var for primary key of record to edit
        Int32 OrderID;
        // if record is selected
        if (lstOrderList.SelectedIndex != -1)
        {
            // get primary key of record to be edited
            OrderID = Convert.ToInt32(lstOrderList.SelectedValue);
            // store data in session
            Session["OrderID"] = OrderID;
            // redirect to edit page
            Response.Redirect("AnOrder.aspx");
        }
        else // if no record selected
        {
            lblError.Text = "Please select a record to edit from the list";
        }
        
    }

    protected void btnApply_Click(object sender, EventArgs e)
    {
        // create instance of order collection
        clsOrderCollection Orders = new clsOrderCollection();
        Orders.ReportbyNumberPlate(txtFilter.Text);
        lstOrderList.DataSource = Orders.OrderList;
        // set primary key
        lstOrderList.DataValueField = "OrderID";
        // set field to display
        lstOrderList.DataTextField = "NumberPlate";
        // bind data to the list
        lstOrderList.DataBind();
    }

    protected void btnClear_Click(object sender, EventArgs e)
    {
        // create instance of order collection
        clsOrderCollection Orders = new clsOrderCollection();
        Orders.ReportbyNumberPlate("");
        // clear any filter to tidy interface
        txtFilter.Text = "";
        lstOrderList.DataSource = Orders.OrderList;
        // set primary key
        lstOrderList.DataValueField = "OrderID";
        // set field to display
        lstOrderList.DataTextField = "NumberPlate";
        // bind data to list
        lstOrderList.DataBind();
    }
}