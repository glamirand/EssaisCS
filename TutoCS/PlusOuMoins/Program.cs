using System;

namespace PlusOuMoins
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Plus ou moins");
            int nbCoups = 0;
            int nbCible;
            int nbPropose;
            bool trouve = false;
            Random ran = new Random();
            nbCible = ran.Next(1,101);
            while (! trouve)
            {
                Console.Write("Proposez un nombre entre 1 et 100 : ");
                if (int.TryParse(Console.ReadLine(),out nbPropose) & nbPropose >= 1 & nbPropose <= 100)
                {
                    nbCoups++;
                    if (nbPropose > nbCible)
                    {
                        Console.WriteLine("C'est moins!");
                    }
                    else if (nbPropose< nbCible)
                    {
                        Console.WriteLine("C'est plus!");
                    }
                    else
                    {
                        Console.WriteLine("Bravo! Vous avez trouvé en " + nbCoups + " coups!");
                        trouve = true;
                    }
                  }
                    else
                    {
                    Console.WriteLine("Le nombre proposé est incorrect!");
                }
                
            }


            Console.Read();
        }
    }
}
