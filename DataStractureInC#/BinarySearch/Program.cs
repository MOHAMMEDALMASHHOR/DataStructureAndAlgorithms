Console.Write("Enter a number: ");

        // Read the input from the user
        string userInput = Console.ReadLine();

        int number;

        // Try to parse the input string to an integer
        if (int.TryParse(userInput, out number))
        {
            // Conversion successful
            Console.WriteLine("You entered: " + number);
        }
        else
        {
            // Conversion failed
            Console.WriteLine("Invalid input. Please enter a valid integer.");
        }
int[] arr = new int[number];
        for (int i = 0; i < number; i++)
        {
            System.Console.WriteLine("Enter the value for index " + i+ ": ");
            var newValue = int.Parse(Console.ReadLine());   
            arr[i] =newValue ;
        }
        BinarySearch bs = new BinarySearch();
        int target = 5;
        int result = bs.Search(arr, target);
        if (result != -1)
        {
            Console.WriteLine("The element is found at index: " + result);
        }
        else
        {
            Console.WriteLine("The element is not found!!!");
        }
string array1 = "{";
foreach (var item in arr)
{
    array1 += item.ToString() + ",";    
}
array1 += "}";
System.Console.WriteLine("The array is: " + array1);