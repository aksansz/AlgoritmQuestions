namespace RomanToInteger
{
    /*
    Roman numerals are represented by seven different symbols: I, V, X, L, C, D and M.

    Symbol       Value
    I             1
    V             5
    X             10
    L             50
    C             100
    D             500
    M             1000

    I can be placed before V (5) and X (10) to make 4 and 9. 
    X can be placed before L (50) and C (100) to make 40 and 90. 
    C can be placed before D (500) and M (1000) to make 400 and 900.
    Given a roman numeral, convert it to an integer.

    Example 3:
    Input: s = "MCMXCIV"
    Output: 1994
    Explanation: M = 1000, CM = 900, XC = 90 and IV = 4.
    */
    public class Program
    {
        public static void Main(string[] args)
        {
            //Test Case 1:
            string s1 = "III";
            int total1 = RomanToInteger(s1);
            System.Console.WriteLine(total1);

            //Test Case 2:
            string s2 = "LVIII";
            int total2 = RomanToInteger(s2);
            System.Console.WriteLine(total2);

            //Test Case 3:
            string s3 = "MCMXCIV";
            int total3 = RomanToInteger(s3);
            System.Console.WriteLine(total3);

        }
        public static int RomanToInteger(string s)
        {
            int total = 0;
            Dictionary<char, int> romanToInt = new Dictionary<char, int>()
            {
                { 'M', 1000 },
                { 'D', 500 },
                { 'C', 100 },
                { 'L', 50 },
                { 'X', 10 },
                { 'V', 5 },
                { 'I', 1 }
            };
            for(int i = 0; i < s.Length; i++)
            {
                char currentRoman = s[i];
                int nextRoman = i < s.Length -1 ? romanToInt[s[i+1]] : 0;
                if(nextRoman <= romanToInt[currentRoman])
                {
                    total += romanToInt[currentRoman];
                }
                else{
                    total -= romanToInt[currentRoman];
                }
            }
            return total;
        }
    }
}