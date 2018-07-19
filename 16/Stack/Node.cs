namespace Stack
{
    public class Node<T>
    {
        public Node<T> Next;
        public T Value;

        public Node<T> Clone()
        {
            return  new Node<T>(){Value = this.Value};
        }
    }
}