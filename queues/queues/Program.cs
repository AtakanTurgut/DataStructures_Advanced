
var numbers = new int[] { 10, 20, 30 };
var queue1 = new queues.Queue<int>();   // Default Array
var queue2 = new queues.Queue<int>(queues.QueueType.LinkedList);


Console.WriteLine("-- EnQueue --");
foreach (var number in numbers)
{
    Console.Write($"{number, -5}");
    queue1.EnQueue(number);
    queue2.EnQueue(number);
}


Console.WriteLine($"\nQueue1 Count : {queue1.Count}");
Console.WriteLine($"Queue2 Count : {queue2.Count}");

Console.WriteLine("-- DeQueue --");
Console.WriteLine($"{queue1.DeQueue()} has been removed from Queue1.");
Console.WriteLine($"{queue2.DeQueue()} has been removed from Queue2.");

Console.WriteLine($"Queue1 Count : {queue1.Count}");
Console.WriteLine($"Queue2 Count : {queue2.Count}");

Console.WriteLine("-- Peek --");
Console.WriteLine($"Queue1 Peek : {queue1.Peek()}");
Console.WriteLine($"Queue2 Peek : {queue2.Peek()}");

Console.WriteLine();
Console.ReadLine();
