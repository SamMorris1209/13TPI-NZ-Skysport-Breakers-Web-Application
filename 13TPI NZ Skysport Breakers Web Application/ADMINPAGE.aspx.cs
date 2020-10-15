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
    public partial class WebForm2 : System.Web.UI.Page
    {
        string connectionString = @"Data Source = tpisql01.avcol.school.nz; Initial Catalog = SAMUserRegistration; Integrated Security = True;";
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                Clear();
                if (!String.IsNullOrEmpty(Request.QueryString["id"]))
                {
                    int userID = Convert.ToInt32(Request.QueryString["id"]);
                    using (SqlConnection sqlCon = new SqlConnection(connectionString))
                    {
                        sqlCon.Open();
                        SqlDataAdapter sqlDa = new SqlDataAdapter("UserViewByID", sqlCon);
                        sqlDa.SelectCommand.CommandType = CommandType.StoredProcedure;
                        sqlDa.SelectCommand.Parameters.AddWithValue("@UserID", userID);
                        DataTable dtbl = new DataTable();
                        sqlDa.Fill(dtbl);
                        hfUserID.Value = userID.ToString();
                        txtFirstName.Text = dtbl.Rows[0][1].ToString();
                        txtLastName.Text = dtbl.Rows[0][2].ToString();
                        txtUsername.Text = dtbl.Rows[0][3].ToString();
                        txtPassword.Text = dtbl.Rows[0][4].ToString();
                       

                    }
                }
            }
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text == "" || txtPassword.Text == "")
                Response.Redirect("~/ADMINPAGE.aspx");
            else
            {
                using (SqlConnection sqlCon = new SqlConnection(connectionString))
                {
                    sqlCon.Open();
                    SqlCommand sqlCmd = new SqlCommand("UserAddOrEdit", sqlCon);
                    sqlCmd.CommandType = CommandType.StoredProcedure;
                    sqlCmd.Parameters.AddWithValue("@UserID", Convert.ToInt32(hfUserID.Value == "" ? "0" : hfUserID.Value));
                    sqlCmd.Parameters.AddWithValue("@FirstName", txtFirstName.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@LastName", txtLastName.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@Username", txtUsername.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@Password", txtPassword.Text.Trim());
                    sqlCmd.ExecuteNonQuery();
                    Clear();
                    lblSuccessMessage.Text = "submitted successfully";
                }
            }
        }
        void Clear()
        {
            txtFirstName.Text = txtLastName.Text = txtUsername.Text = txtPassword.Text = "";
            hfUserID.Value = "";
        }

        protected void txtGenerate_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/ADMINPAGE.aspx" + "?id=" + txtID.Text);
        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {
            using (SqlConnection sqlCon2 = new SqlConnection(connectionString))
            {
                if (sqlCon2.State == ConnectionState.Closed)
                    sqlCon2.Open();
                SqlCommand sqlCmd = new SqlCommand("UserDeleteByID", sqlCon2);
                sqlCmd.CommandType = CommandType.StoredProcedure;
                sqlCmd.Parameters.AddWithValue("@UserID", Convert.ToInt32(hfUserID.Value));
                sqlCmd.ExecuteNonQuery();
                SqlCommand SqlC = new SqlCommand("DeleteTrackerByID", sqlCon2);
                SqlC.CommandType = CommandType.StoredProcedure;
                SqlC.Parameters.AddWithValue("@UserID", Convert.ToInt32(hfUserID.Value));
                SqlC.ExecuteNonQuery();
                sqlCon2.Close();
                Clear();
                lblSuccessMessage.Text = "Deleted  Successfully";
            }

        }

        protected void btnReturn_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/LOGIN.aspx");
        }
    }
}