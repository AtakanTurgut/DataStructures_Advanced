using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using trees.BinarySearchTree;

namespace trees.BinaryTree
{
    public class BinaryTree<T> where T : IComparable
    {
        public BinaryTreeNode<T> Root { get; set; }
        public List<BinaryTreeNode<T>> listBinaryTree { get; private set; }
        public List<BinarySearchTreeNode<T>> listBinarySearchTree { get; private set; }

        public BinaryTree()
        {
            listBinaryTree = new List<BinaryTreeNode<T>>();
            listBinarySearchTree = new List<BinarySearchTreeNode<T>>();
        }

        public void ClearListBinaryTree() => listBinaryTree.Clear();
        public void ClearListBinarySearchTree() => listBinarySearchTree.Clear();

        /*    Recursive Methods    */

        #region PreOrder Recursive
        public List<BinaryTreeNode<T>> PreOrder(BinaryTreeNode<T> root)
        {
            if (!(root == null))
            {
                listBinaryTree.Add(root);

                PreOrder(root.Left);
                PreOrder(root.Right);
            }

            return listBinaryTree;
        }

        public List<BinarySearchTreeNode<T>> PreOrder(BinarySearchTreeNode<T> root)
        {
            if (!(root == null))
            {
                listBinarySearchTree.Add(root);

                PreOrder(root.Left);
                PreOrder(root.Right);
            }

            return listBinarySearchTree;
        }
        #endregion

        #region InOrder Recursive
        public List<BinaryTreeNode<T>> InOrder(BinaryTreeNode<T> root)
        {
            if (!(root == null))
            {
                InOrder(root.Left);

                listBinaryTree.Add(root);

                InOrder(root.Right);
            }

            return listBinaryTree;
        }

        public List<BinarySearchTreeNode<T>> InOrder(BinarySearchTreeNode<T> root)
        {
            if (!(root == null))
            {
                InOrder(root.Left);

                listBinarySearchTree.Add(root);

                InOrder(root.Right);
            }

            return listBinarySearchTree;
        }
        #endregion

        #region PostOrder Recursive
        public List<BinaryTreeNode<T>> PostOrder(BinaryTreeNode<T> root)
        {
            if (!(root == null))
            {
                PostOrder(root.Left);
                PostOrder(root.Right);

                listBinaryTree.Add(root);
            }

            return listBinaryTree;
        }

        public List<BinarySearchTreeNode<T>> PostOrder(BinarySearchTreeNode<T> root)
        {
            if (!(root == null))
            {
                PostOrder(root.Left);
                PostOrder(root.Right);

                listBinarySearchTree.Add(root);
            }

            return listBinarySearchTree;
        }
        #endregion

        #region Maximum Depth
        public static int MaxDepth(BinaryTreeNode<T> root)
        {
            if (root == null) return 0;

            int leftDepth = MaxDepth(root.Left);
            int rightDepth = MaxDepth(root.Right);

            return (leftDepth > rightDepth)
                ? leftDepth + 1
                : rightDepth + 1;
        }

        public static int MaxDepth(BinarySearchTreeNode<T> root)
        {
            if (root == null) return 0;

            int leftDepth = MaxDepth(root.Left);
            int rightDepth = MaxDepth(root.Right);

            return (leftDepth > rightDepth)
                ? leftDepth + 1
                : rightDepth + 1;
        }
        #endregion

        /*   NonRecursive Methods   */

        #region PreOrder NonRecursive
        public List<BinaryTreeNode<T>> PreOrderNonRecursive(BinaryTreeNode<T> root)
        {
            var listBT = new List<BinaryTreeNode<T>>();
            var stackBT = new Stack<BinaryTreeNode<T>>();

            if (root == null) throw new Exception("This Tree is empty.");

            stackBT.Push(root);

            while (!(stackBT.Count == 0))
            {
                var temp = stackBT.Pop();
                listBT.Add(temp);

                if (temp.Right != null) stackBT.Push(temp.Right);
                
                if (temp.Left != null) stackBT.Push(temp.Left);
            }

            return listBT;
        }

        public List<BinarySearchTreeNode<T>> PreOrderNonRecursive(BinarySearchTreeNode<T> root)
        {
            var listBST = new List<BinarySearchTreeNode<T>>();
            var stackBST = new Stack<BinarySearchTreeNode<T>>();

            if (root == null) throw new Exception("This Tree is empty.");

            stackBST.Push(root);

            while (!(stackBST.Count == 0))
            {
                var temp = stackBST.Pop();
                listBST.Add(temp);

                if (temp.Right != null) stackBST.Push(temp.Right);

                if (temp.Left != null) stackBST.Push(temp.Left);
            }

            return listBST;
        }
        #endregion

