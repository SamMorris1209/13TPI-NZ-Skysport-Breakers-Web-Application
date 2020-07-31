using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _13TPI_NZ_Skysport_Breakers_Web_Application
{
    public partial class VIDEOS : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if ((string)Session["IfSignedIn"] == "true")
            {
                login_button.Text = "Welcome " + (string)Session["GetUsername"];
                login_button.Enabled = false;
                logout_button.Visible = true;
            }
        }

        protected void Home_Button_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/HOMEPAGE.aspx");
        }

        protected void Players_Button_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/PLAYERS.aspx");
        }

        protected void Schedule_Button_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/SCHEDULE.aspx");
        }

        protected void Tips_Button_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/TIPS-AND-TRICKS.aspx");
        }

        protected void Videos_Button_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/VIDEOS.aspx");
        }
        protected void login_button_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/LOGIN.aspx");
        }

        protected void logout_button_Click(object sender, EventArgs e)
        {
            Session["IfSignedIn"] = "false";
            Response.Redirect("~/LOGIN.aspx");
        }
    }
}