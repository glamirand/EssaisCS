using System;

namespace Decompte
{
    class Program
    {
        static void Main(string[] args)
        {
int nombre = 0;
            bool nombreOk = false;
            while (!nombreOk)
            {
            Console.Clear();
            Console.Write("Entrez un nombre : ");
            nombreOk = int.TryParse(Console.ReadLine(),out nombre) & nombre>0;
            }
            for (int i = nombre; i >= 0; i--)
            {
                Console.WriteLine(i);
            }
            Console.ReadKey();
        }
    }
}
