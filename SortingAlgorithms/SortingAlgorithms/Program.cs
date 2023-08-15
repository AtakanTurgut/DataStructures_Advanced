using SortingAlgorithms;

#region Selection Sort 
Console.WriteLine("- Selection Sort -");

var selectionArr = new int[] { 16, 23, 44, 12, 55, 40, 6 };

// Original Array
foreach (var selection in selectionArr)
{
    Console.Write($"{selection, -3}");
}
Console.WriteLine();
// 16 23 44 12 55 40 6

// Sorted Arrays
SelectionSort.Sort<int>(selectionArr, SortingAlgorithms.Shared.SortDirection.Descending);
foreach (var selection in selectionArr)
{
    Console.Write($"{selection,-3}");
}
Console.WriteLine();
// 55 44 40 23 16 12 6  -> Descending

SelectionSort.Sort<int>(selectionArr, SortingAlgorithms.Shared.SortDirection.Ascending);
foreach (var selection in selectionArr)
{
    Console.Write($"{selection,-3}");
}
Console.WriteLine();
// 6  12 16 23 40 44 55 -> Ascending
#endregion

Console.WriteLine();

#region Bubble Sort
Console.WriteLine("- Bubble Sort -");

var bubbleArr = new int[] { 16, 23, 44, 12, 55, 40, 6 };

// Original Array
foreach (var bubble in bubbleArr)
{
    Console.Write($"{bubble,-3}");
}
Console.WriteLine();
// 16 23 44 12 55 40 6

// Sorted Arrays
BubbleSort.Sort<int>(bubbleArr, SortingAlgorithms.Shared.SortDirection.Descending);
//BubbleSort.Sort<int>(bubbleArr);
foreach (var bubble in bubbleArr)
{
    Console.Write($"{bubble,-3}");
}
Console.WriteLine();
// 55 44 40 23 16 12 6  -> Descending

BubbleSort.Sort<int>(bubbleArr, SortingAlgorithms.Shared.SortDirection.Ascending);
foreach (var bubble in bubbleArr)
{
    Console.Write($"{bubble,-3}");
}
Console.WriteLine();
// 6  12 16 23 40 44 55 -> Ascending
#endregion

Console.WriteLine();

#region Insertion Sort
Console.WriteLine("- Insertion Sort -");

var insertionArr = new int[] { 16, 23, 44, 12, 55, 40, 6 };

// Original Array
foreach (var insertion in insertionArr)
{
    Console.Write($"{insertion,-3}");
}
Console.WriteLine();
// 16 23 44 12 55 40 6

// Sorted Arrays
InsertionSort.Sort<int>(insertionArr, SortingAlgorithms.Shared.SortDirection.Descending);
foreach (var insertion in insertionArr)
{
    Console.Write($"{insertion,-3}");
}
Console.WriteLine();
// 55 44 40 23 16 12 6  -> Descending

InsertionSort.Sort<int>(insertionArr, SortingAlgorithms.Shared.SortDirection.Ascending);
//InsertionSort.Sort<int>(insertionArr);
foreach (var insertion in insertionArr)
{
    Console.Write($"{insertion,-3}");
}
Console.WriteLine();
// 6  12 16 23 40 44 55 -> Ascending
#endregion

Console.WriteLine();

#region Quick Sort
Console.WriteLine("- Quick Sort -");

var quickArr = new int[] { 16, 23, 44, 12, 55, 40, 6 };

// Original Array
foreach (var quick in quickArr)
{
    Console.Write($"{quick,-3}");
}
Console.WriteLine();
// 16 23 44 12 55 40 6

// Sorted Arrays
QuickSort.Sort<int>(quickArr);
foreach (var quick in quickArr)
{
    Console.Write($"{quick,-3}");
}
Console.WriteLine();
// 6  12 16 23 40 44 55 -> Ascending
#endregion

Console.WriteLine();

#region Merge Sort
Console.WriteLine("- Merge Sort -");

var mergeArr = new sbyte[] { 16, 23, 44, 12, 55, 40, 6 };

// Original Array
foreach (var merge in mergeArr)
{
    Console.Write($"{merge,-3}");
}
Console.WriteLine();
// 16 23 44 12 55 40 6

// Sorted Arrays
MergeSort.Sort<sbyte>(mergeArr);
foreach (var merge in mergeArr)
{
    Console.Write($"{merge,-3}");
}
Console.WriteLine();
// 6  12 16 23 40 44 55 -> Ascending
#endregion

Console.WriteLine();

#region Heap Sort
Console.WriteLine("- Heap Sort -");

var heapArr = new sbyte[] { 16, 23, 44, 12, 55, 40, 6 };

// Original Array
foreach (var h in heapArr)
{
    Console.Write($"{h,-3}");
}
Console.WriteLine();
// 16 23 44 12 55 40 6

// Sorted Arrays
var heap = new SortingAlgorithms.heaps.MinHeap<sbyte>(heapArr);
foreach (var h in heap)
{
    Console.Write($"{heap.DeleteMinMax(),-3}");
}
Console.WriteLine();
// 6  12 16 23 40 44 55 -> Ascending
#endregion

Console.WriteLine();
Console.ReadKey();