<%@ Page Language="C#" AutoEventWireup="true" CodeFile="AStock.aspx.cs" Inherits="AStock" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        #Text1 {
            height: 8px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            number plate:
            <asp:TextBox ID="txtNumberPlate" runat="server"></asp:TextBox>
            <asp:Button ID="ButtonFind" runat="server" Text="Find" OnClick="ButtonFind_Click" />
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Label ID="lblError" runat="server" Text=""></asp:Label>
            <br />
            production year:
            <asp:TextBox ID="txtProductionYear" runat="server"></asp:TextBox>
            <br />
            mileage:
            <asp:TextBox ID="txtMileage" runat="server"></asp:TextBox>
            <br />
            price:
            <asp:TextBox ID="txtPrice" runat="server"></asp:TextBox>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <br />
            sold:
            <asp:CheckBox ID="CheckBoxSold" runat="server" OnCheckedChanged="CheckBox1_CheckedChanged" />
            <br />
            model name:
            <asp:TextBox ID="txtModelName" runat="server"></asp:TextBox>
            <br />
            <br />
            &nbsp;
            <asp:Button ID="ButtonOk" runat="server" OnClick="ButtonOk_Click" Text="Ok" />
            <input id="Button2" type="button" value="Cancel" /></div>
    </form>
</body>
</html>
