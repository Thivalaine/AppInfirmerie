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
using InfirmerieBO; // Référence la couche BO
using InfirmerieBLL; // Référence la couche BLL
using System.Data.SqlClient;
using InfirmerieDAL;

namespace InfirmerieGUI
{
    public partial class Module_de_saisie_des_visites : Form
    {
        public Module_de_saisie_des_visites()
        {
            InitializeComponent();
            // Récupération de chaîne de connexion à la BD à l'ouverture du formulaire
            GestionEleves.SetchaineConnexion(ConfigurationManager.ConnectionStrings
            ["Eleve"]);

            List<Eleve> liste = new List<Eleve>();
            liste = GestionVisites.GetEleves();

            listeEleves.ValueMember = "Id_eleve";

            listeEleves.DisplayMember = "Nom";

            listeEleves.DataSource = liste;

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            saisieDateDeb.Format = saisieDateDeb.Format;
            saisieDateDeb.CustomFormat = "HH:mm tt";
        }

        private void boutonSoumettre_Click(object sender, EventArgs e)
        {
            if (radioHopitalVisite.Checked && radioParentsOui.Checked)
            {
                // Création de l'objet Utilisateur avec le nom récupéré dans la GUI
                Visite uneVisite = new Visite((Eleve)listeEleves.SelectedItem, saisieDateDeb.Value.TimeOfDay, saisieDateFin.Value.TimeOfDay, saisieMotifVisite.Text, saisieCommentaireVisite.Text, true, true); ;
                // Appel de la méthode CreerUtilisateur de la couche BLL
                GestionVisites.CreerVisite(uneVisite);
                MessageBox.Show("La visite de " + listeEleves.SelectedItem + " a bien été enregistrée");

            }
            else if (radioHopitalVisite.Checked && radioParentsOui.Checked && !radioParentsNon.Checked && !radioPasSuiteVisite.Checked)
            {
                // Création de l'objet Utilisateur avec le nom récupéré dans la GUI
                Visite uneVisite = new Visite((Eleve)listeEleves.SelectedItem, saisieDateDeb.Value.TimeOfDay, saisieDateFin.Value.TimeOfDay, saisieMotifVisite.Text, saisieCommentaireVisite.Text, true, true); ;
                // Appel de la méthode CreerUtilisateur de la couche BLL
                GestionVisites.CreerVisite(uneVisite);
                MessageBox.Show("La visite de " + listeEleves.Text + " a bien été enregistrée");

            }
            else if (radioHopitalVisite.Checked && radioParentsNon.Checked && !radioParentsOui.Checked && !radioPasSuiteVisite.Checked)
            {

                // Création de l'objet Utilisateur avec le nom récupéré dans la GUI
                Visite uneVisite = new Visite((Eleve)listeEleves.SelectedItem, saisieDateDeb.Value.TimeOfDay, saisieDateFin.Value.TimeOfDay, saisieMotifVisite.Text, saisieCommentaireVisite.Text, true, false); ;
                // Appel de la méthode CreerUtilisateur de la couche BLL
                GestionVisites.CreerVisite(uneVisite);
                MessageBox.Show("La visite de " + listeEleves.SelectedItem + " a bien été enregistrée");

            }


            if (radioPasSuiteVisite.Checked && radioParentsNon.Checked && !radioParentsOui.Checked && !radioHopitalVisite.Checked)
            {
                // Création de l'objet Utilisateur avec le nom récupéré dans la GUI
                Visite uneVisite = new Visite((Eleve)listeEleves.SelectedItem, saisieDateDeb.Value.TimeOfDay, saisieDateFin.Value.TimeOfDay, saisieMotifVisite.Text, saisieCommentaireVisite.Text, false, false); ;
                // Appel de la méthode CreerUtilisateur de la couche BLL
                GestionVisites.CreerVisite(uneVisite);
                MessageBox.Show("La visite de " + listeEleves.SelectedItem + " a bien été enregistrée");

            }
            else if (radioPasSuiteVisite.Checked && radioParentsOui.Checked && !radioParentsNon.Checked && !radioHopitalVisite.Checked)
            {
                // Création de l'objet Utilisateur avec le nom récupéré dans la GUI
                Visite uneVisite = new Visite((Eleve)listeEleves.SelectedItem, saisieDateDeb.Value.TimeOfDay, saisieDateFin.Value.TimeOfDay, saisieMotifVisite.Text, saisieCommentaireVisite.Text, false, true); ;
                // Appel de la méthode CreerUtilisateur de la couche BLL
                GestionVisites.CreerVisite(uneVisite);
                MessageBox.Show("La visite de " + listeEleves.SelectedItem + " a bien été enregistrée");

            }

        }

        private void listeMedicaments_SelectedIndexChanged(object sender, EventArgs e)
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
