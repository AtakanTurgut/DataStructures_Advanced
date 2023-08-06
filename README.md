# Advanced Data Structures with C#

## Data Structures
System.Collections      IEnumerable
- ArrayList, Hashtable, Queue, Stack

System.Collections.Generic      IEnumerable<-T->    |   foreach - LINQ
- Dictionary<-TKey, TValue->, List<-T->, Queue<-T->
- SortedList<-TKey, TValue->, Stack<-T->
- SortedSet<-TKey, TValue->, HashSet<-TKey, TValue->

## [Arrays](https://github.com/AtakanTurgut/DataStructures_Advanced/blob/main/arrays/arrays/Program.cs) 
Array   |   Dizi -> Arrays are of reference type. - Linear  <br />
Zero-based indexing - Fixed sized <br />
One block allocation and Complex position-based insertion <br />
Single-dimension | Multi-dimension  <br />
Basic and Direct Access O(1) <br />

## [ArrayLists()](https://github.com/AtakanTurgut/DataStructures_Advanced/blob/main/arrays/arrays/Program.cs) 
ArrayList   |   non-generic = boxing -> object  |  object -> unboxing - Linear <br />
Dynamically sized   |   Type non-safety
.Add()  .Remove()   .Insert()

## [Lists<-T->](https://github.com/AtakanTurgut/DataStructures_Advanced/blob/main/arrays/arrays/Program.cs)
List<-T->   |       Type Safety  -> generic - Linear    <br />
Interface -> Inheritance : Inherits contracts.  <br />

## [Arrays<-T->](https://github.com/AtakanTurgut/DataStructures_Advanced/blob/main/arrays/arrays/Array.cs)
Array<-T->   |       Type Safety  -> generic - Linear   <br />
Implement IEnumerable<-T->  <br />
![](/pictures/Arrays.PNG)

## [LinkedLists<-T->](https://github.com/AtakanTurgut/DataStructures_Advanced/blob/main/linkedlists/linkedlists/Program.cs) 
LinkedList<-T->  |  Bağlı Liste           Type Safety  -> generic - Linear  <br />
Abstract Data Type  <br />
It can be bidirectional or unidirectional, linear data structure.  <br />
Expandable O(1) and non-preallocated.    <br />
Access Time O(n).    <br />
.AddFirst()      .AddLast()      .First()    .Last()     .AddBefore()    .AddAfter()    <br />

        Node   ==   - | data | pointer 
        <- | previous | data | next | ->
               firstNode ... lastNode

### [SinglyLinkedList<-T->](https://github.com/AtakanTurgut/DataStructures_Advanced/blob/main/linkedlists/linkedlists/SinglyLinkedList/SinglyLinkedList.cs)   
SinglyLinkedList<-T->   |   Tek Yönlü Bağlı Liste  
First Node = Head   |   Last Node = Tail -> NULL

        Node == value | pointer = default NULL     
                value | next | ->

.Insert()   .Delete()   -   .DeleteList()   .Count()    .Find()

- Language Integrated Query - LINQ
- Inserting at the beginning (Head) O(1).
- Inserting at the ending (Tail ->  NULL) O(n).
- Inserting at the middle O(n).
- Traversing the list O(n).
- Deleting first node in the singly linked list O(1).
- Deleting last node in the singly linked list O(n).
- Deleting an intermediate node in the singly linked list O(n).

![](/pictures/SinglyLinkedLists.PNG)

### [DoublyLinkedList<-T->](https://github.com/AtakanTurgut/DataStructures_Advanced/blob/main/linkedlists/linkedlists/DoublyLinkedList/DoublyLinkedList.cs)   
DoublyLinkedList<-T->   |   Çift Yönlü Bağlı Liste  
First Node = Head   |   Last Node = Tail -> NULL

        Node   ==   - | value | pointer = default NULL     
        <- | previous | value | next | ->

.Insert()   .Delete()   -   .DeleteList()   .Count()    .Find()

- Inserting at the beginning (Head) O(1).
- Inserting at the ending (Tail ->  NULL) O(1).
- Inserting at the given position O(n).
- Traversing the list O(n).
- Deleting at the first node O(1).
- Deleting at the last node O(1).
- Deleting an intermediate node in the doubly linked list O(n).

![](/pictures/DoublyLinkedLists.PNG)

