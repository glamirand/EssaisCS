using System;

namespace Avance
{
    class Program
    {
        static void Main(string[] args)
        {
            Chat monchat = new Chat("Pixel", 3, "Roux tigré");
            Console.WriteLine(monchat);

            Chat deuxiemeChat = monchat;
            Console.WriteLine(deuxiemeChat);

            deuxiemeChat.Vieillir();

            Console.WriteLine(monchat);
            Console.WriteLine(deuxiemeChat);


            Console.WriteLine("Tapez un nombre.");
string reponse = Console.ReadLine();
            int nb = -1;
            try
            {
nb = int.Parse(reponse);
            }
            catch
            {
                Console.WriteLine("Exception!");
                nb = 0;
            }
            finally
            {
            Console.WriteLine("Vous avez tapé le nombre " + nb);
                
            Console.ReadKey();
            }
            
            

           
        }
    }
}
