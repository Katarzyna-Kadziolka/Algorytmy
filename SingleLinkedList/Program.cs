using SingleLinkedList;

Node<int> head = 
    new Node<int>(2,
        new Node<int>(5,
            new Node<int>(1)));
Node<int>.AddAtEndOfSingleLinkedList<int>( -1, ref head);
Node<int>.PrintSingleLinkedList<int>(head);