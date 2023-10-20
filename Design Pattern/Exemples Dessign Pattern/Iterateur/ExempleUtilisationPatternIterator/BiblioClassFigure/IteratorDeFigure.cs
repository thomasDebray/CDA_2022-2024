using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiblioClassFigure
{
    public class FigureIterator : IEnumerator<Figure>
    {
        Figures figures;
        int iCurrent;

        public FigureIterator(Figures figures)
        {
            this.figures = figures;
            iCurrent = -1;
        }

        public Figure Current => figures[iCurrent];

        object IEnumerator.Current => figures[iCurrent];

        public void Dispose()
        {
            //throw new NotImplementedException();
        }

        public bool MoveNext()
        {
            if (iCurrent < figures.Count -1)
            {
                iCurrent++; 
                return true;
            }
            else 
            {
                Console.WriteLine("Il n'y a pas d'autre élément dans la liste");
                return false;
            }
            
        }

        public void Reset()
        {
            iCurrent = -1;
        }
    }
}
