using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JeuxDuChameaux
{
    class Status
    {
        Player Joueur = new Player();
        Cheval Cheval = new Cheval();
        Action Action = new Action();

        public Status()
        {

        }

        // Fonction du Status
        public void AfficherStatus()
        {
            string[] attributs = { "PV", "ENERGIE", "FAIM", "SOIF" };
            int[] joueurStatus = { Joueur.GetSante(), Joueur.GetEnergie(), Joueur.GetFaim(), Joueur.GetEau() };
            int[] chevalStatus = { Cheval.GetSante(), Cheval.GetEnergie(), Cheval.GetFaim(), Cheval.GetEau()};
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Status:\n");
            Console.ResetColor();
            Console.WriteLine("{0,15} {1,-15} {2,-15} {3,-10}", "Aventurier", "", "Cheval", "");
            
            for (int i = 0; i < attributs.Length; i++)
            {
                Console.WriteLine("{0,-15} {1,-10} {2,-15} {3,-10}", attributs[i], joueurStatus[i], attributs[i], chevalStatus[i]);
            }
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
                    Action.AfficherAction();
                    break;
                case "2":
                    Console.Clear();
                    AfficherStatus();
                    break;
                default:
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Reponse invalide"+'\n');
                    Console.ResetColor();
                    AfficherStatus();
                    break;
            }
        }
    }
}
