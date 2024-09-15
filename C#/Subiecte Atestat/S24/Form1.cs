using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace S24
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'cinemaDBDataSet.Filme' table. You can move, or remove it, as needed.
            this.filmeTableAdapter.Fill(this.cinemaDBDataSet.Filme);

        }

        private void btnAdauga_Click(object sender, EventArgs e)
        {
            string regizor = txtRegizor.Text;
            int anAp = int.Parse(txtAnAp.Text);
            string titlu = txtTitlu.Text;
            int durata = int.Parse(txtDurata.Text);

            this.filmeTableAdapter.AdaugaFilm(regizor, anAp, titlu, durata);

            this.filmeTableAdapter.Fill(this.cinemaDBDataSet.Filme);
        }

        private void btnModifica_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtId.Text);
            string titlu = txtTitluModifica.Text;

            this.filmeTableAdapter.ModificaTitlu(titlu, id);

            this.filmeTableAdapter.Fill(this.cinemaDBDataSet.Filme);
        }

        private void btnAfiseaza_Click(object sender, EventArgs e)
        {
            string regizor = txtRegizorAfisare.Text;

            this.filmeTableAdapter.AfiseazaFilme(this.cinemaDBDataSet.Filme, regizor);
        }
    }
}
