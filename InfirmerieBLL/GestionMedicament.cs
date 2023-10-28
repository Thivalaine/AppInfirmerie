using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InfirmerieBO;
using InfirmerieDAL;
using System.Configuration;

namespace InfirmerieBLL
{
    public class GestionMedicaments
    {
        private static GestionMedicaments uneGestionMedicaments; // objet BLL

        // Accesseur en lecture
        public static GestionMedicaments GetGestionMedicaments()
        {
            if (uneGestionMedicaments == null)
            {
                uneGestionMedicaments = new GestionMedicaments();
            }
            return uneGestionMedicaments;
        }

        // Définit la chaîne de connexion grâce à la méthode SetchaineConnexion de la DAL
        public static void SetchaineConnexion(ConnectionStringSettings chset)
        {
            string chaine = chset.ConnectionString;
            ConnexionBD.GetConnexionBD().SetchaineConnexion(chaine);
        }
        // Méthode qui renvoit une List d'objets Eleve en faisant appel à la méthode GetUtilisateurs() de la DAL
        public static List<Medicament> GetMedicaments()
        {
            return MedicamentDAO.GetMedicaments();
        }
        // Méthode qui renvoi l’objet Utilisateur en l'ajoutant à la
        // BD avec la méthode AjoutEleve de la DAL
        public static int CreerMedicament(Medicament unMedicament)
        {
            return MedicamentDAO.AjoutMedicament(unMedicament);
        }
        // Méthode qui modifie un nouvel Utilisateur avec la méthode UpdateEleve de la DAL
        public static int ModifierMedicament(Medicament unMedicament)
        {
            return MedicamentDAO.ModifierMedicament(unMedicament);
        }
        // Méthode qui supprime un Utilisateur avec la méthode DeleteEleve de la DAL
        public static int SupprimerMedicament(Medicament unMedicament)
        {
            return MedicamentDAO.SupprimerMedicament(unMedicament);
        }
    }
}
