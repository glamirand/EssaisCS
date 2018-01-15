using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO
{
    class Program
    {
        static void Main(string[] args)
        {
            Chat monChat = new Chat("Pixel",3,"Rous tigré");
            Chat chaton = new Chat("Chaton", 25,"Roux tigré");
            Chien medor = new Chien("Medor", 8, "Noir et blanc");
            IMord toto = new Chien("Rex", 6, "Noir");
            Console.WriteLine(Animal.nbAnimaux);
            //Animal jimbo = new Animal("Jimbo,9", "Blanc");
            monChat.Miauler();
            chaton.Miauler();
            monChat.Vieillir();
            medor.Aboyer();
            medor.Vieillir();

            Console.WriteLine(medor);

            monChat.FaireDuBruit();
            chaton.FaireDuBruit();
            medor.FaireDuBruit();

            monChat.Mordre();
            medor.Mordre();
            toto.Mordre();

 Console.ReadKey();

        }
    }
}