        #region InOrder NonRecursive
        public List<BinaryTreeNode<T>> InOrderNonRecursive(BinaryTreeNode<T> root)
        {
            var listBT = new List<BinaryTreeNode<T>>();
            var stackBT = new Stack<BinaryTreeNode<T>> ();
            BinaryTreeNode<T> currentNode = root;
            bool done = false;

            while (!done)
            {
                if (currentNode != null)
                {
                    stackBT.Push(currentNode);
                    currentNode = currentNode.Left;
                }
                else
                {
                    if (stackBT.Count == 0)
                    {
                        done = true;
                    }
                    else
                    {
                        currentNode = stackBT.Pop();
                        listBT.Add(currentNode);
                        currentNode = currentNode.Right;
                    }
                }
            }

            return listBT;
        }

        public List<BinarySearchTreeNode<T>> InOrderNonRecursive(BinarySearchTreeNode<T> root)
        {
            var listBST = new List<BinarySearchTreeNode<T>>();
            var stackBST = new Stack<BinarySearchTreeNode<T>>();
            BinarySearchTreeNode<T> currentNode = root;
            bool done = false;

            while (!done)
            {
                if (currentNode != null)
                {
                    stackBST.Push(currentNode);
                    currentNode = currentNode.Left;
                }
                else
                {
                    if (stackBST.Count == 0)
                    {
                        done = true;
                    }
                    else
                    {
                        currentNode = stackBST.Pop();
                        listBST.Add(currentNode);
                        currentNode = currentNode.Right;
                    }
                }
            }

            return listBST;
        }
        #endregion

        #region PostOrder NonRecursive
        public List<BinaryTreeNode<T>> PostOrderNonRecursive(BinaryTreeNode<T> root)
        {
            var listBT = new List<BinaryTreeNode<T>>();
            var stackBT = new Stack<BinaryTreeNode<T>>();
            BinaryTreeNode<T> currentNode = root;
            BinaryTreeNode<T> lastVisitedNode = null;

            while (currentNode != null || stackBT.Count > 0)
            {
                if (currentNode != null)
                {
                    stackBT.Push(currentNode);
                    currentNode = currentNode.Left;
                }
                else
                {
                    BinaryTreeNode<T> peekNode = stackBT.Peek();

                    if (peekNode.Right != null && lastVisitedNode != peekNode.Right)
                    {
                        currentNode = peekNode.Right;
                    }
                    else
                    {
                        listBT.Add(peekNode);
                        lastVisitedNode = stackBT.Pop();
                    }
                }
            }

            return listBT;
        }

        public List<BinarySearchTreeNode<T>> PostOrderNonRecursive(BinarySearchTreeNode<T> root)
        {
            var listBST = new List<BinarySearchTreeNode<T>>();
            var stackBST = new Stack<BinarySearchTreeNode<T>>();
            BinarySearchTreeNode<T> currentNode = root;
            BinarySearchTreeNode<T> lastVisitedNode = null;

            while (currentNode != null || stackBST.Count > 0)
            {
                if (currentNode != null)
                {
                    stackBST.Push(currentNode);
                    currentNode = currentNode.Left;
                }
                else
                {
                    BinarySearchTreeNode<T> peekNode = stackBST.Peek();

                    if (peekNode.Right != null && lastVisitedNode != peekNode.Right)
                    {
                        currentNode = peekNode.Right;
                    }
                    else
                    {
                        listBST.Add(peekNode);
                        lastVisitedNode = stackBST.Pop();
                    }
                }
            }

            return listBST;
        }
        #endregion

        #region LevelOrder NonRecursive
        public List<BinaryTreeNode<T>> LevelOrderNonRecursive(BinaryTreeNode<T> root)
        {
            var listBT = new List<BinaryTreeNode<T>>();
            var queueBT = new Queue<BinaryTreeNode<T>>();

            queueBT.Enqueue(root);

            while (queueBT.Count > 0)
            {
                var temp = queueBT.Dequeue();
                listBT.Add(temp);

                if (temp.Left != null) queueBT.Enqueue(temp.Left);

                if (temp.Right != null) queueBT.Enqueue(temp.Right);
            }

            return listBT;
        }

        public List<BinarySearchTreeNode<T>> LevelOrderNonRecursive(BinarySearchTreeNode<T> root)
        {
            var listBST = new List<BinarySearchTreeNode<T>>();
            var queueBST = new Queue<BinarySearchTreeNode<T>>();

            queueBST.Enqueue(root);

            while (queueBST.Count > 0)
            {
                var temp = queueBST.Dequeue();
                listBST.Add(temp);

                if (temp.Left != null) queueBST.Enqueue(temp.Left);

                if (temp.Right != null) queueBST.Enqueue(temp.Right);
            }

            return listBST;
        }
        #endregion