## [Stacks<-T->](https://github.com/AtakanTurgut/DataStructures_Advanced/blob/main/stacks/stacks/Stack.cs) 
Stack<-T->  |  Yığın           Type Safety  -> generic - Linear     <br />
Array and ArrayList are used to organize data.  <br />
Only the last elements of the stacks can be accessed.   <br />
Last-in First-out     ->  LIFO  |  First-in Last-out     ->  FILO    <br />
.push() -> Ekleme          .pop() -> Çıkarma        .Clear() -> Yığını boşaltma        .ToArray() -> int[]     <br />

```
        in-fix   ->  3 + 5 => 8
        post-fix ->  3 5 + => 8         operants => 2 * .pop() from stack.

                  2 3 1 * + 9 -      result=?
        stack ->  2 3 1 *
                        .pop() - s1 -> 1      s2 * s1
                        .pop() - s2 -> 3      3 * 1 => 3 -> .push() to stack.
        
        stack ->  2 3 +
                      .pop() - s1 -> 3        s2 + s1
                      .pop() - s2 -> 2        2 + 3 => 5 -> .push() to stack.
        
        stack ->  5 9 -
                      .pop() - s1 -> 9        s2 - s1
                      .pop() - s2 -> 5        5 - 9 => -4 -> .push() to stack.
        
        result ->  -4
 ```

![](/pictures/Stacks.PNG)

## [Trees<-T->](https://github.com/AtakanTurgut/DataStructures_Advanced/blob/main/trees/trees/Program.cs) 
Tree<-T->  |   Ağaç         - Nonlinear <br />
Root Node Leaf  <br />
Child Parent Siblings Edge      <br />
Level -> zero start (Root) + Edge       <br />
High Level ==> Tree Height = max single branch edges.    <br />
Left Subtree (smaller than Root) | Right Subtree (larger than Root)    <br />

        Max Tree Node = 2^(h+1)-1 

### [Traveling on the Tree](https://github.com/AtakanTurgut/DataStructures_Advanced/blob/main/trees/trees/BinaryTrees/BinaryTrees.cs)

```
            1
          /   \
        2       3
       /  \    /  \
      4    5  6    7
     ||    || ||   ||
     n     n   n    n
```

- PreOrder  : Data Left Right     - O(n)    1 2 4 5 3 6 7
- InOrder   : Left Data Right     - O(n)    4 2 5 1 6 3 7
- PostOrder : Left Right Data     - O(n)    4 5 2 6 7 3 1   
- LevelOrder: Root > Nodes > Leafs - L>R    1 2 3 4 5 6 7

#### Skew Trees
- Skew Tree : Just one child from the Nodes.
- Left Skew Tree 
- Right Skew Tree

## [BinarySearchTrees<-T->](https://github.com/AtakanTurgut/DataStructures_Advanced/blob/main/trees/trees/BinarySearchTree/BinarySearchTree.cs) && [BinaryTrees<-T->](https://github.com/AtakanTurgut/DataStructures_Advanced/blob/main/trees/trees/BinaryTrees/BinaryTrees.cs) 

- The left is followed continuously for the smallest value. O(log(n)) (BST)     <br />
- The right is followed continuously for the greater value. O(log(n)) (BST)     <br />
- Find Value.    O(log(n)) (BST)    <br />
- Remove Value.  O(log(n)) (BST)    <br />

![](/pictures/bst.PNG)

- Strict Binary Tree : No child or two children.

```
            1
          /   \
        2       3
              /   \
             6     7
```

- Full Binary Tree : Two children from the Nodes.

```
            1
          /   \
        2       3
       /  \    /  \
      4    5  6    7
```

- Complete Binary Tree : Start from the Left Leaf. L>R

```
            1                     1
          /   \                 /   \
        2       3     =>      2       3
       /                     /  \    /   
      4                     4    5  6   
```

Left Subtree (smaller than Root) | Right Subtree (larger than Root)     <br />
Left to Right for Add.    <br />

```
            23                  
          /   \                 PreOrder   DLR : 23 16 3 22 45 37 99
        16      45              InOrder    LDR : 3 16 22 23 37 45 99
       /  \    /  \             PostOrder  LRD : 3 22 16 37 99 45 23
      3   22  37  99            LevelOrder L>R : 23 16 45 3 22 37 99
      n    n  n    n
```

