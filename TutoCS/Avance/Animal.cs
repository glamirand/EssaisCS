using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Avance
{
    public abstract class Animal
    {
        protected String nom;
        protected int age;
        protected String couleur;
        public static int nbAnimaux = 
            0;
        public Animal(string _nom, int _age, string _couleur)
        {
            nom = _nom;
            age = _age;
            couleur = _couleur;
            nbAnimaux++;
        }

        public void Vieillir()
        {
            age++;
            Console.WriteLine(nom + " a maintenant " + age + " ans.");
        }

        public abstract void FaireDuBruit();
}
}
