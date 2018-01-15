using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO
{
    public class Chat:Animal, IMord
    {
        



        /// <summary>
        /// Constructeur de chat à partir de son age
        /// </summary>
        /// <param name="_nom">Chaine représentant le nom</param>
        /// <param name="_age">Age en années</param>
        public Chat(string _nom, int _age,string _couleur) : base(_nom,_age,_couleur)
        {
        }

        public void Miauler()
        {
            Console.WriteLine(nom + " : Braouuuuu!");
        }

        public override void FaireDuBruit()
        {
            Miauler();

        }

        public void Mordre()
        {
            Console.WriteLine(nom + " vous fait des petits trous avec ses dents, ça fait très mal!");
        }
    }
}
