using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExempleCommand.Command
{
    public class CommandAllerEnBas : ICommand
    {
        private int nbPixel;
        private Personnage sonReceiver;

        public CommandAllerEnBas(int pixel, Personnage cible)
        {
            nbPixel = pixel;
            sonReceiver = cible;
        }

        public bool Executer()
        {
            return sonReceiver.DeplacerEnBas(nbPixel);
        }

        public bool Annuler()
        {
            return sonReceiver.DeplacerEnHaut(nbPixel);
        }

        public string GetString()
        {
            return "Bas(" + nbPixel + ")";
        }
    }
}
