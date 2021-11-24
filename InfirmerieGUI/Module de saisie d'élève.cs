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
        }

        private void saisieNom_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void saisiePrenom_TextChanged(object sender, EventArgs e)
        {

        }

        private void saisieDateEleve_ValueChanged(object sender, EventArgs e)
        {
            DateTime dt = saisieDateEleve.Value;
            string dtS = dt.Year.ToString() + dt.Month.ToString() + dt.Day.ToString();
            // you can just convert it to integer if there is a constraint
            int dtI = Convert.ToInt32(dtS);
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
                 DateTime dt = saisieDateEleve.Value;
                string dtS = dt.Year.ToString() + dt.Month.ToString() + dt.Day.ToString();
                // you can just convert it to integer if there is a constraint
                int dtI = Convert.ToInt32(dtS);
                
                // Création de l'objet Utilisateur avec le nom récupéré dans la GUI
                Eleve uti = new Eleve(Int32.Parse(saisieClasse.Text), saisieNom.Text, saisiePrenom.Text, dtI, Int32.Parse(saisieNumTel.Text), Int32.Parse(saisieNumTelParent.Text), true, saisieCommentaireSante.Text);
                // Appel de la méthode CreerUtilisateur de la couche BLL
                GestionEleves.CreerEleve(uti);
                MessageBox.Show("L'élève " + saisieNom + " " + saisiePrenom + "a bien été enregistré(e)");

            }
            else
            {
                 DateTime dt = saisieDateEleve.Value;
                 string dtS = dt.Year.ToString() + dt.Month.ToString() + dt.Day.ToString();
                // you can just convert it to integer if there is a constraint
                int dtI = Convert.ToInt32(dtS);

                
                // Création de l'objet Utilisateur avec le nom récupéré dans la GUI
                Eleve uti = new Eleve(Int32.Parse(saisieClasse.Text), saisieNom.Text, saisiePrenom.Text, dtI, Int32.Parse(saisieNumTel.Text), Int32.Parse(saisieNumTelParent.Text), false, saisieCommentaireSante.Text);
                // Appel de la méthode CreerUtilisateur de la couche BLL
                GestionEleves.CreerEleve(uti);
                MessageBox.Show("L'élève " + saisieNom + " " + saisiePrenom + "a bien été enregistré(e)");
            }
        }

        private void saisieClasse_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
