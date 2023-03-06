using Egzamin2;

var pq = new PriorityQueue<char>(new char[] { 'd', 'f', 'g', 'o', 'c', 'h'} );
Console.WriteLine(string.Join(' ', pq.ToArray()));
Console.WriteLine( pq.Dequeue() );
Console.WriteLine(string.Join(' ', pq.ToArray()));

