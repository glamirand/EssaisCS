using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParcVehicule
{
    abstract class Vehicule
    {
        protected string immatriculation;
        protected string marque;
        protected string couleur;

        public string Immatriculation
        {
            get
            {
                return immatriculation;
            }
        }

        public Vehicule(string _immatriculation, string _marque, string _couleur)
        {
            immatriculation = _immatriculation;
            marque = _marque;
            couleur = _couleur;
        }

        public override string ToString()
        {
            return "véhicule " + immatriculation + " (" + marque + ", " + couleur + ")";
        }
    }
}
