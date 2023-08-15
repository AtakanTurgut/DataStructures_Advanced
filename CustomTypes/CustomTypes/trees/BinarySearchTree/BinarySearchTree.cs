using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomTypes.trees.BinarySearchTree
{
    public class BinarySearchTree<T> : IEnumerable<T> where T : IComparable
        // T > 0 == +1 (larger); T = 0 == 0; T < 0 == -1 (smaller);
    {
        public BinarySearchTreeNode<T> Root { get; set; }

        public BinarySearchTree()
        {
            
        }
        public BinarySearchTree(IEnumerable<T> collection)
        {
            foreach (var item in collection)
            {
                Add(item);
            }
        }

        public void Add(T value)
        {
            if (value == null) throw new ArgumentNullException();
           
            var newNode = new BinarySearchTreeNode<T>(value);

            if (Root == null)
            {
                Root = newNode;
            }
            else
            {
                var current = Root;
                BinarySearchTreeNode<T> parent;

                while (true)
                {
                    parent = current;

                    // Left Subtree (smaller than Root)
                    if (value.CompareTo(current.Value) < 0) //  T < 0 == -1;
                    {
                        current = current.Left;

                        if (current == null)
                        {
                            parent.Left = newNode;
                            break;
                        }
                    }
                    // Right Subtree (larger than Root)
                    else
                    {
                        current = current.Right;

                        if (current == null)
                        {
                            parent.Right = newNode;
                            break;
                        }
                    }
                }
            }
        }

        public BinarySearchTreeNode<T> FindMin(BinarySearchTreeNode<T> root)
        {
            var current = root;

            while (!(current.Left == null))
            {
                current = current.Left;
            }

            return current;
        }

        public BinarySearchTreeNode<T> FindMax(BinarySearchTreeNode<T> root)
        {
            var current = root;

            while (!(current.Right == null))
            {
                current = current.Right;
            }

            return current;
        }

        public BinarySearchTreeNode<T> Find(BinarySearchTreeNode<T> root,T key)
        {
            var current = root;

            // T > 0 == +1 (larger); T = 0 == 0; T < 0 == -1 (smaller);
            while (key.CompareTo(current.Value) != 0)
            {
                if (key.CompareTo(current.Value) < 0) current = current.Left;
                else current = current.Right;

                if (current == null) return default(BinarySearchTreeNode<T>);
            }

            return current;
        }

        public BinarySearchTreeNode<T> Remove(BinarySearchTreeNode<T> root, T key)
        {
            if (root == null) return root; //throw new ArgumentNullException(); 

            // Recursive
            // T > 0 == +1 (larger); T = 0 == 0; T < 0 == -1 (smaller);
            if (key.CompareTo(root.Value) < 0)
            {
                root.Left = Remove(root.Left, key);
            }
            else if (key.CompareTo(root.Value) > 0)
            {
                root.Right = Remove(root.Right, key);
            }
            else
            {
                // delete key
                // one child or childless
                if (root.Left == null)
                {
                    return root.Right;
                }
                else if(root.Right == null)
                {
                    return root.Left;
                }

                // two children
                root.Value = FindMin(root.Right).Value;
                root.Right = Remove(root.Right, root.Value);                
            }

            return root;
        }

        public IEnumerator<T> GetEnumerator()
        {
            return new BinarySearchTreeEnumerator<T>(Root);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
