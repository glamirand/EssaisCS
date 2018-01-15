using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Liste
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Liste");
            List<int> maListe = new List<int>();
            maListe.Add(5);
            maListe.Add(7);
            maListe.Add(3);

            Console.WriteLine(maListe.Count);
            foreach (int nb in maListe)
            {
                Console.WriteLine(nb);
            }
            maListe.RemoveAt(maListe.IndexOf(7));
            Console.WriteLine(maListe.Count);
            foreach (int nb in maListe)
            {
                Console.WriteLine(nb);
            }
            Console.ReadKey();
        }
    }
}
