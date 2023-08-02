
#region - Array() -
using System.Collections;

var arrChar = new char[] { 'a', 't', 'k' };
Console.WriteLine("Array Length : " + arrChar.Length);

var arrInt = Array.CreateInstance(typeof(int), 5);
arrInt.SetValue(10, 0);     // arrInt[0] = 10;
arrInt.SetValue(30, 2);
arrInt.GetValue(0);         // 10
Console.WriteLine("Array Length : " + arrInt.Length);
#endregion

#region - ArrayList() -
// 10 -> boxing -> object
// b -> boxing -> object
var arrObj = new ArrayList();
arrObj.Add(10);
arrObj.Add('a');

// object -> unboxing - int
var result = ((int)arrObj[0] + 20);
Console.WriteLine(result);

Console.WriteLine("ArrayList Count : " + arrObj.Count);
#endregion

#region - List<T> -
var arrNum = new List<int>();
arrNum.Add(10);
arrNum.Add('b');    // ASCII
arrNum.AddRange(new int[] { 1, 2, 3 });
arrNum.RemoveAt(0);

foreach (var item in arrNum)
{
    Console.WriteLine(item);
}

Console.WriteLine("List Count : " + arrNum.Count);
#endregion
/*
#region - Array<T> -
Console.WriteLine(new string('-', 25));
Console.ReadKey();

var a1 = new arrays.Array<int>(1, 2, 3, 4);
var a2 = new int[] { 8, 9, 10, 11 };
var a3 = new List<int>() { 12, 13, 14, 15 };
var a4 = new System.Collections.ArrayList() { 16, 17, 18 };

var arr = new arrays
    .Array<int>();       //.Array<int>(98);    // .Array<int>(a3);

for (int i = 0; i < 5; i++)
{
    arr.Add(i + 1);
    Console.WriteLine($"{i + 1} has been added to array.");
    Console.WriteLine($" {arr.Count}/{arr.Capacity}");
}

arr.Add(3);

/*
Console.WriteLine("---");
for (int i = arr.Count; i >= 1; i--)
{
    Console.WriteLine($"{arr.Remove()} has been removed to array.");
    Console.WriteLine($" {arr.Count}/{arr.Capacity}");
}
///
Console.WriteLine();
arr.Where(x => x % 2 == 0).ToList().ForEach(x => Console.WriteLine(x));

Console.WriteLine("---");

//var crr = (arrays.Array<int>)arr.Clone();
var crr = arr.Clone() as arrays.Array<int>;
crr.Add(1);

foreach (var item in arr)
{
    Console.Write($"{item, -2}");
}
Console.WriteLine($" {arr.Count}/{arr.Capacity}");

Console.WriteLine();
foreach (var item in crr)
{
    Console.Write($"{item,-2}");
}
Console.WriteLine($" {crr.Count}/{crr.Capacity}");
#endregion
*/

var arr = new arrays
    .Array<int>();       //.Array<int>(98);    // .Array<int>(a3);

for (int i = 0; i < 10; i++)
{
    arr.Add(i + 1);
    Console.WriteLine($"{i + 1} has been added to array.");
    Console.WriteLine($" {arr.Count}/{arr.Capacity}");
}

Console.ReadKey();
