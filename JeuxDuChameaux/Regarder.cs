using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JeuxDuChameaux
{
    class Regarder
    {
        Player Joueur = new Player();
        Game Game = new Game();
        Action Action = new Action();
        Inventaire Inventaire = new Inventaire();

        // Fonction de regarder dans alentours
        public void AfficherRegarder()
        {
            Random alea = new Random();
            int Regard_alea = alea.Next(0, 2);
            switch (Regard_alea)
            {
                case 0:
                    Console.WriteLine('\n'+"Vous ne Croisser Rien Vous continuer votre route.");
                    Joueur.ModEau(-10);
                    Joueur.ModEnergie(-5);
                    Joueur.ModFaim(-5);
                    Game.ModTempsJeu(+1);
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("-10 Points de Soif");
                    Console.WriteLine("-5 Points de Energie");
                    Console.WriteLine("-5 Points de Faim\n");
                    Console.ResetColor();
                    Action.AfficherAction();
                    break;
                case 1:
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine('\n'+"Il y a un Cert Sauvage En vue que faire ?"+'\n');
                    Console.ResetColor();
                    Console.WriteLine("1. Aller l'attaquée.");
                    Console.WriteLine("2. Partire.");
                    string reponseC1 = Console.ReadLine();
                    switch (reponseC1)
                    {
                        case "1":
                            Console.Clear();
                            
                            int D2 = alea.Next(0, 2);
                            switch (D2) {
                                case 0:
                                    Console.ForegroundColor = ConsoleColor.Blue;
                                    Console.WriteLine("Vous avais reusi a abattre le Cerf !\n");
                                    int nbaViand = alea.Next(1, 4);
                                    int nbaPeaux = alea.Next(1, 4);
                                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                                    Console.WriteLine("+"+nbaViand+" Viand de Cerf");
                                    Console.WriteLine("+" + nbaPeaux + " Peaux de Cerf");
                                    Inventaire.ModViand(+nbaViand);
                                    Inventaire.ModPeaux(+nbaPeaux);
                                    Joueur.ModEau(-10);
                                    Joueur.ModEnergie(-10);
                                    Joueur.ModFaim(-5);
                                    Game.ModTempsJeu(+1);
                                    Console.ForegroundColor = ConsoleColor.Blue;
                                    Console.WriteLine("Aventurier:");

                                    Console.ForegroundColor = ConsoleColor.DarkRed;
                                    Console.WriteLine("-10 Points de Soif");
                                    Console.WriteLine("-10 Points de Energie");
                                    Console.WriteLine("-5 Points de Faim\n");
                                    Console.ResetColor();
                                    Console.ForegroundColor = ConsoleColor.Yellow;
                                    Console.WriteLine("\nRevenir au menu ?");
                                    Console.ResetColor();
                                    Console.WriteLine("1. Oui");
                                    string reponseC2 = Console.ReadLine();
                                    switch (reponseC2)
                                    {
                                        case "1":
                                            Console.Clear();
                                            Action.AfficherAction();
                                            break;
                                        default:
                                            Console.Clear();
                                            Action.AfficherAction();
                                            break;
                                    }
                                    break;
                                case 1:
                                    Console.ForegroundColor = ConsoleColor.Blue;
                                    Console.Write("Le Cerf c'est enfuit...\n");
                                    Console.ResetColor();
                                    Joueur.ModEau(-10);
                                    Joueur.ModEnergie(-10);
                                    Joueur.ModFaim(-5);
                                    Game.ModTempsJeu(+1);
                                    Console.ForegroundColor = ConsoleColor.DarkRed;
                                    Console.WriteLine("-10 Points de Soif");
                                    Console.WriteLine("-10 Points de Energie");
                                    Console.WriteLine("-5 Points de Faim\n");
                                    Console.ResetColor();
                                    Console.ForegroundColor = ConsoleColor.Yellow;
                                    Console.WriteLine("\nRevenir au menu ?");
                                    Console.ResetColor();
                                    Console.WriteLine("1. Oui");
                                    string reponseC3 = Console.ReadLine();
                                    switch (reponseC3)
                                    {
                                        case "1":
                                            Console.Clear();
                                            Action.AfficherAction();
                                            break;
                                        default:
                                            Console.Clear();
                                            Action.AfficherAction();
                                            break;
                                    }

                                    break;

                            }
                            break;
                        case "2":
                            Console.Clear();
                            Joueur.ModEau(-5);
                            Joueur.ModFaim(-5);
                            Game.ModTempsJeu(+1);
                            Console.ForegroundColor = ConsoleColor.DarkRed;
                            Console.WriteLine("-5 Points de Soif");
                            Console.WriteLine("-5 Points de Faim\n");
                            Console.ResetColor();
                            Action.AfficherAction();
                            break;
                        default:
                            Console.Clear();
                            Joueur.ModEau(-5);
                            Joueur.ModFaim(-5);
                            Game.ModTempsJeu(+1);
                            Console.ForegroundColor = ConsoleColor.DarkRed;
                            Console.WriteLine("-5 Points de Soif");
                            Console.WriteLine("-5 Points de Faim\n");
                            Console.ResetColor();
                            Action.AfficherAction();
                            break;
                    }
                    break ;
                case 2:
                    Console.WriteLine('\n'+"Vous Croisser un Village Que faites-vous ?"+'\n');
                    break;
                case 3:
                    Console.WriteLine('\n'+"Vous Croisser un Village Abandonnais Que faites-vous ?"+'\n');
                    break;
                case 4:
                    Console.WriteLine('\n'+"Vous Croisser un Lac Que faites-vous ?");
                    Console.WriteLine("1. Aller remplire votre Gourde d'Eau.");
                    Console.WriteLine("2. Continuer la Route" + '\n');
                    string reponseL1 = Console.ReadLine();
                    switch (reponseL1)
                    {
                        case "1":
                            Console.WriteLine("Vous vous Approcher du lac remplire votre gourde d'eau");
                            int D5 = alea.Next(5, 11);
                            Inventaire.ModEau(+D5);
                            Console.ForegroundColor = ConsoleColor.DarkGreen;
                            Console.WriteLine("+" + D5 + " Eau.");
                            Console.ResetColor();


                            break;
                        case "2":
                            Console.Clear();
                            Joueur.ModEau(-5);
                            Joueur.ModFaim(-5);
                            Game.ModTempsJeu(+1);
                            Console.ForegroundColor = ConsoleColor.DarkRed;
                            Console.WriteLine("-5 Points de Soif");
                            Console.WriteLine("-5 Points de Faim\n");
                            Console.ResetColor();
                            Action.AfficherAction();
                            break;
                        default:
                            Console.Clear();
                            Joueur.ModEau(-5);
                            Joueur.ModFaim(-5);
                            Game.ModTempsJeu(+1);
                            Console.ForegroundColor = ConsoleColor.DarkRed;
                            Console.WriteLine("-5 Points de Soif");
                            Console.WriteLine("-5 Points de Faim\n");
                            Console.ResetColor();
                            Action.AfficherAction();
                            break;
                    }

                    break;
                case 5:
                    Console.WriteLine('\n'+"Vous Croisser un Donjon Que faites-vous ?"+'\n');
                    break;
                default:
                    Console.WriteLine('\n'+"Vous ne Croisser Rien Vous continuer votre route.");
                    Joueur.ModEau(-10);
                    Joueur.ModEnergie(-10);
                    Joueur.ModFaim(-5);
                    
                    Action.AfficherAction();
                    break;
            }
        }

    }
}
