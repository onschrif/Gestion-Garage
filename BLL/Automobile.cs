using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
   public class Automobile
    {
        int annee;
        string immatriculation;
        public int Annee
        {
            get { return annee; }
            set { annee = value; }
        }

        
        public string Immatriculation { get => immatriculation; set => immatriculation = value; }

        public Automobile()
        {
                
        }

        public Automobile(int annee, string immatriculation)
        {
            this.annee = annee;
            this.immatriculation = immatriculation;
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
