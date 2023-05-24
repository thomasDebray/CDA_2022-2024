using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary5Verification
{
    public static class Verification
    {
        public static bool ElementValide(int longeurTexte,int nbIterationComboBox,int nbiterationListBox)
        {
            if (longeurTexte != 0 && nbIterationComboBox == -1 && nbiterationListBox == -1)
            {
                return true;
            }
            return false;
        }
    }
}
