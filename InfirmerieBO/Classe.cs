using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InfirmerieBO
{
    public class Classe
    {
        private int id_classe;
        private string libelle_classe;

    public Classe(int id_classe, string libelle_classe)
    {
        this.id_classe = id_classe;
        this.libelle_classe = libelle_classe;   
    }

    public Classe(string libelle_classe)
    {
        this.libelle_classe = libelle_classe;
    }

    public override string ToString()
    {
        return libelle_classe;
    }

    public int Id_classe { get => id_classe; set => id_classe = value; }
    public string Libelle_classe { get => libelle_classe; set => libelle_classe = value; }
    }

}
