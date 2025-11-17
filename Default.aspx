<%@ Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="assignment_5._Default" %>

<!DOCTYPE html> 
<html xmlns="http://ww.w3.org/1999/xhtml"> 
    <head runat="server"> 
        <title>Hobby Tracker</title>
        <body> 
            <form id="form2" runat="server">
            <formview id="form1" runat="server"> 
                <div> 
                    <h1>Hobby Tracker</h1>

                    <p>This web application will help users track their hobbies and habits
                        for example playing video games, doing homework, etc. 
                    </p>

                </div>
            </formview>
                <asp:Button ID="btnShowAppStartTime" runat="server" Text="Show Application Start Time" OnClick="btnShowAppStartTime_Click" />
               <br></br>
                <asp:Label ID="lblShowStartTime" runat="server" Text=""></asp:Label>


                <header>Are you a user or a Staff memeber?</header>
                 


                <asp:Button ID="Button1" runat="server" Text="Member" />
                <asp:Button ID="Button2" runat="server" Text="Staff" />

                <br />
                 
            <p> For Staff Members</p>
                <p> This part will be for staff members</p>
                <p> 
                    <asp:Button ID="Button3" runat="server" Text="add user" />
                    <asp:Button ID="Button4" runat="server" Text="change user creditials" />
                </p>
                
                 For Members<br />
                This part will be for members to sign in and to track their habits<br />
                <asp:Button ID="Button5" runat="server" Text="Sign in" />
                <asp:Button ID="Button6" runat="server" Text="Log out" />
                <asp:Button ID="Button7" runat="server" Text="Calender" />
                <asp:Button ID="Button8" runat="server" Text="Add Habit" />
                <br />
                Enter your hobby<br />
                <asp:TextBox ID="TextBox1" runat="server" OnTextChanged="TextBox1_TextChanged"></asp:TextBox>
                <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
                <asp:Button ID="Button9" runat="server" Text="Hobby size" OnClick="Button9_Click" />
                <asp:Label ID="Label2" runat="server" Text="Label"></asp:Label>
                <br />
                
            
                

            </form>
            </body>
    </head>
</html>

   
