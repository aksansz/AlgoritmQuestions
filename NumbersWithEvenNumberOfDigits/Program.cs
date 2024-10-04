namespace NumbersWithEvenNumberOfDigits
{
    /*
    Given an array nums of integers, return how many of them contain an even number of digits.

    Example 1:
    Input: nums = [12,345,2,6,7896]
    Output: 2
    Explanation: 
    12 contains 2 digits (even number of digits). 
    345 contains 3 digits (odd number of digits). 
    Therefore only 12 and 7896 contain an even number of digits.
    */
    public class Program
    {
        public static void Main(string[] args)
        {
            //Test Case 1
            int[] nums1 = {12,345,2,6,7896};
            int output1 = NumbersWithEvenNumberOfDigits1(nums1);
            Console.WriteLine(output1);
    
            //Test Case 2
            int[] nums2 = {555,901,482,1771};
            int output2 = NumbersWithEvenNumberOfDigits1(nums2);
            Console.WriteLine(output2);
        }
        public static int NumbersWithEvenNumberOfDigits1(int[] nums) //Time Complexity O(m*log(n))
        {
            int numsCount = 0;

            for(int i = 0; i < nums.Length; i++)
            {   
                int digitCount = 0;
                if(nums[i] == 0)
                {
                    digitCount++;
                }
                while(nums[i] > 0)
                {
                    nums[i] /= 10;
                    digitCount++;
                }
                if(digitCount % 2 == 0)
                {
                    numsCount++;
                }
            }
            return numsCount;
        }
        public static int NumbersWithEvenNumberOfDigits2(int[] nums)  // Time Complexity O(m)
        {
            int numsCount = 0;

            for(int i = 0; i < nums.Length; i++)
            {
                int digitCount = nums[i].ToString().Length;
                if(digitCount % 2 == 0)
                {
                    numsCount++;
                }
            }
            return numsCount;
        }
    }
}