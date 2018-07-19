using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queue
{
    class Queue<T>
    {
        public Node<T> Current;
        public Node<T> Head;
        public Node<T> Tail;


        public void Enqueue(T item)
        {
            if (this.Head == null)
            {
                Node<T> tmpNode = new Node<T>(item);
                tmpNode.Next = null;
                this.Current = tmpNode;
                this.Head = Current;
                this.Tail = Current;
            }

            else
            {
                var tmp = new Node<T>(item);
                tmp.Next = Current;
                Current = tmp;
                Tail = tmp;

            }
        }

        public T Dequeue()
        {
            if (Head == null)
            {
                throw new NullReferenceException("Empty Queue");
            }

            else if (Head == Tail)
            {
                var tmp = Head.Value;
                Head = null;
                Tail = null;
                Current = null;
                return tmp;
            }
            else if (Tail.Next == Head)
            {
                var tmp = Head.Value;
                Head = Tail;
                Head.Next = null;
                return tmp;
            }

            else
            {
                var tmp = Head.Value;

                Head = Tail.Clone();
                while (Head.Next.Next != null)
                {
                    Head = Head.Next;
                }
                Head.Next = null;
                return tmp;
            }
        }

        public T Peek()
        {
            if (Head == null)
            {
                throw new NullReferenceException("Empty Queue");
            }
            else
            {
                return Head.Clone().Value;
            }

        }
    }
}
