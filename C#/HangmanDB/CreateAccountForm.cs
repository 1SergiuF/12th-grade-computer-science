using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace HangmanDB
{
    public partial class CreateAccountForm : Form
    {
        public CreateAccountForm()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnCreateAccount_Click(object sender, EventArgs e)
        {
            string userName = tbUsernameCreate.Text;
            string password = tbPasswordCreate.Text;
            string confirmPassword = tbConfirmPassword.Text;

            if (userName == "" || password == "" || confirmPassword == "")
            {
                MessageBox.Show("Must fill all fields !");
                ClearTBs();
                return;
            }

            if (password != confirmPassword)
            {
                MessageBox.Show("The confirmation does not match with the password !");
                ClearTBs();
                return;
            }

            if (!UserNameValid(userName))
            {
                MessageBox.Show("Invalid username !");
                ClearTBs();
                return;
            }

            InsertAccount(userName, password, 0, 0);
            this.Close();
        }

        private void InsertAccount(string userName, string password, int highScore, int coins)
        {
            var conn = new SqlConnection(LoginForm.connStr);
            conn.Open();
            string query = "INSERT INTO Player VALUES(@userName, @password, @highScore, @coins)";

            var cmd = new SqlCommand(query, conn);

            cmd.Parameters.AddWithValue("@userName", userName);
            cmd.Parameters.AddWithValue("@password", password);
            cmd.Parameters.AddWithValue("@highScore", highScore);
            cmd.Parameters.AddWithValue("@coins", coins);

            cmd.ExecuteNonQuery();

            conn.Close();
            conn.Dispose();
            cmd.Dispose();
        }

        private bool UserNameValid(string userName)
        {
            var conn = new SqlConnection(LoginForm.connStr);
            conn.Open();
            string query = "SELECT Username FROM Player WHERE Username = @userName";

            var cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@userName", userName);

            var rd = cmd.ExecuteReader();
            bool ok = true;
            if (rd.Read()) ok = false;
            
            conn.Close();
            conn.Dispose();
            cmd.Dispose();
            rd.Close();

            if (ok == false) return false;
            return true;
        }

        private void ClearTBs()
        {
            tbConfirmPassword.Text = "";
            tbPasswordCreate.Text = "";
            tbUsernameCreate.Text = "";
        }
    }
}
