<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SecurityTryIt.aspx.cs" Inherits="Assignment5.SecurityTryIt" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Security DLL TryIt</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>Security DLL TryIt Page</h1>
            <p>Test password</p>
            
            <!-- Password Hashing Test -->
            <h3>1. Password Hashing</h3>
            <asp:TextBox ID="txtPassword" runat="server" placeholder="Enter password to hash"></asp:TextBox>
            <asp:Button ID="btnHash" runat="server" Text="Hash Password" OnClick="btnHash_Click" />
            <br />
            <asp:Label ID="lblHashResult" runat="server" Text=""></asp:Label>
            <br/><br/>
            
            <!-- Encryption Test -->
            <h3>2. Encryption/Decryption</h3>
            Text to encrypt: <asp:TextBox ID="txtTextToEncrypt" runat="server" Width="200"></asp:TextBox>
            <br/>
            Encryption key: <asp:TextBox ID="txtEncryptionKey" runat="server" Width="200"></asp:TextBox>
            <br/>
            <asp:Button ID="btnEncrypt" runat="server" Text="Encrypt" OnClick="btnEncrypt_Click" />
            <asp:Button ID="btnDecrypt" runat="server" Text="Decrypt" OnClick="btnDecrypt_Click" />
            <br/>
            <asp:Label ID="lblEncryptResult" runat="server" Text=""></asp:Label>
            <br/><br/>
            
            <!-- Quick Tests -->
            <h3>3. Quick Tests</h3>
            <asp:Button ID="btnQuickTest" runat="server" Text="Run All Quick Tests" OnClick="btnQuickTest_Click" />
            <br/>
            <asp:Label ID="lblQuickTestResult" runat="server" Text=""></asp:Label>
            <br/><br/>
            
            <asp:Button ID="btnBack" runat="server" Text="Back to Main" OnClick="btnBack_Click" />

        </div>
    </form>
</body>
</html>