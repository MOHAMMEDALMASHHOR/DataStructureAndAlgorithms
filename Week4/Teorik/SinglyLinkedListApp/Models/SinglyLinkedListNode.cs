public class SinglyLinkedListNode<T>
{
    public T Value { get; set; }
    public SinglyLinkedListNode<T> Next { get; set; }
    public SinglyLinkedListNode()
    {

    }
    public SinglyLinkedListNode(T item)
    {
        Value = item;
    }
    public override string ToString()
    {
        return $"{Value}";
    }
}