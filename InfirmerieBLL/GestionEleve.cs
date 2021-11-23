using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;
using InfirmerieBO;
using InfirmerieDAL;
using System.Threading.Tasks;

namespace InfirmerieBLL
{
    public class GestionEleves
    {
        private static GestionEleves uneGestionEleves; // objet BLL

        // Accesseur en lecture
        public static GestionEleves GetGestionEleves()
        {
            if (uneGestionEleves == null)
            {
                uneGestionEleves = new GestionEleves();
            }
            return uneGestionEleves;
        }

        // Définit la chaîne de connexion grâce à la méthode SetchaineConnexion de la DAL
        public static void SetchaineConnexion(ConnectionStringSettings chset)
        {
            string chaine = chset.ConnectionString;
            ConnexionBD.GetConnexionBD().SetchaineConnexion(chaine);
        }
        // Méthode qui renvoit une List d'objets Eleve en faisant appel à la méthode GetUtilisateurs() de la DAL
        public static List<Eleve> GetEleves()
        {
            return EleveDAO.GetEleves();
        }
        // Méthode qui renvoi l’objet Utilisateur en l'ajoutant à la
        // BD avec la méthode AjoutEleve de la DAL
        public static int CreerEleve(Eleve ut)
        {
            return EleveDAO.AjoutEleve(ut);
        }
        // Méthode qui modifie un nouvel Utilisateur avec la méthode UpdateEleve de la DAL
        public static int ModifierEleve(Eleve ut)
        {
            return EleveDAO.UpdateEleve(ut);
        }
        // Méthode qui supprime un Utilisateur avec la méthode DeleteEleve de la DAL
        public static int SupprimerEleve(int id)
        {
            return EleveDAO.DeleteEleve(id);
        }
    }
}