-  After the Root is deleted, the New Root is selected greater from the left or smaller from the right.     <br />

![](/pictures/Trees.PNG)


## [Queues<-T->](https://github.com/AtakanTurgut/DataStructures_Advanced/blob/main/queues/queues/Queue.cs) 
Queue<-T->  |   Kuyruk         Type Safety  -> generic - Linear  <br />
First-in First-out    ->  FIFO   |  Last-in Last-out    ->  LILO     |    Abstract Data Type   <br />
.Enqueue() -> Ekleme       .Dequeue() -> Çıkarma    <br />
 <br />
The Operating System is used to set operating priorities.   <br />
    -> İşletim sistemlerinde çalışma önceliğini belirlemede kullanılır.   <br />

![](pictures/Queues.PNG)

## [Priority Queue](#) && [Heaps<-T->](https://github.com/AtakanTurgut/DataStructures_Advanced/blob/main/heaps/heaps/BHeap.cs)
Quick Add and Quick Remove <br/>
.Insert() .DeleteMin() .DeleteMax() <br/>
.Enqueue() -> Ekleme O(1)      .Dequeue() -> Çıkarma O(n)    <br />

- The Parent will be smaller than the Children for `Min-Heap`.
- The Parent will be older than the Children for `Max-Heap`.

Indexing for zero-based:     - C# -
- Left Index   = parent.index * 2 + 1;      5 * 2 + 1 = 11;
- Right Index  = parent.index * 2 + 2;      5 * 2 + 2 = 12;
- Parent Index = (child.indexes - 1) / 2;   (11 - 1) / 2 = 5, (12 - 1) / 2 = 5;

Indexing for one-based:
- Left Index   = parent.index * 2;        6 * 2 = 12;
- Right Index  = parent.index * 2 + 1;    6 * 2 + 1 = 13;
- Parent Index = child.indexes / 2;       12 / 2 = 6, 13 / 2 = 6;

```
     Min-Heap       |      Max-Heap  
    
         1                     7
       /   \                 /   \
      5     2               5     6
     /  \  /  \            /  \  /  \
    6   7  4   3          1   4  2   3

i: 0 1 2 3 4 5 6    |    0 1 2 3 4 5 6    zero-based index
v: 1 5 2 6 7 4 3    |    7 5 6 1 4 2 3    LevelOrder  L>R
```

- Sorting an array using heap sort algorithm 
- Implementing priority queues 
- Data Compression: Huffman Coding Algorithm
- Shortest Path Algorithms Dijkstra's Algorithm
- Minimum Spanning Tree Algorithm: Prim's Algorithm
- Event-driven Simulation: customers in a line
- Selection problem: Finding kth-smallest element
- Run multiple programs in the operating system
- Select print jons in order of decreasing length
- Greedy Algorithms

### Min-Heap
![](/pictures/heapMin.PNG)

### Max-Heap
![](/pictures/heapMax.PNG)

### Heapifying
 The downward movement is called `Percolate down` from the Heapifying.    <br />
 The upward movement is called `Percolate up` from the Heapifying.    <br />

 Scrolling is done through ancestors. O(log(n)) <br />

 - Inserting in Binary Heap
 ```
            54                    54                    54                   _99                  
          /   \       ->        /   \       ->        /   \        ->       /   \ 
        45      36            45      36           _99      36            54      36
       /  \    /  \          /  \    /  \          /  \    /  \          /  \    /  \
      27   29 18   21      _99   29 18   21       45   29 18   21       45   29 18   21
     /  +                  /  \                  /  \                  /  \
    11  (99)              11   27               11   27               11   27  

                              Max-Heap  ->  heapify-up   
 ```

- Deletion in Binary Heap   =>  The Root Node is deleted.
 ```
          -(54)            (54)  _11                    45                    45                  
          /   \       ->        /   \       ->        /   \        ->       /   \ 
        45      36            45      36           _11      36            29      36
       /  \    /  \          /  \    /  \          /  \    /  \          /  \    /  \
      27   29 18   21       27  29 18   21        27   29 18   21       27  _11 18   21
     /                     
   _11                        Max-Heap  ->  heapify-down                      
 ```
 
 ### Heapsort
 O(nlog(n))

![](/pictures/Heaps.PNG)