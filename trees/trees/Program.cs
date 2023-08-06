
using System.Xml.Linq;
using trees.BinarySearchTree;
using trees.BinaryTree;

#region - BinarySearchTree - BinaryTree -
var bst = new BinarySearchTree<int>(new int[] { 23, 16, 45, 3, 22, 37, 99 });

foreach (int i in bst)
{
    Console.Write($"{i,-5}");
}

Console.WriteLine("\n--    PreOrder  Recursive    --");
new BinaryTree<int>().PreOrder(bst.Root).ForEach(node => Console.Write($"{node,-5}"));
// 23   16   3    22   45   37   99

Console.WriteLine();
Console.WriteLine("--     InOrder Recursive     --");
new BinaryTree<int>().InOrder(bst.Root).ForEach(node => Console.Write($"{node,-5}"));
// 3    16   22   23   37   45   99

Console.WriteLine();
Console.WriteLine("--    PostOrder Recursive    --");
new BinaryTree<int>().PostOrder(bst.Root).ForEach(node => Console.Write($"{node,-5}"));
// 3    22   16   37   99   45   23

Console.WriteLine("\n" + new string('-', 35));
Console.WriteLine("--   PreOrder NonRecursive   --");
new BinaryTree<int>().PreOrderNonRecursive(bst.Root).ForEach(node => Console.Write($"{node,-5}"));
// 23   16   3    22   45   37   99

Console.WriteLine();
Console.WriteLine("--   InOrder  NonRecursive   --");
new BinaryTree<int>().InOrderNonRecursive(bst.Root).ForEach(node => Console.Write($"{node,-5}"));
// 3    16   22   23   37   45   99

Console.WriteLine();
Console.WriteLine("--  PostOrder  NonRecursive  --");
new BinaryTree<int>().PostOrderNonRecursive(bst.Root).ForEach(node => Console.Write($"{node,-5}"));
// 3    22   16   37   99   45   23

Console.WriteLine();
Console.WriteLine("--  LevelOrder NonRecursive  --");
new BinaryTree<int>().LevelOrderNonRecursive(bst.Root).ForEach(node => Console.Write($"{node,-5}"));
// 23   16   45   3    22   37   99

Console.WriteLine("\n" + new string('-', 35));
Console.WriteLine("Binary Search Tree Minimum Value : " + bst.FindMin(bst.Root));   // 3
Console.WriteLine("Binary Search Tree Maximum Value : " + bst.FindMax(bst.Root));   // 99

var keyNode = bst.Find(bst.Root, 23);
Console.WriteLine(
    $" {keyNode.Left.Value} " +
    $": Left <- {keyNode.Value} -> Right :" +
    $" {keyNode.Right.Value}");

Console.WriteLine(new string('-', 35));
var bstt = new BinarySearchTree<int>(new int[] { 60, 40, 70, 20, 45, 65, 85 });
new BinaryTree<int>().InOrder(bstt.Root).ForEach(node => Console.Write($"{node,-5}"));
// 20   40   45   60   65   70   85

var keyNodebstt = bst.Find(bstt.Root, 60);
Console.WriteLine(
    $"\n {keyNodebstt.Left.Value} " +
    $": Left <- {keyNodebstt.Value} -> Right :" +
    $" {keyNodebstt.Right.Value}");

bstt.Remove(bstt.Root, 70);

Console.WriteLine();
new BinaryTree<int>().InOrder(bstt.Root).ForEach(node => Console.Write($"{node,-5}"));
// 20   40   45   60   65   85

var keyNodebsttt = bst.Find(bstt.Root, 60);
Console.WriteLine(
    $"\n {keyNodebsttt.Left.Value} " +
    $": Left <- {keyNodebsttt.Value} -> Right :" +
    $" {keyNodebsttt.Right.Value}");

bstt.Remove(bstt.Root, 40);

Console.WriteLine();
new BinaryTree<int>().InOrder(bstt.Root).ForEach(node => Console.Write($"{node,-5}"));
// 20   45   60   65   85

var keyNodebstttt = bst.Find(bstt.Root, 60);
Console.WriteLine(
    $"\n {keyNodebstttt.Left.Value} " +
    $": Left <- {keyNodebstttt.Value} -> Right :" +
    $" {keyNodebstttt.Right.Value}");

Console.WriteLine();
Console.WriteLine($"Min   : {bstt.FindMin(bstt.Root)}");
Console.WriteLine($"Max   : {bstt.FindMax(bstt.Root)}");
Console.WriteLine($"Depth : {BinaryTree<int>.MaxDepth(bstt.Root)}");


Console.WriteLine(new string('-', 35));
var bt = new BinaryTree<char>();
bt.Root = new BinaryTreeNode<char>('F');
bt.Root.Left = new BinaryTreeNode<char>('A');
bt.Root.Right = new BinaryTreeNode<char>('T');
bt.Root.Left.Left = new BinaryTreeNode<char>('D');
bt.Root.Left.Right = new BinaryTreeNode<char>('E');

var list = bt.LevelOrderNonRecursive(bt.Root);

foreach (var item in list)
{
    Console.Write($"{item, -3}");
}

Console.WriteLine($"\nDeepest Node : {bt.DeepestNode(bt.Root)}");
Console.WriteLine($"Depth          : {BinaryTree<char>.MaxDepth(bt.Root)}");
Console.WriteLine($"Number Of Leaf : {bt.NumberOfLeaf(bt.Root)}");
Console.WriteLine($"Number Of Full Nodes : {BinaryTree<char>.NumberOfFullNodes(bt.Root)}");
Console.WriteLine($"Number Of Half Nodes : {BinaryTree<char>.NumberOfHalfNodes(bt.Root)}");
Console.WriteLine("Paths : ");
bt.PrintPaths(bt.Root);

#endregion

Console.WriteLine();
Console.ReadLine();