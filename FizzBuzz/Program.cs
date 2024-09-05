namespace FizzBuzz
{
    /*
    Given an integer n, return a string array answer (1-indexed) where:

    answer[i] == "FizzBuzz" if i is divisible by 3 and 5.
    answer[i] == "Fizz" if i is divisible by 3.
    answer[i] == "Buzz" if i is divisible by 5.
    answer[i] == i (as a string) if none of the above conditions are true.

    Example 2:
    Input: n = 5
    Output: ["1","2","Fizz","4","Buzz"]
    */
    public class Program
    {
        public static void Main (string[] args)
        {
            //Test Case 1:
            int n1 = 3;
            IList<string> output1 = FizzBuzz_Solution2(n1);
            System.Console.WriteLine(string.Join(", ", output1));

            //Test Case 2:
            int n2 = 5;
            IList<string> output2 = FizzBuzz_Solution2(n2);
            System.Console.WriteLine(string.Join(", ", output2));

            //Test Case 3:
            int n3 = 15;
            IList<string> output3 = FizzBuzz_Solution2(n3);
            System.Console.WriteLine(string.Join(", ", output3));
        }

        public static IList<string> FizzBuzz_Solution1(int n)
        {
            List<string> answer = new List<string>();

            for(int i =1; i<=n; i++)
            {
                if(i%3 == 0 && i%5 == 0)
                {
                    answer.Add("FizzBuzz");
                }
                else if(i%3 == 0)
                {
                    answer.Add("Fizz");
                }
                else if(i%5 == 0)
                {
                    answer.Add("Buzz");
                }
                else
                {
                    answer.Add(i.ToString());
                }
            }
            return answer;
        }

        public static IList<string> FizzBuzz_Solution2(int n)
        {
            IList<string> answer = new List<string>();

            for(int i = 1; i<=n; i++)
            {
                string currString = "";

                if(i%3 == 0)
                {
                    currString += "Fizz";
                }
                if(i%5 == 0)
                {
                    currString += "Buzz";
                }
                if(string.IsNullOrEmpty(currString))
                {
                    currString = i.ToString();
                }
                answer.Add(currString);
            }
            return answer;
        }
    }
}