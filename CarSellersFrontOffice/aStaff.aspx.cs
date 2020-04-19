using CarSellersClasses;
using System;

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
        //validation
        String FirstName = txtFirstName.Text;
        String Surname = SurnameTextBox.Text;
        String DOB = DOBTextBox.Text;
        String MobileNumber = MobNumTextBox.Text;
        String Position = PosTextBox.Text;

        String error = aStaff.Valid(FirstName, Surname, DOB, MobileNumber, Position);

        if (error == "")
        {
            //no errors, program will work as normal

            //StaffID set to blank to prevent error, ID allocated by db
            aStaff.StaffID = 0;
            aStaff.FirstName = FirstName;
            aStaff.Surname = Surname;
            aStaff.DOB = DateTime.Parse(DOB);
            aStaff.MobileNumber = Convert.ToInt32(MobileNumber);
            aStaff.Position = Position;
            //aStaff.toDelete = DelStaff.Checked;
            Session["aStaff"] = aStaff;
            Response.Redirect("StaffViewer.aspx");

        }
        else
        {
            //make error box visible, set to size and enter data
            errorOutput.Visible = true;
            String[] errors = error.Split('\n');
            errorOutput.Height = errors.Length * 25;
            errorOutput.Text = "Errors found within input: " + "\r\n\n";
            foreach (String errorCase in errors)
            {
                errorOutput.Text += errorCase + "\r\n";
            }
        }
    }