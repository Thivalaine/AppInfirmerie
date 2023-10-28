using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InfirmerieBO;
using System.Data.SqlClient;

namespace InfirmerieDAL
{
    public class VisiteDAO
    {
        private static VisiteDAO uneVisiteDAO;
        // Accesseur en lecture, renvoi une instance
        public static VisiteDAO GetuneVisiteDAO()
        {
            if (uneVisiteDAO == null)
            {
                uneVisiteDAO = new VisiteDAO();
            }
            return uneVisiteDAO;
        }

        // Cette méthode retourne une List contenant les objets Utilisateurs contenus dans la table Identification
        public static List<Visite> GetVisites()
        {
            // visite
            int id_visite;
            Eleve Id;
            TimeSpan heure_debut;
            TimeSpan heure_fin;
            string motif_visite;
            string commentaire_visite;
            bool suite_visite;
            bool parent_prevenus;

            //eleve

            int id_eleve;
            Classe id_classe;
            string nom_eleve;
            string prenom_eleve;
            DateTime date_nai_eleve;
            int num_tel_eleve;
            int num_tel_parent_eleve;
            bool tiers_temps_exam_eleve;
            string commentaire_eleve;

            Visite uneVisite;

            // Connexion à la BD
            SqlConnection maConnexion = ConnexionBD.GetConnexionBD().GetSqlConnexion();
            // Création d'une liste vide d'objets Utilisateurs
            List<Visite> lesVisites = new List<Visite>();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = maConnexion;
            cmd.CommandText = " SELECT visite.*,eleve.*,classe.* FROM classe INNER JOIN eleve ON classe.id_classe = eleve.id_classe INNER JOIN visite ON eleve.id_eleve = visite.#id_eleve WHERE visite.#id_eleve = eleve.id_eleve ORDER BY visite.id_visite";
            SqlDataReader monReader = cmd.ExecuteReader();
            // Remplissage de la liste
            while (monReader.Read())
            {
                // Visite

                id_visite = Int32.Parse(monReader["Id_visite"].ToString());
                heure_debut = (TimeSpan)monReader["Heure_debut"];
                heure_fin = (TimeSpan)monReader["Heure_fin"];
                motif_visite = monReader["Motif_visite"].ToString();
                commentaire_visite = monReader["Commentaire_visite"].ToString();
                suite_visite = Boolean.Parse(monReader["Suite_visite"].ToString());
                parent_prevenus = Boolean.Parse(monReader["Parent_prevenus"].ToString());

                // eleve

                id_eleve = Int32.Parse(monReader["Id_eleve"].ToString());
                date_nai_eleve = (DateTime)monReader["Date_Nai_Eleve"];
                num_tel_eleve = Int32.Parse(monReader["Num_Tel_Eleve"].ToString());
                num_tel_parent_eleve = Int32.Parse(monReader["Num_Tel_Parent_Eleve"].ToString());
                tiers_temps_exam_eleve = Boolean.Parse(monReader["Tiers_Temps_Exam_Eleve"].ToString());


                    if (monReader["Motif_visite"] == DBNull.Value && monReader["Commentaire_visite"] == DBNull.Value && monReader["Nom_Eleve"] == DBNull.Value || monReader["Prenom_Eleve"] == DBNull.Value || monReader["Commentaire_Eleve"] == DBNull.Value)
                    {
                        //visite
                        motif_visite = default(string);
                        commentaire_visite = default(string);

                        //eleve
                        nom_eleve = default(string);
                        prenom_eleve = default(string);
                        commentaire_eleve = default(string);

                    }
                    else
                    {
                        //visite
                        motif_visite = monReader["Motif_visite"].ToString();
                        commentaire_visite = monReader["Commentaire_visite"].ToString();

                        //eleve
                        nom_eleve = monReader["Nom_Eleve"].ToString();
                        prenom_eleve = monReader["Prenom_Eleve"].ToString();
                        commentaire_eleve = monReader["Commentaire_Eleve"].ToString();

                    }

                id_classe = new Classe((int)monReader["Id_classe"], monReader["Libelle_classe"].ToString());

                Id = new Eleve(id_eleve, id_classe, nom_eleve, prenom_eleve, date_nai_eleve, num_tel_eleve, num_tel_parent_eleve, tiers_temps_exam_eleve, commentaire_eleve);

                uneVisite = new Visite(id_visite, Id, heure_debut, heure_fin, motif_visite, commentaire_visite, suite_visite, parent_prevenus);

                lesVisites.Add(uneVisite);
            }
            // Fermeture de la connexion
            maConnexion.Close();
            return lesVisites;
        }