        #region Deepest Node
        public BinaryTreeNode<T> DeepestNode(BinaryTreeNode<T> root)
        {
            BinaryTreeNode<T> temp = null;

            if (root == null) throw new Exception("Empty Tree!");
            
            var queue = new Queue<BinaryTreeNode<T>>();
            queue.Enqueue(root);

            while (queue.Count > 0)
            {
                temp = queue.Dequeue();

                if (temp.Left != null)
                {
                    queue.Enqueue(temp.Left);
                }

                if (temp.Right != null)
                {
                    queue.Enqueue(temp.Right);
                }
            }

            return temp;
        }

        public BinaryTreeNode<T> DeepestNode()
        {
            var list = LevelOrderNonRecursive(Root);

            return list[list.Count - 1];
        }

        public BinarySearchTreeNode<T> DeepestNode(BinarySearchTreeNode<T> root)
        {
            BinarySearchTreeNode<T> temp = null;

            if (root == null) throw new Exception("Empty Tree!");

            var queue = new Queue<BinarySearchTreeNode<T>>();
            queue.Enqueue(root);

            while (queue.Count > 0)
            {
                temp = queue.Dequeue();

                if (temp.Left != null)
                {
                    queue.Enqueue(temp.Left);
                }

                if (temp.Right != null)
                {
                    queue.Enqueue(temp.Right);
                }
            }

            return temp;
        }
        #endregion

        #region Number Of Leaf
        public int NumberOfLeaf(BinaryTreeNode<T> root)
        {
            int count = 0;

            if (root == null) return count;
         
            var queue = new Queue<BinaryTreeNode<T>>();
            queue.Enqueue(root);

            while (queue.Count > 0)
            {
                var temp = queue.Dequeue();

                if (temp.Left == null && temp.Right == null) count++;

                if (temp.Left != null) queue.Enqueue(temp.Left);

                if (temp.Right != null) queue.Enqueue(temp.Right);
            }

            return count;
        }

        /*
        public int NumberOfLeaf(BinaryTreeNode<T> root)
        {
            return new BinaryTree<T>().LevelOrderNonRecursive(root).Where(r => r.Left == null && r.Right == null).ToList().Count;
        }
        */

        public int NumberOfLeaf(BinarySearchTreeNode<T> root)
        {
            int count = 0;

            if (root == null) return count;

            var queue = new Queue<BinarySearchTreeNode<T>>();
            queue.Enqueue(root);

            while (queue.Count > 0)
            {
                var temp = queue.Dequeue();

                if (temp.Left == null && temp.Right == null) count++;

                if (temp.Left != null) queue.Enqueue(temp.Left);

                if (temp.Right != null) queue.Enqueue(temp.Right);
            }

            return count;
        }
        #endregion

        #region Number Of Nodes
        // List<BinaryTreeNode<T>>
        public static int NumberOfFullNodes(BinaryTreeNode<T> root) =>
            new BinaryTree<T>().LevelOrderNonRecursive(root)
            .Where(node => node.Left != null && node.Right != null)
            .ToList().Count;

        public static int NumberOfHalfNodes(BinaryTreeNode<T> root) =>
            new BinaryTree<T>().LevelOrderNonRecursive(root)
            .Where(node => 
            (node.Left != null && node.Right == null) || 
            (node.Left == null && node.Right != null))
            .ToList().Count;
        #endregion

        #region Print Paths
        public void PrintPaths(BinaryTreeNode<T> root)
        {
            var path = new T[256];

            PrintPaths(root, path, 0);
        }

        private void PrintPaths(BinaryTreeNode<T> root, T[] path, int pathLen)
        {
            if (root == null) return;

            path[pathLen] = root.Value;
            pathLen++;

            if (root.Left == null && root.Right == null) // is it leaf?
            {
                PrintArray(path, pathLen);
            }
            else
            {
                PrintPaths(root.Left, path, pathLen);
                PrintPaths(root.Right, path, pathLen);
            }
        }

        public void PrintPaths(BinarySearchTreeNode<T> root)
        {
            var path = new T[256];

            PrintPaths(root, path, 0);
        }

        private void PrintPaths(BinarySearchTreeNode<T> root, T[] path, int pathLen)
        {
            if (root == null) return;

            path[pathLen] = root.Value;
            pathLen++;

            if (root.Left == null && root.Right == null) // is it leaf?
            {
                PrintArray(path, pathLen);
            }
            else
            {
                PrintPaths(root.Left, path, pathLen);
                PrintPaths(root.Right, path, pathLen);
            }
        }

        private void PrintArray(T[] path, int len)
        {
            for (int i = 0; i < len; i++)
            {
                Console.Write($"{path[i],-4}");
            }

            Console.WriteLine();
        }
        #endregion
    }
}
