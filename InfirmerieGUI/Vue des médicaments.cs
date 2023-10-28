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
using InfirmerieDAL;
using System.Data.SqlClient;
using InfirmerieBLL; // Référence la couche BLL
using InfirmerieBO; // Référence la couche BO

namespace InfirmerieGUI
{
    public partial class Vue_des_médicaments : Form
    {
        public Vue_des_médicaments()
        {
            InitializeComponent();
            this.tableauMedicament.MultiSelect = true;
            GestionMedicaments.SetchaineConnexion(ConfigurationManager.ConnectionStrings
            ["Eleve"]);
        }



        private void btnActualiser_Click(object sender, EventArgs e)
        {
            List<Medicament> liste = new List<Medicament>();
            liste = GestionMedicaments.GetMedicaments();
            // Rattachement de la List à la source de données du datagridview

            tableauMedicament.DataSource = liste;
        }

        private void saisieLibelleModif_TextChanged(object sender, EventArgs e)
        {

        }

        private void tableauMedicament_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            List<Medicament> liste = new List<Medicament>();
            liste = GestionMedicaments.GetMedicaments();
            // Rattachement de la List à la source de données du datagridview

            tableauMedicament.DataSource = liste;
        }

        private void tableauMedicament_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int indexRow = e.RowIndex;
            DataGridViewRow selectedRow = tableauMedicament.Rows[indexRow];

            saisieLibelleModif.Text = selectedRow.Cells[1].Value.ToString();

            
        }

        private void btnRetour_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menu mm = new Menu();
            mm.Show();
        }

        private void btnModifier_Click(object sender, EventArgs e)
        {
            int RowIndex = tableauMedicament.CurrentCell.RowIndex;
            int indexRow = RowIndex;
            DataGridViewRow selectedRow = tableauMedicament.Rows[indexRow];

            // Création de l'objet Utilisateur avec le nom récupéré dans la GUI
            Medicament unMedicament = new Medicament((int)selectedRow.Cells[0].Value, saisieLibelleModif.Text);
            // Appel de la méthode CreerUtilisateur de la couche BLL
            GestionMedicaments.ModifierMedicament(unMedicament);
            MessageBox.Show("Le médicament " + saisieLibelleModif.Text + " a bien été modifié(e)");

            List<Medicament> liste = new List<Medicament>();
            liste = GestionMedicaments.GetMedicaments();
            // Rattachement de la List à la source de données du datagridview

            tableauMedicament.DataSource = liste;
        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            DialogResult m = MessageBox.Show("Voulez-vous vraiment supprimer ce médicament ?", "Avertissement", MessageBoxButtons.YesNo);

            switch (m)
            {
                case DialogResult.Yes:
                    using (SqlConnection maConnexion = ConnexionBD.GetConnexionBD().GetSqlConnexion())
                    {
                        try
                        {

                            maConnexion.Close();
                            int RowIndex = tableauMedicament.CurrentCell.RowIndex;
                            int indexRow = RowIndex;
                            DataGridViewRow selectedRow = tableauMedicament.Rows[indexRow];

                            Medicament unMedicament = new Medicament((int)selectedRow.Cells[0].Value, saisieLibelleModif.Text);
                            // Appel de la méthode CreerUtilisateur de la couche BLL
                            GestionMedicaments.SupprimerMedicament(unMedicament);
                            MessageBox.Show("Le médicament " + saisieLibelleModif.Text + " a bien été supprimé(e)");

                            List<Medicament> liste = new List<Medicament>();
                            liste = GestionMedicaments.GetMedicaments();
                            // Rattachement de la List à la source de données du datagridview

                            tableauMedicament.DataSource = liste;

                        }
                        catch
                        {
                            MessageBox.Show("Vous ne pouvez pas supprimer ce médicament car il est lié à une ou plusieurs prescriptions !", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            maConnexion.Close();
                        }
                    }

                    break;
                case DialogResult.No:
                    break;
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Vue_des_médicaments_Load(object sender, EventArgs e)
        {
            List<Medicament> liste = new List<Medicament>();
            liste = GestionMedicaments.GetMedicaments();
            // Rattachement de la List à la source de données du datagridview

            tableauMedicament.DataSource = liste;
        }
    }
}
