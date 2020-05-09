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

        string numberPlate = txtNumberPlate.Text;
        string productionDate = txtProductionYear.Text;
        string mileage = txtMileage.Text;
        string price = txtPrice.Text;
        string sold = Convert.ToString(CheckBoxSold.Checked);
        string modelName = txtModelName.Text;
        string Error = "";
        Error = AStock.Valid(productionDate, mileage, price, sold, modelName);
        if (Error == "")
        {
            AStock.numberPlate = txtNumberPlate.Text;
            AStock.productionDate = DateTime.ParseExact(txtProductionYear.Text, "dd/mm/yyyy", null);
            AStock.mileage = Convert.ToInt32(txtMileage.Text);
            AStock.price = Convert.ToInt32(txtPrice.Text);
            AStock.sold = CheckBoxSold.Checked;
            AStock.modelName = txtModelName.Text;

            Session["AStock"] = AStock;

            Response.Write("stockViewer.aspx");
        }
        else
        {
            lblError.Text = Error;
        }


       


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
            txtProductionYear.Text = (AStock.productionDate).ToString("dd/mm/yyyy");
            txtMileage.Text = Convert.ToString(AStock.mileage);
            txtPrice.Text = Convert.ToString(AStock.price);
            CheckBoxSold.Checked = AStock.sold;
            txtModelName.Text = AStock.modelName;
        }
    }
}
