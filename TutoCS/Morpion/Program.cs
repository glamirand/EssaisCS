using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Morpion
{
    class Program
    {

        enum EtatCase
        {
            Vide,
            Rond,
            Croix
        }
        static EtatCase[,] grille;

        static void Main(string[] args)
        {
            Console.WriteLine("Bienvenu dans le jeu du Morpion!");

            //Initialisation
            bool finDeJeu = false;
            grille = new EtatCase[3, 3];
            int nbVide = 9;
            bool gagne;
            //Afficher la grille
            AfficherGrille();

            //Boucle Principale
            while (!finDeJeu)
            {
                //Jeu de l'utilisateur
                ChoisirCaseUtilisateur();
                nbVide--;

                //Affichage de la grille
                AfficherGrille();

                //Jeu gagnant?
                gagne = JeuGagnant(EtatCase.Croix);
                if (gagne)
                {
                    finDeJeu = true;
                    Console.WriteLine("Bravo, vous avez gagné!");
                }

                //Jeu de l'ordinateur
                if (!finDeJeu && nbVide > 0)
                {
                    JeuOrdinateur();
                    nbVide--;

                    //Affichage de la grille
                    Console.WriteLine("L'ordinateur a joué : ");
                    AfficherGrille();

                    // Jeu gagnant?
                    gagne = JeuGagnant(EtatCase.Rond);
                    if (gagne)
                    {
                        finDeJeu = true;
                        Console.WriteLine("L'ordinateur a gagné!");
                    }
                }

                //Match nul?
                if (nbVide <= 0)
                {
                    finDeJeu = true;
                }
            }
            Console.WriteLine("Appuyez sur une touche pour continuer...");
            Console.ReadKey();
        }

        private static void AfficherGrille()
        {
            String dessinGrille = "\n";

            //Trait du haut
            dessinGrille += "************\n";
            //Pour chaque ligne
            for (int ligne = 0; ligne < 3; ligne++)
            {
                //Pour chaque colonne
                for (int colonne = 0; colonne < 3; colonne++)
                {
                    switch (grille[ligne, colonne])
                    {
                        case EtatCase.Vide:
                            dessinGrille += " " + (ligne * 3 + colonne).ToString() + " ";
                            break;
                        case EtatCase.Rond:
                            dessinGrille += " O ";
                            break;
                        case EtatCase.Croix:
                            dessinGrille += " X ";
                            break;
                    }
                    dessinGrille += "|";
                }
                //Trait du bas
                dessinGrille += "\n************\n";
            }
            //Affichage en console
            Console.WriteLine(dessinGrille);
        }

        private static void ChoisirCaseUtilisateur()
        {
            bool choixOK = false;

            while (!choixOK)
            {
                Console.WriteLine("Donnez votre choix de case : ");
                string reponse = Console.ReadLine();
                int choix;

                if (int.TryParse(reponse, out choix) && choix >= 0 && choix <= 8)
                {
                    //case vide?
                    int ligne = choix / 3;
                    int colone = choix % 3;

                    if (grille[ligne, colone] == EtatCase.Vide)
                    {
                        //Choix ok, je valide
                        grille[ligne, colone] = EtatCase.Croix;
                        choixOK = true;
                    }
                }
            }
        }

        private static void JeuOrdinateur()
        {
            bool choixOK = false;
            Random rand = new Random();
            while (!choixOK)
            {

                int choix = rand.Next(0, 9);
                //case vide?
                int ligne = choix / 3;
                int colone = choix % 3;

                if (grille[ligne, colone] == EtatCase.Vide)
                {
                    //Choix ok, je valide
                    grille[ligne, colone] = EtatCase.Rond;
                    choixOK = true;
                }

            }
        }

        private static bool JeuGagnant(EtatCase etatcase)
        {
            //Cas d'une ligne
            for (int ligne = 0; ligne < 3; ligne++)
            {
                if (grille[ligne, 0] == etatcase && grille[ligne, 1] == etatcase && grille[ligne, 2] == etatcase)
                {
                    return true;
                }
            }
            //Cas d'une colone
            for (int colone = 0; colone < 3; colone++)
            {
                if (grille[0, colone] == etatcase && grille[1, colone] == etatcase && grille[2, colone] == etatcase)
                {
                    return true;
                }
            }
            //Cas des diagonales
            if (grille[0, 0] == etatcase && grille[1, 1] == etatcase && grille[2, 2] == etatcase)
            {
                return true;
            }
            if (grille[0, 2] == etatcase && grille[1, 1] == etatcase && grille[2, 0] == etatcase)
            {
                return true;
            }

            //Par défaut on n'a pas gagné
            return false;
        }
    }
}
