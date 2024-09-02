

namespace RunningSum
{
 /*
Given an array nums. We define a running sum of an array as runningSum[i] = sum(nums[0]…nums[i]).
Return the running sum of nums.

Input: nums = [1,2,3,4]
Output: [1,3,6,10]
Explanation: Running sum is obtained as follows: [1, 1+2, 1+2+3, 1+2+3+4].
*/
    public class Program
    {
        public static void Main(string[] args)
        {
            //Test Case 1:
            int[] nums = { 1, 2, 3, 4,};
            int[] result = RunningSum_Solution1(nums);
            Console.WriteLine(string.Join(",", result));

            //Test Case 2:
            int[] nums2 = {3,1,2,10,1};
            int[] result2  = RunningSum_Solution1(nums2);
            Console.WriteLine(string.Join(",", result2));

            //Test Case 3:
            int[] nums3 = {1,1,1,1,1};
            int[] result3 = RunningSum_Solution1(nums3);
            Console.WriteLine(string.Join(",", result3));
        }

        public static int[] RunningSum_Solution1(int[] nums)
        {
            for(int i = 1; i < nums.Length; i++)
            {
                nums[i] = nums[i] + nums[i-1];
            }
            return nums;
        }

        public static int[] RunningSum_Solution2(int[] nums)
        {
            int[] result = new int[nums.Length];
            result[0] = nums[0];

            for(int i = 1; i < nums.Length; i++)
            {
                result[i] = nums[i] + result[i-1];
            }
            return result;
        }
    }
}