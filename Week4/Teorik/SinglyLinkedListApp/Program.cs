var node1 = new SinglyLinkedListNode<String>();
node1.Value = "Mohammed";
var node2 = new SinglyLinkedListNode<String>("Manger");
node1.Next=node2;
var node3 = new SinglyLinkedListNode<String>();
node3.Value = "Ali";
node2.Next=node3;

var current = node1;
while (current != null){
    System.Console.WriteLine(current);
    current = current.Next;
}