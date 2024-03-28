//First of all we have to create the algorithm for the Binary search 
//Which is depending on sorting the elemants and then find the middle element and then compare the middle element with the target element
//If the target element is greater than the middle element then we have to search the right side of the middle element
//If the target element is less than the middle element then we have to search the left side of the middle element
//If the target element is equal to the middle element then we have to return the index of the middle element
//If the target element is not found then we have to return -1
//The time complexity of the Binary search is O(log n)
//The space complexity of the Binary search is O(1)
//The Binary search is the most efficient searching algorithm
//The Binary search is used to search the element in the sorted array
//The Binary search is used to search the element in the sorted list
//The Binary search is used to search the element in the sorted matrix
//The Binary search is used to search the element in the sorted string
//The Binary search is used to search the element in the sorted tree
public class BinarySearch
{
    /*
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
        }*/
   
    
    
    public int Search(int[] nums, int target)
    {
        for (int i = 0; i < nums.Length; i++){
            for (int j = i; j < 0; j--){
                if (nums[j] > nums[j+1]){
                    int temp = nums[j];
                    nums[j] = nums[j+1];
                    nums[j+1] = temp;
                }
            }
        }
        int left = 0;
        int right = nums.Length - 1;
        while (left <= right)
        {
            int mid = left + (right - left) / 2;
            if (nums[mid] == target)
            {
                return mid;
            }
            else if (nums[mid] < target)
            {
                left = mid + 1;
            }
            else
            {
                right = mid - 1;
            }
        }
        return -1;
    }

}