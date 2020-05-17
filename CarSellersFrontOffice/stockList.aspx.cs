using System;
using System.Collections.Generic;
//using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class stockList : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (IsPostBack == false)
        {
            displayStock();
        }
    }
    void displayStock()
    {
        CarSellersClasses.clsStockCollection Stock = new CarSellersClasses.clsStockCollection();

        lstStockList.DataSource = Stock.stockList;

        lstStockList.DataValueField = "numberPlate";

        lstStockList.DataTextField = "modelName";

        lstStockList.DataBind();
    }
    protected void lstStockList_SelectedIndexChanged(object sender, EventArgs e)
    {

    }

    protected void addButton_Click(object sender, EventArgs e)
    {
        Session["numberPlate"] = -1;

        Response.Redirect("AStock.aspx");
    }

    protected void deleteButton_Click(object sender, EventArgs e)
    {
        string numberPlate ;

        if (lstStockList.SelectedIndex != -1)
        {
            numberPlate = lstStockList.SelectedValue;
            Session["numberPlate"] = numberPlate;

            Response.Redirect("deleteStock.aspx");
        }
        else
        {
            lblError.Text = "please select a record to delete from the list";
        }
    }






    protected void Button1_Click(object sender, EventArgs e)
    {
        string numberPlate;
        if (lstStockList.SelectedIndex != -1)
        {
            numberPlate = lstStockList.SelectedValue;
            Session["numberPlate"] = numberPlate;
            Response.Redirect("AStock.aspx");
        }
        else
        {
            lblError.Text = "please select a record from the list";
        }
    }
}