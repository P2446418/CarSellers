<%@ Page Language="C#" AutoEventWireup="true" CodeFile="aStaff.aspx.cs" Inherits="aStaff" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            FirstName<asp:Label ID="StaffFirstNameLabel" runat="server" Text="Label"></asp:Label>
            <br />
            Surname<asp:Label ID="StaffSurnameLabel" runat="server" Text="Label"></asp:Label>
            <br />
            DOB<asp:Label ID="StaffDOBLabel" runat="server" Text="Label"></asp:Label>
            <br />
            MobileNumber<asp:Label ID="StaffMobileNumberLabel" runat="server" Text="Label"></asp:Label>
            <br />
            Position<asp:Label ID="StaffPositionLabel" runat="server" Text="Label"></asp:Label>
            <br />
            InOffice<asp:Label ID="StaffInOfficeLabel" runat="server" Text="Label"></asp:Label>
        </div>
        <asp:Label ID="StaffErrorLabel" runat="server" Text="Label"></asp:Label>
        <br />
        <asp:Button ID="StaffOKButton" runat="server" OnClick="StaffOKButton_Click" Text="OK" />
        <asp:Button ID="StaffCancelButton" runat="server" Text="Cancel" />
    </form>
</body>
</html>
