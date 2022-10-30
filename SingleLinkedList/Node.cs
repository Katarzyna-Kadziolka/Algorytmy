namespace SingleLinkedList; 

public class Node<T>
{    
    public T Data {get; set;}
    public Node<T> Next {get; set;}
    public Node(T data, Node<T> next = null) {
        Data = data; Next = next;
    }
    public override string ToString() => (this==null)? "null" : $"{Data} -> ";
    
    public static void PrintSingleLinkedList<T>( Node<T> head ) {
        var node = head;
        Console.Write("head -> ");
        while (node != null) {
           Console.Write(node.ToString());
           node = node.Next;
        }
        Console.Write("null");
        
    }
}