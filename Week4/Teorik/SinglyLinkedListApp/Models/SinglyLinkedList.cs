public class SinglyLinkedList<T>
{
    private int count;
    public SinglyLinkedListNode<T> Head { get; set; }
    public int Count =>count;
    private bool IsHeadNull => Head == null;
    public void AddFirst(T item){
        var newNode = new SinglyLinkedListNode<T>(item);
        if (IsHeadNull)
        {
            Head = newNode;
            count++;
            return;
        }
        newNode.Next=Head;
        newNode=Head;
        count++;
    }
    public void AddLast(T item){
        var newNode = new SinglyLinkedListNode<T>(item);
        if (IsHeadNull){
            Head = newNode;
            count++;
            return;
        }
        var current=Head;
        var prev =current;
        while (current != null){
            prev=current;
            current=current.Next;
        }
        prev.Next=newNode;
        count++;
        return;
    }
    
}