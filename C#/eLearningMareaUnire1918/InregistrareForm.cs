using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace eLearningMareaUnire1918
{
    public partial class InregistrareForm : Form
    {
        public static string connStr = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\eLearning1918.mdf;Integrated Security=True";
        public static string resPath = $@"{Directory.GetCurrentDirectory()}\..\..\Resurse\";
        public static string imgPath = $@"{Directory.GetCurrentDirectory()}\..\..\Resurse\imaginislideshow\";
        private bool automat = true;
        int imgCount = 1;
        private Timer timer;

        public InregistrareForm()
        {
            InitializeComponent();
            IncarcaDate();

            txtEmail.Text = "elev1@yahoo.com";
            txtParola.Text = "elev1";

            pgBarSlideshow.Value = 1;
            btnInainte.Enabled = false;
            btnInapoi.Enabled = false;

            pbSlideshow.SizeMode = PictureBoxSizeMode.StretchImage;
            pbSlideshow.Image = Image.FromFile(imgPath + imgCount.ToString() + ".jpg");
            timer = new Timer
            {
                Interval = 2000
            };
            timer.Tick += HandleTick;
            timer.Start();
        }

        private void HandleTick(object sender, EventArgs e)
        {
            ++imgCount;
            pgBarSlideshow.Increment(1);
            if (imgCount == 6)
            {
                imgCount = 1;
                pgBarSlideshow.Value = 1;
            }

            Image img = Image.FromFile(imgPath + imgCount.ToString() + ".jpg");
            pbSlideshow.Image = img;
        }

        private void IncarcaDate()
        {
            StreamReader sr = new StreamReader(resPath + "date.txt");
            string line;
            string[] s;
            char[] sep = {';'};
            int count = 0;

            while ((line = sr.ReadLine()) != null)
            {
                if (line.EndsWith(":"))
                {
                    ++count;
                    continue;
                }

                if (count == 1)
                {
                    s = line.Split(sep, StringSplitOptions.RemoveEmptyEntries);
                    string numePrenume = s[0];
                    string parola = s[1];
                    string email = s[2];
                    string clasa = s[3];

                    InsertUtilizator(numePrenume, parola, email, clasa);
                }
                else if (count == 2)
                {
                    s = line.Split(sep, StringSplitOptions.RemoveEmptyEntries);
                    int tip = Int32.Parse(s[0]);
                    string enunt = s[1];
                    string r1 = s[2];
                    string r2 = s[3];
                    string r3 = s[4];
                    string r4 = s[5];
                    string rc = s[6];

                    bool _tip = tip != 1 && tip != 4;
                    InsertItem(tip, enunt, r1, r2, r3, r4, rc, _tip);
                }
                else
                {
                    s = line.Split(sep, StringSplitOptions.RemoveEmptyEntries);
                    int idElev = Int32.Parse(s[0]);
                    DateTime dataEvaluare = DateTime.Parse(s[1]);
                    int nota = Int32.Parse(s[2]);

                    InsertEvaluare(idElev, dataEvaluare, nota);
                }
            }
        }

        private void InsertEvaluare(int idElev, DateTime dataEvaluare, int nota)
        {
            var conn = new SqlConnection(connStr);
            conn.Open();
            string query = "INSERT INTO Evaluari VALUES(@idElev, @dataEvaluare, @nota)";

            var cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@idElev", idElev);
            cmd.Parameters.AddWithValue("@dataEvaluare", dataEvaluare);
            cmd.Parameters.AddWithValue("@nota", nota);

            cmd.ExecuteNonQuery();
            conn.Close();
            conn.Dispose();
            cmd.Dispose();
        }

        private void InsertItem(int tip, string enunt, string r1, string r2, string r3, string r4, string rc, bool _tip)
        {
            var conn = new SqlConnection(connStr);
            conn.Open();
            string query = "";

            if (!_tip)
            {
                query = "INSERT INTO Itemi(TipItem, EnuntItem, RaspunsCorectItem) " +
                    "VALUES(@tip, @enunt, @rc)";

                var cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@tip", tip);
                cmd.Parameters.AddWithValue("@enunt", enunt);
                cmd.Parameters.AddWithValue("@rc", rc);

                cmd.ExecuteNonQuery();
                cmd.Dispose();
            }
            else
            {
                query = "INSERT INTO Itemi VALUES(@tip, @enunt, @r1, @r2, @r3, @r4, @rc)";

                var cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@tip", tip);
                cmd.Parameters.AddWithValue("@enunt", enunt);
                cmd.Parameters.AddWithValue("@r1", r1);
                cmd.Parameters.AddWithValue("@r2", r2);
                cmd.Parameters.AddWithValue("@r3", r3);
                cmd.Parameters.AddWithValue("@r4", r4);
                cmd.Parameters.AddWithValue("@rc", rc);

                cmd.ExecuteNonQuery();
                cmd.Dispose();
            }

            conn.Close();
            conn.Dispose();
        }

        private void InsertUtilizator(string numePrenume, string parola, string email, string clasa)
        {
            var conn = new SqlConnection(connStr);
            conn.Open();
            string query = "INSERT INTO Utilizatori VALUES(@numePrenume, @parola, @email, @clasa)";

            var cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@numePrenume", numePrenume);
            cmd.Parameters.AddWithValue("@parola", parola);
            cmd.Parameters.AddWithValue("@email", email);
            cmd.Parameters.AddWithValue("@clasa", clasa);

            cmd.ExecuteNonQuery();
            conn.Close();
            conn.Dispose();
            cmd.Dispose();
        }

        private void btnInapoi_Click(object sender, EventArgs e)
        {
            --imgCount;
            pgBarSlideshow.Increment(-1);
            if (imgCount < 5) btnInainte.Enabled = true;
            pbSlideshow.Image = Image.FromFile(imgPath + imgCount.ToString() + ".jpg");

            if (imgCount == 1)
            {
                btnInapoi.Enabled = false;
                return;
            }
        }

        private void btnManual_Click(object sender, EventArgs e)
        {
            if (automat)
            {
                automat = false;
                timer.Stop();

                if (imgCount > 1)
                    btnInapoi.Enabled = true;
                if (imgCount < 5)
                    btnInainte.Enabled = true;
            }
            else
            {
                automat = true;
                timer.Start();
                btnInainte.Enabled = false;
                btnInapoi.Enabled = false;
            }
        }

        private void btnInainte_Click(object sender, EventArgs e)
        {           
            ++imgCount;
            pgBarSlideshow.Increment(1);
            if (imgCount > 1) btnInapoi.Enabled = true;
            pbSlideshow.Image = Image.FromFile(imgPath + imgCount.ToString() + ".jpg");

            if (imgCount == 5)
            {
                btnInainte.Enabled = false;
                return;
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text;
            string parola = txtParola.Text;

            if (!ExistaUtilizator(email, parola))
            {
                MessageBox.Show("Eroare de autentificare!");
                txtEmail.Text = String.Empty;
                txtParola.Text = String.Empty;
            }
            else
            {
                int id = GetElevId(email, parola);
                string numePrenume = GetElevNumePrenume(id);
                eLearning1918_Elev eLearning1918_Elev = new eLearning1918_Elev(id, numePrenume);
                this.Visible = false;
                eLearning1918_Elev.ShowDialog();
                this.Visible = true;
            }
        }

        private string GetElevNumePrenume(int id)
        {
            string numePrenume = "";
            using (var conn = new SqlConnection(connStr))
            {
                conn.Open();
                string query = "SELECT NumePrenumeUtilizator FROM Utilizatori WHERE " +
                    "IdUtilizator = @id";

                using (var cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@id", id);

                    var sc = cmd.ExecuteScalar();
                    numePrenume = (string)sc;
                }
            }

            return numePrenume;
        }

        private int GetElevId(string email, string parola)
        {
            int id = 0;
            using (var conn = new SqlConnection(connStr))
            {
                conn.Open();
                string query = "SELECT IdUtilizator FROM Utilizatori WHERE " +
                    "EmailUtilizator = @email AND ParolaUtilizator = @parola";

                using (var cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@email", email);
                    cmd.Parameters.AddWithValue("@parola", parola);

                    var sc = cmd.ExecuteScalar();
                    id = (int)sc;
                }
            }

            return id;
        }

        private bool ExistaUtilizator(string email, string parola)
        {
            bool gasit = false;
            using (var conn = new SqlConnection(connStr))
            {
                conn.Open();
                string query = "SELECT * FROM Utilizatori WHERE " +
                    "EmailUtilizator = @email AND ParolaUtilizator = @parola";

                using (var cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@email", email);
                    cmd.Parameters.AddWithValue("@parola", parola);

                    var sc = cmd.ExecuteScalar();
                    gasit = sc != null;
                }
            }

            return gasit;
        }

        private void InregistrareForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Esti sigur ?", "Iesire", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                this.Dispose();
            }
            else if (dialogResult == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
    }
}
