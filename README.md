# Advanced Data Structures with C#

## Data Structures
System.Collections      IEnumerable
- ArrayList, Hashtable, Queue, Stack

System.Collections.Generic      IEnumerable<-T->    |   foreach - LINQ
- Dictionary<-TKey, TValue->, List<-T->, Queue<-T->
- SortedList<-TKey, TValue->, Stack<-T->
- SortedSet<-TKey, TValue->, HashSet<-TKey, TValue->

## [Arrays](https://github.com/AtakanTurgut/DataStructures_Advanced/blob/main/arrays/arrays/Program.cs) 
Array   |   Dizi -> Arrays are of reference type.   <br />
Zero-based indexing - Fixed sized <br />
One block allocation and Complex position-based insertion <br />
Single-dimension | Multi-dimension  <br />
Basic and Direct Access O(1) <br />

## [ArrayLists()](https://github.com/AtakanTurgut/DataStructures_Advanced/blob/main/arrays/arrays/Program.cs) 
ArrayList   |   non-generic = boxing -> object  |  object -> unboxing  <br />
Dynamically sized   |   Type non-safety
.Add()  .Remove()   .Insert()

## [Lists<-T->](https://github.com/AtakanTurgut/DataStructures_Advanced/blob/main/arrays/arrays/Program.cs)
List<-T->   |       Type Safety  -> generic     <br />
Interface -> Inheritance : Inherits contracts.  <br />

## [Arrays<-T->](https://github.com/AtakanTurgut/DataStructures_Advanced/blob/main/arrays/arrays/Array.cs)
Array<-T->   |       Type Safety  -> generic     <br />
Implement IEnumerable<-T->  <br />
![](/pictures/Arrays.PNG)

## [LinkedLists<-T->](https://github.com/AtakanTurgut/DataStructures_Advanced/blob/main/linkedlists/linkedlists/Program.cs) 
LinkedList<-T->  |  Bağlı Liste           Type Safety  -> generic  <br />
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
Stack<-T->  |  Yığın           Type Safety  -> generic     <br />
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

## [Queues<-T->](https://github.com/AtakanTurgut/DataStructures_Advanced/blob/main/queues/queues/Queue.cs) 
Queue<-T->  |   Kuyruk         Type Safety  -> generic    <br />
First-in First-out    ->  FIFO   |  Last-in Last-out    ->  LILO     |    Abstract Data Type   <br />
.Enqueue() -> Ekleme       .Dequeue() -> Çıkarma    <br />
 <br />
The Operating System is used to set operating priorities.   <br />
    -> İşletim sistemlerinde çalışma önceliğini belirlemede kullanılır.   <br />

![](pictures/Queues.PNG)