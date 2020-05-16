<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CustomerList.aspx.cs" Inherits="CustomerList" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:ListBox ID="CustomerListBox" runat="server" Height="438px" Width="686px" Font-Size="Medium" OnSelectedIndexChanged="CustomerListBox_SelectedIndexChanged"></asp:ListBox>
            <br />
            <br />
            <asp:Label ID="ErrorLabel" runat="server" Font-Names="Calibri" Font-Size="15pt" Text="Errors will appear here"></asp:Label>
            <br />
            <br />
            <asp:Button ID="CustomerAddButton" runat="server" BorderWidth="5px" Font-Size="Medium" OnClick="CustomerAddButton_Click" Text="Add Customer" />
            <asp:Button ID="CustomerEditButton" runat="server" BorderWidth="5px" Font-Size="Medium" OnClick="CustomerEditButton_Click" Text="Edit Customer" />
            <asp:Button ID="CustomerDeleteButton" runat="server" BorderWidth="5px" Font-Size="Medium" OnClick="CustomerDeleteButton_Click" Text="Delete Customer" />
        </div>
    </form>
</body>
</html>
