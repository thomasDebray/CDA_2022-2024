using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice_9
{
    public class Moteur
    {
        private bool enMarche;

        public Moteur()
        {
            enMarche = false;
        }
        public Moteur(bool _enMarche)
        {
            enMarche = _enMarche;
        }
        public Moteur(Moteur copieDeMoteur)
        {
            this.enMarche=copieDeMoteur.enMarche;
        }
        /*public bool Demarrer(bool vraiOuFaux)
        {
            if (enMarche == false && vraiOuFaux == true)
            {
                enMarche = true;
                return true;
            }
            if (enMarche == true && vraiOuFaux == false)
            {
                enMarche = false;
                return true;
            }
            else
                return false;
        }*/

        public bool Demarrer()
        {
            if (enMarche == false )
            {
                enMarche = true;
                return true;
            }
            else
                return false;
        }

        public bool Arreter()
        {
            if (enMarche == true)
            {
                enMarche = false;
                return true;
            }
            else
                return false;
        }

        public bool EntrainerRoues(Roue[] roues)
        {
            if (enMarche == true)
            {
                bool aReussiATourner = true;
                for (int i = 0; i < roues.Length; i++)
                {
                    aReussiATourner = aReussiATourner & roues[i].Tourner(); 
                }
                return aReussiATourner;
            }
            else
                return false;
            
        }

    }
}
