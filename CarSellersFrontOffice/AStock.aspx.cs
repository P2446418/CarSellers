using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CarSellersClasses;

public partial class AStock : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }



    protected void ButtonOk_Click(object sender, EventArgs e)
    {
        clsStock AStock = new clsStock();

        AStock.numberPlate = txtNumberPlate.Text;
        AStock.productionDate = DateTime.ParseExact(txtProductionYear.Text, "yyyy", null);
        AStock.mileage = Convert.ToInt32(txtMileage.Text);
        AStock.price = Convert.ToInt32(txtPrice.Text);
        AStock.sold = CheckBoxSold.Checked;
        AStock.modelName = txtNumberPlate.Text;


        Session["AStock"] = AStock;

        Response.Redirect("stockViewer.aspx");
    }
     


    protected void CheckBox1_CheckedChanged(object sender, EventArgs e)
    {

    }
}
