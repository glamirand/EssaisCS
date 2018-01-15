using System;

namespace TirageDes
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Random ran = new Random();
            int aleatoire = 0;
            string key = "o";

            while (key == "o")
            {
            aleatoire = ran.Next(1, 7);
            Console.WriteLine("Nombre aléatoire tire : " + aleatoire);
            Console.Write("Nouveau tirage (o/n) ? : ");
            key = Console.ReadLine();
}
        }
    }
}
