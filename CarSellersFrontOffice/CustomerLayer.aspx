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
        </div>
        ID :
        <asp:TextBox ID="IDTextBox" runat="server"></asp:TextBox>
        <br />
        <br />
        Name :
        <asp:TextBox ID="NameTextBox" runat="server" Width="246px"></asp:TextBox>
        <br />
        <br />
        Surname :
        <asp:TextBox ID="SurnameTextBox" runat="server" Width="281px"></asp:TextBox>
        <br />
        <br />
        Mobile Number :
        <asp:TextBox ID="MobileTextBox" runat="server" Width="252px"></asp:TextBox>
        <br />
        <br />
        Email : <asp:TextBox ID="EmailTextBox" runat="server" Width="346px"></asp:TextBox>
        <br />
        <br />
        Address :
        <asp:TextBox ID="AddressTextBox" runat="server" Width="357px"></asp:TextBox>
        <br />
        <br />
        Date of birth : <asp:TextBox ID="DateTextBox" runat="server"></asp:TextBox>
        <br />
        <br />
        Delete me? :<asp:CheckBox ID="DelCustomer" runat="server" />
        <br />
        <p>
            <asp:Button ID="OkButton" runat="server" OnClick="OkButton_Click" Text="OK" Width="33px" />
        </p>
    </form>
</body>
</html>
