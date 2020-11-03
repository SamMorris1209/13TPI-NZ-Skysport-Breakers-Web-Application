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
                    SqlDataAdapter sqlDa = new SqlDataAdapter("GetUserID", sqlCon); //runs GetUserID query which gets the userID for the currently logged user
                    sqlDa.SelectCommand.CommandType = CommandType.StoredProcedure;
                    sqlDa.SelectCommand.Parameters.AddWithValue("@Username", Userlbl.Text);
                    sqlDa.SelectCommand.Parameters.AddWithValue("@Password", Passlbl.Text); //uses above parameters to find this ID
                    DataTable dtbl = new DataTable();
                    sqlDa.Fill(dtbl);
                    UserIDlbl.Text = dtbl.Rows[0][0].ToString();
                    lblLevel.Text = dtbl.Rows[0][5].ToString(); //puts UserID in a label and skill level into another label from the logged user
                    
                }
            using (SqlConnection sqlCon = new SqlConnection(connectionString))
            {
                sqlCon.Open();
                SqlDataAdapter sqlDa = new SqlDataAdapter("GetVideos", sqlCon); //similar query to getuserid but gets the bit values of each video to see if watched
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
                Video9Check.Text = Vdtbl.Rows[0][9].ToString(); //puts each value into its respective label
            }
            using (SqlConnection sqlCon = new SqlConnection(connectionString))
            {
                sqlCon.Open();
                SqlDataAdapter sqlDa = new SqlDataAdapter("GetTasks", sqlCon); //same as getvideos but for the tasks
                sqlDa.SelectCommand.CommandType = CommandType.StoredProcedure;
                sqlDa.SelectCommand.Parameters.AddWithValue("@UserID", UserIDlbl.Text.Trim());
                DataTable Tdtbl = new DataTable();
                sqlDa.Fill(Tdtbl);
                RulesCheck.Text = Tdtbl.Rows[0][1].ToString();
                ThreePointersCheck.Text = Tdtbl.Rows[0][2].ToString();
                Task1Check.Text = Tdtbl.Rows[0][3].ToString();
                Task2Check.Text = Tdtbl.Rows[0][4].ToString();
                Task3Check.Text = Tdtbl.Rows[0][5].ToString();
                Task4Check.Text = Tdtbl.Rows[0][6].ToString(); //puts each value into its respective label
            }
            SqlConnection con = new SqlConnection(connectionString);
            SqlDataAdapter sqa = new SqlDataAdapter("Select UserID From tblUser where UserID = '" + UserIDlbl.Text + "' and SkillLevel = '" + "Beginner" + "'", con);
            //runs through the sql to find if the logged user is a beginner
            System.Data.DataTable detbl = new System.Data.DataTable();
            sqa.Fill(detbl);
            if (detbl.Rows.Count > 0) // if they are a beginner
            {
                lblSkillLVL.Visible = false;
                BeginnerContent.Visible = true;
                IntermediateContent.Visible = false;
                AdvancedContent.Visible = false;
                SqlDataAdapter BPsqa = new SqlDataAdapter("Select Progress From tblUser where UserID = '" + UserIDlbl.Text + "' and Username = '" + Userlbl.Text + "'", con);
                ///gets their current progress
                DataTable BPTable = new DataTable();
                BPsqa.Fill(BPTable);
                lblProgress.Text = BPTable.Rows[0][0].ToString() + "/100";
            }
            else
            {
                SqlDataAdapter sqa2 = new SqlDataAdapter("Select UserID From tblUser where UserID = '" + UserIDlbl.Text + "' and SkillLevel = '" + "Intermediate" + "'", con);
                //finds if the logged user is intermediate
                DataTable deetbl = new DataTable();
                sqa2.Fill(deetbl);
                if (deetbl.Rows.Count > 0)
                {
                    lblSkillLVL.Visible = false;
                    IntermediateContent.Visible = true;
                    AdvancedContent.Visible = false;
                    SqlDataAdapter IPsqa = new SqlDataAdapter("Select Progress From tblUser where UserID = '" + UserIDlbl.Text + "' and Username = '" + Userlbl.Text + "'", con);
                    DataTable IPTable = new DataTable();
                    IPsqa.Fill(IPTable);
                    lblProgress.Text = IPTable.Rows[0][0].ToString() + "/100";
                }
                else
                {
                    SqlDataAdapter sqa3 = new SqlDataAdapter("Select UserID From tblUser where UserID = '" + UserIDlbl.Text + "' and SkillLevel = '" + "Advanced" + "'", con);
                    //finds if logged user is advanced
                    DataTable deeetbl = new DataTable();
                    sqa3.Fill(deeetbl);
                    if (deeetbl.Rows.Count > 0)
                    {
                        lblSkillLVL.Visible = false;
                        BeginnerContent.Visible = true;
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
            if(lblProgress.Text == "100/100")
            {
                UpgradeAdvanced();
                UpgradeIntermediate();
                ResetProgress();
            }
            if(Video1Check.Text == "True")
            {
                btnBeginnerDribble.Enabled = false;
                btnBeginnerDribble.Text = "Points Gained!";
            }
            if(Video2Check.Text == "True")
            {
                btnBeginnerPassing.Enabled = false;
                btnBeginnerPassing.Text = "Points Gained!";
            }
            if (Video3Check.Text == "True")
            {
                btnBeginnerShooting.Enabled = false;
                btnBeginnerShooting.Text = "Points Gained!";
            }
            if (Video4Check.Text == "True")
            {
                btnIntermediatePositioning.Enabled = false;
                btnIntermediatePositioning.Text = "Points Gained!";
            }
            if (Video5Check.Text == "True")
            {
                btnIntermediateTricks.Enabled = false;
                btnIntermediateTricks.Text = "Points Gained!";
            }
            if (Video6Check.Text == "True")
            {
                btnIntermediateHandlng.Enabled = false;
                btnIntermediateHandlng.Text = "Points Gained!";
            }
            if (Video7Check.Text == "True")
            {
                btnDunking.Enabled = false;
                btnDunking.Text = "Points Gained!";
            }
            if (Video8Check.Text == "True")
            {
                btnADribbling.Enabled = false;
                btnADribbling.Text = "Points Gained!";
            }
            if (Video9Check.Text == "True")
            {
                btnAPositioning.Enabled = false;
                btnAPositioning.Text = "Points Gained!";
            }
            if (RulesCheck.Text == "True")
            {
                btnRules.Enabled = false;
                btnRules.Text = "Points Gained!";
            }
            if (ThreePointersCheck.Text == "True")
            {
                btn3Pointers.Enabled = false;
                btn3Pointers.Text = "Points Gained!"; //above if statements display labels depending on if the videos are watched - if watched, they become disabled
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
        //above 3 queries initally add a user as their decided skill level
        protected void btnBeginnerDribble_Click(object sender, EventArgs e)
        {
            Video1Watch();
            IncrementProgress();
        }
        protected void btnBeginnerPassing_Click(object sender, EventArgs e)
        {
            Video2Watch();
            IncrementProgress();
        }
        protected void btnBeginnerShooting_Click(object sender, EventArgs e)
        {
            Video3Watch();
            IncrementProgress();
        }
        protected void btnIntermediatePositioning_Click(object sender, EventArgs e)
        {
            Video4Watch();
            IncrementProgressMORE();
        }
        protected void btnIntermediateTricks_Click(object sender, EventArgs e)
        {
            Video5Watch();
            IncrementProgress();
        }
        protected void btnIntermediateHandling_Click(object sender, EventArgs e)
        {
            Video6Watch();
            IncrementProgressMORE();
        }
        protected void btn3Pointers_Click(object sender, EventArgs e)
        {
            ThreePointersWatch();
            IncrementProgress();
        }
        protected void btnRules_Click(object sender, EventArgs e)
        {
            ReadRules();
            IncrementProgressMOST();
        }
        protected void btnDunking_Click(object sender, EventArgs e)
        {
            Video7Watch();
            IncrementProgressMOST();
        }
        protected void btnADribbling_Click(object sender, EventArgs e)
        {
            Video8Watch();
            IncrementProgressMOST();
        }
        protected void btnAPositioning_Click(object sender, EventArgs e)
        {
            Video9Watch();
            IncrementProgressMOST();
        }
        protected void btnThreePointerP_Click(object sender, EventArgs e)
        {
            IncrementProgressNoRedirect();
            btnThreePointerP.Enabled = false;
            btnThreePointerP.Text = "Come back later to do this again!";
        }
        protected void btnAPassing_Click(object sender, EventArgs e)
        {
            IncrementProgressNoRedirect();
            btnAPassing.Enabled = false;
            btnAPassing.Text = "Come back later to do this again!";
        }
        protected void btnBlocking_Click(object sender, EventArgs e)
        {
            IncrementProgressNoRedirect();
            btnBlocking.Enabled = false;
            btnBlocking.Text = "Come back later to do this again!";
        }
        //above button clicks make it so they cannot click it again and they get the points from it by calling on voids
        void Clear()
        {
            hfUserID.Value = "";        
        }
        void StartProgress() //void to initally set progress
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
        void IncrementProgress() //void to make the progress increase by 20
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
        void IncrementProgressNoRedirect() //increase progress by 20 without refreshing  the page
        {
            using (SqlConnection sqlCon = new SqlConnection(connectionString))
            {
                sqlCon.Open();
                SqlCommand sqlCmd = new SqlCommand("GetProgress", sqlCon);
                sqlCmd.CommandType = CommandType.StoredProcedure;
                sqlCmd.Parameters.AddWithValue("@UserID", UserIDlbl.Text.Trim()); ;
                sqlCmd.ExecuteNonQuery();

            }
        }
        void UpgradeIntermediate()
        {
            using (SqlConnection sqlCon = new SqlConnection(connectionString))
            {
                sqlCon.Open();
                SqlCommand sqlCmd = new SqlCommand("UpgradeIntermediate", sqlCon);
                sqlCmd.CommandType = CommandType.StoredProcedure;
                sqlCmd.Parameters.AddWithValue("@UserID", UserIDlbl.Text.Trim()); ;
                sqlCmd.Parameters.AddWithValue("@SkillLevel", lblLevel.Text.Trim());
                sqlCmd.ExecuteNonQuery();

            }
        }
        void UpgradeAdvanced()
        {
            using (SqlConnection sqlCon = new SqlConnection(connectionString))
            {
                sqlCon.Open();
                SqlCommand sqlCmd = new SqlCommand("UpgradeAdvanced", sqlCon);
                sqlCmd.CommandType = CommandType.StoredProcedure;
                sqlCmd.Parameters.AddWithValue("@UserID", UserIDlbl.Text.Trim()); ;
                sqlCmd.Parameters.AddWithValue("@SkillLevel", lblLevel.Text.Trim());
                sqlCmd.ExecuteNonQuery();

            }
        }
        //Previous 2 voids are used to uprage the user's level
            void ResetProgress() //sets progress to 0 after leveling up
            {
                using (SqlConnection sqlCon = new SqlConnection(connectionString))
                {
                    sqlCon.Open();
                    SqlCommand sqlCmd = new SqlCommand("ResetProgress", sqlCon);
                    sqlCmd.CommandType = CommandType.StoredProcedure;
                    sqlCmd.Parameters.AddWithValue("@UserID", UserIDlbl.Text.Trim()); ;
                    sqlCmd.ExecuteNonQuery();
                    Response.Redirect("~/SKILLS.aspx");

                }
            }
        void IncrementProgressMORE() //adds 30 progress
        {
            using (SqlConnection sqlCon = new SqlConnection(connectionString))
            {
                sqlCon.Open();
                SqlCommand sqlCmd = new SqlCommand("GetProgressMORE", sqlCon);
                sqlCmd.CommandType = CommandType.StoredProcedure;
                sqlCmd.Parameters.AddWithValue("@UserID", UserIDlbl.Text.Trim()); ;
                sqlCmd.ExecuteNonQuery();
                Response.Redirect("~/SKILLS.aspx");

            }
        }
        void IncrementProgressMOST() //adds 40 progress
        {
            using (SqlConnection sqlCon = new SqlConnection(connectionString))
            {
                sqlCon.Open();
                SqlCommand sqlCmd = new SqlCommand("GetProgressMOST", sqlCon);
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
        void Video2Watch()
        {
            using (SqlConnection sqlCon = new SqlConnection(connectionString))
            {
                sqlCon.Open();
                SqlCommand sqlCmd = new SqlCommand("Video2Watch", sqlCon);
                sqlCmd.CommandType = CommandType.StoredProcedure;
                sqlCmd.Parameters.AddWithValue("@UserID", UserIDlbl.Text.Trim()); ;
                sqlCmd.ExecuteNonQuery();
            }
        }
        void Video3Watch()
        {
            using (SqlConnection sqlCon = new SqlConnection(connectionString))
            {
                sqlCon.Open();
                SqlCommand sqlCmd = new SqlCommand("Video3Watch", sqlCon);
                sqlCmd.CommandType = CommandType.StoredProcedure;
                sqlCmd.Parameters.AddWithValue("@UserID", UserIDlbl.Text.Trim()); ;
                sqlCmd.ExecuteNonQuery();
            }
        }
        void Video4Watch()
        {
            using (SqlConnection sqlCon = new SqlConnection(connectionString))
            {
                sqlCon.Open();
                SqlCommand sqlCmd = new SqlCommand("Video4Watch", sqlCon);
                sqlCmd.CommandType = CommandType.StoredProcedure;
                sqlCmd.Parameters.AddWithValue("@UserID", UserIDlbl.Text.Trim()); ;
                sqlCmd.ExecuteNonQuery();
            }
        }
        void Video5Watch()
        {
            using (SqlConnection sqlCon = new SqlConnection(connectionString))
            {
                sqlCon.Open();
                SqlCommand sqlCmd = new SqlCommand("Video5Watch", sqlCon);
                sqlCmd.CommandType = CommandType.StoredProcedure;
                sqlCmd.Parameters.AddWithValue("@UserID", UserIDlbl.Text.Trim()); ;
                sqlCmd.ExecuteNonQuery();
            }
        }
        void Video6Watch()
        {
            using (SqlConnection sqlCon = new SqlConnection(connectionString))
            {
                sqlCon.Open();
                SqlCommand sqlCmd = new SqlCommand("Video6Watch", sqlCon);
                sqlCmd.CommandType = CommandType.StoredProcedure;
                sqlCmd.Parameters.AddWithValue("@UserID", UserIDlbl.Text.Trim()); ;
                sqlCmd.ExecuteNonQuery();
            }
        }
        void Video7Watch()
        {
            using (SqlConnection sqlCon = new SqlConnection(connectionString))
            {
                sqlCon.Open();
                SqlCommand sqlCmd = new SqlCommand("Video7Watch", sqlCon);
                sqlCmd.CommandType = CommandType.StoredProcedure;
                sqlCmd.Parameters.AddWithValue("@UserID", UserIDlbl.Text.Trim()); ;
                sqlCmd.ExecuteNonQuery();
            }
        }
        void Video8Watch()
        {
            using (SqlConnection sqlCon = new SqlConnection(connectionString))
            {
                sqlCon.Open();
                SqlCommand sqlCmd = new SqlCommand("Video8Watch", sqlCon);
                sqlCmd.CommandType = CommandType.StoredProcedure;
                sqlCmd.Parameters.AddWithValue("@UserID", UserIDlbl.Text.Trim()); ;
                sqlCmd.ExecuteNonQuery();
            }
        }
        void Video9Watch()
        {
            using (SqlConnection sqlCon = new SqlConnection(connectionString))
            {
                sqlCon.Open();
                SqlCommand sqlCmd = new SqlCommand("Video9Watch", sqlCon);
                sqlCmd.CommandType = CommandType.StoredProcedure;
                sqlCmd.Parameters.AddWithValue("@UserID", UserIDlbl.Text.Trim()); ;
                sqlCmd.ExecuteNonQuery();
            }
        }
        void ReadRules()
        {
            using (SqlConnection sqlCon = new SqlConnection(connectionString))
            {
                sqlCon.Open();
                SqlCommand sqlCmd = new SqlCommand("RulesWatch", sqlCon);
                sqlCmd.CommandType = CommandType.StoredProcedure;
                sqlCmd.Parameters.AddWithValue("@UserID", UserIDlbl.Text.Trim()); ;
                sqlCmd.ExecuteNonQuery();
            }
        }
        void ThreePointersWatch()
        {
            using (SqlConnection sqlCon = new SqlConnection(connectionString))
            {
                sqlCon.Open();
                SqlCommand sqlCmd = new SqlCommand("ThreePointersWatch", sqlCon);
                sqlCmd.CommandType = CommandType.StoredProcedure;
                sqlCmd.Parameters.AddWithValue("@UserID", UserIDlbl.Text.Trim()); ;
                sqlCmd.ExecuteNonQuery();
            }
        }
    }//all above voids set each video/task to 1 so they cannot watch it again
}