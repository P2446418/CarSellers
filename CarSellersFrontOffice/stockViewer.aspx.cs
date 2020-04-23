using CarSellersClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class stockViewer : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        clsStock AStock = new clsStock();

        AStock = (clsStock)Session["AStock"];

        Response.Write(AStock.numberPlate);
        Response.Write(AStock.productionYear);
        Response.Write(AStock.mileage);
        Response.Write(AStock.price);
        Response.Write(AStock.sold);
        Response.Write(AStock.modelName);
    }
}