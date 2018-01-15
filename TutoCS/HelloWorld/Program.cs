using System;

namespace HelloWorld
{
    class Program
    {
        /// <summary>
        /// Ceci est un HelloWorld!
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            //Ceci est un commentaire
            //string msg = "Hello World!";
            //Console.WriteLine(msg);

            //double nb1 = 10;
            //double nb2 = 25;
            //double moyenne = (nb1 + nb2) / 2;
            //Console.WriteLine(moyenne);

            //nb1++;
            //nb1 *= 2;
            //nb1 -= 5;
            //Console.WriteLine(nb1);
            //

            //long j = 3;
            //int i;
            //i = (int)j;

            //Console.WriteLine("Comment t'apelles-tu?");
            //string nom;
            //nom = Console.ReadLine();

            //Console.WriteLine("Quel âge as-tu?");
            //int age;
            //bool conversionOk = int.TryParse(Console.ReadLine(), out age);

            //Console.Clear();

            //if (conversionOk)
            //{
            //    Console.WriteLine("Bonjour " + nom + " ,tu as " + age + " ans.");
            //}
            //else
            //{
            //    Console.WriteLine("Désolé, je n'ai  pas compris ton âge!");
            //}

            for (int i=0;i<10;i++)
            {
                Console.WriteLine(i);
            }

            Console.ReadKey();
        }
    }
}
