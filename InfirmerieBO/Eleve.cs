using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InfirmerieBO
{
    public class Eleve
    {
        private int Id_eleve;
        private int Id_classe;
        private string Nom_eleve;
        private string Prenom_eleve;
        private int Date_nai_eleve;
        private int Num_tel_eleve;
        private int Num_tel_parent_eleve;
        private bool Tiers_temps_exam_eleve;
        private string Commentaire_eleve;

        public Eleve(string Nom_eleve)
        {
            Nom_eleve = Nom;
        }

        public Eleve(int Id, int Id_classe, string Nom_eleve, string Prenom_eleve, int Date_nai_eleve, int num_tel_eleve, int num_tel_parent_eleve, bool tiers_temps_exam_eleve, string commentaire_eleve)
        {
            Id_eleve = Id;
            Id_classe = Idc;
            Nom_eleve = Nom;
            Prenom_eleve = Prenom;
            Date_nai_eleve = Date_nai;
            Num_tel_eleve = Num_tel;
            Num_tel_parent_eleve = Num_tel_parent;
            Tiers_temps_exam_eleve = Tiers_temps_exam;
            Commentaire_eleve = Commentaire;
        }

        public int Id { get => Id_eleve; set => Id_eleve = value; }
        public int Idc { get => Id_classe; set => Id_classe = value;  }
        public string Nom { get => Nom_eleve; set => Nom_eleve = value; }
        public string Prenom { get => Prenom_eleve; set => Prenom_eleve = value; }
        public int Date_nai { get => Date_nai_eleve; set => Date_nai_eleve = value; }
        public int Num_tel { get => Num_tel_eleve; set => Num_tel_eleve = value; }
        public int Num_tel_parent { get => Num_tel_parent_eleve; set => Num_tel_parent_eleve = value; }
        public bool Tiers_temps_exam { get => Tiers_temps_exam_eleve; set => Tiers_temps_exam_eleve = value; }
        public string Commentaire { get => Commentaire_eleve; set => Commentaire_eleve = value; }
    }
}