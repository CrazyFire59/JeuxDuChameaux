using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JeuxDuChameaux
{
    class AvancerNormal
    {
        Player Joueur = new Player();
        Cheval Cheval = new Cheval();
        Game Game = new Game();
        EventAleatoire EventAleatoire = new EventAleatoire();

        // Fonction du Avencer normalent


        public void AfficherAvancerNormal()
        {
            EventAleatoire.AfficherEventAleatoire();
            Game.ModtKilometreFait(+10);
            Cheval.SetNbJRapide(0);
            Cheval.ModEau(-10);
            Cheval.ModEnergie(-10);
            Cheval.ModFaim(-5);
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Cheval :\n");
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("-10 Points de Soif\n");
            Console.WriteLine("-10 Points de Energie\n");
            Console.WriteLine("-5 Points de Faim\n");
            Console.ResetColor();
            Console.WriteLine("\nVous avez fait 10km Aujourd'hui");
        }
    }
}
