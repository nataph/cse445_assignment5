<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CookieTryIt.aspx.cs" Inherits="Assignment5.CookieTryIt" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Cookie TryIt</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>Cookie TryIt Page</h1>
            <p>Test user settings cookie management</p>
            
            <asp:Label ID="lblCurrentSettings" runat="server" Text=""></asp:Label>
            <br/><br/>
            
            <h3>Change Settings:</h3>
            Username: <asp:TextBox ID="txtUsername" runat="server"></asp:TextBox>
            <br/>
            Theme: <asp:DropDownList ID="ddlTheme" runat="server">
                <asp:ListItem Value="light">Light Theme</asp:ListItem>
                <asp:ListItem Value="dark">Dark Theme</asp:ListItem>
            </asp:DropDownList>
            <br/>
            Items per page: <asp:DropDownList ID="ddlItemsPerPage" runat="server">
                <asp:ListItem Value="10">10 items</asp:ListItem>
                <asp:ListItem Value="25">25 items</asp:ListItem>
                <asp:ListItem Value="50">50 items</asp:ListItem>
            </asp:DropDownList>
            <br/><br/>
            
            <asp:Button ID="btnSave" runat="server" Text="Save Settings to Cookie" OnClick="btnSave_Click" />
            <asp:Button ID="btnLoad" runat="server" Text="Load Settings from Cookie" OnClick="btnLoad_Click" />
            <asp:Button ID="btnClear" runat="server" Text="Clear Cookie" OnClick="btnClear_Click" />
            <br/><br/>
            
            <asp:Label ID="lblMessage" runat="server" Text=""></asp:Label>
            <br/><br/>
            
            <asp:Button ID="btnBack" runat="server" Text="Back to Main" OnClick="btnBack_Click" />

        </div>
    </form>
</body>
</html>