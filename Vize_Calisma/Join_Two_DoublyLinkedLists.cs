public class DoublyLinkedListNode<T>
{
    public T Value { get; set; }
    public DoublyLinkedListNode<T> Next { get; set; }
    public DoublyLinkedListNode<T> Previous { get; set; }

    public DoublyLinkedListNode(T value)
    {
        Value = value;
        Next = null;
        Previous = null;
    }
}

public class DoublyLinkedList<T>
{
    public DoublyLinkedListNode<T> Head { get; private set; }
    public int Count { get; private set; }

    // Other methods like AddLast, AddFirst, Remove, etc. can be added here

    // Function to join two doubly linked lists
    public static DoublyLinkedList<T> JoinDoublyLinkedLists(DoublyLinkedList<T> list1, DoublyLinkedList<T> list2)
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
            list2.Head.Previous = current;
            return list1; // Return the joined list
        }
    }
}
