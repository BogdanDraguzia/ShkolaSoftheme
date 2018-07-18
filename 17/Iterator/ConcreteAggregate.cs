using System;
using System.Collections;
using System.Linq;

namespace Iterator
{
    class ConcreteAggregate<T> : Aggregate<T>
    {
        private readonly T[] _items = new T[20]; //to do: Resize when full

        public override Iterator<T> CreateIterator()
        {
            return new ConcreteIterator<T>(this);
        }

        public int Count { get; private set; }

        private void Insert(int index, T value)
        {
            _items[index] = value;
            Count++;
        }

        public object this[int index]
        {
            get { return _items[index]; }
            set { Insert(index, (T)value); }
        }
    }
}