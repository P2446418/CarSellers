<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">

<head runat="server">
    <title>Car Sellers Website</title>
</head>

<body style="height: 150px">
    <!-- Logo and company name -->
    <form id="form1" runat="server">
        <div style="margin-left: auto; margin-right: auto; text-align: center;">
            <asp:Image ID="LogoImage" runat="server" Height="83px" ImageUrl="~/Bin/CarSellersLogo.png" Width="124px" />
            <h1>Car Sellers</h1>
        </div>

        <!-- Identification label just states who is logged in to site, e.g. no-one, customer or staff -->
        <asp:Label ID="IdentificationLabel" runat="server" Font-Names="Calibri" Font-Size="15pt" Text="Not Currently Logged In, please log in before browsing cars" Height="35px"></asp:Label>
        

        <!-- Customer And Staff Buttons and Customer Login Panel -->
        <div style="height: 538px">

            <asp:Button ID="CustomerLoginButton" runat="server" Text="Customer Login" Font-Size="Medium" Height="43px" OnClick="CustomerLoginButton_Click" Width="189px" />
            
            <asp:Button ID="CustomerCreateAccountButton" runat="server" Font-Size="Medium" Height="43px" Text="Create Account" Width="189px" OnClick="CustomerCreateAccountButton_Click" />
            
            <asp:Button ID="CustomerViewAccountButton" runat="server" Font-Size="Medium" Height="43px" OnClick="CustomerViewAccountButton_Click" Text="My Account" Width="189px" />
            
            <asp:Button ID="ViewOrdersButton" runat="server" Font-Size="Medium" Height="43px" Text="My Orders" Width="189px" />
            
            <asp:Panel ID="CustomerLoginPanel" runat="server" Height="199px" BorderWidth="10px" Width="897px" Visible="False">
                <asp:Label ID="EmailLabel" runat="server" BorderWidth="5px" Font-Names="Calibri" Font-Size="15pt" Text="Email :       " Width="144px"></asp:Label>
                <asp:TextBox ID="CustomerEmailTextBox" runat="server" BorderWidth="0px" Font-Size="15pt" Width="703px"></asp:TextBox>
                <asp:Label ID="CIDLabel" runat="server" BorderWidth="5px" Font-Names="Calibri" Font-Size="15pt" Text="Customer ID : "></asp:Label>
                <asp:TextBox ID="CustomerIDTextBox" runat="server" Font-Size="15pt" Width="714px"></asp:TextBox>
                <asp:Button ID="CustomerLogin" runat="server" BorderWidth="10px" Font-Size="15pt" OnClick="CustomerLogin_Click" Text="Login" />
                <asp:TextBox ID="CustomerLoginErrorTextBox" runat="server" BorderWidth="10px" Font-Names="Calibri" Font-Size="12pt" Height="93px" ReadOnly="True" TextMode="MultiLine" Visible="False" Width="741px"></asp:TextBox>
            </asp:Panel>

            <asp:Button ID="StaffControlsButton" runat="server" Font-Size="Medium" Height="43px" Text="Staff Controls" Width="189px" OnClick="StaffControlsButton_Click" />
            

            <asp:Panel ID="StaffPanel" runat="server" Height="55px" Width="900px" BorderWidth="10px" Visible="False">
                </asp:Panel>
       
        </div>
        
    </form>

</body>
</html>
