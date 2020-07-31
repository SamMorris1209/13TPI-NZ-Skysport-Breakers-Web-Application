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
        
        string connectionString = @"Data Source = tpisql01.avcol.school.nz; Initial Catalog = SAMUserRegistration; Integrated Security = True;";
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
            if (txtUsername.Text == "" || txtPassword.Text == "")
                Response.Redirect("~/LOGIN.aspx");
            else if (txtPassword.Text != txtConfirmpassword.Text)
                Response.Redirect("~/LOGIN.aspx");
            else
            {
                using (SqlConnection sqlCon = new SqlConnection(connectionString))
                {
                    sqlCon.Open();
                    SqlCommand sqlCmd = new SqlCommand("UserAdd", sqlCon);
                    sqlCmd.CommandType = System.Data.CommandType.StoredProcedure;
                    sqlCmd.Parameters.AddWithValue("@FirstName", txtFirstname.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@LastName", txtLastname.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@Username", txtUsername.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@Password", txtPassword.Text.Trim());
                    sqlCmd.ExecuteNonQuery();
                    Response.Redirect("~/HOMEPAGEIN.aspx");
                    Clear();
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
            SqlDataAdapter sqa = new SqlDataAdapter("Select UserID From tblUser where Username = '" + txtUsernameIn.Text + "' and Password = '" +txtPasswordIn.Text+"'", con);
            System.Data.DataTable dtbl = new System.Data.DataTable();
            sqa.Fill(dtbl);
            if(txtUsernameIn.Text == "Admin" && txtPasswordIn.Text == "Dfghj22x2")
            {
                Response.Redirect("~/ADMINPAGE");
            }
            else if (dtbl.Rows.Count > 0)
                {
                Session["IfSignedIn"] = "true";
                Session["GetUsername"] = txtUsernameIn.Text;
                Response.Redirect("~/HOMEPAGE.aspx");
            }
            else
            {
                Label10.Visible = true;
            }
        }

        protected void txtUsernameIn_TextChanged(object sender, EventArgs e)
        {

        }
    }
}