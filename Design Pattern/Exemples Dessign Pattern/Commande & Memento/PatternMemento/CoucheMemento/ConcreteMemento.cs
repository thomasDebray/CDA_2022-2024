using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoucheMemento
{
    public class ConcreteMemento<T> : IMemento<T> where T : ICloneable
    {
        private T transactionClonee;
        private DateTime dateMemento;
        private IOriginator<T> originator;
        public ConcreteMemento(IOriginator<T> originator, T transaction)
        {
            this.transactionClonee = (T)transaction.Clone();
            this.originator = originator;
            this.dateMemento = DateTime.Now;
        }
        public DateTime GetDate()
        {
            return dateMemento;
        }

        public void Restore()
        {
            originator.SetState(transactionClonee);
        }
    }
}
