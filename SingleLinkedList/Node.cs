namespace SingleLinkedList;

public class Node<T> {
    public T Data { get; set; }
    public Node<T> Next { get; set; }

    public Node(T data, Node<T> next = null) {
        Data = data;
        Next = next;
    }

    public override string ToString() => (this == null) ? "null" : $"{Data} -> ";

    public static void PrintSingleLinkedList<T>(Node<T> head) {
        Console.Write("head -> ");
        while (head != null) {
            Console.Write(head.ToString());
            head = head.Next;
        }

        Console.Write("null");
    }

    public static void AddAtEndOfSingleLinkedList<T>(T element, ref Node<T> head) {
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

    public static Node<T> CreateSingleLinkedList<T>(params T[] arr) {
        if (arr == null || arr.Length == 0) return null;
        var head = new Node<T>(arr[0], null);
        var node = head;
        for (int i = 1; i < arr.Length; i++) {
            node.Next = new Node<T>(arr[i], null);
            node = node.Next;
        }

        return head;
    }

    public static Node<T> ReverseSingleLinkedList<T>(Node<T> head) {
        if (head == null) return null;
        var current = head;
        Node<T> preview = null;
        Node<T> next = null;
        while (current != null) {
            next = current.Next;
            current.Next = preview;
            preview = current;
            current = next;
        }

        return preview;
    }

    public static void MoveLastNodeToFront<T>(ref Node<T> head) {
        var node = head;
        if (node != null && node.Next != null) {
            while (node.Next.Next != null) {
                node = node.Next;
            }

            var elementToMove = node.Next;
            node.Next = null;
            elementToMove.Next = head;
            head = elementToMove;
        }
    }

    public static void RemoveNodeAt<T>(int position, ref Node<T> head) {
        var node = head;
        if (node != null) {
            Node<T> preview = null;
            var index = 0;
            while (index != position && node.Next != null) {
                preview = node;
                node = node.Next;
                index++;
            }

            if (index == position) {
                if (preview != null) {
                    preview.Next = node.Next;
                }
                else {
                    head = node.Next;
                }
            }
        }
    }

    public static void RemoveAllDuplicatesFromSortedLinkedList<T>(ref Node<T> head)
        where T : IEquatable<T>, IComparable<T> {
        if (head != null) {
            var current = head;
            Node<T> preview = null;
            while (current.Next != null) {
                if (preview != null) {
                    if (preview.Data.Equals(current.Data)) {
                        if (current.Next != null) {
                            preview.Next = current.Next;
                            current = current.Next;
                        }
                        else {
                            preview.Next = null;
                        }
                    }
                }

                if (preview == null || !preview.Data.Equals(current.Data)) {
                    preview = current;
                    current = current.Next;
                }
            }
        }
    }
}