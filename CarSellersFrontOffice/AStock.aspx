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
            Stock Id:
            <input id="Text1" type="text" /><br />
            production year:
            <input id="Text2" type="text" /><br />
            mileage:
            <input id="Text3" type="text" /><br />
            price:
            <input id="Text4" type="text" /><br />
            sold:
            <input id="Checkbox1" type="checkbox" /><br />
            model name:
            <input id="Text6" type="text" /><br />
            <br />
            <input id="Button1" type="button" value="ok" />&nbsp;
            <input id="Button2" type="button" value="cancel" /></div>
    </form>
</body>
</html>
