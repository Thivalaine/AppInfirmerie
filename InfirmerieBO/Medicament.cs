using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InfirmerieBO
{
    public class Medicament
    {
        private int id_medic;
        private string libelle_medic;

        public Medicament(string Libelle_medic)
        {
            libelle_medic = Libelle_medic;
        }

        public Medicament(int Id_medic, string Libelle_medic)
        {
            id_medic = Id_medic;
            libelle_medic = Libelle_medic; 
        }

        public override string ToString()
        {
            return libelle_medic;
        }


        public int Id_medic { get => id_medic; set => id_medic = value; }
        public string Libelle_medic { get => libelle_medic; set => libelle_medic = value; }
        
    }
}
