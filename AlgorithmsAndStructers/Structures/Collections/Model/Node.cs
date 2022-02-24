namespace Structures.Collections.Model
{
    public class Node<T>
    {
        public T Value { get; set; }
        public Node<T> Previous { get; set; }
        public Node<T> Next { get; set; }

        public Node(T data)
        {
            Value = data;
        }

        public override string ToString()
        {
            return Value.ToString();
        }
    }
}
