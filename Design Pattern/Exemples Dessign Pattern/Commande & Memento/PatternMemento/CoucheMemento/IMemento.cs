using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoucheMemento
{
    public interface IMemento<T> where T : ICloneable
    {
        public void Restore();

        public DateTime GetDate();
    }
}
