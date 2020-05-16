<%@ Page Language="C#" AutoEventWireup="true" CodeFile="deleteStock.aspx.cs" Inherits="deleteStock" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Are you sure you want to delete this record?</div>
        <asp:Button ID="yesButton" runat="server" OnClick="yesButton_Click" Text="Yes" />
        <asp:Button ID="noButton" runat="server" OnClick="noButton_Click" Text="No" />
    </form>
</body>
</html>
