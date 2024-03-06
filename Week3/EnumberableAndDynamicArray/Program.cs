using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Creating a dynamic array of integers
        List<int> dynamicArray = new List<int>();

        // Adding elements to the dynamic array
        dynamicArray.Add(10);
        dynamicArray.Add(20);
        dynamicArray.Add(30);

        // Accessing elements of the dynamic array
        Console.WriteLine("Elements of the dynamic array:");
        foreach (int num in dynamicArray)
        {
            Console.WriteLine(num);
        }

        // Modifying elements of the dynamic array
        dynamicArray[1] = 25;

        // Removing elements from the dynamic array
        dynamicArray.RemoveAt(2);

        // Displaying the modified dynamic array
        Console.WriteLine("\nModified elements of the dynamic array:");
        foreach (int num in dynamicArray)
        {
            Console.WriteLine(num);
        }
    }
}
