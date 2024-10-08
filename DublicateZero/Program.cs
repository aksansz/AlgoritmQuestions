namespace DublicateZero
{
    /*
    Given a fixed-length integer array arr, duplicate each occurrence of zero, shifting the remaining elements to the right.
    Note that elements beyond the length of the original array are not written. Do the above modifications to the input array in place and do not return anything.

    Example 1:
    Input: arr = [1,0,2,3,0,4,5,0]
    Output: [1,0,0,2,3,0,0,4]
    Explanation: After calling your function, the input array is modified to: [1,0,0,2,3,0,0,4]
    */
    public class Program
    {
        public static void Main(string[] args)
        {
            //Test Case 1:
            int[] arr1 = { 1,0,2,3,0,4,5,0 };
            DublicateZero(arr1);
            foreach(int i in arr1)
            {
                System.Console.Write($"{i}, ");
            }
            System.Console.WriteLine();
            //Test Case 2:
            int[] arr2 = { 1,2,3 };
            DublicateZero(arr2);
            foreach(int i in arr2)
            {
                System.Console.Write($"{i}, ");
            }
            System.Console.WriteLine();

        }
        public static void DublicateZero(int[] arr) //TimeComplexity = O(N^2), SpaceComplexity O(1)
        {
            int zeroCount = 0;
            int n = arr.Length - 1;
            
            for(int i = 0; i <= n; i++)
            {
                if(arr[i] == 0)
                {
                    zeroCount++;
                }
            }
            
            for(int i = n; i >= 0; i--)
            {
                if(arr[i] == 0) zeroCount--;
                int shiftedIndex = i + zeroCount;
                if(shiftedIndex > n)  continue;
                arr[shiftedIndex] = arr[i];
                if(arr[i] == 0 && (shiftedIndex+1)<=n)
                {
                    arr[shiftedIndex+1] = arr[i];
                    
                }
            }
        }
    }
}