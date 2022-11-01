using SingleLinkedList;

var head = Node<int>.CreateSingleLinkedList<int>(new int[] {1} );
Node<int>.PrintSingleLinkedList<int>(head);
Node<int>.MoveLastNodeToFront<int>(ref head);
Node<int>.PrintSingleLinkedList<int>(head);
