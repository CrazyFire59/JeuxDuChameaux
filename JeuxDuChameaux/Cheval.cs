using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JeuxDuChameaux
{
    class Cheval
    {
        // Variables du Cheval
        public static int C_Sante;
        public static int C_Energie;
        public static int C_Faim ;
        public static int C_Eau;
        public static int nbJRapide;

        // Constructeur
        public Cheval()
        {
            nbJRapide = 0;
            C_Sante = 100;
            C_Energie = 100;
            C_Faim = 100;
            C_Eau = 100;
        }

        // Get et Set
        public int GetSante()
        { 
            return C_Sante; 
        }
        public void SetSante(int Sante)
        {
            C_Sante = Sante;
        }
        public int GetEnergie()
        { 
            return C_Energie; 
        }
        public void SetEnergie(int Energie)
        {
            C_Energie = Energie;
        }
        public int GetFaim()
        { 
            return C_Faim; 
        }
        public void SetFaim(int Faim)
        {
            C_Faim = Faim;
        }
        public int GetEau()
        { 
            return C_Eau; 
        }

        public void SetEau(int Eau)
        {
            C_Eau = Eau;
        }

        public int GetNbJRapide()
        {
            return nbJRapide;
        }


        public void SetNbJRapide(int nbJRapideEnPlus)
        {
            nbJRapide = nbJRapideEnPlus;
        }

        // Modifier ( rajouter ou enlever )
        public void ModSante(int Sante)
        {
            C_Sante += Sante;
        }
        public void ModEnergie(int Energie)
        {
            C_Energie += Energie;
        }
        public void ModFaim(int Faim)
        {
            C_Faim += Faim;
        }
        public void ModEau(int Eau)
        {
            C_Eau += Eau;
        }
        public void ModNbJRapide(int nbJRapideEnPlus)
        {
            nbJRapide += nbJRapideEnPlus;
        }

    }
}
