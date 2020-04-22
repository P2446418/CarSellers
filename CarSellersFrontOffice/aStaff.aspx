﻿<%@ Page Language="C#" AutoEventWireup="true" CodeFile="aStaff.aspx.cs" Inherits="aStaff" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="Form1" runat="server">
        <div>
            <asp:Label ID="StaffIDLabel" runat="server" Text="StaffID"></asp:Label>
            <asp:TextBox ID="StaffIDTextBox" runat="server" ClientIDMode="AutoID"></asp:TextBox>
            <br />
            FirstName<asp:TextBox ID="FirstNameTextBox" runat="server"></asp:TextBox>
            <br />
            Surname<asp:TextBox ID="SurnameTextBox" runat="server"></asp:TextBox>
            <br />
            DOB<asp:TextBox ID="DOBTextBox" runat="server"></asp:TextBox>
            <br />
            MobileNumber<asp:TextBox ID="MobileNumberTextBox" runat="server"></asp:TextBox>
            <br />
            Position<asp:TextBox ID="PosTextBox" runat="server"></asp:TextBox>
            <br />
            InOffice<asp:CheckBox ID="IOCheckBox" runat="server" />
        </div>
        <br />
        <asp:Button ID="StaffOKButton" runat="server" OnClick="StaffOKButton_Click" Text="OK" />
        <asp:Button ID="StaffCancelButton" runat="server" Text="Cancel" />
    </form>
</body>
</html>
