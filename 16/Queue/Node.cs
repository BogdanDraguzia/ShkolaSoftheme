using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queue
{
    class Node<T>
    {
        public T Value;
        public Node<T> Next;

        public Node(T value)
        {
            Value = value;
        }

        public Node()
        { }

        public Node<T> Clone ()
        {
            var tmp = new Node<T>(this.Value);
            tmp.Next = this.Next;
            return tmp;
        }

    }
}
