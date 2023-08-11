using graphs.AdjacencySet;

#region Graph
Console.WriteLine("---- Graph ----");

var graph = new graphs.AdjacencySet.Graph<char>(new char[] { 'A', 'B', 'C', 'D', 'E', 'F', 'G' });

graph.AddEdge('A', 'B');    // A —— B
graph.AddEdge('A', 'D');    // A —— D
graph.AddEdge('D', 'C');    // D —— C
graph.AddEdge('D', 'E');    // D —— E
graph.AddEdge('C', 'E');    // C —— E
graph.AddEdge('E', 'F');    // E —— F
graph.AddEdge('F', 'G');    // F —— G

/*
        A ——  D     G           
       /    /  \    |           
      B    C —— E — F           
*/

foreach (var vertex in graph)
{
    Console.Write($"{vertex, -3}");
}
//   'A', 'B', 'C', 'D', 'E', 'F', 'G'
Console.WriteLine();

Console.WriteLine("     A ——  D     G   ");
Console.WriteLine(@"    /    /  \    |  ");
Console.WriteLine("   B    C —— E — F   ");

Console.WriteLine("Number of Vertex in the Graph : " + graph.Count);    // 7

Console.WriteLine("Is there an edge between A and B ? {0}", graph.HasEdge('A', 'B') ? "Yes." : "No.");  // Yes.
Console.WriteLine("Is there an edge between B and A ? {0}", graph.HasEdge('B', 'A') ? "Yes." : "No.");  // Yes.
Console.WriteLine("Is there an edge between B and D ? {0}", graph.HasEdge('B', 'D') ? "Yes." : "No.");  // No.
Console.WriteLine("Is there an edge between D and B ? {0}", graph.HasEdge('D', 'B') ? "Yes." : "No.");  // No.

foreach (var key in graph)
{
    Console.WriteLine($"{key}");
    foreach (var vertex in graph.GetVertex(key).Edges)
	{
        Console.Write($"   {vertex}");
    }
    Console.WriteLine();
}
#endregion

#region WeightedGraph
Console.WriteLine("\n-- WeightedGraph --");

var weightedGraph = new WeightedGraph<char, double>(new char[] { 'A', 'B', 'C', 'D' });

weightedGraph.AddEdge('A', 'B', 1.2);
weightedGraph.AddEdge('A', 'D', 2.3);
weightedGraph.AddEdge('D', 'C', 5.5);

/*
                            V x V
    \ A    B    C    D                2.3
    A 0   1.2   0   2.3           (A) —— (D)
    B 1.2  0    0    0           / 1.2    | 5.5
    C 0    0    0   5.5        (B)       (C)
    D 2.3  0   5.5   0 
*/

foreach (char vertex in weightedGraph)
{
    Console.Write($"{vertex,-3}");
}
//  'A', 'B', 'C', 'D'
Console.WriteLine();

Console.WriteLine("         2.3       ");
Console.WriteLine("     (A) —— (D)    ");
Console.WriteLine("    / 1.2    | 5.5 ");
Console.WriteLine("  (B)       (C)    ");

Console.WriteLine("Number of Vertex in the Graph : " + weightedGraph.Count);    // 4
Console.WriteLine("Is there an edge between A and B ? {0}", weightedGraph.HasEdge('A', 'B') ? "Yes." : "No.");  // Yes.
Console.WriteLine("Is there an edge between B and A ? {0}", weightedGraph.HasEdge('B', 'A') ? "Yes." : "No.");  // Yes.
Console.WriteLine("Is there an edge between B and D ? {0}", weightedGraph.HasEdge('B', 'D') ? "Yes." : "No.");  // No.
Console.WriteLine("Is there an edge between D and B ? {0}", weightedGraph.HasEdge('D', 'B') ? "Yes." : "No.");  // No.

foreach (char key in weightedGraph)
{
    Console.WriteLine($"{key}");
    foreach (char vertex in weightedGraph.GetVertex(key))
    {
        var node = weightedGraph.GetVertex(vertex);
        Console.WriteLine($"   {key} - {node.GetEdge(weightedGraph.GetVertex(key)).Weight<double>()} - {vertex}");
    }
}
#endregion

#region DiGraph
Console.WriteLine("\n--- DiGraph ---");

var diGraph = new graphs.AdjacencySet.DiGraph<char>(new char[] { 'A', 'B', 'C', 'D', 'E' });

