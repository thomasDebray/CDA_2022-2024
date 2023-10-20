using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExempleCommand.Command
{
    public class CommandAllerADroite : ICommand
    {
        private int nbPixel;
        private Personnage sonReceiver;

        public CommandAllerADroite(int pixel, Personnage cible)
        {
            nbPixel = pixel;
            sonReceiver = cible;
        }

        public bool Executer()
        {
            return sonReceiver.DeplacerADroite(nbPixel);
        }

        public bool Annuler()
        {
            return sonReceiver.DeplacerAGauche(nbPixel);
        }

        public string GetString()
        {
            return "Droite(" + nbPixel + ")";
        }
    }
}
