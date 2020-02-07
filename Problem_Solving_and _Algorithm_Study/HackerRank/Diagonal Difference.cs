using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Problem_Solving_and__Algorithm_Study.HackerRank
{
    class Diagonal_Difference
    {

        public static int DiagonalDifference(List<List<int>> arr)
        {
            int count = arr.Count;
            int firstDiagonalSum = 0;
            int secondDiagonalSum = 0;
            for (int n = 0; n < count; n++) //in n by n matrix, for both direction of diagonal element which is [i,j] is either i == j or i == -j.
            {
                firstDiagonalSum += arr[n][n]; 
                secondDiagonalSum += arr[count - n - 1][n]; 
            }
            int sum = firstDiagonalSum - secondDiagonalSum;
            if (sum < 0) //if the sum is negative, multiply by -1 to make absolute value.
                sum *= -1;
            return sum;
        }

        public static void Test()
        {
            List<List<int>> arr = new List<List<int>>();
            List<int> r1 = new List<int> { 11, 2, 4 };
            List<int> r2 = new List<int> { 4, 5, 6 };
            List<int> r3 = new List<int> { 10, 8, -12 };
            arr.Add(r1);
            arr.Add(r2);
            arr.Add(r3);
            int result = Diagonal_Difference.DiagonalDifference(arr);

            Console.WriteLine(result);
        }
    }
}