diGraph.AddEdge('B', 'A');      // (Child, Node)        A <—— B
diGraph.AddEdge('A', 'D');      // (Child, Node)        D <—— A
diGraph.AddEdge('C', 'A');      // (Child, Node)        A <-- C
diGraph.AddEdge('C', 'B');      // (Child, Node)        B <-- C
diGraph.AddEdge('C', 'D');      // (Child, Node)        D <-- C
diGraph.AddEdge('C', 'E');      // (Child, Node)        E <-- C
diGraph.AddEdge('D', 'E');      // (Child, Node)        E <-- D

/*
        A —→ D                
        ↑ ↖  ↑ ↘        
        B ←— C → E    
*/

foreach (var key in diGraph)
{
    Console.Write($"{key,-3}");
}
//  'A', 'B', 'C', 'D', 'E' 
Console.WriteLine();

Console.WriteLine("Number of Vertex in the Graph : " + diGraph.Count);    // 5
Console.WriteLine("Is there an edge between A and B ? {0}", diGraph.HasEdge('A', 'B') ? "Yes." : "No.");  // No.
Console.WriteLine("Is there an edge between B and A ? {0}", diGraph.HasEdge('B', 'A') ? "Yes." : "No.");  // Yes.
Console.WriteLine("Is there an edge between E and D ? {0}", diGraph.HasEdge('E', 'D') ? "Yes." : "No.");  // No.
Console.WriteLine("Is there an edge between D and E ? {0}", diGraph.HasEdge('D', 'E') ? "Yes." : "No.");  // Yes.

foreach (char key in diGraph)
{
    Console.WriteLine($"{key}");
    foreach (char vertex in diGraph.GetVertex(key))
    {
        Console.Write($"   {vertex}");
    }
    Console.WriteLine();
}

Console.WriteLine("Removed 'C' from Graph.");
diGraph.RemoveVertex('C');

/*
        A —→ D                
        ↑     ↘        
        B      E    
*/

Console.WriteLine("Number of Vertex in the Graph : " + diGraph.Count);    // 4

foreach (char key in diGraph)
{
    Console.WriteLine($"{key}");
    foreach (char vertex in diGraph.GetVertex(key))
    {
        Console.Write($"   {vertex}");
    }
    Console.WriteLine();
}
#endregion

#region WeightedDiGraph
Console.WriteLine("-- WeightedDiGraph --");

var weightedDiGraph = new graphs.AdjacencySet.WeightedDiGraph<char, int>(new char[] { 'A', 'B', 'C', 'D', 'E' });

weightedDiGraph.AddEdge('B', 'A', 10);      // (Child, Node, Weight)        A <——10  B
weightedDiGraph.AddEdge('E', 'A', 7);       // (Child, Node, Weight)        A <——7   E
weightedDiGraph.AddEdge('A', 'C', 12);      // (Child, Node, Weight)        C <——12  A
weightedDiGraph.AddEdge('A', 'D', 60);      // (Child, Node, Weight)        D <——60  A
weightedDiGraph.AddEdge('C', 'B', 20);      // (Child, Node, Weight)        B <——20  C
weightedDiGraph.AddEdge('C', 'D', 32);      // (Child, Node, Weight)        D <——32  C

/*
        A   ←10—   B                
     7↗ ↓60  ↘12   ↑20         
    E   D   ←32—   C  
*/

foreach (var key in weightedDiGraph)
{
    Console.Write($"{key,-3}");
}
//  'A', 'B', 'C', 'D', 'E'
Console.WriteLine();

Console.WriteLine("Number of Vertex in the Graph : " + weightedDiGraph.Count);    // 5
Console.WriteLine("Is there an edge between A and B ? {0}", weightedDiGraph.HasEdge('A', 'B') ? "Yes." : "No.");  // No.
Console.WriteLine("Is there an edge between B and A ? {0}", weightedDiGraph.HasEdge('B', 'A') ? "Yes." : "No.");  // Yes.
Console.WriteLine("Is there an edge between D and C ? {0}", weightedDiGraph.HasEdge('D', 'C') ? "Yes." : "No.");  // No.
Console.WriteLine("Is there an edge between C and D ? {0}", weightedDiGraph.HasEdge('C', 'D') ? "Yes." : "No.");  // Yes.

foreach (var key in weightedDiGraph)
{
    Console.WriteLine($"{key}");
    foreach (var vertex in weightedDiGraph.GetVertex(key))
    {   
            //  (U) --> (V)
        var nodeU = weightedDiGraph.GetVertex(key);
        var nodeV = weightedDiGraph.GetVertex(vertex);
        var weight = nodeU.GetEdge(nodeV).Weight<int>();
        Console.WriteLine($"   {nodeU.Key} - {weight} - {nodeV.Key}");
        //Console.WriteLine($"   {key} - {weight} - {vertex}");
    }
}
#endregion

Console.WriteLine();
Console.ReadLine();