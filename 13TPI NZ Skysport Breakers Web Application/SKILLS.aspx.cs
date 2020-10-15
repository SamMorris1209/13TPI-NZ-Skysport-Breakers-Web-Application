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
                    UserIDlbl.Text = dtbl.Rows[0][0].ToString();
                }
            using (SqlConnection sqlCon = new SqlConnection(connectionString))
            {
                sqlCon.Open();
                SqlDataAdapter sqlDa = new SqlDataAdapter("GetVideos", sqlCon);
                sqlDa.SelectCommand.CommandType = CommandType.StoredProcedure;
                sqlDa.SelectCommand.Parameters.AddWithValue("@UserID", UserIDlbl.Text.Trim());
                DataTable Vdtbl = new DataTable();
                sqlDa.Fill(Vdtbl);
                Video1Check.Text = Vdtbl.Rows[0][1].ToString();
                Video2Check.Text = Vdtbl.Rows[0][2].ToString();
                Video3Check.Text = Vdtbl.Rows[0][3].ToString();
                Video4Check.Text = Vdtbl.Rows[0][4].ToString();
                Video5Check.Text = Vdtbl.Rows[0][5].ToString();
                Video6Check.Text = Vdtbl.Rows[0][6].ToString();
                Video7Check.Text = Vdtbl.Rows[0][7].ToString();
                Video8Check.Text = Vdtbl.Rows[0][8].ToString();
                Video9Check.Text = Vdtbl.Rows[0][9].ToString();
            }
            SqlConnection con = new SqlConnection(connectionString);
            SqlDataAdapter sqa = new SqlDataAdapter("Select UserID From tblUser where UserID = '" + UserIDlbl.Text + "' and SkillLevel = '" + "Beginner" + "'", con);
            System.Data.DataTable detbl = new System.Data.DataTable();
            sqa.Fill(detbl);
            if (detbl.Rows.Count > 0)
            {
                lblSkillLVL.Visible = false;
                BeginnerContent.Visible = true;
                SqlDataAdapter BPsqa = new SqlDataAdapter("Select Progress From tblUser where UserID = '" + UserIDlbl.Text + "' and Username = '" + Userlbl.Text + "'", con);
                DataTable BPTable = new DataTable();
                BPsqa.Fill(BPTable);
                lblProgress.Text = BPTable.Rows[0][0].ToString() + "/100";
            }
            else
            {
                SqlDataAdapter sqa2 = new SqlDataAdapter("Select UserID From tblUser where UserID = '" + UserIDlbl.Text + "' and SkillLevel = '" + "Intermediate" + "'", con);
                DataTable deetbl = new DataTable();
                sqa2.Fill(deetbl);
                if (deetbl.Rows.Count > 0)
                {
                    lblSkillLVL.Visible = false;
                    IntermediateContent.Visible = true;
                    SqlDataAdapter IPsqa = new SqlDataAdapter("Select Progress From tblUser where UserID = '" + UserIDlbl.Text + "' and Username = '" + Userlbl.Text + "'", con);
                    DataTable IPTable = new DataTable();
                    IPsqa.Fill(IPTable);
                    lblProgress.Text = IPTable.Rows[0][0].ToString() + "/100";
                }
                else
                {
                    SqlDataAdapter sqa3 = new SqlDataAdapter("Select UserID From tblUser where UserID = '" + UserIDlbl.Text + "' and SkillLevel = '" + "Advanced" + "'", con);
                    DataTable deeetbl = new DataTable();
                    sqa3.Fill(deeetbl);
                    if (deeetbl.Rows.Count > 0)
                    {
                        lblSkillLVL.Visible = false;
                        IntermediateContent.Visible = true;
                        AdvancedContent.Visible = true;
                        SqlDataAdapter APsqa = new SqlDataAdapter("Select Progress From tblUser where UserID = '" + UserIDlbl.Text + "' and Username = '" + Userlbl.Text + "'", con);
                        DataTable APTable = new DataTable();
                        APsqa.Fill(APTable);
                        lblProgress.Text = APTable.Rows[0][0].ToString() + " Points Earned";
                    }
                    else
                    {
                        BeginnerContent.Visible = false;
                        AdvancedContent.Visible = false;
                        IntermediateContent.Visible = false;
                    }
                }
            }
            if(Video1Check.Text == "True")
            {
                btnBeginnerDribble.Enabled = false;
                btnBeginnerDribble.Text = "Points gained!";
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
                sqlCmd.Parameters.AddWithValue("@UserID", UserIDlbl.Text.Trim());
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
                sqlCmd.Parameters.AddWithValue("@UserID", UserIDlbl.Text.Trim());
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
                sqlCmd.Parameters.AddWithValue("@UserID", UserIDlbl.Text.Trim());
                sqlCmd.Parameters.AddWithValue("@SkillLevel", "Advanced");
                sqlCmd.ExecuteNonQuery();
                Clear();
                StartProgress();
            }
        }
        protected void btnBeginnerDribble_Click(object sender, EventArgs e)
        {
            Video1Watch();
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
                sqlCmd.Parameters.AddWithValue("@UserID", UserIDlbl.Text.Trim());
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
                sqlCmd.Parameters.AddWithValue("@UserID", UserIDlbl.Text.Trim()); ;
                sqlCmd.ExecuteNonQuery();
                Response.Redirect("~/SKILLS.aspx");

            }
        }
        void Video1Watch()
        {
            using (SqlConnection sqlCon = new SqlConnection(connectionString))
            {
                sqlCon.Open();
                SqlCommand sqlCmd = new SqlCommand("Video1Watch", sqlCon);
                sqlCmd.CommandType = CommandType.StoredProcedure;
                sqlCmd.Parameters.AddWithValue("@UserID", UserIDlbl.Text.Trim()); ;
                sqlCmd.ExecuteNonQuery();
            }
        }
    }
}