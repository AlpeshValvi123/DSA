using System;

public class Program
{
    // Method to perform binary search on a sorted array
    static int BinarySearch(int[] array, int target)
    {
        int low = 0;
        int high = array.Length - 1;

        // Continue searching while the range is valid
        while (low <= high)
        {
            // Calculate the midpoint to avoid overflow
            int mid = low + (high - low) / 2;

            // Check if the target is found
            if (array[mid] == target)
            {
                return mid;  // Return the index of the target
            }
            else if (array[mid] < target)
            {
                low = mid + 1;  // Adjust the lower bound
            }
            else
            {
                high = mid - 1;  // Adjust the upper bound
            }
        }

        return -1;  // Return -1 if the target is not found
    }

    // Main method to test the BinarySearch method
    static void Main()
    {
        // Sample array (must be sorted for binary search to work)
        int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

        // Define the target element to search for
        int target = 7;

        // Perform binary search and store the result
        int itemIndex = BinarySearch(array, target);

        // Output the result
        if (itemIndex != -1)
        {
            Console.WriteLine($"Element found at index {itemIndex}");
        }
        else
        {
            Console.WriteLine("Element not found in the array");
        }
    }
}
