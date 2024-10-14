using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JeuxDuChameaux
{
    
    class Player
    {
        public Action Action { get; set; }
        // Variables du Joueur
        public int J_Sante { get; set; }
        public int J_Energie { get; set; }
        public int J_Faim { get; set; }
        public int J_Eau { get; set; }
        public bool J_Epee { get; set; }

        // Constructeur
        public Player()
        {
            J_Sante = 100;
            J_Energie = 100;
            J_Faim = 100;
            J_Eau = 100;
            J_Epee = true;

            this.Action = new Action(this);
        }

        // Modifier ( rajouter ou enlever )
        public void ModSante(int Sante)
        {
            this.J_Sante += Sante;
        }

        public void ModEnergie(int Energie)
        {
            this.J_Energie += Energie;
        }

        public void ModFaim(int Faim)
        {
            this.J_Faim += Faim;
        }

        public void ModEau(int Eau)
        {
            this.J_Eau += Eau;
        }



    }
}
