namespace IsPalindrome
{
    /*
    Given an integer x, return true if x is a palindrome, and false otherwise.

    Example 1:
    Input: x = 121
    Output: true
    Explanation: 121 reads as 121 from left to right and from right to left.

    Example 2:
    Input: x = -121
    Output: false
    Explanation: From left to right, it reads -121. From right to left, it becomes 121-. Therefore it is not a palindrome.
    */
    public class Program
    {
        public static void Main(string[] args)
        {   
            //Test Case 1:
            int x1 = 121;
            bool result1 = IsPalindrome_Solution2(x1);
            System.Console.WriteLine($"{x1} - {result1}");

            //Test Case 2:
            int x2 = -121;
            bool result2 = IsPalindrome_Solution2(x2);
            System.Console.WriteLine($"{x2} - {result2}");

            //Test Case 3:
            int x3 = 10;
            bool result3 = IsPalindrome_Solution2(x3);
            System.Console.WriteLine($"{x3} - {result3}");
        }
        public static bool IsPalindrome_Solution1(int x)
        {
            int original = x;
            int remainder = 0;
            int reversed = 0;

            if(x < 0)
            {
                return false;
            }

            while(x != 0)
            {
                remainder = x%10;
                x/=10;
                reversed = reversed*10 + remainder;
            }
            if (reversed == original)
            {
                return true;
            }
            else{
                return false;
            }

        }
        public static bool IsPalindrome_Solution2(int x)
        {
            int leftPointer = 0;
            int rightPointer;

            if(x<10)
            {
                return false;
            }
            string xStr = x.ToString();
            rightPointer = xStr.Length -1;

            while(rightPointer > leftPointer)
            {
                if(xStr[leftPointer] != xStr[rightPointer])
                {
                    return false;
                }
                leftPointer++;
                rightPointer--;
            }
            return true;
        }

        public static bool IsPalindrome_Solution3(int x)
        {
            if(x<0)
            {
                return false;
            }

            string xStr = x.ToString();
            char[] charArray = xStr.ToCharArray();
            Array.Reverse(charArray);
            string reversedxStr = new string(charArray);
            if(reversedxStr == xStr)
            {
                return true;
            }
            else{
                return false;
            }
        }
    }
}