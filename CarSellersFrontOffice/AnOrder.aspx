<%@ Page Language="C#" AutoEventWireup="true" CodeFile="AnOrder.aspx.cs" Inherits="AnOrder" %>

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
        <div>
            <asp:Label ID="Label1" runat="server" Text="Order ID"></asp:Label>
            <input id="order_id" type="text" /></div>
        <asp:Label ID="Label2" runat="server" Text="Number Plate"></asp:Label>
            <input id="number_plate" type="text" /><p>
            <asp:Label ID="Label3" runat="server" Text="Customer ID"></asp:Label>
            <input id="customer_id" type="text" /></p>
        <asp:Label ID="Label4" runat="server" Text="Quantity"></asp:Label>
        <input id="quantity" type="text" /><br />
        <asp:Label ID="Label5" runat="server" Text="Order Date"></asp:Label>
        <input id="order_date" type="text" /><br />
        <asp:Label ID="Label6" runat="server" Text="Price"></asp:Label>
        <input id="price" type="text" /><br />
        <br />
        <asp:Button ID="btnOk" runat="server" Height="26px" Text="OK" Width="38px" />
        <asp:Button ID="cancel_button" runat="server" style="margin-left: 24px" Text="Cancel" />
    </form>
    </body>
</html>
