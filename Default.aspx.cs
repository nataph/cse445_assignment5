using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace assignment_5
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnShowAppStartTime_Click(object sender, EventArgs e)
        {
            lblShowStartTime.Text = "Application Started at:" + Application["AppStartTime"]; 
        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {
            Label1.Text = TextBox1.Text;
            Label1.Text = "Hobby Saved!"; 
        }

        protected void Button9_Click(object sender, EventArgs e)
        {
            HobbyServiceReference.IHobbyService checkHobby = new HobbyServiceReference.HobbyServiceClient(); 
            Label2.Text = checkHobby.WordCharacters(TextBox1.Text).ToString();  //This is make the service check but this will tell the user if the password is short or long
        }
    }
}