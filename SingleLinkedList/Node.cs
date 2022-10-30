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
        Console.Write("head -> ");
        while (head != null) {
           Console.Write(head.ToString());
           head = head.Next;
        }
        Console.Write("null");
    }

    public static void AddAtEndOfSingleLinkedList<T>(T element, ref Node<T> head)
    {
        if (head == null) {
            head = new Node<T>(element, null);
        }

        else {
            var node = head;
            var added = false;
            while (added != true) {
                if (node.Next == null) {
                    node.Next = new Node<T>(element, null);
                    added = true;
                }
                node = node.Next;
            }
            
        }
    }
}