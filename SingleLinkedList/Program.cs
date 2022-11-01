using SingleLinkedList;

var head = Node<int>.CreateSingleLinkedList<int>(new int[] {1, 2, 3, 4} );
Node<int>.PrintSingleLinkedList<int>(head);
Node<int>.PrintSingleLinkedList<int>(Node<int>.ReverseSingleLinkedList<int>(head));