using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;
using InfirmerieDAL;
using InfirmerieBLL; // Référence la couche BLL
using InfirmerieBO; // Référence la couche BO

namespace InfirmerieGUI
{
    public partial class Liste_des_élèves : Form
    {
        public Liste_des_élèves()
        {
            InitializeComponent();
            GestionEleves.SetchaineConnexion(ConfigurationManager.ConnectionStrings
            ["Eleve"]);
            List<Classe> liste = new List<Classe>();
            liste = GestionEleves.GetClasses();

            listeClasse.ValueMember = "Id";

            listeClasse.DisplayMember = "Libelle";

            listeClasse.DataSource = liste;
        }

        private void tableauEleve_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            // Blocage de la génération automatique des colonnes

            tableauEleve.AutoGenerateColumns = true;

           
        List<Eleve> liste = new List<Eleve>();
            liste = GestionEleves.GetEleves();
            // Rattachement de la List à la source de données du datagridview

            tableauEleve.DataSource = liste;
        }

        private void btnModifierListeEleves_Click(object sender, EventArgs e)
        {

            if (radioTiersTempsOuiModif.Checked)
            {
                int RowIndex = tableauEleve.CurrentCell.RowIndex;
                int indexRow = RowIndex;
                DataGridViewRow selectedRow = tableauEleve.Rows[indexRow];

                // Création de l'objet Utilisateur avec le nom récupéré dans la GUI
                Eleve unEleve = new Eleve((int)selectedRow.Cells[0].Value, (Classe)listeClasse.SelectedItem, saisieNomModif.Text, saisiePrenomModif.Text, saisieDateEleveModif.Value, int.Parse(saisieNumTelModif.Text), int.Parse(saisieNumTelParentModif.Text), true, saisieCommentaireSanteModif.Text);
                // Appel de la méthode CreerUtilisateur de la couche BLL
                GestionEleves.ModifierEleve(unEleve);
                MessageBox.Show("L'élève " + saisieNomModif.Text + " " + saisiePrenomModif.Text + " a bien été modifié(e)");

                List<Eleve> liste = new List<Eleve>();
                liste = GestionEleves.GetEleves();
                // Rattachement de la List à la source de données du datagridview

                tableauEleve.DataSource = liste;

            }
            else
            {

                // Création de l'objet Utilisateur avec le nom récupéré dans la GUI

                int RowIndex = tableauEleve.CurrentCell.RowIndex;
                int indexRow = RowIndex;
                DataGridViewRow selectedRow = tableauEleve.Rows[indexRow];

                Eleve unEleve = new Eleve((int)selectedRow.Cells[0].Value, (Classe)listeClasse.SelectedItem, saisieNomModif.Text, saisiePrenomModif.Text, saisieDateEleveModif.Value, int.Parse(saisieNumTelModif.Text), int.Parse(saisieNumTelParentModif.Text), false, saisieCommentaireSanteModif.Text);
                // Appel de la méthode CreerUtilisateur de la couche BLL
                GestionEleves.ModifierEleve(unEleve);
                MessageBox.Show("L'élève " + saisieNomModif.Text + " " + saisiePrenomModif.Text + " a bien été modifié(e)");

                List<Eleve> liste = new List<Eleve>();
                liste = GestionEleves.GetEleves();
                // Rattachement de la List à la source de données du datagridview

                tableauEleve.DataSource = liste;


            }
        }

        private void btnSupprimerEleve_Click(object sender, EventArgs e)
        {

        }

        private void btnActualiserListeEleve_Click(object sender, EventArgs e)
        {
           
        }

        private void tableauEleve_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int indexRow = e.RowIndex;
            DataGridViewRow selectedRow = tableauEleve.Rows[indexRow];

            listeClasse.Text = selectedRow.Cells[1].Value.ToString();
            saisieNomModif.Text = selectedRow.Cells[2].Value.ToString();
            saisiePrenomModif.Text = selectedRow.Cells[3].Value.ToString();
            saisieDateEleveModif.Text = selectedRow.Cells[4].Value.ToString();
            saisieNumTelModif.Text = selectedRow.Cells[5].Value.ToString();
            saisieNumTelParentModif.Text = selectedRow.Cells[6].Value.ToString();
            saisieCommentaireSanteModif.Text = selectedRow.Cells[8].Value.ToString();
        }

        private void radioTiersTempsOui_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void listeClasseModif_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            DialogResult m = MessageBox.Show("Voulez-vous vraiment supprimer cet élève ?", "Avertissement", MessageBoxButtons.YesNo);

            switch (m)
            {
                case DialogResult.Yes:
                    using (SqlConnection maConnexion = ConnexionBD.GetConnexionBD().GetSqlConnexion())
                    {
                        try
                        {
                            maConnexion.Close();
                            int RowIndex = tableauEleve.CurrentCell.RowIndex;
                            int indexRow = RowIndex;
                            DataGridViewRow selectedRow = tableauEleve.Rows[indexRow];

                            Eleve unEleve = new Eleve((int)selectedRow.Cells[0].Value, (Classe)listeClasse.SelectedItem, saisieNomModif.Text, saisiePrenomModif.Text, saisieDateEleveModif.Value, int.Parse(saisieNumTelModif.Text), int.Parse(saisieNumTelParentModif.Text), false, saisieCommentaireSanteModif.Text);
                            // Appel de la méthode CreerUtilisateur de la couche BLL
                            GestionEleves.SupprimerEleve(unEleve);
                            MessageBox.Show("L'élève " + saisieNomModif.Text + " " + saisiePrenomModif.Text + " a bien été supprimé(e)");

                            List<Eleve> liste = new List<Eleve>();
                            liste = GestionEleves.GetEleves();
                            // Rattachement de la List à la source de données du datagridview

                            tableauEleve.DataSource = liste;
                        }
                        catch
                        {
                            MessageBox.Show("Vous ne pouvez pas supprimer cet élève car il est lié à une ou plusieurs visites !", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            maConnexion.Close();
                        }
                    }

                    break;
                case DialogResult.No:
                    break;
            }
        }

        private void Liste_des_élèves_Load(object sender, EventArgs e)
        {
            List<Eleve> liste = new List<Eleve>();
            liste = GestionEleves.GetEleves();
            // Rattachement de la List à la source de données du datagridview

            tableauEleve.DataSource = liste;
        }

        private void saisieNomModif_TextChanged(object sender, EventArgs e)
        {

        }

        private void labelNomEleve_Click(object sender, EventArgs e)
        {

        }

        private void btnRetour_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menu mm = new Menu();
            mm.Show();
        }
    }
}
