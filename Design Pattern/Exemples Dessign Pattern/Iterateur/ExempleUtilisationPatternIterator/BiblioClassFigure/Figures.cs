using BiblioClassFigure;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace BiblioClassFigure
{
    public class Figures : Figure,IEnumerable<Figure>,IList<Figure>
    {
        List<Figure> sesFigures;



        public Figures(double x, double y) : base(x, y)
        {
            sesFigures = new List<Figure>();
        }
        public override void Draw()
        {
            Console.WriteLine("Je suis une figure");
            foreach (var f in sesFigures)
            {
                f.Draw();
            }
        }
        public override string ToString()
        {
            string r=  base.ToString();
            foreach (Figure f in sesFigures)
            {
                r += f.ToString();
            }
            return r;
        }

        public void Remove(Figure figure)
        {
            sesFigures.Remove(figure);
        }
        public void Add(Figure figure)
        {
            sesFigures.Add(figure);
        }
        


        #region IEnumerator
        public IEnumerator<Figure> GetEnumerator()
        {
            return new FigureIterator(this);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
             return new FigureIterator(this);
        }
        #endregion

        #region IList
        public int Count => sesFigures.Count;

        public Figure this[int index] { get => sesFigures[index]; set => sesFigures[index] = value; }


        public bool IsReadOnly => throw new NotImplementedException();

        public int IndexOf(Figure item)
        {
            throw new NotImplementedException();
        }

        public void Insert(int index, Figure item)
        {
            throw new NotImplementedException();
        }

        public void RemoveAt(int index)
        {
            throw new NotImplementedException();
        }

        public void Clear()
        {
            throw new NotImplementedException();
        }

        public bool Contains(Figure item)
        {
            throw new NotImplementedException();
        }

        public void CopyTo(Figure[] array, int arrayIndex)
        {
            throw new NotImplementedException();
        }

        bool ICollection<Figure>.Remove(Figure item)
        {
            throw new NotImplementedException();
        }
        #endregion
    }
}
