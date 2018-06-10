using System;
using System.Collections;
using System.Collections.Generic;

namespace Two_sided_List
{
    class List<T> : IEnumerable<T>, IEnumerator<T>


    {
        public Node<T> Head { get; set; }
        private Node<T> Current { get; set; }
        public int Count { get; private set; }

        #region Implementing methods from IEnumerable and IEnumerator

        public bool MoveNext()
        {
            var tmp = Current;
            Current = Current.Next;
            return tmp.Next != null;
        }

        public void Reset()
        {
            var tmp = Current;
            Current = Head.Clone();
        }

        T IEnumerator<T>.Current => Current.Value;

        object IEnumerator.Current
        {
            get => Current;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public IEnumerator<T> GetEnumerator()
        {
            var tmp = new Node<T>(null, Head, default(T));

            for (int i = 0; i <= Count - 1; i++)
            {
                if (tmp.Next != null)
                {
                    tmp = tmp.Next.Clone();
                }

                yield return tmp.Value;
            }
        }


        public void Dispose()
        {
            throw new NotImplementedException();
        }

        #endregion

        public List()
        {
            Count = 0;
        }

        public void Add(T value)
        {
            switch (Count)
            {
                case 0:
                    Head = new Node<T>(null, null, value);
                    Current = Head; // Current указывает на Head
                    Count++;
                    break;

                case 1:
                    Head.Next = new Node<T>(Head, null, value);
                    Current = Head.Next;
                    Count++;
                    break;
                default:
                    var tmp = Current;
                    tmp.Next = new Node<T>(tmp, null, value);
                    Current = tmp.Next;
                    Count++;
                    break;
            }
        }

        public void AddFirst(T value)
        {
            switch (Count)
            {
                case 0:
                    Head = new Node<T>(null, null, value);
                    Current = Head; // Current указывает на Head
                    Count++;
                    break;
                case 1:
                    var tmp = Head;
                    Head = new Node<T>(null, tmp, value);
                    Count++;
                    break;
                default:
                    var tmp1 = Head;
                    Head = new Node<T>(null, tmp1, value);
                    Count++;
                    break;
            }
        }

        public void DeleteLast()
        {
            switch (Count)
            {
                case 0:
                    throw new Exception("Empty List");
                    break;
                case 1:
                    Head = null;
                    Current = null;
                    Count = 0;
                    break;
                case 2:
                    Current = Head;
                    Head.Next = null;
                    Count = 1;
                    break;
                default:
                    var tmp = Current.Previous;
                    Current = tmp;
                    Count--;
                    break;
            }
        }

        public T[] ToArray()
        {
            var tmp = Head.Clone();
            T[] array = new T[Count];
            for (int i = 0; i < Count; i++)
            {
                if (i != 0)
                {
                    tmp = tmp.Next.Clone();
                }

                array[i] = tmp.Value;
            }

            return array;
        }

        public bool Contains(T element)
        {
            foreach (T v in this)
            {
                if (v.Equals(element))
                {
                    return true;
                }
            }

            return false;
        }
    }
}