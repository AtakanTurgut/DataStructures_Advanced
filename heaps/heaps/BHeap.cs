using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace heaps
{
    public abstract class BHeap<T> : IEnumerable<T> 
        where T : IComparable 
    {
        public T[] Array { get; private set; }
        protected int Position;
        public int Count { get; private set; }

        public BHeap()
        {
            Count = 0;
            Array = new T[128];
            Position = 0;
        }

        public BHeap(int _size)
        {
            Count = 0;
            Array = new T[_size];
            Position = 0;
        }

        public BHeap(IEnumerable<T> collection)
        {
            Count = 0;
            Array = new T[collection.ToArray().Length];
            Position = 0;

            foreach (var item in collection)
            {
                Add(item);
            }
        }

        protected int GetLeftChildIndex(int i) => 2 * i + 1;
        protected int GetRightChildIndex(int i) => 2 * i + 2;
        protected int GetParentIndex(int i) => (i - 1) / 2;

        protected bool HasLeftChild(int i) => GetLeftChildIndex(i) < Position;
        protected bool HasRightChild(int i) => GetRightChildIndex(i) < Position;
        protected bool IsRoot(int i) => i == 0;

        protected T GetLeftChild(int i) => Array[GetLeftChildIndex(i)];
        protected T GetRightChild(int i) => Array[GetRightChildIndex(i)];
        protected T GetParent(int i) => Array[GetParentIndex(i)];

        public bool IsEmpty() => Position == 0;

        public T Peek()
        {
            if (IsEmpty()) throw new Exception("Empty Heap!");

            return Array[0];
        }

        public void Swap(int first, int second)
        {
            var temp = Array[first];
            Array[first] = Array[second];
            Array[second] = temp;
        }
        public void Add(T value)
        {
            if (Position == Array.Length) throw new IndexOutOfRangeException("Overflow!");

            Array[Position] = value;
            Position++;
            Count++;
            HeapifyUp();
        }
        public T DeleteMinMax()
        {
            if (Position == 0) throw new IndexOutOfRangeException("Underflow!");

            var temp = Array[0];
            Array[0] = Array[Position - 1];
            Position--;
            Count--;
            HeapifyDown();

            return temp;
        }

        protected abstract void HeapifyUp();
        protected abstract void HeapifyDown();

        public IEnumerator<T> GetEnumerator()
        {
            return Array.Take(Position).GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
