using PatternMemento;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoucheMemento
{
    public class ConcreteOriginator : IOriginator<Transaction>
    {
        private Transaction saTransaction;
        public ConcreteOriginator(Transaction obj) {
            saTransaction = obj;
        }
        public IMemento<Transaction> Save()
        {
            return new ConcreteMemento<Transaction>(this,saTransaction);
        }

        public void SetState(Transaction _obj)
        {
            saTransaction = _obj;
        }
    }
}
