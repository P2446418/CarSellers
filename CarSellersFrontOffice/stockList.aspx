<%@ Page Language="C#" AutoEventWireup="true" CodeFile="stockList.aspx.cs" Inherits="stockList" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:ListBox ID="lstStockList" runat="server" Height="454px" OnSelectedIndexChanged="lstStockList_SelectedIndexChanged" Width="692px"></asp:ListBox>
        <p>
            <asp:Button ID="addButton" runat="server" Text="Add" OnClick="addButton_Click" />
            <asp:Button ID="deleteButton" runat="server" Text="Delete" OnClick="deleteButton_Click" />
        </p>
        <asp:Label ID="lblError" runat="server" Text="Label"></asp:Label>
    </form>
</body>
</html>
