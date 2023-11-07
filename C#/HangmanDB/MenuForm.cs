using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;

namespace HangmanDB
{
    public partial class MenuForm : Form
    {
        private List<Tuple<string, int>> topList = new List<Tuple<string, int>>();
        private int counter;
        private string name;
        public MenuForm(string userName)
        {
            InitializeComponent();
            name = userName;
            gbStats.Text = $"{userName}'s stats";
            lblHighscore.Text += $" {LoginForm.highScore}";
            TopScoreDGV();
        }

        private void TopScoreDGV()
        {
            PushToTopList();
            topList.Sort((it1, it2) => it2.Item2.CompareTo(it1.Item2));
            topList.ForEach(t =>
            {
                this.dgvTopHangman.Rows.Add(++counter, t.Item1, t.Item2);
            });
        }

        private void PushToTopList()
        {
            var conn = new SqlConnection(LoginForm.connStr);
            conn.Open();
            string query = "SELECT Username, Highscore FROM Player";

            var cmd = new SqlCommand(query, conn);
            var rd = cmd.ExecuteReader();

            while (rd.Read())
            {
                topList.Add(new Tuple<string, int>(rd[0].ToString(), (int)rd[1]));
            }

            conn.Close();
            conn.Dispose();
            cmd.Dispose();
            rd.Close();
        }

        private void MenuForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            HangmanForm hangmanForm = new HangmanForm();
            this.Visible = false;
            hangmanForm.ShowDialog();
            this.Visible = true;

            if (HangmanForm.punctaj > LoginForm.highScore)
            {
                LoginForm.highScore = HangmanForm.punctaj;
                lblHighscore.Text = $"Highscore: {LoginForm.highScore}";
            }

            HangmanForm.UpdateScore(name, HangmanForm.punctaj);
            HangmanForm.punctaj = 0;

            topList.Clear();
            dgvTopHangman.Rows.Clear();
            TopScoreDGV();
        }
    }
}
