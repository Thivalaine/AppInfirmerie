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
    public class GestionVisites
    {
        private static GestionVisites uneGestionVisites; // objet BLL

        // Accesseur en lecture
        public static GestionVisites GetGestionVisites()
        {
            if (uneGestionVisites == null)
            {
                uneGestionVisites = new GestionVisites();
            }
            return uneGestionVisites;
        }

        // Définit la chaîne de connexion grâce à la méthode SetchaineConnexion de la DAL
        public static void SetchaineConnexion(ConnectionStringSettings chset)
        {
            string chaine = chset.ConnectionString;
            ConnexionBD.GetConnexionBD().SetchaineConnexion(chaine);
        }
        // Méthode qui renvoit une List d'objets Eleve en faisant appel à la méthode GetUtilisateurs() de la DAL
        public static List<Visite> GetVisites()
        {
            return VisiteDAO.GetVisites();
        }
        // Méthode qui renvoi l’objet Utilisateur en l'ajoutant à la
        // BD avec la méthode AjoutEleve de la DAL
        public static int CreerVisite(Visite uneVisite)
        {
            return VisiteDAO.AjoutVisite(uneVisite);
        }
        // Méthode qui modifie un nouvel Utilisateur avec la méthode UpdateEleve de la DAL
        public static int ModifierVisite(Visite uneVisite)
        {
            return VisiteDAO.ModifierVisite(uneVisite);
        }

        public static List<Classe> GetClasses()
        {
            return EleveDAO.GetClasses();
        }

        public static List<Eleve> GetEleves()
        {
            return EleveDAO.GetEleves();
        }

        public static List<Medicament> GetMedicaments()
        {
            return MedicamentDAO.GetMedicaments();
        }
    }
}
