<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CustomerLayer.aspx.cs" Inherits="CustomerLayer" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        #Text1 {
            height: 17px;
            width: 131px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:TextBox ID="errorOutput" runat="server" Font-Bold="True" Font-Size="12pt" Height="20px" ReadOnly="True" TextMode="MultiLine" Visible="False" Width="1000px"></asp:TextBox>
        </div>
        <br />
        Name :&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="NameTextBox" runat="server" Width="246px"></asp:TextBox>
        <br />
        <br />
        Surname :&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <asp:TextBox ID="SurnameTextBox" runat="server" Width="281px"></asp:TextBox>
        <br />
        <br />
        Phone Number : <asp:TextBox ID="MobileTextBox" runat="server" Width="252px"></asp:TextBox>
        <br />
        <br />
        Email :&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <asp:TextBox ID="EmailTextBox" runat="server" Width="426px"></asp:TextBox>
        <br />
        <br />
        Address :&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="AddressTextBox" runat="server" Width="433px"></asp:TextBox>
        <br />
        <br />
        Date of birth :&nbsp;&nbsp;&nbsp; <asp:TextBox ID="DateTextBox" runat="server"></asp:TextBox>
        &nbsp;&nbsp; Enter date in format YYYY-MM-DD<br />
        <br />
        <p>
            <asp:Button ID="OkButton" runat="server" OnClick="OkButton_Click" Text="OK" Width="33px" />
        </p>
    </form>

    </body>
</html>
