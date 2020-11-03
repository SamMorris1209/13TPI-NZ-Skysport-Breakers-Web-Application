using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _13TPI_NZ_Skysport_Breakers_Web_Application
{
    public partial class TIPS_AND_TRICKS : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if ((string)Session["IfSignedIn"] == "true") //checks if the user is signed in and displays different information on the navbar if they are
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

        protected void skills_button_Click(object sender, EventArgs e)
        {
            if ((string)Session["IfSignedIn"] != "true") //button to get into the application, only lets you in if you are signed in
            {
                lblErrorMsg.Visible = true;
            }
            else
            {
                Response.Redirect("~/SKILLS.aspx");
            }
        }
    }
}