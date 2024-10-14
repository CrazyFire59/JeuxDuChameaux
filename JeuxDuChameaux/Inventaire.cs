using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JeuxDuChameaux
{
    class Inventaire
    {
        Player Joueur = new Player();
        Action Action = new Action();
        // Variables de l'inventaire
        public int Eau;
        public int Pain;
        public int Viand;
        public int Peaux;
        public int EBandit;
        public int Argent;

        // Constructeur
        public Inventaire() { 
            Eau = 5;
            Pain = 3;
            Viand = 2;
            Peaux = 0;
            EBandit = 0;
            Argent = 100;
        }

        // Get et Set
        public int GetEau()
        {
            return Eau;
        }
        public void SetEau(int Eau)
        {
            this.Eau = Eau;
        }
        public int GetPain()
        {
            return Pain;
        }
        public void SetPain(int Pain)
        {
            this.Pain = Pain;
        }
        public int GetViand()
        {
            return Viand;
        }
        public void SetViand(int Viand)
        {
            this.Viand = Viand;
        }
        public int GetPeaux()
        {
            return Peaux;
        }
        public void SetPeaux(int Peaux)
        {
            this.Peaux = Peaux;
        }
        public int GetEBandit()
        {
            return EBandit;
        }
        public void SetEBandit(int EBandit)
        {
            this.EBandit = EBandit;
        }
        public int GetArgent()
        {
            return Argent;
        }
        public void SetArgent(int Argent)
        {
            this.Argent = Argent;
        }

        // Modifier ( rajouter ou enlever )
        public void ModEau(int Eau)
        {
            this.Eau += Eau;
        }
        public void ModPain(int Pain)
        {
            this.Pain += Pain;
        }
        public void ModViand(int Viand)
        {
            this.Viand += Viand;
        }
        public void ModPeaux(int Peaux)
        {
            this.Peaux += Peaux;
        }
        public void ModEBandit(int EBandit)
        {
            this.EBandit += EBandit;
        }
        public void ModArgent(int Argent)
        {
            this.Argent += Argent;
        }

        // Fonction Afficher l'inventaire
        public void AfficherInventaire()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Inventaire:\n");
            Console.ResetColor();
            Console.WriteLine("{0,10} {1,-15}", "Eau", GetEau());
            Console.WriteLine("{0,10} {1,-15}", "Pain", GetPain());
            Console.WriteLine("{0,10} {1,-15}", "Viand", GetViand());
            if(Peaux > 0)
            {
                Console.WriteLine("{0,10} {1,-15}", "Peaux", GetPeaux());
            }
            if(EBandit > 0)
            {
                Console.WriteLine("{0,10} {1,-15}", "Equipement Bandit", GetEBandit());
            }
            Console.WriteLine("{0,10} {1,-15}", "Argent", GetArgent());
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\nRevenir au menu ?");
            Console.ResetColor();
            Console.WriteLine("1. Utiliser Eau");
            Console.WriteLine("2. Utiliser Pain");
            Console.WriteLine("3. Utiliser Viand");
            Console.WriteLine("4. Revenir au menu"+'\n');
            
            string reponse = Console.ReadLine();
            
            switch (reponse)
            {
                case "1":
                    if (Joueur.GetEau() <= 90 && GetEau() > 0){
                        Joueur.ModEau(+10);
                        ModEau(-1);
                        Console.Clear();
                        Console.WriteLine("Vous avez bu de l'Eau, Votre Soif est maintenant à "+Joueur.GetEau() + "%."+'\n');
                        AfficherInventaire();
                    }else if (GetEau() < 1){
                        Console.Clear();
                        Console.WriteLine("Vous n'avez plus d'Eau."+'\n');
                        AfficherInventaire();
                    }else{
                        Console.Clear();
                        Console.WriteLine("Le Jouer n'as pas Soif."+'\n');
                        AfficherInventaire();
                    }
                    break;
                case "2":
                    if (Joueur.GetFaim() <= 90 && GetPain() > 0){
                        Joueur.ModFaim(+10);
                        ModPain(-1);
                        Console.Clear();
                        Console.WriteLine("Vous avez mangez un Pain, Votre Faim est maintenant à "+Joueur.GetFaim() + "%."+'\n');
                        AfficherInventaire();
                    }else if (GetPain() < 1){
                        Console.Clear();
                        Console.WriteLine("Vous n'avez plus de pain"+'\n');
                        AfficherInventaire();
                    }else{
                        Console.Clear();
                        Console.WriteLine("Le Jouer n'as pas Faim."+'\n');
                        AfficherInventaire();
                    }
                    break;
                case "3":
                    if (Joueur.GetFaim() <= 75 && GetViand() > 0){
                        Joueur.ModFaim(+25);
                        ModViand(-1);
                        Console.Clear();
                        Console.WriteLine("Vous avez mangez de la Viand, Votre Faim est maintenant à "+Joueur.GetFaim() + "%."+'\n');
                        AfficherInventaire();
                        }else if (GetViand() < 1){
                        Console.Clear();
                        Console.WriteLine("Vous n'avez plus de Viand"+'\n');
                        AfficherInventaire();
                    }else{
                        Console.Clear();
                        Console.WriteLine("Le Jouer n'as pas Faim."+'\n');
                        AfficherInventaire();
                    }
                    break;
                case "4":
                    Console.Clear();
                    Action.AfficherAction();
                    break;
                default:
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Reponse invalide"+'\n');
                    Console.ResetColor();
                    AfficherInventaire();
                    break;
            }
        }
       

    }
}
