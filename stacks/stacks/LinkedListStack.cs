namespace stacks
{
    public class LinkedListStack<T> : IStack<T>
    {   // FILO
        public int Count { get; private set; }
        private readonly LinkedList<T> list = new LinkedList<T>();

        public T Peek()         // Show Head
        {
            if (Count == 0)
            {
                throw new Exception("Empty Stack!");
            }

            return list.First.Value;
        }

        public T Pop()          // Decrease Head
        {
            if (Count == 0)
            {
                throw new Exception("Empty Stack!");
            }

            var temp = list.First.Value;
            list.RemoveFirst();
            Count--;

            return temp;
        }

        public void Push(T value)       // Add Head
        {
            if (value == null)
            {
                throw new ArgumentNullException();
            }

            list.AddFirst(value);
            Count++;
        }
    }
}