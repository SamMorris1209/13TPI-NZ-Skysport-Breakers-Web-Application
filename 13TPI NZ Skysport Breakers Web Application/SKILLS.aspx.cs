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
            Userlbl.Text = (string)Session["GetUsername"];
            Passlbl.Text = (string)Session["GetPassword"];
            using (SqlConnection sqlCon = new SqlConnection(connectionString))
            {
                sqlCon.Open();
                SqlDataAdapter sqlDa = new SqlDataAdapter("GetUserID", sqlCon);
                sqlDa.SelectCommand.CommandType = CommandType.StoredProcedure;
                sqlDa.SelectCommand.Parameters.AddWithValue("@Username", Userlbl.Text);
                sqlDa.SelectCommand.Parameters.AddWithValue("@Password", Passlbl.Text);
                DataTable dtbl = new DataTable();
                sqlDa.Fill(dtbl);
                testlbl.Text = dtbl.Rows[0][0].ToString();
            }
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
            using (SqlConnection sqlCon = new SqlConnection(connectionString))
            {
                sqlCon.Open();
                SqlCommand sqlCmd = new SqlCommand("SkillLevelAdd", sqlCon);
                sqlCmd.CommandType = CommandType.StoredProcedure;
                sqlCmd.Parameters.AddWithValue("@UserID", testlbl.Text.Trim());
                sqlCmd.Parameters.AddWithValue("@SkillLevel", "Beginner");
                sqlCmd.ExecuteNonQuery();
                Clear();
            }
        }
        protected void btnIntermediate_Click(object sender, EventArgs e)
        {

            lblSkillLVL.Visible = false;
            IntermediateContent.Visible = true;
            using (SqlConnection sqlCon = new SqlConnection(connectionString))
            {
                sqlCon.Open();
                SqlCommand sqlCmd = new SqlCommand("SkillLevelAdd", sqlCon);
                sqlCmd.CommandType = CommandType.StoredProcedure;
                sqlCmd.Parameters.AddWithValue("@UserID", testlbl.Text.Trim());
                sqlCmd.Parameters.AddWithValue("@SkillLevel", "Intermediate");
                sqlCmd.ExecuteNonQuery();
                Clear();
            }
        }

        protected void btnAdvanced_Click(object sender, EventArgs e)
        {
            lblSkillLVL.Visible = false;
            AdvancedContent.Visible = true;
            using (SqlConnection sqlCon = new SqlConnection(connectionString))
            {
                sqlCon.Open();
                SqlCommand sqlCmd = new SqlCommand("SkillLevelAdd", sqlCon);
                sqlCmd.CommandType = CommandType.StoredProcedure;
                sqlCmd.Parameters.AddWithValue("@UserID", testlbl.Text.Trim());
                sqlCmd.Parameters.AddWithValue("@SkillLevel", "Advanced");
                sqlCmd.ExecuteNonQuery();
                Clear();
            }
        }
        protected void btnBeginnerDribble_Click(object sender, EventArgs e)
        {

        }
        void Clear()
        {
            hfUserID.Value = "";        
        }

    }
}