using Heap;

var heap = new Heap<char>(new char[] { 'd', 'f', 'g', 'o', 'c', 'h'}, HeapOptions.MaxHeap);
Console.WriteLine(string.Join(' ', heap.ToArray()));
Console.WriteLine( heap.Delete() );
Console.WriteLine(string.Join(' ', heap.ToArray()));