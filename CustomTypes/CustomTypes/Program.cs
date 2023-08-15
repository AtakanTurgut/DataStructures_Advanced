using CustomTypes;
using System.Linq.Expressions;

#region Student
var student1 = new Student(112, "Yağmur Soydan", 3.58);
Console.WriteLine(student1);

var student2 = new Student()
{
    Id = 380,
    NameSurname = "Furkan Üvenç",
    GPA = 3.67
};
Console.WriteLine(student2);     //  before than override - CustomTypes.Student
#endregion

#region Generic Array
Console.WriteLine("- Array<Student>() -");

var studentArray = new Student[] 
{
    new Student(192, "Atakan Turgut", 3.08),
    new Student(291, "Burak Demirciler", 2.78),
    new Student(200, "Hasan Güler", 3.89)
};

var newStudentArray = new CustomTypes.arrays.Array<Student>(studentArray);

newStudentArray.Add(student1);
newStudentArray.Add(new Student(320, "Çiçek Akkaleli", 3.43));

foreach (var student in newStudentArray)
{
    Console.WriteLine(student);
}
#endregion

#region Singly Linked List
Console.WriteLine("- SinglyLinkedList<Student>() -");

var studentLinkedList = new CustomTypes.linkedlists.SinglyLinkedList.SinglyLinkedList<Student>(newStudentArray);

studentLinkedList.AddBefore(studentLinkedList.Head.Next, new Student(207, "Fatih Turhan", 3.22));
studentLinkedList.AddAfter(studentLinkedList.Head, student2);

foreach (var student in studentLinkedList)
{
    Console.WriteLine(student);
}
#endregion

#region Binary Search Tree
Console.WriteLine("- BinarySearchTree<Student>() -");

var studentBST = new CustomTypes.trees.BinarySearchTree.BinarySearchTree<Student>(studentLinkedList);

foreach (var student in studentBST)
{
    Console.WriteLine(student);
}
#endregion

#region MinHeap - MaxHeap
Console.WriteLine("- MinHeap-MaxHeap<Student>() -");

var studentHeapMax = new CustomTypes.heaps.MaxHeap<Student>(studentBST);

foreach (var student in studentHeapMax)
{
    Console.WriteLine(studentHeapMax.DeleteMinMax());
}

Console.WriteLine(new string('-',25));

var studentHeapMin = new CustomTypes.heaps.MinHeap<Student>(studentBST);

foreach (var student in studentHeapMin)
{
    Console.WriteLine(student);
}
#endregion

#region Binary Heap - Descending
Console.WriteLine("- BinaryHeap<Student>(Descending) -");

var studentBinaryHeap = new CustomTypes.heaps.BinaryHeap<Student>(
    CustomTypes.heaps.Shared.SortDirection.Descending,
    studentBST
    );

foreach (var student in studentBinaryHeap)
{
    Console.WriteLine(student);
}
#endregion

#region Sorting Algorithms
Console.WriteLine("- Sorting Algorithms -");

CustomTypes.SortingAlgorithms.BubbleSort.Sort<Student>(studentArray);

foreach (var student in studentArray)
{
    Console.WriteLine(student);
}

Console.WriteLine(new string('-', 25));

CustomTypes.SortingAlgorithms.InsertionSort.Sort<Student>(
    studentArray, CustomTypes.SortingAlgorithms.Shared.SortDirection.Descending);

foreach (var student in studentArray)
{
    Console.WriteLine(student);
}
#endregion

Console.WriteLine();
Console.ReadKey();