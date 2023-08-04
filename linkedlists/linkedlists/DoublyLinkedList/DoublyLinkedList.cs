using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace linkedlists.DoublyLinkedList
{
    public class DoublyLinkedList<T> : IEnumerable
    {
        public DoublyLinkedListNode<T> Head { get; set; }
        public DoublyLinkedListNode<T> Tail { get; set; }
        private bool IsHeadNull => Head == null ? true : false;
        private bool IsTailNull => Head == null ? true : false;

        public DoublyLinkedList()
        {
            
        }

        public DoublyLinkedList(IEnumerable<T> collection)
        {
            foreach (var item in collection)
            {
                AddLast(item);
            }
        }

        // Inserting at the beginning (Head) O(1).
        public void AddFirst(T value)
        {
            var newNode = new DoublyLinkedListNode<T>(value);

            if (Head != null)
            {
                Head.Prev = newNode;
            }

            newNode.Next = Head;
            newNode.Prev = null;
            Head = newNode;

            if (Tail == null)
            {
                Tail = Head;
            }
        }

        // Inserting at the ending (Tail ->  NULL) O(1).
        public void AddLast(T value)
        {
            if (Tail == null)
            {
                AddFirst(value);
                return;
            }

            var newNode = new DoublyLinkedListNode<T>(value);
            Tail.Next = newNode;

            newNode.Next = null;
            newNode.Prev = Tail;
            Tail = newNode;

            return;
        }

        // Inserting at the given position O(n).
        public void AddAfter(DoublyLinkedListNode<T> refNode, DoublyLinkedListNode<T> newNode)
        {
            if (refNode == null)
            {
                throw new ArgumentNullException();
            }

            if (refNode == Head && refNode == Tail)
            {
                refNode.Next = newNode;
                refNode.Prev = null;

                newNode.Prev = refNode;
                newNode.Next = null;

                Head = refNode;
                Tail = newNode;

                return;
            }

            if (refNode != Tail)    // middle
            {
                newNode.Prev = refNode;
                newNode.Next = refNode.Next;

                refNode.Next.Prev = newNode;
                refNode.Next = newNode;
            }
            else      
            {
                newNode.Prev = refNode;
                newNode.Next = null;

                refNode.Next = newNode;
                Tail = newNode;
            }
        }

        public void AddBefore(DoublyLinkedListNode<T> refNode, DoublyLinkedListNode<T> newNode)
        {
            if (refNode == null)
            {
                throw new ArgumentNullException();
            }

            if (refNode == Head && refNode == Tail)
            {
                refNode.Prev = newNode;
                refNode.Next= null;

                newNode.Next = refNode;
                newNode.Prev = null;

                Head = newNode;
                Tail = refNode;

                return;
            }

            if (refNode != Tail)    // middle
            {

                newNode.Prev = refNode.Prev;
                newNode.Next = refNode;

                refNode.Prev.Next = newNode;
                refNode.Prev = newNode;

                
            }
            else
            {
                refNode.Prev = newNode;
                refNode.Next = null;

                newNode.Next = refNode;
                Tail = refNode;
            }
        }

        // Traversing the list O(n).
        private List<DoublyLinkedListNode<T>> GetAllNodes()
        {
            var list = new List<DoublyLinkedListNode<T>>();
            var current = Head;

            while (current != null) 
            {
                list.Add(current);
                current = current.Next;
            }

            return list;
        }

        public IEnumerator GetEnumerator()
        {
            return GetAllNodes().GetEnumerator();
        }

        // Deleting at the first node O(1).
        public T RemoveFirst()
        {
            if (IsHeadNull)
            {
                throw new Exception("");
            }

            var temp = Head.Value;

            if (Head == Tail)
            {
                Head = null;
                Tail = null;
            }
            else
            {
                Head = Head.Next;
                Head.Prev = null;
            }

            return temp;
        }

        // Deleting at the last node O(1).
        public T RemoveLast()
        {
            if (IsTailNull)
            {
                throw new Exception("Empty List.");
            }

            var temp = Tail.Value;

            if (Tail == Head)
            {
                Head = null;
                Tail = null;
            }
            else
            {
                Tail.Prev.Next = null;
                Tail = Tail.Prev;
            }

            return temp;
        }

        // Deleting an intermediate node in the doubly linked list O(n).
        public void Remove(T value) 
        {
            if (IsHeadNull)
            {
                throw new Exception("Empty List.");
            }

            if (Head == Tail)
            {
                if (Head.Value.Equals(value))
                {
                    RemoveFirst();
                }
                return;
            }

            var current = Head;

            // if it consists of at least two elements:
            while (current != null)
            {
                if (current.Value.Equals(value))
                {
                    // current -> first node
                    if (current.Prev == null)
                    {
                        current.Next.Prev = null;
                        Head = current.Next;
                    }
                    // current -> last node
                    else if (current.Next == null)
                    {
                        current.Prev.Next = null;
                        Tail = current.Prev;
                    }
                    // current -> node from middle
                    else
                    {
                        current.Prev.Next = current.Next;
                        current.Next.Prev = current.Prev;
                    }

                    break;
                }
                
                current = current.Next;
            }
        }
    }
}
