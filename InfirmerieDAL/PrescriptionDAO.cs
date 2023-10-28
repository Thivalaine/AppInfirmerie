using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InfirmerieBO;
using System.Data.SqlClient;

namespace InfirmerieDAL
{
    public class PrescriptionDAO
    {
        private static PrescriptionDAO unePrescriptionDAO;
        // Accesseur en lecture, renvoi une instance
        public static PrescriptionDAO GetunePrescriptionDAO()
        {
            if (unePrescriptionDAO == null)
            {
                unePrescriptionDAO = new PrescriptionDAO();
            }
            return unePrescriptionDAO;
        }

        // Cette méthode retourne une List contenant les objets Utilisateurs contenus dans la table Identification
        public static List<Prescription> GetPrescriptions(int i)
        {
            Medicament Medicament;
            int quantite;

            Prescription unePrescription;
            // Connexion à la BD
            SqlConnection maConnexion = ConnexionBD.GetConnexionBD().GetSqlConnexion();
            // Création d'une liste vide d'objets Utilisateurs
            List<Prescription> lesPrescriptions = new List<Prescription>();
            List<Visite> lesVisites = new List<Visite>();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = maConnexion;
            cmd.CommandText = " SELECT * FROM prescrire LEFT JOIN visite ON prescrire.#id_visite = visite.id_visite RIGHT JOIN medicament ON prescrire.#id_medic = medicament.id_medic WHERE #id_visite = @Id_visite";
            cmd.Parameters.AddWithValue("@Id_visite", i);
            SqlDataReader monReader = cmd.ExecuteReader();
            // Remplissage de la liste
            while (monReader.Read())
            {
                i = (int)monReader["Id_visite"];
                Medicament = new Medicament(int.Parse(monReader["Id_medic"].ToString()), monReader["Libelle_medic"].ToString());
                quantite = (int)monReader["Quantite"];

                unePrescription = new Prescription(i, Medicament, quantite);
                lesPrescriptions.Add(unePrescription);
            }
            // Fermeture de la connexion
            maConnexion.Close();
            return lesPrescriptions;
        }

        public static int AjoutPrescription(Prescription unePrescription)
        {
            int nbEnr;


            // Connexion à la BD
            SqlConnection maConnexion =
           ConnexionBD.GetConnexionBD().GetSqlConnexion();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = maConnexion;

            cmd.CommandText = "INSERT INTO prescrire (#id_visite, #id_medic, quantite) values(@Id_visite, @Id_medic, @Quantite)";

            cmd.Parameters.AddWithValue("@Id_visite", unePrescription.Id_visite);
            cmd.Parameters.AddWithValue("@Id_medic", unePrescription.Medicament.Id_medic);
            cmd.Parameters.AddWithValue("@Quantite", unePrescription.Quantite);

            nbEnr = cmd.ExecuteNonQuery();
            // Fermeture de la connexion
            maConnexion.Close();
            return nbEnr;
        }

        public static int ModifierPrescription(Prescription unePrescription)
        {
            int nbEnr;
            SqlConnection maConnexion =
            ConnexionBD.GetConnexionBD().GetSqlConnexion();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = maConnexion;

            cmd.CommandText = "UPDATE prescrire SET #id_medic = @Id_medic, quantite = @Quantite WHERE #id_visite = @Id_visite";
            cmd.Parameters.AddWithValue("@Id_visite", unePrescription.Id_visite);
            cmd.Parameters.AddWithValue("@Id_medic", unePrescription.Medicament.Id_medic);
            cmd.Parameters.AddWithValue("@Quantite", unePrescription.Quantite);
            nbEnr = cmd.ExecuteNonQuery();
            maConnexion.Close();
            return nbEnr;

        }

        public static int SupprimerPrescription(Prescription unePrescription)
        {
            int nbEnr;
            // Connexion à la BD
            SqlConnection maConnexion = ConnexionBD.GetConnexionBD().GetSqlConnexion();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = maConnexion;
            cmd.CommandText = "DELETE FROM prescrire WHERE #id_visite = @Id_visite AND #id_medic = @Id_medic";
            cmd.Parameters.AddWithValue("@Id_visite", unePrescription.Id_visite);
            cmd.Parameters.AddWithValue("@Id_medic", unePrescription.Medicament.Id_medic);
            nbEnr = cmd.ExecuteNonQuery();
            // Fermeture de la connexion
            maConnexion.Close();
            return nbEnr;
        }

    }
}
