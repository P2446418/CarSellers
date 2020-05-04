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
        AStock.modelName = txtModelName.Text;


        Session["AStock"] = AStock;

        Response.Redirect("stockViewer.aspx");
    }
     


    protected void CheckBox1_CheckedChanged(object sender, EventArgs e)
    {

    }

    protected void ButtonFind_Click(object sender, EventArgs e)
    {
        clsStock AStock = new clsStock();

        string numberPlate;

        Boolean found = false;

        numberPlate = txtNumberPlate.Text;

        found = AStock.Find(numberPlate);

        if(found == true)
        {
            txtProductionYear.Text = Convert.ToString(AStock.productionDate);
            txtMileage.Text = Convert.ToString(AStock.mileage);
            txtPrice.Text = Convert.ToString(AStock.price);
            CheckBoxSold.Checked = AStock.sold;
            txtModelName.Text = AStock.modelName;
        }
    }
}
