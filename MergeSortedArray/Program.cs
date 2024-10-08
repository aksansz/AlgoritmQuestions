﻿namespace MergeSortedArray
{
    /*
    You are given two integer arrays nums1 and nums2, sorted in non-decreasing order, and two integers m and n, representing
    the number of elements in nums1 and nums2 respectively.
    Merge nums1 and nums2 into a single array sorted in non-decreasing order.

    The final sorted array should not be returned by the function, but instead be stored inside the array nums1. To 
    accommodate this, nums1 has a length of m + n, where the first m elements denote the elements that should be merged, 
    and the last n elements are set to 0 and should be ignored. nums2 has a length of n.

    Example 1:
    Input: nums1 = [1,2,3,0,0,0], m = 3, nums2 = [2,5,6], n = 3
    Output: [1,2,2,3,5,6]
    Explanation: The arrays we are merging are [1,2,3] and [2,5,6].
    The result of the merge is [1,2,2,3,5,6] with the underlined elements coming from nums1.
    */
    
    public class Program
    {
        public static void Main(string[] args)
        {
            //Test Case 1:
            int[] nums1_1 = {1,2,3,0,0,0};
            int m1 = 3;
            int[] nums1_2 = {2,5,6};
            int n1 = 3;
            MergeSortedArray(nums1_1, nums1_2, m1, n1);
            foreach(int i in nums1_1)
            {
                System.Console.Write(i);
            }
            System.Console.WriteLine();

            //Test Case 2:
            int[] nums2_1 = {0};
            int m2= 0;
            int[] nums2_2 = {1};
            int n2 = 1;
            MergeSortedArray(nums2_1, nums2_2, m2, n2);
            foreach(int i in nums2_1)
            {
                System.Console.Write(i);
            }
            System.Console.WriteLine();
        }
        public static void MergeSortedArray(int[] nums1, int[] nums2, int m, int n)
        {
            int i = m-1;
            int j = n-1;
            int k = m+n-1;

            while(i >= 0 && j >= 0)
            {
                if(nums1[i] > nums2[j])
                {
                    nums1[k--] = nums1[i--];
                }
                else{
                    nums1[k--] = nums2[j--];
                }
            }
            while(j >= 0)
            {
                nums1[k--] = nums2[j--];
            }
        }
    }
}