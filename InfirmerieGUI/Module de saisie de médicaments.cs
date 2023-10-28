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
    public partial class Module_de_saisie_de_médicaments : Form
    {
        public Module_de_saisie_de_médicaments()
        {
            InitializeComponent();
            // Récupération de chaîne de connexion à la BD à l'ouverture du formulaire
            GestionMedicaments.SetchaineConnexion(ConfigurationManager.ConnectionStrings
            ["Eleve"]);
        }

        private void btnSoumettreMedicament_Click(object sender, EventArgs e)
        {
            Medicament unMedicament = new Medicament(saisieLibelle.Text);
            // Appel de la méthode CreerUtilisateur de la couche BLL
            GestionMedicaments.CreerMedicament(unMedicament);
            MessageBox.Show("Le médicament " + saisieLibelle.Text + " a bien été enregistré(e)");
        }

        private void saisieLibelle_TextChanged(object sender, EventArgs e)
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
