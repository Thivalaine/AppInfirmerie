using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;
using InfirmerieDAL;
using InfirmerieBO; // Référence la couche BO
using InfirmerieBLL; // Référence la couche BLL

namespace InfirmerieGUI
{
    public partial class Authentification : Form
    {
        public Authentification()
        {
            InitializeComponent();
            GestionEleves.SetchaineConnexion(ConfigurationManager.ConnectionStrings
           ["Eleve"]);

        }

        private void btnConnexion_Click(object sender, EventArgs e)
        {
            using (SqlConnection maConnexion = ConnexionBD.GetConnexionBD().GetSqlConnexion())
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = maConnexion;
                SqlDataAdapter ds = new SqlDataAdapter("SELECT count(*) FROM utilisateur WHERE login_utilisateur = '" + saisieIdentifiant.Text + "' AND mdp_utilisateur = '" + saisieMDP.Text + "'", maConnexion);
                DataTable dt = new DataTable();
                ds.Fill(dt);
                if (dt.Rows[0][0].ToString() == "1")
                {
                    this.Hide();
                    Menu mm = new Menu();
                    mm.Show();
                    maConnexion.Close();
                }
                else
                {
                    MessageBox.Show("Compte incorrect !", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    maConnexion.Close();
                }

            }
        }

        private void saisieIdentifiant_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void saisieMDP_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
