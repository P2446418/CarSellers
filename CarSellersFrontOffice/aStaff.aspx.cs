using CarSellersClasses;
using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class AStaff : System.Web.UI.Page
{

    protected void Page_Load(object sender, EventArgs e)
    {
        clsStaff aStaff = new clsStaff();
        aStaff = (clsStaff)Session["aStaff"];
        try
        {
            Response.Write(aStaff.FirstName);
        }
        catch (NullReferenceException)
        {

        }
    }
        protected void StaffOKButton_Click(object sender, EventArgs e)
        {
            clsStaff aStaff = new clsStaff();
            aStaff.StaffID = txtStaffID.Text;
            aStaff.FirstName = txtFirstName.Text;
        
            //aStaff.Surname = SurnameTextBox.Text;
            //aStaff.DOB = DOBTextBox.Text;
            //aStaff.MobileNumber = MobNumTextBox.Text;
        
            Session["aStaff"] = aStaff;
            Response.Redirect("StaffViewer.aspx");
        }
}