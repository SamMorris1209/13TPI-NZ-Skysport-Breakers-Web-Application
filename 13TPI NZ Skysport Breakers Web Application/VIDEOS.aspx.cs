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
                Label2.Visible = true;
                Label1.Visible = true;
                Label3.Visible = true;
                Label4.Visible = true;
                Label5.Visible = true;
                Label6.Visible = true;
                Label7.Visible = true;
                Label8.Visible = true;
                Label9.Visible = true;
                Label10.Visible = true;
                Label11.Visible = true;
                Label12.Visible = true;
                Button3.Visible = false;
            }
        }
        protected void Button3_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/LOGIN.aspx");
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