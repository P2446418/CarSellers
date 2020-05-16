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
            Customer ID :
            <asp:TextBox ID="IDAppearBox" runat="server"></asp:TextBox>
        </p>
        <p>
            Name : <asp:TextBox ID="NameAppearBox" runat="server" Width="276px"></asp:TextBox>
        </p>
        <p>
            Surname : <asp:TextBox ID="SurnameAppearBox" runat="server" Width="298px"></asp:TextBox>
        </p>
        <p>
            Mobile Number : <asp:TextBox ID="MobileAppearBox" runat="server" Width="302px"></asp:TextBox>
        </p>
        <p>
            Email : <asp:TextBox ID="EmailAppearBox" runat="server" Width="361px"></asp:TextBox>
        </p>
        <p>
            Address : <asp:TextBox ID="AddressAppearBox" runat="server" Width="297px"></asp:TextBox>
        </p>
        <p>
            Date of birth : <asp:TextBox ID="DateAppearBox" runat="server" Width="266px"></asp:TextBox>
        </p>
        <p>
            Delete this account? : <asp:CheckBox ID="toDeleteCheckBox" runat="server" />
        </p>
        <p>
            <asp:Button ID="UpdateCustomerButton" runat="server" Font-Size="Medium" OnClick="UpdateCustomerButton_Click" Text="Update Account" />
        </p>
        <div>
        </div>
    </form>
</body>
</html>
