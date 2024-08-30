/*Problem:
Given a sorted array of integers arr and an integer target, return the index of target if it exists in arr. 
If target does not exist, return -1. You must write an algorithm with O(log n) runtime complexity.

Example 1:
int[] arr = {1, 2, 3, 4, 5, 6, 7, 8, 9, 10};
int target = 7;
Output: 6

Example 2:
int[] arr = {15, 18, 21, 24, 27, 30, 33, 36, 39, 42};
int target = 25;
Output: -1

*/
namespace BinarySearch
{
    public class Program
    {
        public static void Main (string[] args)
        {
            //Test Case 1
            int[] arr = {1, 2, 3, 4, 5, 6, 7, 8, 9, 10};
            int target = 1 ;
            int result = BinarySearch(arr, target);
            Console.WriteLine($"Test 1 Result = {result}");

            //Test Case 2
            int[] arr2 = {15, 18, 21, 24, 27, 30, 33, 36, 39};
            int target2 = 33;
            int result2 = BinarySearch(arr2, target2);
            Console.WriteLine($"Test2 Result = {result2}");

            //Test Case 3
            int[] arr3 = {15, 18, 21, 24, 27, 30, 33, 36, 39, 42};
            int target3 = 25;
            int result3 = BinarySearch(arr3, target3);
            Console.WriteLine($"Test3 Result = {result3}");
        }

        public static int BinarySearch(int[] arr, int target)
        {
            int left = 0;
            int right = arr.Length - 1;

            while(left <= right)
            {
                int mid = left + (right - left) / 2;
                
                if (arr[mid] == target)
                {
                    return mid;
                }
                else if (arr[mid] < target)
                {
                    left = mid +1;
                }
                else
                {
                    right = mid - 1;
                }
            }
            return -1;
        }
    }
}