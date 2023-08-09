
using sets;

var disjointSet = new DisjointSet<int>(new int[] { 0, 1, 2, 3, 4, 5, 6 });
//  {0}, {1}, {2}, {3}, {4}, {5}, {6}

disjointSet.Union(5, 6); //  {0}, {1}, {2}, {3}, {4}, {5, 6}        (5) <- (6)
disjointSet.Union(1, 2); //  {0}, {1, 2}, {3}, {4}, {5, 6}      (1) <- (2)          |   (5) <- (6) 
disjointSet.Union(1, 0); //  {0, 1, 2}, {3}, {4}, {5, 6}      (0) -> (1p) <- (2)    |   (5p) <- (6) 
             // (P <- C)                                    (3p) = (3)          (4p) = (4)
for (int i = 0; i < 7; i++)
{
    Console.WriteLine($"Find({i}) = Parent Node : {disjointSet.FindSet(i)}");
}

Console.WriteLine();
Console.ReadKey();