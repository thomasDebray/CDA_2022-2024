using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice_9
{
    public class Voiture
    {
        private Moteur sonMoteur;
        private Roue[] sesRoues;

        public Voiture()
        {
            sonMoteur = new Moteur();
            /*sesRoues = new Roue[4];
            sesRoues[0] = new Roue();
            sesRoues[1] = new Roue();
            sesRoues[2] = new Roue();
            sesRoues[3] = new Roue();
            Roue roue = new Roue();
            sesRoues = new Roue[] { roue, roue, roue, roue };*/
            sesRoues = new Roue[4];
            for (int i = 0; i < sesRoues.Length; i++)
                sesRoues[i] = new Roue();
            
        }
        private Voiture(Moteur _sonMoteur,Roue[] _sesRoues)
        {
            this.sonMoteur= _sonMoteur;
            this.sesRoues = _sesRoues;
        }

        public Voiture(Moteur _sonMoteur, Roue _roueAvantDroite, Roue _roueAvantGauche, Roue _roueArriereDroite, Roue _roueArriereGauche)
        :this(_sonMoteur,new Roue[] { _roueAvantDroite , _roueAvantGauche , _roueArriereDroite , _roueArriereGauche })
        {
        }

        public Voiture(Voiture voitureACopier)
            : this(new Moteur(voitureACopier.sonMoteur), new Roue[] 
            {new Roue(voitureACopier.sesRoues[0]),new Roue(voitureACopier.sesRoues[1]),
            new Roue(voitureACopier.sesRoues[2]),new Roue(voitureACopier.sesRoues[3])}) { }

        /// <summary>
        /// Arrête chaque roues ainsi que le moteur
        /// </summary>
        /// <returns>True si toutes les roues ont réussis à s'arrêter et le moteur aussi </returns>
        public bool Arreter()
        {
            bool aReussiASArreter = true;
            for (int i = 0; i < sesRoues.Length; i++)
            {
                aReussiASArreter = aReussiASArreter && sesRoues[i].ArreterDeTourner();
            }
            if (aReussiASArreter)
            {
                return aReussiASArreter && sonMoteur.Arreter();
            }
            return false;
        }
        /// <summary>
        /// Demande au moteur d'entrainer les roues en les faisant tourner
        /// </summary>
        /// <returns>True si l'opération a réussi</returns>
        public bool Avancer()
        {
            return sonMoteur.EntrainerRoues(sesRoues);
        }
        /// <summary>
        /// Demarre le moteur
        /// </summary>
        /// <returns>True si l'opération a réussi</returns>
        public bool Demarrer()
        {
            return sonMoteur.Demarrer();
            
        }
    }
}
