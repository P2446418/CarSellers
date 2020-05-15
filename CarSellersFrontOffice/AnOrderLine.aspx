<%@ Page Language="C#" AutoEventWireup="true" CodeFile="AnOrderLine.aspx.cs" Inherits="AnOrderLine" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        #order_id0 {
            margin-bottom: 1px;
        }
        #order_id1 {
            margin-bottom: 2px;
        }
        #form1 {
            height: 333px;
        }
        #Text1 {
            margin-left: 47px;
        }
        #customer_id {
            margin-left: 18px;
        }
        #Text2 {
            margin-left: 28px;
        }
        #Text3 {
            margin-left: 69px;
        }
        #quantity {
            margin-left: 51px;
        }
        #number_plate {
            margin-left: 15px;
        }
        #order_id {
            margin-left: 43px;
        }
        #order_date {
            margin-left: 31px;
        }
        #price {
            margin-left: 72px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
            <asp:Label ID="Label1" runat="server" Text="OrderLine ID"></asp:Label>
            <asp:TextBox ID="txtOrderLineID" runat="server"></asp:TextBox> 
        <asp:Button ID="btnFind" runat="server" OnClick ="btnFind_Click" Height="26px" Text="Find" Width="56px" style="margin-left: 25px" />
            <br />
        <asp:Label ID="Label2" runat="server" Text="Order ID"></asp:Label>
            <asp:TextBox ID="txtOrderID" runat="server"></asp:TextBox> <br />
            <asp:Label ID="Label3" runat="server" Text="Staff ID"></asp:Label>
            <asp:TextBox ID="txtStaffID" runat="server"></asp:TextBox> <br />
        <asp:Label ID="Label4" runat="server" Text="Order Complete"></asp:Label>
        <asp:CheckBox ID="chkOrderComplete" runat="server"></asp:CheckBox><br />
        <br />
        <br />
        <asp:Button ID="btnOK" runat="server" OnClick ="btnOK_Click" Height="26px" Text="OK" Width="38px" style="margin-top: 0px" />
        <asp:Button ID="btnCancel" runat="server" style="margin-left: 24px" Text="Cancel" />
            <br />
            <br />
            <asp:Label ID="lblError" runat="server" Text=""></asp:Label>
    </form>
    </body>
</html>
