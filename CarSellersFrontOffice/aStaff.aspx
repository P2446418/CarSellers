<%@ Page Language="C#" AutoEventWireup="true" CodeFile="aStaff.aspx.cs" Inherits="aStaff" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="Form1" runat="server">
        <div>
            <div>
            <asp:TextBox ID="errorOutput" runat="server" Font-Bold="True" Font-Size="12pt" Height="20px" ReadOnly="True" TextMode="MultiLine" Visible="False" Width="1000px"></asp:TextBox>
            </div>
            <br />
            <asp:Label ID="StaffIDLabel" runat="server" Text="StaffID"></asp:Label>
            <asp:TextBox ID="StaffIDTextBox" runat="server" ClientIDMode="AutoID"></asp:TextBox>
            <br />
            <br />
            FirstName :&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:TextBox ID="FirstNameTextBox" runat="server"></asp:TextBox>
            <br />
            <br />
            Surname :&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <asp:TextBox ID="SurnameTextBox" runat="server"></asp:TextBox>
            <br />
            <br />
            DOB :&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <asp:TextBox ID="DOBTextBox" runat="server"></asp:TextBox>
            &nbsp;&nbsp;&nbsp;&nbsp; Enter date in format DD/MM/YY
            <br />
            <br />
            MobileNumber :&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <asp:TextBox ID="MobileNumberTextBox" runat="server"></asp:TextBox>
            <br />
            <br />
            Position :&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <asp:TextBox ID="PosTextBox" runat="server"></asp:TextBox>
            <br />
            <br />
            InOffice? &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <asp:CheckBox ID="IOCheckBox" runat="server" />
        </div>
        <br />
        <asp:Button ID="StaffOKButton" runat="server" OnClick="StaffOKButton_Click" Text="OK" />
    </form>
</body>
</html>
