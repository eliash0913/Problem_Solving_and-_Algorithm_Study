using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Problem_Solving_and__Algorithm_Study.HackerRank
{
    class Mini_Max_Sum
    {
        /// <summary>
        /// Given five positive integers, find the minimum and maximum values that can be calculated by summing exactly four of the five integers. 
        /// Then print the respective minimum and maximum values as a single line of two space-separated long integers.
        /// </summary>
        /// <param name="arr"></param>
        static void MiniMaxSum(int[] arr)
        {
            long maxSum = 0;
            long minSum = 0;
            int min = arr[0];
            int max = arr[0];

            for (int i = 1; i < arr.Length; i++)
            {

                if (min < arr[i]) //if true, arr[i] is one of numbers to be added to maximum sum.
                {
                    maxSum += arr[i];
                }
                else //else, min is added to maximum sum because it is bigger number now, and replaced by arr[i]
                {
                    maxSum += min;
                    min = arr[i];
                }


                if (arr[i] < max) //if true, arr[i] is one of minimum numbers to be added to minmum sum.
                {
                    minSum += arr[i];
                }
                else //else, max is added to minimum sum because it is smaller number number, and replaced by arr[i]
                {
                    minSum += max;
                    max = arr[i];
                }
            }
            Console.WriteLine("{0} {1}", minSum, maxSum);
        }
        public static void Test()
        {
            int[] arr = { 1, 2, 3, 4, 5 };
            int[] arr2 = { 3, 1, 5, 4, 2 };
            int[] arr3 = { 2, 3, 1, 4, 5 };
            MiniMaxSum(arr);
            MiniMaxSum(arr2);
            MiniMaxSum(arr3);
        }
    }
}
