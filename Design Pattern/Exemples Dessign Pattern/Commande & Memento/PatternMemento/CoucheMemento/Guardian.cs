using PatternMemento;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoucheMemento
{
    public class Guardian<T> where T : ICloneable
    {
        private Stack<IMemento<T>> history;

        public Guardian()
        {
            history = new();
        }

        public void AjouterMemento(IMemento<T> memento)
        {
            history.Push(memento);
        }

        public void Undo()
        {
            if (history.Count < 1)
                return;
            IMemento<T> mementoAAnnuler = history.Pop();
            mementoAAnnuler.Restore();
        }
    }
}
