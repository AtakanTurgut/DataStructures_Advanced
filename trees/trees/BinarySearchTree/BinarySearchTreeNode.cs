using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace trees.BinarySearchTree
{
    public class BinarySearchTreeNode<T>
    {
        public T Value { get; set; }
        public BinarySearchTreeNode<T> Left { get; set; }
        public BinarySearchTreeNode<T> Right { get; set; }

        public BinarySearchTreeNode(T value)
        {
            Value = value;
        }

        public BinarySearchTreeNode()
        {
            
        }

        public override string ToString()
        {
            return $"{Value}";
        }
    }
}
