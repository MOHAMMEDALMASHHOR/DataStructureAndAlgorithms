public SinglyLinkedList<T> JoinLinkedLists<T>(SinglyLinkedList<T> list1, SinglyLinkedList<T> list2)
{
    if (list1 == null || list1.Head == null)
    {
        return list2; // If list1 is empty, return list2
    }
    else if (list2 == null || list2.Head == null)
    {
        return list1; // If list2 is empty, return list1
    }
    else
    {
        // Find the last node of list1
        var current = list1.Head;
        while (current.Next != null)
        {
            current = current.Next;
        }

        // Join list2 to list1
        current.Next = list2.Head;

        return list1; // Return the joined list
    }
}
