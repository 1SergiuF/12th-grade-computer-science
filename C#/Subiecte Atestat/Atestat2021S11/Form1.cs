using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Atestat2021S11
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'parlamentDataSet.Parlamentar' table. You can move, or remove it, as needed.
            this.parlamentarTableAdapter.Fill(this.parlamentDataSet.Parlamentar);

        }

        private void btnAdauga_Click(object sender, EventArgs e)
        {
            try
            {
                string nume = tbNume.Text;
                string partid = tbPartid.Text;
                string judet = tbJudet.Text;

                if (judet.Length > 2)
                    MessageBox.Show("Judet incorect !");
                else
                {
                    this.parlamentarTableAdapter.InsertParlamentar(nume, partid, judet);
                    this.parlamentarTableAdapter.Fill(this.parlamentDataSet.Parlamentar);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnCauta_Click(object sender, EventArgs e)
        {
            try
            {
                string partid = tbPartidCautare.Text;
                this.parlamentarTableAdapter.SelectParlamentari(this.parlamentDataSet.Parlamentar, partid);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void tbPartidCautare_TextChanged(object sender, EventArgs e)
        {
            if (tbPartidCautare.Text == String.Empty)
                this.parlamentarTableAdapter.Fill(this.parlamentDataSet.Parlamentar);
        }
    }
}
