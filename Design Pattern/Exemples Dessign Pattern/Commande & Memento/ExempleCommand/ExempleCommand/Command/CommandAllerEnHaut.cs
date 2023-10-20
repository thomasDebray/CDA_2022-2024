using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExempleCommand.Command
{
    public class CommandAllerEnHaut : ICommand
    {
        private int nbPixel;
        private Personnage sonReceiver;

        public CommandAllerEnHaut(int pixel, Personnage cible)
        {
            nbPixel = pixel;
            sonReceiver = cible;
        }

        public bool Executer()
        {
            return sonReceiver.DeplacerEnHaut(nbPixel);
        }

        public bool Annuler()
        {
            return sonReceiver.DeplacerEnBas(nbPixel);
        }

        public string GetString()
        {
            return "Haut(" + nbPixel + ")";
        }
    }
}
