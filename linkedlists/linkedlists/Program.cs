#region - SinglyLinkedList -

using linkedlists.SinglyLinkedList;
using System.Collections;

var linkedList = new SinglyLinkedList<int>();
linkedList.AddFirst(1);
linkedList.AddFirst(2);
linkedList.AddFirst(3);
// 3(H) 2 1

linkedList.AddLast(4);
linkedList.AddLast(5);
// 3 2 1 4 5(L) 

linkedList.AddAfter(linkedList.Head.Next, 6);
// 3(H) 2(N) 1 4 5 
// 3(H) 2(N) 6 1 4 5

linkedList.AddAfter(linkedList.Head.Next.Next, 7);
// 3(H) 2(N) 6(N) 1 4 5
// 3(H) 2(N) 6(N) 7(A) 1 4 5

linkedList.AddBefore(linkedList.Head.Next.Next.Next.Next, 8);
// 3(H) 2(N) 6(N) 7(N) 1(N) 4 5
// 3(H) 2(N) 6(N) 7(N) 8(B) 1(N) 4 5


var list1 = new SinglyLinkedList<int>();
list1.AddFirst(99);
list1.AddFirst(88);
// 88 99
linkedList.AddAfter(linkedList.Head.Next, list1.Head);
// 3(H) 2(N) 6 7 8 1 4 5
// 3(H) 2(N) 88(A) 6 7 8 1 4 5

var list2 = new SinglyLinkedList<int>();
list2.AddFirst(99);
list2.AddFirst(88);
// 88 99
linkedList.AddBefore(linkedList.Head.Next.Next.Next, list2.Head.Next);
// 3(H) 2(N) 88(N) 6(N) 7 8 1 4 5
// 3(H) 2(N) 88(N) 99(B) 6(N) 7 8 1 4 5

foreach (var item in linkedList)
{
    Console.Write($"{item,-5}");
}
// 3    2    88   99   6    7    8    1    4    5

// Remove First Node
Console.WriteLine();
Console.WriteLine(linkedList.RemoveFirst() + " has been removed.");       // 3
Console.WriteLine(linkedList.RemoveFirst() + " has been removed.");       // 2

foreach (var item in linkedList)
{
    Console.Write($"{item,-5}");
}
// (3   2)  88   99   6    7    8    1    4    5
// 88   99   6   7    8    1    4    5

// Remove Last Node
Console.WriteLine();
Console.WriteLine(linkedList.RemoveLast() + " has been removed.");       // 5
Console.WriteLine(linkedList.RemoveLast() + " has been removed.");       // 4

foreach (var item in linkedList)
{
    Console.Write($"{item,-5}");
}
// 88   99   6    7    8    1    (4    5)
// 88   99   6    7    8    1

Console.WriteLine();
linkedList.Remove(6);   // 6
linkedList.Remove(1);   // 1 Last Node
linkedList.Remove(88);  // 88 First Node

foreach (var item in linkedList)
{
    Console.Write($"{item,-5}");
}
// (88)   99  (6)   7    8    (1)
// 99   7    8

Console.WriteLine();
Console.WriteLine(new string('-',50));
Console.ReadKey();

var arr = new char[] { 'a', 'b', 'c' };
var list = new List<char>(arr);
var clinkedlist = new LinkedList<char>(arr);
list.AddRange(new char[] { 'd', 'e', 'f' });

var linkedlist = new SinglyLinkedList<char>(list);

foreach (var item in linkedlist)
{
    Console.Write($"{item,-5}");
}

Console.WriteLine();
var charSet = new List<char>(linkedlist);

foreach (var item in charSet)
{
    Console.Write($"{item,-5}");
}

#region - Language Integrated Query - LINQ -
Console.WriteLine();
Console.WriteLine(new string('-', 50));
Console.ReadKey();

var rnd = new Random();
var initial = Enumerable.Range(1, 10).OrderBy(x => rnd.Next()).ToList();
var LinkedList = new SinglyLinkedList<int>(initial);

var query = from item in linkedList
            where item % 2 == 1
            select item;

linkedList.Where(x => x>5)
    .ToList()
    .ForEach(x => Console.Write($"{x, -5}"));

Console.WriteLine();

foreach (var item in query)
{
    Console.WriteLine(item);
}


#endregion
#endregion



Console.ReadKey();