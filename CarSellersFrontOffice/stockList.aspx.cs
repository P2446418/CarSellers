using System;
using System.Collections.Generic;
using System.Linq;
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

        lstStockList.DataTextField = "numberPlate";

        lstStockList.DataBind();
    }
    protected void lstStockList_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
}