<%@ Page Language="C#" AutoEventWireup="true" CodeFile="OrderLineList.aspx.cs" Inherits="OrderLineList" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:ListBox ID="lstOrderLineList" runat="server" Height="498px" Width="569px" OnSelectedIndexChanged="lstOrderLineList_SelectedIndexChanged"></asp:ListBox>
            <br />
            <asp:Button ID="btnAdd" runat="server" Text="Add" OnClick="btnAdd_Click" />
            <asp:Button ID="btnEdit" runat="server" style="margin-left: 19px" Text="Edit" Width="83px" OnClick="btnEdit_Click" />
            <asp:Button ID="btnDelete" runat="server" Text="Delete" OnClick="btnDelete_Click" style="margin-left: 16px" />
            <br />
            <br />
            Enter an Order ID
            <asp:TextBox ID="txtFilter" runat="server" style="margin-left: 24px"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="btnApply" runat="server" Text="Apply" OnClick="btnApply_Click" />
            <asp:Button ID="btnClear" runat="server" style="margin-left: 26px" Text="Clear" OnClick="btnClear_Click" />
            <br />
            <asp:Label ID="lblError" runat="server" Text=""></asp:Label>
        </div>
    </form>
</body>
</html>
