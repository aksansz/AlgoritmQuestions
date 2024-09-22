using System.Net.NetworkInformation;

namespace LongestCommonPrefix
{
    /*
    Write a function to find the longest common prefix string amongst an array of strings.
    If there is no common prefix, return an empty string "".

    Example 1:
    Input: strs = ["flower","flow","flight"]
    Output: "fl"

    Example 2:
    Input: strs = ["dog","racecar","car"]
    Output: ""
    Explanation: There is no common prefix among the input strings.
    */
    public class Program
    {
        public static void Main(string[] args)
        {
            //Test Case 1
            string[] strs1 = { "flower", "flow", "flight"};
            string prefix1 = LongestCommonPrefix(strs1);
            System.Console.WriteLine(prefix1);

            string[] strs2 = new string[] { "dog", "rececar","car"};
            string prefix2 = LongestCommonPrefix(strs2);
            System.Console.WriteLine(prefix2);
        }
        public static string LongestCommonPrefix(string[] strs)
        {
            string prefix = strs[0];

            for(int i = 1; i < strs.Length; i++)
            {
                while(strs[i].IndexOf(prefix) != 0)
                {
                    prefix = prefix.Substring(0, prefix.Length - 1);
                }
                if(prefix == "")
                {
                    return "";
                }
            }
            return prefix;
        }
    }
}