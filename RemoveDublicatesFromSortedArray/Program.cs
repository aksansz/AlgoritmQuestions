namespace RemoveDublicatesFromSortedArray
{
    /*
    Given an integer array nums sorted in non-decreasing order, remove the duplicates in-place such that each unique element appears only once. The relative order of the elements should be kept the same. Then return the number of unique elements in nums.
    Consider the number of unique elements of nums to be k, to get accepted, you need to do the following things:
    Change the array nums such that the first k elements of nums contain the unique elements in the order they were present in nums initially. The remaining elements of nums are not important as well as the size of nums.
    Return k.
    
    Example 1:
    Input: nums = [0,0,1,1,1,2,2,3,3,4]
    Output: 5, nums = [0,1,2,3,4,_,_,_,_,_]
    Explanation: Your function should return k = 5, with the first five elements of nums being 0, 1, 2, 3, and 4 respectively.
    It does not matter what you leave beyond the returned k (hence they are underscores).
    */
    public class Program
    {
        public static void Main(string[] args)
        {
            //Test Case 1:
            int[] nums1 = {0,0,1,1,1,2,2,3,3,4};
            int output1 = RemoveDublicatesFromSortedArray(nums1);
            System.Console.WriteLine(output1);
            for (int i = 0; i < output1; i++)
            {
                System.Console.Write($"{nums1[i]}, ");
            }
            System.Console.WriteLine();
            
            //Test Case 2:
            int[] nums2 = {1,1,2};
            int output2 = RemoveDublicatesFromSortedArray(nums2);
            System.Console.WriteLine(output2);
            for (int i = 0; i < output2; i++)
            {
                System.Console.Write($"{nums2[i]}, ");
            }
            System.Console.WriteLine();
        }
        public static int RemoveDublicatesFromSortedArray(int[] nums)
        {
            int k = 1; //Unique numbers count

            for(int i = 1; i < nums.Length; i++)
            {
                if(nums[i] != nums[i-1])
                {
                    nums[k++] = nums[i];
                }
            }
            return k;
        }
    }
}