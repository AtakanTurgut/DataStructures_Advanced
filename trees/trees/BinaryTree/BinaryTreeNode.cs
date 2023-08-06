using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using trees.BinarySearchTree;

namespace trees.BinaryTree
{
    public class BinaryTreeNode<T>
    {
        public T Value { get; set; }
        public BinaryTreeNode<T> Left { get; set; }
        public BinaryTreeNode<T> Right { get; set; }

        public BinaryTreeNode(T value)
        {
            Value = value;
        }

        public BinaryTreeNode()
        {

        }

        public override string ToString()
        {
            return $"{Value}";
        }
    }
}
