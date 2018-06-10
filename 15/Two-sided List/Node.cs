namespace Two_sided_List
{
    class Node<T>
    {
        public Node<T> Previous { get; set; }
        public Node<T> Next { get; set; }
        public T Value { get; set; }

        public Node(Node<T> prev, Node<T> next, T val)
        {
            Previous = prev;
            Next = next;
            Value = val;
        }

        public Node<T> Clone()
        {
            return new Node<T>(Previous, Next, Value);
        }

        public override string ToString()
        {
            return Value.ToString();
        }
    }
}