namespace TwoSum
{
    /*
    Given an array of integers nums and an integer target, return indices of the two numbers such that they add up to target.
    You may assume that each input would have exactly one solution, and you may not use the same element twice.
    You can return the answer in any order.

    Example 1:
    Input: nums = [2,7,11,15], target = 9
    Output: [0,1]
    Explanation: Because nums[0] + nums[1] == 9, we return [0, 1].

    Example 2:
    Input: nums = [3,2,4], target = 6
    Output: [1,2]

    */
    public class Program
    {
        public static void Main(string[] args)
        {
            //Test Case 1:
            int[] nums1 = new int[] {2,7,11,15};
            int target1 = 9;
            int[] result1 = TwoSum_Solution1(nums1, target1);
            Console.WriteLine($"Result1 = {result1[0]},{result1[1]} -> Value = {nums1[result1[0]]}, {nums1[result1[1]]} -> Target1 = {target1}");

            //Test Case 2:
            int[] nums2 = new int[] {3,2,4};
            int target2 = 6;
            int[] result2 = TwoSum_Solution1(nums2, target2);
            Console.WriteLine($"Result2 = {result2[0]},{result2[1]} -> Value = {nums2[result2[0]]}, {nums2[result2[1]]} -> Target2 = {target2}");

            //Test Case 3:
            int[] nums3 = new int[] {3,3};
            int target3 = 6;
            int[] result3 = TwoSum_Solution1(nums3, target3);
            Console.WriteLine($"Result3 = {result3[0]},{result3[1]} -> Value = {nums3[result3[0]]}, {nums3[result3[1]]} -> Target3 = {target3}");
        }
        public static int[] TwoSum_Solution1(int[] nums, int target)
        {
            int[] result = new int[2];
            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = i+1; j < nums.Length; j++)
                {
                    if(nums[i]+nums[j] == target)
                    {
                        result[0]=i;
                        result[1]=j;
                    }
                }
            }
            return result;
        }
        public static int[] TwoSum_Solution2(int[] nums, int target)
        {
            Dictionary<int, int> num_to_index = new Dictionary<int, int>();
            int currentNumber;
            int remainder;
            int remainder_index;
            int[] answer = new int[2];

            for (int i = 0; i < nums.Length; i++)
            {
                currentNumber = nums[i];
                remainder = target - currentNumber;
                if(num_to_index.ContainsKey(remainder))
                {
                    remainder_index = num_to_index[remainder];
                    answer[0] = remainder_index;
                    answer[1] = i;
                    return answer;
                }
                num_to_index[currentNumber] = i;
            }
            return null;
        }
    }
}