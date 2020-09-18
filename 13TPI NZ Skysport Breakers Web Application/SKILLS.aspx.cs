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
            SqlConnection con = new SqlConnection(connectionString);
            SqlDataAdapter sqa = new SqlDataAdapter("Select UserID From tblUser where UserID = '" + testlbl.Text + "' and SkillLevel = '" + "Beginner" + "'", con);
            System.Data.DataTable detbl = new System.Data.DataTable();
            sqa.Fill(detbl);
            if (detbl.Rows.Count > 0)
            {
                lblSkillLVL.Visible = false;
                BeginnerContent.Visible = true;
                SqlDataAdapter BPsqa = new SqlDataAdapter("Select Progress From tblUser where UserID = '" + testlbl.Text + "' and Username = '" + Userlbl.Text + "'", con);
                DataTable BPTable = new DataTable();
                BPsqa.Fill(BPTable);
                lblProgress.Text = BPTable.Rows[0][0].ToString() + "/100";
            }
            else
            {
                SqlDataAdapter sqa2 = new SqlDataAdapter("Select UserID From tblUser where UserID = '" + testlbl.Text + "' and SkillLevel = '" + "Intermediate" + "'", con);
                DataTable deetbl = new DataTable();
                sqa2.Fill(deetbl);
                if (deetbl.Rows.Count > 0)
                {
                    lblSkillLVL.Visible = false;
                    IntermediateContent.Visible = true;
                    SqlDataAdapter IPsqa = new SqlDataAdapter("Select Progress From tblUser where UserID = '" + testlbl.Text + "' and Username = '" + Userlbl.Text + "'", con);
                    DataTable IPTable = new DataTable();
                    IPsqa.Fill(IPTable);
                    lblProgress.Text = IPTable.Rows[0][0].ToString() + "/100";
                }
                else
                {
                    SqlDataAdapter sqa3 = new SqlDataAdapter("Select UserID From tblUser where UserID = '" + testlbl.Text + "' and SkillLevel = '" + "Advanced" + "'", con);
                    DataTable deeetbl = new DataTable();
                    sqa3.Fill(deeetbl);
                    if (deeetbl.Rows.Count > 0)
                    {
                        lblSkillLVL.Visible = false;
                        AdvancedContent.Visible = true;
                        SqlDataAdapter APsqa = new SqlDataAdapter("Select Progress From tblUser where UserID = '" + testlbl.Text + "' and Username = '" + Userlbl.Text + "'", con);
                        DataTable APTable = new DataTable();
                        APsqa.Fill(APTable);
                        lblProgress.Text = APTable.Rows[0][0].ToString() + "/100";
                    }
                    else
                    {
                        BeginnerContent.Visible = false;
                        AdvancedContent.Visible = false;
                        IntermediateContent.Visible = false;
                    }
                }
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
                StartProgress();
            }
        }
        protected void btnIntermediate_Click(object sender, EventArgs e)
        {
            using (SqlConnection sqlCon = new SqlConnection(connectionString))
            {
                sqlCon.Open();
                SqlCommand sqlCmd = new SqlCommand("SkillLevelAdd", sqlCon);
                sqlCmd.CommandType = CommandType.StoredProcedure;
                sqlCmd.Parameters.AddWithValue("@UserID", testlbl.Text.Trim());
                sqlCmd.Parameters.AddWithValue("@SkillLevel", "Intermediate");
                sqlCmd.ExecuteNonQuery();
                Clear();
                StartProgress();
            }
        }

        protected void btnAdvanced_Click(object sender, EventArgs e)
        {
            using (SqlConnection sqlCon = new SqlConnection(connectionString))
            {
                sqlCon.Open();
                SqlCommand sqlCmd = new SqlCommand("SkillLevelAdd", sqlCon);
                sqlCmd.CommandType = CommandType.StoredProcedure;
                sqlCmd.Parameters.AddWithValue("@UserID", testlbl.Text.Trim());
                sqlCmd.Parameters.AddWithValue("@SkillLevel", "Advanced");
                sqlCmd.ExecuteNonQuery();
                Clear();
                StartProgress();
            }
        }
        protected void btnBeginnerDribble_Click(object sender, EventArgs e)
        {
            IncrementProgress();
        }
                void Clear()
        {
            hfUserID.Value = "";        
        }
        void StartProgress()
        {
            using (SqlConnection sqlCon = new SqlConnection(connectionString))
            {
                sqlCon.Open();
                SqlCommand sqlCmd = new SqlCommand("StartProgress", sqlCon);
                sqlCmd.CommandType = CommandType.StoredProcedure;
                sqlCmd.Parameters.AddWithValue("@UserID", testlbl.Text.Trim());
                sqlCmd.Parameters.AddWithValue("@Progress", "0");
                sqlCmd.ExecuteNonQuery();
                Clear();
            }
            Response.Redirect("~/SKILLS.aspx");
        }
        void IncrementProgress()
        {
            using (SqlConnection sqlCon = new SqlConnection(connectionString))
            {
                sqlCon.Open();
                SqlCommand sqlCmd = new SqlCommand("GetProgress", sqlCon);
                sqlCmd.CommandType = CommandType.StoredProcedure;
                sqlCmd.Parameters.AddWithValue("@UserID", testlbl.Text.Trim()); ;
                sqlCmd.ExecuteNonQuery();
                Response.Redirect("~/SKILLS.aspx");
            }
        }
    }
}