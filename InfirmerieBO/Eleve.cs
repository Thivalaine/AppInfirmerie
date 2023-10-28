using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InfirmerieBO
{
    public class Eleve
    {
        private int id_eleve;
        private Classe id_classe;
        private string nom_eleve;
        private string prenom_eleve;
        private DateTime date_nai_eleve;
        private int num_tel_eleve;
        private int num_tel_parent_eleve;
        private bool tiers_temps_exam_eleve;
        private string commentaire_eleve;

        public Eleve(Classe Id_classe, string Nom, string Prenom, DateTime Date_nai, int Num_tel, int Num_tel_parent, bool Tiers_temps_exam, string Commentaire)
        {
            id_classe = Id_classe;
            nom_eleve = Nom;
            prenom_eleve = Prenom;
            date_nai_eleve = Date_nai;
            num_tel_eleve = Num_tel;
            num_tel_parent_eleve = Num_tel_parent;
            tiers_temps_exam_eleve = Tiers_temps_exam;
            commentaire_eleve = Commentaire;
        }

        public Eleve(int Id, Classe Id_classe, string Nom, string Prenom, DateTime Date_nai, int Num_tel, int Num_tel_parent, bool Tiers_temps_exam, string Commentaire)
        {
            id_eleve = Id;
            id_classe = Id_classe;
            nom_eleve = Nom;
            prenom_eleve = Prenom;
            date_nai_eleve = Date_nai;
            num_tel_eleve = Num_tel;
            num_tel_parent_eleve = Num_tel_parent;
            tiers_temps_exam_eleve = Tiers_temps_exam;
            commentaire_eleve = Commentaire;
        }

        public Eleve(string Nom)
        {
            nom_eleve = Nom;
        }

        public override string ToString()
        {
            return nom_eleve;
        }


        public int Id { get => id_eleve; set => id_eleve = value; }
        public Classe Classe { get => id_classe; set => id_classe = value;  }
        public string Nom { get => nom_eleve; set => nom_eleve = value; }
        public string Prenom { get => prenom_eleve; set => prenom_eleve = value; }
        public DateTime Date_nai { get => date_nai_eleve; set => date_nai_eleve = value; }
        public int Num_tel { get => num_tel_eleve; set => num_tel_eleve = value; }
        public int Num_tel_parent { get => num_tel_parent_eleve; set => num_tel_parent_eleve = value; }
        public bool Tiers_temps_exam { get => tiers_temps_exam_eleve; set => tiers_temps_exam_eleve = value; }
        public string Commentaire { get => commentaire_eleve; set => commentaire_eleve = value; }
    }
}