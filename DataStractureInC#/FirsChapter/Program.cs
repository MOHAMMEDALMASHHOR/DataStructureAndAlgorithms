//Time Complextiy
//Best Case -- Omega Notation 
//Average Case -- Theta Notation
//Worst Case -- Big O Notation O

int[] arr = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
var x = Array.IndexOf(arr, 1);
System.Console.WriteLine(x); //Best Case
var y = Array.IndexOf(arr, 5);
System.Console.WriteLine(y);//Average Case
var z = Array.IndexOf(arr, 10);
System.Console.WriteLine(z);//Worst Case

//Linear Search
int[] arr1 = new int[7] { 55, 12, 44, 33, 22, 99, 88 };
System.Console.WriteLine("Enter the number to search");
int a = int.Parse(Console.ReadLine());
static int LinearSearch(int[] ar, int n)
{
    int ele = -1;
    for (int i = 0; i < ar.Length; i++)
    {
        if (ar[i] == n)
        {
            ele = i;
            break;
        }
    }
    if (ele == -1)
    {
        System.Console.WriteLine("Element not found");
    }
    else
    {
        System.Console.WriteLine("{0} Element found at index {1} ",n,ele);
    }
    return ele;
}
System.Console.WriteLine(LinearSearch(arr1, a));
