using heaps.Shared;

#region Min Heap
Console.WriteLine("--- Min Heap ---");

var heapMin = new heaps.MinHeap<int>(new int[] { 54, 45, 36, 27, 29, 18, 21,99 });    // // ,99
// Indexes    : 0   1   2   3   4   5   6   // 99 before adding
// LevelOrder : 18  29  21  54  36  45  27

foreach (int i in heapMin)
{
    Console.Write($"{i, -4}");
}
// Indexes    : 0   1   2   3   4   5   6   7   
// LevelOrder : 18  29  21  54  36  45  27  99   

Console.WriteLine("\n" + heapMin.DeleteMinMax() + " has been removed.") ;   // 99
foreach (int i in heapMin)
{
    Console.Write($"{i,-4}");
}
// Indexes    : 0   1   2   3   4   5   6  
// LevelOrder : 21  29  27  54  36  45  99
#endregion

Console.WriteLine("\n");
#region Max Heap
Console.WriteLine("--- Max Heap ---");

var heapMax = new heaps.MaxHeap<int>(new int[] { 54, 45, 36, 27, 29, 18, 21, 99 });    // ,99
// Indexes    : 0   1   2   3   4   5   6   // 99 before adding
// LevelOrder : 54  45  36  27  29  18  21

foreach (int i in heapMax)
{
    Console.Write($"{i,-4}");
}
// Indexes    : 0   1   2   3   4   5   6   7   
// LevelOrder : 99  54  36  45  29  18  21  27   

Console.WriteLine("\n" + heapMax.DeleteMinMax() + " has been removed.");    // 99
foreach (int i in heapMax)
{
    Console.Write($"{i,-4}");
}
// Indexes    : 0   1   2   3   4   5   6   
// LevelOrder : 54  45  36  27  29  18  21   
#endregion

Console.WriteLine("\n");
#region Binary Heap
Console.WriteLine("- Ascending Binary Heap -");

var heapBinaryAscending = new heaps.BinaryHeap<int>
    (
    SortDirection.Ascending,    // min-heap
    new int[] { 54, 45, 36, 27, 29, 18, 21, 99 }
    );

foreach (int i in heapBinaryAscending)
{
    Console.Write($"{i,-4}");
}
// Indexes    : 0   1   2   3   4   5   6   7   
// LevelOrder : 18  29  21  54  36  45  27  99 

Console.WriteLine("\n\n- Descending Binary Heap -");

var heapBinaryDescending = new heaps.BinaryHeap<int>
    (
    SortDirection.Descending,   // max-heap
    new int[] { 54, 45, 36, 27, 29, 18, 21, 99 }
    ); 

foreach (int i in heapBinaryDescending)
{
    Console.Write($"{i,-4}");
}
// Indexes    : 0   1   2   3   4   5   6   7   
// LevelOrder : 99  54  36  45  29  18  21  27  

#endregion

Console.WriteLine();
Console.ReadKey();