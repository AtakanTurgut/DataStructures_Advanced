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

### [SinglyLinkedList<-T->](https://github.com/AtakanTurgut/DataStructures_Advanced/blob/main/linkedlists/linkedlists/SinglyLinkedList/SinglyLinkedListNode.cs)   
SinglyLinkedList<-T->   |   Tek Yönlü Bağlı Liste  
First Node = Head   |   Last Node = Tail -> NULL

        Node == value | pointer = default NULL     
                value | next | ->

.Insert()   .Delete()   -   .DeleteList()   .Count()    .Find()

- Language Integrated Query - LINQ
- Inserting at the beginning (Head) O(1).
- Inserting at the ending (Tail ->  NULL) O(n).
- Inserting at the middle O(n).
- Traversing the list O(N).
- Deleting first node in the singly linked list O(1).
- Deleting last node in the singly linked list O(n).
- Deleting an intermediate node in the singly linked list O(n).

![](/pictures/SinglyLinkedLists.PNG)





