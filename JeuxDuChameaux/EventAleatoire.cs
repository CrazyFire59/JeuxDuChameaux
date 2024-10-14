using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JeuxDuChameaux
{
    class EventAleatoire
    {
        Action Action = new Action();
        Random alea = new Random();
        // Fonction d'event Aleatoire

        public void AfficherEventAleatoire()
        {
            int event_alea = alea.Next(0, 20);
            switch (event_alea)
            {
                case 0:
                    Console.WriteLine('\n'+"Vous ne Croisser Rien Vous continuer votre route.");
                    Action.AfficherAction();
                    break;
                case 1:
                    Console.WriteLine('\n'+"Vous vous fait Attaquer par un Bandit !"+'\n');
                    break;
                case 2:
                    Console.WriteLine('\n'+"Vous vous fait Attaquer par un Loups Sauvage !"+'\n');
                    break;
                case 3:
                    Console.WriteLine('\n'+"Vous vous fait Attaquer par un Sanglier Sauvage !"+'\n');
                    break ;
                case 4:
                    Console.WriteLine('\n'+"Cert Sauvage En vue que faire ?"+'\n');
                    break ;
                case 5:
                    Console.WriteLine('\n'+"Vous Entander un cris aller vous regarder ?"+'\n');
                    break ;
                case 6:
                    Console.WriteLine('\n'+"Une Tempête est Là !"+'\n');
                    break;
                case 7:
                    Console.WriteLine('\n'+"Oh non vous avez marcher sur un Portail Magic !"+'\n');
                    break;
                case 8:
                    Console.WriteLine('\n'+"Vous Croisser un Village Que faites-vous ?"+'\n');
                    break;
                case 9:
                    Console.WriteLine('\n'+"Vous Croisser un Village Abandonnais Que faites-vous ?"+'\n');
                    break;
                case 10:
                    Console.WriteLine('\n'+"Vous Croisser un Lac Que faites-vous ?"+'\n');
                    break;
                case 11:
                    Console.WriteLine('\n'+"Vous Croisser un Donjon Que faites-vous ?"+'\n');
                    break;

                default:
                    Console.WriteLine('\n'+"Vous ne Croisser Rien Vous continuer votre route.");
                    Action.AfficherAction();
                    break;
            }
        }
    }
}
