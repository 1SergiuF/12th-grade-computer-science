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

namespace TestDB
{
    public partial class Form1 : Form
    {
        private string connStr = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\TestDB.mdf;Integrated Security=True;Connect Timeout=30";
        private string resPath = $@"{Directory.GetCurrentDirectory()}\..\..\Resources\";
        public Form1()
        {
            InitializeComponent();
            IncarcaDate();
            SelectUsers();
        }

        private void IncarcaDate()
        {
            StreamReader sr = new StreamReader(resPath + "date.txt");

            string line;
            string[] s;
            char[] sep = { ';' };

            while ((line = sr.ReadLine()) != null)
            {
                s = line.Split(sep, StringSplitOptions.RemoveEmptyEntries);

                string prenume = s[0];
                string nume = s[1];
                string parola = s[2];

                InsertUser(prenume, nume, parola);
            }
        }

        private void InsertUser(string prenume, string nume, string parola)
        {
            using (var conn = new SqlConnection(connStr))
            {
                conn.Open();
                string query = "INSERT INTO [Table] VALUES(@nume, @prenume, @parola)";

                using (var cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@nume", nume);
                    cmd.Parameters.AddWithValue("@prenume", prenume);
                    cmd.Parameters.AddWithValue("@parola", parola);

                    cmd.ExecuteNonQuery();
                }
            }
        }

        private void SelectUsers()
        {
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                conn.Open ();
                string query = "SELECT * FROM [Table]";

                using (var cmd = new SqlCommand(query, conn))
                {
                    using (var rd = cmd.ExecuteReader())
                    {
                        DataTable dt = new DataTable();
                        dt.Load(rd);
                        dgv.DataSource = dt;
                    }
                }
            }
        }
    }
}
