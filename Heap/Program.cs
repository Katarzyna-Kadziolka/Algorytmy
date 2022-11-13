using Heap;

var heap = new Heap<int>(new List<int> {2, 1, 6, 7, 1, 3}, HeapOptions.MaxHeap);
foreach(var x in heap)
    Console.Write(x);