using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExempleCommand.Command
{
    public class CommandAllerAGauche : ICommand
    {
        private int nbPixel;
        private Personnage sonReceiver;
        
        public CommandAllerAGauche(int pixel, Personnage cible)
        {
            nbPixel = pixel;
            sonReceiver = cible;
        }

        public bool Executer()
        {
            return sonReceiver.DeplacerAGauche(nbPixel);
        }

        public bool Annuler()
        {
            return sonReceiver.DeplacerADroite(nbPixel);
        }

        public string GetString()
        {
            return "Gauche(" + nbPixel + ")";
        }
    }
}
