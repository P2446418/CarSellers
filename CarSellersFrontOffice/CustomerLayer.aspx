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
        Name :
        <asp:Label ID="NameLabel" runat="server" Text="Bob Smith"></asp:Label>
        <br />
        <p>
            <asp:Button ID="OkButton" runat="server" OnClick="OkButton_Click" Text="OK" Width="33px" />
        </p>
    </form>
</body>
</html>
