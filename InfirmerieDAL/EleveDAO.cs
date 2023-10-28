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
            Classe id_classe;
            string nom_eleve;
            string prenom_eleve;
            DateTime date_nai_eleve;
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
            cmd.CommandText = " SELECT * FROM eleve INNER JOIN classe ON eleve.id_classe = classe.id_classe";
            SqlDataReader monReader = cmd.ExecuteReader();
            // Remplissage de la liste
            while (monReader.Read())
            {
                id_eleve = Int32.Parse(monReader["Id_eleve"].ToString());
                id_classe = new Classe((int)monReader["Id_classe"], monReader["Libelle_classe"].ToString());
                date_nai_eleve = (DateTime)monReader["Date_Nai_Eleve"];
                num_tel_eleve = Int32.Parse(monReader["Num_Tel_Eleve"].ToString());
                num_tel_parent_eleve = Int32.Parse(monReader["Num_Tel_Parent_Eleve"].ToString());
                tiers_temps_exam_eleve = Boolean.Parse(monReader["Tiers_Temps_Exam_Eleve"].ToString());
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

            cmd.CommandText = "INSERT INTO eleve(id_classe, nom_eleve, prenom_eleve, date_nai_eleve, num_tel_eleve, num_tel_parent_eleve, tiers_temps_exam_eleve, commentaire_eleve) values(@Id_classe, @Nom_eleve, @Prenom_eleve, @Date_nai_eleve, @Num_tel_eleve, @Num_tel_parent_eleve, @Tiers_temps_exam_eleve, @Commentaire_eleve)";

            cmd.Parameters.AddWithValue("@Id_classe",unEleve.Classe.Id_classe);
            cmd.Parameters.Add(new SqlParameter("@Nom_eleve", System.Data.SqlDbType.VarChar, 255));
            cmd.Parameters.Add(new SqlParameter("@Prenom_eleve", System.Data.SqlDbType.VarChar, 255));
            cmd.Parameters.Add(new SqlParameter("@Date_nai_eleve", System.Data.SqlDbType.DateTime, 50));
            cmd.Parameters.Add(new SqlParameter("@Num_tel_eleve", System.Data.SqlDbType.Int, 50));
            cmd.Parameters.Add(new SqlParameter("@Num_tel_parent_eleve", System.Data.SqlDbType.Int, 50));
            cmd.Parameters.Add(new SqlParameter("@Tiers_temps_exam_eleve", System.Data.SqlDbType.Bit, 50));
            cmd.Parameters.Add(new SqlParameter("@Commentaire_eleve", System.Data.SqlDbType.VarChar, 255));

            cmd.Parameters["@Nom_eleve"].Value = unEleve.Nom;
            cmd.Parameters["@Prenom_eleve"].Value = unEleve.Prenom;
            cmd.Parameters["@Date_nai_eleve"].Value = unEleve.Date_nai;
            cmd.Parameters["@Num_tel_eleve"].Value = unEleve.Num_tel;
            cmd.Parameters["@Num_tel_parent_eleve"].Value = unEleve.Num_tel_parent;
            cmd.Parameters["@Tiers_temps_exam_eleve"].Value = unEleve.Tiers_temps_exam;
            cmd.Parameters["@Commentaire_eleve"].Value = unEleve.Commentaire;

            nbEnr = cmd.ExecuteNonQuery();
            // Fermeture de la connexion
            maConnexion.Close();
            return nbEnr;
        }
        // Cette méthode modifie un utilisateur passé en paramètre dans la BD
        public static int ModifierEleve(Eleve unEleve)
        {
            int nbEnr;
            SqlConnection maConnexion =
            ConnexionBD.GetConnexionBD().GetSqlConnexion();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = maConnexion;

            cmd.CommandText = "UPDATE eleve SET id_classe = @Id_classe, nom_eleve = @Nom_eleve, prenom_eleve = @Prenom_eleve, date_nai_eleve = @Date_nai_eleve, num_tel_eleve = @Num_tel_eleve, num_tel_parent_eleve = @Num_tel_parent_eleve, tiers_temps_exam_eleve = @Tiers_temps_exam_eleve, commentaire_eleve = @Commentaire_eleve WHERE id_eleve = @Id";
            cmd.Parameters.AddWithValue("@Id_classe", unEleve.Classe.Id_classe);
            cmd.Parameters.AddWithValue("@Nom_eleve", unEleve.Nom);
            cmd.Parameters.AddWithValue("@Prenom_eleve", unEleve.Prenom);
            cmd.Parameters.AddWithValue("@Date_nai_eleve", unEleve.Date_nai);
            cmd.Parameters.AddWithValue("@Num_tel_eleve", unEleve.Num_tel);
            cmd.Parameters.AddWithValue("@Num_tel_parent_eleve", unEleve.Num_tel_parent);
            cmd.Parameters.AddWithValue("@Tiers_temps_exam_eleve", unEleve.Tiers_temps_exam);
            cmd.Parameters.AddWithValue("@Commentaire_eleve", unEleve.Commentaire);
            cmd.Parameters.AddWithValue("@Id", unEleve.Id);
            nbEnr = cmd.ExecuteNonQuery();
            maConnexion.Close();
            return nbEnr;

        }
        // Cette méthode supprime de la BD un utilisateur dont l'id est passé en paramètre
        public static int SupprimerEleve(Eleve unEleve)
        {
            int nbEnr;
            // Connexion à la BD
            SqlConnection maConnexion = ConnexionBD.GetConnexionBD().GetSqlConnexion();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = maConnexion;
            cmd.CommandText = "DELETE FROM eleve WHERE id_eleve = @Id";
            cmd.Parameters.AddWithValue("@Id", unEleve.Id);
            nbEnr = cmd.ExecuteNonQuery();
            // Fermeture de la connexion
            maConnexion.Close();
            return nbEnr;
        }



        public static List<Classe> GetClasses()
        {
            int id_classe;
            string libelle_classe;

            Classe uneClasse;
            // Connexion à la BD
            SqlConnection maConnexion = ConnexionBD.GetConnexionBD().GetSqlConnexion();
            // Création d'une liste vide d'objets Utilisateurs
            List<Classe> lesClasses = new List<Classe>();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = maConnexion;
            cmd.CommandText = " SELECT * FROM Classe ";
            SqlDataReader monReader = cmd.ExecuteReader();
            // Remplissage de la liste
            while (monReader.Read())
            {
                id_classe = Int32.Parse(monReader["id_classe"].ToString());
                if (monReader["libelle_classe"] == DBNull.Value)
                {
                    libelle_classe = default(string);
                }
                else
                {
                    libelle_classe = monReader["libelle_classe"].ToString();
                }
                uneClasse = new Classe(id_classe, libelle_classe);
                lesClasses.Add(uneClasse);
            }
            // Fermeture de la connexion
            maConnexion.Close();
            return lesClasses;
        }
    }
}
