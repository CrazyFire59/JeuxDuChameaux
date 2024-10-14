using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JeuxDuChameaux
{
    class AvancerRapide
    {
        // Fonction du Avencer rapide
        public void AfficherAvancerRapide()
        {
            Player Joueur = new Player();
            Cheval Cheval = new Cheval();
            Game Game = new Game();
            EventAleatoire EventAleatoire = new EventAleatoire();



            Cheval.ModNbJRapide(+1);
            if (Cheval.GetNbJRapide() >= 4){
                EventAleatoire.AfficherEventAleatoire();
                Console.WriteLine("Votre chevale et blesse vue que vous lui demandez d'aller plus vite beaucoup de fois !");
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("Cheval :\n");
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("-30 point de Sante");
                Console.WriteLine("-25 Points de Soif\n");
                Console.WriteLine("-25 Points de Energie\n");
                Console.WriteLine("-15 Points de Faim\n");
                Console.ResetColor();
                Game.ModtKilometreFait(+5);
                Cheval.ModSante(-30);
                Cheval.ModEau(-25);
                Cheval.ModEnergie(-25);
                Cheval.ModFaim(-15);
                Cheval.SetNbJRapide(0);

            }else{
                EventAleatoire.AfficherEventAleatoire();
                Game.ModtKilometreFait(25);
                Cheval.ModEau(-15);
                Cheval.ModEnergie(-15);
                Cheval.ModFaim(-10);
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("Cheval :\n");
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("-15 Points de Soif\n");
                Console.WriteLine("-15 Points de Energie\n");
                Console.WriteLine("-10 Points de Faim\n");
                Console.ResetColor();

                Console.WriteLine("Vous avez fait 25km Aujourd'hui");
            }
            EventAleatoire.AfficherEventAleatoire(); // A supprimer ?
        }
    }
}
