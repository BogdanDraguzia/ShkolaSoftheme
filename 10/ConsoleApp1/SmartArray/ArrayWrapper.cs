using System;

namespace SmartArray
{
    internal class ArrayWrapper
    {
        public int[] Array { get; set; }

        public int Length => Array.Length;

        public void Add(int element)
        {
            var newArr = new int[Array.Length + 1];
            for (var i = 0; i < Array.Length; i++) newArr[i] = Array[i];

            newArr[Array.Length] = element;
            Array = newArr;
        }

        public void Add(int element, int position)
        {
            if (position <= Array.Length && position >= 0)
            {
                var newArr = new int[Array.Length + 1];
                for (var i = 0; i < position; i++) newArr[i] = Array[i];

                newArr[position] = element;
                for (var i = position + 1; i < newArr.Length; i++) newArr[i] = Array[i - 1];

                Array = newArr;
            }
            else
            {
                throw new IndexOutOfRangeException("incorrect position");
            }
        }

        public bool Contains(int element)
        {
            var result = false;
            foreach (var item in Array)
                if (item == element)
                {
                    result = true;
                    break;
                }

            return result;
        }

        public int GetByIndex(int index)
        {
            if (index >= 0 && index < Array.Length)
                return Array[index];
            throw new IndexOutOfRangeException("Incorrect index");
        }

        public override string ToString()
        {
            var result = string.Empty;
            foreach (var s in Array) result += string.Format("{0} ", s);

            return result;
        }
    }
}