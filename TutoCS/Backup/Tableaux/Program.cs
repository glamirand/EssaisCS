using System;

namespace Tableaux
{
    class Program
    {
        static void Main(string[] args)
        {
            /*int[] tab = new int[3];
            for (int i = 0; i < tab.Length; i++)
            {
                tab[i] = 3 * i;
            }
            foreach (int nb in tab)
            {
                Console.WriteLine(nb);
            }
            */

            int[,] matrice = new int[2, 2];
            for (int ligne = 0; ligne < 2; ligne++)
            {
                for (int col = 0; col < 2; col++)
                {
                    matrice[ligne, col] = ligne * 10 + col;
                }
            }
            foreach (int nb in matrice)
            {
                Console.WriteLine(nb);
            }

            Console.ReadKey();
        }
    }
}
