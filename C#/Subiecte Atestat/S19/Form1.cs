using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace S19
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'locatariDBDataSet.Locatar' table. You can move, or remove it, as needed.
            this.locatarTableAdapter.Fill(this.locatariDBDataSet.Locatar);

        }

        private void btnAdauga_Click(object sender, EventArgs e)
        {
            string nume = txtNume.Text;
            string nrBloc = txtNrBloc.Text;
            int nrAp = int.Parse(txtNrAp.Text);
            bool angajat = chkAngajat.Checked;

            this.locatarTableAdapter.AdaugaLocatar(nume, nrBloc, nrAp, angajat);
            this.locatarTableAdapter.Fill(this.locatariDBDataSet.Locatar);
        }

        private void btnModifica_Click(object sender, EventArgs e)
        {
            string nume = txtNumeModifica.Text;
            bool angajat = chkAngajatModifica.Checked;

            this.locatarTableAdapter.ModificaLocatar(angajat, nume);

            this.locatarTableAdapter.Fill(this.locatariDBDataSet.Locatar);
        }

        private void btnAfiseaza_Click(object sender, EventArgs e)
        {
            this.locatarTableAdapter.FillLocatari(this.locatariDBDataSet.Locatar);
        }
    }
}
