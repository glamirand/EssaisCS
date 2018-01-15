using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParcVehicule
{
    class Voiture:Vehicule
    {
        protected int nbPortes;

        public Voiture(string _immatriculation, string _marque, string _couleur, int _nbPortes) : base(_immatriculation,_marque,_couleur)
        {
            nbPortes = _nbPortes;
        }

        public override string ToString()
        {
            return base.ToString() +  " : voiture avec " +nbPortes + " portes";
        }
    }
}
