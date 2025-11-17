using System;
using System.Web.UI;

namespace HobbyWebApp
{
    public partial class LoginControl : UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            // For A5, we just show that the button works.
            // For A6, we will add code here to check the Member.xml file.
            lblLoginStatus.Text = "Login button clicked! (A6 will validate)";
        }
    }
}