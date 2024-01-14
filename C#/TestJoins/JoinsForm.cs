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

namespace TestJoins
{
    public partial class JoinsForm : Form
    {
        private string connStr = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\TestDB.mdf;Integrated Security=True;Connect Timeout=30";
        public JoinsForm()
        {
            InitializeComponent();
            SelectCustomers();
            SelectAllOrders();
        }

        private void SelectAllOrders()
        {
            var conn = new SqlConnection(connStr);
            conn.Open();
            string query = "SELECT * FROM Orders";

            var cmd = new SqlCommand(query, conn);
            var rd = cmd.ExecuteReader();

            DataTable dt = new DataTable();
            dt.Load(rd);
            dgvOrders.DataSource = dt;

            conn.Close();
            conn.Dispose();
            cmd.Dispose();
            rd.Close();
        }

        private void SelectCustomers()
        {
            var conn = new SqlConnection(connStr);
            conn.Open();
            string query = "SELECT * FROM Customers";

            var cmd = new SqlCommand(query, conn);
            var rd = cmd.ExecuteReader();

            DataTable dt = new DataTable();
            dt.Load(rd);
            dgvCustomers.DataSource = dt;

            conn.Close();
            conn.Dispose();
            cmd.Dispose();
            rd.Close();
        }

        private void InnerJoin()
        {
            var conn = new SqlConnection(connStr);
            conn.Open();
            string query = "SELECT Orders.OrderID, Customers.CustomerName, Orders.OrderDate FROM " +
                "Customers " +
                "INNER JOIN Orders ON Customers.CustomerID = Orders.CustomerID";

            var cmd = new SqlCommand(query, conn);
            var rd = cmd.ExecuteReader();

            DataTable dt = new DataTable();
            dt.Load(rd);
            dgvJoins.DataSource = dt;

            conn.Close();
            conn.Dispose();
            cmd.Dispose();
            rd.Close();
        }
        private void LeftJoin()
        {
            var conn = new SqlConnection(connStr);
            conn.Open();
            string query = "SELECT Orders.OrderID, Customers.CustomerName, Orders.OrderDate FROM " +
                "Customers " +
                "LEFT JOIN Orders ON Customers.CustomerID = Orders.CustomerID";

            var cmd = new SqlCommand(query, conn);
            var rd = cmd.ExecuteReader();

            DataTable dt = new DataTable();
            dt.Load(rd);
            dgvJoins.DataSource = dt;

            conn.Close();
            conn.Dispose();
            cmd.Dispose();
            rd.Close();
        }
        private void RightJoin()
        {
            var conn = new SqlConnection(connStr);
            conn.Open();
            string query = "SELECT Orders.OrderID, Customers.CustomerName, Orders.OrderDate FROM " +
                "Customers " +
                "RIGHT JOIN Orders ON Customers.CustomerID = Orders.CustomerID";

            var cmd = new SqlCommand(query, conn);
            var rd = cmd.ExecuteReader();

            DataTable dt = new DataTable();
            dt.Load(rd);
            dgvJoins.DataSource = dt;

            conn.Close();
            conn.Dispose();
            cmd.Dispose();
            rd.Close();
        }
        private void FullJoin()
        {
            var conn = new SqlConnection(connStr);
            conn.Open();
            string query = "SELECT Orders.OrderID, Customers.CustomerName, Orders.OrderDate FROM " +
                "Customers " +
                "FULL JOIN Orders ON Customers.CustomerID = Orders.CustomerID";

            var cmd = new SqlCommand(query, conn);
            var rd = cmd.ExecuteReader();

            DataTable dt = new DataTable();
            dt.Load(rd);
            dgvJoins.DataSource = dt;

            conn.Close();
            conn.Dispose();
            cmd.Dispose();
            rd.Close();
        }
        private void btnInnerJoin_Click(object sender, EventArgs e)
        {
            InnerJoin();
        }

        private void btnLeftJoin_Click(object sender, EventArgs e)
        {
            LeftJoin();
        }

        private void btnRightJoin_Click(object sender, EventArgs e)
        {
            RightJoin();
        }

        private void btnFullJoin_Click(object sender, EventArgs e)
        {
            FullJoin();
        }
    }
}
