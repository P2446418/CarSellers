<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">

<head runat="server">
    <title>Car Sellers Website</title>
    <style type="text/css">
        .auto-style1 {
            width: 293px;
        }
        .auto-style2 {
            width: 121px;
        }
    </style>
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
        

        <!-- Customer And Staff Buttons -->
        <div style="height: 538px">

            <asp:Button ID="CustomerLoginButton" runat="server" Text="Customer Login" Font-Size="Medium" Height="43px" OnClick="CustomerLoginButton_Click" Width="189px" />
            
            <asp:Button ID="StaffControlsButton" runat="server" Font-Size="Medium" Height="43px" Text="Staff Controls" Width="189px" OnClick="StaffControlsButton_Click" />

            <asp:Button ID="CustomerViewAccountButton" runat="server" Font-Size="Medium" Height="43px" OnClick="CustomerViewAccountButton_Click" Text="My Account" Width="189px" />
            
            <asp:Button ID="ViewOrdersButton" runat="server" Font-Size="Medium" Height="43px" Text="My Orders" Width="189px" />

            <br />
            <!-- MultiView containing the customer and staff controls -->
            <asp:MultiView ID="MultiView1" runat="server" OnActiveViewChanged="MultiView1_ActiveViewChanged">
                <asp:View ID="View1" runat="server">
                    <table style="width: 100%;">
                        <tr>
                            <td class="auto-style2"><h2>Login</h2></td>
                        </tr>
                        <tr>
                            <td class="auto-style2"><strong>Email :</strong></td>
                            <td>
                                <asp:TextBox ID="CustomerEmailTextBox" runat="server" Width="525px"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td class="auto-style2"><strong>Customer ID :</strong></td>
                            <td>
                                <asp:TextBox ID="CustomerIDTextBox" runat="server" Width="522px"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td class="auto-style2">
                                &nbsp;&nbsp;
                                <asp:Button ID="CustomerLogin" runat="server" BorderWidth="10px" Font-Size="15pt" OnClick="CustomerLogin_Click" Text="Login" />
                            </td>
                            <td>
                                &nbsp;&nbsp;
                                <asp:Button ID="CustomerCreateAccountButton" runat="server" Font-Size="15pt" Height="58px" Text="Create Account" Width="204px" OnClick="CustomerCreateAccountButton_Click" BorderWidth="10px" />
                            </td>
                        </tr>
                        <tr>
                            <td class="auto-style2"></td>
                            <td class="auto-style1">
                                <asp:TextBox ID="CustomerLoginErrorTextBox" runat="server" BorderWidth="10px" Font-Names="Calibri" Font-Size="15pt" ReadOnly="True" TextMode="MultiLine" Visible="False" Width="824px"></asp:TextBox>
                            </td>
                        </tr>
                    </table>
                </asp:View>

                <asp:View ID="View2" runat="server">
                    <!-- where staff controls will go -->
                </asp:View>

            </asp:MultiView>
       
        </div>
        
    </form>

</body>
</html>
