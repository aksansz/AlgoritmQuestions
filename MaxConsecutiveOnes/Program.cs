namespace MaxConsecutiveOnes
{

    /*
    Given a binary array nums, return the maximum number of consecutive 1's in the array.
    
    Example 1:
    Input: nums = [1,1,0,1,1,1]
    Output: 3
    Explanation: The first two digits or the last three digits are consecutive 1s. The maximum number of consecutive 1s is 3.
    */
    public class Program
    {
        public static void Main(string[] args)
        {

            //Test Case 1
            int[] nums1 = {1,1,0,1,1,1};
            int output1 = MaxConsecutiveOnes(nums1);
            Console.WriteLine(output1);
            
            // Test Case 2:
            int[] nums2 = {1,0,1,1,0,1};
            int output2 = MaxConsecutiveOnes(nums2);
            Console.WriteLine(output2);
        }

        public static int MaxConsecutiveOnes(int[] nums)
        {
            int consecutive = 0;
            int maxConsecutive = 0;

            for(int i=0; i < nums.Length; i++)
            {
                if(nums[i] == 1)
                {
                    consecutive++;
                    // maxConsecutive = Math.Max(maxConsecutive, consecutive);  //Basic max calculation
                    if(consecutive > maxConsecutive)
                    {
                        maxConsecutive = consecutive;
                    }
                }
                else{
                    consecutive = 0;
                }
            }
            return maxConsecutive;
        }
    }
}