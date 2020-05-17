using CarSellersClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class deleteStock : System.Web.UI.Page
{
    string numberPlate;
    
    protected void Page_Load(object sender, EventArgs e)
    {
        numberPlate = Session["numberPlate"].ToString();
    }

    protected void yesButton_Click(object sender, EventArgs e)
    {
        clsStockCollection stockList = new clsStockCollection();
        stockList.thisStock.Find(numberPlate);
        stockList.Delete();
        Response.Redirect("stockList.aspx");
    }

    protected void noButton_Click(object sender, EventArgs e)
    {

    }

}