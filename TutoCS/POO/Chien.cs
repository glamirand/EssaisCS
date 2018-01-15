using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO
{
    public class Chien : Animal, IMord
    {
        public Chien(string _nom, int _age, string _couleur) : base(_nom, _age,_couleur)
        {

        }

        public void Aboyer()
        {
            Console.WriteLine(nom + " : Ouaf ouaf!");
        }

        public override string ToString()
        {
            return nom + " ("+age+" ans, "+couleur + ")";
        }

        public override void FaireDuBruit()
        {
            Aboyer();
        }

        public void Mordre()
        {
            Console.WriteLine(nom + " vous mords, vous saignez fort!");
        }
    }
}
