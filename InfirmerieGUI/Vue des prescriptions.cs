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
using InfirmerieBLL; // Référence la couche BLL
using InfirmerieBO; // Référence la couche BO

namespace InfirmerieGUI
{
    public partial class Vue_des_prescriptions : Form
    {
        private int i;
        public Vue_des_prescriptions(int i)
        {
            InitializeComponent();
            this.i = i;
            //MessageBox.Show(i.ToString());
            GestionPrescriptions.SetchaineConnexion(ConfigurationManager.ConnectionStrings
            ["Eleve"]);
            List<Medicament> listeM = new List<Medicament>();
            listeM = GestionVisites.GetMedicaments();

            listeMedicament.ValueMember = "Id_medic";

            listeMedicament.DisplayMember = "Libelle_medic";

            listeMedicament.DataSource = listeM;
        }

        private void Vue_des_prescriptions_Load(object sender, EventArgs e)
        {
            List<Prescription> liste = new List<Prescription>();
            liste = GestionPrescriptions.GetPrescriptions(i);
            // Rattachement de la List à la source de données du datagridview

            tableauPrescriptions.DataSource = liste;

            saisieIdVisite.Text = i.ToString();

            // Add this textbox to form
            this.Controls.Add(saisieIdVisite);
        }

        private void tableauPrescriptions_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void tableauPrescriptions_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int indexRow = e.RowIndex;
            DataGridViewRow selectedRow = tableauPrescriptions.Rows[indexRow];

            saisieIdVisite.Text = selectedRow.Cells[0].Value.ToString();
            listeMedicament.Text = selectedRow.Cells[1].Value.ToString();
            saisieQuantite.Text = selectedRow.Cells[2].Value.ToString();
        }

        private void btnModifier_Click(object sender, EventArgs e)
        {
            int RowIndex = tableauPrescriptions.CurrentCell.RowIndex;
            int indexRow = RowIndex;
            DataGridViewRow selectedRow = tableauPrescriptions.Rows[indexRow];

            // Création de l'objet Utilisateur avec le nom récupéré dans la GUI
            Prescription unePrescription = new Prescription(int.Parse(saisieIdVisite.Text), (Medicament)listeMedicament.SelectedItem, int.Parse(saisieQuantite.Text));
            // Appel de la méthode CreerUtilisateur de la couche BLL
            GestionPrescriptions.ModifierPrescription(unePrescription);
            MessageBox.Show("Le médicament a bien été modifié(e)");

            List<Prescription> liste = new List<Prescription>();
            liste = GestionPrescriptions.GetPrescriptions(i);

            // Rattachement de la List à la source de données du datagridview

            tableauPrescriptions.DataSource = liste;
        }

        private void saisieLibelleModif_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnRetour_Click(object sender, EventArgs e)
        {
            this.Hide();
            Vue_des_visites mm = new Vue_des_visites();
            mm.Show();
        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            DialogResult m = MessageBox.Show("Voulez-vous vraiment supprimer cette prescription ?", "Avertissement", MessageBoxButtons.YesNo);

            switch (m)
            {
                case DialogResult.Yes:
                    int RowIndex = tableauPrescriptions.CurrentCell.RowIndex;
                    int indexRow = RowIndex;
                    DataGridViewRow selectedRow = tableauPrescriptions.Rows[indexRow];

                    Prescription unePrescription = new Prescription(int.Parse(saisieIdVisite.Text), (Medicament)listeMedicament.SelectedItem, int.Parse(saisieQuantite.Text));
                    // Appel de la méthode CreerUtilisateur de la couche BLL
                    GestionPrescriptions.SupprimerPrescription(unePrescription);
                    MessageBox.Show("La prescription a bien été supprimé(e)");

                    List<Prescription> liste = new List<Prescription>();
                    liste = GestionPrescriptions.GetPrescriptions(i);
                    // Rattachement de la List à la source de données du datagridview

                    tableauPrescriptions.DataSource = liste;

                    break;
                case DialogResult.No:
                    break;
            }
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {

            Prescription unePrescription = new Prescription(int.Parse(saisieIdVisite.Text), (Medicament)listeMedicament.SelectedItem, int.Parse(saisieQuantite.Text));
            // Appel de la méthode CreerUtilisateur de la couche BLL
            GestionPrescriptions.AjoutPrescription(unePrescription);
            if (int.Parse(saisieQuantite.Text) == 1)
            {
                MessageBox.Show("La prescription avec un " + listeMedicament.Text + " a bien été ajoutée");

            }
            else
            {
                MessageBox.Show("La prescription du médicament " + listeMedicament.Text + " avec une quantité de " + saisieQuantite.Text + " a bien été ajoutée");
            }

            List<Prescription> liste = new List<Prescription>();
            liste = GestionPrescriptions.GetPrescriptions(i);

            // Rattachement de la List à la source de données du datagridview

            tableauPrescriptions.DataSource = liste;
        }

        private void listeMedicament_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void saisieIdMedic_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