        // Cette méthode insert un nouvel utilisateur passé en paramètre dans la BD
        public static int AjoutVisite(Visite uneVisite)
        {
            int nbEnr;


            // Connexion à la BD
            SqlConnection maConnexion =
           ConnexionBD.GetConnexionBD().GetSqlConnexion();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = maConnexion;

            cmd.CommandText = "INSERT INTO visite(#id_eleve, heure_debut, heure_fin, motif_visite, commentaire_visite, suite_visite, parent_prevenus) values(@Id_eleve, @Heure_debut, @Heure_fin, @Motif_visite, @Commentaire_visite, @Suite_visite, @Parent_prevenus)";

            cmd.Parameters.AddWithValue("@Id_eleve", uneVisite.Eleve.Id);
            cmd.Parameters.Add(new SqlParameter("@Heure_debut", System.Data.SqlDbType.Time, 50));
            cmd.Parameters.Add(new SqlParameter("@Heure_fin", System.Data.SqlDbType.Time, 50));
            cmd.Parameters.Add(new SqlParameter("@Motif_visite", System.Data.SqlDbType.VarChar, 255));
            cmd.Parameters.Add(new SqlParameter("@Commentaire_visite", System.Data.SqlDbType.VarChar, 255));
            cmd.Parameters.Add(new SqlParameter("@Suite_visite", System.Data.SqlDbType.Bit, 255));
            cmd.Parameters.Add(new SqlParameter("@Parent_prevenus", System.Data.SqlDbType.Bit, 255));

            cmd.Parameters["@Heure_debut"].Value = uneVisite.Heure_debut;
            cmd.Parameters["@Heure_fin"].Value = uneVisite.Heure_fin;
            cmd.Parameters["@Motif_visite"].Value = uneVisite.Motif_visite;
            cmd.Parameters["@Commentaire_visite"].Value = uneVisite.Commentaire_visite;
            cmd.Parameters["@Suite_visite"].Value = uneVisite.Suite_visite;
            cmd.Parameters["@Parent_prevenus"].Value = uneVisite.Parent_prevenus;

            nbEnr = cmd.ExecuteNonQuery();
            // Fermeture de la connexion
            maConnexion.Close();
            return nbEnr;
        }
        // Cette méthode modifie un utilisateur passé en paramètre dans la BD
        public static int ModifierVisite(Visite uneVisite)
        {
            int nbEnr;
            SqlConnection maConnexion =
            ConnexionBD.GetConnexionBD().GetSqlConnexion();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = maConnexion;

            cmd.CommandText = "UPDATE visite SET #id_eleve = @Id_eleve, heure_debut = @Heure_debut, heure_fin = @Heure_fin, motif_visite = @Motif_visite, commentaire_visite = @Commentaire_visite, suite_visite = @Suite_visite, parent_prevenus = @Parent_prevenus WHERE id_visite = @Id";
            cmd.Parameters.Add(new SqlParameter("@Id", uneVisite.Id_visite));
            cmd.Parameters.AddWithValue("@Id_eleve", uneVisite.Eleve.Id);
            cmd.Parameters.Add(new SqlParameter("@Heure_debut", uneVisite.Heure_debut));
            cmd.Parameters.Add(new SqlParameter("@Heure_fin", uneVisite.Heure_fin));
            cmd.Parameters.Add(new SqlParameter("@Motif_visite", uneVisite.Motif_visite));
            cmd.Parameters.Add(new SqlParameter("@Commentaire_visite", uneVisite.Commentaire_visite));
            cmd.Parameters.Add(new SqlParameter("@Suite_visite", uneVisite.Suite_visite));
            cmd.Parameters.Add(new SqlParameter("@Parent_prevenus", uneVisite.Parent_prevenus));

            nbEnr = cmd.ExecuteNonQuery();
            maConnexion.Close();
            return nbEnr;

        }
    }
}
