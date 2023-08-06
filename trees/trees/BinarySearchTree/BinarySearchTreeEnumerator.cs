using System.Collections;
using trees.BinaryTree;

namespace trees.BinarySearchTree
{
    public class BinarySearchTreeEnumerator<T> : IEnumerator<T> where T : IComparable
    {
        private List<BinarySearchTreeNode<T>> list;
        private int indexer = -1;

        public BinarySearchTreeEnumerator(BinarySearchTreeNode<T> root)
        {
            list = new BinaryTree<T>().LevelOrderNonRecursive(root);
            // || .PreOrderNonRecursive(root); .inorder; .postorder.....
        }

        public T Current => list[indexer].Value;

        object IEnumerator.Current => Current;

        public void Dispose()
        {
            list = null;
        }

        public bool MoveNext()
        {
            indexer++;

            return indexer < list.Count ? true : false;
        }

        public void Reset()
        {
            indexer = -1;
        }
    }
}