using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InfirmerieGUI
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnAjoutEleve_Click(object sender, EventArgs e)
        {
            Module_de_saisie_d_élève mse = new Module_de_saisie_d_élève();
            this.Hide();
            mse.Show();
        }


        private void btnListeEleves_Click(object sender, EventArgs e)
        {
            Liste_des_élèves lde = new Liste_des_élèves();
            this.Hide();
            lde.Show();
        }

        private void btnQuitter_Click(object sender, EventArgs e)
        {
            DialogResult m = MessageBox.Show("Voulez-vous vraiment quitter ce menu ?", "Faites votre choix", MessageBoxButtons.YesNo);

            switch (m)
            {
                case DialogResult.Yes:
                    System.Windows.Forms.Application.Exit();
                    break;
                case DialogResult.No:
                    break;
            }
        }

        private void btnSaisieMedoc_Click(object sender, EventArgs e)
        {
            Module_de_saisie_de_médicaments lde = new Module_de_saisie_de_médicaments();
            this.Hide();
            lde.Show();
        }

        private void btnVueMedoc_Click(object sender, EventArgs e)
        {
            Vue_des_médicaments mse = new Vue_des_médicaments();
            this.Hide();
            mse.Show();
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void btnSaisieVisite_Click(object sender, EventArgs e)
        {
            Module_de_saisie_des_visites mse = new Module_de_saisie_des_visites();
            this.Hide();
            mse.Show();
        }

        private void btnAncienneVisite_Click(object sender, EventArgs e)
        {
            this.Hide();
            Vue_des_visites mm = new Vue_des_visites();
            mm.Show();
        }
    }
}
