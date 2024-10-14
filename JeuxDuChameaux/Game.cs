using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JeuxDuChameaux
{
    class Game
    {
        // Variables du temps
        public int TempsJeu;
        public int TempsLimite;

        // Variables Kilometre
        public int KilometreFait;
        public int KilometreAFaire;

        private Player Joueur;


        public Game(){
            TempsJeu = 0;
            TempsLimite = 35;

            KilometreFait = 0;
            KilometreAFaire = 500;

            Joueur = new Player();
        }

        // Get et Set


        // temps
        public void SetTempsJeu(int tempsJeu)
        {
            this.TempsJeu = tempsJeu;
        }

        public int GetTempsJeu()
        {
            return TempsJeu;
        }
        public int GetTempsLimite()
        {
            return TempsLimite;
        }

        // kilometre
        public void SetKilometreFait(int kilometreFait)
        {
            this.KilometreFait = kilometreFait;
        }
        public int GetKilometreFait()
        {
            return KilometreFait;
        }
        public int GetKilometreAFait()
        {
            return KilometreAFaire;
        }

        // Modifier ( rajouter ou enlever )
        public void ModTempsJeu(int tempsJeu)
        {
            this.TempsJeu += tempsJeu;
        }

        public void ModtKilometreFait(int kilometreFait)
        {
            this.KilometreFait += kilometreFait;
        }

        // Fonction

        // Fonction Commencer

        public  void Commencer()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Bienvenue dans Rush Adventure !" + '\n');
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Voulez-vous commencer ?");
            Console.ResetColor();
            Console.WriteLine("1. Oui");
            Console.WriteLine("2. Non"+'\n');

            string reponse = Console.ReadLine();
            switch (reponse)
            {
                case "1":
                    Console.Clear();
                    Histoire();
                    break;
                case "2":
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("A Bientôt." + '\n');
                    Console.ResetColor();
                    Quitter();
                    break;
                default:
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Reponse invalide"+'\n');
                    Console.ResetColor();
                    Commencer();
                    break;

                
            }
        }

        // Fonction Quitter
        public static void Quitter()
        {
            Environment.Exit(0);
        }

        // Fonction Histoire
        public void Histoire()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Histoire : ");
            Console.WriteLine("Vous êtes un aventurier d'une ville de campagne vaux parent vous on inscrit a l'académie des Aventurier,");
            Console.WriteLine("vous partais avec votre chevale et votre épée a l'aventure vous avais comme but de vous rendre a la capitale pour aller a l'academy des Aventurier Avant que la rentrer arrive !"+'\n');
            Action action = new Action(Joueur);
            action.AfficherAction();
        }

        // Fonction Game Over
        public void GameOver()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("GAME OVER \n");
            if (Joueur.J_Sante <= 0)
            {
                Console.WriteLine("Vous êtes Mort de Blessure. \n");
               

            }
            else if (GetTempsLimite()-GetTempsJeu() <= 0)
            {
                Console.WriteLine("Vous êtes Pas Arrivée a Temps. \n");
            }
            else if (Joueur.J_Faim <= 0)
            {
                Console.WriteLine("Vous êtes Mort de Faim. \n");
            }
            else if (Joueur.J_Eau <= 0)
            {
                Console.WriteLine("Vous êtes Mort de Soif. \n");
            }
            Console.WriteLine("Nombre de jour Fait : " + GetTempsJeu() + "J/" + GetTempsLimite() + "J.");
            Console.ResetColor();
            Game.Quitter();

        }

        // Fonction de temps
        public void Temps()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Temps et Kilometres:\n");
            Console.ResetColor();
            Console.WriteLine("Il reste "+ (GetTempsLimite()-GetTempsJeu())+" Jours et "+(GetKilometreAFait()-GetKilometreFait())+" Kilometres.");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\nRevenir au menu ?");
            Console.ResetColor();
            Console.WriteLine("1. Oui");
            Console.WriteLine("2. Non"+'\n');

            string reponse = Console.ReadLine();
            switch (reponse)
            {
                case "1":
                    Console.Clear();
                    Action Action = new Action(Joueur);
                    Action.AfficherAction();
                    break;
                case "2":
                    Console.Clear();
                    Temps();
                    break;
                default:
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Reponse invalide"+'\n');
                    Console.ResetColor();
                    Temps();
                    break;
            }
        }


    }
}
