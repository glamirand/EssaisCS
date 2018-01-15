using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParcVehicule
{
    class Utilitaire:Vehicule
    {
        protected int volumeUtile;

        public Utilitaire(string _immatriculation, string _marque, string _couleur, int _volumeUtile) : base(_immatriculation, _marque, _couleur)
        {
            volumeUtile = _volumeUtile;
        }

        public override string ToString()
        {
            return base.ToString() + " : utilitaire de " + volumeUtile + " m3";
        }
    }
}
