using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

namespace _13TPI_NZ_Skysport_Breakers_Web_Application
{
    public partial class SKILLS : System.Web.UI.Page
    {
        string connectionString = @"Data Source = tpisql01.avcol.school.nz; Initial Catalog = SAMUserRegistration; Integrated Security = True;";
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Back_Button_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/TIPS-AND-TRICKS.aspx");
        }

        protected void Home_Button_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/HOMEPAGE.aspx");
        }

        protected void btnBeginner_Click(object sender, EventArgs e)
        {
            lblSkillLVL.Visible = false;
            BeginnerContent.Visible = true;
        }
        protected void btnIntermediate_Click(object sender, EventArgs e)
        {
            lblSkillLVL.Visible = false;
            IntermediateContent.Visible = true;
        }

        protected void btnAdvanced_Click(object sender, EventArgs e)
        {
            lblSkillLVL.Visible = false;
            AdvancedContent.Visible = true;
        }
        protected void btnBeginnerDribble_Click(object sender, EventArgs e)
        {

        }
    }
}