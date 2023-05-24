using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary_additionneur
{
    public class Addition
    {
        private List<int> listeDeChiffres;

        public Addition()
        {
            listeDeChiffres = new List<int>();
            listeDeChiffres.Add(0);
        }
        public void AjouterChiffre(int chiffre)
        {
            listeDeChiffres.Add(chiffre);
        }
        public int Evaluer()
        {
            int somme = 0;
            for (int i = 0; i < listeDeChiffres.Count; i++)
            {
                somme += listeDeChiffres[i];
            }
            return somme;
        }
    } 
}
