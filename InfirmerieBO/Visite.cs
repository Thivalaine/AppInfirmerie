using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InfirmerieBO
{
    public class Visite
    {
        private int id_visite;
        private Eleve id_eleve;
        private TimeSpan heure_debut;
        private TimeSpan heure_fin;
        private string motif_visite;
        private string commentaire_visite;
        private bool suite_visite;
        private bool parent_prevenus;

        public Visite(Eleve Id_eleve, TimeSpan Heure_debut, TimeSpan Heure_fin, string Motif_visite, string Commentaire_visite, bool Suite_visite, bool Parent_prevenus)
        {
            id_eleve = Id_eleve;
            heure_debut = Heure_debut;
            heure_fin = Heure_fin;
            motif_visite = Motif_visite;
            commentaire_visite = Commentaire_visite;
            suite_visite = Suite_visite;
            parent_prevenus = Parent_prevenus;
        }

        public Visite(int Id_visite, Eleve Id_eleve, TimeSpan Heure_debut, TimeSpan Heure_fin, string Motif_visite, string Commentaire_visite, bool Suite_visite, bool Parent_prevenus)
        {
            id_visite = Id_visite;
            id_eleve = Id_eleve;
            heure_debut = Heure_debut;
            heure_fin = Heure_fin;
            motif_visite = Motif_visite;
            commentaire_visite = Commentaire_visite;
            suite_visite = Suite_visite;
            parent_prevenus = Parent_prevenus;
        }

        public Visite(int Id_visite)
        {
            id_visite = Id_visite;
        }


        public int Id_visite { get => id_visite; set => id_visite = value; }
        public Eleve Eleve { get => id_eleve; set => id_eleve = value; }
        public TimeSpan Heure_debut { get => heure_debut; set => heure_debut = value; }
        public TimeSpan Heure_fin { get => heure_fin; set => heure_fin = value; }
        public string Motif_visite { get => motif_visite; set => motif_visite = value; }
        public string Commentaire_visite { get => commentaire_visite; set => commentaire_visite = value; }
        public bool Suite_visite { get => suite_visite; set => suite_visite = value; }
        public bool Parent_prevenus { get => parent_prevenus; set => parent_prevenus = value; }





    }
}
