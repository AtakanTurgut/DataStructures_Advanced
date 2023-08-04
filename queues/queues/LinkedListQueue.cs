namespace queues
{
    public class LinkedListQueue<T> : IQueue<T>
    {
        public int Count { get; private set; }
        private readonly LinkedList<T> list = new LinkedList<T>();

        public T DeQueue()
        {
            if (Count == 0) throw new Exception("Empty Queue!");

            var temp = list.First.Value;
            list.RemoveFirst();
            Count--;

            return temp;
        }

        public void EnQueue(T value)
        {
            if (value == null) throw new ArgumentNullException();

            list.AddLast(value);
            Count++;
        }

        public T Peek() => Count == 0 
            ? throw new Exception("Empty Queue!") 
            : list.First.Value;
    }
}