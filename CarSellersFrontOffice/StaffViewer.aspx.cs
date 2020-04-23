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
            DeleteStaffLabel.Text = Convert.ToString(aStaff.toDelete);
        }
    }

    protected void FindButton_Click(object sender, EventArgs e)
    {
        clsStaff aStaff = new clsStaff();
        Int32 StaffNo;
        Boolean Found = false;
        StaffNo = Convert.ToInt32(IDAppearBox.Text);
        try
        {
            Found = aStaff.Find(StaffNo);
            if (Found == true)
            {
                FirstNameAppearBox.Text = aStaff.FirstName;
                SurnameAppearBox.Text = aStaff.Surname;
                MobileAppearBox.Text = Convert.ToString(aStaff.MobileNumber);
                PositionAppearBox.Text = aStaff.Position;
                DateAppearBox.Text = Convert.ToString(aStaff.DOB);
                DeleteStaffLabel.Text = Convert.ToString(aStaff.toDelete);
            }
            else
            {
                IDAppearBox.Text = "Staff Not Found";
            }
        }
        catch (System.FormatException)
        {
            IDAppearBox.Text = "Invalid Input";
        }
    }
}