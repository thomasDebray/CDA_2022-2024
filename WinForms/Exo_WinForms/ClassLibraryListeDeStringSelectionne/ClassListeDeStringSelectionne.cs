using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryListeDeStringSelectionne
{
    public class ClassListeDeStringSelectionne
    {
        private Dictionary<string,bool> mesElements;

        public ClassListeDeStringSelectionne()
        {
            this.mesElements = new Dictionary<string,bool>();
        }
        public Dictionary<string,bool> MesElements { get { return mesElements; } set { mesElements = value; } }

        public void AjouterElement(string entree)
        {
            this.mesElements.Add(entree,false);
        }
        public void SelectionnerElement(string entree)
        {
            mesElements[entree] = true;
        }
        public void DeselectionnerElement(string entree)
        {
            mesElements[entree] = false;
        }
    }
}
