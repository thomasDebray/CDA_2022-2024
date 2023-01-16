using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice_9
{
    public class Roue
    {
        private bool enMouvement;

        public Roue()
        {
            enMouvement = false;
        }
        public Roue(bool enMouvement)
        {
            this.enMouvement = enMouvement;
        }
        public Roue(Roue copieDeRoue): this(copieDeRoue.enMouvement)
        {

        }

        

        public bool Tourner()
        {
            if (enMouvement == false)
            {
                enMouvement = true;
                return true;
            }
            else
                return false;
        }
        public bool ArreterDeTourner()
        {
            if (enMouvement == true)
            {
                enMouvement = false;
                return true;
            }
            else
                return false;
        }
    }
}
