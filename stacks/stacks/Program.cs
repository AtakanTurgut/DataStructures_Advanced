
using stacks;

var charSet = new char[] { 'a', 'b', 'c', 'd', 'e' };
var stack1 = new stacks.Stack<char>();
var stack2 = new stacks.Stack<char>(stacks.StackType.LinkedList);

foreach (var ch in charSet)
{
    Console.Write($" {ch,-5}");
    stack1.Push(ch);
    stack2.Push(ch);
}

Console.WriteLine("\n-- Count --");
Console.WriteLine($" Stack1 : {stack1.Count}");
Console.WriteLine($" Stack2 : {stack2.Count}");

Console.WriteLine("-- Peek --");
Console.WriteLine($" Stack1 : {stack1.Peek()}");
Console.WriteLine($" Stack2 : {stack2.Peek()}");

Console.WriteLine("-- Pop --");
Console.WriteLine($" Stack1 : {stack1.Pop()} has been removed.");
Console.WriteLine($" Stack2 : {stack2.Pop()} has been removed.");
Console.WriteLine("---------");
Console.WriteLine($" Stack1 : {stack1.Pop()} has been removed.");
Console.WriteLine($" Stack2 : {stack2.Pop()} has been removed.");

#region - PostFixExample -
Console.WriteLine();

Console.WriteLine("Post-fix : " + PostFixExample.Run("231*+9-"));
#endregion

Console.WriteLine();
Console.ReadKey(); 