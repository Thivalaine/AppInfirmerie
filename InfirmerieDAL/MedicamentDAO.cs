using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InfirmerieBO;
using System.Data.SqlClient;

namespace InfirmerieDAL
{
    public class MedicamentDAO
    {
        private static MedicamentDAO unMedicamentDAO;
        // Accesseur en lecture, renvoi une instance
        public static MedicamentDAO GetunMedicamentDAO()
        {
            if (unMedicamentDAO == null)
            {
                unMedicamentDAO = new MedicamentDAO();
            }
            return unMedicamentDAO;
        }

        // Cette méthode retourne une List contenant les objets Utilisateurs contenus dans la table Identification
        public static List<Medicament> GetMedicaments()
        {
            int id_medic;
            string libelle_medic;

            Medicament unMedicament;
            // Connexion à la BD
            SqlConnection maConnexion = ConnexionBD.GetConnexionBD().GetSqlConnexion();
            // Création d'une liste vide d'objets Utilisateurs
            List<Medicament> lesMedicaments = new List<Medicament>();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = maConnexion;
            cmd.CommandText = " SELECT * FROM medicament ";
            SqlDataReader monReader = cmd.ExecuteReader();
            // Remplissage de la liste
            while (monReader.Read())
            {
                id_medic = Int32.Parse(monReader["Id_medic"].ToString());
                
                if (monReader["Libelle_medic"] == DBNull.Value)
                {
                    libelle_medic = default(string);
                }
                else
                {
                    libelle_medic = monReader["Libelle_medic"].ToString();
                }
                unMedicament = new Medicament(id_medic, libelle_medic);
                lesMedicaments.Add(unMedicament);
            }
            // Fermeture de la connexion
            maConnexion.Close();
            return lesMedicaments;
        }

        // Cette méthode insert un nouvel utilisateur passé en paramètre dans la BD
        public static int AjoutMedicament(Medicament unMedicament)
        {
            int nbEnr;


            // Connexion à la BD
            SqlConnection maConnexion =
           ConnexionBD.GetConnexionBD().GetSqlConnexion();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = maConnexion;

            cmd.CommandText = "INSERT INTO medicament(libelle_medic) values(@Libelle_medic)";

            cmd.Parameters.Add(new SqlParameter("@Libelle_medic", System.Data.SqlDbType.VarChar, 255));
            cmd.Parameters["@Libelle_medic"].Value = unMedicament.Libelle_medic;

            nbEnr = cmd.ExecuteNonQuery();
            // Fermeture de la connexion
            maConnexion.Close();
            return nbEnr;
        }
        // Cette méthode modifie un utilisateur passé en paramètre dans la BD
        public static int ModifierMedicament(Medicament unMedicament)
        {
            int nbEnr;
            SqlConnection maConnexion =
            ConnexionBD.GetConnexionBD().GetSqlConnexion();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = maConnexion;

            cmd.CommandText = "UPDATE medicament SET libelle_medic = @Libelle_medic WHERE id_medic = @Id_medic";
            cmd.Parameters.AddWithValue("@Libelle_medic", unMedicament.Libelle_medic);
            cmd.Parameters.AddWithValue("@Id_medic", unMedicament.Id_medic);
            nbEnr = cmd.ExecuteNonQuery();
            maConnexion.Close();
            return nbEnr;

        }
        // Cette méthode supprime de la BD un utilisateur dont l'id est passé en paramètre
        public static int SupprimerMedicament(Medicament unMedicament)
        {
            int nbEnr;
            // Connexion à la BD
            SqlConnection maConnexion = ConnexionBD.GetConnexionBD().GetSqlConnexion();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = maConnexion;
            cmd.CommandText = "DELETE FROM medicament WHERE id_medic = @Id_medic";
            cmd.Parameters.AddWithValue("@Id_medic", unMedicament.Id_medic);
            nbEnr = cmd.ExecuteNonQuery();
            // Fermeture de la connexion
            maConnexion.Close();
            return nbEnr;
        }

    }
}
