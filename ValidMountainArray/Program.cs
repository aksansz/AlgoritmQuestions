namespace ValidMountainArray
{
    /*
    Given an array of integers arr, return true if and only if it is a valid mountain array.

    Recall that arr is a mountain array if and only if:

    arr.length >= 3
    There exists some i with 0 < i < arr.length - 1 such that:
    - arr[0] < arr[1] < ... < arr[i - 1] < arr[i]
    - arr[i] > arr[i + 1] > ... > arr[arr.length - 1]
    
    Example 3:
    Input: arr = [0,1,2,3,5,2,1]
    Output: true
    */
    public class Program
    {
        public static void Main(string[] args)
        {
            //Test Case 1:
            int[] arr1 = { 0,1,2,3,5,2,1 };
            System.Console.WriteLine(ValidMountainArray(arr1));
            //Test Case 2:
            int[] arr2 = { 2, 1 };
            System.Console.WriteLine(ValidMountainArray(arr2));

            //Test Case 3:
            int[] arr3 = { 2, 5, 5 };
            System.Console.WriteLine(ValidMountainArray(arr3));

        }
        public static bool ValidMountainArray(int[] arr)
        {
            int i = 0;
            int n = arr.Length;

            //Array lenght need to be at least 3
            if(arr.Length < 3){ 
                return false;
            }

            // Find the increasing part
            while(i + 1 < n && arr[i] < arr[i+1])
            {
                i++;
            }
            //High number cannot be at the beginnig or the end
            if(i == 0 && i == n-1)
            {
                return false;
            }
            //Find decreasing part
            while(i + 1 < n && arr[i] > arr[i+1])
            {
                i++;
            }
            //if i reach to last number return true
            return i == n - 1;
        }
    }
}