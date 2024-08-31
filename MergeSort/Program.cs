/*
Given an array of integers, implement the Merge Sort algorithm to sort the array in ascending order. 
Your implementation should have a time complexity of O(n log n) and a space complexity of O(n).

You need to write a function that takes an unsorted integer array and returns a sorted array using the Merge Sort algorithm.
*/

namespace MergeSort
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //Test Case 1
            int[] arr = {38, 27, 43, 3, 9, 82, 10 };
            MergeSort(arr);
            Console.WriteLine(string.Join(", ", arr));
        }

        public static void MergeSort(int[] arr)
        {
            if (arr.Length <= 1)
            {
                return;
            }

            //Find the middle of the array
            int mid = arr.Length/2;

            int[] leftHalf = new int[mid];
            int[] rightHalf = new int[arr.Length - mid];
            
            //Copy the left and right of the arrays to leftHalf and RightHalf arrays
            Array.Copy(arr, 0, leftHalf, 0, mid);
            Array.Copy(arr, mid, rightHalf, 0, arr.Length - mid);

            MergeSort(leftHalf);
            MergeSort(rightHalf);

            Merge(arr, leftHalf, rightHalf);
        }

        public static void Merge(int[] arr, int[] leftHalf, int[] rightHalf)
        {
            int i = 0, j = 0, k = 0;

            while(i < leftHalf.Length && j < rightHalf.Length)
            {
                if(leftHalf[i] <= rightHalf[j])
                {
                    arr[k++] = leftHalf[i++];
                }
                else
                {
                    arr[k++] = rightHalf[j++];
                }
            }

            while(i < leftHalf.Length)
            {
                arr[k++] = leftHalf[i++];
            }

            while(j < rightHalf.Length)
            {
                arr[k++] = rightHalf[j++];
            }
        }
    }
}