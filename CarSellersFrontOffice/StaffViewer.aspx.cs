using CarSellersClasses;
using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class StaffViewer : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        clsStaff aStaff = new clsStaff();
        aStaff = (clsStaff)Session["aStaff"];
        Response.Write(aStaff.FirstName);
        if (aStaff != null)
        {
            IDAppearBox.Text = Convert.ToString(aStaff.StaffID);
            FirstNameAppearBox.Text = aStaff.FirstName;
            SurnameAppearBox.Text = aStaff.Surname;
            MobileAppearBox.Text = Convert.ToString(aStaff.MobileNumber);
            PositionAppearBox.Text = aStaff.Position;
            DateAppearBox.Text = Convert.ToString(aStaff.DOB);
            DeleteCustomerLabel.Text = Convert.ToString(aStaff.toDelete);
        }
    }

    protected void EmailAppearBox_TextChanged(object sender, EventArgs e)
    {

    }

    protected void FindButton_Click(object sender, EventArgs e)
    {
        clsStaff aStaff = new clsStaff();
        Int32 CustomerNo;
        Boolean Found = false;
        CustomerNo = Convert.ToInt32(IDAppearBox.Text);
        try
        {
            Found = aStaff.Find(CustomerNo);
            if (Found == true)
            {
                NameAppearBox.Text = aStaff.FirstName;
                SurnameAppearBox.Text = aStaff.Surname;
                MobileAppearBox.Text = Convert.ToString(aStaff.MobileNumber);
                PositionAppearBox.Text = aStaff.Position;
                DateAppearBox.Text = Convert.ToString(aStaff.DOB);
                DeleteCustomerLabel.Text = Convert.ToString(aStaff.toDelete);
            }
            else
            {
                IDAppearBox.Text = "Customer Not Found";
            }
        }
        catch (System.FormatException)
        {
            IDAppearBox.Text = "Invalid Input";
        }
    }
}