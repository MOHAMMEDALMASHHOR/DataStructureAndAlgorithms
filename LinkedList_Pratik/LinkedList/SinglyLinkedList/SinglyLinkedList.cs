using System;
using System.Collections;
using System.Collections.Generic;
/*
using System;
using System.Collections;
using System.Collections.Generic;

namespace DataStructures.LinkedList.SinglyLinkedList
{
    // Define a generic singly linked list class
    public class SinglyLinkedList<T> : IEnumerable<T>
    {
        // Properties
        public SinglyLinkedListNode<T> Head { get; private set; } // Reference to the first node
        public int Count { get; private set; } // Number of nodes in the list
        private bool isHeadNull => Head == null; // Helper property to check if the list is empty

        // Constructors
        // Initialize an empty linked list
        public SinglyLinkedList()
        {
            Head = null;
            Count = 0;
        }

        // Initialize a linked list with elements from a collection
        public SinglyLinkedList(IEnumerable<T> collection)
        {
            Head = null;
            Count = 0;
            // Add each item from the collection to the beginning of the list
            foreach (var item in collection)
            {
                this.AddFirst(item);
            }
        }

        // Method to add a new node with the specified value to the beginning of the list
        public void AddFirst(T value)
        {
            var newNode = new SinglyLinkedListNode<T>(value);
            if (isHeadNull)
            {
                Head = newNode; // Set the new node as the head
            }
            else
            {
                newNode.Next = Head; // Make the new node point to the current head
                Head = newNode; // Update the head to the new node
            }
            Count++; // Increment the count of nodes
        }

        // Method to add a new node with the specified value to the end of the list
        public void AddLast(T value)
        {
            var newNode = new SinglyLinkedListNode<T>(value);
            if (isHeadNull)
            {
                Head = newNode; // Set the new node as the head if the list is empty
            }
            else
            {
                var current = Head;
                while (current.Next != null)
                {
                    current = current.Next; // Traverse the list until the last node
                }
                current.Next = newNode; // Append the new node to the end of the list
            }
            Count++; // Increment the count of nodes
        }

        // Other methods for adding, removing, and retrieving nodes, as well as converting the list to a list and implementing IEnumerable<T>

        // IEnumerator<T> implementation to enable foreach iteration
        public IEnumerator<T> GetEnumerator()
        {
            return new SinglyLinkedListEnumerator<T>(Head); // Pass the head node to the enumerator
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator(); // Implement the non-generic version of GetEnumerator
        }
    }
}
*/
namespace DataStructures.LinkedList.SinglyLinkedList
{
    public class SinglyLinkedList<T> : IEnumerable<T>
    {

        public SinglyLinkedListNode<T> Head { get; private set; }
        public int Count { get; private set; }
        private bool isHeadNull => Head == null;

        public SinglyLinkedList()
        {
            Head = null;
            Count = 0;
        }

        public SinglyLinkedList(IEnumerable<T> collection)
        {
            Head = null;
            Count = 0;
            foreach (var item in collection)
            {
                this.AddFirst(item);
            }
        }

        public void AddFirst(T value)
        {
            var newNode = new SinglyLinkedListNode<T>(value);
            if (isHeadNull)
            {
                Head = newNode;
                Count++;
                return;
            }
            newNode.Next = Head;
            Head = newNode;
            Count++;
        }
        public void AddLast(T value)
        {
            var newNode = new SinglyLinkedListNode<T>(value);
            if (isHeadNull)
            {
                Head = newNode;
                Count++;
                return;
            }

            var current = Head;
            var prev = current;
            while (current != null)
            {
                prev = current;
                current = current.Next;
            }
            prev.Next = newNode;
            Count++;

        }
        public void AddBefore(SinglyLinkedListNode<T> node, T value)
        {
            if (node == null)
                throw new ArgumentNullException();

            // liste boş veya ilk elemandan önce ekleme yapılmak isteniyor ise
            if (isHeadNull || node.Equals(Head))
            {
                AddFirst(value);
                return;
            }

            var newNode = new SinglyLinkedListNode<T>(value);
            var current = Head;
            var prev = current;

            // Daha sonraki düğümler için
            while (current != null)
            {
                if (current.Equals(node))
                {
                    newNode.Next = prev.Next;
                    prev.Next = newNode;
                    Count++;
                    return;
                }
                prev = current;
                current = current.Next;
            }

            throw new ArgumentException("There is no such a node in the list.");
        }
        public void AddAfter(SinglyLinkedListNode<T> node, T value)
        {
            if (node == null)
                throw new ArgumentNullException("Reference node can't be null.");

            // list boş veya ilk düğümden sonra 
            if (isHeadNull)
            {
                AddFirst(value);
                return;
            }

            // Diğer durumlarda.
            var newNode = new SinglyLinkedListNode<T>(value);
            var current = Head;
            while (current != null)
            {
                if (current.Equals(node))
                {
                    newNode.Next = current.Next;
                    current.Next = newNode;
                    Count++;
                    return;
                }
                current = current.Next;
            }
            throw new ArgumentException("There is no such a node in the list.");
        }
        public T RemoveFirst()
        {
            if (isHeadNull)
                throw new ArgumentNullException();

            var temp = Head;
            Head = Head.Next;
            Count--;
            return temp.Value;
        }
        public T RemoveLast()
        {
            if (isHeadNull || Count == 0)
                throw new ArgumentNullException();

            // Head silinecek ise; 
            if (Count == 1)
            {
                var temp = Head;
                Head = null;
                Count--;
                return temp.Value;
            }
            else
            {
                var current = Head;
                var prev = current;
                while (current.Next != null)
                {
                    prev = current;
                    current = current.Next;
                }
                prev.Next = null;
                Count--;
                return prev.Value;
            }
        }
        public T Remove(T value)
        {
            if (Count == 0 || isHeadNull)
                throw new ArgumentNullException();

            if (Head.Value.Equals(value))
                return RemoveFirst();

            var current = Head;
            var prev = current;
            while (current != null)
            {
                if (current.Value.Equals(value))
                {
                    prev.Next = current.Next;
                    Count--;
                    return current.Value;
                }
                prev = current;
                current = current.Next;
            }
            throw new ArgumentException("There is no such element in the list.");
        }
        public List<SinglyLinkedListNode<T>> GetNodes()
        {
            var list = new List<SinglyLinkedListNode<T>>();
            var current = Head;
            while (current != null)
            {
                list.Add(current);
                current = current.Next;
            }
            return list;
        }

        public IEnumerator<T> GetEnumerator()
        {
            return new SinglyLinkedListEnumerator<T>(Head);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public List<T> ToList()
        {
            return new List<T>(this);
        }

    }
}
