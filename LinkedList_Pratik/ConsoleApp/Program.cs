using System;

namespace ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.ReadKey();
        }
    }
}
/*
using System;
using System.Collections;
using System.Collections.Generic;

namespace DataStructures.LinkedList.DoublyLinkedList
{
    // Define a generic doubly linked list class
    public class DoublyLinkedList<T> : IEnumerable<T>
    {
        // Properties
        public DoublyLinkedListNode<T> Head { get; private set; } // Reference to the first node
        public DoublyLinkedListNode<T> Tail { get; private set; } // Reference to the last node
        public int Count { get; private set; } // Number of nodes in the list
        private bool isEmpty => Count == 0; // Helper property to check if the list is empty

        // Constructors
        // Initialize an empty doubly linked list
        public DoublyLinkedList()
        {
            Head = null;
            Tail = null;
            Count = 0;
        }

        // Initialize a doubly linked list with elements from a collection
        public DoublyLinkedList(IEnumerable<T> collection)
        {
            Head = null;
            Tail = null;
            Count = 0;
            // Add each item from the collection to the end of the list
            foreach (var item in collection)
            {
                this.AddLast(item);
            }
        }

        // Method to add a new node with the specified value to the beginning of the list
        public void AddFirst(T value)
        {
            var newNode = new DoublyLinkedListNode<T>(value);
            if (isEmpty)
            {
                Head = newNode;
                Tail = newNode;
            }
            else
            {
                newNode.Next = Head;
                Head.Previous = newNode;
                Head = newNode;
            }
            Count++;
        }

        // Method to add a new node with the specified value to the end of the list
        public void AddLast(T value)
        {
            var newNode = new DoublyLinkedListNode<T>(value);
            if (isEmpty)
            {
                Head = newNode;
                Tail = newNode;
            }
            else
            {
                Tail.Next = newNode;
                newNode.Previous = Tail;
                Tail = newNode;
            }
            Count++;
        }

        // Method to add a new node with the specified value before the specified node
        public void AddBefore(DoublyLinkedListNode<T> node, T value)
        {
            // Implementation goes here
        }

        // Method to add a new node with the specified value after the specified node
        public void AddAfter(DoublyLinkedListNode<T> node, T value)
        {
            // Implementation goes here
        }

        // Other methods for adding, removing, and retrieving nodes, as well as converting the list to a list and implementing IEnumerable<T>

        // IEnumerator<T> implementation to enable foreach iteration
        public IEnumerator<T> GetEnumerator()
        {
            return new DoublyLinkedListEnumerator<T>(Head); // Pass the head node to the enumerator
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator(); // Implement the non-generic version of GetEnumerator
        }
    }
}
*/
