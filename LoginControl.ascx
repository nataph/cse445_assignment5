<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="LoginControl.ascx.cs" Inherits="HobbyWebApp.LoginControl" %>

<%-- This is a self-contained Login User Control --%>
<div style="border: 1px solid #ccc; padding: 10px; width: 300px; background-color: #f9f9f9;">
    <h3>Member Login</h3>
    
    <label for="txtUsername">Username:</label><br />
    <asp:TextBox ID="txtUsername" runat="server" Width="280px"></asp:TextBox><br /><br />
    
    <label for="txtPassword">Password:</label><br />
    <asp:TextBox ID="txtPassword" runat="server" TextMode="Password" Width="280px"></asp:TextBox><br /><br />
    
    <asp:Button ID="btnLogin" runat="server" Text="Login" OnClick="btnLogin_Click" /><br /><br />
    
    <asp:Label ID="lblLoginStatus" runat="server" ForeColor="Red"></asp:Label>
</div>