using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Problem_Solving_and__Algorithm_Study.HackerRank
{
    /// <summary>
    /// Given a 6 by 6 2D Array, arr:
    /// We define an hourglass in A to be a subset of values with indices falling in this pattern in 's graphical representation:
    /// </summary>
    /// 
    class _2DArray_DS
    {
        /***** COMPLETED *****/
        static int hourglassSum(int[][] arr)
        {
            int maxSum = arr[0][0] + arr[0][1] + arr[0][2] + arr[1][1] + arr[2][0] + arr[2][1] + arr[2][2];//Declare and initialize maxSum variable.
            for (int m = 0; m <= arr.Length - 3; m++) //Moving the starting point horizontally
            {
                for (int n = 0; n <= arr.Length - 3; n++) //Moving the starting point vertically
                {
                    int sum = arr[m][n] + arr[m][n + 1] + arr[m][n + 2]
                        + arr[m + 1][n + 1]
                        + arr[m + 2][n] + arr[m + 2][n + 1] + arr[m + 2][n + 2];
                    if(sum>maxSum) //If sum is more than max, replace max with sum
                    {
                        maxSum = sum;
                    }
                }
            }
            return maxSum;
        }

        public static void Test()
        {
            int[][] arr = new int[][] {
                new int[] { 1, 1, 1, 0, 0, 0 },
                new int[] { 0, 1, 0, 0, 0, 0 },
                new int[] { 1, 1, 1, 0, 0, 0 },
                new int[] { 0, 0, 0, 0, 0, 0 },
                new int[] { 0, 0, 0, 0, 0, 0 },
                new int[] { 0, 0, 0, 0, 0, 0 }
            };
            int[][] arr2 = new int[][] {
                new int[] { -9, -9, -9, 1, 1, 1 },
                new int[] { 0, -9, 0, 4, 3, 2 },
                new int[] { -9, -9, -9, 1, 2, 3 },
                new int[] { 0, 0, 8, 6, 6, 0 },
                new int[] { 0, 0, 0, -2, 0, 0 },
                new int[] { 0, 0, 1, 2, 4, 0 }
            };
            int[][] arr3 = new int[][] {
                new int[] { 1, 1, 1, 0, 0, 0 },
                new int[] { 0, 1, 0, 0, 0, 0 },
                new int[] { 1, 1, 1, 0, 0, 0 },
                new int[] { 0, 9, 2, -4, -4, 0 },
                new int[] { 0, 0, 0, -2, 0, 0 },
                new int[] { 0, 0, -1, -2, -4, 0 }
            };
            int[][] arr4 = new int[][] {
                new int[] { -1, -1, 0,-9, -2, -2},
                new int[]{ -2, -1, -6, -8, -2, -5},
                new int[]{ -1, -1, -1, -2, -3, -4},
                new int[]{ -1, -9, -2, -4, -4, -5},
                new int[]{ -7, -3, -3, -2, -9, -9},
                new int[]{ -1, -3, -1, -2, -4, -5},
            };
            Console.WriteLine(hourglassSum(arr));
            Console.WriteLine(hourglassSum(arr2));
            Console.WriteLine(hourglassSum(arr3));
            Console.WriteLine(hourglassSum(arr4));
        }
    }
}
