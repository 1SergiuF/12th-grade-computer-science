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

namespace Teorie3
{
    public partial class MainWindow : Form
    {
        private StreamReader sr = null;
        private StreamWriter sw = null;
        private List<User> users = null;
        public MainWindow()
        {
            users = new List<User>();
            InitializeComponent();
        }

        public void ReadUsers()
        {
            try
            {
                sr = new StreamReader("users.txt");
                string[] s = null;
                string line = "";
                char[] sep = { ' ', ',', '\t' };

                while ((line = sr.ReadLine()) != null)
                {
                    s = line.Split(sep, StringSplitOptions.RemoveEmptyEntries);
                    int id = int.Parse(s[0]);
                    string name = s[1];
                    string password = s[2];
                    string email = s[3];
                    int age = int.Parse(s[4]);

                    users.Add(new User(id, name, password, email, age));
                }

                sr.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void WriteAllUsers()
        {
            try
            {
                sw = new StreamWriter("users.out");
                listUsers.Items.Clear();
                users.ForEach(user => {
                    sw.WriteLine(user);
                    listUsers.Items.Add(user);
                });

                sw.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnRead_Click(object sender, EventArgs e)
        {
            ReadUsers();
            MessageBox.Show("Data was read !");
            btnRead.Enabled = false;
        }

        private void btnWrite_Click(object sender, EventArgs e)
        {
            WriteAllUsers();
        }

        private void btnSearchByAge_Click(object sender, EventArgs e)
        {
            try
            {
                listUsers.Items.Clear();
                var user = users.Find(u => u.Age == int.Parse(tbAge.Text));
                if (user != null)
                    listUsers.Items.Add(user);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void tbSearchByName_TextChanged(object sender, EventArgs e)
        {
            listUsers.Items.Clear();

            var newList = users.FindAll(u => u.Name.ToLower().Contains(tbSearchByName.Text));

            newList.ForEach(user => listUsers.Items.Add(user));
        }

        private void AddUsers()
        {
            listUsers.Items.Clear();
            users.ForEach(user => listUsers.Items.Add(user));
        }

        private void btnAsc_Click(object sender, EventArgs e)
        {
            /*
             * CompareTo(a, b) < 0  daca a < b
             * CompareTor(a, b) > 0 daca a > b
             * CompareTo(a, b) = 0  daca a == b 
             */

            users.Sort((u1, u2) => u1.Name.CompareTo(u2.Name));
            AddUsers();
        }

        private void btnDesc_Click(object sender, EventArgs e)
        {
            users.Sort((u1, u2) => -u1.Name.CompareTo(u2.Name));
            AddUsers();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            try
            {
                users.RemoveAt(int.Parse(tbIndex.Text));
                tbIndex.Text = "";
                AddUsers();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                tbIndex.Text = "";
            }
        }
    }
}
