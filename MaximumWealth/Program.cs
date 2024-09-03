namespace MaximumWealth
{
    /*
    You are given an m x n integer grid accounts where accounts[i][j] is the amount of money the i​​​​​​​​​​​th​​​​ customer 
    has in the j​​​​​​​​​​​th​​​​ bank. Return the wealth that the richest customer has.

    A customer's wealth is the amount of money they have in all their bank accounts. 
    The richest customer is the customer that has the maximum wealth.

    Example:
    Input: accounts = [[1,5],[7,3],[3,5]]
    Output: 10
    Explanation: 
    1st customer has wealth = 1 + 5 = 6
    2nd customer has wealth = 7 + 3 = 10 
    3rd customer has wealth = 3 + 5 = 8
    The 2nd customer is the richest with a wealth of 10.
    */
    public class Program
    {
        public static void Main(string[] args)
        {
            //Test Case 1
            int[][] accounts1 = new int[][]
            {
                new int[] { 1, 2, 3 },
                new int[] { 3, 2, 1 }
            };
            int output1 = MaximumWealth(accounts1);
            System.Console.WriteLine($"maxValue = {output1}");

            //Test Case 2
            int[][] accounts2 = new int[3][];
            accounts2[0] = new int[] { 1, 5,};
            accounts2[1] = new int[] { 7, 3 };
            accounts2[2] = new int[] { 3, 5 };
            int output2 = MaximumWealth(accounts2);
            System.Console.WriteLine($"maxValue = {output2}");

            //Test Case 3
            int[][] accounts3 = {new int[] { 2, 8, 7 }, new int[] { 7, 1, 3 }, new int[] { 1, 9, 5 }};
            int output3 = MaximumWealth(accounts3);
            System.Console.WriteLine($"maxValue = {output3}");
        }

        public static int MaximumWealth(int[][] accounts)
        {
            int richest = 0;
            for(int i = 0; i < accounts.Length; i++)
            {
                int currentWealth = 0;
                for(int j = 0; j< accounts[i].Length; j++)
                {
                    currentWealth += accounts[i][j];
                }
                richest = Math.Max(richest ,currentWealth);
            }
            return richest;
        }
    }
}