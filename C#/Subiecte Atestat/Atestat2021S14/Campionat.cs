using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Atestat2021S14
{
    public partial class Campionat : Form
    {
        public Campionat()
        {
            InitializeComponent();
        }

        private void Campionat_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'campionatDataSet.Meci' table. You can move, or remove it, as needed.
            this.meciTableAdapter.Fill(this.campionatDataSet.Meci);

        }

        private void btnAdauga_Click(object sender, EventArgs e)
        {
            try
            {
                int etapa = int.Parse(tbEtapa.Text);
                string gazde = tbGazde.Text;
                string oaspeti = tbOaspeti.Text;
                int golGazde = int.Parse(tbGolGazde.Text);
                int golOaspeti = int.Parse(tbGolOaspeti.Text);

                this.meciTableAdapter.InsertMeci(etapa, gazde, oaspeti, golGazde, golOaspeti);
                this.meciTableAdapter.Fill(this.campionatDataSet.Meci);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnTop_Click(object sender, EventArgs e)
        {
            try
            {
                this.meciTableAdapter.SelectEchipeDesc(this.campionatDataSet.Meci);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
