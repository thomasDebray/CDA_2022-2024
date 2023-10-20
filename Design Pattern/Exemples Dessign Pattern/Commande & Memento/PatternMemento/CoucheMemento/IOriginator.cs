using PatternMemento;

namespace CoucheMemento
{
    public interface IOriginator<T> where T : ICloneable
    {
        public void SetState(T _obj);

        public IMemento<T> Save();
    }
}