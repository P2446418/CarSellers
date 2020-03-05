<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CustomerViewer.aspx.cs" Inherits="CustomerViewer" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <p>
            <br />
            Typed in ID :
            <asp:TextBox ID="IDAppearBox" runat="server"></asp:TextBox>
        </p>
        <p>
            Typed in Name :<asp:TextBox ID="NameAppearBox" runat="server" Width="276px"></asp:TextBox>
        </p>
        <p>
            Typed in Surname :<asp:TextBox ID="SurnameAppearBox" runat="server" Width="298px"></asp:TextBox>
        </p>
        <p>
            Typed in email :
            <asp:TextBox ID="EmailAppearBox" runat="server" OnTextChanged="EmailAppearBox_TextChanged" Width="361px"></asp:TextBox>
        </p>
        <div>
        </div>
    </form>
</body>
</html>
