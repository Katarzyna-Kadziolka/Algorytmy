using SingleLinkedList;

var head = Node<int>.CreateSingleLinkedList<int>(1, 1);
Node<int>.PrintSingleLinkedList<int>(head);
Node<int>.RemoveAllDuplicatesFromSortedLinkedList<int>(ref head);
Node<int>.PrintSingleLinkedList<int>(head);
