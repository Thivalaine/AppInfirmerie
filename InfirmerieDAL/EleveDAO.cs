using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InfirmerieBO;
using System.Data.SqlClient;

namespace InfirmerieDAL
{
    public class EleveDAO
    {
        private static EleveDAO unEleveDAO;
        // Accesseur en lecture, renvoi une instance
        public static EleveDAO GetunEleveDAO()
        {
            if (unEleveDAO == null)
            {
                unEleveDAO = new EleveDAO();
            }
            return unEleveDAO;
        }

        // Cette méthode retourne une List contenant les objets Utilisateurs contenus dans la table Identification
        public static List<Eleve> GetEleves()
        {
            int id_eleve;
            int id_classe;
            string nom_eleve;
            string prenom_eleve;
            int date_nai_eleve;
            int num_tel_eleve;
            int num_tel_parent_eleve;
            bool tiers_temps_exam_eleve;
            string commentaire_eleve;

            Eleve unEleve;
            // Connexion à la BD
            SqlConnection maConnexion = ConnexionBD.GetConnexionBD().GetSqlConnexion();
            // Création d'une liste vide d'objets Utilisateurs
            List<Eleve> lesEleves = new List<Eleve>();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = maConnexion;
            cmd.CommandText = " SELECT * FROM Eleve ";
            SqlDataReader monReader = cmd.ExecuteReader();
            // Remplissage de la liste
            while (monReader.Read())
            {
                id_eleve = Int32.Parse(monReader["Id_Eleve"].ToString());
                id_classe = Int32.Parse(monReader["Id_Classe"].ToString());
                date_nai_eleve = (DateTime)monReader["Date_Nai_Eleve"];
                num_tel_eleve = Int32.Parse(monReader["Num_Tel_Eleve"].ToString());
                num_tel_parent_eleve = Int32.Parse(monReader["Num_Tel_Parent_Eleve"].ToString());
                tiers_temps_exam_eleve = bool.Parse(monReader["Tiers_Temps_Exam_Eleve"].ToString());
                if (monReader["Nom_Eleve"] == DBNull.Value || monReader["Prenom_Eleve"] == DBNull.Value || monReader["Commentaire_Eleve"] == DBNull.Value)
                {
                    nom_eleve = default(string);
                    prenom_eleve = default(string);
                    commentaire_eleve = default(string);
                }
                else
                {
                    nom_eleve = monReader["Nom_Eleve"].ToString();
                    prenom_eleve = monReader["Prenom_Eleve"].ToString();
                    commentaire_eleve = monReader["Commentaire_Eleve"].ToString();
                }
                unEleve = new Eleve(id_eleve, id_classe, nom_eleve, prenom_eleve, date_nai_eleve, num_tel_eleve, num_tel_parent_eleve, tiers_temps_exam_eleve, commentaire_eleve);
                lesEleves.Add(unEleve);
            }
            // Fermeture de la connexion
            maConnexion.Close();
            return lesEleves;
        }

        // Cette méthode insert un nouvel utilisateur passé en paramètre dans la BD
        public static int AjoutEleve(Eleve unEleve)
        {
            int nbEnr;
            // Connexion à la BD
            SqlConnection maConnexion =
           ConnexionBD.GetConnexionBD().GetSqlConnexion();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = maConnexion;
            cmd.CommandText = "INSERT INTO Eleve values('" + unEleve.Idc + "' + '" + unEleve.Nom + "' + '" + unEleve.Prenom + "' + '" + unEleve.Date_nai + "' + '" + unEleve.Num_tel + "' + '" + unEleve.Num_tel_parent + "' + '" + unEleve.Tiers_temps_exam + "' + '" + unEleve.Commentaire + "')";
            nbEnr = cmd.ExecuteNonQuery();
            // Fermeture de la connexion
            maConnexion.Close();
            return nbEnr;
        }
        // Cette méthode modifie un utilisateur passé en paramètre dans la BD
        public static int UpdateEleve(Eleve unEleve)
        {
            int nbEnr;
            // Connexion à la BD
            SqlConnection maConnexion = ConnexionBD.GetConnexionBD().GetSqlConnexion();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = maConnexion;
            cmd.CommandText = "UPDATE Eleve SET Nom_eleve = '" + unEleve.Nom + "' WHERE Id_eleve = " + unEleve.Id;
            nbEnr = cmd.ExecuteNonQuery();
            // Fermeture de la connexion
            maConnexion.Close();
            return nbEnr;
        }
        // Cette méthode supprime de la BD un utilisateur dont l'id est passé en paramètre
        public static int DeleteEleve(int id)
        {
            int nbEnr;
            // Connexion à la BD
            SqlConnection maConnexion = ConnexionBD.GetConnexionBD().GetSqlConnexion();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = maConnexion;
            cmd.CommandText = "DELETE FROM Eleve WHERE id_eleve = " + id;
            nbEnr = cmd.ExecuteNonQuery();
            // Fermeture de la connexion
            maConnexion.Close();
            return nbEnr;
        }
    }
}
