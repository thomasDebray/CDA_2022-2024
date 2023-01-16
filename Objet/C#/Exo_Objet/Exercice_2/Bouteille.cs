using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice_2
{
    public class Bouteille
    {
        private bool ouvert;
        private float remplissageDeLaBouteilleEnPourcentage;
        private float capaciteeEnL;


        public Bouteille():this(false,100,1)
        {
        }

        public Bouteille(bool ouvert,float remplissageEnPourcentage ,float capaciteeEnL)
        {
            this.ouvert = ouvert;
            this.remplissageDeLaBouteilleEnPourcentage = remplissageEnPourcentage;
            this.capaciteeEnL = capaciteeEnL;
        }

        /*public Bouteille(Bouteille bouteilleACopier)
        {
            this.ouvert = bouteilleACopier.ouvert;
            this.remplissageDeLaBouteilleEnPourcentage = bouteilleACopier.remplissageDeLaBouteilleEnPourcentage;
            this.capaciteeEnL = bouteilleACopier.capaciteeEnL;
        }*/

        public Bouteille(Bouteille bouteilleACopier)
            :this(bouteilleACopier.ouvert, bouteilleACopier.remplissageDeLaBouteilleEnPourcentage, bouteilleACopier.capaciteeEnL)
        {
        }
        /// <summary>
        /// Action de fermer la bouteille
        /// </summary>
        /// <returns>Action réalisée</returns>
        public bool Fermer()
        {
            if (ouvert == true)
            {
                ouvert = false;
                return true;
            }
            else
                return false;
        }
        /// <summary>
        /// Action d'ouvrir la bouteille
        /// </summary>
        /// <returns>Action réalisée</returns>
        public bool Ouvrir()
        {
            if (ouvert == false)
            {
                ouvert=true;
                return true;
            }
            else
                return false;
        }
        /// <summary>
        /// Remplissage de la bouteille avec un pourcentage de liquide
        /// </summary>
        /// <param name="pourcentageDuContenuAjouteOuRetire">Quantité en pourcentage à ajouter</param>
        /// <returns>Action réalisée</returns>
        public bool Remplir(float pourcentageDuContenuAjouteOuRetire)
        {
            if (ouvert == true && remplissageDeLaBouteilleEnPourcentage < 100 && pourcentageDuContenuAjouteOuRetire>0 && remplissageDeLaBouteilleEnPourcentage+pourcentageDuContenuAjouteOuRetire<=100 )
            {
                remplissageDeLaBouteilleEnPourcentage = remplissageDeLaBouteilleEnPourcentage + pourcentageDuContenuAjouteOuRetire;
                return true;
            }
            else
                return false;
        }
        /// <summary>
        /// Vidage de la bouteille avec un pourcentage de liquide
        /// </summary>
        /// <param name="pourcentageDuContenuAjouteOuRetire">Quantité en pourcentage à vider</param>
        /// <returns>Action réalisée</returns>
        public bool Vider(float pourcentageDuContenuAjouteOuRetire)
        {
            if (ouvert == true && remplissageDeLaBouteilleEnPourcentage > 0 && pourcentageDuContenuAjouteOuRetire > 0 && pourcentageDuContenuAjouteOuRetire <= remplissageDeLaBouteilleEnPourcentage)
            {
                remplissageDeLaBouteilleEnPourcentage = remplissageDeLaBouteilleEnPourcentage - pourcentageDuContenuAjouteOuRetire;
                return true;
            }
            else
                return false;
        }
        /*
        public bool ViderTout()
        {
            if (ouvert == true && remplissageDeLaBouteilleEnPourcentage > 0)
            {
                remplissageDeLaBouteilleEnPourcentage = 0;
                return true;
            }
            else
                return false;
        }
        */
        /// <summary>
        /// Vidage de la bouteille dans sa totalité
        /// </summary>
        /// <returns>Action réalisée</returns>
        public bool ViderTout()
        {
            return Vider(remplissageDeLaBouteilleEnPourcentage);    
        }
        /// <summary>
        /// Remplissage dans la totalité la bouteille
        /// </summary>
        /// <returns>Action réalisée</returns>
        public bool RemplirTout()
        {
            if (ouvert == true && remplissageDeLaBouteilleEnPourcentage < 100)
            {
                remplissageDeLaBouteilleEnPourcentage = 100;
                return true;
            }
            else
                return false;
        }

    }
}
