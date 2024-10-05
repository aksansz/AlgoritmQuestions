using System.Runtime.InteropServices;
using System.Runtime.Serialization.Formatters;

namespace SquaresOfSortedArray
{
    /*
    Given an integer array nums sorted in non-decreasing order, return an array of the squares of each number sorted in non-decreasing order.
    
    Example 1:
    Input: nums = [-4,-1,0,3,10]
    Output: [0,1,9,16,100]
    Explanation: After squaring, the array becomes [16,1,0,9,100].
    After sorting, it becomes [0,1,9,16,100].
    */
    public class Program
    {
        public static void Main(string[] args)
        {
            //Test Case 1:
            int[] nums1 = {-4,-1,0,3,10};
            int[] result1 = SquaresOfSortedArray2(nums1);
            foreach (int result in result1)
            {
                Console.Write($"{result}, ");
            }
            System.Console.WriteLine();
            //Test Case 2:
            int[] nums2 = {-7,-3,2,3,11};
            int[] result2 = SquaresOfSortedArray2(nums2);
            foreach (int result in result2)
            {
                Console.Write($"{result}, ");
            }
            System.Console.WriteLine();
        }
        public static int[] SquaresOfSortedArray1(int[] nums)   // TimeComplexity : O(nlogn), SpaceComplexity : O(1)
        {
            for(int i = 0; i < nums.Length; i++)
            {
                nums[i] *= nums[i];
            }

            Array.Sort(nums);
            
            return nums;
        }
        public static int[] SquaresOfSortedArray2(int[] nums) // TimeComplexity : O(n), SpaceComplexity : O(n)
        {
            int n = nums.Length;
            int[] result = new int[n];
            int left = 0;
            int right = n-1;
            int index = n-1;

            while(left <= right)
            {
                int leftSquare = nums[left] * nums[left];
                int rightSquare = nums[right] * nums[right];

                if(leftSquare > rightSquare)
                {
                    result[index] = leftSquare;
                    left++;
                }
                else
                {
                    result[index] = rightSquare;
                    right--;
                }
                index--;
            }
            return result;
        }
    }
}