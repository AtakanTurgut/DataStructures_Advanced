using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace linkedlists.SinglyLinkedList
{
    public class SinglyLinkedList<T> : IEnumerable<T>
    {
        public SinglyLinkedList()
        {
            
        }

        public SinglyLinkedList(IEnumerable<T> collection)
        {
            foreach (var item in collection)
            {
                this.AddLast(item);
            }
        }

        public SinglyLinkedListNode<T> Head { get; set; }
        private bool IsHeadNull => Head == null ? true : false;

        // Inserting at the beginning (Head) O(1).
        public void AddFirst(T value)
        {
            var newNode = new SinglyLinkedListNode<T>(value);
            newNode.Next = Head;
            Head = newNode;
        }

        // Inserting at the ending (Tail -> NULL) O(n).
        public void AddLast(T value)
        {
            var newNode = new SinglyLinkedListNode<T>(value);

            if (IsHeadNull)
            {
                Head = newNode;
                return;
            }

            var current = Head;

            while (current.Next != null) 
            {
                current = current.Next;
            }

            current.Next = newNode;
        }

        // Inserting at the middle O(n).
        public void AddAfter(SinglyLinkedListNode<T> node, T value)
        {
            if (node == null)
            {
                throw new ArgumentException();
            }

            if (IsHeadNull)
            {
                AddFirst(value);
                return;
            }

            var newNode = new SinglyLinkedListNode<T>(value);
            var current = Head;

            while (current != null)
            {
                if (current.Equals(node))
                {
                    newNode.Next = current.Next;
                    current.Next = newNode;
                    return;
                }

                current = current.Next;
            }
            throw new ArgumentException("The reference node is not in this list.");
        }

        public void AddAfter(SinglyLinkedListNode<T> refNode, SinglyLinkedListNode<T> newNode)
        {
            if (refNode == null)
            {
                throw new ArgumentException();
            }

            if (IsHeadNull)
            {
                Head = refNode;
                return;
            }

            var current = Head;

            while (current != null)
            {
                if (current == refNode)
                {
                    newNode.Next = current.Next;
                    current.Next = newNode;
                    return;
                }

                current = current.Next;
            }
            throw new ArgumentException("The reference node is not in this list.");
        }

        public void AddBefore(SinglyLinkedListNode<T> node, T value)
        {
            if (node == null)
            {
                throw new ArgumentException();
            }

            if (IsHeadNull)
            {
                AddFirst(value);
                return;
            }

            var newNode = new SinglyLinkedListNode<T>(value);
            var current = Head;

            while (current != null)
            {
                if (current.Next == node)
                {
                    newNode.Next = current.Next;
                    current.Next = newNode;
                    return;
                }

                current = current.Next;
            }
            throw new ArgumentException("The reference node is not in this list.");
        }

        public void AddBefore(SinglyLinkedListNode<T> refNode, SinglyLinkedListNode<T> newNode)
        {
            if (refNode == null)
            {
                throw new ArgumentException();
            }

            if (IsHeadNull)
            {
                Head = refNode;
                return;
            }

            var current = Head;

            while (current != null)
            {
                if (current.Next == refNode)
                {
                    newNode.Next = current.Next;
                    current.Next = newNode;
                    return;
                }

                current = current.Next;
            }
            throw new ArgumentException("The reference node is not in this list.");
        }

        public IEnumerator<T> GetEnumerator()
        {
            return new SinglyLinkedListEnumerator<T>(Head);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public T RemoveFirst()
        {
            if (IsHeadNull)
            {
                throw new Exception("Underflow! Nothing to remove.");
            }

            var firstValue = Head.Value;
            Head = Head.Next;

            return firstValue;
        }

        public T RemoveLast()
        {
            var current = Head;
            SinglyLinkedListNode<T> prev = null;

            while (current.Next != null) 
            {
                prev = current;
                current = current.Next;
            }

            var lastValue = prev.Next.Value;
            prev.Next = null;

            return lastValue;
        }

        public void Remove(T value)
        {
            if (IsHeadNull)
            {
                throw new Exception("Underflow! Nothing to remove.");
            }

            if (value == null)
            {
                throw new ArgumentNullException();
            }

            var current = Head;
            SinglyLinkedListNode<T> prev = null;

            do
            {
                if (current.Value.Equals(value))
                {
                    if (current.Next == null)  
                    {
                        if (prev == null)   // Head
                        {
                            Head = null;
                            return;
                        }
                        else    // last Node 
                        {
                            prev.Next = null;
                            return;
                        }
                    }
                    else    
                    {
                        if (prev == null)   // Head
                        {
                            Head = Head.Next;
                            return;
                        }
                        else    // intermediate node
                        {
                            prev.Next = current.Next;
                            return;
                        }
                    }
                }

                prev = current;
                current = current.Next;

            } while (current != null);

            throw new ArgumentException("The value could not be found in the list!");
        }
    }
}
