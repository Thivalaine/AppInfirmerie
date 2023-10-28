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
    public class GestionPrescriptions
    {
        private static GestionPrescriptions uneGestionPrescriptions; // objet BLL

        // Accesseur en lecture
        public static GestionPrescriptions GetGestionPrescriptions()
        {
            if (uneGestionPrescriptions == null)
            {
                uneGestionPrescriptions = new GestionPrescriptions();
            }
            return uneGestionPrescriptions;
        }

        // Définit la chaîne de connexion grâce à la méthode SetchaineConnexion de la DAL
        public static void SetchaineConnexion(ConnectionStringSettings chset)
        {
            string chaine = chset.ConnectionString;
            ConnexionBD.GetConnexionBD().SetchaineConnexion(chaine);
        }
        // Méthode qui renvoit une List d'objets Eleve en faisant appel à la méthode GetUtilisateurs() de la DAL
        public static List<Prescription> GetPrescriptions(int i)
        {
            return PrescriptionDAO.GetPrescriptions(i);
        }
        // Méthode qui renvoi l’objet Utilisateur en l'ajoutant à la
        // BD avec la méthode AjoutEleve de la DAL
        public static int ModifierPrescription(Prescription unePrescription)
        {
            return PrescriptionDAO.ModifierPrescription(unePrescription);
        }

        public static int SupprimerPrescription(Prescription unePrescription)
        {
            return PrescriptionDAO.SupprimerPrescription(unePrescription);
        }

        public static int AjoutPrescription(Prescription unePrescription)
        {
            return PrescriptionDAO.AjoutPrescription(unePrescription);
        }

    }
}
