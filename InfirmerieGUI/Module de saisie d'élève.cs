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
    public partial class Module_de_saisie_d_élève : Form
    {
        
        public Module_de_saisie_d_élève()
        {

            InitializeComponent();
     
            // Récupération de chaîne de connexion à la BD à l'ouverture du formulaire
            GestionEleves.SetchaineConnexion(ConfigurationManager.ConnectionStrings
            ["Eleve"]);
            List<Classe> liste = new List<Classe>();
            liste = GestionEleves.GetClasses();

            listeClasse.ValueMember = "Id";

            listeClasse.DisplayMember = "Libelle";

            listeClasse.DataSource = liste;
        }

        private void saisieNom_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void saisiePrenom_TextChanged(object sender, EventArgs e)
        {

        }

        private void saisieDateEleve_ValueChanged(object sender, EventArgs e)
        {

        }

        private void saisieNumTel_TextChanged(object sender, EventArgs e)
        {

        }

        private void saisieNumTelParent_TextChanged(object sender, EventArgs e)
        {

        }

        private void radioTiersTempsOui_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioTiersTempsNon_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void saisieCommentaireSante_TextChanged(object sender, EventArgs e)
        {

        }

        private void boutonSoumettre_Click(object sender, EventArgs e)
        {
            if (radioTiersTempsOui.Checked)
            {
                // Création de l'objet Utilisateur avec le nom récupéré dans la GUI
                Eleve uti = new Eleve((Classe)listeClasse.SelectedItem, saisieNom.Text, saisiePrenom.Text, saisieDateEleve.Value, int.Parse(saisieNumTel.Text), int.Parse(saisieNumTelParent.Text), true, saisieCommentaireSante.Text); ;
                // Appel de la méthode CreerUtilisateur de la couche BLL
                GestionEleves.CreerEleve(uti);
                MessageBox.Show("L'élève " + saisieNom + " " + saisiePrenom + " a bien été enregistré(e)");

            }
            else
            {

                // Création de l'objet Utilisateur avec le nom récupéré dans la GUI

                Eleve uti = new Eleve((Classe)listeClasse.SelectedItem, saisieNom.Text, saisiePrenom.Text, saisieDateEleve.Value, int.Parse(saisieNumTel.Text), int.Parse(saisieNumTelParent.Text), false, saisieCommentaireSante.Text);
                // Appel de la méthode CreerUtilisateur de la couche BLL
                GestionEleves.CreerEleve(uti);
                MessageBox.Show("L'élève " + saisieNom.Text + " " + saisiePrenom.Text + " a bien été enregistré(e)");

            }
        }

        private void Module_de_saisie_d_élève_Load(object sender, EventArgs e)
        {
            
        }

        private void listeClasse_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void btnRetour_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menu mm = new Menu();
            mm.Show();
        }

        private void labelNumTel_Click(object sender, EventArgs e)
        {

        }
    }
}
