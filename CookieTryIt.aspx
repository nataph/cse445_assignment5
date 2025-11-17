<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CookieTryIt.aspx.cs" Inherits="Assignment5.CookieTryIt" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Collection Summary</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>Collection Summary</h1>
            <p>Save your hobby collection overview</p>
            
            <asp:Label ID="lblCurrentSummary" runat="server" Text=""></asp:Label>
            <br /><br />
            
            <h3>Update Collection Summary:</h3>
            Collector Name: <asp:TextBox ID="txtUsername" runat="server"></asp:TextBox>
            <br />
            Recent Purchase: <asp:TextBox ID="txtRecentPurchase" runat="server" placeholder="Rare 1800s Coin"></asp:TextBox>
            <br />
            Total Collection Value: $<asp:TextBox ID="txtTotalValue" runat="server" Text="0"></asp:TextBox>
            <br />
            Number of Items: <asp:TextBox ID="txtItemCount" runat="server" Text="0"></asp:TextBox>
            <br /><br />
            
            <asp:Button ID="btnSave" runat="server" Text="Save Summary" OnClick="btnSave_Click" />
            <asp:Button ID="btnLoad" runat="server" Text="Load Summary" OnClick="btnLoad_Click" />
            <asp:Button ID="btnClear" runat="server" Text="Clear Summary" OnClick="btnClear_Click" />
            <br /><br />
            
            <asp:Label ID="lblMessage" runat="server" Text=""></asp:Label>
            <br /><br />
            
            <asp:Button ID="btnBack" runat="server" Text="Back to Main" OnClick="btnBack_Click" />

        </div>
    </form>
</body>
</html>
