namespace CanConstruct
{
    /*
    Given two strings ransomNote and magazine, return true if ransomNote can be constructed by using the letters from magazine and false otherwise.
    Each letter in magazine can only be used once in ransomNote.

    Example 1:
    Input: ransomNote = "aa", magazine = "aab"
    Output: true
    Example 2:
    Input: ransomNote = "aa", magazine = "ab"
    Output: false
    */
    public class Program
    {
        public static void Main(string[] args)
        {
            //Test Case 1
            string ransomNote1 = "a", magazine1 = "b";
            bool output1 = CanConstruct_Solution1(ransomNote1, magazine1);
            System.Console.WriteLine(output1);

            //Test Case 2
            string ransomNote2 = "aa", magazine2 = "ab";
            bool output2 = CanConstruct_Solution1(ransomNote2, magazine2);
            System.Console.WriteLine(output2);

            //Test Case 3
            string ransomNote3 = "aba", magazine3 = "aabc";
            bool output3 = CanConstruct_Solution1(ransomNote3, magazine3);
            System.Console.WriteLine(output3);
        }
        public static bool CanConstruct_Solution1(string ransomNote, string magazine)
        {
            if(ransomNote.Length > magazine.Length)
            {
                return false;
            }
            List<char> list = new List<char>(magazine);
            foreach(char c in ransomNote)
            {
                if(list.Contains(c))
                {
                    list.Remove(c);
                }
                else
                {
                    return false;
                }
            }
            return true;
        }
        public static bool CanConstruct_Solution2(string ransomNote, string magazine)
        {
            if(ransomNote.Length > magazine.Length)
            {
                return false;
            }
            Dictionary<char, int> charCount = new Dictionary<char, int>();
            foreach(char c in magazine)
            {
                if(charCount.ContainsKey(c))
                {
                    charCount[c]++;
                }
                else{
                    charCount[c] = 1;
                }
            }
            foreach(char c in ransomNote)
            {
                if(!charCount.ContainsKey(c) || charCount[c] == 0)
                {
                    return false;
                }
                charCount[c]--;
            }
            return true;
        }

    }
}