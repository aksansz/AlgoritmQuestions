namespace StepsToReduceZero
{
    /*
    Given an integer num, return the number of steps to reduce it to zero.
    In one step, if the current number is even, you have to divide it by 2, otherwise, you have to subtract 1 from it.
    
    Example:
    Input: num = 8
    Output: 4
    Explanation: 
    Step 1) 8 is even; divide by 2 and obtain 4. 
    Step 2) 4 is even; divide by 2 and obtain 2. 
    Step 3) 2 is even; divide by 2 and obtain 1. 
    Step 4) 1 is odd; subtract 1 and obtain 0.
    */
    public class Program
    {
        public static void Main(string[] args)
        {
            //Test Case 1:
            int num1 = 14;
            int expectedOutput1 = 6;
            System.Console.WriteLine($"Output = {StepsToReduceZero_Solution2(num1)} - {StepsToReduceZero_Solution2(num1) == expectedOutput1}");

            //Test Case 2:
            int num2 = 8;
            int expectedOutput2 = 4;
            System.Console.WriteLine($"Output = {StepsToReduceZero_Solution2(num2)} - {StepsToReduceZero_Solution2(num2) == expectedOutput2}");


            //Test Case 3:
            int num3 = 123;
            int expectedOutput3 = 12;
            System.Console.WriteLine($"Output = {StepsToReduceZero_Solution2(num3)} - {StepsToReduceZero_Solution2(num3) == expectedOutput3}");

        }
        public static int StepsToReduceZero_Solution1(int num)
        {
            int step = 0;
            while(num > 0)
            {
                if(num%2 == 0)
                {
                    num /= 2;
                }
                else
                {
                    num--;
                }
                step++;
            }
            return step;
        }
        public static int StepsToReduceZero_Solution2(int num)
        {
            int step = 0;
            while(num>0)
            {
                if((num & 1) == 0) //Using BitMask
                {
                    num >>= 1;  //Slide Bit right by 1
                }
                else
                {
                    num--;
                }
                step++;
            }
            return step;
        }
    }
}