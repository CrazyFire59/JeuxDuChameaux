using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JeuxDuChameaux
{
    class Reposer
    {
        Player Joueur = new Player();
        Game Game = new Game();
        Action Action = new Action();

        // Fonction de Repos
        public void AfficherReposer()
        {
            if(Joueur.GetSante() > 80){
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("Vous vous reposer");
                Console.ResetColor();
                if(Joueur.GetEnergie() > 85){
                    Joueur.ModEau(-5);
                    Joueur.ModFaim(-5);
                    Game.ModTempsJeu(+1);
                    Console.WriteLine("-5 Points de Soif");
                    Console.WriteLine("-5 Points de Faim\n");
                    
                    Action.AfficherAction();
                }else if(Joueur.GetEnergie() <= 85){
                    Joueur.ModEnergie(+15);
                    Joueur.ModEau(-5);
                    Joueur.ModFaim(-5);
                    Game.ModTempsJeu(+1);
                    Console.WriteLine("+15 Points d'Energie");
                    Console.WriteLine("-5 Points de Soif");
                    Console.WriteLine("-5 Points de Faim \n");

                    Action.AfficherAction();
                }
            }else if(Joueur.GetSante() < 80){
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("Vous vous reposer et vos blesure se Soigne \n");
                Console.ResetColor();
                Joueur.ModSante(+20);
                Console.WriteLine("+20 Points de Sante");
                if(Joueur.GetEnergie() > 85){
                    Joueur.ModEau(-5);
                    Joueur.ModFaim(-5);
                    Game.ModTempsJeu(+1);
                    Console.WriteLine("-5 Points de Soif");
                    Console.WriteLine("-5 Points de Faim\n");
                    Action.AfficherAction();
                }else if(Joueur.GetEnergie() <= 85){
                    Joueur.ModEnergie(+15);
                    Joueur.ModFaim(-5);
                    Joueur.ModEau(-5);
                    Game.ModTempsJeu(+1);
                    Console.WriteLine("+15 Points d'Energie");
                    Console.WriteLine("-5 Points de Soif");
                    Console.WriteLine("-5 Points de Faim\n");
                    Action.AfficherAction();
                }
            }
            
        }

    }
}
