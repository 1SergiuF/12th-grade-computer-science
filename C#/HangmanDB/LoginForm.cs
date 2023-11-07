using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace HangmanDB
{
    public partial class LoginForm : Form
    {
        private string resPath = $@"{Directory.GetCurrentDirectory()}\..\..\DefaultPlayers\";
        public static string connStr = $@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\PlayerDB.mdf;Integrated Security=True";
        public static int highScore;
        public LoginForm()
        {
            InitializeComponent();
            LoadPlayers();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            panelLogin.BackColor = Color.FromArgb(100, 0, 0, 0);
        }

        private void LoadPlayers()
        {
            StreamReader sr = new StreamReader($"{resPath}players.txt");

            string line;
            char[] sep = { ';', ' ' };
            string[] s;

            while ((line = sr.ReadLine()) != null)
            {
                s = line.Split(sep, StringSplitOptions.RemoveEmptyEntries);

                string username = s[0];
                string password = s[1];
                int highScore = int.Parse(s[2]);
                int coins = int.Parse(s[3]);

                InsertPlayers(username, password, highScore, coins);
            }
        }

        private void InsertPlayers(string username, string password, int highScore, int coins)
        {
            SqlConnection conn = new SqlConnection(connStr);
            conn.Open();
            string query = "INSERT INTO Player VALUES(@username, @password, @highScore, @coins)";

            var cmd = new SqlCommand(query, conn);

            cmd.Parameters.AddWithValue("@username", username);
            cmd.Parameters.AddWithValue("@password", password);
            cmd.Parameters.AddWithValue("@highScore", highScore);
            cmd.Parameters.AddWithValue("@coins", coins);

            cmd.ExecuteNonQuery();

            conn.Close();
            conn.Dispose();
            cmd.Dispose();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (tbUsername.Text == "" || tbPassword.Text == "")
            {
                MessageBox.Show("Must fill all fields !");
                tbUsername.Text = "";
                tbPassword.Text = "";
                return;
            }

            if (AccountExists(tbUsername.Text, tbPassword.Text))
            {
                highScore = UserFindHighScore(tbUsername.Text);
                MenuForm menuForm = new MenuForm(tbUsername.Text);
                this.Visible = false;
                menuForm.ShowDialog();
                this.Visible = true;
                tbUsername.Text = "";
                tbPassword.Text = "";
            }
            else
            {
                MessageBox.Show("Account doesn't exist !");
                tbUsername.Text = "";
                tbPassword.Text = "";
            }

        }

        private int UserFindCoins(string userName)
        {
            var conn = new SqlConnection(connStr);
            conn.Open();
            string query = "SELECT Coins FROM Player WHERE Username = @userName";

            var cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@userName", userName);

            int x = (int)cmd.ExecuteScalar();

            conn.Close();
            conn.Dispose();
            cmd.Dispose();

            return x;
        }

        private int UserFindHighScore(string userName)
        {
            var conn = new SqlConnection(connStr);
            conn.Open();
            string query = "SELECT Highscore FROM Player WHERE Username = @userName";

            var cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@userName", userName);

            int x = (int)cmd.ExecuteScalar();

            conn.Close();
            conn.Dispose();
            cmd.Dispose();

            return x;
        }

        private bool AccountExists(string userName, string password)
        {
            var conn = new SqlConnection(connStr);
            conn.Open();
            string query = "SELECT COUNT(Username) FROM Player WHERE Username = @userName AND Password = @password";

            var cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@userName", userName);
            cmd.Parameters.AddWithValue ("@password", password);

            int x = (int)cmd.ExecuteScalar();

            conn.Close();
            conn.Dispose();
            cmd.Dispose();

            return x == 1;
        }

        private void btnCreateAccount_Click(object sender, EventArgs e)
        {
            CreateAccountForm createAccountForm = new CreateAccountForm();
            this.Visible = false;
            createAccountForm.ShowDialog();
            this.Visible = true;
        }
    }
}
