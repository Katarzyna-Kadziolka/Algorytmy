using SingleLinkedList;

var head = Node<int>.CreateSingleLinkedList<int>(1, 2, 3, 4, 5, 6);
Node<int>.PrintSingleLinkedList<int>(head);
Node<int>.RemoveNodeAt<int>(0, ref head);
Node<int>.PrintSingleLinkedList<int>(head);
