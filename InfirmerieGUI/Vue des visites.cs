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
    public partial class Vue_des_visites : Form
    {
        public Vue_des_visites()
        {
            InitializeComponent();
            GestionVisites.SetchaineConnexion(ConfigurationManager.ConnectionStrings
            ["Eleve"]);

            List<Eleve> liste = new List<Eleve>();
            liste = GestionEleves.GetEleves();

            listeEleves.ValueMember = "Id_eleve";

            listeEleves.DisplayMember = "Nom";

            listeEleves.DataSource = liste;
        }

        private void btnActualiserListeEleve_Click(object sender, EventArgs e)
        {
            List<Visite> liste = new List<Visite>();
            liste = GestionVisites.GetVisites();
            // Rattachement de la List à la source de données du datagridview

            tableauVisite.DataSource = liste;
        }

        private void tableauVisite_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Blocage de la génération automatique des colonnes

            tableauVisite.AutoGenerateColumns = true;


            List<Visite> liste = new List<Visite>();
            liste = GestionVisites.GetVisites();
            // Rattachement de la List à la source de données du datagridview

            tableauVisite.DataSource = liste;
        }

        private void btnRetour_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menu mm = new Menu();
            mm.Show();
        }

        private void Vue_des_visites_Load(object sender, EventArgs e)
        {
            List<Visite> liste = new List<Visite>();
            liste = GestionVisites.GetVisites();
            // Rattachement de la List à la source de données du datagridview

            tableauVisite.DataSource = liste;
        }

        private void btnPrescription_Click(object sender, EventArgs e)
        {
            int RowIndex = tableauVisite.CurrentCell.RowIndex;
            int indexRow = RowIndex;
            DataGridViewRow selectedRow = tableauVisite.Rows[indexRow];

            this.Hide();
            Vue_des_prescriptions mse = new Vue_des_prescriptions((int)selectedRow.Cells[0].Value);
            mse.Show();
        }

        private void tableauVisite_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int indexRow = e.RowIndex;
            DataGridViewRow selectedRow = tableauVisite.Rows[indexRow];

            listeEleves.Text = selectedRow.Cells[1].Value.ToString();
            saisieDateDeb.Text = selectedRow.Cells[2].Value.ToString();
            saisieDateFin.Text = selectedRow.Cells[3].Value.ToString();
            saisieMotifVisite.Text = selectedRow.Cells[4].Value.ToString();
            saisieCommentaireVisite.Text = selectedRow.Cells[5].Value.ToString();

        }

        private void listeEleves_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnModifierListeEleves_Click(object sender, EventArgs e)
        {

            if (radioHopitalVisite.Checked && radioParentsOui.Checked && !radioParentsNon.Checked && !radioPasSuiteVisite.Checked)
            {
                int RowIndex = tableauVisite.CurrentCell.RowIndex;
                int indexRow = RowIndex;
                DataGridViewRow selectedRow = tableauVisite.Rows[indexRow];

                // Création de l'objet Utilisateur avec le nom récupéré dans la GUI
                Visite uneVisite = new Visite((int)selectedRow.Cells[0].Value, (Eleve)listeEleves.SelectedItem, saisieDateDeb.Value.TimeOfDay, saisieDateFin.Value.TimeOfDay, saisieMotifVisite.Text, saisieCommentaireVisite.Text, true, true); ;
                // Appel de la méthode CreerUtilisateur de la couche BLL
                GestionVisites.ModifierVisite(uneVisite);
                MessageBox.Show("La visite de " + listeEleves.Text + " a bien été enregistré(e)");
            }
            else if (radioHopitalVisite.Checked && radioParentsNon.Checked && !radioParentsOui.Checked && !radioPasSuiteVisite.Checked)
            {
                int RowIndex = tableauVisite.CurrentCell.RowIndex;
                int indexRow = RowIndex;
                DataGridViewRow selectedRow = tableauVisite.Rows[indexRow];

                // Création de l'objet Utilisateur avec le nom récupéré dans la GUI
                Visite uneVisite = new Visite((int)selectedRow.Cells[0].Value, (Eleve)listeEleves.SelectedItem, saisieDateDeb.Value.TimeOfDay, saisieDateFin.Value.TimeOfDay, saisieMotifVisite.Text, saisieCommentaireVisite.Text, true, false); ;
                // Appel de la méthode CreerUtilisateur de la couche BLL
                GestionVisites.ModifierVisite(uneVisite);
                MessageBox.Show("La visite de " + listeEleves.SelectedItem + " a bien été enregistré(e)");

            }


            if (radioPasSuiteVisite.Checked && radioParentsNon.Checked && !radioParentsOui.Checked && !radioHopitalVisite.Checked)
            {
                int RowIndex = tableauVisite.CurrentCell.RowIndex;
                int indexRow = RowIndex;
                DataGridViewRow selectedRow = tableauVisite.Rows[indexRow];

                // Création de l'objet Utilisateur avec le nom récupéré dans la GUI
                Visite uneVisite = new Visite((int)selectedRow.Cells[0].Value, (Eleve)listeEleves.SelectedItem, saisieDateDeb.Value.TimeOfDay, saisieDateFin.Value.TimeOfDay, saisieMotifVisite.Text, saisieCommentaireVisite.Text, false, false); ;
                // Appel de la méthode CreerUtilisateur de la couche BLL
                GestionVisites.ModifierVisite(uneVisite);
                MessageBox.Show("La visite de " + listeEleves.SelectedItem + " a bien été enregistré(e)");

            }
            else if (radioPasSuiteVisite.Checked && radioParentsOui.Checked && !radioParentsNon.Checked && !radioHopitalVisite.Checked)
            {
                int RowIndex = tableauVisite.CurrentCell.RowIndex;
                int indexRow = RowIndex;
                DataGridViewRow selectedRow = tableauVisite.Rows[indexRow];

                // Création de l'objet Utilisateur avec le nom récupéré dans la GUI
                Visite uneVisite = new Visite((int)selectedRow.Cells[0].Value, (Eleve)listeEleves.SelectedItem, saisieDateDeb.Value.TimeOfDay, saisieDateFin.Value.TimeOfDay, saisieMotifVisite.Text, saisieCommentaireVisite.Text, false, true); ;
                // Appel de la méthode CreerUtilisateur de la couche BLL
                GestionVisites.ModifierVisite(uneVisite);
                MessageBox.Show("La visite de " + listeEleves.SelectedItem + " a bien été enregistré(e)");
            }


            List<Visite> liste = new List<Visite>();
            liste = GestionVisites.GetVisites();
            // Rattachement de la List à la source de données du datagridview

            tableauVisite.DataSource = liste;
        }
    }
}
