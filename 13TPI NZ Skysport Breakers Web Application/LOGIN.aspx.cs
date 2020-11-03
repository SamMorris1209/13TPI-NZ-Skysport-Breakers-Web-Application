using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace _13TPI_NZ_Skysport_Breakers_Web_Application
{
    public partial class LOGIN : System.Web.UI.Page
    {
        
        string connectionString = @"Data Source = tpisql01.avcol.school.nz; Initial Catalog = SAMUserRegistration; Integrated Security = True;"; //Sets variable for the connection to the database so I dont have to type it in every time
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void HomeLogo_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/HOMEPAGE.aspx");
        }

        protected void HomeLogo_Click1(object sender, EventArgs e)
        {

        }

        protected void btnSignUp_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text == "" || txtPassword.Text == "") //checks if any fields in the sing up boxes are empty
                Response.Redirect("~/LOGIN.aspx"); //refreshes the page if this is true
            else if (txtPassword.Text != txtConfirmpassword.Text) //checks if the passwords match
                Response.Redirect("~/LOGIN.aspx");
            else if(txtPassword.Text.Length < 6)
            {
                Label12.Visible = true;
            }
            else
            {
                using (SqlConnection sqlCon = new SqlConnection(connectionString)) //establishes connection with the SQL Database via string defined above
                {
                    sqlCon.Open();
                    SqlCommand sqlCmd = new SqlCommand("UserAdd", sqlCon); //runs SQL Query UserAdd from the database which adds your account to the database
                    sqlCmd.CommandType = System.Data.CommandType.StoredProcedure;
                    sqlCmd.Parameters.AddWithValue("@FirstName", txtFirstname.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@LastName", txtLastname.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@Username", txtUsername.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@Password", txtPassword.Text.Trim()); //Last 4 lines inputs values for variables needed in the SQL query.
                    sqlCmd.ExecuteNonQuery();
                    SignupMessage.Visible = true; //confirms you have signed up
                    Clear(); //clears text boxes
                }
                using (SqlConnection sqlCon = new SqlConnection(connectionString))
                {
                    sqlCon.Open();
                    SqlCommand sqlCmd = new SqlCommand("TrackingUserAdd", sqlCon);  //runs SQL Query TrackingUserAdd which keeps track of the videos youve watched in the app
                    sqlCmd.CommandType = System.Data.CommandType.StoredProcedure;
                    sqlCmd.Parameters.AddWithValue("@Video1", "0");
                    sqlCmd.Parameters.AddWithValue("@Video2", "0");
                    sqlCmd.Parameters.AddWithValue("@Video3", "0");
                    sqlCmd.Parameters.AddWithValue("@Video4", "0");
                    sqlCmd.Parameters.AddWithValue("@Video5", "0");
                    sqlCmd.Parameters.AddWithValue("@Video6", "0");
                    sqlCmd.Parameters.AddWithValue("@Video7", "0");
                    sqlCmd.Parameters.AddWithValue("@Video8", "0");
                    sqlCmd.Parameters.AddWithValue("@Video9", "0"); //sets the bit values of each video to 0 (not yet watched)
                    sqlCmd.ExecuteNonQuery();
                }
                using (SqlConnection sqlCon = new SqlConnection(connectionString))
                {
                    sqlCon.Open();
                    SqlCommand sqlCmd = new SqlCommand("TaskTrackingUserAdd", sqlCon); //runs SQL Query TaskTrackingUserAdd which tracks tasks you have done on the app
                    sqlCmd.CommandType = System.Data.CommandType.StoredProcedure;
                    sqlCmd.Parameters.AddWithValue("@Rules", "0");
                    sqlCmd.Parameters.AddWithValue("@ThreePointers", "0");
                    sqlCmd.Parameters.AddWithValue("@Task1", "0");
                    sqlCmd.Parameters.AddWithValue("@Task2", "0");
                    sqlCmd.Parameters.AddWithValue("@Task3", "0");
                    sqlCmd.Parameters.AddWithValue("@Task4", "0"); //sets each task to 0 (not watched)
                    sqlCmd.ExecuteNonQuery();
                }
            }
        }
        void Clear()
        {
            txtFirstname.Text = txtLastname.Text = txtPassword.Text = txtUsername.Text = txtConfirmpassword.Text = "";
        }

        protected void btnSignIn_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(connectionString);
            SqlDataAdapter sqa = new SqlDataAdapter("Select UserID From tblUser where Username = '" + txtUsernameIn.Text + "' and Password = '" +txtPasswordIn.Text+"'", con); //checks if there is a user in the database with this username and password
            System.Data.DataTable dtbl = new System.Data.DataTable();
            sqa.Fill(dtbl); //fills a datatable depending on parameters defined from c# LINQ query
            if(txtUsernameIn.Text == "Admin" && txtPasswordIn.Text == "Dfghj22x2") //checks if account logging in is the admin
            {
                Response.Redirect("~/ADMINPAGE"); //takes you to the admin page instead of the home page
            }
            else if (dtbl.Rows.Count > 0) //checks if a row was filled with the parameters (user with the inputted username and password)
                {
                Session["IfSignedIn"] = "true";
                Session["GetUsername"] = txtUsernameIn.Text;
                Session["GetPassword"] = txtPasswordIn.Text; //sets session variables (which can be used across webforms) for different things
                Response.Redirect("~/HOMEPAGE.aspx");
            }
            else
            {
                Label10.Visible = true; //says the user doesnt exist
            }
        }

        protected void txtUsernameIn_TextChanged(object sender, EventArgs e)
        {

        }
    }
}