using CarSellersClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class aStaff : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        clsStaff aStaff = new clsStaff();
        aStaff = (clsStaff)Session["aStaff"];
        Response.Write(aStaff.FirstName);
    }

    protected void StaffOKButton_Click(object sender, EventArgs e)
    {
        clsStaff aStaff = new clsStaff();
        aStaff.FirstName = StaffFirstNameLabel.Text;
        aStaff.Surname = StaffSurnameLabel.Text;
        aStaff.DOB = StaffDOBLabel.Text;
        aStaff.MobileNumber = StaffMobileNumberLabel.Text;
        
        Session["aStaff"] = aStaff;
        Response.Redirect("StaffViewer.aspx");
    }
}