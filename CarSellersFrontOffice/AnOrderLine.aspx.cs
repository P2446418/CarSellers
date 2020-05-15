using System;
using CarSellersClasses;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class AnOrderLine : System.Web.UI.Page
{
    Int32 OrderLineID;
    protected void Page_Load(object sender, EventArgs e)
    {
        OrderLineID = Convert.ToInt32(Session["OrderLineID"]);
        if(IsPostBack == false)
        {
            // if not new record
            if(OrderLineID != -1)
            {
                //display current orderLine
                DisplayOrderLine();
            }
        }
        clsOrderLine AnOrderLine = new clsOrderLine();
        AnOrderLine = (clsOrderLine)Session["AnOrderLine"];
        //Response.Write(AnOrder.orderID);

    }

    void DisplayOrderLine()
    {
        // create instance of orderLineCollection
        clsOrderLineCollection OrderLineList = new clsOrderLineCollection();
        // find record to edit
        OrderLineList.ThisOrderLine.Find(OrderLineID);
        // display data for record
        txtOrderLineID.Text = OrderLineList.ThisOrderLine.orderLineID.ToString();
        txtOrderID.Text = OrderLineList.ThisOrderLine.orderID.ToString();
        txtStaffID.Text = OrderLineList.ThisOrderLine.staffID.ToString();
        chkOrderComplete.Checked = OrderLineList.ThisOrderLine.orderComplete;
    }

    protected void btnOK_Click(object sender, EventArgs e)
    {
        // create new instance
        clsOrderLine AnOrderLine = new clsOrderLine();
        // capture staff id
        string StaffID = txtStaffID.Text;
        // capture order id
        string OrderID = txtOrderID.Text;
        // Error string
        string Error = "";
        // validate data
        Error = AnOrderLine.Valid(OrderID, StaffID);
        if(Error == "")
        {
            // capture orderline ID
            AnOrderLine.orderLineID = OrderLineID; 
            // capture order ID
            AnOrderLine.orderID = Convert.ToInt32(OrderID);
            // capture staff ID
            AnOrderLine.staffID = Convert.ToInt32(StaffID);
            // capture order Complete
            AnOrderLine.orderComplete = chkOrderComplete.Checked;
            // new istance of order line collection
            clsOrderLineCollection OrderLineList = new clsOrderLineCollection();
            // if this is a new record
            if (OrderLineID == -1)
            {
                // set thisOrderLine
                OrderLineList.ThisOrderLine = AnOrderLine;
                // add new record
                OrderLineList.Add();
            }
            // otherwise must be update
            else
            {
                // find record to update
                OrderLineList.ThisOrderLine.Find(OrderLineID);
                // set thisOrderLine
                OrderLineList.ThisOrderLine = AnOrderLine;
                // update record
                OrderLineList.Update();
            }
            // redirect to list page
            Response.Redirect("OrderLineList.aspx");
        }
        else
        {
            // display error message
            lblError.Text = Error;
        }
    }

    protected void btnFind_Click(object sender, EventArgs e)
    {
        // new orderline
        clsOrderLine anOrderLine = new clsOrderLine();
        Int32 OrderLineID;
        Boolean Found = false;
        OrderLineID = Convert.ToInt32(txtOrderLineID.Text);
        // find specified orderline
        Found = anOrderLine.Find(OrderLineID);
        if (Found == true)
        {
            // display orderline
            txtOrderID.Text = anOrderLine.orderID.ToString();
            txtStaffID.Text = anOrderLine.staffID.ToString();
            chkOrderComplete.Checked = anOrderLine.orderComplete;
        }
    }
}