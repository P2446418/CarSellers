<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StaffViewer.aspx.cs" Inherits="StaffViewer" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="Form1" runat="server">
        <p>
            <br />
            Typed in ID :
            <asp:TextBox ID="IDAppearBox" runat="server"></asp:TextBox>
            <asp:Button ID="FindButton" runat="server" OnClick="FindButton_Click" Text="Search" />
        </p>
        <p>
            Typed in FirstName :
            <asp:TextBox ID="FirstNameAppearBox" runat="server" Width="276px"></asp:TextBox>
        </p>
        <p>
            Typed in Surname :
            <asp:TextBox ID="SurnameAppearBox" runat="server" Width="298px"></asp:TextBox>
        </p>
        <p>
            Typed in Mobile :
            <asp:TextBox ID="MobileAppearBox" runat="server" Width="302px"></asp:TextBox>
        </p>
        <p>
            Typed in Position :
            <asp:TextBox ID="PositionAppearBox" runat="server" Width="297px"></asp:TextBox>
        </p>
        <p>
            Typed in Date of birth :
            <asp:TextBox ID="DateAppearBox" runat="server" Width="266px"></asp:TextBox>
        </p>
        <p>
            Want to delete? :
            <asp:Label ID="DeleteStaffLabel" runat="server" Text="---" BackColor="White"></asp:Label>
        </p>
        <div>
        </div>
    </form>
</body>
</html>
