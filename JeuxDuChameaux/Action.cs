using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JeuxDuChameaux
{
    class Action
    {
        public Player _joueur { get; private set; }
        // Cheval Cheval = new Cheval();
        // Status Status = new Status();
        Game Game = new Game();
        // Inventaire Inventaire = new Inventaire();
        // AvancerNormal AvancerNormal = new AvancerNormal();
        // AvancerRapide AvancerRapide = new AvancerRapide();
        // Regarder Regarder = new Regarder();
        // Reposer Reposer = new Reposer();



        // Constructeur
        public Action( Player joueur){
            this._joueur = joueur;
        }


        // Fonction d'action
        
        public void AfficherAction()
        {
            if (_joueur.J_Sante <= 0 || Game.GetTempsLimite()-Game.GetTempsJeu() <= 0 || _joueur.J_Faim <= 0 || _joueur.J_Eau <= 0){
                Game.GameOver();
            }
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Quelle action voulez-vous faire ?");
            Console.ResetColor();
            Console.WriteLine("1. Afficher Status");
            Console.WriteLine("2. Inventaire");
            Console.WriteLine("3. Avancer normalement");
            Console.WriteLine("4. Avancer Rapidelent");
            Console.WriteLine("5. Regarder dans les alentours");
            Console.WriteLine("6. Se Reposer");
            Console.WriteLine("7. Afficher le Temps et Kilometre Restants");
            Console.WriteLine("8. Quitter"+'\n');

            string reponse = Console.ReadLine();
            switch (reponse)
            {
                case "1":
                    Console.Clear();
                    Status.AfficherStatus();
                    break;
                case "2":
                    Console.Clear();
                    Inventaire.AfficherInventaire();
                    break;
                case "3":
                    Console.Clear();
                    AvancerNormal.AfficherAvancerNormal();
                    break;
                case "4":
                    Console.Clear();
                    AvancerRapide.AfficherAvancerRapide();
                    break;
                case "5":
                    Console.Clear();
                    Regarder.AfficherRegarder();
                    break;
                case "6":
                    Console.Clear();
                    Reposer.AfficherReposer();
                    break;
                case "7":
                    Console.Clear();
                    Game.Temps();
                    break;
                case "8":
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Clear();
                    Console.WriteLine("A Bientôt." + '\n');
                    Console.ResetColor();
                    Game.Quitter();
                    break;
                default:
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Reponse invalide"+'\n');
                    Console.ResetColor();
                    AfficherAction();
                    break;

            }

        }
    }
}
