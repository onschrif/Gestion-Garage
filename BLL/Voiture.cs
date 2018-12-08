using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class Voiture:Automobile
    {
        public string couleur { get; set; }
        public string marque { get; set; }
        public string TypeV { get; set; }

        public Voiture()
        { }
        public Voiture(int annee, string immatriculation, string couleur, string marque, string TypeV)
        
            :base(annee, immatriculation)
                {
                this.couleur = couleur;
                this.marque = marque;
                this.TypeV = TypeV;
                }

        
       
    }
}
