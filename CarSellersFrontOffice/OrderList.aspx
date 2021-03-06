﻿<%@ Page Language="C#" AutoEventWireup="true" CodeFile="OrderList.aspx.cs" Inherits="OrderList" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div style="height: 708px">
            <asp:ListBox ID="lstOrderList" runat="server" Height="452px" Width="632px" OnSelectedIndexChanged="lstOrderList_SelectedIndexChanged"></asp:ListBox>
            <br />
            <asp:Button ID="btnAdd" runat="server" Text="Add" OnClick="btnAdd_Click" />
            <asp:Button ID="btnEdit" runat="server" style="margin-left: 19px" Text="Edit" Width="83px" OnClick="btnEdit_Click" />
            <asp:Button ID="btnDelete" runat="server" Text="Delete" OnClick="btnDelete_Click" style="margin-left: 16px" />
            <br />
            <br />
            <br />
            Enter a Number Plate
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
