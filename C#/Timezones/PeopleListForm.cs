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
using System.Windows.Input;

namespace Timezones
{
    public partial class PeopleListForm : Form
    {
        private string connStr = @"Server=sergiu;Database=TimezonesDB;User Id=Sergiu;Password=sergiu";
        private int checkedBoxes = 0;
        private List<int> checkedList;
        public PeopleListForm()
        {
            InitializeComponent();
            SelectAllPeople();
            checkedList = new List<int>();
        }

        private void SelectAllPeople()
        {
            using (var conn = new SqlConnection(connStr))
            {
                conn.Open();
                using (var cmd = new SqlCommand(connStr))
                {
                    cmd.Connection = conn;
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "spSelectAllPeople";

                    DataTable dt = new DataTable();
                    dt.Load(cmd.ExecuteReader());
                    dgvPeople.DataSource = dt;
                }
            }
        }

        private void dgvPeople_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn && 
                e.RowIndex >= 0)
            {
                string regionName = senderGrid[5, e.RowIndex].Value.ToString();
                string username = senderGrid[3, e.RowIndex].Value.ToString();

                TimeForm timeForm = new TimeForm(regionName, username);
                timeForm.ShowDialog();
            }

            else
                if (senderGrid.Columns[e.ColumnIndex] is DataGridViewCheckBoxColumn &&
                    e.RowIndex >= 0)
                {
                    DataGridViewCheckBoxCell cell = (DataGridViewCheckBoxCell)senderGrid[0, e.RowIndex];
                    int id = (int)senderGrid[2, e.RowIndex].Value;
                    if (cell.Selected && checkedList.Contains(id) == false)
                        checkedList.Add(id);
                    else
                        checkedList.Remove(id);

                    if (checkedList.Count > 0)
                    {
                        icobtnInsert.BackColor = Color.Red;
                        icobtnInsert.IconChar = FontAwesome.Sharp.IconChar.X;
                        senderGrid.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.MediumPurple;
                    }
                    else
                    {
                        icobtnInsert.BackColor = Color.DarkOrange;
                        icobtnInsert.IconChar = FontAwesome.Sharp.IconChar.Plus;
                        senderGrid.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.SlateBlue;
                        senderGrid.Rows[e.RowIndex].Cells[1].Style.BackColor = Color.Indigo;
                    }
                }
        }

        private void icobtnSearch_Click(object sender, EventArgs e)
        {
            SearchPeople();
        }

        private void SearchPeople()
        {
            using (var conn = new SqlConnection(connStr))
            {
                conn.Open();
                using (var cmd = new SqlCommand(connStr))
                {
                    cmd.Connection = conn;
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "spSearchPeople";
                    cmd.Parameters.AddWithValue("@prefix", txtSearch.Text);

                    DataTable dt = new DataTable();
                    dt.Load(cmd.ExecuteReader());
                    dgvPeople.DataSource = dt;
                }
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if (txtSearch.Text == "")
                SelectAllPeople();
        }

        private void icobtnInsert_Click(object sender, EventArgs e)
        {
            if (icobtnInsert.BackColor == Color.DarkOrange)
            {
                InsertPersonForm insertPersonForm = new InsertPersonForm();
                insertPersonForm.ShowDialog();
            }

            else
            {
                foreach (int id in checkedList)
                    DeletePerson(id);

                SelectAllPeople();

                icobtnInsert.BackColor = Color.DarkOrange;
                icobtnInsert.IconChar = FontAwesome.Sharp.IconChar.Plus;
            }

            SelectAllPeople();
        }

        private void DeletePerson(int id)
        {
            using (var conn = new SqlConnection(connStr))
            {
                conn.Open();
                using (var cmd = new SqlCommand(connStr))
                {
                    cmd.Connection = conn;
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "spDeletePeople";
                    cmd.Parameters.AddWithValue("@id", id);

                    cmd.ExecuteNonQuery();
                }
            }
        }

        private void txtSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
                SearchPeople();
        }
    }
}
