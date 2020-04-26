using CarSellersClasses;
using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;



public partial class AnOrder : System.Web.UI.Page
{
    // store primary key with page level scope
    Int32 OrderID;
    protected void Page_Load(object sender, EventArgs e)
    {
        // get order id to be processed
        OrderID = Convert.ToInt32(Session["OrderID"]);
        if (IsPostBack == false)
        {
            // if not new record
            if(OrderID != -1)
            {
                DisplayOrder();
            }
        }
        //clsOrder AnOrder = new clsOrder();
        //AnOrder = (clsOrder)Session["AnOrder"];
        //Response.Write(AnOrder.orderID);

    }

    private void DisplayOrder()
    {
        // create instance of order list
        clsOrderCollection OrderList = new clsOrderCollection();
        // find record to update
        OrderList.ThisOrder.Find(OrderID);
        // display data for record
        txtOrderID.Text = OrderList.ThisOrder.orderID.ToString();
        txtNumberPlate.Text = OrderList.ThisOrder.numberPlate;
        txtCustID.Text = OrderList.ThisOrder.customerID.ToString();
        txtQuantity.Text = OrderList.ThisOrder.quantity.ToString();
        txtPrice.Text = OrderList.ThisOrder.price.ToString();
        txtOrderDate.Text = OrderList.ThisOrder.dateOrdered.ToString();
    }

    protected void OkBtn_Click(object sender, EventArgs e)
    {
        clsOrder AnOrder = new clsOrder();
        string OrderID = txtOrderID.Text;
        string NumberPlate = txtNumberPlate.Text;
        string CustomerID = txtCustID.Text;
        string Quantity = txtQuantity.Text;
        string DateOrdered = txtOrderDate.Text;
        string Price = txtPrice.Text;
        string Error = "";

        Error = AnOrder.Valid(DateOrdered, NumberPlate, CustomerID, Quantity, Price);

        if(Error == "")
        {
            // capture order id
            AnOrder.orderID = Convert.ToInt32(OrderID);
            // capture number plate
            AnOrder.numberPlate = NumberPlate;
            // capture customer id
            AnOrder.customerID = Convert.ToInt32(CustomerID);
            // capture quantity
            AnOrder.quantity = Convert.ToInt32(Quantity);
            // capture order date
            AnOrder.dateOrdered = Convert.ToDateTime(DateOrdered);
            // capture price
            AnOrder.price = Convert.ToDouble(Price);
            // new instance of order collection
            clsOrderCollection OrderList = new clsOrderCollection();

            // if this is a new record
            if (Convert.ToInt32(OrderID) == -1)
            {
                OrderList.ThisOrder = AnOrder;
                // add new record
                OrderList.Add();
            }
            // otherwise update
            else
            {
                // find record to update
                OrderList.ThisOrder.Find(Convert.ToInt32(OrderID));
                // set the this address property
                OrderList.ThisOrder = AnOrder;
                // update record
                OrderList.Update();
            }
            // redirect to list page
            Response.Redirect("OrderList.aspx");
        }
        else
        {
            // display error
            lblError.Text = Error;
        }

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