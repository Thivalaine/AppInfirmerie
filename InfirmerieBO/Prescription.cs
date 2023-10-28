using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InfirmerieBO
{
    public class Prescription
    {
        int id_visite;
        Medicament id_medic;
        private int quantite;

        public Prescription(int Id_visite, Medicament Id_medic, int Quantite)
        {
            id_visite = Id_visite;
            id_medic = Id_medic;
            quantite = Quantite;

        }


        public int Id_visite { get => id_visite; set => id_visite = value; }
        public Medicament Medicament { get => id_medic; set => id_medic = value; }
        public int Quantite { get => quantite; set => quantite = value; }
    }
}
