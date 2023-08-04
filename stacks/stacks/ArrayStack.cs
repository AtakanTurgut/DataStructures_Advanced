﻿namespace stacks
{
    public class ArrayStack<T> : IStack<T>
    {
        public int Count { get; private set; }
        private readonly List<T> list = new List<T>();

        public T Peek()         // Show Top
        {
            if (Count == 0)
            {
                throw new Exception("Empty Stack!");
            }

            return list[list.Count - 1];
        }       

        public T Pop()          // Decrease Top
        {
            if (Count == 0)
            {
                throw new Exception("Empty Stack!");
            }

            var temp = list[list.Count - 1];

            list.RemoveAt(list.Count - 1);
            Count--;

            return temp;
        }       

        public void Push(T value)       // Add Top
        {
            if (value == null)
            {
                throw new ArgumentNullException();
            }

            list.Add(value);
            Count++;
        }   
    }
}