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

namespace Timezones
{
    public partial class InsertPersonForm : Form
    {
        private string connStr = @"Server=sergiu;Database=TimezonesDB;User Id=Sergiu;Password=sergiu";
        private bool selected;
        public InsertPersonForm()
        {
            InitializeComponent();
            GetTimeZoneIDs();
        }

        private void GetTimeZoneIDs()
        {
            cmbIds.DropDownStyle = ComboBoxStyle.DropDownList;
            foreach (TimeZoneInfo tz in TimeZoneInfo.GetSystemTimeZones())
                cmbIds.Items.Add(tz.Id);
        }

        private void icobtnLeave_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void icobtnInsert_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string email = txtEmail.Text;
            string region = string.Empty;
            if (selected == true)
                region = cmbIds.SelectedItem.ToString();
            else
            {
                MessageBox.Show("Region can't be null !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (username == string.Empty)
            {
                MessageBox.Show("Username can't be an empty string !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            InsertPerson(username, email, region);
        }

        private void InsertPerson(string username, string email, string region)
        {
            if (!EmailValid(email))
            {
                MessageBox.Show("Invalid email address !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            using (var conn = new SqlConnection(connStr))
            {
                conn.Open();
                using (var cmd = new SqlCommand(connStr))
                {
                    cmd.Connection = conn;
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "spInsertPerson";
                    
                    try
                    {
                        cmd.Parameters.AddWithValue("@username", username);
                        cmd.Parameters.AddWithValue("@email", email);
                        cmd.Parameters.AddWithValue("@region", region);

                        cmd.ExecuteNonQuery();
                    }
                    catch(Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }

            this.Dispose();
        }

        bool EmailValid(string email)
        {
            var trimmedEmail = email.Trim();

            if (trimmedEmail.EndsWith("."))
                return false;

            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == trimmedEmail;
            }
            catch
            { return false; }
        }

        private void cmbIds_SelectedIndexChanged(object sender, EventArgs e)
        {
            selected = true;
        }
    }
}
