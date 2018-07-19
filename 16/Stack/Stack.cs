using System;

namespace Stack
{
    public class Stack<T>
    {
        public Node<T> Head;

        public void Push(T item)
        {
            if (Head == null)
            {
                Head = new Node<T>(){Value = item};
                Head.Next = null;
                
            }
            else
            {
                var tmp = Head;
                
                Head = new Node<T>() {Value =  item};
                Head.Next = tmp;
            }
        }

        public T Pop()
        {
            if (Head == null)
            {
                throw new ArgumentNullException();
            }
            else if (Head.Next == null)
            {
                var tmp = Head.Value;
                Head = null;
                return tmp;
            }
            else
            {
                var tmp = Head.Value;
                Head = Head.Next;
                return tmp;
            }
        }

        public T Peek()
        {
            if (Head == null )
            {
                throw new NullReferenceException();
            }
            else
            {
                return Head.Value;
            }
        }

    }
}