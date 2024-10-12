using System.Collections;

namespace CheckIfNumAndDoubleExist
{
    /*
    Given an array arr of integers, check if there exist two indices i and j such that :
    i != j
    0 <= i, j < arr.length
    arr[i] == 2 * arr[j]
    
    Example 1:
    Input: arr = [10,2,5,3]
    Output: true
    Explanation: For i = 0 and j = 2, arr[i] == 10 == 2 * 5 == 2 * arr[j]
    */
    public class Program
    {
        public static void Main(string[] args)
        {
            //Test Case 1:
            int[] arr1 = { 10,2,5,3 };
            System.Console.WriteLine(CheckIfNumAndDoubleExist2(arr1));

            //Test Case 2:
            int[] arr2 = { 3,1,7,11 };
            System.Console.WriteLine(CheckIfNumAndDoubleExist2(arr2));
        }
        public static bool CheckIfNumAndDoubleExist1(int[] arr) //Time Complexity = O(1), storing null value is unnecessary, Hashset is better
        {
            Hashtable hashtable= new Hashtable();

            for(int i = 0; i < arr.Length; i++)
            {
                if(hashtable.ContainsKey(arr[i] * 2) || (arr[i] % 2 == 0 && hashtable.ContainsKey(arr[i] / 2)))
                {
                    return true;
                }
                if(!hashtable.ContainsKey(arr[i])) //Need to control if its exist or it will give error
                {
                    hashtable.Add(arr[i],null);
                }
            }
            return false;
        }
        
        public static bool CheckIfNumAndDoubleExist2(int[] arr) //Time Complexity O(1) , this  method is better. hashset store unique values and no need to key, value.
        {
            HashSet<int> hashset = new HashSet<int>();

            for(int i = 0; i < arr.Length; i++)
            {
                if(hashset.Contains(arr[i] * 2) || (arr[i] % 2 == 0 && hashset.Contains(arr[i] / 2)))
                {
                    return true;
                }
                hashset.Add(arr[i]);
            }
            return false;
        }

    }
}