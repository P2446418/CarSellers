﻿<%@ Page Language="C#" AutoEventWireup="true" CodeFile="DeleteOrderLine.aspx.cs" Inherits="DeleteOrderLine" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Are you sure you want to delete this record?<br />
            <br />
            <asp:Button ID="btnYes" runat="server" OnClick="btnYes_Click" Text="Yes" />
            <asp:Button ID="btnNo" runat="server" Text="No" OnClick="btnNo_Click" style="margin-left: 19px; margin-right: 2px" />
        </div>
    </form>
</body>
</html>
