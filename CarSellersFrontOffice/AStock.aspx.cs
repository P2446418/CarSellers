using System;
//using System.Activities.Expressions;
using System.Collections.Generic;
//using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CarSellersClasses;

public partial class AStock : System.Web.UI.Page
{
    string numberPlate;
    protected void Page_Load(object sender, EventArgs e)
    {
        numberPlate = Convert.ToString(Session["numberPlate"]);
        if (IsPostBack == false)
        {
            if (numberPlate != "")
            {
                DisplayStock();
            }
        }
    }

    private void DisplayStock()
    {
        clsStockCollection stockList = new clsStockCollection();

        stockList.thisStock.Find(numberPlate);

        txtNumberPlate.Text = stockList.thisStock.numberPlate;
        txtProductionYear.Text = stockList.thisStock.productionDate.ToString("dd/mm/yyyy");
        txtMileage.Text = stockList.thisStock.mileage.ToString();
        txtPrice.Text = stockList.thisStock.price.ToString();
        CheckBoxSold.Checked = stockList.thisStock.sold;
        txtModelName.Text = stockList.thisStock.modelName;

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
            AStock.numberPlate = numberPlate;
            AStock.productionDate = DateTime.ParseExact(txtProductionYear.Text, "dd/mm/yyyy", null);
            AStock.mileage = Convert.ToInt32(txtMileage.Text);
            AStock.price = Convert.ToInt32(txtPrice.Text);
            AStock.sold = CheckBoxSold.Checked;
            AStock.modelName = txtModelName.Text;

            clsStockCollection stockList = new clsStockCollection();

            if (numberPlate == "")
            {
                stockList.thisStock = AStock;
                stockList.Add();
            }
            else
            {
                stockList.thisStock.Find(numberPlate);
                stockList.thisStock = AStock;
                stockList.Update();
            }

            

            Response.Redirect("stockViewer.aspx");
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
